USE [master]
GO

/****** Object:  Database [UserActivityDB]    Script Date: 31/3/2023 00:36:25 ******/
CREATE DATABASE [UserActivityDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UserActivityDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\UserActivityDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UserActivityDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\UserActivityDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UserActivityDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [UserActivityDB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [UserActivityDB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [UserActivityDB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [UserActivityDB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [UserActivityDB] SET ARITHABORT OFF 
GO

ALTER DATABASE [UserActivityDB] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [UserActivityDB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [UserActivityDB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [UserActivityDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [UserActivityDB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [UserActivityDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [UserActivityDB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [UserActivityDB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [UserActivityDB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [UserActivityDB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [UserActivityDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [UserActivityDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [UserActivityDB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [UserActivityDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [UserActivityDB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [UserActivityDB] SET READ_COMMITTED_SNAPSHOT ON 
GO

ALTER DATABASE [UserActivityDB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [UserActivityDB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [UserActivityDB] SET  MULTI_USER 
GO

ALTER DATABASE [UserActivityDB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [UserActivityDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [UserActivityDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [UserActivityDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [UserActivityDB] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [UserActivityDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [UserActivityDB] SET QUERY_STORE = ON
GO

ALTER DATABASE [UserActivityDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [UserActivityDB] SET  READ_WRITE 
GO
