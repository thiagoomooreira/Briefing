SET IDENTITY_INSERT [dbo].[Usuario] ON
INSERT INTO [dbo].[Usuario] ([Id], [Email], [Senha], [Nome], [Cpf], [Sexo], [Telefone], [DataCadastro], [IdEndereco]) VALUES (4002, N'admin@gmail.com', N'admin', N'Admin', N'983.229.547-51 ', N'Feminino  ', N'991570937                ', N'2021-05-26 23:57:44', 9002)
SET IDENTITY_INSERT [dbo].[Usuario] OFF

SET IDENTITY_INSERT [dbo].[Cidade] ON
INSERT INTO [dbo].[Cidade] ([Id], [Nome], [EstadoNome]) VALUES (4002, N'Campo Grande', N'Mato Grosso do Sul')
INSERT INTO [dbo].[Cidade] ([Id], [Nome], [EstadoNome]) VALUES (4003, N'Porto Alegre', N'Rio Grande do Sul')
INSERT INTO [dbo].[Cidade] ([Id], [Nome], [EstadoNome]) VALUES (4004, N'Rio do Sul', N'Santa Catarina')
SET IDENTITY_INSERT [dbo].[Cidade] OFF


SET IDENTITY_INSERT [dbo].[Endereco] ON
INSERT INTO [dbo].[Endereco] ([Id], [Rua], [Bairro], [Cep], [IdCidade]) VALUES (9002, N'Praça Ignácio Treis', N'Bom Fim', N'91859561  ', 4002)
INSERT INTO [dbo].[Endereco] ([Id], [Rua], [Bairro], [Cep], [IdCidade]) VALUES (9004, N'Praça Ignácio Treis', N'Los Angeles', N'79073031  ', 4002)
INSERT INTO [dbo].[Endereco] ([Id], [Rua], [Bairro], [Cep], [IdCidade]) VALUES (9005, N'Rua Johann Kepler', N'Budag', N'89165-400 ', 4004)
INSERT INTO [dbo].[Endereco] ([Id], [Rua], [Bairro], [Cep], [IdCidade]) VALUES (9006, N'Rua A', N'Zona de Expansão (Robalo)', N'49004-784 ', 4002)
INSERT INTO [dbo].[Endereco] ([Id], [Rua], [Bairro], [Cep], [IdCidade]) VALUES (9007, N'Acesso L Dois', N'Rubem Berta', N'91160-461 ', 4004)
INSERT INTO [dbo].[Endereco] ([Id], [Rua], [Bairro], [Cep], [IdCidade]) VALUES (9008, N'Rua Manoel Mendes', N'Pinheirinho', N'81820-070 ', 4003)
INSERT INTO [dbo].[Endereco] ([Id], [Rua], [Bairro], [Cep], [IdCidade]) VALUES (9009, N'Rua D', N'Industrial', N'49066-222 ', 4002)
INSERT INTO [dbo].[Endereco] ([Id], [Rua], [Bairro], [Cep], [IdCidade]) VALUES (9010, N'Quadra QN 7 Área Especial 3', N'Riacho Fundo I', N'71805-733 ', 4002)
SET IDENTITY_INSERT [dbo].[Endereco] OFF



SET IDENTITY_INSERT [dbo].[Pais] ON
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6004, N'Maria da Silva Pereira dos Santos', N'995845                   ', N'143.134.074-05      ', N'Padeira', N'3325635', N'2021-05-27 00:42:09')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6005, N'Paulo Santos', N'6655412                  ', N'647.116.673-77      ', N'Desenvolvedor Junior ', N'96664524', N'2021-05-27 00:42:09')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6006, N'Andreia Amanda', N'1241242                  ', N'363.087.550-52      ', N'Cozinheiro', N'(47) 99651-5415', N'2021-05-27 01:03:58')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6007, N'Felipe Giovanni Corte Real', N'2412425                  ', N'087.152.089-31      ', N'Professor', N'(47) 3723-6221', N'2021-05-27 01:03:58')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6008, N'Sophia Bárbara Fernanda', N'9665411                  ', N'857.373.555-43      ', N'Empresaria', N'44775544', N'2021-05-27 01:08:41')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6009, N'Mário Luís Lopes', N'698885                   ', N'273.029.455-43      ', N'Desenvolvedor', N'559985647', N'2021-05-27 01:08:41')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6010, N'Sandra Fabiana', N'335541                   ', N'376.682.274-82      ', N'Pintora', N'6658995', N'2021-05-27 01:11:48')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6011, N'Raul Benedito José Figueiredo', N'66985                    ', N'703.496.910-88      ', N'Marinheiro', N'679985462', N'2021-05-27 01:11:48')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6012, N'Alana Andrea Clara', N'99872                    ', N'611.656.362-71      ', N'Modelo', N'(41) 3674-3759', N'2021-05-27 01:14:23')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6013, N'Cauã Henry da Luz', N'666541                   ', N'712.960.347-04      ', N'Cantor', N'(41) 3674-3759', N'2021-05-27 01:14:23')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6014, N'Ana Bianca Helena', N'24.010.192-3             ', N'758.533.125-88      ', N'Garçom', N'(79) 99210-6732', N'2021-05-27 01:16:56')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6015, N'Thomas Carlos Eduardo Isaac Barbosa', N'24.010.192-3             ', N'675.465.349-33      ', N'Garçom', N'(79) 99210-6732', N'2021-05-27 01:16:56')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6016, N'Melissa Fernanda Louise', N'40.059.672-6             ', N'901.880.347-22      ', N'Professor', N'(61) 99195-3968', N'2021-05-27 01:19:15')
INSERT INTO [dbo].[Pais] ([Id], [Nome], [Rg], [Cpf], [Profissao], [Celular], [DataCadastro]) VALUES (6017, N'Marcos Vinicius Nelson Diogo dos Santos', N'40.059.672-6             ', N'116.488.448-47      ', N'Professor', N'(61) 99195-3968', N'2021-05-27 01:19:15')
SET IDENTITY_INSERT [dbo].[Pais] OFF


SET IDENTITY_INSERT [dbo].[Aluno] ON
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Cpf], [Sexo], [Telefone], [DataCadastro], [Rg], [DataNascimento], [Matricula], [Idade], [Email], [IdEndereco], [IdPai], [IdMae]) VALUES (6008, N'Bianca Rocha Souza Rodrigues Martins', N'983.229.547-51 ', N'Feminino  ', N'67991328634              ', N'2021-05-27 00:42:09', N'66325                    ', N'2000-10-28 00:00:00', N'177662', 20, N'biancamartins@localhost.com', 9004, 6005, 6004)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Cpf], [Sexo], [Telefone], [DataCadastro], [Rg], [DataNascimento], [Matricula], [Idade], [Email], [IdEndereco], [IdPai], [IdMae]) VALUES (6009, N'Caroline Luciana Fabiana Corte Real', N'832.137.363-17 ', N'Feminino  ', N'(47) 99651-5415          ', N'2021-05-26 01:03:58', N'34.306.491-1             ', N'1988-03-01 00:00:00', N'k532DOoZ3B', 33, N'carolinelucianafabianacortereal_@tjam.jus.br', 9005, 6007, 6006)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Cpf], [Sexo], [Telefone], [DataCadastro], [Rg], [DataNascimento], [Matricula], [Idade], [Email], [IdEndereco], [IdPai], [IdMae]) VALUES (6010, N'Anthony Lucas Bernardo Lopes', N'578.032.348-87 ', N'Masculino ', N'(79) 2962-6867           ', N'2021-05-26 01:08:41', N'1554263                  ', N'1950-09-08 00:00:00', N'19039as8', 66, N'anthonylucasbernardolopes..anthonylucasbernardolopes@proxion.com.br', 9006, 6009, 6008)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Cpf], [Sexo], [Telefone], [DataCadastro], [Rg], [DataNascimento], [Matricula], [Idade], [Email], [IdEndereco], [IdPai], [IdMae]) VALUES (6011, N'Nicolas Thiago Marcelo Figueiredo', N'631.082.843-63 ', N'Masculino ', N'(51) 3561-2680           ', N'2021-05-20 01:11:48', N'885554                   ', N'2002-07-05 00:00:00', N'Th1223n', 18, N'nicolasthiagomarcelofigueiredo@nelsoncosta.com.br', 9007, 6011, 6010)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Cpf], [Sexo], [Telefone], [DataCadastro], [Rg], [DataNascimento], [Matricula], [Idade], [Email], [IdEndereco], [IdPai], [IdMae]) VALUES (6012, N'Lara Jaqueline Adriana da Luz', N'466.624.428-01 ', N'Feminino  ', N'(41) 99364-6369          ', N'2021-05-16 01:14:23', N'33445                    ', N'1980-12-02 00:00:00', N'kju786', 26, N'larajaquelineadrianadaluz_@leanclean.com.br', 9008, 6013, 6012)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Cpf], [Sexo], [Telefone], [DataCadastro], [Rg], [DataNascimento], [Matricula], [Idade], [Email], [IdEndereco], [IdPai], [IdMae]) VALUES (6013, N'Carlos José Barbosa', N'732.651.411-95 ', N'Masculino ', N'(79) 99210-6732          ', N'2021-05-13 01:16:56', N'24.010.192-3             ', N'1998-03-15 00:00:00', N'uih277', 23, N'carlosjosebarbosa-84@contabilidaderangel.com.br', 9009, 6015, 6014)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Cpf], [Sexo], [Telefone], [DataCadastro], [Rg], [DataNascimento], [Matricula], [Idade], [Email], [IdEndereco], [IdPai], [IdMae]) VALUES (6014, N'Milena Amanda Lara dos Santos', N'730.049.085-90 ', N'Feminino  ', N'(61) 3725-3937           ', N'2021-05-10 01:19:15', N'40.059.672-6             ', N'1962-04-11 00:00:00', N'234frg', 36, N'milenaamandalaradossantos-75@alemponte.com.br', 9010, 6017, 6016)
SET IDENTITY_INSERT [dbo].[Aluno] OFF
