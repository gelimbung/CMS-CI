Imports ProductSvr.Service
Public Class UserControlUomData
    Dim UomSvr As UomService = New UomService
    Dim uc As UserControl
    Dim SearchStr As String = "description LIKE '%{0}%'"
    Dim dt As DataTable = New DataTable()
    Dim dv As DataView = New DataView()
    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUom.CellContentClick
        If e.RowIndex <> -1 Then
            Dim value As String
            value = Me.dgvUom.Rows(e.RowIndex).Cells("uom_code").Value.ToString()
            uc = New UserControlUomModify(value)
            Me.Parent.Controls.Add(uc)
            Me.Parent.Controls.Remove(Me)
        End If
    End Sub

    Private Sub formatGridUom()
        dgvUom.Columns("Uom_code").HeaderText = "Uom Code"
        dgvUom.Columns("Uom_code").Width = 200
        dgvUom.Columns("description").HeaderText = "Description"
        dgvUom.Columns("description").Width = 600
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
            'Dim testDt As DataTable = New DataTable()
            'testDt = UomService.GetUom
            'For Each row As DataRow In testDt.Rows
            '    MsgBox("1")
            'Next



            AddStyleToGrid(dgvUom)
            dv.Table = UomSvr.GetUom()
            dgvUom.DataSource = dv
            dgvUom.DefaultCellStyle.SelectionBackColor = Color.BurlyWood
            formatGridUom()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxSearch.TextChanged
        Me.dv.RowFilter = String.Format(Me.SearchStr, TextBoxSearch.Text)
    End Sub

    Private Sub ButtonSearch_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearch.Click
        TextBoxSearch.Text = ""
        Me.dv.RowFilter = String.Format(Me.SearchStr, TextBoxSearch.Text)
    End Sub

    Private Sub dgvUom_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvUom.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim value As String
            value = Me.dgvUom.Rows(e.RowIndex).Cells("uom_code").Value.ToString()
            uc = New UserControlUomModify(value)
            Me.Parent.Controls.Add(uc)
            Me.Parent.Controls.Remove(Me)
        End If
    End Sub
End Class
