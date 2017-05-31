CREATE DATABASE reservación_vuelos;
GO

USE reservación_vuelos;
GO



   
    CREATE PROCEDURE [notRepeat]
    @cveClubPremier varchar (8)
   AS
   BEGIN 
	 SELECT cveClubPremier
	 FROM	reservación_vuelos
	 WHERE cveClubPremier= @cveClubPremier
   END

   
