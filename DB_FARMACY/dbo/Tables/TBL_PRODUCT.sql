﻿CREATE TABLE [dbo].[TBL_PRODUCT] (
    [PRO_INT_ID]          UNIQUEIDENTIFIER NOT NULL,
    [CAT_INT_ID]          UNIQUEIDENTIFIER NULL,
    [PRO_NAME]            VARCHAR (1000)   NOT NULL,
    [PRO_CODE]            VARCHAR (100)    NOT NULL,
    [PRO_CANT]            INT              NOT NULL,
    [PRO_PRICE_SALES]     NUMERIC (18, 2)  NOT NULL,
    [PRO_PRIC_PURCHASE]   NUMERIC (18, 2)  NOT NULL,
    [PRO_DATE_EXPIRATION] DATE             NULL,
    [PRO_STOCK]           INT              NOT NULL,
    [PRO_MINIMAL_STOCK]   INT              NOT NULL,
    [PRO_IMAGE]           VARBINARY (MAX)  NULL,
    [PRO_STATUS]          BIT              NOT NULL,
    CONSTRAINT [PK_TBL_PRODUCT] PRIMARY KEY CLUSTERED ([PRO_INT_ID] ASC),
    CONSTRAINT [FK_TBL_PRODUCT_TBL_CATEGORY] FOREIGN KEY ([CAT_INT_ID]) REFERENCES [dbo].[TBL_CATEGORY] ([CAT_INT_ID])
);

