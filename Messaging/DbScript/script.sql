USE [master]
GO
ALTER DATABASE [MEPDb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MEPDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MEPDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MEPDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MEPDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MEPDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MEPDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [MEPDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MEPDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MEPDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MEPDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MEPDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MEPDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MEPDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MEPDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MEPDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MEPDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MEPDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MEPDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MEPDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MEPDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MEPDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MEPDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MEPDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MEPDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MEPDb] SET  MULTI_USER 
GO
ALTER DATABASE [MEPDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MEPDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MEPDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MEPDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MEPDb]
GO
/****** Object:  Table [dbo].[UserRegistration]    Script Date: 23-11-2015 17:46:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserRegistration](
	[Uid] [int] IDENTITY(1,1) NOT NULL,
	[UserEmail] [varchar](50) NOT NULL,
	[EmailSentFlag] [varchar](50) NOT NULL CONSTRAINT [DF_UserRegistration_EmailSentFlag]  DEFAULT ('F'),
 CONSTRAINT [PK_UserRegistration] PRIMARY KEY CLUSTERED 
(
	[Uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [MEPDb] SET  READ_WRITE 
GO
