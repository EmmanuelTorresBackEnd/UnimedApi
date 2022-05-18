CREATE DATABASE UnimedWebApiDB
GO

USE UnimedWebApiDB
GO

CREATE TABLE Cliente (
Id INT PRIMARY KEY IDENTITY,
Nome VARCHAR(150) NOT NULL,
CPF INT NOT NULL,
DataNasc DATE,
NomeDaMae VARCHAR(150) NOT NULL,
Endereco VARCHAR(250) NOT NULL,
IdCarteirinha INT NOT NULL,
NomeDoPlano VARCHAR(50) NOT NULL,
Exames BIT,
)
GO

INSERT INTO Cliente (ID ,Nome, CPF,DataNasc, NomeDaMae, Endereco, IdCarteirinha, NomeDoPlano, Exames)
VALUES (002, 'Maria Silva', 111222333-00, '1980/05/10', 'Tereza Silva', 'Rua do Sol', 001, 'UNIMAX', '1')
GO

SELECT Id, Nome, CPF, DataNasc, NomeDaMae, Endereco,IdCarteirinha, NomeDoPlano, Exames FROM Cliente
GO
