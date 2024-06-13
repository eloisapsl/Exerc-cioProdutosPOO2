CREATE TABLE [dbo].[Produto]
(--chave primaria auto encrement
[Nome] NVARCHAR(40)  NOT NULL PRIMARY KEY,
[Marca] NVARCHAR(MAX),
[Quantidade] NVARCHAR(MAX)
);

INSERT INTO Produto (Nome, Marca, Quantidade) VALUES ('Blusa', 'Renner', '3');
INSERT INTO Produto (Nome, Marca, Quantidade) VALUES ('Calça', 'CEA', '1');
INSERT INTO Produto (Nome, Marca, Quantidade) VALUES ('Cardigã', 'Adela', '1');
INSERT INTO Produto (Nome, Marca, Quantidade) VALUES ('Brinco', '499', '3');

SELECT * FROM Produto;

DROP TABLE Produto;
