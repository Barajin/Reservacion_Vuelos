
CREATE DATABASE reservación_vuelos;
GO

USE reservación_vuelos;
GO

CREATE TABLE ciudad (
  cveCiudad CHAR(3) PRIMARY KEY,
  nombreCiudad VARCHAR(20) NOT NULL,
  estado VARCHAR(20) NOT NULL
)

CREATE TABLE vuelo (
  cveVuelo INT IDENTITY(1,1) PRIMARY KEY,
  numPasajeros INT NOT NULL,
  origen CHAR(3) NOT NULL FOREIGN KEY REFERENCES ciudad(cveCiudad),
  destino CHAR(3) NOT NULL FOREIGN KEY REFERENCES ciudad(cveCiudad),
  capacidad INT NOT NULL CHECK(capacidad>0),
  costo DECIMAL(10,3) NOT NULL CHECK(costo>0),
  millas DECIMAL(10,3) NOT NULL CHECK(millas>0),
)

CREATE TABLE cliente (
  cveCliente INT IDENTITY(1,1) PRIMARY KEY,
  nombre VARCHAR(50) NOT NULL,
  edad INT NOT NULL CHECK(edad>0)
)

CREATE TABLE club_premier (
  cveClubPremier INT IDENTITY(1,1) PRIMARY KEY,
  cveCliente INT NOT NULL FOREIGN KEY REFERENCES cliente(cveCliente),
  domicilio VARCHAR(60) NOT NULL
)

CREATE TABLE clienteGenérico(
	cveCliente INT PRIMARY KEY FOREIGN KEY REFERENCES cliente(cveCliente)
)
  
CREATE TABLE boleto (
  cveBoleto INT IDENTITY(1,1) PRIMARY KEY,
  cveVuelo INT FOREIGN KEY REFERENCES vuelo(cveVuelo),
  cveCliente INT FOREIGN KEY REFERENCES cliente(cveCliente)
)

INSERT INTO ciudad (cveCiudad, nombreCiudad, estado)
	VALUES ('CLN', 'Culiacán', 'Sinaloa'),
	('MZN', 'Mazatlán', 'Sinaloa')

SELECT * FROM ciudad;

INSERT INTO vuelo (numPasajeros, origen, destino, capacidad, costo, millas)
	VALUES(30,'CLN','MZN',14,500,1400)

SELECT * FROM vuelo;

INSERT INTO cliente (nombre, edad)
	VALUES ('Manuel Bernal', 19)

SELECT * FROM cliente;

INSERT INTO club_premier (cveCliente, domicilio)
	VALUES (1, 'Av Guadalupe Victoria')

SELECT * FROM club_premier;

INSERT INTO boleto (cveVuelo, cveCliente)
	VALUES (1,1)

SELECT * FROM boleto;