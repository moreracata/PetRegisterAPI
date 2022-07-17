CREATE DATABASE PetRegister


USE PetRegister

CREATE TABLE Provincia(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ProvinciaId INT NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	CreatedBy  VARCHAR(100),
	CreationDate DATE NOT NULL,
	EditionDate DATE NOT NULL,
	
);

CREATE TABLE Canton(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	CantonId INT NOT NULL,
	ProvinciaId INT NOT NULL,
	Nombre VARCHAR(100) NOT NULL ,
	CreatedBy  VARCHAR(100),
	CreationDate DATE NOT NULL,
	EditionDate DATE NOT NULL,
	
	FOREIGN KEY (ProvinciaId) REFERENCES Provincia(Id)
										ON DELETE CASCADE
										ON UPDATE CASCADE,	
);

CREATE TABLE Distrito(
	Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	DistritoId INT NOT NULL,
	CantonId INT NOT NULL,
	ProvinciaId INT NOT NULL,
	Nombre VARCHAR(100) NOT NULL,
	CreatedBy  VARCHAR(100),
	CreationDate DATE NOT NULL,
	EditionDate DATE NOT NULL,
	
	FOREIGN KEY (CantonId) REFERENCES Canton(Id),
										ON DELETE CASCADE
										ON UPDATE CASCADE,
	FOREIGN KEY (ProvinciaId) REFERENCES Provincia(Id),
										ON DELETE CASCADE
										ON UPDATE CASCADE,
);

CREATE TABLE Owner (
    Id INT NOT NULL IDENTITY(1,1),
	NSS INT NOT NULL UNIQUE,
    LastName VARCHAR(100) NOT NULL,
    FirstName VARCHAR(100),
    Address VARCHAR(100),
    AddressLongitude VARCHAR(100),
    AddressLatitude VARCHAR(100),
    ProvinciaId INT,
	CantonId INT,
	DistritoId INT,
	Phone VARCHAR(100) NOT NULL,
	Cellphone VARCHAR(100) NOT NULL,
	Birthdate DATE,
	PhotoURL  VARCHAR(100),
	CreatedBy  VARCHAR(100),
	CreationDate DATE NOT NULL,
	EditionDate DATE NOT NULL, 
	
	PRIMARY KEY (Id),
	FOREIGN KEY (ProvinciaId) REFERENCES Provincia(Id),
										ON DELETE CASCADE
										ON UPDATE CASCADE,
	FOREIGN KEY (CantonId) REFERENCES Canton(Id),
										ON DELETE CASCADE
										ON UPDATE CASCADE,
	FOREIGN KEY (DistritoId) REFERENCES Distrito(Id)
										ON DELETE CASCADE
										ON UPDATE CASCADE,
);

CREATE TABLE Categories (
    Id INT NOT NULL  IDENTITY(1,1),
    Name VARCHAR(255),
    Description VARCHAR(600),
	PhotoURL  VARCHAR(500),
	CreatedBy  VARCHAR(100),
	CreationDate DATE NOT NULL,
	EditionDate DATE NOT NULL,

	PRIMARY KEY(Id)   
);

CREATE TABLE Pet (
    Id INT NOT NULL  IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
	Weight DECIMAL,
	Age INT,
    City VARCHAR(100),
	Color VARCHAR(100),
	CategoriesId INT NOT NULL,
	OwnerId INT NOT NULL,
	Birthdate DATE,
	PhotoURL  VARCHAR(100),
	CreatedBy  VARCHAR(100),
	CreationDate DATE NOT NULL,
	EditionDate DATE NOT NULL,
	
	PRIMARY KEY(Id),
	FOREIGN KEY (CategoriesId) REFERENCES Categories(Id) 
										ON DELETE CASCADE
										ON UPDATE CASCADE,
	FOREIGN KEY (OwnerId) REFERENCES Owner(Id)
										ON DELETE CASCADE
										ON UPDATE CASCADE,
);