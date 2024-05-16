CREATE TABLE [dbo].[Licitatii] (
    [id_licitatie] INT           NOT NULL,
    [Data ]        DATE          NULL,
    [Descriere]    VARCHAR (100) NULL,
    [id_tablou]    INT           NULL,
    [id_sculptura] INT           NULL,
    [vandut]       BIT           NULL,
    [id_client]    INT           NULL,
    PRIMARY KEY CLUSTERED ([id_licitatie] ASC), 
    CONSTRAINT [FK_Licitatii_ToPicturi] FOREIGN KEY ([id_tablou]) REFERENCES [Picturi]([id_tablou]), 
    CONSTRAINT [FK_Licitatii_ToSculpturi] FOREIGN KEY ([id_sculptura]) REFERENCES [Sculpturi]([id_sculptura]), 
    CONSTRAINT [FK_Licitatii_ToClienti] FOREIGN KEY ([id_client]) REFERENCES [Clienti]([id_client])
);

