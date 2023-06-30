Use Devicement
go

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--store procedure ShipmentDetail_
	create proc [dbo].[ShipmentDetail_SelectByPrimaryKey](@id int)
	as 
	begin
	SET NOCOUNT ON;
		select* from [dbo].[D_Shipment_Detail] 
		where [Id] = @id
	end
	go

	create proc [dbo].[ShipmentDetail_SelectAllWhereDynamic]
	(
	@id int = null,
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as 
		begin
		SET NOCOUNT ON;
		select * from [dbo].[D_Shipment_Detail]
		where (@id IS null or [Id] = @id) and
		(@shipmentId IS null or [ShipmentId] = @shipmentId) and
		(@deviceId IS null or [DeviceId] = @deviceId) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status IS null or [Status] = @status)
		order by [CreatedDate]
		end
	go

	create proc [dbo].[ShipmentDetail_GetRecordCount]
	as 
	begin
	SET NOCOUNT ON;
		select count(*) [count] from [dbo].[D_Shipment_Detail]
	end
	go

	create proc [dbo].[ShipmentDetail_SelectSkipAndTakeWhereDynamic](
	@id int = null,
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
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
		select * from [dbo].[D_Shipment_Detail]
		where (@id IS null or [Id] = @id) and
		(@shipmentId IS null or [ShipmentId] = @shipmentId) and
		(@deviceId IS null or [DeviceId] = @deviceId) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status IS null or [Status] = @status)
		order by 
		case when (@sort is null or @sort = 'Id') then [Id] end,
		case when (@sort = 'Id desc') then [Id] end desc,
		case when @sort = 'CreatedUserId' then [CreatedUserId] end,
		case when @sort = 'CreatedDate' then [CreatedDate] end,
		case when @sort = 'CreatedDate desc' then [CreatedDate] end desc,
		case when @sort = 'IsDeleted' then [IsDeleted] end
		offset   @start ROWS    -- skip s rows
		FETCH NEXT @numberOfRows ROWS ONLY; -- take n rows
		end
	go

	create proc [dbo].[ShipmentDetail_GetRecordCountWhereDynamic](
	@id int = null,
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
as 
	begin
	SET NOCOUNT ON;
	select count(*) [count] from [dbo].[D_Shipment_Detail]
	where (@id IS null or [Id] = @id) and
		(@shipmentId IS null or [ShipmentId] = @shipmentId) and
		(@deviceId IS null or [DeviceId] = @deviceId) and
		(@description is null or [Description] = @description) and
		(@createdDate is null or [CreatedDate] = @createdDate) and
		(@createdUserId is null or [CreatedUserId] = @createdUserId) and
		(@isDeleted is null or ISNULL([IsDeleted],0) = @isDeleted) and
		(@status IS null or [Status] = @status)
	end
	go

	create proc [dbo].[ShipmentDetail_Insert](
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Insert into [dbo].[D_Shipment_Detail]
		([ShipmentId], [DeviceId], [Description],[CreatedDate],[CreatedUserId],[IsDeleted],[Status]) 
		Values(@shipmentId , @deviceId , @description,@createdDate,@createdUserId,@isDeleted,@status)
		select Max([Id])  as Id from [dbo].[D_Shipment_Detail]
	end
	go

	create proc [dbo].[ShipmentDetail_Update](
	@id int = null,
	@shipmentId int = null,
	@deviceId int = null,
	@description nvarchar(100) = null,
	@createdDate datetime = null,
	@createdUserId int = null,
	@isDeleted bit = null,
	@status int = null
	)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Shipment_Detail]
		set ShipmentId = @shipmentId,[DeviceId] = @deviceId,[Description]=@description
		,[CreatedDate]=@createdDate,[CreatedUserId]=@createdUserId,[IsDeleted]=@isDeleted,[Status] = @status
		where [Id] =@id
	end
	go

	create proc [dbo].[ShipmentDetail_Delete](@id int)
	as
	begin
		SET NOCOUNT ON;
		Delete from [dbo].[D_Shipment_Detail]		
		Where [Id] = @id
	end
	go

	create proc [dbo].[ShipmentDetail_Hide](@id int)
	as
	begin
		SET NOCOUNT ON;
		Update [dbo].[D_Shipment_Detail]
		set [IsDeleted]=1
		Where [Id] = @id
	end
	go

	create proc [dbo].[ShipmentDetail_SelectAndCollectByShipment](@id int)
	as 
	begin
		SET NOCOUNT ON;
		--Select * from D_Shipment_Detail sd
		select [Name],[Mota] From D_Device d,
		
		(
		Select DeviceId as 'Id', CONCAT_WS(': ',ddt.NameSpecs,ddt.[Description]) as 'MoTa' from [dbo].[D_DeviceDetail] ddt
		Group By DeviceId, CONCAT_WS(': ',ddt.NameSpecs,ddt.[Description])
		) as Device
		where d.Id = Device.Id
	end
	go
--end Shipment

