CREATE PROCEDURE [dbo].[SP_IM_TYPE_PRESENTATION] (
   @preIntId   UNIQUEIDENTIFIER,
   @preName  VARCHAR(50)
	
)
AS
BEGIN
	SET NOCOUNT ON;

	  IF NOT EXISTS (SELECT * FROM TBL_PRESENTATION WHERE PRES_ID = @preIntId)
	  BEGIN

			INSERT INTO [dbo].[TBL_PRESENTATION]
			   (
					PRES_ID,
					PRES_NAME
			   )
			 VALUES
			   (
					@preIntId,
					@preName
			   )

		END
        ELSE
		   BEGIN
			UPDATE TBL_PRESENTATION
				SET @preName = @preName
			  WHERE PRES_ID = @preIntId

		  END
END