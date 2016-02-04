Imports ProductSvr
Public Class UserControlSupplierData
    Dim supplierSvr As Service.SupplierService = New Service.SupplierService()
    Dim SearchStr As String = "supplier_name LIKE '%{0}%'"
    Dim dt As DataTable = New DataTable()
    Dim dv As DataView = New DataView()
    Private Sub formatGridRoom()
        dgvSupplier.Columns("supplier_id").Visible = False
        dgvSupplier.Columns("supplier_name").Width = 200
        dgvSupplier.Columns("supplier_name").HeaderText = "Name"
        dgvSupplier.Columns("supplier_name").Width = 200
        dgvSupplier.Columns("address").HeaderText = "Address"
        dgvSupplier.Columns("address").Width = 400
        dgvSupplier.Columns("email").HeaderText = "Email"
        dgvSupplier.Columns("email").Width = 150
        dgvSupplier.Columns("phone").HeaderText = "Phone"
        dgvSupplier.Columns("phone").Width = 150
    End Sub

    Private Sub AddStyleToGrid(ByVal dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue
        'dgv.RowHeadersVisible = False
        dgv.GridColor = Color.Black
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv.AllowUserToResizeRows = False
        dgv.AllowUserToAddRows = False


    End Sub


    Public Sub loadData()
        Try
            'Dim testDt As DataTable
            'testDt = supplierSvr.GetSupplier()
            'For Each row As DataRow In testDt.Rows
            '    MsgBox("1")
            'Next
            AddStyleToGrid(dgvSupplier)
            dv.Table = supplierSvr.GetSupplier()
            dgvSupplier.DataSource = dv
            dgvSupplier.DefaultCellStyle.SelectionBackColor = Color.BurlyWood
            formatGridRoom()
        Catch ex As Exception
            'MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxSearch.TextChanged
        Me.dv.RowFilter = String.Format(Me.SearchStr, TextBoxSearch.Text)
    End Sub

    Private Sub ButtonSearch_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearch.Click

        Me.dv.RowFilter = String.Format(Me.SearchStr, "")
    End Sub

    Private Sub dgvSupplier_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSupplier.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim value As String
            value = Me.dgvSupplier.Rows(e.RowIndex).Cells("supplier_id").Value.ToString()
            Me.Parent.Controls.Add(New UserControlSupplierModify(value))

            Me.Parent.Controls.Remove(Me)
        End If
    End Sub
End Class
