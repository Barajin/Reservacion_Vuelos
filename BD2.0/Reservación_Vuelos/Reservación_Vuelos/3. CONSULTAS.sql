USE reservación_vuelos;
GO

SELECT * FROM boleto;
SELECT * FROM ciudad;
SELECT * FROM cliente;
SELECT * FROM clienteGenérico;
SELECT * FROM club_premier;
SELECT * FROM días;
SELECT * FROM vuelo;

-- 1 Nombre de todos los vuelos con capacidad mayor a 20
SELECT * FROM vuelo WHERE capacidad >20;

-- 2 Vuelos donde la ciudad de origen sea Campeche
SELECT * FROM vuelo WHERE origen = 'CAE';

-- 3 Vuelos donde las millas sean menor a 1000
SELECT * FROM vuelo WHERE millas <1000;

-- 4 Vuelos con capacidad mayor a 30 pasajeros
SELECT cveVuelo, capacidad, origen, destino, costo FROM vuelo WHERE capacidad >30;

-- 5 Vuelos con destino Ciudad de México o Saltillo
SELECT * FROM vuelo WHERE destino = 'CIA' OR destino = 'SAL';

-- 6 Vuelos desde Hermosillo a Mérida
SELECT * FROM vuelo WHERE origen = 'HEO' AND destino = 'MÉD';

-- 7 Vuelos con capacidad mayor a 40
SELECT * FROM vuelo WHERE capacidad > 40;

-- 8 Ciudades que empiecen con C
SELECT * FROM ciudad WHERE nombreCiudad LIKE 'C%';

-- 9 Ciudades que empiecen con A
SELECT * FROM ciudad WHERE nombreCiudad LIKE 'A%';

-- 10 Ciudades que terminen con A
SELECT * FROM ciudad WHERE nombreCiudad LIKE '%A';

-- 11 Vuelos que cuesten menos de mil pesos
SELECT * FROM vuelo WHERE costo < 1000;

-- 12 Nombre, edad y direccion de todos los clientes de club premier ordenados por edad
SELECT nombre, edad, domicilio FROM cliente c 
	INNER JOIN club_premier cp ON c.cveCliente = cp.cveCliente ORDER BY edad;

-- 13 Nombre, edad, dirección y ciudad de origen de todos los clientes de club premier que han comprado vuelos
SELECT nombre, edad, domicilio, v.cveVuelo AS 'Vuelo', nombreCiudad AS 'Ciudad' FROM cliente c 
	JOIN club_premier cp ON c.cveCliente = cp.cveCliente 
	JOIN boleto b ON b.cveCliente = cp.cveCliente 
	JOIN vuelo v ON b.cveVuelo = v.cveVuelo 
	JOIN ciudad ci ON ci.cveCiudad = v.origen;

-- 14 Todos los boletos comprados por los clientes normales
SELECT c.cveCliente, v.cveVuelo, origen, destino FROM boleto b 
	JOIN clienteGenérico c ON b.cveCliente = c.cveCliente
	JOIN vuelo v ON b.cveVuelo = v.cveVuelo;

-- 15 Vuelos que salgan los miércoles
SELECT d.cveVuelo, origen, destino FROM vuelo v 
JOIN días d ON v.cveVuelo = d.cveVuelo WHERE d.díaVuelo = 'Miércoles';

-- 16 Nombre de todas las ciudades de las que hay vuelos y número de vuelos
SELECT nombreCiudad, COUNT(nombreCiudad) AS '# vuelos' FROM vuelo v 
	JOIN ciudad c ON v.origen = c.cveCiudad GROUP BY nombreCiudad;

-- 17 Nombre de todas las ciudades a las que hay vuelos y número de vuelos
SELECT nombreCiudad, COUNT(nombreCiudad) AS '# vuelos' FROM vuelo v 
	JOIN ciudad c ON v.destino = c.cveCiudad GROUP BY nombreCiudad;

-- 18 Ciudades a las que todavía no hay vuelos
SELECT nombreCiudad FROM ciudad c WHERE cveCiudad NOT IN 
(SELECT nombreCiudad FROM vuelo v JOIN ciudad c ON v.destino = c.cveCiudad GROUP BY nombreCiudad);

-- 19 Ciudades desde las que todavía no hay vuelos
SELECT nombreCiudad FROM ciudad c WHERE cveCiudad NOT IN 
(SELECT nombreCiudad FROM vuelo v JOIN ciudad c ON v.origen = c.cveCiudad GROUP BY nombreCiudad);

-- 20 Número de vuelos a Ciudad de México
SELECT nombreCiudad, COUNT(nombreCiudad) AS '# vuelos' FROM vuelo v 
	JOIN ciudad c ON v.destino = c.cveCiudad  WHERE nombreCiudad = 'Ciudad de México' GROUP BY nombreCiudad;

-- 21 Número de vuelos desde hermosillo
SELECT nombreCiudad, COUNT(nombreCiudad) AS '# vuelos' FROM vuelo v 
	JOIN ciudad c ON v.origen = c.cveCiudad  WHERE nombreCiudad = 'Hermosillo' GROUP BY nombreCiudad;

-- 22 Ciudad con menos vuelos
SELECT TOP 1 nombreCiudad, COUNT(nombreCiudad) AS '# vuelos' FROM vuelo v 
	JOIN ciudad c ON v.destino = c.cveCiudad GROUP BY nombreCiudad ORDER BY '# vuelos';

-- 23 Ciudad con más vuelos
SELECT TOP 1 nombreCiudad, COUNT(nombreCiudad) AS '# vuelos' FROM vuelo v 
	JOIN ciudad c ON v.destino = c.cveCiudad GROUP BY nombreCiudad ORDER BY '# vuelos' DESC;

-- 24  Clientes menores de 15 que van a Culiacán
SELECT c.nombre, c.edad, v.origen, v.destino
FROM cliente c INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo WHERE c.edad<15 AND v.destino = 'CLN';

-- 25 Clientes menores de 3 años
SELECT *
FROM cliente
WHERE edad<3;

-- 26 Clientes mayores de 7 años
SELECT *
FROM cliente
WHERE edad>7;

-- 27  Clientes que son Club Premier
SELECT c.nombre, cp.cveClubPremier
FROM cliente c JOIN club_premier cp ON c.cveCliente = cp.cveCliente
ORDER BY nombre;

-- 28 Clientes que son Club Premier Y van a Ciudad de México
SELECT c.nombre, v.destino, cp.cveClubPremier FROM cliente c
INNER JOIN club_premier cp ON cp.cveCliente = c.cveCliente
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo 
WHERE v.destino = 'CIA' ORDER BY nombre;

-- 29  Clientes mayores de edad que van a Aguascalientes
SELECT c.nombre, c.edad, v.destino FROM cliente c
INNER JOIN boleto b ON b.cveCliente = c.cveCliente 
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo 
WHERE c.edad>18 AND v.destino='AGS'
ORDER BY nombre;

-- 30 Clientes que se llaman Karen
SELECT nombre
FROM cliente
WHERE nombre LIKE 'Karen%';

-- 31 Clientes que se llaman Karen y van a Culiacán
SELECT c.nombre, v.destino FROM cliente c
INNER JOIN boleto b ON c.cveCliente = b.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE nombre LIKE 'Karen%' AND v.destino='CLN';

-- 32 Clientes que van a Ciudad de México
SELECT c.nombre, v.cveVuelo, v.origen, v.destino FROM vuelo v
INNER JOIN boleto b ON b.cveVuelo = v.cveVuelo
INNER JOIN cliente c ON b.cveCliente = c.cveCliente
WHERE v.destino = 'CIA';

-- 33 Número de personas que viajarán a la Ciudad de México --
SELECT COUNT(c.nombre) FROM vuelo v
INNER JOIN boleto b ON b.cveVuelo = v.cveVuelo
INNER JOIN cliente c ON b.cveCliente = c.cveCliente
WHERE v.destino = 'CIA';

-- 34 Clientes que se llaman Diego y son mayores de edad
SELECT cliente.nombre, cliente.edad
FROM cliente
WHERE nombre LIKE 'Diego%' AND edad>18

-- 35 Clientes que se llaman Karen y son mayores de edad
SELECT cliente.nombre, cliente.edad
FROM cliente
WHERE nombre LIKE 'Karen%' AND edad>18

-- 36 Todos los clientes que son menores de edad
SELECT *
FROM cliente 
WHERE edad<18
ORDER BY nombre

-- 37 Clientes que son Club Premier Y menores de edad 
SELECT c.nombre, c.edad, cp.cveClubPremier FROM cliente c
INNER JOIN club_premier cp ON c.cveCliente = cp.cveCliente
WHERE edad <18 ;

-- 38 Clientes que son Club Premier Y van a Ciudad de Mexico
SELECT c.nombre, v.destino, cp.cveClubPremier FROM cliente c
INNER JOIN boleto b ON c.cveCliente = b.cveCliente
INNER JOIN vuelo v ON b.cveVuelo = v.cveVuelo
INNER JOIN club_premier cp ON cp.cveCliente = c.cveCliente
WHERE v.destino = 'CIA' ORDER BY nombre;

-- 39 Clientes menores de 17 que van a Sonora
SELECT c.nombre, c.edad, v.destino FROM cliente c
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE c.edad <17 AND v.destino = 'SON';

-- 40 Clientes que son Club Premier y su vuelo sale en Lunes
SELECT c.nombre, cp.cveClubPremier, d.díaVuelo FROM cliente c
INNER JOIN club_premier cp ON cp.cveCliente = c.cveCliente
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
INNER JOIN días d ON d.cveVuelo = v.cveVuelo
WHERE díaVuelo = 'Lunes' ORDER BY nombre;

-- 41 Cantidad de personas de club premier que viajan en domingo --
SELECT COUNT(c.nombre) AS 'VIAJES EN DOMINGO' FROM cliente c
INNER JOIN club_premier cp ON cp.cveCliente = c.cveCliente
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
INNER JOIN días d ON d.cveVuelo = v.cveVuelo
WHERE díaVuelo = 'Domingo';

-- 42 Clientes que viajan en Jueves 
SELECT c.nombre, d.díaVuelo FROM cliente c
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
INNER JOIN días d ON d.cveVuelo = v.cveVuelo
WHERE díaVuelo = 'Jueves' ORDER BY nombre;

-- 43 Clientes que son menores de edad y viajan en Miércoles
SELECT c.nombre, c.edad, d.díaVuelo FROM cliente c
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
INNER JOIN días d ON d.cveVuelo = v.cveVuelo
WHERE díaVuelo = 'Miércoles' AND edad <18 ORDER BY nombre;

-- 44 Vuelos en los que ya no hay espacio para más pasajeros -- 
SELECT origen,destino,capacidad,numPasajeros
FROM vuelo
WHERE capacidad = numPasajeros;

-- 45 Número de vuelos en los que ya no hay espacio -- 
SELECT COUNT(origen) AS 'SIN ESPACIO'
FROM vuelo
WHERE capacidad = numPasajeros;

-- 46 Número de vuelos en los que todavía hay espacio -- 
SELECT COUNT(origen) AS 'Vuelos disponibles'
FROM vuelo
WHERE capacidad > numPasajeros;

-- 47 Vuelos con lugares disponibles -- 
SELECT origen,destino,capacidad,numPasajeros
FROM vuelo
WHERE capacidad > numPasajeros;

-- 48 Vuelos en donde las millas son menores a 1000 --
SELECT cveVuelo,destino
FROM vuelo
WHERE millas<1000;

-- 49 Vuelos entre 500 y 1000 pesos --
SELECT cveVuelo,origen,destino,costo
FROM vuelo
WHERE (costo BETWEEN 500 and 1000)
ORDER BY costo;

-- 50 Clientes que van a Guanajuato --
SELECT c.nombre, v.origen, v.destino FROM cliente c
INNER JOIN boleto b ON c.cveCliente = b.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE v.destino = 'GUA';

-- 51 Nombre de los clientes que su vuelo saldrá el día viernes --
SELECT c.nombre, v.cveVuelo, d.díaVuelo FROM cliente c
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveBoleto
INNER JOIN días d ON d.cveVuelo = v.cveVuelo
WHERE d.díaVuelo = 'Viernes';

-- 52 vuelos que tienen clientes con edad mayor de 40 años -- 
SELECT c.nombre, c.edad, v.cveVuelo FROM cliente c
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE edad >40 ORDER BY edad;

-- 53 Vuelos que no están llenos --
SELECT cveVuelo,numPasajeros,capacidad
FROM vuelo
WHERE numPasajeros<capacidad
ORDER BY numPasajeros;

-- 54 Vuelos que salen a diario --
SELECT v.cveVuelo, v.origen, v.destino, d.díaVuelo FROM vuelo v 
INNER JOIN días d ON d.cveVuelo = v.cveVuelo
WHERE d.díaVuelo = 'Diaria';

-- 55 Domicilios de los primeros 5 clientes premier en registrarse --
SELECT domicilio
FROM club_premier
WHERE cveClubPremier<=5

-- 56 Vuelos en donde las millas son mayores de 1000 --
SELECT cveVuelo,destino
FROM vuelo
WHERE millas>1000

-- 57 Vuelos donde el número de pasajeros sea mayor a 30 --
SELECT cveVuelo, destino,origen,numPasajeros
FROM vuelo
WHERE numPasajeros>30
ORDER BY numPasajeros

-- 58 Clientes menores de edad -- 
SELECT nombre, edad
FROM cliente
WHERE edad<18

-- 59 Clientes menores de edad que van a Guadalajara --
SELECT c.nombre, c.edad, v.destino FROM cliente c
INNER JOIN boleto b ON c.cveCliente = b.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE edad <18 AND v.destino = 'GUA';

-- 60 Clientes mayores de edad que van a Guadalajara --
SELECT c.nombre, c.edad, v.destino FROM cliente c
INNER JOIN boleto b ON c.cveCliente = b.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE edad > 18 AND v.destino = 'GUA';

-- 61 Clientes mayores de 25 años que son premier*/
SELECT c.nombre, c.edad, cp.cveClubPremier FROM cliente c 
INNER JOIN club_premier cp ON cp.cveCliente = c.cveCliente
WHERE c.edad > 25 ORDER BY edad; 

-- 62 Clientes menores de 18 que son club premier -- 
SELECT c.nombre, c.edad, cp.cveClubPremier FROM cliente c 
INNER JOIN club_premier cp ON cp.cveCliente = c.cveCliente
WHERE c.edad < 18 ORDER BY edad; 

-- 63 Todos los clientes que su apellido empiece con E y sean premier --
SELECT cliente.nombre, club_premier.cveClubPremier
FROM cliente
INNER JOIN club_premier ON cliente.cveCliente = club_premier.cveCliente WHERE cliente.nombre LIKE 'E%'

-- 64 Clientes que pertenecen al club premier, tienen más de 19 años y su Nombre comienza con E* --
SELECT cliente.nombre,club_premier.cveClubPremier,cliente.edad
FROM cliente
INNER JOIN club_premier ON cliente.cveCliente = club_premier.cveCliente WHERE cliente.nombre LIKE 'E%'
AND edad > 19;

-- 65 Nombres de ciudades cuyo destino comience con la letra C -- 
SELECT DISTINCT destino, c.nombreCiudad
FROM vuelo v INNER JOIN ciudad c ON v.destino = c.cveCiudad
WHERE destino LIKE'C%' ORDER BY nombreCiudad;

-- 66 Todos los nombres de los clientes que han comprado boletos, su origen y destino --
SELECT b.cveBoleto, c.nombre, c.edad, v.origen, v.destino
FROM cliente c INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo;

-- 67 Clientes menores de 3 años --
SELECT *
FROM cliente
WHERE edad<3

-- 68 Clientes mayores de 7 años --
SELECT *
FROM cliente
WHERE edad>7

-- 69 Clientes que son Club Premier --
SELECT c.nombre, cp.cveClubPremier FROM cliente c
INNER JOIN club_premier cp ON c.cveCliente = cp.cveCliente ORDER BY nombre;

-- 70 Clientes que son Club Premier Y van a la ciudad de México --
SELECT c.nombre, cp.cveClubPremier FROM cliente c
INNER JOIN club_premier cp ON c.cveCliente = cp.cveCliente 
INNER JOIN boleto b ON c.cveCliente = b.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE destino = 'CIA'
ORDER BY nombre;

-- 71 Clientes que se llaman Karen --
SELECT cliente.nombre
FROM cliente
WHERE nombre LIKE 'Karen%'

-- 72 Clientes que se llaman Diego y son mayores de edad --
SELECT cliente.nombre, cliente.edad
FROM cliente
WHERE nombre LIKE 'Diego%' AND edad>18

-- 73 Clientes que se llaman Karen y son mayores de edad --
SELECT cliente.nombre, cliente.edad
FROM cliente
WHERE nombre LIKE 'Karen%' AND edad>18

-- 74 Todos los clientos que son menores de edad --
SELECT *
FROM cliente 
WHERE edad<18
ORDER BY edad

-- 75 Clientes que son Club Premier Y menores de edad  --
SELECT c.nombre, c.edad, cp.cveClubPremier FROM cliente c
INNER JOIN club_premier cp ON c.cveCliente = cp.cveCliente
WHERE edad<18 ORDER BY edad;

-- 76 Clientes que son Club Premier Y van a Ciudad de Mexico -
SELECT c.nombre, c.edad, cp.cveClubPremier FROM cliente c
INNER JOIN club_premier cp ON c.cveCliente = cp.cveCliente
INNER JOIN boleto b ON b.cveCliente = cp.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE destino = 'CIA';

-- 77 Clientes que viajen más 500 millas -- 
SELECT v.cveVuelo, c.nombre, v.millas FROM cliente c
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE millas>500
ORDER BY nombre;

-- 78 Clientes que viajen más 1000 millas y sean mayores de edad --
SELECT v.cveVuelo, c.nombre, c.edad, v.millas FROM cliente c
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE millas>1000 AND edad >18
ORDER BY nombre;

-- 79 Clientes que viajen más 700 millas y se llamen Karen --
SELECT v.cveVuelo, c.nombre, v.millas FROM cliente c
INNER JOIN boleto b ON b.cveCliente = c.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE millas>700 AND nombre LIKE 'Karen%'
ORDER BY nombre;

-- 80 Clientes que viajen más 1000 millas y sean club premier -- 
SELECT v.cveVuelo, c.nombre, cp.cveClubPremier, millas FROM cliente c
INNER JOIN club_premier cp ON cp.cveCliente = c.cveCliente
INNER JOIN boleto b ON b.cveCliente = cp.cveCliente
INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo
WHERE millas>1000
ORDER BY nombre;

-- 81 edad promedio de los clientes en general --
SELECT AVG(edad) AS 'Edad Promedio' FROM cliente;

-- 82 edad promedio de los clientes genéricos -- 
SELECT AVG(edad) AS 'Edad Promedio' FROM cliente c
INNER JOIN clienteGenérico cg ON c.cveCliente = cg.cveCliente;

-- 83 edad promedio de los clientes club premier -- 
SELECT AVG(edad) AS 'Edad Promedio' FROM cliente c
INNER JOIN club_premier cp ON c.cveCliente = cp.cveCliente;


/* EXTRAS
Vuelos que salgan los fines de semana
Ciudad a la que hay más vuelos
Vuelo más caro y vuelo más barato
Vuelo redondo
Clientes que van a mérida
Clientes que su vuelo sale el martes
cuántos lugares disponibles hay para un vuelo a Ciudad de México
Cantidad de vuelos que salen desde mérida
Vuelos que salen a diario
Vuelos que salen varios días
Días en que sale el vuelo de MOE a CUN
Edad promedio de los clientes
Edad promedio de los clientes club premier
*/

