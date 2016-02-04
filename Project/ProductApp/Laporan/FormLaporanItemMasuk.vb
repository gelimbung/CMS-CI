Imports ProductSvr
Public Class FormLaporanItemMasuk
    Dim svrOrder As New Service.OrderService
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim dtReports As New DataTable 'datatable untuk menampung data record
        Dim frmReport As New FormLaporanViewer ' form report viewer
        Dim crTrans As New CrystalReportOrder '




        dtReports = svrOrder.GetOrderReport(DateTimePickerStart.Value, DateTimePickerEnd.Value)
        'crTrans.
        crTrans.SetDataSource(dtReports)
        frmReport.CrystalReportViewer1.ReportSource = crTrans
        frmReport.ShowDialog()
        frmReport = Nothing
    End Sub
End Class