﻿CREATE TABLE [dbo].[TBL_TYPE_MOVEMENT] (
    [TYP_MOV_ID]   UNIQUEIDENTIFIER NOT NULL,
    [TYP_MOV_NAME] VARCHAR (100)    NULL,
    CONSTRAINT [PK_TBL_TYPE_MOVEMENT] PRIMARY KEY CLUSTERED ([TYP_MOV_ID] ASC)
);

