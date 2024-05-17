SET IDENTITY_INSERT [dbo].[Categories] ON;

INSERT INTO [dbo].[Categories] ([CategoryID], [Name], [ImageUrl]) 
VALUES (1, 'Sand', 'wwwroot/images/sand.jpg'),
       (2, 'Sten', 'wwwroot/images/sten.jpg'),
       (3, 'Grus', 'wwwroot/images/grus.jpg');

SET IDENTITY_INSERT [dbo].[Categories] OFF;
