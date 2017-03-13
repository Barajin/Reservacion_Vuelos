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

CREATE TABLE días (
	cveVuelo INT FOREIGN KEY REFERENCES vuelo(cveVuelo),
	díaVuelo VARCHAR(10) CHECK(díaVuelo IN ('Lunes','Martes','Miércoles','Jueves','Viernes','Sábado','Domingo','Diaria')),
	PRIMARY KEY (cveVuelo, díaVuelo)
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
