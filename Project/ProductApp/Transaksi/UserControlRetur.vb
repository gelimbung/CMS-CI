Imports ProductSvr
Public Class UserControlRetur
    Dim uc As UserControl

    Dim order_id As Integer = -1
    Private Sub formatGridRoom()
        dgv.Columns("order_id").HeaderText = "ID"
        dgv.Columns("order_id").Width = 200
        dgv.Columns("order_id").Visible = False
        dgv.Columns("order_date").HeaderText = "Order Date"
        dgv.Columns("order_date").Width = 200
        dgv.Columns("supplier_name").HeaderText = "Supplier Name"
        dgv.Columns("supplier_name").Width = 600
        dgv.Columns("supplier_id").Visible = False
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
            dgv.DataSource = ordSvr.GetOrder()
            dgv.DefaultCellStyle.SelectionBackColor = Color.BurlyWood
            formatGridRoom()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    
End Class
