-- On nettoie les données précédentes
ALTER DATABASE Cave_Vins SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE Cave_Vins;
