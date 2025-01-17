USE [master]
GO
/****** Object:  Database [ZooMarket]    Script Date: 11.12.2024 15:43:45 ******/
CREATE DATABASE [ZooMarket]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ZooMarket', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ZooMarket.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ZooMarket_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ZooMarket_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ZooMarket] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ZooMarket].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ZooMarket] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ZooMarket] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ZooMarket] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ZooMarket] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ZooMarket] SET ARITHABORT OFF 
GO
ALTER DATABASE [ZooMarket] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ZooMarket] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ZooMarket] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ZooMarket] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ZooMarket] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ZooMarket] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ZooMarket] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ZooMarket] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ZooMarket] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ZooMarket] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ZooMarket] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ZooMarket] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ZooMarket] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ZooMarket] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ZooMarket] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ZooMarket] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ZooMarket] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ZooMarket] SET RECOVERY FULL 
GO
ALTER DATABASE [ZooMarket] SET  MULTI_USER 
GO
ALTER DATABASE [ZooMarket] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ZooMarket] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ZooMarket] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ZooMarket] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ZooMarket] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ZooMarket] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ZooMarket', N'ON'
GO
ALTER DATABASE [ZooMarket] SET QUERY_STORE = ON
GO
ALTER DATABASE [ZooMarket] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ZooMarket]
GO
/****** Object:  Table [dbo].[БлокировкаПользователей]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[БлокировкаПользователей](
	[БлокировкаID] [int] IDENTITY(1,1) NOT NULL,
	[СотрудникID] [int] NULL,
	[Дата] [date] NULL,
	[Причина] [nvarchar](255) NULL,
	[IPадрес] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[БлокировкаID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Должности]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Должности](
	[ДолжностьID] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ДолжностьID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ЗаявкиНаПокупку]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ЗаявкиНаПокупку](
	[ЗаявкаID] [int] IDENTITY(1,1) NOT NULL,
	[ДиректорID] [int] NULL,
	[Дата] [date] NULL,
	[Статус] [int] NULL,
	[ПоставщикID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ЗаявкаID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ИзмененияЗП]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ИзмененияЗП](
	[ИзмененияID] [int] IDENTITY(1,1) NOT NULL,
	[СотрудникID] [int] NULL,
	[СтараяЗП] [decimal](18, 2) NULL,
	[НоваяЗП] [decimal](18, 2) NULL,
	[Дата] [date] NULL,
	[Причина] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ИзмененияID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ИсторияВходов]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ИсторияВходов](
	[ЛогID] [int] IDENTITY(1,1) NOT NULL,
	[СотрудникID] [int] NULL,
	[ДатаВхода] [datetime] NULL,
	[IPадрес] [nvarchar](50) NULL,
	[Статус] [int] NULL,
	[Логин] [nvarchar](50) NULL,
	[Пароль] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ЛогID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[КатегорииТоваров]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[КатегорииТоваров](
	[КатегорияID] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[КатегорияID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Клиенты]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Клиенты](
	[КлиентID] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nvarchar](100) NOT NULL,
	[Адрес] [nvarchar](255) NULL,
	[Телефон] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[КонтактноеЛицо] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[КлиентID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Поставки]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Поставки](
	[ПоставкаID] [int] IDENTITY(1,1) NOT NULL,
	[СотрудникID] [int] NULL,
	[ДатаПоставки] [date] NULL,
	[ПоставщикID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ПоставкаID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Поставщики]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Поставщики](
	[ПоставщикID] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nvarchar](100) NOT NULL,
	[Адрес] [nvarchar](255) NULL,
	[Телефон] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NULL,
	[КонтактноеЛицо] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ПоставщикID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Премии]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Премии](
	[ПремияID] [int] IDENTITY(1,1) NOT NULL,
	[СотрудникID] [int] NULL,
	[Сумма] [decimal](18, 2) NULL,
	[Дата] [date] NULL,
	[Причина] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ПремияID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Продажи]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Продажи](
	[ПродажаID] [int] IDENTITY(1,1) NOT NULL,
	[СотрудникID] [int] NULL,
	[Дата] [date] NULL,
	[Сумма] [decimal](18, 2) NULL,
	[КлиентID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ПродажаID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[СоставЗаявки]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СоставЗаявки](
	[ЗаявкиID] [int] NOT NULL,
	[ТоварID] [int] NOT NULL,
	[Количество] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ЗаявкиID] ASC,
	[ТоварID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[СоставПоставки]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СоставПоставки](
	[ПоставкаID] [int] NOT NULL,
	[ТоварID] [int] NOT NULL,
	[Количество] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ПоставкаID] ASC,
	[ТоварID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[СоставПродажи]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СоставПродажи](
	[ПродажаID] [int] NOT NULL,
	[ТоварID] [int] NOT NULL,
	[Количество] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ПродажаID] ASC,
	[ТоварID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Сотрудники]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Сотрудники](
	[СотрудникID] [int] IDENTITY(1,1) NOT NULL,
	[ФИО] [nvarchar](150) NOT NULL,
	[ДолжностьID] [int] NULL,
	[Зарплата] [decimal](18, 2) NULL,
	[ДатаПриема] [date] NULL,
	[ДатаУвольнения] [date] NULL,
	[Логин] [nvarchar](50) NULL,
	[Пароль] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[СотрудникID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[СписаниеТоваров]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СписаниеТоваров](
	[СписаниеID] [int] IDENTITY(1,1) NOT NULL,
	[СотрудникID] [int] NULL,
	[ТоварID] [int] NULL,
	[ДатаСписания] [date] NULL,
	[Количество] [int] NULL,
	[Причина] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[СписаниеID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[СтатусВхода]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СтатусВхода](
	[СтатусID] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[СтатусID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[СтатусыЗаявки]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[СтатусыЗаявки](
	[СтатусID] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[СтатусID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ТипТовара]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ТипТовара](
	[ТипТовараID] [int] IDENTITY(1,1) NOT NULL,
	[Наименование] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ТипТовараID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Товары]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Товары](
	[ТоварID] [int] IDENTITY(1,1) NOT NULL,
	[Название] [nvarchar](100) NOT NULL,
	[Описание] [nvarchar](255) NULL,
	[Цена] [decimal](18, 2) NULL,
	[Количество] [int] NULL,
	[СрокГодности] [date] NULL,
	[ТипТовара] [int] NULL,
	[ПоставщикID] [int] NULL,
	[КатегорияID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ТоварID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Увольнения]    Script Date: 11.12.2024 15:43:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Увольнения](
	[УвольнениеID] [int] IDENTITY(1,1) NOT NULL,
	[СотрудникID] [int] NULL,
	[ДатаУвольнения] [date] NULL,
	[Причина] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[УвольнениеID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[БлокировкаПользователей]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[БлокировкаПользователей]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[ЗаявкиНаПокупку]  WITH CHECK ADD FOREIGN KEY([ДиректорID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[ЗаявкиНаПокупку]  WITH CHECK ADD FOREIGN KEY([ДиректорID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[ЗаявкиНаПокупку]  WITH CHECK ADD FOREIGN KEY([ПоставщикID])
REFERENCES [dbo].[Поставщики] ([ПоставщикID])
GO
ALTER TABLE [dbo].[ЗаявкиНаПокупку]  WITH CHECK ADD FOREIGN KEY([ПоставщикID])
REFERENCES [dbo].[Поставщики] ([ПоставщикID])
GO
ALTER TABLE [dbo].[ЗаявкиНаПокупку]  WITH CHECK ADD FOREIGN KEY([Статус])
REFERENCES [dbo].[СтатусыЗаявки] ([СтатусID])
GO
ALTER TABLE [dbo].[ЗаявкиНаПокупку]  WITH CHECK ADD FOREIGN KEY([Статус])
REFERENCES [dbo].[СтатусыЗаявки] ([СтатусID])
GO
ALTER TABLE [dbo].[ИзмененияЗП]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[ИзмененияЗП]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[ИсторияВходов]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[ИсторияВходов]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[ИсторияВходов]  WITH CHECK ADD FOREIGN KEY([Статус])
REFERENCES [dbo].[СтатусВхода] ([СтатусID])
GO
ALTER TABLE [dbo].[ИсторияВходов]  WITH CHECK ADD FOREIGN KEY([Статус])
REFERENCES [dbo].[СтатусВхода] ([СтатусID])
GO
ALTER TABLE [dbo].[Поставки]  WITH CHECK ADD FOREIGN KEY([ПоставщикID])
REFERENCES [dbo].[Поставщики] ([ПоставщикID])
GO
ALTER TABLE [dbo].[Поставки]  WITH CHECK ADD FOREIGN KEY([ПоставщикID])
REFERENCES [dbo].[Поставщики] ([ПоставщикID])
GO
ALTER TABLE [dbo].[Поставки]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[Поставки]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[Премии]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[Премии]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[Продажи]  WITH CHECK ADD FOREIGN KEY([КлиентID])
REFERENCES [dbo].[Клиенты] ([КлиентID])
GO
ALTER TABLE [dbo].[Продажи]  WITH CHECK ADD FOREIGN KEY([КлиентID])
REFERENCES [dbo].[Клиенты] ([КлиентID])
GO
ALTER TABLE [dbo].[Продажи]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[Продажи]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[СоставЗаявки]  WITH CHECK ADD FOREIGN KEY([ЗаявкиID])
REFERENCES [dbo].[ЗаявкиНаПокупку] ([ЗаявкаID])
GO
ALTER TABLE [dbo].[СоставЗаявки]  WITH CHECK ADD FOREIGN KEY([ЗаявкиID])
REFERENCES [dbo].[ЗаявкиНаПокупку] ([ЗаявкаID])
GO
ALTER TABLE [dbo].[СоставЗаявки]  WITH CHECK ADD FOREIGN KEY([ТоварID])
REFERENCES [dbo].[Товары] ([ТоварID])
GO
ALTER TABLE [dbo].[СоставПоставки]  WITH CHECK ADD FOREIGN KEY([ПоставкаID])
REFERENCES [dbo].[Поставки] ([ПоставкаID])
GO
ALTER TABLE [dbo].[СоставПоставки]  WITH CHECK ADD FOREIGN KEY([ТоварID])
REFERENCES [dbo].[Товары] ([ТоварID])
GO
ALTER TABLE [dbo].[СоставПоставки]  WITH CHECK ADD FOREIGN KEY([ТоварID])
REFERENCES [dbo].[Товары] ([ТоварID])
GO
ALTER TABLE [dbo].[СоставПродажи]  WITH CHECK ADD FOREIGN KEY([ПродажаID])
REFERENCES [dbo].[Продажи] ([ПродажаID])
GO
ALTER TABLE [dbo].[СоставПродажи]  WITH CHECK ADD FOREIGN KEY([ПродажаID])
REFERENCES [dbo].[Продажи] ([ПродажаID])
GO
ALTER TABLE [dbo].[СоставПродажи]  WITH CHECK ADD FOREIGN KEY([ТоварID])
REFERENCES [dbo].[Товары] ([ТоварID])
GO
ALTER TABLE [dbo].[Сотрудники]  WITH CHECK ADD FOREIGN KEY([ДолжностьID])
REFERENCES [dbo].[Должности] ([ДолжностьID])
GO
ALTER TABLE [dbo].[Сотрудники]  WITH CHECK ADD FOREIGN KEY([ДолжностьID])
REFERENCES [dbo].[Должности] ([ДолжностьID])
GO
ALTER TABLE [dbo].[СписаниеТоваров]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[СписаниеТоваров]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[СписаниеТоваров]  WITH CHECK ADD FOREIGN KEY([ТоварID])
REFERENCES [dbo].[Товары] ([ТоварID])
GO
ALTER TABLE [dbo].[Товары]  WITH CHECK ADD FOREIGN KEY([КатегорияID])
REFERENCES [dbo].[КатегорииТоваров] ([КатегорияID])
GO
ALTER TABLE [dbo].[Товары]  WITH CHECK ADD FOREIGN KEY([КатегорияID])
REFERENCES [dbo].[КатегорииТоваров] ([КатегорияID])
GO
ALTER TABLE [dbo].[Товары]  WITH CHECK ADD FOREIGN KEY([ПоставщикID])
REFERENCES [dbo].[Поставщики] ([ПоставщикID])
GO
ALTER TABLE [dbo].[Товары]  WITH CHECK ADD FOREIGN KEY([ПоставщикID])
REFERENCES [dbo].[Поставщики] ([ПоставщикID])
GO
ALTER TABLE [dbo].[Товары]  WITH CHECK ADD FOREIGN KEY([ТипТовара])
REFERENCES [dbo].[ТипТовара] ([ТипТовараID])
GO
ALTER TABLE [dbo].[Товары]  WITH CHECK ADD FOREIGN KEY([ТипТовара])
REFERENCES [dbo].[ТипТовара] ([ТипТовараID])
GO
ALTER TABLE [dbo].[Увольнения]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
ALTER TABLE [dbo].[Увольнения]  WITH CHECK ADD FOREIGN KEY([СотрудникID])
REFERENCES [dbo].[Сотрудники] ([СотрудникID])
GO
USE [master]
GO
ALTER DATABASE [ZooMarket] SET  READ_WRITE 
GO
