USE [master]
GO
/****** Object:  Database [TransactionDb]    Script Date: 23-11-2015 17:49:24 ******/
ALTER DATABASE [TransactionDb] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TransactionDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TransactionDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TransactionDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TransactionDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TransactionDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TransactionDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [TransactionDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TransactionDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TransactionDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TransactionDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TransactionDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TransactionDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TransactionDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TransactionDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TransactionDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TransactionDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TransactionDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TransactionDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TransactionDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TransactionDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TransactionDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TransactionDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TransactionDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TransactionDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TransactionDb] SET  MULTI_USER 
GO
ALTER DATABASE [TransactionDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TransactionDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TransactionDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TransactionDb] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [TransactionDb]
GO
/****** Object:  UserDefinedFunction [dbo].[fn_GetStatus]    Script Date: 23-11-2015 17:49:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[fn_GetStatus](@Salary as float)
returns varchar(10)
as
begin
	declare @Result as Varchar(10)
	Set @Result =
				case 
				when @Salary <= 8000 then 'OK'
				when @Salary >8000 then 'Good'
				end
	return @Result
end
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 23-11-2015 17:49:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[Eid] [int] IDENTITY(1,1) NOT NULL,
	[EName] [varchar](50) NOT NULL,
	[ESalary] [float] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Eid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalaryHistory]    Script Date: 23-11-2015 17:49:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryHistory](
	[SNo] [int] IDENTITY(1000,1) NOT NULL,
	[Eid] [int] NULL,
	[ESalary] [float] NULL,
	[StDate] [date] NULL,
	[EdDate] [date] NULL,
 CONSTRAINT [PK_Employee_Salary] PRIMARY KEY CLUSTERED 
(
	[SNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[SalaryHistory]  WITH CHECK ADD  CONSTRAINT [FK_SalaryHistory_Employee] FOREIGN KEY([Eid])
REFERENCES [dbo].[Employee] ([Eid])
GO
ALTER TABLE [dbo].[SalaryHistory] CHECK CONSTRAINT [FK_SalaryHistory_Employee]
GO
/****** Object:  StoredProcedure [dbo].[sp_myTrans]    Script Date: 23-11-2015 17:49:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_myTrans]
as
begin try
begin tran MyTran
	insert into Employee values ('David',8000)
	declare @id as int
	set @id=SCOPE_IDENTITY()
	insert into SalaryHistory values(@id,8000,GetDate(),NULL)
	commit tran MyTran
end try
begin catch
	print 'Error Occurred'
	rollback tran MyTran
end catch
GO
/****** Object:  StoredProcedure [dbo].[Sp_TransactionHistory]    Script Date: 23-11-2015 17:49:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_TransactionHistory]
as
begin try
	begin tran MyTran
	declare @id as int
	insert into Employee values ('Lilly',9000)
	set @id=SCOPE_IDENTITY()
	insert into SalaryHistory values (@id,9000,GetDate(),NULL)
	commit tran MyTran
end try
begin catch
	print 'Error occoured'
	rollback tran MyTran
end catch
GO
USE [master]
GO
ALTER DATABASE [TransactionDb] SET  READ_WRITE 
GO
