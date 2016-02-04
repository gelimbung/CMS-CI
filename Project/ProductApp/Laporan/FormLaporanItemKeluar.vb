Imports ProductSvr.Service
Public Class FormLaporanItemKeluar
    Dim svrDeliver As IDeliverService
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        svrDeliver = ClientLibs.InProcFactory.CreateChannel(Of DeliverService, IDeliverService)()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim dtReports As New DataTable 'datatable untuk menampung data record
        Dim frmReport As New FormLaporanViewer ' form report viewer
        Dim crTrans As New CrystalReportReportDelivery '

        dtReports = svrDeliver.GetDeliverReport(DateTimePickerStart.Value, DateTimePickerEnd.Value)
        'crTrans.
        crTrans.SetDataSource(dtReports)
        frmReport.CrystalReportViewer1.ReportSource = crTrans
        frmReport.ShowDialog()
        frmReport = Nothing
    End Sub
End Class