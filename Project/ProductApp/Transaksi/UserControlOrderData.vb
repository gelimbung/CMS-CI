Imports ProductSvr
Public Class UserControlOrderData
    Dim uc As UserControl
    Dim SearchStr As String = "supplier_name LIKE '%{0}%'"
    Dim order_id As Integer = -1
    Dim dv As New DataView()

    Private Sub formatGridRoom()
        dgv.Columns("order_id").HeaderText = "No"
        dgv.Columns("order_id").Width = 200
        dgv.Columns("order_id").Visible = True
        dgv.Columns("order_date").HeaderText = "Order Date"
        dgv.Columns("order_date").Width = 200
        dgv.Columns("supplier_name").HeaderText = "Supplier Name"
        dgv.Columns("supplier_name").Width = 300
        dgv.Columns("supplier_id").Visible = False
        dgv.Columns("address").HeaderText = "Address"
        dgv.Columns("address").Width = 400
        dgv.Columns("phone").HeaderText = "Phone"
        dgv.Columns("phone").Width = 100

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
            Dim ordSvr As Service.OrderService = New Service.OrderService()
            AddStyleToGrid(dgv)
            dv.Table = ordSvr.GetOrder()
            dgv.DataSource = dv
            dgv.DefaultCellStyle.SelectionBackColor = Color.BurlyWood
            formatGridRoom()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub


    Private Sub TextBoxSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxSearch.TextChanged
        Me.dv.RowFilter = String.Format(Me.SearchStr, TextBoxSearch.Text)
    End Sub

    Private Sub ButtonSearch_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearch.Click
        Me.dv.RowFilter = String.Format(Me.SearchStr, "")
    End Sub
End Class
