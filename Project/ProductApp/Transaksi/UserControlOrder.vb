Imports ProductSvr
Public Class UserControlOrder
    Dim order_id As Integer = -1
    Dim uc As UserControl
    Public Property viewData As New UserControlOrderData()
    Dim ordSvr As New Service.OrderService()
    Private Sub ToolStripButtonData_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonData.Click
        Me.PanelMain.Controls.Clear()
        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.PanelMain.Controls.Clear()
        uc = New UserControlOrderInput(viewData)

        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click

        If viewData.dgv.SelectedRows.Count > 0 Then
            order_id = CInt(viewData.dgv.SelectedCells("0").Value)
            uc = New UserControlOrderModify(CInt(viewData.dgv.SelectedCells("0").Value))
            uc.Dock = DockStyle.Fill
            Me.PanelMain.Controls.Clear()
            Me.PanelMain.Controls.Add(uc)
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        If viewData.dgv.SelectedRows.Count > 0 Then
            order_id = CInt(viewData.dgv.SelectedCells("0").Value)
        End If
        If order_id <> -1 Then
            If MsgBox("Are you sure delete data ?", MsgBoxStyle.YesNo, "Title") = MsgBoxResult.Yes Then

                Dim msg As String = ordSvr.OrderDelete(order_id)
                MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewData.loadData()
                order_id = -1
                Me.PanelMain.Controls.Clear()
                Me.PanelMain.Controls.Add(viewData)
            Else
                order_id = -1
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
