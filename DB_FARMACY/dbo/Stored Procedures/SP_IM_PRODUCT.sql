CREATE PROCEDURE [dbo].[SP_IM_PRODUCT] (
   @prodId UNIQUEIDENTIFIER,
   @catIntId   UNIQUEIDENTIFIER,
   @proName  VARCHAR(50),
   @proCode VARCHAR(100),
   @proPriceSales DECIMAL(18,2),
   @proMinimalStock INT,
   @proStatus bit
	
)
AS
BEGIN
	SET NOCOUNT ON;

	  IF NOT EXISTS (SELECT * FROM TBL_PRODUCT WHERE PRO_INT_ID = @prodId)
	  BEGIN

			INSERT INTO [dbo].[TBL_PRODUCT]
			   (
					PRO_INT_ID,
					CAT_INT_ID,
					PRO_NAME,
					PRO_CODE,
					PRO_PRICE_SALES,
					PRO_MINIMAL_STOCK,
					PRO_STATUS
			   )
			 VALUES
			   (
					@prodId,
					ISNULL(@catIntId, NULL),
					@proName,
					@proCode,
					@proPriceSales,
					@proMinimalStock,
					@proStatus
			   )

		END
        ELSE
		   BEGIN
			UPDATE TBL_PRODUCT
				SET PRO_NAME = @proName, PRO_CODE = ISNULL(@catIntId, NULL),
					PRO_MINIMAL_STOCK=	@proMinimalStock, PRO_PRICE_SALES = @proPriceSales,
					PRO_STATUS = @proStatus
			  WHERE  PRO_INT_ID = @prodId

		  END
END