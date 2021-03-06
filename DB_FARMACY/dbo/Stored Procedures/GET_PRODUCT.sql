﻿CREATE PROCEDURE [dbo].[GET_PRODUCT]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT PR.PRO_INT_ID, PR.CAT_INT_ID, PR.PRO_NAME AS Nombre, 
		   PR.PRO_CODE AS Código, PR.PRO_MINIMAL_STOCK ,PR.PRO_STOCK AS Cantidad, PR.PRO_PRICE_SALES, 
		   PR.PRO_STATUS AS Estado , PR.PRO_IVA AS IVA, TYP.PRES_NAME
	FROM  TBL_PRODUCT PR LEFT OUTER JOIN TBL_PRESENTATION TYP ON TYP.PRES_ID = PR.PRES_ID
END