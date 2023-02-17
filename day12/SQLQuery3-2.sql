--ALTER TABLE [dbo].[customers] ALTER COLUMN [customerBirthDay] DATETIME
--ALTER TABLE [dbo].[customers] ADD customerName varchar(50)
--ALTER TABLE [dbo].[customers] DROP COLUMN customerName
USE Market
GO

--ALTER TABLE [dbo].[customers] DROP COLUMN customerName
ALTER TABLE [dbo].[customers] ADD customerName VARCHAR(100)

ALTER TABLE [dbo].[customers]ALTER COLUMN customerBirthDay DATE