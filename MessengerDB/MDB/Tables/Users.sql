CREATE TABLE [MDB].[Users]
(
	[Id] uniqueidentifier NOT NULL PRIMARY KEY,
    [Login] NVARCHAR(128) NOT NULL,
    [Password] NCHAR(128) NOT NULL,
    [Name] NVARCHAR(128) NOT NULL,
)