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


Namespace RoomSvc
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="RoomSvc.Room")>  _
    Public Interface Room
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Room/RoomAdd", ReplyAction:="http://tempuri.org/Room/RoomAddResponse")>  _
        Function RoomAdd(ByVal rm As ProductSvr.Model.Room) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Room/RoomModify", ReplyAction:="http://tempuri.org/Room/RoomModifyResponse")>  _
        Function RoomModify(ByVal rm As ProductSvr.Model.Room, ByVal key As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Room/RoomDelete", ReplyAction:="http://tempuri.org/Room/RoomDeleteResponse")>  _
        Function RoomDelete(ByVal room_id As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Room/GetRoom", ReplyAction:="http://tempuri.org/Room/GetRoomResponse")>  _
        Function GetRoom() As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Room/RecordRoom", ReplyAction:="http://tempuri.org/Room/RecordRoomResponse")>  _
        Function RecordRoom(ByVal id As String) As ProductSvr.Model.Room
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface RoomChannel
        Inherits RoomSvc.Room, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class RoomClient
        Inherits System.ServiceModel.ClientBase(Of RoomSvc.Room)
        Implements RoomSvc.Room
        
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
        
        Public Function RoomAdd(ByVal rm As ProductSvr.Model.Room) As String Implements RoomSvc.Room.RoomAdd
            Return MyBase.Channel.RoomAdd(rm)
        End Function
        
        Public Function RoomModify(ByVal rm As ProductSvr.Model.Room, ByVal key As String) As String Implements RoomSvc.Room.RoomModify
            Return MyBase.Channel.RoomModify(rm, key)
        End Function
        
        Public Function RoomDelete(ByVal room_id As String) As String Implements RoomSvc.Room.RoomDelete
            Return MyBase.Channel.RoomDelete(room_id)
        End Function
        
        Public Function GetRoom() As System.Data.DataTable Implements RoomSvc.Room.GetRoom
            Return MyBase.Channel.GetRoom
        End Function
        
        Public Function RecordRoom(ByVal id As String) As ProductSvr.Model.Room Implements RoomSvc.Room.RecordRoom
            Return MyBase.Channel.RecordRoom(id)
        End Function
    End Class
End Namespace
