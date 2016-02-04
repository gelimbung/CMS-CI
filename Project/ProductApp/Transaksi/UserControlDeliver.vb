Imports ProductSvr
Public Class UserControlDeliver
    Dim uc As UserControl
    Dim viewData As New UserControlDeliverData
    Dim delivery_id As Integer = -1
    Dim deliveryService As Service.IDeliverService

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
                deliveryService = ClientLibs.InProcFactory.CreateChannel(Of Service.DeliverService, Service.IDeliverService)()
                Dim msg As String = deliveryService.DeliveryDelete(delivery_id)
                MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewData.loadData()
                delivery_id = -1
                Me.PanelMain.Controls.Clear()
                Me.PanelMain.Controls.Add(viewData)
                ClientLibs.InProcFactory.CloseChannel(deliveryService)
            Else
                delivery_id = -1
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub UserControlDeliver_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.PanelMain.Controls.Remove(uc)
        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub
End Class
