Imports ProductSvr
Imports System.Windows.Forms
Public Class FormDeliver
    Dim uc As UserControl
    Dim viewData As New UserControlDeliverData
    Dim delivery_id As Integer = -1
    Dim deliveryService As New Service.DeliverService()
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
        uc = New UserControlDeliverInputNew(viewData)
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub FormDeliver_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.PanelMain.Controls.Clear()
        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        If viewData.dgv.SelectedRows.Count > 0 Then
            delivery_id = CInt(viewData.dgv.SelectedCells("0").Value)
            uc = New UserControlDeliverModify(CInt(viewData.dgv.SelectedCells("0").Value))
            uc.Dock = DockStyle.Fill
            Me.PanelMain.Controls.Clear()
            Me.PanelMain.Controls.Add(uc)
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        If viewData.dgv.SelectedRows.Count > 0 Then
            delivery_id = CInt(viewData.dgv.SelectedCells("0").Value)
        End If
        If delivery_id <> -1 Then
            If MsgBox("Are you sure delete data ?", MsgBoxStyle.YesNo, "Title") = MsgBoxResult.Yes Then

                Dim msg As String = deliveryService.DeliveryDelete(delivery_id)
                MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewData.loadData()
                delivery_id = -1
                Me.PanelMain.Controls.Clear()
                Me.PanelMain.Controls.Add(viewData)
            Else
                delivery_id = -1
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As System.Object, e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class