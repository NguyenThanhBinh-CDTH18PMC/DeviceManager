--thêm xóa sửa Phòng
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

---Thêm xóa Sửa Thương Hiệu
go
create proc GetAllBrand
as
select Id,Name,Address from D_Brand
go
Create proc InsertBrand
@Id int,
@Name nvarchar(50),
@Address nvarchar(100),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	set IDENTITY_INSERT D_Brand on;
	insert into D_Brand(Id, Name,Address,CreatedDate,CreatedUserId,IsDeleted,Status)
	values (@Id,@Name,@Address,@CreatedDate,@CreatedUserId,@IsDeleted,@Status)
	set IDENTITY_INSERT D_Brand Off;
end

go
Create proc UpdateBrand
@Id int,
@Name nvarchar(50),
@Address nvarchar(100),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	set IDENTITY_INSERT D_Brand on;
	UPDATE D_Brand
	SET Name=@Name,Address=@Address,CreatedDate=@CreatedDate
	,CreatedUserId=@CreatedUserId,IsDeleted=@IsDeleted,Status=@Status
	WHERE @Id=Id
	set IDENTITY_INSERT D_Brand Off;
end

go 
create proc DeleteBrand
@Id int
as 
delete from D_Brand
Where Id=@Id
--Thêm xóa sửa Loại thiết bị

go
create proc GetAllDevice_Type
as
select Id,Name,Description from D_Device_Type

go
Create proc InsertDevice_type
@Id int,
@Name nvarchar(50),
@Description nvarchar(100),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	set IDENTITY_INSERT D_Device_Type on;
	insert into D_Device_Type(Id, Name,Description,CreatedDate,CreatedUserId,IsDeleted,Status)
	values (@Id,@Name,@Description,@CreatedDate,@CreatedUserId,@IsDeleted,@Status)
	set IDENTITY_INSERT D_Device_Type Off;
end

go
Create proc UpdateDevice_Type
@Id int,
@Name nvarchar(50),
@Description nvarchar(100),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit,
@Status int
as
begin
	set IDENTITY_INSERT D_Device_Type on;
	UPDATE D_Device_Type
	SET Name=@Name,Description=@Description,CreatedDate=@CreatedDate
	,CreatedUserId=@CreatedUserId,IsDeleted=@IsDeleted,Status=@Status
	WHERE @Id=Id
	set IDENTITY_INSERT D_Device_Type Off;
end

go create proc DeleteDevice_Type
@Id int
as 
delete from D_Device_Type
Where Id=@Id