USE [PriyaProjectDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblAdmin]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAdmin](
	[AdminId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[MobileNo] [nvarchar](max) NOT NULL,
	[EmailId] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblAdmin] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblCart]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCart](
	[CartId] [bigint] IDENTITY(1,1) NOT NULL,
	[CartDate] [datetime2](7) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[StoreId] [bigint] NOT NULL,
	[OrderTaxId] [bigint] NULL,
 CONSTRAINT [PK_TblCart] PRIMARY KEY CLUSTERED 
(
	[CartId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblCategory]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCategory](
	[CategoryId] [bigint] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblCategory] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblCity]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCity](
	[CityId] [bigint] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](max) NOT NULL,
	[StateId] [bigint] NOT NULL,
 CONSTRAINT [PK_TblCity] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblComplaint]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblComplaint](
	[ComplaintId] [bigint] IDENTITY(1,1) NOT NULL,
	[ComplaintDate] [datetime2](7) NOT NULL,
	[ComplaintDesc] [nvarchar](max) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
 CONSTRAINT [PK_TblComplaint] PRIMARY KEY CLUSTERED 
(
	[ComplaintId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblCountry]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCountry](
	[CountryId] [bigint] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblCountry] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblDispatchAgency]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDispatchAgency](
	[DispatchAgencyId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[MobileNo] [nvarchar](max) NOT NULL,
	[EmailId] [nvarchar](max) NOT NULL,
	[ContactPerson] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblDispatchAgency] PRIMARY KEY CLUSTERED 
(
	[DispatchAgencyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblDispatchOrder]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblDispatchOrder](
	[DispatchOrederId] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[DispatchDate] [datetime2](7) NOT NULL,
	[DocketNo] [nvarchar](max) NOT NULL,
	[DispatchAgencyId] [bigint] NOT NULL,
	[ExpectedReachDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_TblDispatchOrder] PRIMARY KEY CLUSTERED 
(
	[DispatchOrederId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblOffer]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOffer](
	[OfferId] [bigint] IDENTITY(1,1) NOT NULL,
	[OfferName] [nvarchar](max) NOT NULL,
	[Discount] [decimal](18, 2) NOT NULL,
	[StoreId] [bigint] NOT NULL,
 CONSTRAINT [PK_TblOffer] PRIMARY KEY CLUSTERED 
(
	[OfferId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblOrder]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOrder](
	[OrderId] [bigint] IDENTITY(1,1) NOT NULL,
	[Orderdate] [datetime2](7) NOT NULL,
	[UserId] [bigint] NOT NULL,
	[StoreId] [bigint] NOT NULL,
	[IsPaid] [bit] NOT NULL,
 CONSTRAINT [PK_TblOrder] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblOrderDet]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOrderDet](
	[OrderDetID] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TblOrderDet] PRIMARY KEY CLUSTERED 
(
	[OrderDetID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblOrderTax]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblOrderTax](
	[OrderTaxId] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[TaxId] [bigint] NOT NULL,
	[TaxAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TblOrderTax] PRIMARY KEY CLUSTERED 
(
	[OrderTaxId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblPayment]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPayment](
	[PaymentId] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[PaymentDate] [datetime2](7) NOT NULL,
	[PaymentAmount] [decimal](18, 2) NOT NULL,
	[PaymentMode] [int] NOT NULL,
 CONSTRAINT [PK_TblPayment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblPet]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPet](
	[PetId] [bigint] IDENTITY(1,1) NOT NULL,
	[PetName] [nvarchar](max) NOT NULL,
	[Age] [bigint] NOT NULL,
	[Gender] [int] NOT NULL,
	[PetTypeId] [bigint] NOT NULL,
	[PetFamilyId] [bigint] NOT NULL,
	[PetDesc] [nvarchar](max) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[PhotoPath] [nvarchar](max) NULL,
 CONSTRAINT [PK_TblPet] PRIMARY KEY CLUSTERED 
(
	[PetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblPetFamily]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPetFamily](
	[PetFamilyId] [bigint] IDENTITY(1,1) NOT NULL,
	[PetFamilyName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblPetFamily] PRIMARY KEY CLUSTERED 
(
	[PetFamilyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblPetFood]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPetFood](
	[FoodId] [bigint] IDENTITY(1,1) NOT NULL,
	[FoodName] [nvarchar](max) NOT NULL,
	[MfgName] [nvarchar](max) NOT NULL,
	[FoodDesc] [nvarchar](max) NOT NULL,
	[PhotoPath] [nvarchar](max) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[GoodFoodAccordingToPetAge] [int] NOT NULL,
 CONSTRAINT [PK_TblPetFood] PRIMARY KEY CLUSTERED 
(
	[FoodId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblPetPhotos]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPetPhotos](
	[PetPhotosId] [bigint] IDENTITY(1,1) NOT NULL,
	[PetId] [bigint] NOT NULL,
	[PhotoTitle] [nvarchar](max) NOT NULL,
	[PhotoPath] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblPetPhotos] PRIMARY KEY CLUSTERED 
(
	[PetPhotosId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblPetProduct]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPetProduct](
	[PetProductId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[MfgName] [nvarchar](max) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[ProductDesc] [nvarchar](max) NOT NULL,
	[PhotoPath] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblPetProduct] PRIMARY KEY CLUSTERED 
(
	[PetProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblPetType]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPetType](
	[PetTypeId] [bigint] IDENTITY(1,1) NOT NULL,
	[PetTypeName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblPetType] PRIMARY KEY CLUSTERED 
(
	[PetTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblProduct]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblProduct](
	[ProductId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductType] [int] NOT NULL,
	[ProductPrice] [decimal](18, 2) NOT NULL,
	[StoreId] [bigint] NOT NULL,
 CONSTRAINT [PK_TblProduct] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblProductReview]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblProductReview](
	[ProductReviewId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Rating] [int] NOT NULL,
	[UserId] [bigint] NOT NULL,
	[ReviewDesc] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblProductReview] PRIMARY KEY CLUSTERED 
(
	[ProductReviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblRefund]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblRefund](
	[RefundId] [bigint] IDENTITY(1,1) NOT NULL,
	[ReturnId] [bigint] NOT NULL,
	[RefundDate] [datetime2](7) NOT NULL,
	[RefundAmount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TblRefund] PRIMARY KEY CLUSTERED 
(
	[RefundId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblReturn]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblReturn](
	[ReturnId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[ReturnDate] [datetime2](7) NOT NULL,
	[ReturnReason] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblReturn] PRIMARY KEY CLUSTERED 
(
	[ReturnId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblSolution]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSolution](
	[SolutionId] [bigint] IDENTITY(1,1) NOT NULL,
	[SolutionDate] [datetime2](7) NOT NULL,
	[SolutionDesc] [nvarchar](max) NOT NULL,
	[ComplaintId] [bigint] NOT NULL,
 CONSTRAINT [PK_TblSolution] PRIMARY KEY CLUSTERED 
(
	[SolutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblState]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblState](
	[StateId] [bigint] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](max) NULL,
	[CountryId] [bigint] NOT NULL,
 CONSTRAINT [PK_TblState] PRIMARY KEY CLUSTERED 
(
	[StateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblStore]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblStore](
	[StoreId] [bigint] IDENTITY(1,1) NOT NULL,
	[StoreName] [nvarchar](max) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[MobileNo] [nvarchar](max) NOT NULL,
	[EmailId] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[CityId] [bigint] NOT NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_TblStore] PRIMARY KEY CLUSTERED 
(
	[StoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblStoreReview]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblStoreReview](
	[StoreReviewId] [bigint] IDENTITY(1,1) NOT NULL,
	[Review] [nvarchar](max) NOT NULL,
	[StoreId] [bigint] NOT NULL,
	[Rating] [int] NOT NULL,
	[UserId] [bigint] NOT NULL,
 CONSTRAINT [PK_TblStoreReview] PRIMARY KEY CLUSTERED 
(
	[StoreReviewId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblTax]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTax](
	[TaxId] [bigint] IDENTITY(1,1) NOT NULL,
	[TaxPercentage] [decimal](18, 2) NOT NULL,
	[HSNSACNo] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TblTax] PRIMARY KEY CLUSTERED 
(
	[TaxId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TblUser]    Script Date: 04-06-2024 18:46:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUser](
	[UserId] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[MobileNo] [nvarchar](max) NOT NULL,
	[EmailId] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Gender] [int] NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[CityId] [bigint] NOT NULL,
 CONSTRAINT [PK_TblUser] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240424084636_DatabaseCreate', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240426132319_OfferTblAdd', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240427115405_123', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240428110645_deletecategory', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240507104351_TaxTblEdit', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240507111550_ispaidchange', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240507115937_CartQuantitydatatypechange', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240507130629_paymentTblAdd', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240508103708_ordertaxaddthendelete', N'7.0.18')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240510092113_removeoredrpaymentclass', N'7.0.18')
SET IDENTITY_INSERT [dbo].[TblAdmin] ON 

INSERT [dbo].[TblAdmin] ([AdminId], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [Password]) VALUES (1, N'Priyanka', N'Chaure', N'Pune', N'9876543210', N'priyanka@gmail.com', N'1234')
SET IDENTITY_INSERT [dbo].[TblAdmin] OFF
SET IDENTITY_INSERT [dbo].[TblCart] ON 

INSERT [dbo].[TblCart] ([CartId], [CartDate], [Quantity], [Price], [UserId], [ProductId], [StoreId], [OrderTaxId]) VALUES (46, CAST(N'2024-05-13 13:51:54.8416775' AS DateTime2), 2, CAST(9000.00 AS Decimal(18, 2)), 1, 62, 1, NULL)
INSERT [dbo].[TblCart] ([CartId], [CartDate], [Quantity], [Price], [UserId], [ProductId], [StoreId], [OrderTaxId]) VALUES (47, CAST(N'2024-05-22 18:31:48.0502886' AS DateTime2), 2, CAST(400.00 AS Decimal(18, 2)), 1, 118, 1, NULL)
INSERT [dbo].[TblCart] ([CartId], [CartDate], [Quantity], [Price], [UserId], [ProductId], [StoreId], [OrderTaxId]) VALUES (48, CAST(N'2024-05-22 18:31:58.8644121' AS DateTime2), 1, CAST(3200.00 AS Decimal(18, 2)), 1, 98, 1, NULL)
SET IDENTITY_INSERT [dbo].[TblCart] OFF
SET IDENTITY_INSERT [dbo].[TblCategory] ON 

INSERT [dbo].[TblCategory] ([CategoryId], [CategoryName]) VALUES (2, N'PetType')
INSERT [dbo].[TblCategory] ([CategoryId], [CategoryName]) VALUES (3, N'PetFood')
INSERT [dbo].[TblCategory] ([CategoryId], [CategoryName]) VALUES (4, N'PetProduct')
SET IDENTITY_INSERT [dbo].[TblCategory] OFF
SET IDENTITY_INSERT [dbo].[TblCity] ON 

INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (3, N'Nagpur', 12)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (4, N'Aurangabad', 12)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (5, N'Mumbai', 12)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (6, N'Thane', 12)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (7, N'Amritsar', 13)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (8, N'Jalandhar', 13)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (9, N'Ludhaina', 13)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (10, N'Bathinda', 13)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (11, N'Patiala', 13)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (12, N'Guwahati', 15)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (13, N'Dibrugarh', 15)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (14, N'Silchar', 15)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (15, N'Tezpur', 15)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (16, N'Rajkot', 16)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (17, N'Ahmedabad', 16)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (18, N'Vadodara', 16)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (19, N'Surat', 16)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (20, N'Kozhikode', 17)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (21, N'Thruvanthapuram', 17)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (22, N'Kochi', 17)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (23, N'Kannur', 17)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (24, N'Los Angeles', 18)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (25, N'San Francisco', 17)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (26, N'San Diego', 17)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (27, N'Fresno', 18)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (28, N'Irvine', 18)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (29, N'Houston', 19)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (30, N'Austin', 19)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (31, N'Dallas', 19)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (32, N'Texas City', 19)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (33, N'Clifton', 20)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (34, N'Edison', 20)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (35, N'Hoboken', 20)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (36, N'Wayne', 20)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (37, N'Cherry Hill', 20)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (38, N'Albany', 21)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (39, N'Yonkers', 21)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (40, N'Buffalo', 21)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (41, N'Ithaca', 21)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (42, N'Utica', 21)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (43, N'Charleston', 22)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (44, N'Florence', 22)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (45, N'Clemson', 22)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (46, N'Rock Hill', 22)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (47, N'Brisbane', 25)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (48, N'Cairns', 25)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (49, N'Mackay', 25)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (50, N'Toowoomba', 25)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (51, N'Newport', 26)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (52, N'Swansea', 26)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (53, N'Rhondda', 26)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (54, N'Laugharne', 26)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (55, N'Melbourne', 27)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (56, N'Geelong', 27)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (57, N'Bendigo', 27)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (58, N'Ballarat', 27)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (59, N'Hobart', 28)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (60, N'Launceston', 28)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (61, N'Devonport', 28)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (62, N'Burnie', 28)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (63, N'Adelaide', 29)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (64, N'Port Augusta', 29)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (65, N'Whyllas', 29)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (66, N'Port Lincoln', 29)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (67, N'Khasab', 30)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (68, N'Madha', 30)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (69, N'Kumzar', 30)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (70, N'Qadah', 30)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (71, N'Rusayl', 31)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (72, N'Surnizwa', 31)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (73, N'Sohar', 31)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (74, N'Shinas', 32)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (75, N'AI Suwayq', 32)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (76, N'AI Khaburah', 32)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (77, N'Muttrah', 33)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (78, N'Seeb', 33)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (79, N'Bawshar', 33)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (80, N'Salalah', 34)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (81, N'Mibrat', 34)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (82, N'Taqah', 34)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (83, N'Chizou', 35)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (84, N'Bengbu', 35)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (85, N'Fuzhou', 36)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (86, N'Xiamen', 36)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (87, N'Longnan', 37)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (88, N'Tianshui', 37)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (89, N'Baishan', 38)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (90, N'Dehui', 38)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (91, N'Shenzhen', 39)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (92, N'Jiangmn', 39)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (93, N'Milan', 40)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (94, N'Brescia', 40)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (95, N'Rome', 41)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (96, N'Tivoli', 41)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (97, N'Urbino', 42)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (98, N'Lesi', 42)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (99, N'Pesaro', 43)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (100, N'Ancona', 43)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (101, N'Venice', 44)
GO
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (102, N'Vicenza', 44)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (103, N'Ethia', 45)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (104, N'Lentas', 45)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (105, N'Plaka', 46)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (106, N'Acropolis', 46)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (107, N'Mycenaean', 47)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (108, N'Epigoni', 47)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (109, N'Chalcis', 48)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (110, N'Eretria', 48)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (111, N'Antirrio', 49)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (112, N'Thermo', 49)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (113, N'Lower Hutt', 50)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (114, N'Upper Hutt', 50)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (115, N'Manurewa', 51)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (116, N'Papakura', 51)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (117, N'Dunedin', 52)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (118, N'QueensTown', 52)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (119, N'Richmond', 53)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (120, N'Murchison', 53)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (121, N'New Plymoth', 54)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (122, N'Waitara', 54)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (126, N'Pune', 12)
INSERT [dbo].[TblCity] ([CityId], [CityName], [StateId]) VALUES (129, N'demo', 34)
SET IDENTITY_INSERT [dbo].[TblCity] OFF
SET IDENTITY_INSERT [dbo].[TblComplaint] ON 

INSERT [dbo].[TblComplaint] ([ComplaintId], [ComplaintDate], [ComplaintDesc], [OrderId], [ProductId]) VALUES (7, CAST(N'2024-05-19 13:15:00.0000000' AS DateTime2), N'Your Goat Is Not Good!', 3, 70)
INSERT [dbo].[TblComplaint] ([ComplaintId], [ComplaintDate], [ComplaintDesc], [OrderId], [ProductId]) VALUES (8, CAST(N'2024-05-30 13:32:00.0000000' AS DateTime2), N'This Conditioner is not suited for our Pet!', 8, 99)
INSERT [dbo].[TblComplaint] ([ComplaintId], [ComplaintDate], [ComplaintDesc], [OrderId], [ProductId]) VALUES (9, CAST(N'2024-05-15 15:39:00.0000000' AS DateTime2), N'Johny''s Mental health Not Good!', 9, 137)
INSERT [dbo].[TblComplaint] ([ComplaintId], [ComplaintDate], [ComplaintDesc], [OrderId], [ProductId]) VALUES (10, CAST(N'2024-05-16 14:49:00.0000000' AS DateTime2), N'This is too much small PetHome.', 9, 141)
INSERT [dbo].[TblComplaint] ([ComplaintId], [ComplaintDate], [ComplaintDesc], [OrderId], [ProductId]) VALUES (11, CAST(N'2024-05-16 15:42:00.0000000' AS DateTime2), N'Goat Food Is Not Tasty!', 8, 120)
INSERT [dbo].[TblComplaint] ([ComplaintId], [ComplaintDate], [ComplaintDesc], [OrderId], [ProductId]) VALUES (12, CAST(N'2024-05-18 13:08:00.0000000' AS DateTime2), N'Tiger is So Lazy!', 8, 50)
INSERT [dbo].[TblComplaint] ([ComplaintId], [ComplaintDate], [ComplaintDesc], [OrderId], [ProductId]) VALUES (14, CAST(N'2024-05-20 13:38:00.0000000' AS DateTime2), N'It''s a too small pethome!', 9, 141)
SET IDENTITY_INSERT [dbo].[TblComplaint] OFF
SET IDENTITY_INSERT [dbo].[TblCountry] ON 

INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (1, N'United States')
INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (2, N'Australia')
INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (3, N'United Kindom')
INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (4, N'Russia')
INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (5, N'India')
INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (8, N'Oman')
INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (11, N'China')
INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (13, N'Italy')
INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (19, N'Greece')
INSERT [dbo].[TblCountry] ([CountryId], [CountryName]) VALUES (20, N'New Zeeland')
SET IDENTITY_INSERT [dbo].[TblCountry] OFF
SET IDENTITY_INSERT [dbo].[TblDispatchAgency] ON 

INSERT [dbo].[TblDispatchAgency] ([DispatchAgencyId], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [ContactPerson]) VALUES (2, N'Gorge', N'Agency', N'Wakad', N'1234567890', N'gorgeagency@gmail.com', N'Tejas Chaure')
INSERT [dbo].[TblDispatchAgency] ([DispatchAgencyId], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [ContactPerson]) VALUES (3, N'Santa', N'Agency', N'Pune', N'5645566667', N'santaagency@gmail.com', N'Swapnil Chaure')
INSERT [dbo].[TblDispatchAgency] ([DispatchAgencyId], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [ContactPerson]) VALUES (4, N'Harnita', N'Agency', N'Nashik', N'1111133445', N'harnitaagency@gmail.com', N'Kunal  Chaure')
INSERT [dbo].[TblDispatchAgency] ([DispatchAgencyId], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [ContactPerson]) VALUES (5, N'Jenny', N'Agency', N'Mumbai', N'6677889944', N'jennyagency@gmail.com', N'Jay Kamble')
INSERT [dbo].[TblDispatchAgency] ([DispatchAgencyId], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [ContactPerson]) VALUES (6, N'Kotha', N'Agency', N'Delhi', N'1233215677', N'kothaagency@gmail.com', N'Vijay Mane')
SET IDENTITY_INSERT [dbo].[TblDispatchAgency] OFF
SET IDENTITY_INSERT [dbo].[TblDispatchOrder] ON 

INSERT [dbo].[TblDispatchOrder] ([DispatchOrederId], [OrderId], [DispatchDate], [DocketNo], [DispatchAgencyId], [ExpectedReachDate]) VALUES (1, 1, CAST(N'2024-05-15 16:35:00.0000000' AS DateTime2), N'1234', 3, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TblDispatchOrder] ([DispatchOrederId], [OrderId], [DispatchDate], [DocketNo], [DispatchAgencyId], [ExpectedReachDate]) VALUES (2, 8, CAST(N'2024-05-12 18:44:40.3865575' AS DateTime2), N'2222', 2, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TblDispatchOrder] ([DispatchOrederId], [OrderId], [DispatchDate], [DocketNo], [DispatchAgencyId], [ExpectedReachDate]) VALUES (3, 3, CAST(N'2024-05-13 18:08:11.9943029' AS DateTime2), N'777', 5, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TblDispatchOrder] ([DispatchOrederId], [OrderId], [DispatchDate], [DocketNo], [DispatchAgencyId], [ExpectedReachDate]) VALUES (4, 9, CAST(N'2024-05-15 15:34:56.8853097' AS DateTime2), N'7777', 4, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
INSERT [dbo].[TblDispatchOrder] ([DispatchOrederId], [OrderId], [DispatchDate], [DocketNo], [DispatchAgencyId], [ExpectedReachDate]) VALUES (5, 6, CAST(N'2024-05-23 17:18:15.7000820' AS DateTime2), N'3456', 5, CAST(N'0001-01-01 00:00:00.0000000' AS DateTime2))
SET IDENTITY_INSERT [dbo].[TblDispatchOrder] OFF
SET IDENTITY_INSERT [dbo].[TblOffer] ON 

INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (1, N'Offer On Pets', CAST(20.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (2, N'Offer On Pets', CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (3, N'Offer On Pets', CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (4, N'Offer On Pet Products', CAST(30.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (5, N'Offer On Pet Products', CAST(30.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (6, N'Offer On Pet Products', CAST(30.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (8, N'Offer On Pet Food', CAST(20.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (9, N'Offer On Pet Food', CAST(20.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (11, N'tytughg', CAST(44.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblOffer] ([OfferId], [OfferName], [Discount], [StoreId]) VALUES (12, N'Offer On Pet Foods ', CAST(40.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[TblOffer] OFF
SET IDENTITY_INSERT [dbo].[TblOrder] ON 

INSERT [dbo].[TblOrder] ([OrderId], [Orderdate], [UserId], [StoreId], [IsPaid]) VALUES (1, CAST(N'2024-05-07 19:10:42.0925784' AS DateTime2), 1, 1, 0)
INSERT [dbo].[TblOrder] ([OrderId], [Orderdate], [UserId], [StoreId], [IsPaid]) VALUES (3, CAST(N'2024-05-09 18:50:54.7000479' AS DateTime2), 1, 1, 0)
INSERT [dbo].[TblOrder] ([OrderId], [Orderdate], [UserId], [StoreId], [IsPaid]) VALUES (4, CAST(N'2024-05-09 19:18:16.2796115' AS DateTime2), 1, 1, 0)
INSERT [dbo].[TblOrder] ([OrderId], [Orderdate], [UserId], [StoreId], [IsPaid]) VALUES (5, CAST(N'2024-05-09 19:19:02.9874303' AS DateTime2), 1, 2, 0)
INSERT [dbo].[TblOrder] ([OrderId], [Orderdate], [UserId], [StoreId], [IsPaid]) VALUES (6, CAST(N'2024-05-09 19:25:31.8988362' AS DateTime2), 1, 1, 0)
INSERT [dbo].[TblOrder] ([OrderId], [Orderdate], [UserId], [StoreId], [IsPaid]) VALUES (7, CAST(N'2024-05-09 19:25:50.1682632' AS DateTime2), 1, 2, 0)
INSERT [dbo].[TblOrder] ([OrderId], [Orderdate], [UserId], [StoreId], [IsPaid]) VALUES (8, CAST(N'2024-05-10 14:32:11.2160629' AS DateTime2), 1, 1, 1)
INSERT [dbo].[TblOrder] ([OrderId], [Orderdate], [UserId], [StoreId], [IsPaid]) VALUES (9, CAST(N'2024-05-10 14:33:04.5799690' AS DateTime2), 1, 2, 1)
INSERT [dbo].[TblOrder] ([OrderId], [Orderdate], [UserId], [StoreId], [IsPaid]) VALUES (10, CAST(N'2024-05-20 16:56:22.5144743' AS DateTime2), 2, 1, 1)
SET IDENTITY_INSERT [dbo].[TblOrder] OFF
SET IDENTITY_INSERT [dbo].[TblOrderDet] ON 

INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (1, 1, 50, 2, CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (2, 1, 48, 2, CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (3, 1, 52, 2, CAST(15000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (4, 1, 64, 1, CAST(5000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (5, 1, 137, 1, CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (6, 3, 70, 1, CAST(6900.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (7, 3, 121, 2, CAST(1500.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (8, 3, 96, 2, CAST(600.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (9, 3, 137, 2, CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (10, 3, 142, 1, CAST(600.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (11, 3, 141, 1, CAST(1300.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (12, 4, 48, 1, CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (13, 4, 119, 1, CAST(490.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (14, 4, 100, 1, CAST(340.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (15, 6, 48, 1, CAST(10000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (16, 6, 117, 1, CAST(900.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (17, 6, 96, 1, CAST(600.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (18, 7, 137, 1, CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (19, 7, 142, 1, CAST(600.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (20, 7, 141, 1, CAST(1300.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (21, 8, 50, 1, CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (22, 8, 120, 1, CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (23, 8, 99, 1, CAST(440.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (24, 9, 137, 1, CAST(7000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (25, 9, 142, 1, CAST(600.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (26, 9, 141, 1, CAST(1300.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (27, 10, 68, 1, CAST(4500.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (28, 10, 82, 1, CAST(234.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (29, 10, 121, 1, CAST(1500.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (30, 10, 128, 1, CAST(1670.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (31, 10, 103, 1, CAST(670.00 AS Decimal(18, 2)))
INSERT [dbo].[TblOrderDet] ([OrderDetID], [OrderId], [ProductId], [Quantity], [Price]) VALUES (32, 10, 105, 1, CAST(345.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[TblOrderDet] OFF
SET IDENTITY_INSERT [dbo].[TblPayment] ON 

INSERT [dbo].[TblPayment] ([PaymentId], [OrderId], [PaymentDate], [PaymentAmount], [PaymentMode]) VALUES (1, 8, CAST(N'2024-05-10 14:32:43.6894157' AS DateTime2), CAST(13640.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblPayment] ([PaymentId], [OrderId], [PaymentDate], [PaymentAmount], [PaymentMode]) VALUES (2, 9, CAST(N'2024-05-10 14:33:27.1638842' AS DateTime2), CAST(8900.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblPayment] ([PaymentId], [OrderId], [PaymentDate], [PaymentAmount], [PaymentMode]) VALUES (3, 10, CAST(N'2024-05-20 16:56:22.5504272' AS DateTime2), CAST(8919.00 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[TblPayment] OFF
SET IDENTITY_INSERT [dbo].[TblPet] ON 

INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (14, N'Kitty', 2, 2, 1, 3, N'The Persian cat, also known as the Persian Longhair, is a long-haired breed of cat characterised by a round face and short muzzle.', 48, N'\PetImages\persiancat.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (15, N'Tiger', 4, 1, 2, 7, N'The Bulldog is a British breed of dog of mastiff type. It may also be known as the English Bulldog or British Bulldog', 50, N'\PetImages\Bulldog.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (16, N'Luna', 5, 1, 3, 12, N'The American Paint Horse is a breed of horse that combines both the conformational characteristics of a western stock horse with a pinto spotting pattern of Horse', 52, N'\PetImages\american horse.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (17, N'Greeko', 3, 2, 4, 20, N'Social and affectionate, the name comes from the parrots'' strong, monogamous pair bonding and the long periods which paired birds spend sitting together.', 54, N'\PetImages\lovebird.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (20, N'fisshy', 2, 2, 5, 23, N'The goldfish (Carassius auratus) is a freshwater fish in the family Cyprinidae of order Cypriniformes. It is commonly kept as a pet in indoor aquariums,', 60, N'\PetImages\goldfish3.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (21, N'Rabby', 2, 1, 6, 27, N'Dutch rabbits are purely a domestic breed. They are a small-medium sized animal with a compact body and large erect ears that are well furred. Rabbits are known dutch Rabbit.', 62, N'\PetImages\dutchrabbit.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (22, N'Torto', 1, 1, 8, 33, N'Caring for an African Sideneck Turtle is a relatively easy thing to do as long as you are consistent and educated on their physiology and nutritional needs.', 64, N'\PetImages\africanturtle.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (24, N'Paro', 2, 1, 9, 39, N'Amazon parrots are parrots in the genus Amazona. They are medium-sized, short-tailed parrots native to the Americas, with their range extending from South', 68, N'\PetImages\amazonparrot.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (25, N'Goat', 3, 2, 10, 46, N'Mini Silkies are not required to faint, although a big percentage of them do and eventually we expect that all of them will faint, but fainting is not our goal,', 70, N'\PetImages\miniaturegoat.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (26, N'Chiken', 1, 1, 11, 48, N'The Cochin is a breed of large domestic chicken. It derives from large feather-legged chickens brought from China to Europe and North America in the 1840s', 72, N'\PetImages\chikenimage.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (31, N'Srisha', 4, 2, 5, 8, N'A pet is a domesticated animal that lives with people, but is not forced to work and is not eaten, in most instances.', 82, N'\PetImages\dogs.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (32, N'gggggggggg', 1, 1, 1, 2, N'fgfddg', 90, N'\PetImages\dogbrown.jfif')
INSERT [dbo].[TblPet] ([PetId], [PetName], [Age], [Gender], [PetTypeId], [PetFamilyId], [PetDesc], [ProductId], [PhotoPath]) VALUES (36, N'johny', 4, 1, 2, 6, N'English Bulldog puppy price in Hyderabad ranges from ₹15,000 to ₹35,000. The price depends on factors like the dog''s size, lineage, color, reputation, and location. If you are considering adding a Bulldog to your family, it''s important to be aware of the factors that can influence their price.', 137, N'\PetImages\dogs.jfif')
SET IDENTITY_INSERT [dbo].[TblPet] OFF
SET IDENTITY_INSERT [dbo].[TblPetFamily] ON 

INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (2, N'Maine Coon')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (3, N'Persian Cat')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (4, N'American shorthair')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (5, N'Birman')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (6, N'Ragdoll')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (7, N'Bulldog')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (8, N'Golden Retriever')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (9, N'Pomeranian')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (10, N'Chihuahua')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (11, N'Poodle')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (12, N'American Paint Horse')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (13, N'Arabian')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (14, N'Morgan Horse')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (15, N'Miniature')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (16, N'Icelandic Horse')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (17, N'Parakeet ')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (18, N'Cockatiel')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (19, N'Finch')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (20, N'LoveBird')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (21, N'MonkParakeet')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (22, N'AngelFish')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (23, N' Goldfish')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (24, N'Tetras')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (25, N' Cory Catfish')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (26, N' Cardinal Tetras')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (27, N' Dutch Rabbit')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (28, N' Lionhead Rabbit')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (29, N' Californian Rabbit')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (30, N' Netherland Dwarf Rabbit')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (31, N' American Rabbit')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (32, N'Red-Eared Slider')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (33, N'African Sideneck Turtle')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (34, N'Eastern Box Turtle')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (35, N'Western Painted Turtle')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (36, N'Mississippi Map Turtle')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (37, N' Macaw')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (38, N' Grey Parrot')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (39, N'Amazon parrot')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (40, N'Budgerigar')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (41, N' Conure Parrot')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (42, N'Pygmy')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (43, N'Mini Alpines')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (44, N'Nigerian Dwarf')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (45, N'Mini Myotonics')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (46, N'Miniature Silky Fainting Goats')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (47, N'Silked White Easter Eggers')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (48, N'Cochins:')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (49, N'Salmon Faverolles')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (50, N'Duccles:')
INSERT [dbo].[TblPetFamily] ([PetFamilyId], [PetFamilyName]) VALUES (51, N'Speckled Sussex')
SET IDENTITY_INSERT [dbo].[TblPetFamily] OFF
SET IDENTITY_INSERT [dbo].[TblPetFood] ON 

INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (3, N'Finch Food', N'Finia', N'Finches are generally seed eaters that eat a variety of plant seeds, especially grasses. Depending on the season, seed availability, insects and certain fruits, berries, and other vegetation will constitute the bulk of a finch''s diet during certain times of the year.', N'\PetFoodImages\finchbirdfood.jfif', 117, 2)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (4, N'Floating Pellets', N'Flowshia', N'Dry foods: Flake food is a type of proprietary or artificially manufactured fish food consumed by a wide variety of tropical and saltwater fish and invertebrates. It is ideally suited to top dwellers and mid-water fish though numerous bottom dwelling species consume flake food', N'\PetFoodImages\fishfood1.jfif', 118, 3)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (5, N'Nutrition Fish Food', N'Della', N'Finally, a handful of tips – small fish species and those with small mouth holes should be fed with flakes and microgranules. Larger species that collect food from the water surface are best fed with chips and sticks, while bottom fish eat flakes, pellets, tablets or wafers.', N'\PetFoodImages\fishfood12.jfif', 119, 4)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (6, N'Goat Food', N'Punjack', N'We''re building the GREATEST food brands of all time. G.O.A.T. Foods is our family business that has created a collection of unique brands. Each brand is curated', N'\PetFoodImages\goatfood.jfif', 120, 9)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (7, N'Fancy Feed', N'Diana', N'Hottest Deals. Goat Food. Showing the single result. Sort by popularity, Sort by average rating, Sort by latest, Sort by price: low to high, Sort by price', N'\PetFoodImages\goatfood2.jfif', 121, 6)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (8, N'Goat Treats', N'Hinamila', N'This is a very high yieding grass variety. With proper care, you would be able to harvest around 150 tonnes per year per acre. This has average protien content ', N'\PetFoodImages\goatfood3.jfif', 122, 9)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (9, N'Horse Feed', N'Jokina', N'Food supplements of Horsefood the best to order online. All supplements from magnesium, electrolytes, sport recovery to fly spray.', N'\PetFoodImages\horsefeed.jfif', 123, 9)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (10, N'Hygain Feed', N'Hyna', N'In simple terms, horses eat grass and hay or haylage, but salt, concentrates and fruits or vegetables can also enhance their diets, depending on the required work regime and available feed.', N'\PetFoodImages\hygainhorsefood.jfif', 124, 8)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (12, N'Pedigree Food', N'Pedia', N'Pedigree offers the best dry dog food with high-quality ingredients that are rich in proteins and nutrition. Order now and get them delivered at your', N'\PetFoodImages\pedigreedogfood.jpg', 126, 5)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (13, N'Nut Fruit', N'Nutriaa', N'Nuts are actually fruits. They are defined as dry, single-seeded fruits that have high oil content. They are usually enclosed in a leathery or solid outer layer. In botany terms, nuts are strictly a particular kind of dry fruit that has a single seed, a hard shell, and a protective husk.', N'\PetFoodImages\nutfruitbirdfood.jfif', 127, 6)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (14, N'Natural Feed', N'Mintinosa', N'Sunflower seeds are the seeds favored by most seed-eating birds, some 40 species including cardinals, tufted titmice, Carolina chickadees, house and purple finches, American goldfinches, brown-headed nuthatches, and red-bellied woodpeckers, to name a few.', N'\PetFoodImages\parrotfood.jfif', 128, 8)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (15, N'Prestige Food', N'Prestige', N' Prestige Food Paradise''s profile on LinkedIn, the world''s largest professional community. Prestige has 1 job listed on their profile', N'\PetFoodImages\parrotfood1.jfif', 129, 5)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (16, N'Rabbit Pellets', N'Rania', N'WiggleBoo Rabbit Pellet Food Rich in Vitamins D, Minerals,Calcium & Healthy Food for All Kinds of Rabbit Every Bite Have Nutrition (450gm).', N'\PetFoodImages\rabbit1petfood.jfif', 130, 9)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (17, N'Premium Food', N'Lifes', N'Hay is the most important part of a rabbit''s daily intake. Unlimited, high-quality grass hay, such as timothy, orchard, or brome, should make up the bulk of a rabbit''s diet. Grass hay is high in fiber, which is critical to maintaining a rabbit''s healthy digestive tract.', N'\PetFoodImages\rabbitpet3food.jfif', 131, 6)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (18, N'Tetra Micro', N'Tetras', N'It may include detritus*, bacteria*, plankton* , worms, insects, snails, aquatic plants and fish. Their abundance greatly depends on water quality.', N'\PetFoodImages\tetrafoodimg.jfif', 132, 7)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (19, N'Turtle Food', N'Tainyo', N'Taiyo baby turtle food is a complete and balanced nutritional staple food for all turtles, other reptiles, and aquatic amphibians as well. It contains all.', N'\PetFoodImages\turtlefood.jfif', 133, 9)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (20, N'Whiskat', N'Turlo', N'Pick from a range of tantalizing wet cat food textures such as jelly, loaf, and gravy, or simply try our mouth-watering variety of dry cat food like salmon,', N'\PetFoodImages\whiskasfoodcat.webp', 134, 4)
INSERT [dbo].[TblPetFood] ([FoodId], [FoodName], [MfgName], [FoodDesc], [PhotoPath], [ProductId], [GoodFoodAccordingToPetAge]) VALUES (22, N'FruitMi', N'Jinova', N'Feed free choice and assure your bird always has fresh food and water.', N'\PetFoodImages\sparrowfood1.jpg', 142, 4)
SET IDENTITY_INSERT [dbo].[TblPetFood] OFF
SET IDENTITY_INSERT [dbo].[TblPetProduct] ON 

INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (3, N'Pet Hoodie', N'Royal', 96, N'The stylish designed dogs hoodie is made of high-quality cotton, inside is high quality velvet. Natural Cotton Fabric Material, Skin-Friendly, Breathable, Soft and elastic.', N'\PetImages\doghoodie.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (4, N'Pet Body Harness', N'PawsIndia', 97, N'Easy Adjustment: Put on and take off this product with 2 quick-release buckles with no hassle. 4 fully adjustable straps (2 Shoulder and 2 Chest) allow a snug fit with maximum mobility.', N'\PetImages\petbodyharness.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (5, N'Pet Sofa', N'Zigly', 98, N'Pet sofa is made of solid wood and plywood frame,filled with high density soft sponge and dall cotton,and covered with Red Velvet.', N'\PetImages\Petsofa.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (6, N'Conditioner', N'Pioneer', 99, N'Pet life Ultra moisturizing Hair Conditioner helps to loosen up those tangles and makes it easier to brush your pet.', N'\PetImages\petconditioner.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (7, N'Pet Oil', N'Monkoo', 100, N'Full spectrum Hemp Extract Pet oil is enriched with essential phytocannabinoids to assist with conditions such as anxiety and skin diseases.', N'\PetImages\petoil.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (8, N'Brushes', N'LoyaPetZone', 101, N'There are four primary types of dog brushes: slicker brushes, rakes, bristle, and pin brushes. Slicker brushes have fine, short wires close together on a flat surface.', N'\PetImages\petbrushes.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (9, N'Pet Tooth Brush', N'ChullBull', 102, N'Soft-bristled, gentle toothbrush. Designed specifically for dogs'' and cats'' mouths. Periodontal disease is no joke! Both professional dental care and daily at-home care are necessary and the benefits of professional dental care can be short-lived unless effective home care is implemented.', N'\PetImages\pettoothbrush.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (10, N'Seat Belt', N'TailsMart', 103, N'Our dog seat belts give peace of mind knowing your best friend is protected from sudden stops and swerves. Extra durable rip-stop nylon, a powerful elastic bungee cord, and a 360° rotating clasp provide safety for your pet''s neck and body with our dog car leash.', N'\PetImages\seatbelt.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (11, N'Pet Harness', N'Vetco', 104, N'A dog harness is a piece of equipment consisting in part of straps that surround the dog''s torso. It is used to guide, hold, and lift the dog or to utilise its pulling power. It reduces tension on the neck when they pull, and provides free breathing during daily walks.', N'\PetImages\petharness.png')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (12, N'Color Bells', N'Petpai Vetic', 105, N'If you have a puppy, these bells make it easier for you to keep track of them and work on housetraining. They add a splash of color and have a pleasant ring to them. Bells come in an assortment of swirled colors.', N'\PetImages\collerbells.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (13, N'Pet Masseger', N'Poodles', 106, N'The pre-event massage is an energizing massage that warms the muscles, increases flexibility and prepares the muscles for exercise. It is especially useful for helping to prevent injury. Post-event massage loosens up muscles, aides in removal of toxins (lactic acid) and facilitates a quicker recovery.', N'\PetImages\dogmasseger.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (14, N'Pet Litter', N'Oscar Daisy', 107, N'Cat litter comes in different materials and is increasingly being experimented upon, however, the five most common types of cat litter are clay (bentonite), tofu, silica, paper, and corn. Clay is the oldest form of cat litter. It comes in two varieties - clumping and non-clumping.', N'\PetImages\petmatbeaker.jpg')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (17, N'Fish Bowl', N'Keria', 111, N'A container that is usually round and made of glass and is used for keeping pet fish in', N'\PetImages\fishbowlpro.jfif')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (18, N'Fish Tank', N'Seria', 112, N'A glass-sided tank for keeping, displaying, or observing live fish or other aquatic animals.', N'\PetImages\fishtankpro.jfif')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (19, N'Bird Toy', N'Getta', 113, N'Bird toys are nothing but the simulator. Young Birds continuously play with these toys and this playtime forms the learning period in their life. Birds learn textures, colours and shapes.', N'\PetImages\birdpro2.jfif')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (20, N'BirdNet', N'Jiggy', 114, N'Bird netting is one of the most effective and long lasting ways of bird proofing buildings and other structures against all urban bird species. It provides a discreet and impenetrable barrier that protects premises without harming the birds.', N'\PetImages\birdpro3.jfif')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (21, N'Parrot House', N'kinara', 115, N'Other bird species that are suited to apartment living include finches, canaries, and parrotlets. Single-Family Homes Larger birds like cockatiels and parrots', N'\PetImages\parrotpro.jfif')
INSERT [dbo].[TblPetProduct] ([PetProductId], [ProductName], [MfgName], [ProductId], [ProductDesc], [PhotoPath]) VALUES (22, N'PetHome', N'Finosu', 141, N'Buy Pet Dog and Cat Products Online in India from PetHome. Express Free Shipping. Free COD. Brands available Like Vivaldis, Catalysis, Bioiberica, Orijen,', N'\PetImages\Pethomes.jpg')
SET IDENTITY_INSERT [dbo].[TblPetProduct] OFF
SET IDENTITY_INSERT [dbo].[TblPetType] ON 

INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (1, N'Cats')
INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (2, N'Dogs')
INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (3, N'Horse')
INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (4, N'Bird')
INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (5, N'Fish')
INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (6, N'Rabbit')
INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (8, N'Turtle')
INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (9, N'Parrot')
INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (10, N'Goat')
INSERT [dbo].[TblPetType] ([PetTypeId], [PetTypeName]) VALUES (11, N'Chiken')
SET IDENTITY_INSERT [dbo].[TblPetType] OFF
SET IDENTITY_INSERT [dbo].[TblProduct] ON 

INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (48, 1, CAST(10000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (50, 1, CAST(12000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (52, 1, CAST(15000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (54, 1, CAST(5000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (60, 1, CAST(3000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (62, 1, CAST(9000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (64, 1, CAST(5000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (68, 1, CAST(4500.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (70, 1, CAST(6900.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (72, 1, CAST(10000.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (82, 2, CAST(234.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (90, 1, CAST(11.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (96, 3, CAST(600.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (97, 3, CAST(1200.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (98, 3, CAST(3200.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (99, 3, CAST(440.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (100, 3, CAST(340.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (101, 3, CAST(550.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (102, 3, CAST(122.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (103, 3, CAST(670.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (104, 3, CAST(260.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (105, 3, CAST(345.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (106, 3, CAST(890.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (107, 3, CAST(900.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (111, 3, CAST(190.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (112, 3, CAST(490.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (113, 3, CAST(700.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (114, 3, CAST(467.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (115, 3, CAST(890.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (117, 2, CAST(900.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (118, 2, CAST(400.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (119, 2, CAST(490.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (120, 2, CAST(1200.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (121, 2, CAST(1500.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (122, 2, CAST(1700.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (123, 2, CAST(1300.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (124, 2, CAST(1780.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (126, 2, CAST(780.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (127, 2, CAST(1345.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (128, 2, CAST(1670.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (129, 2, CAST(850.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (130, 2, CAST(1690.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (131, 2, CAST(790.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (132, 2, CAST(645.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (133, 2, CAST(450.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (134, 2, CAST(1450.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (137, 1, CAST(7000.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (141, 3, CAST(1300.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[TblProduct] ([ProductId], [ProductType], [ProductPrice], [StoreId]) VALUES (142, 2, CAST(600.00 AS Decimal(18, 2)), 2)
SET IDENTITY_INSERT [dbo].[TblProduct] OFF
SET IDENTITY_INSERT [dbo].[TblProductReview] ON 

INSERT [dbo].[TblProductReview] ([ProductReviewId], [ProductId], [Rating], [UserId], [ReviewDesc]) VALUES (8, 50, 1, 1, N'It''s very Good Pet!')
INSERT [dbo].[TblProductReview] ([ProductReviewId], [ProductId], [Rating], [UserId], [ReviewDesc]) VALUES (9, 119, 2, 1, N'It'' a Good Food!')
INSERT [dbo].[TblProductReview] ([ProductReviewId], [ProductId], [Rating], [UserId], [ReviewDesc]) VALUES (10, 99, 3, 1, N'This is very nice Product!')
INSERT [dbo].[TblProductReview] ([ProductReviewId], [ProductId], [Rating], [UserId], [ReviewDesc]) VALUES (11, 68, 3, 2, N'Its a para very Intelligent!')
INSERT [dbo].[TblProductReview] ([ProductReviewId], [ProductId], [Rating], [UserId], [ReviewDesc]) VALUES (12, 128, 3, 2, N'Its nice Food!')
INSERT [dbo].[TblProductReview] ([ProductReviewId], [ProductId], [Rating], [UserId], [ReviewDesc]) VALUES (13, 103, 1, 2, N'its very comfortable belt for pets!')
SET IDENTITY_INSERT [dbo].[TblProductReview] OFF
SET IDENTITY_INSERT [dbo].[TblRefund] ON 

INSERT [dbo].[TblRefund] ([RefundId], [ReturnId], [RefundDate], [RefundAmount]) VALUES (1, 1, CAST(N'2024-05-17 20:16:27.7342577' AS DateTime2), CAST(440.00 AS Decimal(18, 2)))
INSERT [dbo].[TblRefund] ([RefundId], [ReturnId], [RefundDate], [RefundAmount]) VALUES (2, 3, CAST(N'2024-05-18 13:41:25.4864443' AS DateTime2), CAST(12000.00 AS Decimal(18, 2)))
INSERT [dbo].[TblRefund] ([RefundId], [ReturnId], [RefundDate], [RefundAmount]) VALUES (3, 5, CAST(N'2024-05-18 13:53:44.0855876' AS DateTime2), CAST(600.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[TblRefund] OFF
SET IDENTITY_INSERT [dbo].[TblReturn] ON 

INSERT [dbo].[TblReturn] ([ReturnId], [ProductId], [OrderId], [ReturnDate], [ReturnReason]) VALUES (1, 99, 8, CAST(N'2024-05-15 19:36:00.0000000' AS DateTime2), N'This Conditioner Smale Not Good Thats The Reason We Want To Return This Product!')
INSERT [dbo].[TblReturn] ([ReturnId], [ProductId], [OrderId], [ReturnDate], [ReturnReason]) VALUES (3, 50, 8, CAST(N'2024-05-18 13:10:00.0000000' AS DateTime2), N'Tiger is So unhealthy!')
INSERT [dbo].[TblReturn] ([ReturnId], [ProductId], [OrderId], [ReturnDate], [ReturnReason]) VALUES (4, 70, 3, CAST(N'2024-05-18 13:14:00.0000000' AS DateTime2), N'Return Goat')
INSERT [dbo].[TblReturn] ([ReturnId], [ProductId], [OrderId], [ReturnDate], [ReturnReason]) VALUES (5, 142, 9, CAST(N'2024-05-18 13:51:00.0000000' AS DateTime2), N'This FruitMi is so tasteless!')
SET IDENTITY_INSERT [dbo].[TblReturn] OFF
SET IDENTITY_INSERT [dbo].[TblSolution] ON 

INSERT [dbo].[TblSolution] ([SolutionId], [SolutionDate], [SolutionDesc], [ComplaintId]) VALUES (2, CAST(N'2024-05-15 16:39:00.0000000' AS DateTime2), N'We will work on your complaint . Give us some time.', 7)
INSERT [dbo].[TblSolution] ([SolutionId], [SolutionDate], [SolutionDesc], [ComplaintId]) VALUES (3, CAST(N'2024-05-17 17:34:00.0000000' AS DateTime2), N'OKay ,We Understand Your Problem And we will provide you new conditioner.', 8)
INSERT [dbo].[TblSolution] ([SolutionId], [SolutionDate], [SolutionDesc], [ComplaintId]) VALUES (4, CAST(N'2024-05-18 13:36:00.0000000' AS DateTime2), N'we will check and work on it.', 12)
SET IDENTITY_INSERT [dbo].[TblSolution] OFF
SET IDENTITY_INSERT [dbo].[TblState] ON 

INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (12, N'Maharashtra', 5)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (13, N'Punjab', 5)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (15, N'Assam', 5)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (16, N'Gujarat', 5)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (17, N'Kerala', 5)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (18, N'California', 1)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (19, N'Texas', 1)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (20, N'New Jersey', 1)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (21, N'New York', 1)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (22, N'South Carolina', 1)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (25, N'Queensland', 2)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (26, N'South Wales', 2)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (27, N'Victoria', 2)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (28, N'Tasmania', 2)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (29, N'South Australia', 2)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (30, N'Musandam', 8)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (31, N'AI Buraimi', 8)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (32, N'AI Batinah North', 8)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (33, N'Muscat', 8)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (34, N'Dhofar', 8)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (35, N'Anhui', 11)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (36, N'Fujain', 11)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (37, N'Gansu', 11)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (38, N'Jilin', 11)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (39, N'Gaungdong', 11)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (40, N'Lombardia', 13)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (41, N'Lazio', 13)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (42, N'Marche', 13)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (43, N'Puglia', 13)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (44, N'Veneto', 13)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (45, N'Heraklion', 19)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (46, N'Athens', 19)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (47, N'Boeotia', 19)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (48, N'Euboea', 19)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (49, N'Aetolia', 19)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (50, N'Wellington', 20)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (51, N'Auckland', 20)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (52, N'Otago', 20)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (53, N'Nelson', 20)
INSERT [dbo].[TblState] ([StateId], [StateName], [CountryId]) VALUES (54, N'Taranaki', 20)
SET IDENTITY_INSERT [dbo].[TblState] OFF
SET IDENTITY_INSERT [dbo].[TblStore] ON 

INSERT [dbo].[TblStore] ([StoreId], [StoreName], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [Password], [CityId], [IsActive]) VALUES (1, N'PetStore', N'Sweety', N'Chaure', N'Pune', N'1122334455', N'sweety@gmail.com', N'1234', 126, 0)
INSERT [dbo].[TblStore] ([StoreId], [StoreName], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [Password], [CityId], [IsActive]) VALUES (2, N'SkyPetShop', N'Guddi', N'Chaure', N'Pune', N'1234567890', N'guddi@gmail.com', N'1234', 10, 0)
INSERT [dbo].[TblStore] ([StoreId], [StoreName], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [Password], [CityId], [IsActive]) VALUES (3, N'GoldenPetShop', N'Tejas', N'Chaure', N'Khadki', N'1111111111', N'tejas@gmail.com', N'1234', 5, 0)
INSERT [dbo].[TblStore] ([StoreId], [StoreName], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [Password], [CityId], [IsActive]) VALUES (7, N'JubliePet', N'Disha', N'Jawale', N'Pune', N'1234567890', N'disha@gmail.com', N'1234', 8, 0)
INSERT [dbo].[TblStore] ([StoreId], [StoreName], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [Password], [CityId], [IsActive]) VALUES (8, N'ghfh', N'dfd', N'fdfgf', N'fghgfhg', N'4546512342', N'sweety@gmail.com', N'123', 52, 0)
SET IDENTITY_INSERT [dbo].[TblStore] OFF
SET IDENTITY_INSERT [dbo].[TblStoreReview] ON 

INSERT [dbo].[TblStoreReview] ([StoreReviewId], [Review], [StoreId], [Rating], [UserId]) VALUES (1, N'Good Store!', 1, 1, 1)
INSERT [dbo].[TblStoreReview] ([StoreReviewId], [Review], [StoreId], [Rating], [UserId]) VALUES (2, N'nice store', 1, 3, 1)
INSERT [dbo].[TblStoreReview] ([StoreReviewId], [Review], [StoreId], [Rating], [UserId]) VALUES (3, N'good', 1, 2, 1)
INSERT [dbo].[TblStoreReview] ([StoreReviewId], [Review], [StoreId], [Rating], [UserId]) VALUES (4, N'Good store', 2, 3, 1)
INSERT [dbo].[TblStoreReview] ([StoreReviewId], [Review], [StoreId], [Rating], [UserId]) VALUES (5, N'here all products Are Available!', 1, 1, 2)
SET IDENTITY_INSERT [dbo].[TblStoreReview] OFF
SET IDENTITY_INSERT [dbo].[TblTax] ON 

INSERT [dbo].[TblTax] ([TaxId], [TaxPercentage], [HSNSACNo]) VALUES (8, CAST(18.00 AS Decimal(18, 2)), N'1234')
SET IDENTITY_INSERT [dbo].[TblTax] OFF
SET IDENTITY_INSERT [dbo].[TblUser] ON 

INSERT [dbo].[TblUser] ([UserId], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [Password], [IsActive], [Gender], [DateOfBirth], [CityId]) VALUES (1, N'Sonali', N'Chavan', N'Nigadi', N'9885257441', N'sonali@gmail.com', N'123', 0, 2, CAST(N'2024-05-01 18:54:00.0000000' AS DateTime2), 8)
INSERT [dbo].[TblUser] ([UserId], [FirstName], [LastName], [Address], [MobileNo], [EmailId], [Password], [IsActive], [Gender], [DateOfBirth], [CityId]) VALUES (2, N'Sita', N'Kale', N'Pune', N'1111122222', N'sita@gmail.com', N'1234', 0, 2, CAST(N'2021-02-18 19:28:00.0000000' AS DateTime2), 34)
SET IDENTITY_INSERT [dbo].[TblUser] OFF
ALTER TABLE [dbo].[TblCart]  WITH CHECK ADD  CONSTRAINT [FK_TblCart_TblOrderTax_OrderTaxId] FOREIGN KEY([OrderTaxId])
REFERENCES [dbo].[TblOrderTax] ([OrderTaxId])
GO
ALTER TABLE [dbo].[TblCart] CHECK CONSTRAINT [FK_TblCart_TblOrderTax_OrderTaxId]
GO
ALTER TABLE [dbo].[TblCart]  WITH CHECK ADD  CONSTRAINT [FK_TblCart_TblProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TblProduct] ([ProductId])
GO
ALTER TABLE [dbo].[TblCart] CHECK CONSTRAINT [FK_TblCart_TblProduct_ProductId]
GO
ALTER TABLE [dbo].[TblCart]  WITH CHECK ADD  CONSTRAINT [FK_TblCart_TblStore_StoreId] FOREIGN KEY([StoreId])
REFERENCES [dbo].[TblStore] ([StoreId])
GO
ALTER TABLE [dbo].[TblCart] CHECK CONSTRAINT [FK_TblCart_TblStore_StoreId]
GO
ALTER TABLE [dbo].[TblCart]  WITH CHECK ADD  CONSTRAINT [FK_TblCart_TblUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[TblUser] ([UserId])
GO
ALTER TABLE [dbo].[TblCart] CHECK CONSTRAINT [FK_TblCart_TblUser_UserId]
GO
ALTER TABLE [dbo].[TblCity]  WITH CHECK ADD  CONSTRAINT [FK_TblCity_TblState_StateId] FOREIGN KEY([StateId])
REFERENCES [dbo].[TblState] ([StateId])
GO
ALTER TABLE [dbo].[TblCity] CHECK CONSTRAINT [FK_TblCity_TblState_StateId]
GO
ALTER TABLE [dbo].[TblComplaint]  WITH CHECK ADD  CONSTRAINT [FK_TblComplaint_TblOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TblOrder] ([OrderId])
GO
ALTER TABLE [dbo].[TblComplaint] CHECK CONSTRAINT [FK_TblComplaint_TblOrder_OrderId]
GO
ALTER TABLE [dbo].[TblComplaint]  WITH CHECK ADD  CONSTRAINT [FK_TblComplaint_TblProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TblProduct] ([ProductId])
GO
ALTER TABLE [dbo].[TblComplaint] CHECK CONSTRAINT [FK_TblComplaint_TblProduct_ProductId]
GO
ALTER TABLE [dbo].[TblDispatchOrder]  WITH CHECK ADD  CONSTRAINT [FK_TblDispatchOrder_TblDispatchAgency_DispatchAgencyId] FOREIGN KEY([DispatchAgencyId])
REFERENCES [dbo].[TblDispatchAgency] ([DispatchAgencyId])
GO
ALTER TABLE [dbo].[TblDispatchOrder] CHECK CONSTRAINT [FK_TblDispatchOrder_TblDispatchAgency_DispatchAgencyId]
GO
ALTER TABLE [dbo].[TblDispatchOrder]  WITH CHECK ADD  CONSTRAINT [FK_TblDispatchOrder_TblOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TblOrder] ([OrderId])
GO
ALTER TABLE [dbo].[TblDispatchOrder] CHECK CONSTRAINT [FK_TblDispatchOrder_TblOrder_OrderId]
GO
ALTER TABLE [dbo].[TblOffer]  WITH CHECK ADD  CONSTRAINT [FK_TblOffer_TblStore_StoreId] FOREIGN KEY([StoreId])
REFERENCES [dbo].[TblStore] ([StoreId])
GO
ALTER TABLE [dbo].[TblOffer] CHECK CONSTRAINT [FK_TblOffer_TblStore_StoreId]
GO
ALTER TABLE [dbo].[TblOrder]  WITH CHECK ADD  CONSTRAINT [FK_TblOrder_TblStore_StoreId] FOREIGN KEY([StoreId])
REFERENCES [dbo].[TblStore] ([StoreId])
GO
ALTER TABLE [dbo].[TblOrder] CHECK CONSTRAINT [FK_TblOrder_TblStore_StoreId]
GO
ALTER TABLE [dbo].[TblOrder]  WITH CHECK ADD  CONSTRAINT [FK_TblOrder_TblUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[TblUser] ([UserId])
GO
ALTER TABLE [dbo].[TblOrder] CHECK CONSTRAINT [FK_TblOrder_TblUser_UserId]
GO
ALTER TABLE [dbo].[TblOrderDet]  WITH CHECK ADD  CONSTRAINT [FK_TblOrderDet_TblOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TblOrder] ([OrderId])
GO
ALTER TABLE [dbo].[TblOrderDet] CHECK CONSTRAINT [FK_TblOrderDet_TblOrder_OrderId]
GO
ALTER TABLE [dbo].[TblOrderDet]  WITH CHECK ADD  CONSTRAINT [FK_TblOrderDet_TblProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TblProduct] ([ProductId])
GO
ALTER TABLE [dbo].[TblOrderDet] CHECK CONSTRAINT [FK_TblOrderDet_TblProduct_ProductId]
GO
ALTER TABLE [dbo].[TblOrderTax]  WITH CHECK ADD  CONSTRAINT [FK_TblOrderTax_TblOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TblOrder] ([OrderId])
GO
ALTER TABLE [dbo].[TblOrderTax] CHECK CONSTRAINT [FK_TblOrderTax_TblOrder_OrderId]
GO
ALTER TABLE [dbo].[TblOrderTax]  WITH CHECK ADD  CONSTRAINT [FK_TblOrderTax_TblTax_TaxId] FOREIGN KEY([TaxId])
REFERENCES [dbo].[TblTax] ([TaxId])
GO
ALTER TABLE [dbo].[TblOrderTax] CHECK CONSTRAINT [FK_TblOrderTax_TblTax_TaxId]
GO
ALTER TABLE [dbo].[TblPayment]  WITH CHECK ADD  CONSTRAINT [FK_TblPayment_TblOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TblOrder] ([OrderId])
GO
ALTER TABLE [dbo].[TblPayment] CHECK CONSTRAINT [FK_TblPayment_TblOrder_OrderId]
GO
ALTER TABLE [dbo].[TblPet]  WITH CHECK ADD  CONSTRAINT [FK_TblPet_TblPetFamily_PetFamilyId] FOREIGN KEY([PetFamilyId])
REFERENCES [dbo].[TblPetFamily] ([PetFamilyId])
GO
ALTER TABLE [dbo].[TblPet] CHECK CONSTRAINT [FK_TblPet_TblPetFamily_PetFamilyId]
GO
ALTER TABLE [dbo].[TblPet]  WITH CHECK ADD  CONSTRAINT [FK_TblPet_TblPetType_PetTypeId] FOREIGN KEY([PetTypeId])
REFERENCES [dbo].[TblPetType] ([PetTypeId])
GO
ALTER TABLE [dbo].[TblPet] CHECK CONSTRAINT [FK_TblPet_TblPetType_PetTypeId]
GO
ALTER TABLE [dbo].[TblPet]  WITH CHECK ADD  CONSTRAINT [FK_TblPet_TblProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TblProduct] ([ProductId])
GO
ALTER TABLE [dbo].[TblPet] CHECK CONSTRAINT [FK_TblPet_TblProduct_ProductId]
GO
ALTER TABLE [dbo].[TblPetFood]  WITH CHECK ADD  CONSTRAINT [FK_TblPetFood_TblProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TblProduct] ([ProductId])
GO
ALTER TABLE [dbo].[TblPetFood] CHECK CONSTRAINT [FK_TblPetFood_TblProduct_ProductId]
GO
ALTER TABLE [dbo].[TblPetPhotos]  WITH CHECK ADD  CONSTRAINT [FK_TblPetPhotos_TblPet_PetId] FOREIGN KEY([PetId])
REFERENCES [dbo].[TblPet] ([PetId])
GO
ALTER TABLE [dbo].[TblPetPhotos] CHECK CONSTRAINT [FK_TblPetPhotos_TblPet_PetId]
GO
ALTER TABLE [dbo].[TblPetProduct]  WITH CHECK ADD  CONSTRAINT [FK_TblPetProduct_TblProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TblProduct] ([ProductId])
GO
ALTER TABLE [dbo].[TblPetProduct] CHECK CONSTRAINT [FK_TblPetProduct_TblProduct_ProductId]
GO
ALTER TABLE [dbo].[TblProduct]  WITH CHECK ADD  CONSTRAINT [FK_TblProduct_TblStore_StoreId] FOREIGN KEY([StoreId])
REFERENCES [dbo].[TblStore] ([StoreId])
GO
ALTER TABLE [dbo].[TblProduct] CHECK CONSTRAINT [FK_TblProduct_TblStore_StoreId]
GO
ALTER TABLE [dbo].[TblProductReview]  WITH CHECK ADD  CONSTRAINT [FK_TblProductReview_TblProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TblProduct] ([ProductId])
GO
ALTER TABLE [dbo].[TblProductReview] CHECK CONSTRAINT [FK_TblProductReview_TblProduct_ProductId]
GO
ALTER TABLE [dbo].[TblProductReview]  WITH CHECK ADD  CONSTRAINT [FK_TblProductReview_TblUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[TblUser] ([UserId])
GO
ALTER TABLE [dbo].[TblProductReview] CHECK CONSTRAINT [FK_TblProductReview_TblUser_UserId]
GO
ALTER TABLE [dbo].[TblRefund]  WITH CHECK ADD  CONSTRAINT [FK_TblRefund_TblReturn_ReturnId] FOREIGN KEY([ReturnId])
REFERENCES [dbo].[TblReturn] ([ReturnId])
GO
ALTER TABLE [dbo].[TblRefund] CHECK CONSTRAINT [FK_TblRefund_TblReturn_ReturnId]
GO
ALTER TABLE [dbo].[TblReturn]  WITH CHECK ADD  CONSTRAINT [FK_TblReturn_TblOrder_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TblOrder] ([OrderId])
GO
ALTER TABLE [dbo].[TblReturn] CHECK CONSTRAINT [FK_TblReturn_TblOrder_OrderId]
GO
ALTER TABLE [dbo].[TblReturn]  WITH CHECK ADD  CONSTRAINT [FK_TblReturn_TblProduct_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TblProduct] ([ProductId])
GO
ALTER TABLE [dbo].[TblReturn] CHECK CONSTRAINT [FK_TblReturn_TblProduct_ProductId]
GO
ALTER TABLE [dbo].[TblSolution]  WITH CHECK ADD  CONSTRAINT [FK_TblSolution_TblComplaint_ComplaintId] FOREIGN KEY([ComplaintId])
REFERENCES [dbo].[TblComplaint] ([ComplaintId])
GO
ALTER TABLE [dbo].[TblSolution] CHECK CONSTRAINT [FK_TblSolution_TblComplaint_ComplaintId]
GO
ALTER TABLE [dbo].[TblState]  WITH CHECK ADD  CONSTRAINT [FK_TblState_TblCountry_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[TblCountry] ([CountryId])
GO
ALTER TABLE [dbo].[TblState] CHECK CONSTRAINT [FK_TblState_TblCountry_CountryId]
GO
ALTER TABLE [dbo].[TblStore]  WITH CHECK ADD  CONSTRAINT [FK_TblStore_TblCity_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[TblCity] ([CityId])
GO
ALTER TABLE [dbo].[TblStore] CHECK CONSTRAINT [FK_TblStore_TblCity_CityId]
GO
ALTER TABLE [dbo].[TblStoreReview]  WITH CHECK ADD  CONSTRAINT [FK_TblStoreReview_TblStore_StoreId] FOREIGN KEY([StoreId])
REFERENCES [dbo].[TblStore] ([StoreId])
GO
ALTER TABLE [dbo].[TblStoreReview] CHECK CONSTRAINT [FK_TblStoreReview_TblStore_StoreId]
GO
ALTER TABLE [dbo].[TblStoreReview]  WITH CHECK ADD  CONSTRAINT [FK_TblStoreReview_TblUser_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[TblUser] ([UserId])
GO
ALTER TABLE [dbo].[TblStoreReview] CHECK CONSTRAINT [FK_TblStoreReview_TblUser_UserId]
GO
ALTER TABLE [dbo].[TblUser]  WITH CHECK ADD  CONSTRAINT [FK_TblUser_TblCity_CityId] FOREIGN KEY([CityId])
REFERENCES [dbo].[TblCity] ([CityId])
GO
ALTER TABLE [dbo].[TblUser] CHECK CONSTRAINT [FK_TblUser_TblCity_CityId]
GO
