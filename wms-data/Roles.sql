CREATE TABLE [dbo].[Roles]
(
	[RoleId] INT IDENTITY (1, 1) NOT NULL,
	RoleName NVARCHAR(50) NULL, 
	[CreatedBy] int null,
	[CreatedOn] datetime null,
	[UpdatedBy] int null,
	[UpdatedOn] datetime null,
)
