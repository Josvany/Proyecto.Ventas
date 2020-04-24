﻿CREATE PROCEDURE SP_GET_CATEGORY
AS
BEGIN
	SET NOCOUNT ON;

	SELECT CAT.CAT_INT_ID, CAT_NOMBRE AS Nombre, CAT.CAT_SYS_NAME AS Código, CAT.CAT_STATUS AS Estado FROM TBL_CATEGORY CAT
END