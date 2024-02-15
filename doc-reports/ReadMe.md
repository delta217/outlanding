# Content
This folder is hosting reports generated by automation tools

## VerifAlti
`./VerifAlti --topo ./Alpes_FR_2.trn --summary --error 50 --warning 100 --cup ../cols_des_alpes.cup --md out.md`

This is checking altitude against a topographic file and generate a report.
Exit status:  
0 = OK  
2 = Erreur ligne de commande  
4 = warnings  
8 = erreurs