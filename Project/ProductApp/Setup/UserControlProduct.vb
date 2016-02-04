Imports ProductSvr
Public Class UserControlProduct
    Dim viewData As New UserControlProductData()
    Dim uc As UserControl

    Private Sub UserControlProduk_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.PanelMain.Controls.Clear()
        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub


    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs)
        Me.PanelMain.Controls.Clear()
        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub


    Private Sub ToolStripButtonModify_Click(sender As System.Object, e As System.EventArgs)
        If viewData.dgvProduct.SelectedRows.Count > 0 Then
            Me.PanelMain.Controls.Clear()
            Dim viewModify As New UserControlProductModify(viewData.dgvProduct.SelectedCells("0").Value.ToString())
            uc = viewModify
            uc.Dock = DockStyle.Fill
            Me.PanelMain.Controls.Add(uc)
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButtonDelete_Click(sender As System.Object, e As System.EventArgs)
        If viewData.dgvProduct.SelectedRows.Count > 0 Then
            If MsgBox("Are you sure delete data ?", MsgBoxStyle.YesNo, "Title") = MsgBoxResult.Yes Then
                Dim svrProd As New Service.ProductService()
                Dim msg As String = svrProd.ProductDelete(viewData.dgvProduct.SelectedCells("0").Value.ToString())
                MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewData.loadData()
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ToolStripButton1_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Me.PanelMain.Controls.Clear()
        uc = viewData
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        Me.PanelMain.Controls.Clear()
        uc = New UserControlProductInput()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButtonModify_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonModify.Click
        If viewData.dgvProduct.SelectedRows.Count > 0 Then
            Me.PanelMain.Controls.Clear()
            Dim viewModify As New UserControlProductModify(viewData.dgvProduct.SelectedCells("0").Value.ToString())
            uc = viewModify
            uc.Dock = DockStyle.Fill
            Me.PanelMain.Controls.Add(uc)
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButtonDelete_Click_1(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonDelete.Click
        If viewData.dgvProduct.SelectedRows.Count > 0 Then
            If MsgBox("Are you sure delete data ?", MsgBoxStyle.YesNo, "Title") = MsgBoxResult.Yes Then
                Dim svrProd As New Service.ProductService()
                Dim msg As String = svrProd.ProductDelete(viewData.dgvProduct.SelectedCells("0").Value.ToString())
                MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewData.loadData()
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
