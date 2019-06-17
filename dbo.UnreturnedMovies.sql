CREATE TABLE [dbo].[UnreturnedMovies]
(
	[UMID] INT NOT NULL PRIMARY KEY, 
    [MovieIDFK] INT NULL, 
    [CustIDFK] INT NULL, 
    [DateRented] NVARCHAR(50) NULL
	CONSTRAINT [PK_UnreturnedMovies] PRIMARY KEY CLUSTERED ([UMID] ASC),
    CONSTRAINT [FK_UnreturnedMovies_Customer] FOREIGN KEY ([CustIDFK]) REFERENCES [dbo].[Customer] ([CustID]),
    CONSTRAINT [FK_UnreturnedMovies_Movies] FOREIGN KEY ([MovieIDFK]) REFERENCES [dbo].[Movies] ([MovieID])
)