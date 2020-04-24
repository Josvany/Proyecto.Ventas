CREATE PROCEDURE [dbo].[SP_IM_KADEX] (
   @karID UNIQUEIDENTIFIER,
   @prodId UNIQUEIDENTIFIER,
   @typKarId   UNIQUEIDENTIFIER,
   @proDescription  VARCHAR(MAX),
   @karCreateDate DATETIME,
   @karPriceBuy DECIMAL(18,2),
   @karQuantity INT,
   @karQuantityT INT,
   @karExpirationDate DATE,
   @karDisabledDate DATETIME
	
)
AS
BEGIN
	SET NOCOUNT ON;

	  IF NOT EXISTS (SELECT * FROM TBL_KARDEX WHERE KAR_ID = @karID)
	  BEGIN

			INSERT INTO [dbo].[TBL_KARDEX]
			   (
					KAR_ID,
					PRO_INT_ID,
					TYP_KAR_ID,
					KAR_DECRIPTION,
					KAR_CREATE_DATE,
					KAR_PRICE_BUY,
					KAR_QUANTITY,
					KAR_QUANTITY_T,
					KAR_EXPIRATION_DATE
			   )
			 VALUES
			   (
					@karID,
					ISNULL(@prodId, NULL),
					@typKarId,
					@proDescription,
					@karCreateDate,
					@karPriceBuy,
					@karQuantity,
					@karQuantityT,
					@karExpirationDate
			   )

		END
        ELSE
		   BEGIN
			UPDATE TBL_KARDEX
				SET KAR_PRICE_BUY = @karPriceBuy, KAR_QUANTITY = ISNULL(@karQuantity, NULL),
					KAR_EXPIRATION_DATE= @karExpirationDate, KAR_DISABLE_DATE = ISNULL(@karDisabledDate, NULL)
			  WHERE  KAR_ID = @karID

		  END
END