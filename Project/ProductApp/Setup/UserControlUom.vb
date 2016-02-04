Imports ProductSvr
Public Class UserControlUom
    Dim viewData As New UserControlUomData
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.PanelMain.Controls.Clear()
        viewData.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(viewData)
        viewData.loadData()
    End Sub

    Private Sub UserControlUom_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.PanelMain.Controls.Clear()
        viewData.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(viewData)
        viewData.loadData()
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.PanelMain.Controls.Clear()
        Dim viewForm As UserControlUomInput = New UserControlUomInput
        Me.PanelMain.Controls.Add(viewForm)
        viewForm.Dock = DockStyle.Fill
        viewData.dgvUom.ClearSelection()
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        If viewData.dgvUom.SelectedRows.Count > 0 Then
            Me.PanelMain.Controls.Clear()
            Dim viewModify As New UserControlUomModify(viewData.dgvUom.CurrentRow.Cells("uom_code").Value.ToString())
            viewData.Dock = DockStyle.Fill
            Me.PanelMain.Controls.Add(viewModify)
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonDelete.Click
        If viewData.dgvUom.SelectedRows.Count > 0 Then
            If MsgBox("Are you sure delete data ?", MsgBoxStyle.YesNo, "Title") = MsgBoxResult.Yes Then
                Dim svr As New Service.UomService()
                Dim msg As String = svr.UomDelete(viewData.dgvUom.CurrentRow.Cells("uom_code").Value.ToString())
                MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewData.loadData()
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
