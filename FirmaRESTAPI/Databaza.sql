USE [master]
GO
/****** Object:  Database [firma]    Script Date: 2/21/2022 15:55:33 ******/
CREATE DATABASE [firma]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'firma', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\firma.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'firma_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\firma_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [firma] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [firma].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [firma] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [firma] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [firma] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [firma] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [firma] SET ARITHABORT OFF 
GO
ALTER DATABASE [firma] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [firma] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [firma] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [firma] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [firma] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [firma] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [firma] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [firma] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [firma] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [firma] SET  ENABLE_BROKER 
GO
ALTER DATABASE [firma] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [firma] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [firma] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [firma] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [firma] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [firma] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [firma] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [firma] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [firma] SET  MULTI_USER 
GO
ALTER DATABASE [firma] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [firma] SET DB_CHAINING OFF 
GO
ALTER DATABASE [firma] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [firma] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [firma] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [firma] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [firma] SET QUERY_STORE = OFF
GO
USE [firma]
GO
/****** Object:  Table [dbo].[Divizie]    Script Date: 2/21/2022 15:55:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Divizie](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazov] [nvarchar](50) NOT NULL,
	[ID_veduci] [int] NULL,
	[ID_patri_pod] [int] NULL,
 CONSTRAINT [PK__Divizie__3214EC27DC23A4D4] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Firma]    Script Date: 2/21/2022 15:55:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Firma](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazov] [nvarchar](50) NOT NULL,
	[ID_veduci] [int] NULL,
 CONSTRAINT [PK_Firma] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Oddelenia]    Script Date: 2/21/2022 15:55:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Oddelenia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazov] [nvarchar](50) NOT NULL,
	[ID_veduci] [int] NULL,
	[ID_patri_pod] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projekty]    Script Date: 2/21/2022 15:55:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projekty](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nazov] [nvarchar](50) NOT NULL,
	[ID_veduci] [int] NULL,
	[ID_patri_pod] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zamestnanci]    Script Date: 2/21/2022 15:55:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zamestnanci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Titul] [nvarchar](50) NULL,
	[Meno] [nvarchar](50) NOT NULL,
	[Priezvisko] [nvarchar](50) NOT NULL,
	[Telefon] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Divizie] ON 

INSERT [dbo].[Divizie] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (1, N'Cara', 17, 2)
INSERT [dbo].[Divizie] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (2, N'Kirby', 18, 3)
INSERT [dbo].[Divizie] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (3, N'Sonya', 1, 5)
INSERT [dbo].[Divizie] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (4, N'Lamar', 13, 1)
INSERT [dbo].[Divizie] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (5, N'Allistair', 21, 2)
SET IDENTITY_INSERT [dbo].[Divizie] OFF
GO
SET IDENTITY_INSERT [dbo].[Firma] ON 

INSERT [dbo].[Firma] ([ID], [Nazov], [ID_veduci]) VALUES (1, N'Price', 18)
INSERT [dbo].[Firma] ([ID], [Nazov], [ID_veduci]) VALUES (2, N'Kenyon', 7)
INSERT [dbo].[Firma] ([ID], [Nazov], [ID_veduci]) VALUES (3, N'Lucian', 13)
INSERT [dbo].[Firma] ([ID], [Nazov], [ID_veduci]) VALUES (4, N'Francesca', 1)
INSERT [dbo].[Firma] ([ID], [Nazov], [ID_veduci]) VALUES (5, N'Forrest', 1)
SET IDENTITY_INSERT [dbo].[Firma] OFF
GO
SET IDENTITY_INSERT [dbo].[Oddelenia] ON 

INSERT [dbo].[Oddelenia] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (2, N'Cameron', 21, 2)
INSERT [dbo].[Oddelenia] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (3, N'Lucian', 2, 3)
INSERT [dbo].[Oddelenia] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (4, N'Summer', 2, 4)
INSERT [dbo].[Oddelenia] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (5, N'Nell', 11, 3)
INSERT [dbo].[Oddelenia] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (6, N'Rowan', 27, 1)
SET IDENTITY_INSERT [dbo].[Oddelenia] OFF
GO
SET IDENTITY_INSERT [dbo].[Projekty] ON 

INSERT [dbo].[Projekty] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (1, N'convallis', 22, 3)
INSERT [dbo].[Projekty] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (2, N'Morbi', 29, 5)
INSERT [dbo].[Projekty] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (3, N'lorem', 15, 4)
INSERT [dbo].[Projekty] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (4, N'rutrum.', 4, 1)
INSERT [dbo].[Projekty] ([ID], [Nazov], [ID_veduci], [ID_patri_pod]) VALUES (5, N'nec', 5, 4)
SET IDENTITY_INSERT [dbo].[Projekty] OFF
GO
SET IDENTITY_INSERT [dbo].[Zamestnanci] ON 

INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (1, N'', N'Herman', N'Hunter', N'1-127-961-9253', N'magnis.dis@google.edu')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (2, N'', N'Althea', N'Finch', N'(311) 605-2385', N'pede.malesuada@yahoo.couk')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (3, N'', N'Hoyt', N'Sullivan', N'1-579-337-3379', N'maecenas@protonmail.ca')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (4, N'', N'Fuller', N'Manning', N'1-482-860-8634', N'felis.eget.varius@protonmail.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (5, N'Vestibulum', N'Kevyn', N'Pitts', N'(565) 375-7662', N'phasellus.ornare.fusce@google.edu')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (6, N'et', N'Phillip', N'Combs', N'1-248-361-8373', N'posuere.cubilia@google.edu')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (7, N'Donec', N'Chadwick', N'Ratliff', N'1-472-829-9212', N'sed.neque@google.couk')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (8, N'', N'Axel', N'Hunter', N'(877) 308-5678', N'amet.risus.donec@yahoo.net')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (9, N'', N'Chiquita', N'Howard', N'(461) 303-3407', N'mauris@protonmail.org')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (10, N'dolor.', N'Darryl', N'Coleman', N'1-250-373-7414', N'erat.in@aol.couk')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (11, N'pharetra', N'Jessamine', N'Burgess', N'(587) 446-5237', N'vulputate@outlook.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (12, N'', N'Piper', N'Dudley', N'1-321-256-7274', N'vivamus@hotmail.net')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (13, N'', N'Caryn', N'Holloway', N'(407) 213-5618', N'a.scelerisque.sed@protonmail.ca')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (14, N'urna,', N'Peter', N'Goodman', N'1-228-211-0413', N'mauris@google.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (15, N'Donec', N'Samson', N'Cabrera', N'(368) 342-4145', N'aliquam.ultrices.iaculis@google.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (16, N'', N'MacKensie', N'Reed', N'(896) 716-5211', N'lorem.ut@yahoo.edu')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (17, N'vulputate', N'Chancellor', N'Aguirre', N'(230) 650-8581', N'taciti.sociosqu@protonmail.org')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (18, N'', N'Astra', N'Moon', N'(902) 226-5507', N'cras.sed.leo@icloud.couk')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (19, N'eget', N'Ezra', N'Moses', N'(110) 334-5888', N'donec.tincidunt@outlook.edu')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (20, N'egestas', N'Tara', N'Yates', N'1-204-691-0886', N'eu.lacus@protonmail.org')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (21, N'', N'Hu', N'Clemons', N'1-237-833-2745', N'tortor.dictum@hotmail.couk')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (22, N'Phasellus', N'Sacha', N'Erickson', N'(394) 231-7168', N'eu.arcu@yahoo.ca')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (23, N'magna,', N'Colette', N'Flynn', N'1-658-739-3831', N'fringilla.ornare@yahoo.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (24, N'faucibus.', N'Maya', N'Aguirre', N'1-431-570-4694', N'mauris.suspendisse@aol.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (25, N'arcu.', N'Ursa', N'Barnett', N'(699) 353-8342', N'tortor.nunc.commodo@hotmail.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (26, N'velit', N'Brendan', N'Vazquez', N'1-633-443-5385', N'ipsum.porta.elit@outlook.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (27, N'amet,', N'Iona', N'Wilkinson', N'(739) 784-0439', N'dictum.placerat@protonmail.couk')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (28, N'', N'Tamara', N'Thornton', N'(765) 760-7147', N'lectus.nullam.suscipit@hotmail.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (29, N'mauris,', N'Giacomo', N'Mercer', N'1-416-503-8125', N'eu@protonmail.com')
INSERT [dbo].[Zamestnanci] ([Id], [Titul], [Meno], [Priezvisko], [Telefon], [Email]) VALUES (30, N'magna.', N'Charity', N'Moran', N'1-587-218-6132', N'nunc.sed.orci@google.couk')
SET IDENTITY_INSERT [dbo].[Zamestnanci] OFF
GO
ALTER TABLE [dbo].[Divizie]  WITH CHECK ADD  CONSTRAINT [FK_Divizie_Firma] FOREIGN KEY([ID_patri_pod])
REFERENCES [dbo].[Firma] ([ID])
GO
ALTER TABLE [dbo].[Divizie] CHECK CONSTRAINT [FK_Divizie_Firma]
GO
ALTER TABLE [dbo].[Divizie]  WITH CHECK ADD  CONSTRAINT [FK_Divizie_Zamestnanci] FOREIGN KEY([ID_veduci])
REFERENCES [dbo].[Zamestnanci] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Divizie] CHECK CONSTRAINT [FK_Divizie_Zamestnanci]
GO
ALTER TABLE [dbo].[Firma]  WITH CHECK ADD  CONSTRAINT [FK_Firma_Zamestnanci] FOREIGN KEY([ID_veduci])
REFERENCES [dbo].[Zamestnanci] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Firma] CHECK CONSTRAINT [FK_Firma_Zamestnanci]
GO
ALTER TABLE [dbo].[Oddelenia]  WITH CHECK ADD  CONSTRAINT [FK_Oddelenia_Projekty] FOREIGN KEY([ID_patri_pod])
REFERENCES [dbo].[Projekty] ([ID])
GO
ALTER TABLE [dbo].[Oddelenia] CHECK CONSTRAINT [FK_Oddelenia_Projekty]
GO
ALTER TABLE [dbo].[Oddelenia]  WITH CHECK ADD  CONSTRAINT [FK_Oddelenia_Zamestnanci] FOREIGN KEY([ID_veduci])
REFERENCES [dbo].[Zamestnanci] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Oddelenia] CHECK CONSTRAINT [FK_Oddelenia_Zamestnanci]
GO
ALTER TABLE [dbo].[Projekty]  WITH CHECK ADD  CONSTRAINT [FK_Projekty_Divizie] FOREIGN KEY([ID_patri_pod])
REFERENCES [dbo].[Divizie] ([ID])
GO
ALTER TABLE [dbo].[Projekty] CHECK CONSTRAINT [FK_Projekty_Divizie]
GO
ALTER TABLE [dbo].[Projekty]  WITH CHECK ADD  CONSTRAINT [FK_Projekty_Zamestnanci] FOREIGN KEY([ID_veduci])
REFERENCES [dbo].[Zamestnanci] ([Id])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Projekty] CHECK CONSTRAINT [FK_Projekty_Zamestnanci]
GO
USE [master]
GO
ALTER DATABASE [firma] SET  READ_WRITE 
GO
