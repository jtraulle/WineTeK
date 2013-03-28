-- On nettoie les donn�es pr�c�dentes
DELETE FROM T_BOUTEILLE_BTL
DELETE FROM T_COULEUR_CLR
DELETE FROM T_FLACONNAGE_FCG
DELETE FROM T_CHATEAU_CHT
DELETE FROM T_APPELLATION_APT
DELETE FROM T_REGION_REG
DELETE FROM T_PAYS_PAY


-- On insert les donn�es
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
INSERT INTO T_REGION_REG (REG_C_CODE, PAY_C_CODE, REG_S_NOM) VALUES('VDR','FRA','Vall�e du Rh�ne')

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
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('ALS','Cr�mant d''Alsace')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('LOR','C�tes de Toul')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('LOR','VDQS Moselle')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Beaujolais')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Beaujolais Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Brouilly')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Ch�nas')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Chiroubles')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','C�te de Brouilly')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Fleurie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Juli�nas')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Morgon')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Moulin � Vent')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','R�gni�')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BJL','Saint Amour')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('LYO','Coteaux du Lyonnais')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Blaye')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','C�tes de Blaye')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','C�tes de Bordeaux Blaye')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Premi�res C�tes de Blaye')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Bordeaux sup�rieur')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','C�tes de Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Cr�mant de Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Premi�res C�tes de Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','C�tes de Bourg')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Cadillac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','C�tes de Bordeaux Cadillac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','C�tes de Bordeaux-Saint-Macaire')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Entre-deux-Mers')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Graves de Vayre')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Loupiac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Sainte Croix du Mont')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Sainte-Foy Bordeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Graves')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Graves sup�rieures')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Pessac-L�ognan')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Canon-Fronsac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','C�tes de Bordeaux Castillon')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','C�tes de Bordeaux Francs')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Fronsac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Haut M�doc')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Listrac-M�doc')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Margaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','M�doc')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Moulis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Pauillac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint Est�phe')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint Julien')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Lalande de Pomerol')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','N�ac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Pomerol')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Lussac-Saint �milion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Montagne-Saint �milion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Puisseguin-Saint �milion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint �milion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint �milion Grand cru')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Saint Georges Saint Emilion')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Barsac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','C�rons')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BOR','Sauternes')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne aligot�')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Clairet ou Bourgogne Ros�')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne grand ordinaire ou Bourgogne ordinaire')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne mousseux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Passe-tout-grains')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Cr�mant de Bourgogne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chablis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chablis Grand cru')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chablis Premier cru')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Petit Chablis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne C�te Chalonnaise')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne C�tes du Couchois')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bouzeron')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Givry')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Mercurey')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Montagny')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Rully')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Aloxe-Corton')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Auxey-Duresses')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','B�tard-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bienvenues-B�tard-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Blagny')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Hautes C�tes de Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne La Chapelle Notre Dame')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Charlemagne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chassagne-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chevalier-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chorey les Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Corton')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Corton-Charlemagne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','C�te de Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','C�te de Beaune-Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Criots-B�tard-Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Ladoix')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Maranges')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Meursault')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Month�lie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pernand Vergelesses')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pommard')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Puligny Montrachet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Saint-Aubin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Saint-Romain')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Santenay')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Savigny-l�s-Beaune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Volnay')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bonnes-Mares')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Hautes C�tes de Nuits')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Le Chapitre')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Montrecul')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chambertin Clos de B�ze')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chambolle-Musigny')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Chapelle Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Charmes Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos de la Roche')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos de Tart')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos des Lambrays')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos Saint-Denis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Clos Vougeot')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','C�te de Nuits-Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','�chezeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Fixin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Gevrey-Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Grands �chezeaux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Griotte Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','La Grande Rue')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','La Roman�e')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','La T�che')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Latrici�res Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Marsannay')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Mazis Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Mazoy�res Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Morey-Saint-Denis')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Musigny')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Nuits ou Nuits-Saint-Georges')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Richebourg')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Roman�e Conti')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Roman�e Saint Vivant')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Ruchottes Chambertin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Vosne-Roman�e')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Vougeot')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','M�con et M�con Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','M�con suivi d''un nom de commune')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pouilly-Fuiss�')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pouilly-Loch�')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Pouilly-Vinzelles')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Saint-V�ran')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Vir�-Cless�')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Chitry')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne C�te Saint-Jacques')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne C�tes d''Auxerre')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Coulanges-la-Vineuse')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne �pineuil')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne Tonnerre')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Bourgogne V�zelay')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Irancy')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('BRG','Saint Bris')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('CHP','Champagne')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('CHP','Champagne Grand Cru ou PremierCru')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('CHP','Coteaux Champenois')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('CHP','Ros� des Riceys')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Arbois')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Arbois Pupillin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Ch�teau-Chalon')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','C�tes du Jura')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Cr�mant du Jura')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','L''�toile')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('JUR','Macvin du Jura')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Bugey')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Roussette de Savoie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Roussette du Bugey')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Seyssel')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('SAV','Vin de Savoie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Beaumes de Venise')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Ch�teauneuf du Pape')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Costi�res de N�mes')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Coteaux du Tricastin')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','C�tes du Rh�ne r�gional')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','C�tes du Rh�ne Villages')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','C�tes du Vivarais')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Gigondas')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Lirac')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Luberon')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Muscat de Beaumes de Venise')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Rasteau')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Tavel')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Vacqueyras')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Ventoux')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Vinsobres')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Ch�teau Grillet')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Ch�tillon en Diois')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Clairette de Die')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Condrieu')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Cornas')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','C�te R�tie')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Coteaux de Die')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','C�tes du Rh�ne r�gional')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Cr�mant de Die')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Crozes-Hermitage')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Hermitage')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Saint Joseph')
INSERT INTO T_APPELLATION_APT (REG_C_CODE, APT_S_NOM) VALUES ('VDR','Saint P�ray')


declare @appellation int
declare @chateau bigint

SELECT @appellation=APT_I_ID
FROM T_APPELLATION_APT (nolock)
WHERE APT_S_NOM = 'Pessac-L�ognan'

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Ch�teau Carbonnieux', 'Fond� au XIII�me si�cle, le ch�teau Carbonnieux est un domaine viticole qui fait partit du paysage historique de L�ognan. �tant situ� en AOC Pessac-L�ognan, il est class� grand cru dans le classement des vins de Graves. Ce domaine, r�partit sur plus de 50 hectares, fait partit des exceptions bordelaises en terme de sa morphologie et de la diversit� de ses sols. L''enc�pagement est compos� par le cabernet sauvignon (60%), le merlot (30%), le cabernet franc (7%)et, le petit verdot et la carmen�re (3%). L''interaction des facteurs naturels (g�ographie, c�pages, exposition, sols...) apporte au terroir de Carbonnieux des conditions de grande pr�cocit�, et il est l''un des premiers domaines � d�buter ses vendanges en terre girondine.')

Set @chateau = @@Identity

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2000, 60, 90)
INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacMag, @chateau, @RougeM,2000, 140, 200)
INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancN,2006, 35, 40)

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Ch�teau Haut-Brion', 'Ch�teau Haut-Brion est le plus ancien et, pourtant, le plus petit en taille des vignobles class�s "Premiers Grands Crus" en 1855. Bien que le vignoble de Haut-Brion ait �t� pr�sent dans la r�gion depuis au moins l''�poque romaine, la premi�re mention du vignoble de Haut-Brion ne date que de 1423, selon les recherches effectu�es. Dans les premiers temps, les vins �taient connus sous le nom des paroisses d''o� ils �taient issus. Dans le cas de Haut-Brion, sous la direction �clair�e des Pontac, le vin porta d''abord le nom de cette noble et respectable famille. Puis, sa r�putation grandissant, le nom du domaine en vint � remplacer celui de ses propri�taires pour devenir le Ch�teau Haut-Brion. La notion de Grand Cru est n�e ! Nous en trouvons la premi�re mention dans le journal de Samuel Pepys qui �crit le 10 avril 1663 : " Je viens de d�guster un vin fran�ais nomm� Ho-Bryan (Haut-Brion) qui a le go�t le meilleur et le plus sp�cial que j''ai jamais rencontr�... ".')

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
VALUES (@appellation, 'Ch�teau Palmer', 'Le vignoble bordelais est un fabuleux livre d�histoires, comme celle du grand Ch�teau Palmer, d�abord propri�t� du major-g�n�ral Palmer qui, passionn�, y laissa sa fortune, puis des fr�res P�reire, richissimes banquiers-entrepreneurs perdus par la crise de 1930 qui �difi�rent le ch�teau actuel. Plusieurs familles de n�gociants bordelais s''unirent alors pour reformer le domaine compos� aujourd''hui de @BlancN ha d''une croupe de graves garonnaises surplombant la Gironde. Merlot, Cabernet Sauvignon et Petit Verdot y deviennent fruits, fleurs et �pices, finesse, densit� et �l�gance d''une grande complexit�.')

Set @chateau = @@Identity

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2007, 200, 240)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM,2009, 410, 470)

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Ch�teau Margaux', 'Margaux cultive, comme aucune autre propri�t� au monde, le culte de l��l�gance. Rien n�existe � Margaux qui ne soit le fruit d�une extr�me volont� de raffinement. Bien s�r, l�enchantement commence lorsqu�au d�tour du chemin droit et simple qui longe le cimeti�re de Margaux o� l�on d�couvre la splendide all�e de platanes. Les cours int�rieures, les b�timents de travail et les chais de Margaux n�ont jamais �t� bouscul� par une refonte spectaculaire comme c�est souvent le cas dans le M�doc. Le rachat du Ch�teau Margaux par Andr� Mentzelopoulos en 1977 a permit un redressement aussi rapide que spectaculaire du vignoble de Margaux. Ce brillant travail est anim� et poursuivit par sa fille Corinne et par l�excellent directeur Paul Pontalier. Margaux a ainsi red�fini les canons du grand Bordeaux �l�gant : svelte, �lanc�, mais jamais maigre et dot� d�une structure de satin comme d�acier. Le Margaux est brillant et long et offre un bouquet d�une incomparable fra�cheur. Le Ch�teau Margaux propose �galement un blanc d�une extraordinaire qualit� (Pavillon Blanc), de m�me qu�un deuxi�me vin de tr�s grande classe (Pavillon Rouge).')

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
VALUES (@appellation, 'Ch�teau Lafaurie-Peyraguey', '"Peyraguey" vient du mot "Pey" qui signifiait "colline d�gag�e". A cette situation privil�gi�e s''ajoute un micro-climat particuli�rement favorable au d�veloppement du "Botrytis Cinerea", champignon gr�ce auquel la pourriture noble se d�veloppe sur les baies de raisins. Le Ch�teau Lafaurie-Peyraguey est aujourd''hui la propri�t� du Domaine Cordier, acteur majeur dans le bordelais.')

Set @chateau = @@Identity

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancM,2003, 45, 60)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @BlancM,2005, 40, 60)

INSERT INTO T_CHATEAU_CHT (APT_I_ID, CHT_S_CHATEAU, CHT_T_DESCRIPTION)
VALUES (@appellation, 'Ch�teau d''Yquem', 'Yquem... Vin parmi les vins. Sup�rieur! A la fois noble et altier, cet adjectif appliqu� � Yquem depuis 1855 est un pl�onasme tant il para�t �vident qu''Yquem est, a �t�, et restera l''unique Premier Cru Sup�rieur de Bordeaux. Pl�onasme aussi lorsque l''on se trouve face � ce colosse de liqueur, monstre d''ampleur, dont la confection rel�ve plus de l''art que de la production. D''or par sa couleur, de soie par sa texture, de safran par son bouquet et de sucres par ses saveurs, Yquem a d�pass� le "sup�rieur". Il est incomparable, distingu�, �minent et transcendant. Noble de robe et d''�p�e, il est Vin parmi les vins.')

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
VALUES (@appellation, 'Petrus', 'P�trus est l�un des seuls Bordeaux � ne pas accoler � son nom le vocable de Ch�teau, puisque de ch�teau il n�y a point. Ni m�me de maison ! Un chai, reconstitu� r�cemment, marque simplement la pr�sence du cru de P�trus. Au-del� de tout c�est son terroir qui a construit la r�putation de P�trus. Constitu� essentiellement d�un plateau qui s��tend au nord-est de Libourne et jusqu�� la limite ouest de Saint-Emilion, P�trus est issu de Pomerol, une appellation presque plane et apparemment homog�ne. Le sous-sol de P�trus est presque enti�rement compos� d�une veine d�argile bleue, qui maintient les racines des merlots qui y sont plant�s dans une bienfaisante et permanente fra�cheur. Aussi, pr�coces et ne souffrant jamais de stress hydrique, les raisins de P�trus arrivent au chai t�t et parfaitement m�rs. Autrefois, P�trus �tait un vin l�gendaire par sa s�ve capiteuse ; aujourd�hui, c�est la perfection formelle de son onctuosit� qui �pate.')

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacBout, @chateau, @RougeM, 1981, 1800, 1900)

INSERT INTO T_BOUTEILLE_BTL (FCG_I_ID, CHT_I_ID , CLR_I_ID, BTL_I_MILLESIME, BTL_R_PRIXBAS, BTL_R_PRIXHAUT)
VALUES(@flacMag, @chateau, @RougeM, 1983, 2200, 2300)