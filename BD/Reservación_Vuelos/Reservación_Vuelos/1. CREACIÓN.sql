<<<<<<< Updated upstream:BD/Reservacio虂n_Vuelos/1. CREACIO虂N.sql
CREATE DATABASE reservaci贸n_vuelos;
=======
CREATE DATABASE reservaci髇_vuelos;
>>>>>>> Stashed changes:BD/Reservaci贸n_Vuelos/Reservaci贸n_Vuelos/1. CREACI脫N.sql
GO

USE reservaci髇_vuelos;
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

CREATE TABLE d韆s (
	cveVuelo INT FOREIGN KEY REFERENCES vuelo(cveVuelo),
<<<<<<< Updated upstream:BD/Reservacio虂n_Vuelos/1. CREACIO虂N.sql
	d铆aVuelo VARCHAR(10) CHECK(d铆aVuelo IN ('Lunes','Martes','Mi茅rcoles','Jueves','Viernes','S谩bado','Domingo','Diaria')),
	PRIMARY KEY (cveVuelo, d铆aVuelo)
=======
	d韆Vuelo VARCHAR(10) CHECK(d韆Vuelo IN ('Lunes','Martes','Mi閞coles','Jueves','Viernes','S醔ado','Domingo','Diaria')),
	PRIMARY KEY (cveVuelo, d韆Vuelo)
>>>>>>> Stashed changes:BD/Reservaci贸n_Vuelos/Reservaci贸n_Vuelos/1. CREACI脫N.sql
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

<<<<<<< Updated upstream:BD/Reservacio虂n_Vuelos/1. CREACIO虂N.sql
CREATE TABLE clienteGen茅rico(
  cveCliente INT PRIMARY KEY FOREIGN KEY REFERENCES cliente(cveCliente)
=======
CREATE TABLE clienteGen閞ico(
	cveCliente INT PRIMARY KEY FOREIGN KEY REFERENCES cliente(cveCliente)
>>>>>>> Stashed changes:BD/Reservaci贸n_Vuelos/Reservaci贸n_Vuelos/1. CREACI脫N.sql
)
  
CREATE TABLE boleto (
  cveBoleto INT IDENTITY(1,1) PRIMARY KEY,
  cveVuelo INT FOREIGN KEY REFERENCES vuelo(cveVuelo),
  cveCliente INT FOREIGN KEY REFERENCES cliente(cveCliente)
)