Imports DietaryService.Service
Imports ClientLibs
Imports SessionInfo


Public Class ModFoodMenu

    Private fdSrv As IFoodService
    Dim acl As SessionInfo.ACLUser

    Private Sub ModFoodMenu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.acl = CType(Me.Tag, ACLUser)
        btnProses.Enabled = Me.acl.allowPrint

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btnProses.Click

        Me.fdSrv = InProcFactory.CreateChannel(Of FoodService, IFoodService)()

        'untuk keperluan debug
        'Me.fdSrv = New FoodService()

        Dim hasil As String = Me.fdSrv.GetFoods(TextBox1.Text)
        gv.DataSource = Me.fdSrv.GetPoli()

        InProcFactory.CloseChannel(Me.fdSrv)

        MsgBox(hasil)

    End Sub

End Class
