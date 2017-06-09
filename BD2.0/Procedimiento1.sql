//validacion de las cves de cliente uwu
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cve_cliente]
      @cve_Cliente int
AS

BEGIN
	
	SET NOCOUNT ON;
	select cveCliente from cliente where cveCliente=@cve_Cliente
END






//Validación de la cve de Boleto para que no se repita uwu
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cve_Boleto]
      @cve_Boleto int
AS

BEGIN
	
	SET NOCOUNT ON
	select cveBoleto from boleto where cveBoleto=@cve_Boleto
END
GO


//Validación de la cve de ciudad no se repita uwu
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[cve_Ciudad]
      @cve_Ciudad int
      
AS

BEGIN
	
	SET NOCOUNT ON
	select cve_Ciudad from ciudad where cve_Ciudad =@cve_Ciudad 
END
GO


