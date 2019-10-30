# MagentoApiConnect
Desktop application to get order detail from Magento 2 API. 
This project was build for Indian client to fetch magento order from Magento API and perform local tax calculation and
to prepare the import file format for Tally accounting software.

<br>
<img src="https://github.com/rddewan/MagentoApiConnect/blob/master/MagentoApp/Images/1.png" width="700" height="500">
<br>
<img src="https://github.com/rddewan/MagentoApiConnect/blob/master/MagentoApp/Images/2.png" width="700" height="500">
<br>
<img src="https://github.com/rddewan/MagentoApiConnect/blob/master/MagentoApp/Images/3.png" width="700" height="500">
<br>
<img src="https://github.com/rddewan/MagentoApiConnect/blob/master/MagentoApp/Images/4.png" width="700" height="500">

<br>
1. Create a folder C:\MagentoSetting and create a config file setting.config
<br>
2. Create a folder C:\MagentoSetting\ItemMaster and place your ItemMaster excel file. This file is used to get item tax.
<br>
3.If you want to print the order you need to save the record to Database before you can print.
Create a database table use below query
<br>

USE [MagentoAPIConnect]
GO

/****** Object:  Table [dbo].[M2SalesOrder]    Script Date: 30/10/2019 10:11:34 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[M2SalesOrder](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[BillNo] [varchar](50) NULL,
	[BillDate] [datetime] NULL,
	[VoucherType] [varchar](50) NULL,
	[Godown] [varchar](50) NULL,
	[CustomerName] [varchar](250) NULL,
	[Address1] [text] NULL,
	[Address2] [text] NULL,
	[Address3] [text] NULL,
	[Address4] [text] NULL,
	[Country] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[GSTRegistrationType] [varchar](50) NULL,
	[GSTNo] [varchar](50) NULL,
	[SalesLedger] [varchar](50) NULL,
	[ProductName] [varchar](250) NULL,
	[SKU] [varchar](50) NULL,
	[BatchNo] [varchar](50) NULL,
	[TaxRate] [varchar](20) NULL,
	[ManufacturingDate] [datetime] NULL,
	[ExpiryDate] [datetime] NULL,
	[Quantity] [smallint] NULL,
	[Unit] [varchar](50) NULL,
	[RateInclusiveOfTax] [money] NULL,
	[RateBasic] [money] NULL,
	[DiscPercent] [varchar](50) NULL,
	[Amount] [money] NULL,
	[DeliveryCharges] [money] NULL,
	[CGST] [money] NULL,
	[SGST] [money] NULL,
	[IGST] [money] NULL,
	[RoundOff] [money] NULL,
	[TotalAmount] [money] NULL,
	[CreditDebitCardLedgerName] [varchar](250) NULL,
	[CashLedgerName] [varchar](250) NULL,
	[Narration] [varchar](250) NULL,
	[HSN] [varchar](50) NULL,
 CONSTRAINT [PK_M2SalesOrder] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO
<br>
4. Change the connection string detain in connection.config file



