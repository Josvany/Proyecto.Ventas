﻿CREATE TABLE [dbo].[TBL_SAL_KARD_AFECTED] (
    [SAL_ID] UNIQUEIDENTIFIER NOT NULL,
    [KAR_ID] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_TBL_SAL_KARD_AFECTED] PRIMARY KEY CLUSTERED ([SAL_ID] ASC, [KAR_ID] ASC),
    CONSTRAINT [FK_TBL_SAL_KARD_AFECTED_TBL_KARDEX] FOREIGN KEY ([KAR_ID]) REFERENCES [dbo].[TBL_KARDEX] ([KAR_ID]),
    CONSTRAINT [FK_TBL_SAL_KARD_AFECTED_TBL_SALES] FOREIGN KEY ([SAL_ID]) REFERENCES [dbo].[TBL_SALES] ([SAL_ID])
);

