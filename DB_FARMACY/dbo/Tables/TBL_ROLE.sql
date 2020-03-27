﻿CREATE TABLE [dbo].[TBL_ROLE] (
    [ROL_INT_ID] UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [ROL_NAME]   VARCHAR (50)     NULL,
    PRIMARY KEY CLUSTERED ([ROL_INT_ID] ASC)
);
