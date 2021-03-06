USE [master]
GO
/****** Object:  Database [prj_prn]    Script Date: 22/07/2022 1:27:34 SA ******/
CREATE DATABASE [prj_prn]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'prj_prn', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TUANANH\MSSQL\DATA\prj_prn.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'prj_prn_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TUANANH\MSSQL\DATA\prj_prn_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [prj_prn] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [prj_prn].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [prj_prn] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [prj_prn] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [prj_prn] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [prj_prn] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [prj_prn] SET ARITHABORT OFF 
GO
ALTER DATABASE [prj_prn] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [prj_prn] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [prj_prn] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [prj_prn] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [prj_prn] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [prj_prn] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [prj_prn] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [prj_prn] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [prj_prn] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [prj_prn] SET  DISABLE_BROKER 
GO
ALTER DATABASE [prj_prn] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [prj_prn] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [prj_prn] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [prj_prn] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [prj_prn] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [prj_prn] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [prj_prn] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [prj_prn] SET RECOVERY FULL 
GO
ALTER DATABASE [prj_prn] SET  MULTI_USER 
GO
ALTER DATABASE [prj_prn] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [prj_prn] SET DB_CHAINING OFF 
GO
ALTER DATABASE [prj_prn] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [prj_prn] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [prj_prn] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [prj_prn] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'prj_prn', N'ON'
GO
ALTER DATABASE [prj_prn] SET QUERY_STORE = OFF
GO
USE [prj_prn]
GO
/****** Object:  Table [dbo].[tblCategory]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCategory](
	[food_type_id] [int] IDENTITY(1,1) NOT NULL,
	[type_name] [nvarchar](50) NOT NULL,
	[description] [nvarchar](100) NOT NULL,
	[image] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[food_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblcustomer]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblcustomer](
	[customer_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_first_name] [varchar](30) NOT NULL,
	[customer_last_name] [varchar](30) NOT NULL,
	[customer_middle_name] [varchar](30) NOT NULL,
	[customer_email] [varchar](50) NOT NULL,
	[customer_phone_number] [varchar](15) NOT NULL,
	[customer_landline] [varchar](15) NOT NULL,
	[customer_username] [varchar](30) NOT NULL,
	[customer_password] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblemployee]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblemployee](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [nvarchar](100) NOT NULL,
	[contact] [nvarchar](50) NOT NULL,
	[email_address] [nvarchar](50) NOT NULL,
	[employee_image] [nvarchar](100) NULL,
	[username] [nvarchar](30) NOT NULL,
	[password] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblfood_size]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblfood_size](
	[food_size_id] [int] not null identity(1,1),
	[food_size] [nvarchar](50) NOT NULL,
	primary key (food_size_id)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblorder]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblorder](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[order_date] [date] NOT NULL,
	[total_amount] [float] NOT NULL,
	[order_status] [int] NOT NULL,
	[processed_by] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblorderdetails]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblorderdetails](
	[order_details_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[food_id] [int] NOT NULL,
	[amount] [float] NOT NULL,
	[total_amount] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[order_details_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblpayment]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblpayment](
	[payment_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[amount] [float] NOT NULL,
	[paid_by] [nvarchar](50) NOT NULL,
	[payment_date] [date] NOT NULL,
	[processed_by] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[payment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblproducts]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblproducts](
	[food_id] [int] IDENTITY(1,1) NOT NULL,
	[menu_type_id] [int] NOT NULL,
	[food_name] [nvarchar](100) NOT NULL,
	[food_category] [nvarchar](45) NULL,
	[food_description] [nvarchar](200),
	[food_image] [nvarchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[food_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblrating]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblrating](
	[rating_id] [int] IDENTITY(1,1) NOT NULL,
	[food_id] [int] NOT NULL,
	[score] [int] NOT NULL,
	[remarks] [nvarchar](100) NOT NULL,
	[date_recorded] [date] NOT NULL,
	[customer_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rating_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblsiteinfo]    Script Date: 22/07/2022 1:27:34 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblsiteinfo](
	[site_info_id] [int] IDENTITY(1,1) NOT NULL,
	[site_name] [varchar](30) NOT NULL,
	[description] [nvarchar](100) NOT NULL,
	[contact_info] [nvarchar](15) NOT NULL,
	[address] [nvarchar](100) NOT NULL,
	[last_update] [date] NOT NULL,
	[user_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[site_info_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblCategory] ON 

INSERT [dbo].[tblCategory] ([food_type_id], [type_name], [description], [image]) VALUES (1, N'Pizza', N'Các loại đồ ăn nhanh', NULL)
INSERT [dbo].[tblCategory] ([food_type_id], [type_name], [description], [image]) VALUES (2, N'Drinks', N'Cái loại đồ uống', NULL)
INSERT [dbo].[tblCategory] ([food_type_id], [type_name], [description], [image]) VALUES (3, N'Burgers', N'Bánh burger', NULL)
INSERT [dbo].[tblCategory] ([food_type_id], [type_name], [description], [image]) VALUES (4, N'Salads', N'Salads', NULL)
INSERT [dbo].[tblCategory] ([food_type_id], [type_name], [description], [image]) VALUES (5, N'Tacos', N'Tacos', NULL)
INSERT [dbo].[tblCategory] ([food_type_id], [type_name], [description], [image]) VALUES (6, N'Wraps', N'đồ ăn vặt', NULL)
SET IDENTITY_INSERT [dbo].[tblCategory] OFF
GO
SET IDENTITY_INSERT [dbo].[tblcustomer] ON 

INSERT [dbo].[tblcustomer] ([customer_id], [customer_first_name], [customer_last_name], [customer_middle_name], [customer_email], [customer_phone_number], [customer_landline], [customer_username], [customer_password]) VALUES (1, N'Nguyen', N'Hoang', N'Van', N'anhpthe150124@fpt.edu.vn', N'0827523009', N'827523009', N'Hoangnv123', N'123456')
INSERT [dbo].[tblcustomer] ([customer_id], [customer_first_name], [customer_last_name], [customer_middle_name], [customer_email], [customer_phone_number], [customer_landline], [customer_username], [customer_password]) VALUES (2, N'Nguyen', N'Lien', N'Van', N'anhpthe150125@fpt.edu.vn', N'0827523007', N'827523007', N'Liennv123', N'123456')
INSERT [dbo].[tblcustomer] ([customer_id], [customer_first_name], [customer_last_name], [customer_middle_name], [customer_email], [customer_phone_number], [customer_landline], [customer_username], [customer_password]) VALUES (3, N'Nguyen', N'Giang', N'Van', N'anhpthe150126@fpt.edu.vn', N'0827523001', N'827523001', N'Giangnv123', N'123456')
INSERT [dbo].[tblcustomer] ([customer_id], [customer_first_name], [customer_last_name], [customer_middle_name], [customer_email], [customer_phone_number], [customer_landline], [customer_username], [customer_password]) VALUES (4, N'Nguyen', N'Lam', N'Van', N'anhpthe150128@fpt.edu.vn', N'0827523000', N'827523000', N'Lamnv123', N'123456')
SET IDENTITY_INSERT [dbo].[tblcustomer] OFF
GO
SET IDENTITY_INSERT [dbo].[tblemployee] ON 

INSERT [dbo].[tblemployee] ([user_id], [full_name], [contact], [email_address], [employee_image], [username], [password]) VALUES (1, N'Pham Tuan Anh', N'0827523006', N'Ptuananh270@gmail.com', NULL, N'ptuananh270', N'123456')
INSERT [dbo].[tblemployee] ([user_id], [full_name], [contact], [email_address], [employee_image], [username], [password]) VALUES (2, N'Pham Tuan Trang', N'0827523006', N'Ptuananh370@gmail.com', NULL, N'ptuananh370', N'123456')
INSERT [dbo].[tblemployee] ([user_id], [full_name], [contact], [email_address], [employee_image], [username], [password]) VALUES (3, N'Pham Tuan Anh', N'0827523006', N'Ptuanan470@gmail.com', NULL, N'ptuananh470', N'123456')
INSERT [dbo].[tblemployee] ([user_id], [full_name], [contact], [email_address], [employee_image], [username], [password]) VALUES (4, N'Pham Tuan Anh', N'0827523006', N'Ptuananh570@gmail.com', NULL, N'ptuananh570', N'123456')
INSERT [dbo].[tblemployee] ([user_id], [full_name], [contact], [email_address], [employee_image], [username], [password]) VALUES (5, N'Pham Tuan Anh', N'0827523006', N'Ptuananh670@gmail.com', NULL, N'ptuananh670', N'123456')
SET IDENTITY_INSERT [dbo].[tblemployee] OFF
GO
INSERT [dbo].[tblfood_size] ([food_id], [food_size], [food_price]) VALUES (1, 19, 15.0000)
INSERT [dbo].[tblfood_size] ([food_id], [food_size], [food_price]) VALUES (1, 25, 19.0000)
INSERT [dbo].[tblfood_size] ([food_id], [food_size], [food_price]) VALUES (3, 19, 15.0000)
INSERT [dbo].[tblfood_size] ([food_id], [food_size], [food_price]) VALUES (3, 25, 19.0000)
GO
SET IDENTITY_INSERT [dbo].[tblproducts] ON 

INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES ( 1, N'Pepperoni Pizza', N'Pizza', N'\images\products\p1.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (1, N'Trio Cheese', N'Pizza', N'\images\products\p2.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (1, N'Apricot Chicken', N'Pizza', N'\images\products\p3.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES ( 1, N'Italiano Original', N'Pizza', N'\images\products\p4.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (1, N'Chicken Hawaii', N'Pizza', N'\images\products\p5.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (2, N'Blueberry Shake', N'Shakes', N'\images\products\p1.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (6, N'Chocolate cake', N'Dessert', N'\images\products\p1.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (2, N'Cola bottle', N'Lemonades', N'\images\products\p1.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (2, N'Fresh Lime', N'Lemonades', N'\images\products\p1.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (2, N'Ice Lime Cola', N'Lemonades', N'\images\products\p1.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (2, N'Ice Tea', N'Lemonades', N'\images\products\p1.jpg')
INSERT [dbo].[tblproducts] ([menu_type_id], [food_name], [food_category], [food_image]) VALUES (2, N'Kiwin Smoothie', N'Smoothie', N'\images\products\p1.jpg')
SET IDENTITY_INSERT [dbo].[tblproducts] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tblcusto__64E4CB012C9A3966]    Script Date: 22/07/2022 1:27:34 SA ******/
ALTER TABLE [dbo].[tblcustomer] ADD UNIQUE NONCLUSTERED 
(
	[customer_username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tblemplo__F3DBC572955D3048]    Script Date: 22/07/2022 1:27:34 SA ******/
ALTER TABLE [dbo].[tblemployee] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tblorder] ADD  DEFAULT ('1') FOR [order_status]
GO
ALTER TABLE [dbo].[tblproducts] ADD  DEFAULT (NULL) FOR [food_category]
GO
ALTER TABLE [dbo].[tblfood_size]  WITH CHECK ADD FOREIGN KEY([food_id])
REFERENCES [dbo].[tblproducts] ([food_id])
GO
ALTER TABLE [dbo].[tblorder]  WITH CHECK ADD  CONSTRAINT [tblorder_ibfk_1] FOREIGN KEY([processed_by])
REFERENCES [dbo].[tblemployee] ([user_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblorder] CHECK CONSTRAINT [tblorder_ibfk_1]
GO
ALTER TABLE [dbo].[tblorder]  WITH CHECK ADD  CONSTRAINT [tblorder_ibfk_2] FOREIGN KEY([customer_id])
REFERENCES [dbo].[tblcustomer] ([customer_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblorder] CHECK CONSTRAINT [tblorder_ibfk_2]
GO
ALTER TABLE [dbo].[tblorderdetails]  WITH CHECK ADD  CONSTRAINT [tblorderdetails_ibfk_1] FOREIGN KEY([food_id])
REFERENCES [dbo].[tblproducts] ([food_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblorderdetails] CHECK CONSTRAINT [tblorderdetails_ibfk_1]
GO
ALTER TABLE [dbo].[tblorderdetails]  WITH CHECK ADD  CONSTRAINT [tblorderdetails_ibfk_2] FOREIGN KEY([order_id])
REFERENCES [dbo].[tblorder] ([order_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblorderdetails] CHECK CONSTRAINT [tblorderdetails_ibfk_2]
GO
ALTER TABLE [dbo].[tblpayment]  WITH CHECK ADD  CONSTRAINT [tblpayment_ibfk_1] FOREIGN KEY([processed_by])
REFERENCES [dbo].[tblemployee] ([user_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblpayment] CHECK CONSTRAINT [tblpayment_ibfk_1]
GO
ALTER TABLE [dbo].[tblpayment]  WITH CHECK ADD  CONSTRAINT [tblpayment_ibfk_2] FOREIGN KEY([order_id])
REFERENCES [dbo].[tblorder] ([order_id])
GO
ALTER TABLE [dbo].[tblpayment] CHECK CONSTRAINT [tblpayment_ibfk_2]
GO
ALTER TABLE [dbo].[tblproducts]  WITH CHECK ADD  CONSTRAINT [tblproducts_ibfk_1] FOREIGN KEY([menu_type_id])
REFERENCES [dbo].[tblCategory] ([food_type_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblproducts] CHECK CONSTRAINT [tblproducts_ibfk_1]
GO
ALTER TABLE [dbo].[tblrating]  WITH CHECK ADD  CONSTRAINT [tblrating_ibfk_1] FOREIGN KEY([food_id])
REFERENCES [dbo].[tblproducts] ([food_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblrating] CHECK CONSTRAINT [tblrating_ibfk_1]
GO
ALTER TABLE [dbo].[tblrating]  WITH CHECK ADD  CONSTRAINT [tblrating_ibfk_2] FOREIGN KEY([customer_id])
REFERENCES [dbo].[tblcustomer] ([customer_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblrating] CHECK CONSTRAINT [tblrating_ibfk_2]
GO
ALTER TABLE [dbo].[tblsiteinfo]  WITH CHECK ADD  CONSTRAINT [tblsiteinfo_ibfk_1] FOREIGN KEY([user_id])
REFERENCES [dbo].[tblemployee] ([user_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tblsiteinfo] CHECK CONSTRAINT [tblsiteinfo_ibfk_1]
GO
USE [master]
GO
ALTER DATABASE [prj_prn] SET  READ_WRITE 
GO
