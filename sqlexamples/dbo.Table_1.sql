CREATE TABLE [dbo].[DliscDatabase]
(
	[TRN] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [CC] VARCHAR(50) NULL, 
    [Laiden] VARCHAR(50) NULL, 
    [Examination] VARCHAR(50) NULL, 
    [TypeOfLisc] VARCHAR(50) NULL, 
    [Image] IMAGE NULL, 
    [Unlaiden] VARCHAR(50) NULL, 
    [Home] NUMERIC NULL, 
    [Work] NUMERIC NULL, 
    [Occupation] VARCHAR(50) NULL, 
    [Address] VARCHAR(50) NULL, 
    [TOlisc] VARCHAR(50) NULL, 
    [DateReceived] DATE NULL, 
    [DateCollected] DATE NULL
)
