CREATE PROCEDURE [dbo].[SP_IM_AGENCY_BOX] (
   @boxIntId   UNIQUEIDENTIFIER,
   @boxName  VARCHAR(50),
   @boxStatus bit
	
)
AS
BEGIN
	SET NOCOUNT ON;

	  IF NOT EXISTS (SELECT * FROM TBL_AGENCY_BOX WHERE BOX_INT_ID = @boxIntId)
	  BEGIN

			INSERT INTO [dbo].[TBL_AGENCY_BOX]
			   (
					BOX_INT_ID,
					BOX_NAME,
					BOX_STATUS
			   )
			 VALUES
			   (
					@boxIntId,
					@boxName,
					@boxStatus
			   )

		END
        ELSE
		   BEGIN
			UPDATE TBL_AGENCY_BOX
				SET BOX_NAME= @boxName , BOX_STATUS = @boxStatus
			  WHERE  BOX_INT_ID = @boxIntId

		  END
END