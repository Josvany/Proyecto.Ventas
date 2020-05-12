
CREATE PROCEDURE [dbo].[SP_I_HIS_AGENCY_BOX](
   @hisUserId UNIQUEIDENTIFIER,
   @useIntId   UNIQUEIDENTIFIER,
   @agencyBoxIntId   UNIQUEIDENTIFIER,
   @initialAmount  VARCHAR(50)
	
)
AS
BEGIN
	SET NOCOUNT ON;

			INSERT INTO [dbo].[TBL_HIS_USER_AGENCY_BOX]
			   (
					HIS_USER_AGENCY_BOX_ID,
					USE_INT_ID,
					BOX_INT_ID,
					HIS_USER_AGENCY_BOX_CREATE_DATE,
					HIS_USER_AGENCY_BOX_INITIAL_AMOUNT
			   )
			 VALUES
			   (
					@hisUserId,
					@useIntId,
					@agencyBoxIntId,
					GETDATE(),
					@initialAmount
			   )

END