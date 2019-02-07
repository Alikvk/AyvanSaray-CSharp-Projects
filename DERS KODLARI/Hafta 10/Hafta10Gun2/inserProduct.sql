USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[insertProduct]    Script Date: 29.01.2019 14:24:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[insertProduct]
 @prodName nvarchar(40),
 @unitPrice money,
 @unitsInStock smallint,
 @CategoryID int,
 @SupplierID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;
	INSERT INTO Products(ProductName,UnitPrice,UnitsInStock,CategoryID,SupplierID) VALUES (@prodName,@unitPrice,@unitsInStock,@CategoryID,@SupplierID)
END
