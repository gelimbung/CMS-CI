Imports ProductSvr
Public Class FormLaporanItemPersediaan
    Dim svrProd As New Service.ProductService
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim dtReports As New DataTable 'datatable untuk menampung data record
        Dim frmReport As New FormLaporanViewer ' form report viewer
        Dim crTrans As New CrystalReportPersediaan '

        dtReports = svrProd.GetProduct()
        'crTrans.
        crTrans.SetDataSource(dtReports)
        frmReport.CrystalReportViewer1.ReportSource = crTrans
        frmReport.ShowDialog()
        frmReport = Nothing
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub
End Class