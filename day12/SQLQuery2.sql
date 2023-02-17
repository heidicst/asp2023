/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [customerID]
      ,[customerContact]
      ,[customerCity]
      ,[customerBirthDay]
  FROM [Market].[dbo].[customers]