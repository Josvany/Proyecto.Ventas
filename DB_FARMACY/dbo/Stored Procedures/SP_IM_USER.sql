CREATE PROCEDURE [dbo].[SP_IM_USER] (
   @useIntId   UNIQUEIDENTIFIER,
   @useName  VARCHAR(50),
   @useLogin VARCHAR(100),
   @usePass VARCHAR(300),
   @rolIntId UNIQUEIDENTIFIER,
   @useStatus bit
	
)
AS
BEGIN
	SET NOCOUNT ON;

	  IF NOT EXISTS (SELECT * FROM TBL_USER WHERE USE_INT_ID = @useIntId)
	  BEGIN

			INSERT INTO [dbo].[TBL_USER]
			   (
					USE_INT_ID,
					USE_NAME,
					USE_LOGIN,
					USE_PASS,
					ROL_INT_ID,
					USE_STATUS
			   )
			 VALUES
			   (
					@useIntId,
					@useName,
					@useLogin,
					@usePass,
					@rolIntId,
					@useStatus
			   )

		END
        ELSE
		   BEGIN
			UPDATE TBL_USER
				SET USE_NAME = @useName,
					USE_LOGIN =	@useLogin, USE_PASS = @usePass,
					ROL_INT_ID = @rolIntId, USE_STATUS = @useStatus
			  WHERE  USE_INT_ID = @useIntId

		  END
END