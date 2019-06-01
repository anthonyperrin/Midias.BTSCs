--- 
--- In order to make this script work with the LivreTout app, run the script in the "Midias.BTSCs" database.
--- 

--- Categorie table
create table Categorie (
	Id int identity not null primary key,
	Libelle varchar(100)
	);

--- Produit table
create table Produit (
	Id int identity not null primary key,
	Libelle varchar(100),
	PrixHT float default(0),
	Quantite int not null default(0),
	Taxe float default(0),
	IdCategorie int foreign key references Categorie(Id)
	);

--- Mouvement table
create table Mouvement (
	Id int identity not null primary key,
	Quantite int default (0),
	DateCreation datetime not null,
	IdProduit int not null foreign key references Produit(Id)
	);

--- Salarie table
create table Salarie (
	Id int identity not null primary key,
	Nom varchar (255),
	Prenom varchar(255),
	Valide bit not null default(0),
	Permis varchar,
	Email varchar(255),
	Telephone varchar(15)
	);

--- Vehicule table 
create table Vehicule (
	Id int identity not null primary key,
	CarteGrise varchar(10),
	Immatriculation varchar(10),
	Modele varchar(50),
	Marque varchar(50)
	);

--- Adresse table
create table Adresse (
	Id int identity not null primary key,
	Rue1 varchar (255),
	Rue2 varchar (255),
	CodePostal varchar(5),
	Ville varchar(100),
	Pays varchar (255)
	);
	
--- Client table 
create table Client (
	Id int identity not null primary key,
	Nom varchar(100),
	Prenom varchar(100),
	IdAdresse int not null foreign key references Adresse(Id)
	);

--- Commande table
create table Commande (
	Id int identity not null primary key,
	Libelle varchar (255),
	Etat int not null default(0),
	DateCreation datetime not null,
	DateValidation datetime not null,
	IdClient int not null foreign key references Client(Id)
	);

--- Table liaison Commande - Produit
create table ProduitCommande (
	Quantite int not null default(1),
	IdProduit int not null foreign key references Produit(Id),
	IdCommande int not null foreign key references Commande(Id)
	);

--- Livraison table
create table Livraison (
	Id int identity not null primary key,
	DateLivraison datetime,
	IdAdresse int not null foreign key references Adresse(Id),
	IdCommande int not null foreign key references Commande(Id),
	IdSalarie int not null foreign key references Salarie(Id),
	IdVehicule int not null foreign key references Vehicule(Id)
	);