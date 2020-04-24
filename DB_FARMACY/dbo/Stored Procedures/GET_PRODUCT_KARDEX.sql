﻿CREATE PROCEDURE GET_PRODUCT_KARDEX
 @prodIntId UNIQUEIDENTIFIER,
 @typKardex UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON;

	SELECT KD.KAR_DECRIPTION AS Descripción , KD.KAR_PRICE_BUY,
		   KD.KAR_QUANTITY AS Cantidad, KD.KAR_EXPIRATION_DATE
	FROM  TBL_KARDEX KD INNER JOIN  TBL_PRODUCT PR  ON PR.PRO_INT_ID = KD.PRO_INT_ID
	WHERE KD.PRO_INT_ID = @prodIntId AND KD.TYP_KAR_ID = @typKardex AND KD.KAR_DISABLE_DATE IS NULL
END