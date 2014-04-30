CREATE TABLE [dbo].[PartMaster]
(
	[PartId] INT IDENTITY (1, 1) NOT NULL,
	[PartNumber] NVARCHAR(50) NULL,
	[PartDesc] NVARCHAR(MAX) NULL,
	[PartFamily] NVARCHAR(50) NULL,
	[PartType] int null,
	[PartRev] NVARCHAR(50) NULL,
	[CreatedBy] int null,
	[CreatedOn] datetime null,
	[UpdatedBy] int null,
	[UpdatedOn] datetime null
)
