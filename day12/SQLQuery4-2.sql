USE Market
GO

create table userInfo
(
UserID INT PRIMARY KEY IDENTITY(10,1) NOT NULL,
UserName varchar(50) NOT NULL,
UserPassword VARCHAR(100) NOT NULL,
UserAge TINYINT,
UserEmail VARCHAR(30),
UserMobile VARCHAR(10),
CreateDate DATETIME,
LastLogin   DATETIME,
LastErrDateTime DATETIME,
DelFlag TINYINT DEFAULT 0,



)

INSERT [dbo].[userInfo]
( 
    [UserName], 
	[UserPassword], 
	[UserAge], 
	[UserEmail], 
	[UserMobile], 
	[CreateDate], 
	[LastLogin], 
	[LastErrDateTime], 
	[DelFlag]
)
VALUES 
('Alice', '123456', 23, '', '', '', '', '', 0);
INSERT [dbo].[userInfo]([UserName], [UserPassword], [UserAge], [UserEmail], [UserMobile], [CreateDate], [LastLogin], [LastErrDateTime], [DelFlag])VALUES('Alice', '123456', 23, '', '', '', '', '', 0);