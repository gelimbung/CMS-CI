Public Class MainService

    Public Shared Sub RunService()
        ServerLibs.InProcFactory.CreateChannel(Of ProductSvr.Service.RoomService, ProductSvr.Service.IRoomService)()
        ServerLibs.InProcFactory.CreateChannel(Of ProductSvr.Service.UomService, ProductSvr.Service.IUomService)()
        ServerLibs.InProcFactory.CreateChannel(Of ProductSvr.Service.SupplierService, ProductSvr.Service.ISupplierService)()
        ServerLibs.InProcFactory.CreateChannel(Of ProductSvr.Service.ProductService, ProductSvr.Service.IProductService)()
        ServerLibs.InProcFactory.CreateChannel(Of ProductSvr.Service.DeliverService, ProductSvr.Service.IDeliverService)()
        ServerLibs.InProcFactory.CreateChannel(Of ProductSvr.Service.OrderService, ProductSvr.Service.IOrderService)()
    End Sub

End Class
