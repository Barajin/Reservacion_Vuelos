USE reservación_vuelos;
GO

SELECT * FROM cliente
SELECT * FROM clienteGenérico
SELECT * FROM club_premier

ALTER TABLE club_premier
	ADD fecha_nacimiento DATETIME DEFAULT GETDATE()

UPDATE club_premier SET fecha_nacimiento = '1980-05-04'
UPDATE club_premier SET fecha_nacimiento = '1999-11-02' WHERE domicilio LIKE 'R%'
UPDATE club_premier SET fecha_nacimiento = '1995-03-04' WHERE domicilio LIKE 'A%'
UPDATE club_premier SET fecha_nacimiento = '1997-12-01' WHERE domicilio LIKE 'T%'


ALTER TABLE clienteGenérico
	ADD edad INT NOT NULL DEFAULT 1

CREATE PROC cambiar_edad
AS 
BEGIN
	DECLARE edades CURSOR FOR
		SELECT cveCliente as clave, edad as edad FROM cliente;
OPEN edades;
DECLARE @c INT, @e INT;
FETCH NEXT FROM edades INTO @c, @e
WHILE @@FETCH_STATUS = 0
	BEGIN
		FETCH NEXT FROM edades INTO @c, @e
				PRINT 'CLIENTE: '+ CAST(@c as char(8)) + ' Edad: ' + CAST(@e as char(8))
				UPDATE clienteGenérico SET edad = @e WHERE cveCliente = @c;
	END
	CLOSE edades
	DEALLOCATE edades
END

EXECUTE cambiar_edad;
UPDATE clienteGenérico SET edad = 70 WHERE cveCliente = 1;

ALTER TABLE cliente
	DROP CONSTRAINT CK__cliente__edad__1CF15040;

ALTER TABLE cliente
	DROP COLUMN edad;