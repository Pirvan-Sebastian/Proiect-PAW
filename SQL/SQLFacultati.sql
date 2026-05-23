CREATE TABLE [dbo].[Facultati] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Nume]        NVARCHAR (100) NOT NULL,
    [NumarLocuri] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);