CREATE TABLE [dbo].[Movies] (
    [Id]   INT          NOT NULL,
    [Name] VARCHAR (50) NOT NULL,
    [Year] INT          NOT NULL,
    [Description] VARCHAR(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

