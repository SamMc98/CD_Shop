USE [p2536632]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblOrderProcessing_SelectAll]

SELECT	@return_value as 'Return Value'

GO
