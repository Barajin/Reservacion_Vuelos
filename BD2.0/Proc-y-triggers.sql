------------------------------Cuando un vuelo venga de Siria------------------
CREATE TRIGGER BorrarVuelo
ON ciudad
FOR delete 
AS
BEGIN
DELETE vuelo where origen = 'Siria'
END

----------------------------
CREATE TRIGGER Disponibilidad AFTER INSERT ON boleto
  FOR EACH ROW
  BEGIN
     UPDATE vuelo SET capacidad = capacidad - 1 WHERE boleto.cveBoleto = boleto.cveBoleto;
  END;
  ---------------------------------
  CREATE TRIGGER Borrarvuelo AFTER DELETE ON vuelo
  FOR EACH ROW
  BEGIN
     UPDATE actor SET actorCount = actorCount - 1 WHERE idActor = OLD.idActor;
     DELETE FROM cliente WHERE cveCliente = OLD.cveCliente;
  END;
  ----------------Cliente duplicado-------------
  CREATE PROCEDURE [reservación_vuelos].[NombreCliente]
@Cli VARCHAR(40)
AS
BEGIN
SET NOCOUNT ON;

SELECT nombre
FROM reservación_vuelos.cliente
WHERE nombre=@Cli
END
------------------Clv ClubPremier duplicada----------------
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cveClubPremier]
  @cveClubPremier int
  AS
  BEGIN

 ----------------Clv Vuelo duplicada------------------------
 ET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cveVuelo]
  @cveVuelo int
  AS
  BEGIN