# Outlanding
Les renseignements fournis le sont a titre indicatif et ne sauraient engager la responsabilite des contributeurs et encore moins celle des proprietaires des champs.
## Download
| Fichier  | Format  | Lien |
|---|---|---|
| Guide des Aires de securite | cup | [guide_aires_securite.cup](https://planeur-net.github.io/outlanding/guide_aires_securite.cup) 
| | cupx | [guide_aires_securite.cupx](https://planeur-net.github.io/outlanding/guide_aires_securite.cupx)  
| | kml | [guide_aires_securite.kml](https://planeur-net.github.io/outlanding/guide_aires_securite.kml) 
| | kmz | [guide_aires_securite.kmz](https://planeur-net.github.io/outlanding/guide_aires_securite.kmz)
||||
| Champs des Alpes | cup | [champs_des_alpes.cup](https://planeur-net.github.io/outlanding/champs_des_alpes.cup)
| | cupx | [champs_des_alpes.cupx](https://planeur-net.github.io/outlanding/champs_des_alpes.cupx)
||||
| Cols des Alpes | cup | [cols_des_alpes.cup](https://planeur-net.github.io/outlanding/cols_des_alpes.cup)
| | cupx | [cols_des_alpes.cupx](https://planeur-net.github.io/outlanding/cols_des_alpes.cupx)
| | kml| [cols_des_alpes.kml](https://planeur-net.github.io/outlanding/cols_des_alpes.kml)
| | kmz| [cols_des_alpes.kmz](https://planeur-net.github.io/outlanding/cols_des_alpes.kmz)
||||
| Montagnes des Alpes | cup | [montagnes_des_alpes.cup](https://planeur-net.github.io/outlanding/montagnes_des_alpes.cup) 

### Mise a jour des fichiers sur Android
<table>
<tr>
<td width=80%>  

Une application Android [GithubDownloader](https://github.com/llauner/AirspaceDownloader) permet de mettre a jours les fichiers dans les bons repertoires pour XCSoar ou SeeYou Navigator en 1 click.  
 Le repo github: https://github.com/llauner/AirspaceDownloader  
 Le fichier .apk: [com.llcs.airspacedownloader.apk](https://github.com/llauner/AirspaceDownloader/releases)

</td>
<td>
<img src="https://github.com/llauner/AirspaceDownloader/raw/master/doc/images/screenshot_main_screen.jpg" alt="drawing" width="97" height=166/>
</td>
</tr>
</table>


## Fichiers de champs "vachables" pour les Alpes
| Fichier  | Commentaire  |
|---|---|
|Guide des Aires de securite| Reprend les aerodromes et champs definis dans le Guide des aires de sécurité dans les Alpes Edition 4.1 Peut cependant contenir des differences liees aux corrections apportees par les contributeurs (altitude, position exacte, ...). [Fiabilite: bonne].
| Champs des Alpes | Autres champs definis par des contributeurs. [Fiabilite: moyenne]
|Cols des Alpes | Cols interessants dans les Alpes
|Montagnes des Alpes | Noms de montagnes dans les Alpes. :warning: Certains noms peuvent etre erronés ou fantaisistes. Merci de participer aux corrections. (Source initiale du fichier a retrouver...)


### Les formats suivants sont maintenus:
- .cup : Le fichier source
- .cupx : Fichier généré automatiquement a partir du .cup et du repertoire /Pics [See: SeeYou cupx file format](./doc/SeeYou_cupx_file_format.md)
- .kml + .kmz : Format Google Earth. Fichier générés automatiquement a partir du .cup
- [XCSoar _details.txt et /pics](#Fichier-_details.txt-pour-XCSoar): Fichiers générés automatiquement

[![Vue Google map du fichier .kmz](doc/images/kmz_googlemap_view_small.png)](doc/images/kmz_googlemap_view.png)

### Fichier _details.txt pour XCSoar
Fichiers générés automatiquement:  
Le fichier *guide_aires_securite.wp_details.txt* ainsi que le repertoire *xcsoar_waipoint_details/pic* permettent d'associer une image a un point (champ, aerodrome, ...).  
Voir l'aide a l'installation:  <a href="https://github.com/planeur-net/outlanding/blob/main/doc/xcsoar_waypoint_details.md" target="_blank">xcsoar_waypoint_details.md</a>  
Et le contenu du <a href="https://github.com/planeur-net/outlanding/tree/main/xcsoar_waypoint_details" target="_blank">repertoire /xcsoar_waypoint_details/</a>
  
 ![Site Files](doc/images/Screenshot_XCSoar_wp_details.png)

### Guide de nommage
La version du guide de reference est indiquee dans la 2e ligne du fichier cup, dans la colonne code.
```
"version=",4.1,,,,,,,,,,"c0007a7 2023-12-15T13:59:33+01:00",,
```
#<num_page> <nom_aero>: Aerodrome. Le code est le code OACI de l'aerodrome  
```
"#60 LFLG Grenoble Versoud",LFLG,FR,4513.150N,00550.950E,220.0m,5,40,890.0m,,"121.000",,,"N090E005LFLG.jpg"
```

<numero_champs> <nom_champs>: Le numero du champs correspond au numero dans le rectangle colore en haut a gauche (ou droite) de la page du champs dans le guide. 
```
"213 Aups",V13,FR,4337.517N,00610.983E,450.0m,3,0,300.0m,,,"Zone cultures",,
```

#### Commentaires
Les commentaires proviennent generalement du guide. A la fin de chaque commentaire est ajoute un "tag" qui permet d'idientifier rapidement la difficulte associee.  
Les "tag" sont:
| Tag  | Commentaire  | Couleur dans le guide | kmz icon|
|---|---|---|---|
|  {aerodrome} | Aerodrome ou aeroport  | blanc | ![](doc/images/runway.png)|
|  {terrain} | Terrain balise (prive) ou piste ULM | blanc | ![](doc/images/windsock.png)|
|  {altiport} | Altiport | blanc | ![](doc/images/altiport.png)|
|  {velisurface} | Velisurface |  |![](doc/images/velisurface.png) |
|  {facile} | Champ sans difficulte particuliere. Adapte a tous les types de machines  | Vert | ![](doc/images/marker_green.png)|
|  {normal} | Champ avec une ou plusieurs difficultes. (Un seul sens, taille reduite, ...) | Orange | ![](doc/images/marker_orange.png)|
|  {difficile} | Champ difficile. Pas forcement utilisable avec les grandes plumes, casse possible, ...  | Rouge | ![](doc/images/marker_red.png)| 
|  {tres_difficile} | Champ tres difficile, a utiliser qu'en ultime recours, casse probable...  | Noir | ![](doc/images/marker_black.png)|
|||||
|  {col} | Col de montagne  |  | ![](doc/images/mountain_pass.png)|

## Copyrights - Droits
Images fournies et utilisées avec l'autorisation de Jérémie Badaroux 