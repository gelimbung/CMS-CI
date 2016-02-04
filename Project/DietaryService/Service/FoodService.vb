Imports System.ServiceModel

Namespace Service

    <ServiceContract()>
    Public Interface IFoodService

        <OperationContract()>
        Function GetFoods(name As String) As String

        <OperationContract()>
        Function GetPoli() As DataTable

    End Interface

    <ServiceBehavior(IncludeExceptionDetailInFaults:=True)>
    Public Class FoodService
        Implements IFoodService

        Private fdDao As Dao.FoodDao
        Private db As DbLibs.ClsDbase

        Public Sub New()
            Me.db = New DbLibs.ClsDbase(System.Configuration.ConfigurationManager.AppSettings("strCnn").ToString())
            Me.fdDao = New Dao.FoodDao()
            Me.fdDao.db = Me.db
        End Sub

        Public Function GetFoods(name As String) As String Implements IFoodService.GetFoods
            Return Me.fdDao.GetFoods(name)
        End Function

        Public Function GetPoli() As System.Data.DataTable Implements IFoodService.GetPoli
            Try

                Return Me.fdDao.GetPoli()

            Catch ex As Exception
                Throw New FaultException(ex.Message)
            End Try
        End Function

    End Class

End Namespace

