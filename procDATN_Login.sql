go
create proc [dbo].[GetUserByUserName_Pass](
@UserName varchar(50),
@Pass varchar(100)
)
as
begin
	select * from [System_User]
	where UserName=@UserName and Pass=@Pass
end

go
create proc [dbo].[GetStatusByUserId](
@UserId int
)
as
begin
	select Status from [System_User]
	where Id=@UserId and ISNULL(IsDeleted,0)=0
end
go
create proc [dbo].[GetInfoByUserId](
@UserId int
)
as
begin
	select * from [System_User]
	where Id=@UserId and ISNULL(IsDeleted,0)=0
end
go
create proc [dbo].[CheckUserId](
@UserId int
)
as 
begin
	select * from [System_Decentralization]
	where UserId=@UserId and ISNULL(IsDeleted,0)=0
end