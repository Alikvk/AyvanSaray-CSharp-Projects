USE [Northwind]
GO
/****** Object:  StoredProcedure [dbo].[insertCategory]    Script Date: 29.01.2019 13:47:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[insertCategory]
 @catName nvarchar(15),
 @catDesc ntext
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;
	INSERT INTO Categories (CategoryName,Description) VALUES (@catName,@catDesc)
END
