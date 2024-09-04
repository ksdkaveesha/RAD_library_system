CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Title] VARCHAR(50) NOT NULL, 
    [ISBN] INT NULL, 
    [Genre] VARCHAR(50) NOT NULL, 
    [AvailableCopies] INT NOT NULL
)
