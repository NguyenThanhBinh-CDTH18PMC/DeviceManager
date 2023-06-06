
create proc GetAllRoom
as
select Id,Code,Name,Description,DeviceQuantity from D_Room
go

Create proc InsertRoom
@Code nvarchar(50),
@Name nvarchar(50),
@Description nvarchar(100),
@DeviceQuantity int,
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	SET NOCOUNT ON;
	declare @Id int;
	insert into D_Room(Code,Name,Description,DeviceQuantity,CreatedDate,CreatedUserId,IsDeleted,Status)
	values (@Code,@Name,@Description,@DeviceQuantity,@CreatedDate,@CreatedUserId,@IsDeleted,@Status)
	set @Id = SCOPE_IDENTITY()
	return @Id
end
GO 
Create proc UpdateRoom
@Code nvarchar(50),
@Name nvarchar(50),
@Description nvarchar(100),
@DeviceQuantity int,
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	set NOCOUNT ON
	declare @Id int;
	UPDATE D_Room
	SET Code=@Code,Name=@Name,Description=@Description,DeviceQuantity=@DeviceQuantity,CreatedDate=@CreatedDate
	,CreatedUserId=@CreatedUserId,IsDeleted=@IsDeleted,Status=@Status
	WHERE Code=@Code
	SET @Id =SCOPE_IDENTITY()
	return @Id
end
go
create proc DeleteRoom
@Code nvarchar(50)
as 
delete from D_Room
Where Code=@Code