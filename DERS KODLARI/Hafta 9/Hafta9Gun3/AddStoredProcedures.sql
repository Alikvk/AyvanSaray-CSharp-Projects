-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
Use [Northwind]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Ali KAVAK
-- Create date: 23.01.2019
-- Description:	ADO.net için yazýlacak Stored Procudeures
-- =============================================
CREATE PROCEDURE [dbo].[AddProduct]
	-- Add the parameters for the stored procedure here
	@productName nvarchar(50),
	@UnitPrice money,
	@UnitsInStock smallint
AS
DECLARE @trimli nvarchar=ltrim(rtrim(@productName))
BEGIN
	if(exists(SELECT * from Products WHERE ProductName=@trimli))
		print 'This product is already attached'
	else
		BEGIN
			INSERT INTO Products(ProductName,UnitPrice,UnitsInStock) 
			VALUES (@productName,@UnitPrice,@UnitsInStock)
		END
END
GO
