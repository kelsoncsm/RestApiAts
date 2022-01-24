create Database [Ats]
Go

USE [Ats]
GO
/****** Object:  Table [dbo].[Candidatos]    Script Date: 20/01/2022 08:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidatos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](max) NULL,
	[SobreNome] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Telefone] [nvarchar](max) NULL,
	[DataNascimento] [nvarchar](max) NULL,
	[DataCadastro] [datetime2](7) NOT NULL,
	[IsAtivo] [bit] NOT NULL,
 CONSTRAINT [PK_Candidatos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vagas]    Script Date: 20/01/2022 08:31:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vagas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [nvarchar](max) NULL,
	[DataInicio] [datetime2](7) NOT NULL,
	[DataFim] [datetime2](7) NOT NULL,
	[Requisitos] [nvarchar](max) NULL,
	[IsAtivo] [bit] NOT NULL,
 CONSTRAINT [PK_Vagas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
