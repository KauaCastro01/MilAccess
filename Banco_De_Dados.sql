Create Database MilAccess

Use MilAccess

Create Table Usuarios
(
	Id Int Primary Key Identity,
	Nome Varchar(60) Not Null,
	Senha Varchar(30) Not Null,
	Cargo Varchar(60) Not Null
)

Insert Into Usuarios(Nome, Senha, Cargo)
Values('Kaua','1234', 'Adm')

SELECT * FROM Usuarios

CREATE TABLE Militares
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(60) NOT NULL,
    Patente VARCHAR(60) NOT NULL,
    Documentos VARCHAR(20) NOT NULL,
    OM VARCHAR(100) NOT NULL,
    Acompanhantes INT NOT NULL,
    Destino VARCHAR(100) NOT NULL,
    Entrada DATETIME NOT NULL,
    Saida DATETIME
);

Select * From Militares

CREATE TABLE Civil
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(60) NOT NULL,
    Documentos VARCHAR(20) NOT NULL,
    Acompanhantes INT NOT NULL,
    Destino VARCHAR(100) NOT NULL,
    Entrada DATETIME NOT NULL,
    Saida DATETIME
);

Select * From Civil

CREATE TABLE Veiculo
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(60) NOT NULL,
    TipoPessoa VARCHAR(60) NOT NULL,
    Documentos VARCHAR(20) NOT NULL,
    Placa VARCHAR(10) NOT NULL,
	Veiculo VARCHAR(40) NOT NULL,
	Cor VARCHAR(50) NOT NULL,
    Acompanhantes INT NOT NULL,
    Destino VARCHAR(100) NOT NULL,
    Entrada DATETIME NOT NULL,
    Saida DATETIME
);

Select * From Veiculo