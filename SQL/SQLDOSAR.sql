CREATE TABLE [dbo].[Dosare] (
    [Id]          INT   IDENTITY (1, 1) NOT NULL,
    [IdCandidat]  INT   NOT NULL,
    [IdFacultate] INT   NOT NULL,
    [NotaBac]     FLOAT NOT NULL,
    [NotaExamen]  FLOAT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);