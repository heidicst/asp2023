/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [UserID]
      ,[UserName]
      ,[UserPassword]
      ,[UserAge]
      ,[UserEmail]
      ,[UserMobile]
      ,[CreateDate]
      ,[LastLogin]
      ,[LastErrDateTime]
      ,[DelFlag]
  FROM [Market].[dbo].[userInfo]