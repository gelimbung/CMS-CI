Namespace Dao

    Public Class FoodDao

        Public Property db As DbLibs.ClsDbase

        Public Function GetFoods(name As String) As String
            Return String.Format("Food : {0}", name)
        End Function

        Public Function GetPoli() As DataTable
            Try

                Return Me.db.execQuery("Pis_PolyGetAll")

            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class

End Namespace

