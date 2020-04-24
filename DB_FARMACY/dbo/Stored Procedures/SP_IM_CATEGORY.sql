CREATE PROCEDURE [dbo].[SP_IM_CATEGORY] (
   @catIntId   UNIQUEIDENTIFIER,
   @catName  VARCHAR(50),
   @catCode VARCHAR(100),
   @catStatus bit
	
)
AS
BEGIN
	SET NOCOUNT ON;

	  IF NOT EXISTS (SELECT * FROM TBL_CATEGORY WHERE CAT_INT_ID = @catIntId)
	  BEGIN

			INSERT INTO [dbo].[TBL_CATEGORY]
			   (
					CAT_INT_ID,
					CAT_NOMBRE,
					CAT_SYS_NAME,
					CAT_STATUS
			   )
			 VALUES
			   (
					@catIntId,
					@catName,
					@catCode,
					@catStatus
			   )

		END
        ELSE
		   BEGIN
			UPDATE TBL_CATEGORY
				SET CAT_NOMBRE = @catName,
					CAT_SYS_NAME =	@catCode, CAT_STATUS = @catStatus
			  WHERE  CAT_INT_ID = @catIntId

		  END
END