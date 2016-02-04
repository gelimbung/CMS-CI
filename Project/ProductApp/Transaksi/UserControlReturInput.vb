Imports ProductSvr
Public Class UserControlReturInput
    Dim listOfProduct As List(Of Model.OrderProduct) = New List(Of Model.OrderProduct)()
    Dim supplier As Integer
    Dim svrProd As Service.ProductService
    Dim svrSup As Service.SupplierService
    Dim svrOrder As Service.OrderService

    Dim lastest_qtt As Integer
    Dim lastest_price As Integer
    Dim Lastest_uom As String
    Dim lookupFrm As FormLookUp

    Dim isInsert As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        AddStyleToGrid(dgvProdTransact)
        FormatGrid()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ButtonSearchSupplier_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearchSupplier.Click
        svrSup = New Service.SupplierService()
        lookupFrm = New FormLookUp(svrSup.GetSupplier())
        lookupFrm.SearchStr = "supplier_name LIKE '%{0}%'"
        lookupFrm.columnTable = New List(Of HiddenColumn)
        'Dim hide As New HiddenColumn
        'hide.ColumnName = "uom_code"
        'hide.ColumnName = "description"
        'lookupFrm.columnTable.Add(hide)
        lookupFrm.ReturnValue = "supplier_id"
        lookupFrm.ShowDialog(Me)
        TextBoxSupplier.Text = lookupFrm.resValue
        TextBoxSupplier.Focus()
        NumericUpDownQtt.Value = 0
        lookupFrm = Nothing

    End Sub

    Private Sub ButtonSearchProduct_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearchProduct.Click
        svrProd = New Service.ProductService()
        lookupFrm = New FormLookUp(svrProd.GetProduct())
        lookupFrm.SearchStr = "product_name LIKE '%{0}%'"
        lookupFrm.columnTable = New List(Of HiddenColumn)
        'Dim hide As New HiddenColumn
        'hide.ColumnName = "uom_code"
        'hide.ColumnName = "description"
        'lookupFrm.columnTable.Add(hide)
        lookupFrm.ReturnValue = "product_id"
        lookupFrm.ShowDialog(Me)
        TextBoxProduct.Text = lookupFrm.resValue
        TextBoxProduct.Focus()
        NumericUpDownQtt.Value = 0
        lookupFrm = Nothing
    End Sub

    Private Sub TextBoxSupplier_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxSupplier.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            svrSup = New Service.SupplierService()
            Dim supModel As Model.Supplier = svrSup.RecordSupplier(TextBoxSupplier.Text)
            If String.IsNullOrEmpty(supModel.supplier_name) Then
                MessageBox.Show("Supplier Not Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxSupplier.Text = ""
                TextBoxSupplier.Focus()
            Else
                TextBoxSupplierName.Text = supModel.supplier_name
            End If
        End If
    End Sub

    Private Sub TextBoxProduct_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxProduct.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            svrProd = New Service.ProductService()
            Dim prodModel As Model.Product = svrProd.recordProduct(TextBoxProduct.Text)
            If String.IsNullOrEmpty(prodModel.product_name) Then
                MessageBox.Show("Product Not Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TextBoxProduct.Text = ""
                TextBoxProduct.Focus()
            Else
                TextBoxProductName.Text = prodModel.product_name
                lastest_qtt = NumericUpDownQtt.Value
                lastest_price = prodModel.product_price
                Lastest_uom = prodModel.uom_code
            End If
        End If
    End Sub

    Private Sub FormatGrid()
        dgvProdTransact.ColumnCount = 5
        dgvProdTransact.Columns(0).Name = "product_id"
        dgvProdTransact.Columns(0).HeaderText = "Product Id"
        dgvProdTransact.Columns(0).Width = "200"
        dgvProdTransact.Columns(1).Name = "uom_code"
        dgvProdTransact.Columns(1).HeaderText = "Uom Code"
        dgvProdTransact.Columns(1).Width = "150"
        dgvProdTransact.Columns(2).Name = "product_name"
        dgvProdTransact.Columns(2).HeaderText = "Product Name"
        dgvProdTransact.Columns(2).Width = "400"
        dgvProdTransact.Columns(3).Name = "qty_stock"
        dgvProdTransact.Columns(3).HeaderText = "Qtt"
        dgvProdTransact.Columns(3).Width = "150"
        dgvProdTransact.Columns(4).Name = "product_price"
        dgvProdTransact.Columns(4).HeaderText = "Price"
        dgvProdTransact.Columns(4).Width = "200"
    End Sub

    Private Sub addItem(ByVal row As Object())
        dgvProdTransact.Rows.Add(row)
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

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If validateFormItem() = True Then
            Dim idx As Integer = -1

            For Each row As DataGridViewRow In dgvProdTransact.Rows
                If row.Cells.Item("product_id").Value.ToString() = TextBoxProduct.Text Then
                    idx = row.Index
                    Exit For
                End If
            Next

            If isInsert = True Then
                If idx = -1 Then
                    addItem(New Object() {TextBoxProduct.Text, Lastest_uom, TextBoxProductName.Text, NumericUpDownQtt.Value, lastest_price})
                    ClearFormProduct()
                    idx = -1
                Else
                    MessageBox.Show("Product already exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                If idx <> -1 And (NumericUpDownQtt.Value = CInt(dgvProdTransact.Rows(idx).Cells("qty_stock").Value)) Then
                    MessageBox.Show("Data not modified", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    dgvProdTransact.Rows(idx).Cells.Item("qty_stock").Value = NumericUpDownQtt.Value
                    ClearFormProduct()
                End If
            End If
        End If
    End Sub

    Private Function validateFormItem() As Boolean
        Dim res As Boolean = True
        If String.IsNullOrEmpty(TextBoxSupplier.Text) Then
            MessageBox.Show("Please enter supplier", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxSupplierName.Text) Then
            MessageBox.Show("Please enter supplier", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxProduct.Text) Then
            MessageBox.Show("Please enter product", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxProductName.Text) Then
            MessageBox.Show("Please enter product", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(NumericUpDownQtt.Text) Then
            MessageBox.Show("Please enter qty value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf (NumericUpDownQtt.Value < 1) Then
            MessageBox.Show("Please enter qty value", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        End If
        Return res
    End Function

    Private Function validateTransaction() As Boolean
        Dim res As Boolean = True
        If String.IsNullOrEmpty(TextBoxSupplier.Text) Then
            MessageBox.Show("Please enter supplier", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxSupplierName.Text) Then
            MessageBox.Show("Please enter supplier", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        End If
        Return res
    End Function


    Private Sub ButtonSaveTransaction_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSaveTransaction.Click
        svrOrder = New Service.OrderService()
        Dim order As New Model.Order()
        order.order_date = DateTimePickerOrder.Text
        order.supplier_id = Convert.ToInt16(TextBoxSupplier.Text)
        For Each r As DataGridViewRow In dgvProdTransact.Rows
            Dim prod As Model.OrderProduct = New Model.OrderProduct()
            prod.product_id = r.Cells(0).Value
            prod.qty = r.Cells(3).Value
            prod.product_price = r.Cells(4).Value
            listOfProduct.Add(prod)
        Next
        Dim mesRes As String = svrOrder.OrderAdd(order, listOfProduct)
        MessageBox.Show(mesRes, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearForm()
    End Sub

    Private Sub ClearForm()
        TextBoxSupplier.Text = ""
        TextBoxSupplierName.Text = ""
        TextBoxProductName.Text = ""
        TextBoxProduct.Text = ""
        TextBoxProductName.Text = ""
        NumericUpDownQtt.Value = 0
        dgvProdTransact.Rows.Clear()
    End Sub

    Private Sub ClearFormProduct()
        TextBoxProduct.Text = ""
        TextBoxProductName.Text = ""
        NumericUpDownQtt.Value = 0
        TextBoxProduct.Focus()
        isInsert = True
        LabelStatus.Text = "Inserting...."
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        If dgvProdTransact.SelectedRows.Count > 0 Then
            isInsert = False
            LabelStatus.Text = "Editing...."
            TextBoxProduct.Text = dgvProdTransact.SelectedCells("0").Value.ToString()
            TextBoxProductName.Text = dgvProdTransact.SelectedCells("2").Value.ToString()
            NumericUpDownQtt.Value = CInt(dgvProdTransact.SelectedCells("3").Value.ToString())
            NumericUpDownQtt.Focus()
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        ClearFormProduct()
    End Sub
End Class
