CREATE DATABASE Ats;
GO
USE Ats;
GO
 CREATE TABLE [Candidatos] (
          [Id] int NOT NULL IDENTITY,
          [Nome] nvarchar(max) NULL,
          [SobreNome] nvarchar(max) NULL,
          [Email] nvarchar(max) NULL,
          [Telefone] nvarchar(max) NULL,
          [DataNascimento] nvarchar(max) NULL,
          [DataCadastro] datetime2 NOT NULL,
          [IsAtivo] bit NOT NULL,
          CONSTRAINT [PK_Candidatos] PRIMARY KEY ([Id])
      );

      CREATE TABLE [Vagas] (
          [Id] int NOT NULL IDENTITY,
          [Descricao] nvarchar(max) NULL,
          [DataInicio] datetime2 NOT NULL,
          [DataFim] datetime2 NOT NULL,
          [Requisitos] nvarchar(max) NULL,
          [IsAtivo] bit NOT NULL,
          CONSTRAINT [PK_Vagas] PRIMARY KEY ([Id])
      );