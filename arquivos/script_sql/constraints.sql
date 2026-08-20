-- DROP TABLE IF EXISTS Enderecos;

--- Criando constraints ---

CREATE TABLE Enderecos (
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL, -- PRIMARY KEY E NOT NULL
	IdCliente int NULL, -- NULL
	Rua VARCHAR(255) NULL,
	Bairro VARCHAR(255) NULL,
	Cidade VARCHAR(255) NULL,
	Estado CHAR(2) NULL,

	CONSTRAINT FK_Endereco_Cliente FOREIGN KEY(IdCliente) REFERENCES Clientes(Id) -- FOREIGN KEY
	)

ALTER TABLE Produtos -- UNIQUE
  ADD UNIQUE(Nome);

ALTER TABLE Produtos -- CHECK
  ADD CONSTRAINT ChkColunaGenero CHECK(Genero = 'U' OR Genero = 'F' OR Genero = 'M');

ALTER TABLE Produtos -- DEFAULT
  ADD DEFAULT GETDATE() FOR DataCadastro;
  
  --- Deletandoo constraint ---
ALTER TABLE Produtos
 DROP CONSTRAINT UQ__Produtos__7D8FE3B2B607C803;