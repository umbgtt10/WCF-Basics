USE [master]
GO
/****** Object:  Database [MyOrg]    Script Date: 05-01-2016 10:41:28 ******/
ALTER DATABASE [MyOrg] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MyOrg].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MyOrg] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MyOrg] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MyOrg] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MyOrg] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MyOrg] SET ARITHABORT OFF 
GO
ALTER DATABASE [MyOrg] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MyOrg] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MyOrg] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MyOrg] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MyOrg] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MyOrg] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MyOrg] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MyOrg] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MyOrg] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MyOrg] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MyOrg] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MyOrg] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MyOrg] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MyOrg] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MyOrg] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MyOrg] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MyOrg] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MyOrg] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MyOrg] SET  MULTI_USER 
GO
ALTER DATABASE [MyOrg] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MyOrg] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MyOrg] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MyOrg] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [MyOrg]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [int] NOT NULL,
	[CourseName] [varchar](50) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Department]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[Did] [int] IDENTITY(1000,1) NOT NULL,
	[DName] [varchar](50) NOT NULL,
	[HOD] [varchar](50) NULL,
	[Gender] [varchar](50) NULL CONSTRAINT [DF_Department_Gender]  DEFAULT ('M'),
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Did] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[Eid] [int] NOT NULL,
	[EName] [varchar](50) NOT NULL,
	[ESalary] [float] NOT NULL,
	[EGender] [varchar](50) NOT NULL,
	[EDOB] [datetime] NOT NULL,
	[Did] [int] NULL,
	[UpdatedDate] [timestamp] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Eid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EmployeeCourse]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeCourse](
	[EmployeeCourseID] [int] IDENTITY(10000,1) NOT NULL,
	[Eid] [int] NULL,
	[CourseId] [int] NULL,
	[Marks] [tinyint] NULL,
 CONSTRAINT [PK_EmployeeCourse] PRIMARY KEY CLUSTERED 
(
	[EmployeeCourseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Person]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[PersonId] [int] NOT NULL,
	[PersonName] [varchar](50) NULL,
	[PersonEmail] [varchar](50) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonAddress]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonAddress](
	[PersonId] [int] NOT NULL,
	[Address] [varchar](50) NULL,
	[Pin] [varchar](50) NULL,
 CONSTRAINT [PK_PersonAddress] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[GetData]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetData]
(
	
)
RETURNS table
AS

return (select * from Employee)
GO
/****** Object:  View [dbo].[vw_EmployeeDetails]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_EmployeeDetails]
as
Select E.Eid,E.EName,E.ESalary,E.EGender,E.EDOB,D.DName,D.HOD
from Employee E join Department D on E.Did=D.Did
GO
/****** Object:  View [dbo].[vw_EmployeeInfo]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[vw_EmployeeInfo]
as
select Eid,EName,EGender from Employee
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([Did])
REFERENCES [dbo].[Department] ([Did])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[EmployeeCourse]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeCourse_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[EmployeeCourse] CHECK CONSTRAINT [FK_EmployeeCourse_Course]
GO
ALTER TABLE [dbo].[EmployeeCourse]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeCourse_Employee] FOREIGN KEY([Eid])
REFERENCES [dbo].[Employee] ([Eid])
GO
ALTER TABLE [dbo].[EmployeeCourse] CHECK CONSTRAINT [FK_EmployeeCourse_Employee]
GO
ALTER TABLE [dbo].[PersonAddress]  WITH CHECK ADD  CONSTRAINT [FK_PersonAddress_Person] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[PersonAddress] CHECK CONSTRAINT [FK_PersonAddress_Person]
GO
/****** Object:  StoredProcedure [dbo].[DeleteDepartment]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[DeleteDepartment]
(@Did as int)
as
Delete from Department where Did=@Did
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmp]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[GetAllEmp]
as
select *,DATEDIFF(YY,EDOB,getdate()) as Age from Employee
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmpByDid]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllEmpByDid]
(@Did as int)
as
select * from Employee
where (@Did is null or Did=@Did) 
GO
/****** Object:  StoredProcedure [dbo].[GetAllTables]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetAllTables]
as
select * from Department
select * from Employee
GO
/****** Object:  StoredProcedure [dbo].[GetEmpSalByEid]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[GetEmpSalByEid]
(@Eid as int,@Salary as float output)
as
select @Salary=Esalary from Employee where Eid=@Eid
GO
/****** Object:  StoredProcedure [dbo].[InsertDepartment]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[InsertDepartment]
(@DName as Varchar(50), @HOD as varchar(50), @Gender as Varchar(50))
as
INSERT INTO Department (DName,HOD,Gender) VALUES (@DName,@HOD,@Gender)
GO
/****** Object:  StoredProcedure [dbo].[UpdateDepartment]    Script Date: 05-01-2016 10:41:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[UpdateDepartment]
(@DName as Varchar(50), @HOD as varchar(50), @Gender as Varchar(50),@Did as int)
as
Update Department Set DName=@DName,HOD=@HOD,Gender=@Gender where Did=@Did
GO
USE [master]
GO
ALTER DATABASE [MyOrg] SET  READ_WRITE 
GO
