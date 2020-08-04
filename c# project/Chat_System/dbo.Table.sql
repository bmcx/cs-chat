CREATE TABLE [dbo].[Table]
(
	[FirstName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NULL, 
    [Repassword] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Email]) 
)
