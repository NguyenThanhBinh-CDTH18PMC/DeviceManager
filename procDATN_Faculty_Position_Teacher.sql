Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--thêm xóa sửa Khoa
go
create proc GetAllFaculty
as
select Id,Name,Description from D_Faculty
go
Create proc InsertFaculty
@Name nvarchar(50),
@Description nvarchar(100),
--@Image nvarchar(100) null,
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit
as
begin
	SET NOCOUNT ON;
	declare @Id int;
	insert into D_Faculty(Name,Description,CreatedDate,CreatedUserId,IsDeleted)
	values (@Name,@Description,@CreatedDate,@CreatedUserId,@IsDeleted)
	set @Id = SCOPE_IDENTITY()
	return @Id
end
go
Create proc UpdateFaculty
@Id int,
@Name nvarchar(50),
@Description nvarchar(100),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit
--@Status int
as
begin
	set NOCOUNT ON
	UPDATE D_Faculty
	SET Name=@Name,Description=@Description,CreatedDate=@CreatedDate
	,CreatedUserId=@CreatedUserId,IsDeleted=@IsDeleted
	WHERE @Id=Id
	SET @Id =SCOPE_IDENTITY()
	return @Id
	
end
go
create proc GetFacultyAfterDelete
as
select Id,Name,Description from D_Faculty
where IsDeleted=0
go 
--thêm xóa sửa chức vụ
go
create proc GetAllPosition
as
select Id,Name from D_Position
go
Create proc InsertPosition
@Name nvarchar(50),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit
as
begin
	SET NOCOUNT ON;
	declare @Id int;
	insert into D_Position(Name,CreatedDate,CreatedUserId,IsDeleted)
	values (@Name,@CreatedDate,@CreatedUserId,@IsDeleted)
	set @Id = SCOPE_IDENTITY()
	return @Id
end
go
Create proc UpdatePosition
@Id int,
@Name nvarchar(50),
@CreatedDate datetime null,
@CreatedUserId int,
@IsDeleted bit
--@Status int
as
begin
	set NOCOUNT ON
	UPDATE D_Position
	SET Name=@Name,CreatedDate=@CreatedDate
	,CreatedUserId=@CreatedUserId,IsDeleted=@IsDeleted
	WHERE @Id=Id
	SET @Id =SCOPE_IDENTITY()
	return @Id
	
end
go
create proc GetPositonAfterDelete
as
select Id,Name from D_Position
where IsDeleted=0
go 

--thêm xóa sửa Giáo viên
go
create proc GetAllTeachers
as 
begin
	select Gv.Id,Gv.FirstName,Gv.LastName,Gv.FullName,Gv.Birth,Gv.Gender,Gv.Address,Gv.Phone,Gv.Email,p.Name
	from S_Teacher Gv
	inner join D_Position p on Gv.PositionId= p.Id
end

go
create proc InsertTeacher
	
	@FirstName nvarchar(40) null,
	@LastName nvarchar(20) null,
	@FullName nvarchar(60) null,
	@Birth Datetime null,
	@Gender bit,
	@Address nvarchar(200) null,
	--Image nvarchar(200) null,
	@Phone varchar(20) null,
	@Email varchar(50) null,
	@CreatedDate DateTime null,
	@CreatedUserId int null,
	@PositionId int null,
	@IsDeleted bit null,
	@Status int null
	as
begin
	SET NOCOUNT ON;
	declare @Id int;
	insert into S_Teacher(FirstName,LastName,FullName,Birth,Gender,Address,Phone,Email,CreatedDate,CreatedUserId,PositionId,IsDeleted,Status)
	values (@FirstName,@LastName,@FullName,@Birth,@Gender,@Address,@Phone,@Email,@CreatedDate,@CreatedUserId,@PositionId,@IsDeleted,@Status)
	set @Id = SCOPE_IDENTITY()
	return @Id
end
go
create proc UpdateTeacher
	@Id int,
	@FirstName nvarchar(40) null,
	@LastName nvarchar(20) null,
	@FullName nvarchar(60) null,
	@Birth Datetime null,
	@Gender bit,
	@Address nvarchar(200) null,
	--Image nvarchar(200) null,
	@Phone varchar(20) null,
	@Email varchar(50) null,
	@CreatedDate DateTime null,
	@CreatedUserId int null,
	@PositionId int null,
	@IsDeleted bit null,
	@Status int null
	as
begin
	set NOCOUNT ON
	update S_Teacher
	set FirstName=@FirstName,LastName=@LastName,FullName=@FullName,Birth=@Birth,Gender=@Gender,Address=@Address,Phone=@Phone,
		Email=@Email,CreatedDate=@CreatedDate,CreatedUserId=@CreatedUserId,PositionId=@PositionId,IsDeleted=@IsDeleted,Status=@Status
		WHERE @Id=Id
	SET @Id =SCOPE_IDENTITY()
	return @Id
end
go
create proc GetTeachersAfterDelete
as 
begin
	select Gv.Id,Gv.FirstName,Gv.LastName,Gv.FullName,Gv.Birth,Gv.Gender,Gv.Address,Gv.Phone,Gv.Email,p.Name
	from S_Teacher Gv 
	inner join D_Position p on Gv.PositionId= p.Id
	where Gv.IsDeleted=0
end