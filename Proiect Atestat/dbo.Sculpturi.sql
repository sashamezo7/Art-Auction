CREATE TABLE [dbo].[Sculpturi] (
    [id_sculptura] INT           NOT NULL,
    [Denumire]     VARCHAR (50)  NULL,
    [Pret]         INT           NULL,
    [Descriere]    VARCHAR (100) NULL,
    [id_artist]    INT           NULL,
    PRIMARY KEY CLUSTERED ([id_sculptura] ASC), 
    CONSTRAINT [FK_Sculpturi_ToArtisti] FOREIGN KEY ([id_artist]) REFERENCES [Artisti]([id_artist])
);

