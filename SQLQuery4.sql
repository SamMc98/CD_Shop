USE [p2536632]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_StaffManagement_FilterByStaffID]
		@StaffID = NULL

SELECT	@return_value as 'Return Value'

GO
