Imports ProductSvr
Public Class FormLaporanViewer
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        loadData()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub loadData()
        Dim orderSVr As New Service.OrderService()
        Dim dt As New DataTable()
        dt = orderSVr.GetOrder()
        'For Each row As DataRow In dt.Rows
        '    MsgBox(1)
        'Next
        Dim rpt As New CrystalReportOrder()
        rpt.Database.Tables("Order").SetDataSource(dt)
        Me.CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub FormLaporanItemMasuk_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '  Me.ReportViewer1.LocalReport = rpt
    End Sub
End Class