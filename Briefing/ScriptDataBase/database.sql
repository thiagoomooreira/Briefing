CREATE TABLE [dbo].[Usuario] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Email]        NVARCHAR (MAX) NOT NULL,
    [Senha]        NVARCHAR (MAX) NOT NULL,
    [Nome]         NVARCHAR (250) NOT NULL,
    [Cpf]          NCHAR (15)     NOT NULL,
    [Sexo]         NCHAR (10)     NOT NULL,
    [Telefone]     NCHAR (25)     NOT NULL,
    [DataCadastro] DATETIME       NOT NULL,
    [IdEndereco]   INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Usuario_ToTable] FOREIGN KEY ([IdEndereco]) REFERENCES [dbo].[Endereco] ([Id])
);

CREATE TABLE [dbo].[Cidade] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Nome]       NVARCHAR (150) NOT NULL,
    [EstadoNome] NVARCHAR (150) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Endereco] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Rua]      NVARCHAR (MAX) NOT NULL,
    [Bairro]   NVARCHAR (MAX) NOT NULL,
    [Cep]      NCHAR (10)     NOT NULL,
    [IdCidade] INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Endereco_Cidade] FOREIGN KEY ([IdCidade]) REFERENCES [dbo].[Cidade] ([Id])
);

CREATE TABLE [dbo].[Pais] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Nome]         NVARCHAR (250) NOT NULL,
    [Rg]           NCHAR (25)     NOT NULL,
    [Cpf]          NCHAR (20)     NOT NULL,
    [Profissao]    NVARCHAR (50)  NOT NULL,
    [Celular]      NVARCHAR (50)  NOT NULL,
    [DataCadastro] DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Aluno] (
    [Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Nome]           NVARCHAR (MAX) NOT NULL,
    [Cpf]            NCHAR (15)     NOT NULL,
    [Sexo]           NCHAR (10)     NOT NULL,
    [Telefone]       NCHAR (25)     NOT NULL,
    [DataCadastro]   DATETIME       NOT NULL,
    [Rg]             NCHAR (25)     NOT NULL,
    [DataNascimento] DATETIME       NOT NULL,
    [Matricula]      NVARCHAR (50)  NOT NULL,
    [Idade]          INT            NOT NULL,
    [Email]          NVARCHAR (250) NOT NULL,
    [IdEndereco]     INT            NOT NULL,
    [IdPai]          INT            NOT NULL,
    [IdMae]          INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    UNIQUE NONCLUSTERED ([Cpf] ASC),
    CONSTRAINT [FK_Aluno_Endereco] FOREIGN KEY ([IdEndereco]) REFERENCES [dbo].[Endereco] ([Id]),
    CONSTRAINT [FK_Aluno_PaisMae] FOREIGN KEY ([IdMae]) REFERENCES [dbo].[Pais] ([Id]),
    CONSTRAINT [FK_Aluno_PaisPai] FOREIGN KEY ([IdPai]) REFERENCES [dbo].[Pais] ([Id])
);

