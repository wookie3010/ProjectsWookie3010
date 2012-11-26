CREATE TABLE [dbo].[ColdWaterMeterRecords] (
    [ColdWaterMeterRecordId] INT        NOT NULL,
    [MeterValue]             FLOAT (53) NOT NULL,
    [UnitId]                 INT        NOT NULL,
    [LocationId]             INT NOT NULL,
    [MeterClassId]           INT        NOT NULL,
    [Timestamp]              DATETIME   NOT NULL
);

