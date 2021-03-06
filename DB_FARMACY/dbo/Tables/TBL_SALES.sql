﻿CREATE TABLE [dbo].[TBL_SALES] (
    [SAL_ID]          UNIQUEIDENTIFIER NOT NULL,
    [USE_INT_ID]      UNIQUEIDENTIFIER NOT NULL,
    [SAL_DESCRIPTION] VARCHAR (MAX)    NULL,
    [SAL_CREATE_DATE] DATETIME         NOT NULL,
    CONSTRAINT [PK_TBL_SALES] PRIMARY KEY CLUSTERED ([SAL_ID] ASC),
    CONSTRAINT [FK_TBL_SALES_TBL_USER] FOREIGN KEY ([USE_INT_ID]) REFERENCES [dbo].[TBL_USER] ([USE_INT_ID])
);

