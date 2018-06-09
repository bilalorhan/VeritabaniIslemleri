CREATE TABLE [dbo].[Ogretmenler] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Ad]     NVARCHAR (50) NOT NULL,
    [Soyad]  NVARCHAR (50) NOT NULL,
    [DersId] INT           NOT NULL,
    [DTarih] DATE          NOT NULL,
    CONSTRAINT [PK_Ogretmenler] PRIMARY KEY CLUSTERED ([Id] ASC)
);

