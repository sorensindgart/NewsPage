/****** Object:  Database [dbNews]    Script Date: 12/04/2015 10:23:11 ******/
CREATE DATABASE [dbNews] ON  PRIMARY 
( NAME = N'dbNews', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\dbNews.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbNews_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\dbNews_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbNews] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbNews].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbNews] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [dbNews] SET ANSI_NULLS OFF
GO
ALTER DATABASE [dbNews] SET ANSI_PADDING OFF
GO
ALTER DATABASE [dbNews] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [dbNews] SET ARITHABORT OFF
GO
ALTER DATABASE [dbNews] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [dbNews] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [dbNews] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [dbNews] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [dbNews] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [dbNews] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [dbNews] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [dbNews] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [dbNews] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [dbNews] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [dbNews] SET  DISABLE_BROKER
GO
ALTER DATABASE [dbNews] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [dbNews] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [dbNews] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [dbNews] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [dbNews] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [dbNews] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [dbNews] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [dbNews] SET  READ_WRITE
GO
ALTER DATABASE [dbNews] SET RECOVERY SIMPLE
GO
ALTER DATABASE [dbNews] SET  MULTI_USER
GO
ALTER DATABASE [dbNews] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [dbNews] SET DB_CHAINING OFF
GO
/****** Object:  Table [dbo].[tblKontakt]    Script Date: 12/04/2015 10:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKontakt](
	[fldFirmanavn] [varchar](50) NULL,
	[fldAdresse] [varchar](50) NULL,
	[fldPostnummer] [varchar](4) NULL,
	[fldBy] [varchar](50) NULL,
	[fldTelefon] [varchar](16) NULL,
	[fldEmail] [varchar](70) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblKontakt] ([fldFirmanavn], [fldAdresse], [fldPostnummer], [fldBy], [fldTelefon], [fldEmail]) VALUES (N'NewsSite', N'Domkirketorvet 12b 1. th.', N'8000', N'Aarhus C', N'86 34 18 12', N'newssite@newssite.dk')
/****** Object:  Table [dbo].[tblKategorier]    Script Date: 12/04/2015 10:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblKategorier](
	[fldKatID] [int] IDENTITY(1,1) NOT NULL,
	[fldKategori] [varchar](50) NULL,
	[fldKatImage] [varchar](150) NULL,
 CONSTRAINT [PK_tblKategorier] PRIMARY KEY CLUSTERED 
(
	[fldKatID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblKategorier] ON
INSERT [dbo].[tblKategorier] ([fldKatID], [fldKategori], [fldKatImage]) VALUES (1, N'Indland', N'indland.png')
INSERT [dbo].[tblKategorier] ([fldKatID], [fldKategori], [fldKatImage]) VALUES (2, N'Udland', N'udland.png')
INSERT [dbo].[tblKategorier] ([fldKatID], [fldKategori], [fldKatImage]) VALUES (3, N'Sport', N'sport.png')
INSERT [dbo].[tblKategorier] ([fldKatID], [fldKategori], [fldKatImage]) VALUES (4, N'Krimi', N'krimi.png')
INSERT [dbo].[tblKategorier] ([fldKatID], [fldKategori], [fldKatImage]) VALUES (5, N'Underholdning', N'underholdning.png')
SET IDENTITY_INSERT [dbo].[tblKategorier] OFF
/****** Object:  Table [dbo].[tblBruger]    Script Date: 12/04/2015 10:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBruger](
	[fldID] [int] IDENTITY(1,1) NOT NULL,
	[fldBrugernavn] [varchar](50) NULL,
	[fldPassword] [varchar](20) NULL,
	[fldEmail] [varchar](50) NULL,
 CONSTRAINT [PK_tblBruger] PRIMARY KEY CLUSTERED 
(
	[fldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblBruger] ON
INSERT [dbo].[tblBruger] ([fldID], [fldBrugernavn], [fldPassword], [fldEmail]) VALUES (1, N'admin', N'abc123', N'admin@admin.dk')
INSERT [dbo].[tblBruger] ([fldID], [fldBrugernavn], [fldPassword], [fldEmail]) VALUES (2, N'admin', N'admin', N'admin2@admin2.dk')
SET IDENTITY_INSERT [dbo].[tblBruger] OFF
/****** Object:  Table [dbo].[tblVidsteDu]    Script Date: 12/04/2015 10:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblVidsteDu](
	[fldID] [int] IDENTITY(1,1) NOT NULL,
	[fldOverskrift] [varchar](50) NULL,
	[fldVidsteDuTekst] [varchar](250) NULL,
 CONSTRAINT [PK_tblVidsteDu] PRIMARY KEY CLUSTERED 
(
	[fldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblVidsteDu] ON
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (1, N'Flyulykker', N'Æsler dræber hvert år flere mennesker end flyulykker.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (2, N'Umuligt', N'Det er fysisk umligt at slikke sig selv på albuen.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (3, N'Hjernen', N'Hjernen består af 80% vand.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (4, N'Kalorier', N'Man forbrænder flere kalorier ved at sove, end ved at se TV.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (5, N'Coca Cola', N'Coca-Cola oprindelig var grøn.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (6, N'Prosit', N'Et nys kan komme op på 400 km/t.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (7, N'Dynamit', N'Peanuts er en ingrediens i fremstilling af dynamit.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (8, N'Tung(e)', N'En almindelig elefant vejer sædvanligvis mindre end tungen på en blåhval.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (9, N'Guldfisk', N'En guldfisk har en korttidshukommelse på tre sekunder.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (10, N'Tastetur', N'"Stewardesse" staves udelukkende med venstre hånd på et tastetur.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (11, N'Toiletpapir', N'En rulle toiletpapir har i gennemsnit 333 stykker.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (12, N'Jern', N'Der er nok jern i et menneskes krop til at kunne lave et lille søm.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (13, N'Søer', N'Canada har flere søer end resten af verden har tilsammen.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (14, N'Medicin', N'Mindre end 20% af medicinske procedurer er blevet dokumenteret brugbare ved kontrollerede, medicinske.')
INSERT [dbo].[tblVidsteDu] ([fldID], [fldOverskrift], [fldVidsteDuTekst]) VALUES (15, N'Lyskryds', N'Man bruge i gennemsnit 12 uger af sit liv på.')
SET IDENTITY_INSERT [dbo].[tblVidsteDu] OFF
/****** Object:  Table [dbo].[tblNyheder]    Script Date: 12/04/2015 10:23:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblNyheder](
	[fldID] [int] IDENTITY(1,1) NOT NULL,
	[fldOverskrift] [varchar](150) NULL,
	[fldTeaser] [varchar](250) NULL,
	[fldTekst] [varchar](max) NULL,
	[fldDato] [datetime] NULL,
	[fldImage] [varchar](150) NULL,
	[fldKatID_fk] [int] NOT NULL,
 CONSTRAINT [PK_tblNyheder] PRIMARY KEY CLUSTERED 
(
	[fldID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblNyheder] ON
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (1, N'Frederik og Mary på hemmelig rejse', N'Kronprins Frederik og kronprinsesse Mary er taget på uofficiel rejse. De skal angiveligt på privat slædetur i den storslåede grønlandske natur.', N'Grønlands Lufthavne har tirsdag afsløret billeder fra en lille lufthavn på Østgrønland, hvor Kronprinsparret pludselig dukkede op tirsdag.', CAST(0x0000A41E00000000 AS DateTime), N'royal.jpg', 1)
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (2, N'Badminton-bosser vil stoppe medlemsflugt', N'DGI Badminton og Badminton Danmark samler kræfterne for at vende badmintons nedgang i antallet af medlemmer.', N'Badmintonklubberne skal op på dupperne og have langt mere fokus på at skabe spændende klubmiljøer, der kan tiltrække flere medlemmer. - Det er meget alvorligt. Badminton oplever en deroute. Vi bliver nødt til at tage en ny kasket på og tænke nyt, siger Ib Møller.', CAST(0x0000A41E00000000 AS DateTime), N'badminton.jpg', 3)
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (3, N'24-årig idømt forvaring for dødsvold', N'24-årige Dennis Vestergaard er idømt forvaring for at banke rocker ihjel med næverne, skriver Ekstra Bladet.', N'NULLDen 24-årige Dennis Kronome Vestergaard er idømt forvaring på ubestemt tid for at banke Bandidos-rockeren Poul Joachim Hansen, kaldet Big Mac'', til døde med knytnæveslag på et værtshus i Helsinge i Nordsjælland. Et enigt nævningeting slog onsdag fast, at forvaring er nødvendig for at forhindre nye forbrydelser fra den 24-årige.', CAST(0x0000A41E00000000 AS DateTime), N'dommer.jpg', 4)
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (4, N'Skraldemænd kede af det: Arbejder så meget vi kan', N'De strejkende skraldemænd i København har valgt at genoptage arbejdet. En midlertidig aftale har givet parterne ro til at forhandle. Skraldemændene vil gøre en ekstra indsats for at få fjernet alt det ophobede affald.', N'De strejkende skraldemænd i København har nu valgt at genoptage arbejdet, lyder det i en pressemeddelelse. - Vi har indgået en skriftlig aftale om, at renovationsfirmaet M. Larsen fortsætter i tre måneder med samme antal ansatte. I de tre måneder skal vi med kommunens advokat ved bordenden forsøge at lave en aftale om, hvordan driften skal være på Østerbro og Nørrebro efter 1. august, hvor City Renovation overtager driften. Inden da skal vi have nået en endelig aftale, siger faglig sekretær John Ø. Pedersen fra 3F Kastrup til Politiken.', CAST(0x0000A41E00000000 AS DateTime), N'skrald.jpg', 1)
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (8, N'Mand skaffede lovlige rør til joints - får fængsel i to år', N'Tømrer fra København skal i fængsel, fordi byretten finder det bevist, at han hjalp stor joint-fabrik.', N'Alle de varer, han skaffede, var indkøbt på fuldt lovlig vis - men alligevel skal han i fængsel. - Hvordan kan jeg være ansvarlig for, hvad andre foretager sig, spørger han. På stedet har han anket dommen til Østre Landsret.', CAST(0x0000A41E00000000 AS DateTime), N'drug.jpg', 4)
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (9, N'Skader tvinger U21-landstræner i tænkeboks', N'U21-landstræner Jess Thorup overvejer at lede efter helt nye spillere til angrebet efter de mange skadesafbud.', N'Det giver ikke kun hovedpine i FC København, at Andreas Cornelius, Youssef Toutouh og Danny Amankwaa har pådraget sig skader. - Cornelius'' fravær gør, at jeg skal til at tænke alternativt. Måske skal jeg ud og kigge efter helt andre typer - eller eventuelt kigge på en ny opstilling. Thorup udvælger sin bruttotrup til EM inden for samme periode, som Morten Olsen afslører navnene til de to næste A-landsholdskampe.', CAST(0x0000A41E00000000 AS DateTime), N'bold.jpg', 3)
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (10, N'Op mod to millioner børn i akut nød i Nepal', N'Op mod halvdelen af befolkningen i Nepal er børn. Mange af dem står uden tag over hovedet og trues af sygdom.', N'Omkring 1,7 millioner børn er i akut nød efter jordskælvskatastrofen i Nepal, siger FN''s børnefond Unicef. Op mod halvdelen af befolkningen i Nepal er børn.', CAST(0x0000A41E00000000 AS DateTime), N'nepal.jpg', 2)
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (11, N'Saudiarabere tvinges tættere på USA', N'Ny kronprins og udenrigsminister i Saudi-Arabien har USA-venlig baggrund, siger ekspert.', N'Den saudiarabiske kong Salmans udpegning af sin nevø som kronprins er et forsøg på at gøre et ellers køligt forhold til USA varmere, mener ekspert. Saudi-Arabien er omringet af opløsningstruede lande, som det selv er militært involveret i. Og det tvinger nu landet til at lede efter andre alliancer, der blandt andet kan styrke det i rivaliseringen med Iran.', CAST(0x0000A41E00000000 AS DateTime), N'saudi.jpg', 2)
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (12, N'Hollywoodpar krydser kærlige klinger', N'Efter 20-års venskab blev Charlize Theron og Sean Penn kærester, og selv om alt kører privat, løber temperamenterne løbsk professionelt.', N'Der skulle gå hele 20 år, inden Sean Penn og Charlize Theron fandt sammen som kærester. - Der var øjeblikke, hvor jeg var meget urimelig over for ham, og øjeblikke hvor jeg følte, at han var utrolig urimelig over for mig. Men det får én til at indse, at uanset hvor kompliceret tingene bliver, så er førsteprioriteten forholdet, siger Theron, som trods de professionelle gnidninger indså, hvor meget Penn betyder for hende.', CAST(0x0000A41E00000000 AS DateTime), N'klinger.jpg', 5)
INSERT [dbo].[tblNyheder] ([fldID], [fldOverskrift], [fldTeaser], [fldTekst], [fldDato], [fldImage], [fldKatID_fk]) VALUES (13, N'Madonna overrasker rapper med vådt kys', N'Sangerinden Madonna kastede sig under en musikfestival ud i et hedt kys med en af hiphoppens største stjerner.', N'56-årige Madonna er kendt for at slå kløerne i unge fyre, og søndag aften kastede hun sig så over rapperen Drake på 28 år. Det skriver ABC News. Bagefter valsede hun af scenen med ordene: - Jeg er Madonna.', CAST(0x0000A41E00000000 AS DateTime), N'madonna.jpg', 5)
SET IDENTITY_INSERT [dbo].[tblNyheder] OFF
/****** Object:  ForeignKey [FK_tblNyheder_tblKategorier]    Script Date: 12/04/2015 10:23:14 ******/
ALTER TABLE [dbo].[tblNyheder]  WITH CHECK ADD  CONSTRAINT [FK_tblNyheder_tblKategorier] FOREIGN KEY([fldKatID_fk])
REFERENCES [dbo].[tblKategorier] ([fldKatID])
GO
ALTER TABLE [dbo].[tblNyheder] CHECK CONSTRAINT [FK_tblNyheder_tblKategorier]
GO
