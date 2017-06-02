SELECT claveBoleto, c1.nombreCiudad, c2.nombreCiudad, cl.nombre, cp.claveClubPremier FROM boleto b 
	 INNER JOIN vuelo v ON v.cveVuelo = b.cveVuelo INNER JOIN ciudad c1 ON v.origen = c1.cveCiudad
         INNER JOIN ciudad c2 ON v.destino = c2.cveCiudad INNER JOIN cliente cl ON b.cveCliente = cl.cveCliente
		 LEFT JOIN club_premier cp ON cl.cveCliente = cp.cveCliente;


	SELECT * FROM club_premier;


SELECT * FROM vuelo;
SELECT * FROM ciudad;

SELECT v.cveVuelo, o.nombreCiudad, d.nombreCiudad, v.millas FROM vuelo v INNER JOIN ciudad o ON o.cveCiudad = v.origen INNER JOIN ciudad d ON d.cveCiudad = v.destino
WHERE millas = 1;

UPDATE vuelo SET millas = 1035.39082 WHERE cveVuelo = 25;
UPDATE vuelo SET millas = 558.613  WHERE cveVuelo = 38;
UPDATE vuelo SET millas = 1200.36 WHERE cveVuelo = 1;
UPDATE vuelo SET millas = 873.8343076 WHERE cveVuelo = 47;
UPDATE vuelo SET millas = 1048.315338 WHERE cveVuelo = 54;
UPDATE vuelo SET millas = 692.7667422 WHERE cveVuelo = 89;

EXEC AcumularMillas;

ALTER TABLE días
	DROP CONSTRAINT FK__días__cveVuelo__1920BF5C

SELECT * FROM boleto WHERE cveVuelo = 62;
DELETE FROM boleto WHERE cveVuelo = 62;
DELETE FROM vuelo WHERE cveVuelo = 62;

DROP TABLE días;

ALTER TABLE boleto
	ADD fecha_compra DATETIME DEFAULT GETDATE() NOT NULL

SELECT * FROM boleto;
	