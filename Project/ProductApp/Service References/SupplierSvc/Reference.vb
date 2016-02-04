﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace SupplierSvc
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="SupplierSvc.ISupplierService")>  _
    Public Interface ISupplierService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISupplierService/SupplierAdd", ReplyAction:="http://tempuri.org/ISupplierService/SupplierAddResponse")>  _
        Function SupplierAdd(ByVal inp As ProductSvr.Model.Supplier) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISupplierService/SupplierModify", ReplyAction:="http://tempuri.org/ISupplierService/SupplierModifyResponse")>  _
        Function SupplierModify(ByVal inp As ProductSvr.Model.Supplier) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISupplierService/SupplierDelete", ReplyAction:="http://tempuri.org/ISupplierService/SupplierDeleteResponse")>  _
        Function SupplierDelete(ByVal id As Integer) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISupplierService/GetSupplier", ReplyAction:="http://tempuri.org/ISupplierService/GetSupplierResponse")>  _
        Function GetSupplier() As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISupplierService/RecordSupplier", ReplyAction:="http://tempuri.org/ISupplierService/RecordSupplierResponse")>  _
        Function RecordSupplier(ByVal supplier_id As Integer) As ProductSvr.Model.Supplier
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ISupplierServiceChannel
        Inherits SupplierSvc.ISupplierService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class SupplierServiceClient
        Inherits System.ServiceModel.ClientBase(Of SupplierSvc.ISupplierService)
        Implements SupplierSvc.ISupplierService
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function SupplierAdd(ByVal inp As ProductSvr.Model.Supplier) As String Implements SupplierSvc.ISupplierService.SupplierAdd
            Return MyBase.Channel.SupplierAdd(inp)
        End Function
        
        Public Function SupplierModify(ByVal inp As ProductSvr.Model.Supplier) As String Implements SupplierSvc.ISupplierService.SupplierModify
            Return MyBase.Channel.SupplierModify(inp)
        End Function
        
        Public Function SupplierDelete(ByVal id As Integer) As String Implements SupplierSvc.ISupplierService.SupplierDelete
            Return MyBase.Channel.SupplierDelete(id)
        End Function
        
        Public Function GetSupplier() As System.Data.DataTable Implements SupplierSvc.ISupplierService.GetSupplier
            Return MyBase.Channel.GetSupplier
        End Function
        
        Public Function RecordSupplier(ByVal supplier_id As Integer) As ProductSvr.Model.Supplier Implements SupplierSvc.ISupplierService.RecordSupplier
            Return MyBase.Channel.RecordSupplier(supplier_id)
        End Function
    End Class
End Namespace