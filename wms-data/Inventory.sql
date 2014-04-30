CREATE TABLE [dbo].[Inventory]
(
	[InventoryId] INT IDENTITY (1, 1) NOT NULL,
	[PartNumber] NVARCHAR(50) NULL,
	[PartRev] NVARCHAR(50) NULL,
	[Qty] int null,
	[UnitCost] decimal(18,2) null,
	[UOM] int null,
	[SKU] int null,
)
