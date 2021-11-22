USE [master]
GO

/****** Object:  Database [DBLibrary]    Script Date: 22/11/2021 5:13:21 PM ******/
CREATE DATABASE [DBLibrary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBLibrary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DBLibrary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBLibrary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DBLibrary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBLibrary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [DBLibrary] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [DBLibrary] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [DBLibrary] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [DBLibrary] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [DBLibrary] SET ARITHABORT OFF 
GO

ALTER DATABASE [DBLibrary] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [DBLibrary] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [DBLibrary] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [DBLibrary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [DBLibrary] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [DBLibrary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [DBLibrary] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [DBLibrary] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [DBLibrary] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [DBLibrary] SET  ENABLE_BROKER 
GO

ALTER DATABASE [DBLibrary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [DBLibrary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [DBLibrary] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [DBLibrary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [DBLibrary] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [DBLibrary] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [DBLibrary] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [DBLibrary] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [DBLibrary] SET  MULTI_USER 
GO

ALTER DATABASE [DBLibrary] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [DBLibrary] SET DB_CHAINING OFF 
GO

ALTER DATABASE [DBLibrary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [DBLibrary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [DBLibrary] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [DBLibrary] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [DBLibrary] SET QUERY_STORE = OFF
GO

ALTER DATABASE [DBLibrary] SET  READ_WRITE 
GO
