CREATE TABLE [dbo].[Whse]
(
	[WhId] INT IDENTITY (1, 1) NOT NULL,
	[WhName] NVARCHAR(50) NULL,
	[CreatedBy] int null,
	[CreatedOn] datetime null,
	[UpdatedBy] int null,
	[UpdatedOn] datetime null,
)
