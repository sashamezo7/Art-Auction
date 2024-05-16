CREATE TABLE [dbo].[Picturi] (
    [id_tablou] INT           NOT NULL,
    [Denumire]  VARCHAR (50)  NULL,
    [Pret]      INT           NULL,
    [Descriere] VARCHAR (100) NULL,
    [id_artist] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([id_tablou] ASC), 
    CONSTRAINT [FK_Picturi_ToArtisti] FOREIGN KEY ([id_artist]) REFERENCES [Artisti]([id_artist]) 
);

