﻿CREATE TABLE [dbo].[TBL_MOVEMENT] (
    [MOV_ID]          UNIQUEIDENTIFIER NOT NULL,
    [TYP_MOV_ID]      UNIQUEIDENTIFIER NOT NULL,
    [SAL_ID]          UNIQUEIDENTIFIER NOT NULL,
    [MOV_CREATE_DATE] DATETIME         NOT NULL,
    [MOV_AMOUT]       DECIMAL (18, 2)  NOT NULL,
    CONSTRAINT [FK_TBL_MOVEMENT_TBL_SALES] FOREIGN KEY ([SAL_ID]) REFERENCES [dbo].[TBL_SALES] ([SAL_ID]),
    CONSTRAINT [FK_TBL_MOVEMENT_TBL_TYPE_MOVEMENT] FOREIGN KEY ([TYP_MOV_ID]) REFERENCES [dbo].[TBL_TYPE_MOVEMENT] ([TYP_MOV_ID])
);
