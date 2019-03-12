USE Stock
GO

INSERT INTO 
[dbo].[produit]
 ([nom], [reference], [description], [prix], [quantite], [image], [id_categorie]) 
 Values 
--('Ford Mustang Fastback Mach 1 1969','FM1969','Rouge',20000,2,'image_mustang_rouge',3),
('Dodge Charger 2018','DC2018','Noire',32000,3,'image_charger_noire',3),
('Chevrolet Camaro SS 1969','CCSS1969','Noire',26000,5,'image_camaro_noire',3),
('Mazda mx-5 2018','MMX52018','Rouge',25000,2,'image_mx5_rouge',3),
('BMW i8 2015','BMWI82015','Noire et Blanche, Hybride',80000,2,'image_i8_noire_blanche',3),
('Mercedes AMG GT 2017','AMGGT2017','Jaune',100000,3,'image_AMGGT_jaune',3),
('Aston Martin DB9 2006','AMDB92006','Bordeaux',60000,4,'image_DB9_bordeaux',3),

('Smart Fortwo II 2007','SF2007','Rouge',8000,4,'image_fortwo_rouge',2),
('Renault Twingo II 2007','RT2007','Bleue',11000,3,'image_twingo_bleue',2),
('Alfa Romeo Mito 2008','ARM2008','Rouge',15000,4,'image_mito_rouge',2),
('Peugeot 206+ 2009','P2009','Blanche',10000,5,'image_206_blanche',2),
('Fiat 500 Collezione 2018','FC2018','Noire',16000,2,'image_fiat500_noire',2),
('Audi A1 Quattro 2010','AA1Q2010','Grise',18000,6,'image_audia1q_grise',2),
('BMW I3 2017', 'BMWI32017','Noire et Bleue, Hybride',40000,4,'image_bmwi3_noire_bleue',2),

('BMW Serie 5 2010','S52010','Grise',21000,2,'image_serie5_grise',1),
 ('Volvo S60 2015','FM1969','Grise',22000,5,'image_s60_grise',1),
 ('Renault Talisman 2014','RT2014','Noire',19000,3,'image_talisman_noire',1),
 ('Mercedes Classe A 2014','MCA2014','Grise',27000,4,'image_classea_grise',1),
 ('Renault Talisman 2015','RT2015','Grise',20000,2,'image_talisman_Grise',1),
 ('Peugeot 508 2018','P5082018','Rouge',35000,2,'image_508_rouge',1),
 ('Ford Mondéo 2008','FM2008','Bleue',14000,3,'image_mondéo_bleue',1);