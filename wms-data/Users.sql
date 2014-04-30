CREATE TABLE [dbo].[Users]
(
	[UserId]   INT            IDENTITY (1, 1) NOT NULL,
    [UserName] NVARCHAR (50) NOT NULL,
    [Email] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Phone] NVARCHAR(30) NULL, 
	[Address] NVARCHAR(200) NULL, 
	[TimeZone] NVARCHAR(200) NULL, 
    [ActiveFlag] BIT NULL, 
    [DeleteFlage] BIT NULL, 
	[CreatedBy] int null,
	[CreatedOn] datetime null,
	[UpdatedBy] int null,
	[UpdatedOn] datetime null,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
)
