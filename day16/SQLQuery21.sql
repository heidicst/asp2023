USE Market
GO
--Select * from dbo.userinfo where DelFlag=0
--delete from dbo.userinfo where UserID=20
UPDATE dbo.userInfo SET DelFlag=1 WHERE UserID=17