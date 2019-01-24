USE [Northwind]
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteProduct]
	@productID int
AS
BEGIN
	DELETE FROM Products WHERE ProductID=@productID
END
GO