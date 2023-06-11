Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure Device
	create proc [dbo].[Device_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_Device] 
		where [Id] = @id
	end
	go

	create proc [dbo].[Device_SelectAllWhereDynamic]
	(
	@id int = null,
	@name nvarchar(100) = null,
	@description nvarchar(100) = null,
	@brandId int = null,
	@deviceTypeId int = null,
	--@shipmentId int = null,
	@qr_code varchar(100) = null,
	@note varchar(100) = null,
	@image varchar(100) = null,
	@price money = null,
	@warrantyPeriod datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Device]
		where (@id IS null or [Id] = @id) and
		(@DeviceTypeId is null or [DeviceTypeId] = @DeviceTypeId) and
		(@name is null or [Name] = @name) and
		(@brandId is null or [brandId] = @brandId) and
		--(@shipmentId is null or [shipmentId] = @shipmentId) and
		(@qr_code is null or [QR_Code] = @qr_code) and
		(@note is null or [Note] = @note) and
		(@image is null or [Image] = @image) and
		(@price is null or [Price] = @price) and
		(@description is null or [Description] = @description) and
		(@warrantyPeriod is null or [WarrantyPeriod] = @warrantyPeriod) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status is null or ISNULL([Status],0) = @status)
		order by [Name]
		end
	go

	create proc [dbo].[Device_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_Device]
	end
	go

	create proc [dbo].[Device_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@name nvarchar(100) = null,
	@description nvarchar(100) = null,
	@brandId int = null,
	@deviceTypeId int = null,
	--@shipmentId int = null,
	@qr_code varchar(100) = null,
	@note varchar(100) = null,
	@image varchar(100) = null,
	@price money = null,
	@warrantyPeriod datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null,
	@sort varchar(50) = null,
	@numberOfRows int,
	@start int)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Device]
		where (@id IS null or [Id] = @id) and
		(@DeviceTypeId is null or [DeviceTypeId] = @DeviceTypeId) and
		(@name is null or [Name] = @name) and
		(@brandId is null or [brandId] = @brandId) and
		--(@shipmentId is null or [shipmentId] = @shipmentId) and
		(@qr_code is null or [QR_Code] = @qr_code) and
		(@note is null or [Note] = @note) and
		(@image is null or [Image] = @image) and
		(@price is null or [Price] = @price) and
		(@description is null or [Description] = @description) and
		(@warrantyPeriod is null or [WarrantyPeriod] = @warrantyPeriod) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status is null or ISNULL([Status],0) = @status)
		order by 
		case when (@sort is null or @sort = 'Id') then [Id] end,
		case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'Price' then [Price] end,
		case when @sort = 'Price desc' then [Price] end desc,
		case when @sort = 'CreatedUserId' then [CreatedUserId] end,
		case when @sort = 'brandId' then [brandId] end,
		case when @sort = 'IsDeleted' then [IsDeleted] end,
		case when @sort = 'Status' then [Status] end
		offset   @start ROWS    -- skip s rows
		FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
		end
	go

	create proc [dbo].[Device_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@name nvarchar(100) = null,
	@description nvarchar(100) = null,
	@brandId int = null,
	@deviceTypeId int = null,
	--@shipmentId int = null,
	@qr_code varchar(100) = null,
	@note varchar(100) = null,
	@image varchar(100) = null,
	@price money = null,
	@warrantyPeriod datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null,
	@sort varchar(50) = null,
	@numberOfRows int,
	@start int)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Device]
		where (@id IS null or [Id] = @id) and
		(@DeviceTypeId is null or [DeviceTypeId] = @DeviceTypeId) and
		(@name is null or [Name] = @name) and
		(@brandId is null or [brandId] = @brandId) and
		--(@shipmentId is null or [shipmentId] = @shipmentId) and
		(@qr_code is null or [QR_Code] = @qr_code) and
		(@note is null or [Note] = @note) and
		(@image is null or [Image] = @image) and
		(@price is null or [Price] = @price) and
		(@description is null or [Description] = @description) and
		(@warrantyPeriod is null or [WarrantyPeriod] = @warrantyPeriod) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status is null or ISNULL([Status],0) = @status)
		order by 
		case when (@sort is null or @sort = 'Id') then [Id] end,
		case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'Price' then [Price] end,
		case when @sort = 'Price desc' then [Price] end desc,
		case when @sort = 'CreatedUserId' then [CreatedUserId] end,
		case when @sort = 'brandId' then [brandId] end,
		case when @sort = 'IsDeleted' then [IsDeleted] end,
		case when @sort = 'Status' then [Status] end
		offset   @start ROWS    -- skip s rows
		FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
		end
	go

	create proc [dbo].[Device_GetRecordCountWhereDynamic](
	@id int = null,
	@name nvarchar(100) = null,
	@description nvarchar(100) = null,
	@brandId int = null,
	@deviceTypeId int = null,
	--@shipmentId int = null,
	@qr_code varchar(100) = null,
	@note varchar(100) = null,
	@image varchar(100) = null,
	@price money = null,
	@warrantyPeriod datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_Device]
	where (@id IS null or [Id] = @id) and
		(@DeviceTypeId is null or [DeviceTypeId] = @DeviceTypeId) and
		(@name is null or [Name] = @name) and
		(@brandId is null or [brandId] = @brandId) and
		--(@shipmentId is null or [shipmentId] = @shipmentId) and
		(@qr_code is null or [QR_Code] = @qr_code) and
		(@note is null or [Note] = @note) and
		(@image is null or [Image] = @image) and
		(@price is null or [Price] = @price) and
		(@description is null or [Description] = @description) and
		(@warrantyPeriod is null or [WarrantyPeriod] = @warrantyPeriod) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status is null or ISNULL([Status],0) = @status)
	end
	go

	create proc [dbo].[Device_Insert](
	@name nvarchar(100) = null,
	@description nvarchar(100) = null,
	@brandId int = null,
	@deviceTypeId int = null,
	--@shipmentId int = null,
	@qr_code varchar(100) = null,
	@note varchar(100) = null,
	@image varchar(100) = null,
	@price money = null,
	@warrantyPeriod datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_Device]
		([Name],[brandId],[DeviceTypeId]/*,[ShipmentId]*/,[qr_code],[Image],[Price],[Note],[Description],[WarrantyPeriod],[CreatedDate],[CreatedUserId],[IsDeleted],[Status]) 
		Values(@name,@brandId,@DeviceTypeId/*,@shipmentId*/,@qr_code,@image,@price,@note,@description,@warrantyPeriod,@createdDate,@createdUserId,@isDeleted,@status)
		select Max(Id) as Id from [dbo].[D_Device]
	end
	go

	create proc [dbo].[Device_Update](
	@id int,
	@name nvarchar(100) = null,
	@description nvarchar(100) = null,
	@brandId int = null,
	@deviceTypeId int = null,
	--@shipmentId int = null,
	@qr_code varchar(100) = null,
	@note varchar(100) = null,
	@image varchar(100) = null,
	@price money = null,
	@warrantyPeriod datetime = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Device]
		set [Name]=@name,[brandId]=@brandId,[DeviceTypeId]=@deviceTypeId/*,[ShipmentId]= @shipmentId*/,[qr_code]=@qr_code,[Image]=@image,
		[Price]=@price,[Note]=@note,[Description]=@description,[WarrantyPeriod]=@warrantyPeriod,
		[CreatedDate]=@createdDate, [CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted,[Status]=@status 
		where [Id] = @id
	end
	go

	create proc [dbo].[Device_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[D_Device]		
		Where [Id] = @id
	end
	go

	create proc [dbo].[Device_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Device]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go

--end Device

/*DeviceType*/

create proc [dbo].[DeviceType_SelectByPrimaryKey](@id int)
as
begin
	select * from [dbo].[D_Device_Type]
	where [Id] = @id
end
go

create proc [dbo].[DeviceType_SelectDropDownListData]
as
	begin
		select * from [dbo].[D_Device_Type]
		where ISNULL([IsDeleted],0) = 0
	end
go
