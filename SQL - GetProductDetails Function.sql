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
CREATE FUNCTION fn_getProductDetails
(
	-- Add the parameters for the function here
	@p_prodid int
)
RETURNS table
AS

	return (
	-- Declare the return variable here
	-- Add the T-SQL statements to compute the return value here
	SELECT productid,productname,unitprice,categoryid,supplierid from Products where ProductID=@p_prodid

	-- Return the result of the function
	 
	)

GO

