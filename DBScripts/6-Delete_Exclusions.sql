USE [DiscountPricing]
GO
/****** Object:  StoredProcedure [dbo].[prcDelExclusions]    Script Date: 9/8/2020 12:04:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[prcDelExclusions] 
@strDrugNDC		VARCHAR(15),
@strContractCode	VARCHAR(50)
AS
BEGIN
	DELETE FROM tblExclusions WHERE strDrugNDC = @strDrugNDC AND strContractCode = @strContractCode
END
