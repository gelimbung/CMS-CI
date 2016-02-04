
Imports System.Windows.Forms
Public Class FormRetur
    Dim uc As UserControl
    Dim viewData As New UserControlRetur
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub ButtonSearchSupplier_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ButtonSearchProduct_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub ToolStripButtonData_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonData.Click
        Me.PanelMain.Controls.Remove(uc)

        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.PanelMain.Controls.Clear()
        uc = New UserControlDeliverInput()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub FormRetur_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PanelMain.Controls.Clear()
        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub
End Class