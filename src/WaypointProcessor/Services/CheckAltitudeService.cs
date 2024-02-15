﻿using CoordinateSharp;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaypointProcessor.Models;

namespace WaypointProcessor.Services
{
    /// <summary>
    /// Finds duplicate points between two cup files
    /// </summary>
    internal class CheckAltitudeService(string baseFileName, int distance, string outputFilename)
    {
        private readonly string _baseFilename = baseFileName;
        private readonly int _distance = distance;
        private readonly string _outputFilename = outputFilename;

        private List<AltitudeCheckModel> listAltitudeChecks = [];

        /// <summary>
        /// List duplicates when distance between 2 points <= distance
        /// </summary>
        public void CheckAltitudes()
        {
            // Load waypoints
            var parser = new CsvFileParser();
            var waypointsBase = parser.ParseFile(_baseFilename);

            var lats = new List<double>();
            var lons = new List<double>();

            foreach (var wpBase in waypointsBase)
            {
                lats.Add(wpBase.Lat.DecimalDegree);
                lons.Add(wpBase.Lon.DecimalDegree);
            }

            var latParam = string.Join<double>("|", lats).Replace(",", ".");
            var lonParam = string.Join<double>("|", lons).Replace(",", ".");


            const string url = "https://wxs.ign.fr/calcul/alti/rest/elevation.json";
            var param = new Dictionary<string, string?>() { {"lat", latParam }, { "lon", lonParam }, { "zonly", "true" } };

            var newUrl = new Uri(QueryHelpers.AddQueryString(url, queryString: param));

            var client = new HttpClient();
            var response = client.GetStringAsync(newUrl).GetAwaiter().GetResult();
            var responseModel = JsonSerializer.Deserialize<ElevationResponseModel>(response);

            if (responseModel != null)
                ComputeDelta(waypointsBase, responseModel);
        }

        private void ComputeDelta(List<WaypointModel> waypointsBase, ElevationResponseModel responseModel)
        {
            for (int i = 0; i< waypointsBase.Count; i++)
            {
                WaypointModel currentPoint = waypointsBase[i];
                var altBase = currentPoint.Altitude;
                var altApi = responseModel.elevations[i];
                var delta = altBase - altApi;

                //if (Math.Abs((double)delta) > _distance)
                //{
                listAltitudeChecks.Add(new AltitudeCheckModel
                    {
                        Nom = currentPoint.Name,
                        AltiCup = (int)currentPoint.Altitude,
                        AltiTopo = (int)altApi,
                        Delta = (int)delta
                    });
                //}
            }

            OutputToFile();
        }

        private void OutputToFile()
        {
            Console.WriteLine($"Writing outpout to: {_outputFilename}");
            var header = "| Nom | Alti .cup | Alti API | Delta |";
            var header2 = "|---|---|---|---|";

            using (var outputFile = new StreamWriter(_outputFilename))
            {
                outputFile.WriteLine(header);
                outputFile.WriteLine(header2);
                foreach (AltitudeCheckModel altCheckModel in listAltitudeChecks)
                {
                    var line = altCheckModel.ToMarkDownTableLine();
                    outputFile.WriteLine(line);
                }
                    
            }

        }


    }
}
