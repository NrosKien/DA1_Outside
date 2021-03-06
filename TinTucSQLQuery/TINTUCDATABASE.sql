USE [master]
GO

/****** Object:  Database [TinTuc]    Script Date: 04/25/2021 21:41:26 ******/
CREATE DATABASE [TinTuc] ON  PRIMARY 
( NAME = N'TinTuc', FILENAME = N'd:\Program Files\Microsoft SQL Server\Instance\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\TinTuc.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'TinTuc_log', FILENAME = N'd:\Program Files\Microsoft SQL Server\Instance\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\TinTuc_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [TinTuc] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TinTuc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [TinTuc] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [TinTuc] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [TinTuc] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [TinTuc] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [TinTuc] SET ARITHABORT OFF 
GO

ALTER DATABASE [TinTuc] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [TinTuc] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [TinTuc] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [TinTuc] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [TinTuc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [TinTuc] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [TinTuc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [TinTuc] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [TinTuc] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [TinTuc] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [TinTuc] SET  DISABLE_BROKER 
GO

ALTER DATABASE [TinTuc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [TinTuc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [TinTuc] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [TinTuc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [TinTuc] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [TinTuc] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [TinTuc] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [TinTuc] SET  READ_WRITE 
GO

ALTER DATABASE [TinTuc] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [TinTuc] SET  MULTI_USER 
GO

ALTER DATABASE [TinTuc] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [TinTuc] SET DB_CHAINING OFF 
GO

