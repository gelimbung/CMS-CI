Imports ProductSvr
Public Class UserControlSupplier
    Dim uc As UserControl
    Dim viewData As New UserControlSupplierData
    Private Sub UserControlSupplier_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.PanelMain.Controls.Clear()
        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.PanelMain.Controls.Clear()
        uc = New UserControlSupplierInput()
        uc.Dock = DockStyle.Fill
        viewData.dgvSupplier.ClearSelection()
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        If viewData.dgvSupplier.SelectedRows.Count > 0 Then
            Me.PanelMain.Controls.Clear()
            Dim viewModify As New UserControlSupplierModify(Convert.ToInt16(viewData.dgvSupplier.CurrentRow.Cells("supplier_id").Value.ToString()))
            uc = viewModify
            uc.Dock = DockStyle.Fill
            Me.PanelMain.Controls.Add(uc)
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        If viewData.dgvSupplier.SelectedRows.Count > 0 Then
            If MsgBox("Are you sure delete data ?", MsgBoxStyle.YesNo, "Title") = MsgBoxResult.Yes Then
                Dim svr As New Service.SupplierService()
                Dim mesRes As String = svr.SupplierDelete(viewData.dgvSupplier.CurrentRow.Cells("supplier_id").Value.ToString())
                MessageBox.Show(mesRes, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewData.loadData()
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.PanelMain.Controls.Clear()
        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub
End Class
