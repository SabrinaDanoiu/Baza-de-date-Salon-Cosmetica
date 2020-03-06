use Salon_Cosmetica;

CREATE TABLE Programari
(
	ID_Programare INT PRIMARY KEY IDENTITY(1,1),
	ID_Client INT NOT NULL,
	ID_Procedura INT NOT NULL,
	ID_Cosmetician INT NOT NULL,
	Data DATE NOT NULL,
	Ora TIME NOT NULL
);

CREATE TABLE Cosmeticieni
(
	ID_Cosmetician INT PRIMARY KEY IDENTITY(1,1),
	Nume VARCHAR(20) NOT NULL,
	Prenume VARCHAR(20) NOT NULL,
	Data_Nasterii DATE NOT NULL,
	cnp CHAR(13) UNIQUE NOT NULL,
	Sex CHAR(1) CHECK(SEX='M' OR SEX='F') DEFAULT 'F',
	Nr_telefon CHAR(10) NOT NULL,
	Email VARCHAR(30) NOT NULL,
	Adresa VARCHAR(50) NOT NULL,
	Nivel_experienta VARCHAR(9) CHECK(Nivel_experienta='Incepator' OR Nivel_experienta='Avansat') DEFAULT 'Incepator'
	);

CREATE TABLE Clienti
(
	ID_Client INT PRIMARY KEY IDENTITY(1,1),
	Nume VARCHAR(20) NOT NULL,
	Prenume VARCHAR(20) NOT NULL,
	Email VARCHAR(30) NOT NULL,
	Nr_telefon VARCHAR(10) NOT NULL
);

CREATE TABLE Proceduri_2
(
	ID_Procedura INT PRIMARY KEY IDENTITY(1,1),
	Nume_Procedura VARCHAR(30) UNIQUE NOT NULL,
	Durata_Procedura TIME NOT NULL,
	ID_Sala_Procedura INT NOT NULL
);

CREATE TABLE Sali_Proceduri 
(
	ID_Sala_Procedura INT PRIMARY KEY IDENTITY(1,1),
	Nr_Statii_de_lucru INT NOT NULL
);