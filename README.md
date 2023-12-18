# outlanding
Les renseignements fournis le sont a titre indicatif et ne sauraient engager la responsabilite des contributeurs et encore moins celle des proprietaires des champs.
## Download
[guide_aires_securite.cup](https://planeur-net.github.io/outlanding/guide_aires_securite.cup)  
[guide_aires_securite.cupx](https://planeur-net.github.io/outlanding/guide_aires_securite.cupx)  

[guide_aires_securite.kml](https://planeur-net.github.io/outlanding/guide_aires_securite.kml)  
[guide_aires_securite.kmz](https://planeur-net.github.io/outlanding/guide_aires_securite.kmz)
## Fichiers de champs "vachables" pour les Alpes
Les fichiers suivants sont maintenus:
- .cup : Champs et aerodromes du Guide des aires de sécurité dans les Alpes Edition 4.1
- .cupx : Fichier généré automatiquement a partir du .cup et du repertoire /Pics [See: SeeYou cupx file format](./SeeYou_cupx_file_format.md)
- .kml + .kmz : Format Google Earth. Fichier générés automatiquement a partir du .cup 

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
| Tag  | Comment  | Couleur dans le guide |
|---|---|---|
|  {aerodrome} | Aerodrome ou aeroport  | blanc |
|  {terrain} | Terrain balise (prive) ou piste ULM | blanc |
|  {altiport} | Altiport | blanc |
|  {velisurface} | Velisurface |  |
|  {facile} | Champ sans difficulte particuliere. Adapte a tous les types de machines  | Vert |
|  {normal} | Champ avec une ou plusieurs difficultes. (Un seul sens, taille reduite, ...) | Orange |
|  {difficile} | Champ difficile. Pas forcement utilisable avec les grandes plumes, casse possible, ...  | Rouge |
|  {tres_difficile} | Champ tres difficile, a utiliser qu'en ultime recours, casse probable...  | Noir |

## Copyrights - Droits
Images fournies et utilisées avec l'autorisation de Jérémie Badaroux 