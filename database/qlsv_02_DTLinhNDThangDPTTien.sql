USE [master]
GO
/****** Object:  Database [qlsv_02_DTLinhNDThangDPTTien]    Script Date: 5/28/2022 1:41:20 PM ******/
CREATE DATABASE [qlsv_02_DTLinhNDThangDPTTien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'qlsv_02_DTLinhNDThangDPTTien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LINHTOT\MSSQL\DATA\qlsv_02_DTLinhNDThangDPTTien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'qlsv_02_DTLinhNDThangDPTTien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.LINHTOT\MSSQL\DATA\qlsv_02_DTLinhNDThangDPTTien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [qlsv_02_DTLinhNDThangDPTTien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET ARITHABORT OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET RECOVERY FULL 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET  MULTI_USER 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'qlsv_02_DTLinhNDThangDPTTien', N'ON'
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET QUERY_STORE = OFF
GO
USE [qlsv_02_DTLinhNDThangDPTTien]
GO
/****** Object:  Table [dbo].[dangnhap]    Script Date: 5/28/2022 1:41:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangnhap](
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
	[fullname] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[mod] [bit] NULL,
	[state] [nvarchar](50) NULL,
 CONSTRAINT [PK_dangnhap] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[lop]    Script Date: 5/28/2022 1:41:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lop](
	[malop] [nvarchar](50) NOT NULL,
	[tenlop] [nvarchar](50) NULL,
	[email] [nvarchar](50) NULL,
	[hotenlt] [nvarchar](50) NULL,
 CONSTRAINT [PK_lop] PRIMARY KEY CLUSTERED 
(
	[malop] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sinhvien]    Script Date: 5/28/2022 1:41:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sinhvien](
	[masv] [int] NOT NULL,
	[hoten] [nvarchar](50) NULL,
	[ngaysinh] [date] NULL,
	[gioitinh] [bit] NULL,
	[quequan] [nvarchar](50) NULL,
	[diemrl] [int] NULL,
	[malop] [nvarchar](50) NULL,
 CONSTRAINT [PK_sinhvien] PRIMARY KEY CLUSTERED 
(
	[masv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[dangnhap] ([username], [password], [fullname], [email], [mod], [state]) VALUES (N'admin', N'admin', N'Nguyễn Văn A', N'admin@gmail.com', 0, NULL)
INSERT [dbo].[dangnhap] ([username], [password], [fullname], [email], [mod], [state]) VALUES (N'linh', N'linh', N'linh', N'linh@gmail.com', 1, NULL)
INSERT [dbo].[dangnhap] ([username], [password], [fullname], [email], [mod], [state]) VALUES (N'user', N'user', N'Nguyễn Văn B', N'user@gmail.com', 1, NULL)
GO
INSERT [dbo].[lop] ([malop], [tenlop], [email], [hotenlt]) VALUES (N'DHTI13A1HN', N'Tin 13a1', N'tin13a1@gmail.com', N'Đặng Xuân Sắc')
INSERT [dbo].[lop] ([malop], [tenlop], [email], [hotenlt]) VALUES (N'DHTI13A2HN', N'Tin 13a2', N'tin13a2@gmail.com', N'Lê Văn Trường')
INSERT [dbo].[lop] ([malop], [tenlop], [email], [hotenlt]) VALUES (N'DHTI13A3HN', N'Tin 13a3 ', N'tin13a3@gmail.com', N'Nguyễn Bích Thùy')
INSERT [dbo].[lop] ([malop], [tenlop], [email], [hotenlt]) VALUES (N'DHTI13A4HN', N'Tin 13a4', N'tin13a4@gmail.com', N'Vũ Hải Dương')
INSERT [dbo].[lop] ([malop], [tenlop], [email], [hotenlt]) VALUES (N'DHTI13A5HN', N'Tin 13a5', N'tin13a5@gmail.com', N'Nguyễn Thế Quang')
GO
INSERT [dbo].[sinhvien] ([masv], [hoten], [ngaysinh], [gioitinh], [quequan], [diemrl], [malop]) VALUES (1910310032, N'Đào Phan Trường Tiến', CAST(N'2001-11-16' AS Date), 1, N'Hà Nam', 79, N'DHTI13A2HN')
INSERT [dbo].[sinhvien] ([masv], [hoten], [ngaysinh], [gioitinh], [quequan], [diemrl], [malop]) VALUES (1910310072, N'Nguyễn Trọng Tấn', CAST(N'2001-03-02' AS Date), 1, N'Hà Nội', 85, N'DHTI13A5HN')
INSERT [dbo].[sinhvien] ([masv], [hoten], [ngaysinh], [gioitinh], [quequan], [diemrl], [malop]) VALUES (1910310098, N'Đinh Tùng Linh', CAST(N'2001-09-24' AS Date), 1, N'Hà Nội', 80, N'DHTI13A2HN')
INSERT [dbo].[sinhvien] ([masv], [hoten], [ngaysinh], [gioitinh], [quequan], [diemrl], [malop]) VALUES (1910310106, N'Nguyễn Đức Thắng', CAST(N'2001-08-12' AS Date), 1, N'Phú Thọ', 78, N'DHTI13A2HN')
INSERT [dbo].[sinhvien] ([masv], [hoten], [ngaysinh], [gioitinh], [quequan], [diemrl], [malop]) VALUES (1910310167, N'Phạm Trọng Khang', CAST(N'2001-03-20' AS Date), 1, N'Quảng Bình', 77, N'DHTI13A2HN')
GO
USE [master]
GO
ALTER DATABASE [qlsv_02_DTLinhNDThangDPTTien] SET  READ_WRITE 
GO
