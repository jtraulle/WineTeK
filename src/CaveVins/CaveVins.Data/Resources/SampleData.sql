-- On nettoie les données précédentes
DELETE FROM T_BOUTEILLE_BTL
DELETE FROM T_COULEUR_CLR
DELETE FROM T_FLACONNAGE_FCG
DELETE FROM T_CHATEAU_CHT
DELETE FROM T_APPELLATION_APT
DELETE FROM T_REGION_REG
DELETE FROM T_PAYS_PAY


-- On insert les données
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('FRA','France')
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('ITA','Italie')
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('ESP','Espagne')
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('USA','USA')
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('AUS','Australie')
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('ARG','Argentine')
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('DEU','Allemagne')
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('PRT','Portugal')
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('CHL','Chili')
INSERT INTO T_PAYS_PAY (PAY_C_CODE, PAY_S_NOM) VALUES('ZAF','Afrique du Sud')

INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('ALS','FRA','Alsace')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('LOR','FRA','Lorraine')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('BJL','FRA','Beaujolais')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('LYO','FRA','Lyonnais')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('BOR','FRA','Bordeaux')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('BRG','FRA','Bourgogne')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('CHP','FRA','Champagne')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('JUR','FRA','Jura')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('SAV','FRA','Savoie')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('LGD','FRA','Languedoc')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('RSL','FRA','Roussillon')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('LCT','FRA','Loire - Centre')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('PRV','FRA','Provence')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('CRS','FRA','Corse')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('SDO','FRA','Sud Ouest')
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('VDR','FRA','Vallée du Rhône')

declare @RougeM int
declare @BlancN int
declare @BlancM int

INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Rouge finesse')
INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Rouge tendresse')
INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Rouge massif')
Set @RougeM = @@IDENTITY
INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Blanc opulent')
INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Blanc nerveux')
Set @BlancN = @@IDENTITY
INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Alcool')
INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Blanc moelleux')
Set @BlancM = @@IDENTITY
INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Fortifie')
INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Fines bulles')
INSERT INTO T_COULEUR_CLR (CLR_S_NOM) VALUES('Rose')

declare @flacBout int
declare @flacMag int
declare @flacJer int

INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Mignonette',5)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Quart',20)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Demi-bouteille',35)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('demi-bouteille',37)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('bouteille',50)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('bouteille',70)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('bouteille',75)
Set @flacBout = @@IDENTITY
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('4 Quarts',80)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Magnum',150)
Set @flacMag = @@IDENTITY
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Jeroboam / Dble Magnum',300)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Jeroboam',500)
Set @flacJer = @@IDENTITY
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Mathusalem / Imperiale',600)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Salmanazar',900)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Balthazar',1200)
INSERT INTO T_FLACONNAGE_FCG (FCG_S_NOM, FCG_R_CONTENANCE) VALUES('Nabuchodonosor',1500)

INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('ALS','Alsace')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('ALS','Alsace Grand Cru')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('ALS','Crémant d''Alsace')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('LOR','Côtes de Toul')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('LOR','VDQS Moselle')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Beaujolais')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Beaujolais Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Brouilly')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Chénas')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Chiroubles')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Côte de Brouilly')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Fleurie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Juliénas')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Morgon')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Moulin à Vent')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Régnié')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Saint Amour')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('LYO','Coteaux du Lyonnais')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Blaye')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Côtes de Blaye')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Côtes de Bordeaux Blaye')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Premières Côtes de Blaye')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Bordeaux supérieur')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Côtes de Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Crémant de Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Premières Côtes de Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Côtes de Bourg')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Cadillac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Côtes de Bordeaux Cadillac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Côtes de Bordeaux-Saint-Macaire')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Entre-deux-Mers')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Graves de Vayre')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Loupiac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Sainte Croix du Mont')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Sainte-Foy Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Graves')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Graves supérieures')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Pessac-Léognan')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Canon-Fronsac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Côtes de Bordeaux Castillon')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Côtes de Bordeaux Francs')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Fronsac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Haut Médoc')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Listrac-Médoc')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Margaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Médoc')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Moulis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Pauillac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint Estèphe')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint Julien')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Lalande de Pomerol')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Néac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Pomerol')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Lussac-Saint Émilion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Montagne-Saint Émilion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Puisseguin-Saint Émilion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint Émilion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint Émilion Grand cru')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint Georges Saint Emilion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Barsac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Cérons')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Sauternes')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne aligoté')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Clairet ou Bourgogne Rosé')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne grand ordinaire ou Bourgogne ordinaire')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne mousseux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Passe-tout-grains')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Crémant de Bourgogne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chablis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chablis Grand cru')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chablis Premier cru')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Petit Chablis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Côte Chalonnaise')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Côtes du Couchois')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bouzeron')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Givry')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Mercurey')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Montagny')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Rully')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Aloxe-Corton')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Auxey-Duresses')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bâtard-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bienvenues-Bâtard-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Blagny')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Hautes Côtes de Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne La Chapelle Notre Dame')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Charlemagne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chassagne-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chevalier-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chorey les Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Corton')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Corton-Charlemagne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Côte de Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Côte de Beaune-Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Criots-Bâtard-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Ladoix')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Maranges')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Meursault')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Monthélie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pernand Vergelesses')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pommard')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Puligny Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Saint-Aubin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Saint-Romain')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Santenay')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Savigny-lès-Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Volnay')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bonnes-Mares')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Hautes Côtes de Nuits')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Le Chapitre')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Montrecul')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chambertin Clos de Bèze')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chambolle-Musigny')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chapelle Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Charmes Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos de la Roche')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos de Tart')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos des Lambrays')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos Saint-Denis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos Vougeot')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Côte de Nuits-Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Échezeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Fixin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Gevrey-Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Grands Échezeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Griotte Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','La Grande Rue')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','La Romanée')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','La Tâche')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Latricières Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Marsannay')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Mazis Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Mazoyères Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Morey-Saint-Denis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Musigny')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Nuits ou Nuits-Saint-Georges')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Richebourg')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Romanée Conti')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Romanée Saint Vivant')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Ruchottes Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Vosne-Romanée')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Vougeot')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Mâcon et Mâcon Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Mâcon suivi d''un nom de commune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pouilly-Fuissé')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pouilly-Loché')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pouilly-Vinzelles')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Saint-Véran')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Viré-Clessé')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Chitry')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Côte Saint-Jacques')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Côtes d''Auxerre')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Coulanges-la-Vineuse')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Épineuil')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Tonnerre')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Vézelay')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Irancy')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Saint Bris')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('CHP','Champagne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('CHP','Champagne Grand Cru ou PremierCru')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('CHP','Coteaux Champenois')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('CHP','Rosé des Riceys')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Arbois')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Arbois Pupillin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Château-Chalon')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Côtes du Jura')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Crémant du Jura')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','L''Étoile')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Macvin du Jura')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Bugey')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Roussette de Savoie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Roussette du Bugey')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Seyssel')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Vin de Savoie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Beaumes de Venise')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Châteauneuf du Pape')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Costières de Nîmes')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Coteaux du Tricastin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Côtes du Rhône régional')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Côtes du Rhône Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Côtes du Vivarais')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Gigondas')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Lirac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Luberon')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Muscat de Beaumes de Venise')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Rasteau')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Tavel')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Vacqueyras')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Ventoux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Vinsobres')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Château Grillet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Châtillon en Diois')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Clairette de Die')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Condrieu')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Cornas')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Côte Rôtie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Coteaux de Die')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Côtes du Rhône régional')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Crémant de Die')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Crozes-Hermitage')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Hermitage')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Saint Joseph')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Saint Péray')


declare @appellation int
declare @chateau bigint

SELECT @appellation=APT_I_ID
FROM T_APPELLATION_APT (nolock)
WHERE APT_S_NOM = 'Pessac-Léognan'

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Château Carbonnieux', 'Fondé au XIIIème siècle, le château Carbonnieux est un domaine viticole qui fait partit du paysage historique de Léognan. Étant situé en AOC Pessac-Léognan, il est classé grand cru dans le classement des vins de Graves. Ce domaine, répartit sur plus de 50 hectares, fait partit des exceptions bordelaises en terme de sa morphologie et de la diversité de ses sols. L''encépagement est composé par le cabernet sauvignon (60%), le merlot (30%), le cabernet franc (7%)et, le petit verdot et la carmenère (3%). L''interaction des facteurs naturels (géographie, cépages, exposition, sols...) apporte au terroir de Carbonnieux des conditions de grande précocité, et il est l''un des premiers domaines à débuter ses vendanges en terre girondine.')

Set @chateau = @@Identity

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2000, 60, 90)
INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacMag, @chateau, @RougeM,2000, 140, 200)
INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancN,2006, 35, 40)

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Château Haut-Brion', 'Château Haut-Brion est le plus ancien et, pourtant, le plus petit en taille des vignobles classés "Premiers Grands Crus" en 1855. Bien que le vignoble de Haut-Brion ait été présent dans la région depuis au moins l''époque romaine, la première mention du vignoble de Haut-Brion ne date que de 1423, selon les recherches effectuées. Dans les premiers temps, les vins étaient connus sous le nom des paroisses d''où ils étaient issus. Dans le cas de Haut-Brion, sous la direction éclairée des Pontac, le vin porta d''abord le nom de cette noble et respectable famille. Puis, sa réputation grandissant, le nom du domaine en vint à remplacer celui de ses propriétaires pour devenir le Château Haut-Brion. La notion de Grand Cru est née ! Nous en trouvons la première mention dans le journal de Samuel Pepys qui écrit le 10 avril 1663 : " Je viens de déguster un vin français nommé Ho-Bryan (Haut-Brion) qui a le goût le meilleur et le plus spécial que j''ai jamais rencontré... ".')

Set @chateau = @@Identity
INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2006, 450, 500)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2007, 400, 440)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2009, 1000, 1100)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacJer, @chateau, @RougeM,2009, 6900, 8000)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2004, 500, 550)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancN,2005, 930, 980)

SELECT @appellation=APT_I_ID
FROM T_APPELLATION_APT (nolock)
WHERE APT_S_NOM = 'Margaux'

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Château Palmer', 'Le vignoble bordelais est un fabuleux livre d’histoires, comme celle du grand Château Palmer, d’abord propriété du major-général Palmer qui, passionné, y laissa sa fortune, puis des frères Péreire, richissimes banquiers-entrepreneurs perdus par la crise de 1930 qui édifièrent le château actuel. Plusieurs familles de négociants bordelais s''unirent alors pour reformer le domaine composé aujourd''hui de @BlancN ha d''une croupe de graves garonnaises surplombant la Gironde. Merlot, Cabernet Sauvignon et Petit Verdot y deviennent fruits, fleurs et épices, finesse, densité et élégance d''une grande complexité.')

Set @chateau = @@Identity

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2007, 200, 240)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2009, 410, 470)

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Château Margaux', 'Margaux cultive, comme aucune autre propriété au monde, le culte de l’élégance. Rien n’existe à Margaux qui ne soit le fruit d’une extrême volonté de raffinement. Bien sûr, l’enchantement commence lorsqu’au détour du chemin droit et simple qui longe le cimetière de Margaux où l’on découvre la splendide allée de platanes. Les cours intérieures, les bâtiments de travail et les chais de Margaux n’ont jamais été bousculé par une refonte spectaculaire comme c’est souvent le cas dans le Médoc. Le rachat du Château Margaux par André Mentzelopoulos en 1977 a permit un redressement aussi rapide que spectaculaire du vignoble de Margaux. Ce brillant travail est animé et poursuivit par sa fille Corinne et par l’excellent directeur Paul Pontalier. Margaux a ainsi redéfini les canons du grand Bordeaux élégant : svelte, élancé, mais jamais maigre et doté d’une structure de satin comme d’acier. Le Margaux est brillant et long et offre un bouquet d’une incomparable fraîcheur. Le Château Margaux propose également un blanc d’une extraordinaire qualité (Pavillon Blanc), de même qu’un deuxième vin de très grande classe (Pavillon Rouge).')

Set @chateau = @@Identity

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,1997, 450, 500)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacMag, @chateau, @RougeM,1997, 950, 1050)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2006, 620, 650)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2008, 730, 760)

SELECT @appellation=APT_I_ID
FROM T_APPELLATION_APT (nolock)
WHERE APT_S_NOM = 'Sauternes'

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Château Lafaurie-Peyraguey', '"Peyraguey" vient du mot "Pey" qui signifiait "colline dégagée". A cette situation privilégiée s''ajoute un micro-climat particulièrement favorable au développement du "Botrytis Cinerea", champignon grâce auquel la pourriture noble se développe sur les baies de raisins. Le Château Lafaurie-Peyraguey est aujourd''hui la propriété du Domaine Cordier, acteur majeur dans le bordelais.')

Set @chateau = @@Identity

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancM,2003, 45, 60)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancM,2005, 40, 60)

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Château d''Yquem', 'Yquem... Vin parmi les vins. Supérieur! A la fois noble et altier, cet adjectif appliqué à Yquem depuis 1855 est un pléonasme tant il paraît évident qu''Yquem est, a été, et restera l''unique Premier Cru Supérieur de Bordeaux. Pléonasme aussi lorsque l''on se trouve face à ce colosse de liqueur, monstre d''ampleur, dont la confection relève plus de l''art que de la production. D''or par sa couleur, de soie par sa texture, de safran par son bouquet et de sucres par ses saveurs, Yquem a dépassé le "supérieur". Il est incomparable, distingué, éminent et transcendant. Noble de robe et d''épée, il est Vin parmi les vins.')

Set @chateau = @@Identity

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancM, 1892, 45000, 46000)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancM, 1896, 30000, 33000)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancM, 1924, 5900, 6000)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancM, 1975, 1500, 1700)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancM, 1988, 580, 620)


SELECT @appellation=APT_I_ID
FROM T_APPELLATION_APT (nolock)
WHERE APT_S_NOM = 'Pomerol'

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Petrus', 'Pétrus est l’un des seuls Bordeaux à ne pas accoler à son nom le vocable de Château, puisque de château il n’y a point. Ni même de maison ! Un chai, reconstitué récemment, marque simplement la présence du cru de Pétrus. Au-delà de tout c’est son terroir qui a construit la réputation de Pétrus. Constitué essentiellement d’un plateau qui s’étend au nord-est de Libourne et jusqu’à la limite ouest de Saint-Emilion, Pétrus est issu de Pomerol, une appellation presque plane et apparemment homogène. Le sous-sol de Pétrus est presque entièrement composé d’une veine d’argile bleue, qui maintient les racines des merlots qui y sont plantés dans une bienfaisante et permanente fraîcheur. Aussi, précoces et ne souffrant jamais de stress hydrique, les raisins de Pétrus arrivent au chai tôt et parfaitement mûrs. Autrefois, Pétrus était un vin légendaire par sa sève capiteuse ; aujourd’hui, c’est la perfection formelle de son onctuosité qui épate.')

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM, 1981, 1800, 1900)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacMag, @chateau, @RougeM, 1983, 2200, 2300)