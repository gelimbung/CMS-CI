Public Class FrmService

    Private Sub FrmService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Text = "HMIS Service v 3.7.52"

        MainService.RunService()

        'server.FinanceService.RunService()
        'server.HRDService.RunService()
        'server.MMHost.RunService()
        'server.PharmacyService.RunService()
        'server.PISService.RunService()
        'server.PISService.RunServiceIRNA()

        'lblStatus.Text = "Service Running..."

    End Sub

End Class