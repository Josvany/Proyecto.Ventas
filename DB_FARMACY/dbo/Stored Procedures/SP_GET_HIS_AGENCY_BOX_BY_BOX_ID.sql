﻿
CREATE PROCEDURE [dbo].[SP_GET_HIS_AGENCY_BOX_BY_BOX_ID](
   @boxIntId   UNIQUEIDENTIFIER	
)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM TBL_HIS_USER_AGENCY_BOX WHERE BOX_INT_ID = @boxIntId AND HIS_USER_AGENCY_BOX_DISABLE_DATE IS NULL
END