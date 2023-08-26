USE [NLH]
GO
/****** Object:  StoredProcedure [dbo].[usp_BedsSetFree]    Script Date: 2022-12-12 9:53:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[usp_BedsSetFree]
@BedNumber nvarchar(3)
AS
BEGIN TRANSACTION
UPDATE Beds 
SET Occupied = 0
WHERE BedNumber = @BedNumber
COMMIT