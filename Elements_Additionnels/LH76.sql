/*------------------------------------------------------------
*        Script SQLSERVER 
------------------------------------------------------------*/


/*------------------------------------------------------------
-- Table: categorie
------------------------------------------------------------*/
USE Stock
GO

CREATE TABLE categorie(
	id          INT IDENTITY (1,1) ,
	categorie   NVARCHAR (255) NOT NULL  ,
	CONSTRAINT categorie_PK PRIMARY KEY (id)
);


/*------------------------------------------------------------
-- Table: produit
------------------------------------------------------------*/
CREATE TABLE produit(
	id             INT IDENTITY (1,1) NOT NULL ,
	nom            NVARCHAR (255) NOT NULL ,
	reference      NVARCHAR (50) NOT NULL ,
	description    TEXT  NOT NULL ,
	prix           REAL  NOT NULL ,
	quantite       INT  NOT NULL ,
	image          NVARCHAR (MAX) NOT NULL ,
	id_categorie   INT  NOT NULL  ,
	CONSTRAINT produit_PK PRIMARY KEY (id)

	,CONSTRAINT produit_categorie_FK FOREIGN KEY (id_categorie) REFERENCES categorie(id)
);
