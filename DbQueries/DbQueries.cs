//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace SchoolManagementSystem.DbQueries
//{
//    public class DbQueries
//    {
//    }
//}

/*
 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ApprovalOfFees](

[StudentId][int] NOT NULL,

[ClassId] [int] NULL,
	[SectionId] [int] NULL,
	[FeesId] [int] NULL,
	[UTR] [nvarchar](50) NULL,
	[PaidAmount] [decimal](18, 2) NULL,
	[RemainingAmount] [decimal](18, 2) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOn] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Class](

[ClassId][int] NOT NULL,

[ClassName] [nvarchar](255) NULL,
	[ClassTeacherId] [int] NULL,
	[NumberOfSections] [int] NULL,
	[TotalStudents] [int] NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]
GO



USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClassAttendance](
	[AttendanceId] [int] NOT NULL,
	[ClassId] [int] NULL,
	[Date] [datetime] NULL,
	[Present] [int] NULL,
	[Absent] [int] NULL,
	[TotalStudents] [int] NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AttendanceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ClassTeacher](
	[ClassTeacherId] [int] NOT NULL,
	[StaffId] [int] NULL,
	[ClassId] [int] NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassTeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ComplainByStudent](
	[StudentId] [int] NULL,
	[StudentName] [nvarchar](255) NULL,
	[ClassId] [int] NULL,
	[SectionId] [int] NULL,
	[ComplainAgainst] [nvarchar](max) NULL,
	[UpdatedByStudentId] [int] NULL,
	[UpdatedByStudentName] [nvarchar](255) NULL,
	[UpdatedOn] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FeesUpdateByStudent](
	[StudentId] [int] NOT NULL,
	[ClassId] [int] NULL,
	[SectionId] [int] NULL,
	[StudentName] [nvarchar](255) NULL,
	[RemainingFees] [decimal](18, 2) NULL,
	[PaidFees] [decimal](18, 2) NULL,
	[UTRNo] [nvarchar](255) NULL,
	[UpdatedByStudentId] [int] NULL,
	[UpdatedByStudentName] [nvarchar](255) NULL,
	[UpdatedOn] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[GenerateFeesForStudent](
	[ClassId] [int] NULL,
	[SectionId] [int] NULL,
	[StudentId] [int] NULL,
	[FeesId] [int] IDENTITY(1,1) NOT NULL,
	[LastRemaining] [decimal](18, 2) NULL,
	[CurrentMonthFees] [decimal](18, 2) NULL,
	[TotalFees] [decimal](18, 2) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOn] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[FeesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HwCw](
	[Id] [int] NOT NULL,
	[ClassId] [int] NULL,
	[SectionId] [int] NULL,
	[Date] [datetime] NULL,
	[Hw] [nvarchar](max) NULL,
	[Cw] [nvarchar](max) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Revenue](

[RevenueId][int] NOT NULL,

[RevenueGenerated] [decimal](18, 2) NULL,
	[RevenueReceived] [decimal](18, 2) NULL,
	[RevenueYetToReceived] [decimal](18, 2) NULL,
	[RevenueSpent] [decimal](18, 2) NULL,
	[LoanTaken] [decimal](18, 2) NULL,
	[LoanPaid] [decimal](18, 2) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdatedOn] [datetime] NULL,
	[RevenueUptoWeek] [int] NULL,
	[MonthName] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[RevenueId] ASC
)WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON[PRIMARY]
) ON[PRIMARY]
GO


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Section](
	[SectionId] [int] NOT NULL,
	[ClassId] [int] NULL,
	[Class] [nvarchar](255) NULL,
	[SectionName] [nvarchar](255) NULL,
	[TotalStudents] [int] NULL,
	[SectionTeacherId] [int] NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SectionAttendance](
	[AttendanceId] [int] NOT NULL,
	[SectionId] [int] NULL,
	[Date] [datetime] NULL,
	[Present] [int] NULL,
	[Absent] [int] NULL,
	[TotalStudents] [int] NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[AttendanceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SectionTeacher](
	[SectionTeacherId] [int] NOT NULL,
	[StaffId] [int] NULL,
	[SectionId] [int] NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SectionTeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StaffAttendance](
	[StaffId] [int] NOT NULL,
	[StaffName] [nvarchar](255) NULL,
	[Date] [datetime] NULL,
	[StatusOnDate] [nvarchar](50) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOn] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StaffDetails](
	[StaffId] [int] NOT NULL,
	[StaffName] [nvarchar](255) NULL,
	[ContactNumber] [nvarchar](20) NULL,
	[RoleId] [int] NULL,
	[RoleName] [nvarchar](50) NULL,
	[NetSalary] [decimal](18, 2) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOn] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentAchievement](
	[StudentId] [int] NOT NULL,
	[StudentName] [nvarchar](255) NULL,
	[ClassId] [int] NOT NULL,
	[SectionId] [int] NOT NULL,
	[Achievement] [nvarchar](max) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ClassId] ASC,
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentAttendance](
	[StudentId] [int] NOT NULL,
	[StudentName] [nvarchar](255) NULL,
	[ClassId] [int] NOT NULL,
	[SectionId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[StatusOnDate] [nvarchar](50) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ClassId] ASC,
	[SectionId] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentDetails](
	[StudentId] [int] NOT NULL,
	[StudentName] [nvarchar](255) NULL,
	[FatherName] [nvarchar](255) NULL,
	[MotherName] [nvarchar](255) NULL,
	[LocalGuardianName] [nvarchar](255) NULL,
	[LocalGuardianRelation] [nvarchar](255) NULL,
	[FatherContactDetails] [nvarchar](255) NULL,
	[MotherContactDetails] [nvarchar](255) NULL,
	[LocalGuardianContactDetails] [nvarchar](255) NULL,
	[LocalAddress] [nvarchar](max) NULL,
	[PermanentAddress] [nvarchar](max) NULL,
	[Class] [nvarchar](255) NULL,
	[ClassId] [int] NULL,
	[Section] [nvarchar](255) NULL,
	[SectionId] [int] NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[Date] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentMarks](
	[StudentId] [int] NOT NULL,
	[StudentName] [nvarchar](255) NULL,
	[ClassId] [int] NOT NULL,
	[SectionId] [int] NOT NULL,
	[English] [int] NULL,
	[Hindi] [int] NULL,
	[Maths] [int] NULL,
	[Science] [int] NULL,
	[SocialStudies] [int] NULL,
	[Computer] [int] NULL,
	[Additional] [int] NULL,
	[TotalMarks] [int] NULL,
	[MarksScored] [int] NULL,
	[Percentage] [decimal](5, 2) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ClassId] ASC,
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[StudentRemarks](
	[StudentId] [int] NOT NULL,
	[StudentName] [nvarchar](255) NULL,
	[ClassId] [int] NOT NULL,
	[SectionId] [int] NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[ClassId] ASC,
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SubjectTeacher](
	[StaffId] [int] NOT NULL,
	[TeacherName] [nvarchar](255) NULL,
	[Subject] [nvarchar](100) NULL,
	[ClassId] [int] NULL,
	[SectionId] [int] NULL,
	[UpdatedByStaffId] [int] NULL,
	[UpdatedByStaffName] [nvarchar](255) NULL,
	[UpdateOnDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[UserId] [int] NOT NULL,
	[Username] [nvarchar](255) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[RoleId] [int] NOT NULL,
	[JwtToken] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


USE [SchoolProjectDone]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[UserRole](
	[RoleId] [int] NOT NULL,
	[RoleName] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Change Password
ALTER PROCEDURE [dbo].[sp_ChangePassword]
    @Username NVARCHAR(255),
    @NewPassword NVARCHAR(255)
AS
BEGIN
    UPDATE [User] SET Password = @NewPassword WHERE Username = @Username
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Create Approval of Fees
ALTER PROCEDURE [dbo].[sp_CreateApprovalOfFees]
@StudentId INT,
@ClassId INT,
@SectionId INT,
@UTR NVARCHAR(50),
    @PaidAmount DECIMAL(18, 2),
    @RemainingAmount DECIMAL(18, 2),
    @UpdatedByStaffId INT,
	@UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    INSERT INTO ApprovalOfFees (StudentId, ClassId, SectionId, UTR, PaidAmount, RemainingAmount, UpdatedByStaffId, UpdatedByStaffName, UpdateOn)
    VALUES(@StudentId, @ClassId, @SectionId, @UTR, @PaidAmount, @RemainingAmount, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOn)
END



USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Create stored procedure for creating Class
ALTER PROCEDURE [dbo].[sp_CreateClass]
    @ClassName NVARCHAR(255),
    @ClassTeacherId INT,
    @NumberOfSections INT,
    @TotalStudents INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO Class (ClassName, ClassTeacherId, NumberOfSections, TotalStudents, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@ClassName, @ClassTeacherId, @NumberOfSections, @TotalStudents, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate)
END;



USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Stored procedure: sp_CreateClassAttendance
ALTER PROCEDURE [dbo].[sp_CreateClassAttendance]
    @ClassId INT,
    @Date DATETIME,
    @Present INT,
    @Absent INT,
    @TotalStudents INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO ClassAttendance (ClassId, Date, Present, Absent, TotalStudents, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@ClassId, @Date, @Present, @Absent, @TotalStudents, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate);
END

USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- Stored procedure: sp_CreateClassTeacher
ALTER PROCEDURE [dbo].[sp_CreateClassTeacher]
    @StaffId INT,
    @ClassId INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO ClassTeacher (StaffId, ClassId, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@StaffId, @ClassId, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate);
END



USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Stored Procedure for Creating ComplainByStudent
ALTER PROCEDURE [dbo].[sp_CreateComplainByStudent]
    @StudentId INT,
    @StudentName NVARCHAR(255),
    @ClassId INT,
    @SectionId INT,
    @ComplainAgainst NVARCHAR(MAX),
    @UpdatedByStudentId INT,
    @UpdatedByStudentName NVARCHAR(255),
    @UpdatedOn DATETIME
AS
BEGIN
    INSERT INTO ComplainByStudent (StudentId, StudentName, ClassId, SectionId, ComplainAgainst, UpdatedByStudentId, UpdatedByStudentName, UpdatedOn)
    VALUES (@StudentId, @StudentName, @ClassId, @SectionId, @ComplainAgainst, @UpdatedByStudentId, @UpdatedByStudentName, @UpdatedOn)
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create Fees Update By Student
ALTER PROCEDURE [dbo].[sp_CreateFeesUpdateByStudent]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @StudentName NVARCHAR(255),
    @RemainingFees DECIMAL(18, 2),
    @PaidFees DECIMAL(18, 2),
    @UTRNo NVARCHAR(255),
    @UpdatedByStudentId INT,
    @UpdatedByStudentName NVARCHAR(255),
    @UpdatedOn DATETIME
AS
BEGIN
    INSERT INTO FeesUpdateByStudent (StudentId, ClassId, SectionId, StudentName, RemainingFees, PaidFees, UTRNo, UpdatedByStudentId, UpdatedByStudentName, UpdatedOn)
    VALUES (@StudentId, @ClassId, @SectionId, @StudentName, @RemainingFees, @PaidFees, @UTRNo, @UpdatedByStudentId, @UpdatedByStudentName, @UpdatedOn)
END;



USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Create sp_CreateGenerateFeesForStudent Stored Procedure
ALTER PROCEDURE [dbo].[sp_CreateGenerateFeesForStudent]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @LastRemaining DECIMAL(18, 2),
    @CurrentMonthFees DECIMAL(18, 2),
    @TotalFees DECIMAL(18, 2),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    INSERT INTO GenerateFeesForStudent (StudentId, ClassId, SectionId, LastRemaining, CurrentMonthFees, TotalFees, UpdatedByStaffId, UpdatedByStaffName, UpdateOn)
    VALUES (@StudentId, @ClassId, @SectionId, @LastRemaining, @CurrentMonthFees, @TotalFees, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOn)
END


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create HwCw
ALTER PROCEDURE [dbo].[sp_CreateHwCw]
    @ClassId INT,
    @SectionId INT,
    @Date DATETIME,
    @Hw NVARCHAR(MAX),
    @Cw NVARCHAR(MAX),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO HwCw (ClassId, SectionId, Date, Hw, Cw, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@ClassId, @SectionId, @Date, @Hw, @Cw, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate)
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create stored procedure for creating Revenue
ALTER PROCEDURE [dbo].[sp_CreateRevenue]
    @RevenueGenerated DECIMAL(18, 2),
    @RevenueReceived DECIMAL(18, 2),
    @RevenueYetToReceived DECIMAL(18, 2),
    @RevenueSpent DECIMAL(18, 2),
    @LoanTaken DECIMAL(18, 2),
    @LoanPaid DECIMAL(18, 2),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdatedOn DATETIME,
    @RevenueUptoWeek INT,
    @MonthName NVARCHAR(255)
AS
BEGIN
    INSERT INTO Revenue (RevenueGenerated, RevenueReceived, RevenueYetToReceived, RevenueSpent, LoanTaken, LoanPaid, UpdatedByStaffId, UpdatedByStaffName, UpdatedOn, RevenueUptoWeek, MonthName)
    VALUES (@RevenueGenerated, @RevenueReceived, @RevenueYetToReceived, @RevenueSpent, @LoanTaken, @LoanPaid, @UpdatedByStaffId, @UpdatedByStaffName, @UpdatedOn, @RevenueUptoWeek, @MonthName)
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create Section
ALTER PROCEDURE [dbo].[sp_CreateSection]
    @SectionId INT,
    @ClassId INT,
    @Class NVARCHAR(255),
    @SectionName NVARCHAR(255),
    @TotalStudents INT,
    @SectionTeacherId INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO Section (SectionId, ClassId, Class, SectionName, TotalStudents, SectionTeacherId, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@SectionId, @ClassId, @Class, @SectionName, @TotalStudents, @SectionTeacherId, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate)
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Stored procedure: sp_CreateSectionAttendance
ALTER PROCEDURE [dbo].[sp_CreateSectionAttendance]
    @SectionId INT,
    @Date DATETIME,
    @Present INT,
    @Absent INT,
    @TotalStudents INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO SectionAttendance (SectionId, Date, Present, Absent, TotalStudents, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@SectionId, @Date, @Present, @Absent, @TotalStudents, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate);
END


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Create Section Teacher
ALTER PROCEDURE [dbo].[sp_CreateSectionTeacher]
    @StaffId INT,
    @SectionId INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO SectionTeacher (StaffId, SectionId, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@StaffId, @SectionId, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate)
END

USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create Staff Attendance
ALTER PROCEDURE [dbo].[sp_CreateStaffAttendance]
    @StaffId INT,
    @StaffName NVARCHAR(255),
    @Date DATETIME,
    @StatusOnDate NVARCHAR(50),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    INSERT INTO StaffAttendance (StaffId, StaffName, Date, StatusOnDate, UpdatedByStaffId, UpdatedByStaffName, UpdateOn)
    VALUES (@StaffId, @StaffName, @Date, @StatusOnDate, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOn)
END


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Create Staff Details
ALTER PROCEDURE [dbo].[sp_CreateStaffDetails]
    @StaffId INT,
    @StaffName NVARCHAR(255),
    @ContactNumber NVARCHAR(20),
    @RoleId INT,
    @RoleName NVARCHAR(50),
    @NetSalary DECIMAL(18, 2),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    INSERT INTO StaffDetails (StaffId, StaffName, ContactNumber, RoleId, RoleName, NetSalary, UpdatedByStaffId, UpdatedByStaffName, UpdateOn)
    VALUES (@StaffId, @StaffName, @ContactNumber, @RoleId, @RoleName, @NetSalary, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOn)
END

USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create stored procedure for creating StaffSalary
ALTER PROCEDURE [dbo].[sp_CreateStaffSalary]
    @StaffId INT,
    @StaffName NVARCHAR(255),
    @NetSalary DECIMAL(18, 2),
    @PreviousRemaining DECIMAL(18, 2),
    @TotalAmount DECIMAL(18, 2),
    @PaidAmount DECIMAL(18, 2),
    @RemainingThisMonth DECIMAL(18, 2),
    @PaidUptoMonth DECIMAL(18, 2),
    @AdvancePaid DECIMAL(18, 2),
    @PaidOnDate DATETIME,
    @UTR NVARCHAR(255),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    INSERT INTO StaffSalary (StaffId, StaffName, NetSalary, PreviousRemaining, TotalAmount, PaidAmount, RemainingThisMonth, PaidUptoMonth, AdvancePaid, PaidOnDate, UTR, UpdatedByStaffId, UpdatedByStaffName, UpdateOn)
    VALUES (@StaffId, @StaffName, @NetSalary, @PreviousRemaining, @TotalAmount, @PaidAmount, @RemainingThisMonth, @PaidUptoMonth, @AdvancePaid, @PaidOnDate, @UTR, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOn)
END;

USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create StudentAchievement
ALTER PROCEDURE [dbo].[sp_CreateStudentAchievement]
    @StudentId INT,
    @StudentName NVARCHAR(255),
    @ClassId INT,
    @SectionId INT,
    @Achievement NVARCHAR(MAX),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO StudentAchievement (StudentId, StudentName, ClassId, SectionId, Achievement, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@StudentId, @StudentName, @ClassId, @SectionId, @Achievement, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate)
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create StudentAttendance
ALTER PROCEDURE [dbo].[sp_CreateStudentAttendance]
    @StudentId INT,
    @StudentName NVARCHAR(255),
    @ClassId INT,
    @SectionId INT,
    @Date DATETIME,
    @StatusOnDate NVARCHAR(50),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO StudentAttendance (StudentId, StudentName, ClassId, SectionId, Date, StatusOnDate, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@StudentId, @StudentName, @ClassId, @SectionId, @Date, @StatusOnDate, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate)
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create StudentDetails
ALTER PROCEDURE [dbo].[sp_CreateStudentDetails]
    @StudentName NVARCHAR(255),
    @FatherName NVARCHAR(255),
    @MotherName NVARCHAR(255),
    @LocalGuardianName NVARCHAR(255),
    @LocalGuardianRelation NVARCHAR(255),
    @FatherContactDetails NVARCHAR(255),
    @MotherContactDetails NVARCHAR(255),
    @LocalGuardianContactDetails NVARCHAR(255),
    @LocalAddress NVARCHAR(MAX),
    @PermanentAddress NVARCHAR(MAX),
    @Class NVARCHAR(255),
    @ClassId INT,
    @Section NVARCHAR(255),
    @SectionId INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @Date DATETIME
AS
BEGIN
    INSERT INTO StudentDetails (
        StudentName, FatherName, MotherName, LocalGuardianName, LocalGuardianRelation,
        FatherContactDetails, MotherContactDetails, LocalGuardianContactDetails,
        LocalAddress, PermanentAddress, Class, ClassId, Section, SectionId,
        UpdatedByStaffId, UpdatedByStaffName, Date
    )
    VALUES (
        @StudentName, @FatherName, @MotherName, @LocalGuardianName, @LocalGuardianRelation,
        @FatherContactDetails, @MotherContactDetails, @LocalGuardianContactDetails,
        @LocalAddress, @PermanentAddress, @Class, @ClassId, @Section, @SectionId,
        @UpdatedByStaffId, @UpdatedByStaffName, @Date
    )
END;


USE [SchoolProjectDone]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create StudentMarks
ALTER PROCEDURE [dbo].[sp_CreateStudentMarks]
    @StudentId INT,
    @StudentName NVARCHAR(255),
    @ClassId INT,
    @SectionId INT,
    @English INT,
    @Hindi INT,
    @Maths INT,
    @Science INT,
    @SocialStudies INT,
    @Computer INT,
    @Additional INT,
    @TotalMarks INT,
    @MarksScored INT,
    @Percentage DECIMAL(5, 2),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO StudentMarks (
        StudentId, StudentName, ClassId, SectionId,
        English, Hindi, Maths, Science, SocialStudies,
        Computer, Additional, TotalMarks, MarksScored,
        Percentage, UpdatedByStaffId, UpdatedByStaffName,
        UpdateOnDate
    )
    VALUES (
        @StudentId, @StudentName, @ClassId, @SectionId,
        @English, @Hindi, @Maths, @Science, @SocialStudies,
        @Computer, @Additional, @TotalMarks, @MarksScored,
        @Percentage, @UpdatedByStaffId, @UpdatedByStaffName,
        @UpdateOnDate
    )
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create StudentRemarks
ALTER PROCEDURE [dbo].[sp_CreateStudentRemarks]
    @StudentId INT,
    @StudentName NVARCHAR(255),
    @ClassId INT,
    @SectionId INT,
    @Remarks NVARCHAR(MAX),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO StudentRemarks (
        StudentId, StudentName, ClassId, SectionId,
        Remarks, UpdatedByStaffId, UpdatedByStaffName,
        UpdateOnDate
    )
    VALUES (
        @StudentId, @StudentName, @ClassId, @SectionId,
        @Remarks, @UpdatedByStaffId, @UpdatedByStaffName,
        @UpdateOnDate
    )
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Create Subject Teacher
ALTER PROCEDURE [dbo].[sp_CreateSubjectTeacher]
    @StaffId INT,
    @TeacherName NVARCHAR(255),
    @Subject NVARCHAR(100),
    @ClassId INT,
    @SectionId INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    INSERT INTO SubjectTeacher (StaffId, TeacherName, Subject, ClassId, SectionId, UpdatedByStaffId, UpdatedByStaffName, UpdateOnDate)
    VALUES (@StaffId, @TeacherName, @Subject, @ClassId, @SectionId, @UpdatedByStaffId, @UpdatedByStaffName, @UpdateOnDate)
END


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create User
ALTER PROCEDURE [dbo].[sp_CreateUser]
    @Username NVARCHAR(255),
    @Password NVARCHAR(255),
    @RoleId INT,
    @JwtToken NVARCHAR(MAX)
AS
BEGIN
    INSERT INTO [User] (Username, Password, RoleId, JwtToken)
    VALUES (@Username, @Password, @RoleId, @JwtToken)
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Create User
ALTER PROCEDURE [dbo].[sp_CreateUserLoginModel]
    @Username NVARCHAR(255),
    @Password NVARCHAR(255)
AS
BEGIN
    INSERT INTO [User] (Username, Password)
    VALUES (@Username, @Password)
END;


USE [SchoolProjectDone]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Stored Procedure for Creating UserRole
ALTER PROCEDURE [dbo].[sp_CreateUserRole]
    @RoleName NVARCHAR(255)
AS
BEGIN
    INSERT INTO UserRole (RoleName)
    VALUES (@RoleName)
END;

-- Delete Approval of Fees
ALTER PROCEDURE [dbo].[sp_DeleteApprovalOfFees]
    @FeesId INT
AS
BEGIN
    DELETE FROM ApprovalOfFees WHERE FeesId = @FeesId
END

ALTER PROCEDURE [dbo].[sp_DeleteClass]
    @ClassId INT
AS
BEGIN
    DELETE FROM Class WHERE ClassId = @ClassId
END;


-- Stored procedure: sp_DeleteClassAttendance
ALTER PROCEDURE [dbo].[sp_DeleteClassAttendance]
    @AttendanceId INT
AS
BEGIN
    DELETE FROM ClassAttendance WHERE AttendanceId = @AttendanceId;
END


-- Stored procedure: sp_DeleteClassTeacher
ALTER PROCEDURE [dbo].[sp_DeleteClassTeacher]
    @ClassTeacherId INT
AS
BEGIN
    DELETE FROM ClassTeacher WHERE ClassTeacherId = @ClassTeacherId;
END


-- Stored Procedure for Deleting ComplainByStudent
ALTER PROCEDURE [dbo].[sp_DeleteComplainByStudent]
    @StudentId INT
AS
BEGIN
    DELETE FROM ComplainByStudent WHERE StudentId = @StudentId
END;

-- Delete Fees Update By Student
ALTER PROCEDURE [dbo].[sp_DeleteFeesUpdateByStudent]
    @StudentId INT
AS
BEGIN
    DELETE FROM FeesUpdateByStudent WHERE StudentId = @StudentId
END;


-- Delete GenerateFeesForStudent
ALTER PROCEDURE [dbo].[sp_DeleteGenerateFeesForStudent]
    @FeesId INT
AS
BEGIN
    DELETE FROM GenerateFeesForStudent WHERE FeesId = @FeesId
END

-- Delete HwCw
ALTER PROCEDURE [dbo].[sp_DeleteHwCw]
    @Id INT
AS
BEGIN
    DELETE FROM HwCw WHERE Id = @Id
END;


-- Delete stored procedure for deleting Revenue
ALTER PROCEDURE [dbo].[sp_DeleteRevenue]
    @RevenueId INT
AS
BEGIN
    DELETE FROM Revenue WHERE RevenueId = @RevenueId
END;

-- Delete Section
ALTER PROCEDURE [dbo].[sp_DeleteSection]
    @SectionId INT
AS
BEGIN
    DELETE FROM Section WHERE SectionId = @SectionId
END;



-- Stored procedure: sp_DeleteSectionAttendance
ALTER PROCEDURE [dbo].[sp_DeleteSectionAttendance]
    @AttendanceId INT
AS
BEGIN
    DELETE FROM SectionAttendance WHERE AttendanceId = @AttendanceId;
END



-- Delete Section Teacher
ALTER PROCEDURE [dbo].[sp_DeleteSectionTeacher]
    @SectionTeacherId INT
AS
BEGIN
    DELETE FROM SectionTeacher WHERE SectionTeacherId = @SectionTeacherId
END


-- Delete Staff Attendance
ALTER PROCEDURE [dbo].[sp_DeleteStaffAttendance]
    @StaffId INT,
    @Date DATETIME
AS
BEGIN
    DELETE FROM StaffAttendance WHERE StaffId = @StaffId AND Date = @Date
END



-- Delete Staff Details
ALTER PROCEDURE [dbo].[sp_DeleteStaffDetails]
    @StaffId INT
AS
BEGIN
    DELETE FROM StaffDetails WHERE StaffId = @StaffId
END



-- Delete stored procedure for deleting StaffSalary
ALTER PROCEDURE [dbo].[sp_DeleteStaffSalary]
    @StaffId INT
AS
BEGIN
    DELETE FROM StaffSalary WHERE StaffId = @StaffId
END;



-- Delete StudentAchievement
ALTER PROCEDURE [dbo].[sp_DeleteStudentAchievement]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT
AS
BEGIN
    DELETE FROM StudentAchievement
    WHERE StudentId = @StudentId AND
          ClassId = @ClassId AND
          SectionId = @SectionId
END;


ALTER PROCEDURE [dbo].[sp_DeleteStudentAttendance]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @Date DATETIME
AS
BEGIN
    DELETE FROM StudentAttendance
    WHERE
        StudentId = @StudentId
        AND ClassId = @ClassId
        AND SectionId = @SectionId
        AND Date = @Date
END;


-- Delete StudentDetails
ALTER PROCEDURE [dbo].[sp_DeleteStudentDetails]
    @StudentId INT
AS
BEGIN
    DELETE FROM StudentDetails WHERE StudentId = @StudentId
END;


CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 
	-- Add the parameters for the stored procedure here
	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO


-- Delete StudentRemarks
ALTER PROCEDURE [dbo].[sp_DeleteStudentRemarks]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT
AS
BEGIN
    DELETE FROM StudentRemarks
    WHERE StudentId = @StudentId AND ClassId = @ClassId AND SectionId = @SectionId
END;




-- Delete Subject Teacher
ALTER PROCEDURE [dbo].[sp_DeleteSubjectTeacher]
    @StaffId INT
AS
BEGIN
    DELETE FROM SubjectTeacher WHERE StaffId = @StaffId
END

-- Delete User
ALTER PROCEDURE [dbo].[sp_DeleteUser]
    @UserId INT
AS
BEGIN
    DELETE FROM [User] WHERE UserId = @UserId
END;


-- Delete User by Username
ALTER PROCEDURE [dbo].[sp_DeleteUserByUsername]
    @Username NVARCHAR(255)
AS
BEGIN
    DELETE FROM [User] WHERE Username = @Username
END;


CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 
	-- Add the parameters for the stored procedure here
	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO



-- Edit Approval of Fees
ALTER PROCEDURE [dbo].[sp_EditApprovalOfFees]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @FeesId INT,
    @UTR NVARCHAR(50),
    @PaidAmount DECIMAL(18, 2),
    @RemainingAmount DECIMAL(18, 2),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    UPDATE ApprovalOfFees
    SET
        UTR = @UTR,
        PaidAmount = @PaidAmount,
        RemainingAmount = @RemainingAmount,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOn = @UpdateOn
    WHERE
        StudentId = @StudentId AND
        ClassId = @ClassId AND
        SectionId = @SectionId AND
        FeesId = @FeesId
END


ALTER PROCEDURE [dbo].[sp_EditClass]
    @ClassId INT,
    @ClassName NVARCHAR(255),
    @ClassTeacherId INT,
    @NumberOfSections INT,
    @TotalStudents INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE Class
    SET
        ClassName = @ClassName,
        ClassTeacherId = @ClassTeacherId,
        NumberOfSections = @NumberOfSections,
        TotalStudents = @TotalStudents,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE
        ClassId = @ClassId
END;



-- Stored procedure: sp_EditClassAttendance
ALTER PROCEDURE [dbo].[sp_EditClassAttendance]
    @AttendanceId INT,
    @ClassId INT,
    @Date DATETIME,
    @Present INT,
    @Absent INT,
    @TotalStudents INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE ClassAttendance
    SET
        ClassId = @ClassId,
        Date = @Date,
        Present = @Present,
        Absent = @Absent,
        TotalStudents = @TotalStudents,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE
        AttendanceId = @AttendanceId;
END



-- Stored procedure: sp_EditClassTeacher
ALTER PROCEDURE [dbo].[sp_EditClassTeacher]
    @ClassTeacherId INT,
    @StaffId INT,
    @ClassId INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE ClassTeacher
    SET
        StaffId = @StaffId,
        ClassId = @ClassId,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE
        ClassTeacherId = @ClassTeacherId;
END




-- Stored Procedure for Updating ComplainByStudent
ALTER PROCEDURE [dbo].[sp_EditComplainByStudent]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @ComplainAgainst NVARCHAR(MAX),
    @UpdatedByStudentId INT,
    @UpdatedByStudentName NVARCHAR(255),
    @UpdatedOn DATETIME
AS
BEGIN
    UPDATE ComplainByStudent
    SET
        ClassId = @ClassId,
        SectionId = @SectionId,
        ComplainAgainst = @ComplainAgainst,
        UpdatedByStudentId = @UpdatedByStudentId,
        UpdatedByStudentName = @UpdatedByStudentName,
        UpdatedOn = @UpdatedOn
    WHERE
        StudentId = @StudentId
END;



-- Edit Fees Update By Student
ALTER PROCEDURE [dbo].[sp_EditFeesUpdateByStudent]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @StudentName NVARCHAR(255),
    @RemainingFees DECIMAL(18, 2),
    @PaidFees DECIMAL(18, 2),
    @UTRNo NVARCHAR(255),
    @UpdatedByStudentId INT,
    @UpdatedByStudentName NVARCHAR(255),
    @UpdatedOn DATETIME
AS
BEGIN
    UPDATE FeesUpdateByStudent
    SET
        ClassId = @ClassId,
        SectionId = @SectionId,
        StudentName = @StudentName,
        RemainingFees = @RemainingFees,
        PaidFees = @PaidFees,
        UTRNo = @UTRNo,
        UpdatedByStudentId = @UpdatedByStudentId,
        UpdatedByStudentName = @UpdatedByStudentName,
        UpdatedOn = @UpdatedOn
    WHERE StudentId = @StudentId
END;



ALTER PROCEDURE [dbo].[sp_EditGenerateFeesForStudent]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @LastRemaining DECIMAL(18, 2),
    @CurrentMonthFees DECIMAL(18, 2),
    @TotalFees DECIMAL(18, 2),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    UPDATE GenerateFeesForStudent
    SET
        ClassId = @ClassId,
        SectionId = @SectionId,
        LastRemaining = @LastRemaining,
        CurrentMonthFees = @CurrentMonthFees,
        TotalFees = @TotalFees,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOn = @UpdateOn
    WHERE
        StudentId = @StudentId
END



-- Edit HwCw
ALTER PROCEDURE [dbo].[sp_EditHwCw]
    @Id INT,
    @ClassId INT,
    @SectionId INT,
    @Date DATETIME,
    @Hw NVARCHAR(MAX),
    @Cw NVARCHAR(MAX),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE HwCw
    SET
        ClassId = @ClassId,
        SectionId = @SectionId,
        Date = @Date,
        Hw = @Hw,
        Cw = @Cw,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE
        Id = @Id
END;

-- Edit stored procedure for updating Revenue
ALTER PROCEDURE [dbo].[sp_EditRevenue]
    @RevenueId INT,
    @RevenueGenerated DECIMAL(18, 2),
    @RevenueReceived DECIMAL(18, 2),
    @RevenueYetToReceived DECIMAL(18, 2),
    @RevenueSpent DECIMAL(18, 2),
    @LoanTaken DECIMAL(18, 2),
    @LoanPaid DECIMAL(18, 2),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdatedOn DATETIME,
    @RevenueUptoWeek INT,
    @MonthName NVARCHAR(255)
AS
BEGIN
    UPDATE Revenue
    SET
        RevenueGenerated = @RevenueGenerated,
        RevenueReceived = @RevenueReceived,
        RevenueYetToReceived = @RevenueYetToReceived,
        RevenueSpent = @RevenueSpent,
        LoanTaken = @LoanTaken,
        LoanPaid = @LoanPaid,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdatedOn = @UpdatedOn,
        RevenueUptoWeek = @RevenueUptoWeek,
        MonthName = @MonthName
    WHERE
        RevenueId = @RevenueId
END;

-- Edit Section
ALTER PROCEDURE [dbo].[sp_EditSection]
    @SectionId INT,
    @ClassId INT,
    @Class NVARCHAR(255),
    @SectionName NVARCHAR(255),
    @TotalStudents INT,
    @SectionTeacherId INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE Section
    SET
        ClassId = @ClassId,
        Class = @Class,
        SectionName = @SectionName,
        TotalStudents = @TotalStudents,
        SectionTeacherId = @SectionTeacherId,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE SectionId = @SectionId
END;


-- Stored procedure: sp_EditSectionAttendance
ALTER PROCEDURE [dbo].[sp_EditSectionAttendance]
    @AttendanceId INT,
    @SectionId INT,
    @Date DATETIME,
    @Present INT,
    @Absent INT,
    @TotalStudents INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE SectionAttendance
    SET
        SectionId = @SectionId,
        Date = @Date,
        Present = @Present,
        Absent = @Absent,
        TotalStudents = @TotalStudents,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE
        AttendanceId = @AttendanceId;
END

-- Edit Section Teacher
ALTER PROCEDURE [dbo].[sp_EditSectionTeacher]
    @SectionTeacherId INT,
    @StaffId INT,
    @SectionId INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE SectionTeacher
    SET
        StaffId = @StaffId,
        SectionId = @SectionId,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE
        SectionTeacherId = @SectionTeacherId
END

-- Edit Staff Attendance
ALTER PROCEDURE [dbo].[sp_EditStaffAttendance]
    @StaffId INT,
    @Date DATETIME,
    @StatusOnDate NVARCHAR(50),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    UPDATE StaffAttendance
    SET
        StatusOnDate = @StatusOnDate,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOn = @UpdateOn
    WHERE
        StaffId = @StaffId AND
        Date = @Date
END


-- Edit Staff Details
ALTER PROCEDURE [dbo].[sp_EditStaffDetails]
    @StaffId INT,
    @StaffName NVARCHAR(255),
    @ContactNumber NVARCHAR(20),
    @RoleId INT,
    @RoleName NVARCHAR(50),
    @NetSalary DECIMAL(18, 2),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    UPDATE StaffDetails
    SET
        StaffName = @StaffName,
        ContactNumber = @ContactNumber,
        RoleId = @RoleId,
        RoleName = @RoleName,
        NetSalary = @NetSalary,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOn = @UpdateOn
    WHERE
        StaffId = @StaffId
END

-- Edit stored procedure for updating StaffSalary
ALTER PROCEDURE [dbo].[sp_EditStaffSalary]
    @StaffId INT,
    @NetSalary DECIMAL(18, 2),
    @PreviousRemaining DECIMAL(18, 2),
    @TotalAmount DECIMAL(18, 2),
    @PaidAmount DECIMAL(18, 2),
    @RemainingThisMonth DECIMAL(18, 2),
    @PaidUptoMonth DECIMAL(18, 2),
    @AdvancePaid DECIMAL(18, 2),
    @PaidOnDate DATETIME,
    @UTR NVARCHAR(255),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOn DATETIME
AS
BEGIN
    UPDATE StaffSalary
    SET
        NetSalary = @NetSalary,
        PreviousRemaining = @PreviousRemaining,
        TotalAmount = @TotalAmount,
        PaidAmount = @PaidAmount,
        RemainingThisMonth = @RemainingThisMonth,
        PaidUptoMonth = @PaidUptoMonth,
        AdvancePaid = @AdvancePaid,
        PaidOnDate = @PaidOnDate,
        UTR = @UTR,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOn = @UpdateOn
    WHERE
        StaffId = @StaffId
END;

GO
-- Edit StudentAchievement
ALTER PROCEDURE [dbo].[sp_EditStudentAchievement]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @Achievement NVARCHAR(MAX),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE StudentAchievement
    SET
        Achievement = @Achievement,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE
        StudentId = @StudentId AND
        ClassId = @ClassId AND
        SectionId = @SectionId
END;


-- Update StudentAttendance
ALTER PROCEDURE [dbo].[sp_EditStudentAttendance]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @Date DATETIME,
    @StatusOnDate NVARCHAR(50),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE StudentAttendance
    SET
        StatusOnDate = @StatusOnDate,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE
        StudentId = @StudentId
        AND ClassId = @ClassId
        AND SectionId = @SectionId
        AND Date = @Date
END;


-- Edit StudentDetails
ALTER PROCEDURE [dbo].[sp_EditStudentDetails]
    @StudentId INT,
    @StudentName NVARCHAR(255),
    @FatherName NVARCHAR(255),
    @MotherName NVARCHAR(255),
    -- Include other parameters as needed
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @Date DATETIME
AS
BEGIN
    UPDATE StudentDetails
    SET
        StudentName = @StudentName,
        FatherName = @FatherName,
        MotherName = @MotherName,
        -- Update other columns as needed
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        Date = @Date
    WHERE StudentId = @StudentId
END;


-- Edit StudentMarks
ALTER PROCEDURE [dbo].[sp_EditStudentMarks]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @English INT,
    @Hindi INT,
    @Maths INT,
    @Science INT,
    @SocialStudies INT,
    @Computer INT,
    @Additional INT,
    @TotalMarks INT,
    @MarksScored INT,
    @Percentage DECIMAL(5, 2),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE StudentMarks
    SET
        English = @English,
        Hindi = @Hindi,
        Maths = @Maths,
        Science = @Science,
        SocialStudies = @SocialStudies,
        Computer = @Computer,
        Additional = @Additional,
        TotalMarks = @TotalMarks,
        MarksScored = @MarksScored,
        Percentage = @Percentage,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE StudentId = @StudentId AND ClassId = @ClassId AND SectionId = @SectionId
END;

-- Edit StudentRemarks
ALTER PROCEDURE [dbo].[sp_EditStudentRemarks]
    @StudentId INT,
    @ClassId INT,
    @SectionId INT,
    @Remarks NVARCHAR(MAX),
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE StudentRemarks
    SET
        Remarks = @Remarks,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE StudentId = @StudentId AND ClassId = @ClassId AND SectionId = @SectionId
END;


-- Edit Subject Teacher
ALTER PROCEDURE [dbo].[sp_EditSubjectTeacher]
    @StaffId INT,
    @TeacherName NVARCHAR(255),
    @Subject NVARCHAR(100),
    @ClassId INT,
    @SectionId INT,
    @UpdatedByStaffId INT,
    @UpdatedByStaffName NVARCHAR(255),
    @UpdateOnDate DATETIME
AS
BEGIN
    UPDATE SubjectTeacher
    SET
        TeacherName = @TeacherName,
        Subject = @Subject,
        ClassId = @ClassId,
        SectionId = @SectionId,
        UpdatedByStaffId = @UpdatedByStaffId,
        UpdatedByStaffName = @UpdatedByStaffName,
        UpdateOnDate = @UpdateOnDate
    WHERE
        StaffId = @StaffId
END

-- Edit User
ALTER PROCEDURE [dbo].[sp_EditUser]
    @UserId INT,
    @Username NVARCHAR(255),
    @Password NVARCHAR(255),
    @RoleId INT,
    @JwtToken NVARCHAR(MAX)
AS
BEGIN
    UPDATE [User]
    SET
        Username = @Username,
        Password = @Password,
        RoleId = @RoleId,
        JwtToken = @JwtToken
    WHERE
        UserId = @UserId
END;

-- Stored Procedure for Updating UserRole
ALTER PROCEDURE [dbo].[sp_EditUserRole]
    @RoleId INT,
    @RoleName NVARCHAR(255)
AS
BEGIN
    UPDATE UserRole
    SET RoleName = @RoleName
    WHERE RoleId = @RoleId
END;

-- Find Approval of Fees by Class ID
ALTER PROCEDURE [dbo].[sp_FindApprovalOfFeesByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM ApprovalOfFees WHERE ClassId = @ClassId
END



-- Find Approval of Fees by Fees ID
ALTER PROCEDURE [dbo].[sp_FindApprovalOfFeesByFeesId]
    @FeesId INT
AS
BEGIN
    SELECT * FROM ApprovalOfFees WHERE FeesId = @FeesId
END

-- Find Approval of Fees by Section ID
ALTER PROCEDURE [dbo].[sp_FindApprovalOfFeesBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM ApprovalOfFees WHERE SectionId = @SectionId
END

-- Find Approval of Fees by Student Id
ALTER PROCEDURE [dbo].[sp_FindApprovalOfFeesByStudentId]
    @StudentId INT
AS
BEGIN
    SELECT * FROM ApprovalOfFees WHERE StudentId = @StudentId
END



-- Find Approval of Fees by UTR
ALTER PROCEDURE [dbo].[sp_FindApprovalOfFeesByUTR]
    @UTR NVARCHAR(50)
AS
BEGIN
    SELECT * FROM ApprovalOfFees WHERE UTR = @UTR
END


-- Stored procedure: sp_FindClassAttendanceByAttendanceId
ALTER PROCEDURE [dbo].[sp_FindClassAttendanceByAttendanceId]
    @AttendanceId INT
AS
BEGIN
    SELECT * FROM ClassAttendance WHERE AttendanceId = @AttendanceId;
END


-- Stored procedure: sp_FindClassAttendanceByClassId
ALTER PROCEDURE [dbo].[sp_FindClassAttendanceByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM ClassAttendance WHERE ClassId = @ClassId;
END



-- Find by ClassId stored procedure
ALTER PROCEDURE [dbo].[sp_FindClassByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM Class WHERE ClassId = @ClassId
END;

-- Find Class by ClassTeacherId without Foreign Key
ALTER PROCEDURE [dbo].[sp_FindClassByClassTeacherId]
    @ClassTeacherId INT
AS
BEGIN
    SELECT * FROM Class
    WHERE ClassTeacherId = @ClassTeacherId
END;


-- Stored procedure: sp_FindClassTeacherByClassId
ALTER PROCEDURE [dbo].[sp_FindClassTeacherByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM ClassTeacher WHERE ClassId = @ClassId;
END


-- Stored procedure: sp_FindClassTeacherByClassTeacherId
ALTER PROCEDURE [dbo].[sp_FindClassTeacherByClassTeacherId]
    @ClassTeacherId INT
AS
BEGIN
    SELECT * FROM ClassTeacher WHERE ClassTeacherId = @ClassTeacherId;
END



-- Stored procedure: sp_FindClassTeacherByStaffId
ALTER PROCEDURE [dbo].[sp_FindClassTeacherByStaffId]
    @StaffId INT
AS
BEGIN
    SELECT * FROM ClassTeacher WHERE StaffId = @StaffId;
END


-- Stored Procedure for Finding ComplainByStudent by ClassId
ALTER PROCEDURE [dbo].[sp_FindComplainByStudentByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM ComplainByStudent WHERE ClassId = @ClassId
END;

-- Stored Procedure for Finding ComplainByStudent by SectionId
ALTER PROCEDURE [dbo].[sp_FindComplainByStudentBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM ComplainByStudent WHERE SectionId = @SectionId
END;

-- Stored Procedure for Finding ComplainByStudent by StudentId
ALTER PROCEDURE [dbo].[sp_FindComplainByStudentByStudentId]
    @StudentId INT
AS
BEGIN
    SELECT * FROM ComplainByStudent WHERE StudentId = @StudentId
END;

-- Find Fees Update By Student by Class ID
ALTER PROCEDURE [dbo].[sp_FindFeesUpdateByStudentByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM FeesUpdateByStudent WHERE ClassId = @ClassId
END;


-- Find Fees Update By Student by Section ID
ALTER PROCEDURE [dbo].[sp_FindFeesUpdateByStudentBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM FeesUpdateByStudent WHERE SectionId = @SectionId
END;


-- Find Fees Update By Student by Student ID
ALTER PROCEDURE [dbo].[sp_FindFeesUpdateByStudentByStudentId]
    @StudentId INT
AS
BEGIN
    SELECT * FROM FeesUpdateByStudent WHERE StudentId = @StudentId
END;


-- Find Fees Update By Student by UTR
ALTER PROCEDURE [dbo].[sp_FindFeesUpdateByStudentByUTR]
    @UTRNo NVARCHAR(255)
AS
BEGIN
    SELECT * FROM FeesUpdateByStudent WHERE UTRNo = @UTRNo
END;


-- Find by ClassId
ALTER PROCEDURE [dbo].[sp_FindGenerateFeesForStudentByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM GenerateFeesForStudent WHERE ClassId = @ClassId
END

-- Find by FeesId
ALTER PROCEDURE [dbo].[sp_FindGenerateFeesForStudentByFeesId]
    @FeesId INT
AS
BEGIN
    SELECT * FROM GenerateFeesForStudent WHERE FeesId = @FeesId
END

-- Find by SectionId
ALTER PROCEDURE [dbo].[sp_FindGenerateFeesForStudentBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM GenerateFeesForStudent WHERE SectionId = @SectionId
END


CREATE PROCEDURE <Procedure_Name, sysname, ProcedureName> 
	-- Add the parameters for the stored procedure here
	<@Param1, sysname, @p1> <Datatype_For_Param1, , int> = <Default_Value_For_Param1, , 0>, 
	<@Param2, sysname, @p2> <Datatype_For_Param2, , int> = <Default_Value_For_Param2, , 0>
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT <@Param1, sysname, @p1>, <@Param2, sysname, @p2>
END
GO


-- Find HwCw By ClassId
ALTER PROCEDURE [dbo].[sp_FindHwCwByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM HwCw WHERE ClassId = @ClassId
END;

-- Find HwCw By Id
ALTER PROCEDURE [dbo].[sp_FindHwCwById]
    @Id INT
AS
BEGIN
    SELECT * FROM HwCw WHERE Id = @Id
END;


-- Find HwCw By SectionId
ALTER PROCEDURE [dbo].[sp_FindHwCwBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM HwCw WHERE SectionId = @SectionId
END;


-- Find by RevenueId stored procedure
ALTER PROCEDURE [dbo].[sp_FindRevenueById]
    @RevenueId INT
AS
BEGIN
    SELECT * FROM Revenue WHERE RevenueId = @RevenueId
END;


-- Find by MonthName stored procedure
ALTER PROCEDURE [dbo].[sp_FindRevenueByMonthName]
    @MonthName NVARCHAR(255)
AS
BEGIN
    SELECT * FROM Revenue WHERE MonthName = @MonthName
END;


-- Stored procedure: sp_FindSectionAttendanceByAttendanceId
ALTER PROCEDURE [dbo].[sp_FindSectionAttendanceByAttendanceId]
    @AttendanceId INT
AS
BEGIN
    SELECT * FROM SectionAttendance WHERE AttendanceId = @AttendanceId;
END


-- Stored procedure: sp_FindSectionAttendanceByDate
ALTER PROCEDURE [dbo].[sp_FindSectionAttendanceByDate]
    @Date DATETIME
AS
BEGIN
    SELECT * FROM SectionAttendance WHERE Date = @Date;
END


-- Stored procedure: sp_FindSectionAttendanceBySectionId
ALTER PROCEDURE [dbo].[sp_FindSectionAttendanceBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM SectionAttendance WHERE SectionId = @SectionId;
END


-- Stored procedure: sp_FindSectionAttendanceByStaffId
ALTER PROCEDURE [dbo].[sp_FindSectionAttendanceByStaffId]
    @StaffId INT
AS
BEGIN
    SELECT * FROM SectionAttendance WHERE UpdatedByStaffId = @StaffId;
END

-- Find Section by ClassId
ALTER PROCEDURE [dbo].[sp_FindSectionByClassId]
    @ClassId INT
AS
BEGIN
    SELECT *
    FROM Section
    WHERE ClassId = @ClassId
END;


-- Find Section by SectionId
ALTER PROCEDURE [dbo].[sp_FindSectionBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT *
    FROM Section
    WHERE SectionId = @SectionId
END;



-- Find Section by SectionTeacherId without Foreign Key
ALTER PROCEDURE [dbo].[sp_FindSectionBySectionTeacherId]
    @SectionTeacherId INT
AS
BEGIN
    SELECT * FROM Section
    WHERE SectionTeacherId = @SectionTeacherId
END;



-- Find Section Teacher by Section Id
ALTER PROCEDURE [dbo].[sp_FindSectionTeacherBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM SectionTeacher WHERE SectionId = @SectionId
END


-- Find Section Teacher by SectionTeacherId
ALTER PROCEDURE [dbo].[sp_FindSectionTeacherBySectionTeacherId]
    @SectionTeacherId INT
AS
BEGIN
    SELECT * FROM SectionTeacher WHERE SectionTeacherId = @SectionTeacherId
END


-- Find Section Teacher by Staff Id
ALTER PROCEDURE [dbo].[sp_FindSectionTeacherByStaffId]
    @StaffId INT
AS
BEGIN
    SELECT * FROM SectionTeacher WHERE StaffId = @StaffId
END

-- Find Staff Attendance by Date
ALTER PROCEDURE [dbo].[sp_FindStaffAttendanceByDate]
    @Date DATETIME
AS
BEGIN
    SELECT * FROM StaffAttendance WHERE Date = @Date
END


-- Find Staff Attendance by Staff Id
ALTER PROCEDURE [dbo].[sp_FindStaffAttendanceByStaffId]
    @StaffId INT
AS
BEGIN
    SELECT * FROM StaffAttendance WHERE StaffId = @StaffId
END

-- Find Staff Attendance by Staff Id and Date
ALTER PROCEDURE [dbo].[sp_FindStaffAttendanceByStaffIdAndDate]
    @StaffId INT,
    @Date DATETIME
AS
BEGIN
    SELECT * FROM StaffAttendance WHERE StaffId = @StaffId AND Date = @Date
END



-- Find Staff Details by Staff Id
ALTER PROCEDURE [dbo].[sp_FindStaffDetailsByStaffId]
    @StaffId INT
AS
BEGIN
    SELECT * FROM StaffDetails WHERE StaffId = @StaffId
END

-- Find by StaffId stored procedure
ALTER PROCEDURE [dbo].[sp_FindStaffSalaryByStaffId]
    @StaffId INT
AS
BEGIN
    SELECT * FROM StaffSalary WHERE StaffId = @StaffId
END;

-- Find by UTR stored procedure
ALTER PROCEDURE [dbo].[sp_FindStaffSalaryByUTR]
    @UTR NVARCHAR(255)
AS
BEGIN
    SELECT * FROM StaffSalary WHERE UTR = @UTR
END;

-- Find StudentAchievement By ClassId
ALTER PROCEDURE [dbo].[sp_FindStudentAchievementByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM StudentAchievement
    WHERE ClassId = @ClassId
END;


-- Find StudentAchievement By SectionId
ALTER PROCEDURE [dbo].[sp_FindStudentAchievementBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM StudentAchievement
    WHERE SectionId = @SectionId
END;

-- Find StudentAchievement By StudentId
ALTER PROCEDURE [dbo].[sp_FindStudentAchievementByStudentId]
    @StudentId INT
AS
BEGIN
    SELECT * FROM StudentAchievement
    WHERE StudentId = @StudentId
END;

-- Find StudentAttendance By ClassId
ALTER PROCEDURE [dbo].[sp_FindStudentAttendanceByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM StudentAttendance
    WHERE ClassId = @ClassId
END;

-- Find StudentAttendance By Date
ALTER PROCEDURE [dbo].[sp_FindStudentAttendanceByDate]
    @Date DATETIME
AS
BEGIN
    SELECT * FROM StudentAttendance
    WHERE Date = @Date
END;

-- Find StudentAttendance By SectionId
ALTER PROCEDURE [dbo].[sp_FindStudentAttendanceBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM StudentAttendance
    WHERE SectionId = @SectionId
END;


-- Find StudentAttendance By StudentId
ALTER PROCEDURE [dbo].[sp_FindStudentAttendanceByStudentId]
    @StudentId INT
AS
BEGIN
    SELECT * FROM StudentAttendance
    WHERE StudentId = @StudentId
END;


ALTER PROCEDURE [dbo].[sp_FindStudentDetailsByClassId]
    @ClassId INT
AS
BEGIN
    SELECT *
    FROM StudentDetails
    WHERE ClassId = @ClassId
END;


ALTER PROCEDURE [dbo].[sp_FindStudentDetailsBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT *
    FROM StudentDetails
    WHERE SectionId = @SectionId
END;


-- Find StudentDetails by StudentId
ALTER PROCEDURE [dbo].[sp_FindStudentDetailsByStudentId]
    @StudentId INT
AS
BEGIN
    SELECT *
    FROM StudentDetails
    WHERE StudentId = @StudentId
END;


-- Find StudentMarks By ClassId
ALTER PROCEDURE [dbo].[sp_FindStudentMarksByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM StudentMarks
    WHERE ClassId = @ClassId
END;


-- Find StudentMarks By SectionId
ALTER PROCEDURE [dbo].[sp_FindStudentMarksBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM StudentMarks
    WHERE SectionId = @SectionId
END;


-- Find StudentMarks By StudentId
ALTER PROCEDURE [dbo].[sp_FindStudentMarksByStudentId]
    @StudentId INT
AS
BEGIN
    SELECT * FROM StudentMarks
    WHERE StudentId = @StudentId
END;


-- Find Subject Teacher by Class Id
ALTER PROCEDURE [dbo].[sp_FindSubjectTeacherByClassId]
    @ClassId INT
AS
BEGIN
    SELECT * FROM SubjectTeacher WHERE ClassId = @ClassId
END




-- Find Subject Teacher by Section Id
ALTER PROCEDURE [dbo].[sp_FindSubjectTeacherBySectionId]
    @SectionId INT
AS
BEGIN
    SELECT * FROM SubjectTeacher WHERE SectionId = @SectionId
END


-- Find Subject Teacher by Staff Id
ALTER PROCEDURE [dbo].[sp_FindSubjectTeacherByStaffId]
    @StaffId INT
AS
BEGIN
    SELECT * FROM SubjectTeacher WHERE StaffId = @StaffId
END


-- Find Subject Teacher by Subject Name
ALTER PROCEDURE [dbo].[sp_FindSubjectTeacherBySubjectName]
    @Subject NVARCHAR(100)
AS
BEGIN
    SELECT * FROM SubjectTeacher WHERE Subject = @Subject
END



-- Stored Procedure for Finding UserRole by RoleId
ALTER PROCEDURE [dbo].[sp_FindUserRoleById]
    @RoleId INT
AS
BEGIN
    SELECT * FROM UserRole WHERE RoleId = @RoleId
END;

-- Stored Procedure for Finding UserRole by RoleName
ALTER PROCEDURE [dbo].[sp_FindUserRoleByName]
    @RoleName NVARCHAR(255)
AS
BEGIN
    SELECT * FROM UserRole WHERE RoleName = @RoleName
END;

-- Get User by Username
ALTER PROCEDURE [dbo].[sp_GetUserLogininModelByUsername]
    @Username NVARCHAR(255)
AS
BEGIN
    SELECT * FROM [User] WHERE Username = @Username
END;


-- List All ApprovalOfFees
ALTER PROCEDURE [dbo].[sp_ListAllApprovalOfFees]
AS
BEGIN
    SELECT * FROM ApprovalOfFees
END;



ALTER PROCEDURE [dbo].[sp_ListAllClassAttendances]
AS
BEGIN
    SELECT * FROM ClassAttendance;
END

ALTER PROCEDURE [dbo].[sp_ListAllClasses]
AS
BEGIN
    SELECT * FROM Class
END;



-- Stored procedure: sp_ListAllClassTeachers
ALTER PROCEDURE [dbo].[sp_ListAllClassTeachers]
AS
BEGIN
    SELECT * FROM ClassTeacher;
END


-- Stored Procedure for Reading All Complains By Student
ALTER PROCEDURE [dbo].[sp_ListAllComplainsByStudents]
AS
BEGIN
    SELECT * FROM ComplainByStudent
END;

-- List All Fees Updates By Student
ALTER PROCEDURE [dbo].[sp_ListAllFeesUpdateByStudents]
AS
BEGIN
    SELECT * FROM FeesUpdateByStudent
END;


ALTER PROCEDURE [dbo].[sp_ListAllGenerateFeesForStudents]
AS
BEGIN
    SELECT * FROM GenerateFeesForStudent
END

-- List All HwCw
ALTER PROCEDURE [dbo].[sp_ListAllHwCws]
AS
BEGIN
    SELECT * FROM HwCw
END;


-- List All stored procedure for listing all Revenue entries
ALTER PROCEDURE [dbo].[sp_ListAllRevenues]
AS
BEGIN
    SELECT * FROM Revenue
END;

-- Stored procedure: sp_GetSectionAttendanceList
ALTER PROCEDURE [dbo].[sp_ListAllSectionAttendances]
AS
BEGIN
    SELECT * FROM SectionAttendance;
END

-- List All Sections
ALTER PROCEDURE [dbo].[sp_ListAllSections]
AS
BEGIN
    SELECT * FROM Section
END;

-- List All Section Teachers
ALTER PROCEDURE [dbo].[sp_ListAllSectionTeachers]
AS
BEGIN
    SELECT * FROM SectionTeacher
END


-- List All Staff Attendances
ALTER PROCEDURE [dbo].[sp_ListAllStaffAttendances]
AS
BEGIN
    SELECT * FROM StaffAttendance
END

-- List All Staff Details
ALTER PROCEDURE [dbo].[sp_ListAllStaffDetails]
AS
BEGIN
    SELECT * FROM StaffDetails
END

-- List All stored procedure for listing all StaffSalary entries
ALTER PROCEDURE [dbo].[sp_ListAllStaffSalaries]
AS
BEGIN
    SELECT * FROM StaffSalary
END;

-- List All StudentAchievements
ALTER PROCEDURE [dbo].[sp_ListAllStudentAchievements]
AS
BEGIN
    SELECT * FROM StudentAchievement
END;


-- List All StudentAttendance
ALTER PROCEDURE [dbo].[sp_ListAllStudentAttendances]
AS
BEGIN
    SELECT * FROM StudentAttendance
END;


-- List All StudentDetails
ALTER PROCEDURE [dbo].[sp_ListAllStudentDetails]
AS
BEGIN
    SELECT * FROM StudentDetails
END;


-- List All StudentMarks
ALTER PROCEDURE [dbo].[sp_ListAllStudentMarks]
AS
BEGIN
    SELECT * FROM StudentMarks
END;


-- List All StudentRemarks
ALTER PROCEDURE [dbo].[sp_ListAllStudentRemarks]
AS
BEGIN
    SELECT * FROM StudentRemarks
END;


-- List All Subject Teachers
ALTER PROCEDURE [dbo].[sp_ListAllSubjectTeachers]
AS
BEGIN
    SELECT * FROM SubjectTeacher
END


-- Stored Procedure for Reading All UserRoles
ALTER PROCEDURE [dbo].[sp_ListAllUserRoles]
AS
BEGIN
    SELECT * FROM UserRole
END;

-- List All Users
ALTER PROCEDURE [dbo].[sp_ListAllUsers]
AS
BEGIN
    SELECT * FROM [User]
END;
*/



