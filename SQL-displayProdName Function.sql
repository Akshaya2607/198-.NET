-- ================================================
-- Template generated from Template Explorer using:
-- Create Scalar Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION fn_getProductName 
(
	-- Add the parameters for the function here
	@p_prodid int
)
RETURNS nvarchar(40)
AS
BEGIN
	-- Declare the return variable here
	DECLARE @v_prodname nvarchar(40)

	-- Add the T-SQL statements to compute the return value here
	SELECT @v_prodname=ProductName from Products where ProductID=@p_prodid

	-- Return the result of the function
	RETURN @v_prodname

END
GO

