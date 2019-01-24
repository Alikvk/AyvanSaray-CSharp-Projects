USE [Northwind]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		AL� KAVAK
-- Create date: 23.01.2019
-- Description:	Silme i�lemi �al��t�r�ld���nda o i�lem i�in Update komutunu �al��t�racak tetikleyici
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
