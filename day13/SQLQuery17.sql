USE Market
GO

declare @i INT
SET @i=10
WHILE @i<50
BEGIN
insert into [dbo].[userInfo]( [UserName], [UserPassword], [UserAge], [UserEmail], [UserMobile], [CreateDate], [LastErrDateTime])
values ('Jerry'+CAST(@i AS varchar),'123.com',29,'','',getdate(),getdate());

set @i=@i+1

print @i


END