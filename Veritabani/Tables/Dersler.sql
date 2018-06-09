CREATE TABLE [dbo].[Dersler] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Ders] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Dersler] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [IX_Dersler] UNIQUE NONCLUSTERED ([Ders] ASC)
);

