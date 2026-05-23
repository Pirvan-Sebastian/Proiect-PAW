CREATE TABLE [dbo].[Candidati] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [NumeComplet] NVARCHAR (100) NOT NULL,
    [CNP]         NVARCHAR (13)  NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);