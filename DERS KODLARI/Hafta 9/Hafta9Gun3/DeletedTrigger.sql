USE [Northwind]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		ALÝ KAVAK
-- Create date: 23.01.2019
-- Description:	Silme iþlemi çalýþtýrýldýðýnda o iþlem için Update komutunu çalýþtýracak tetikleyici
-- =============================================
CREATE TRIGGER [dbo].[DeleteProducts]
		ON [dbo].[Products]
		INSTEAD OF DELETE
AS 
BEGIN
	 Update Products SET Discontinued = 1 WHERE ProductID
						in (SELECT ProductID From Deleted)
END
GO
