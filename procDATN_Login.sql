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

----------------------------------thêm proc-------------------------
go
create proc User_SelectAll
as
begin
	select * from [System_User]
	where ISNULL(IsDeleted,0)=0
end


go 
create proc Insert_Decentralization(
	@TeacherId int null,
	@UserId int null,
	@CreatedDate datetime null,
	@CreatedUserId int null,
	@IsDelete bit null
)as 
begin
	Set Nocount on
	declare @Id int;
	Insert into [System_Decentralization](UserId,TeacherId,CreatedDate,CreatedUserId,IsDeleted)
	values(@UserId,@TeacherId,@CreatedDate,@CreatedUserId,@IsDelete)
	set @Id=SCOPE_IDENTITY()
	return @Id
end

go 
create proc Update_Decentralization(
	@Id int null,
	@TeacherId int null,
	@UserId int null,
	@CreatedDate datetime null,
	@CreatedUserId int null,
	@IsDelete bit null
)
as
begin 
	set Nocount on
	update [System_Decentralization]
	set TeacherId=@TeacherId,UserId=@UserId,CreatedDate=@CreatedDate,CreatedUserId=@CreatedUserId,IsDeleted=@IsDelete
end