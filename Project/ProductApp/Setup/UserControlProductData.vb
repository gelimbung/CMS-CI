Imports ProductSvr.Service
Imports ProductSvr.Model
Public Class UserControlProductData
    Dim prodSvr As IProductService
    Dim SearchStr As String = "product_name LIKE '%{0}%'"
    Dim dt As DataTable = New DataTable()
    Dim dv As DataView = New DataView()



    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub UserControlProduct_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Me.loadData()
    End Sub

    Private Sub formatGridRoom()
        dgvProduct.Columns("product_price").DefaultCellStyle.Format = "#,0.###"
        dgvProduct.Columns("product_id").HeaderText = "ID"
        dgvProduct.Columns("product_id").Width = 100
        dgvProduct.Columns("uom_code").HeaderText = "Uom"
        dgvProduct.Columns("uom_code").Width = 100
        dgvProduct.Columns("product_name").HeaderText = "Name"
        dgvProduct.Columns("product_name").Width = 300
        dgvProduct.Columns("qty_stock").HeaderText = "Qtt"
        dgvProduct.Columns("qty_stock").Width = 100
        dgvProduct.Columns("product_price").HeaderText = "Price"
        dgvProduct.Columns("product_price").Width = 200
        dgvProduct.Columns("product_price").DefaultCellStyle.Format = "#,0.###"
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


    Public Sub modifyData()
        Dim md As New Product
        MsgBox(dgvProduct.SelectedRows.Count.ToString())
        If dgvProduct.SelectedRows.Count > 0 Then
            md.product_id = "test"
            MessageBox.Show("Data belum dipilih", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'Return md
    End Sub

    Public Sub loadData()
        Try
            prodSvr = ClientLibs.InProcFactory.CreateChannel(Of ProductService, IProductService)()
            AddStyleToGrid(dgvProduct)
            dv.Table = prodSvr.GetProduct()
            dgvProduct.DataSource = dv
            dgvProduct.DefaultCellStyle.SelectionBackColor = Color.BurlyWood
            formatGridRoom()
            ClientLibs.InProcFactory.CloseChannel(Me.prodSvr)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub dgvProduct_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick
        MsgBox(dgvProduct.SelectedRows.Count.ToString())
    End Sub


    Private Sub TextBoxSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxSearch.TextChanged
        dv.RowFilter = String.Format(SearchStr, TextBoxSearch.Text)
    End Sub

    Private Sub ButtonSearch_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearch.Click
        TextBoxSearch.Text = ""
        dv.RowFilter = String.Format(SearchStr, TextBoxSearch.Text)
    End Sub

    Private Sub dgvProduct_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvProduct.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim value As String
            value = Me.dgvProduct.Rows(e.RowIndex).Cells("product_id").Value.ToString()
            Me.Parent.Controls.Add(New UserControlProductModify(value))
            Me.Parent.Controls.Remove(Me)
        End If
    End Sub


End Class
