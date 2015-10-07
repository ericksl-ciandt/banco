CREATE TABLE [dbo].[TableConta] (
    [idConta] VARCHAR (15) NOT NULL,
    [Saldo]   MONEY        NOT NULL,
    [idCartao] VARCHAR(25) NOT NULL FOREIGN KEY REFERENCES TableCartao(idCartao), 
    [idCPF] NCHAR(20) NULL, 
    PRIMARY KEY CLUSTERED ([idConta] ASC),	

);

