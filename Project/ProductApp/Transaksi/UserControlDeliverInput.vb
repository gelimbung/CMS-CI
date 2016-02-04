Imports ProductSvr
Public Class UserControlDeliverInput
    Dim listOfProduct As List(Of Model.DeliverProduct) = New List(Of Model.DeliverProduct)()
    Dim supplier As Integer
    Dim svrProd As Service.ProductService
    Dim svrRoom As Service.RoomService
    Dim svrDeliver As Service.DeliverService

    Dim dtRoom As DataTable = New DataTable()
    Dim lastest_qtt As Integer
    Dim lastest_price As Integer
    Dim Lastest_uom As String
    Dim lookupFrm As FormLookUp


    Private Sub ButtonSearchSupplier_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearchSupplier.Click
        svrRoom = New Service.RoomService()
        lookupFrm = New FormLookUp(svrRoom.GetRoom())
        lookupFrm.columnTable = New List(Of HiddenColumn)
        'Dim hide As New HiddenColumn
        'hide.ColumnName = "uom_code"
        'hide.ColumnName = "description"
        'lookupFrm.columnTable.Add(hide)
        lookupFrm.ReturnValue = "room_id"
        lookupFrm.ShowDialog(Me)

        TextBoxRoom.Text = lookupFrm.resValue
        TextBoxRoom.Focus()
        SetSupplierValue()
        NumericUpDownQtt.Value = 0
        lookupFrm = Nothing

    End Sub

    Private Sub ButtonSearchProduct_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearchProduct.Click
        svrProd = New Service.ProductService()
        lookupFrm = New FormLookUp(svrProd.GetProduct())
        lookupFrm.columnTable = New List(Of HiddenColumn)
        'Dim hide As New HiddenColumn
        'hide.ColumnName = "uom_code"
        'hide.ColumnName = "description"
        'lookupFrm.columnTable.Add(hide)
        lookupFrm.ReturnValue = "product_id"
        lookupFrm.ShowDialog(Me)

        TextBoxProduct.Text = lookupFrm.resValue
        TextBoxProduct.Focus()
        SetProductValue()
        NumericUpDownQtt.Value = 0
        lookupFrm = Nothing
     End Sub

    Private Sub TextBoxSupplier_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxRoom.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then
            SetSupplierValue()
        End If
    End Sub

    Private Sub SetSupplierValue()
        svrRoom = New Service.RoomService()
        Dim rmModel As Model.Room = svrRoom.RecordRoom(TextBoxRoom.Text)
        If String.IsNullOrEmpty(rmModel.room_name) Then
            MessageBox.Show("Supplier Not Found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBoxRoom.Text = ""
            TextBoxRoom.Focus()
        Else
            TextBoxRoomName.Text = rmModel.room_name
        End If
    End Sub

    Private Sub SetProductValue()
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
    End Sub

    Private Sub TextBoxProduct_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxProduct.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SetProductValue()
        End If
    End Sub

    Private Sub addItem()
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
        dgvProdTransact.Columns(3).HeaderText = "Qtt Stock"
        dgvProdTransact.Columns(3).Width = "150"
        dgvProdTransact.Columns(4).Name = "product_price"
        dgvProdTransact.Columns(4).HeaderText = "Price"
        dgvProdTransact.Columns(4).Width = "200"

        Dim row As Object() = New Object() {TextBoxProduct.Text, Lastest_uom, TextBoxProductName.Text, NumericUpDownQtt.Value, lastest_price}
        dgvProdTransact.Rows.Add(row)
        TextBoxProduct.Text = ""
        TextBoxProductName.Text = ""
        NumericUpDownQtt.Value = 0

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
            AddStyleToGrid(dgvProdTransact)
            Dim rowIdx As Integer
            Dim found As Boolean = False
            If CInt(dgvProdTransact.RowCount.ToString()) > 0 Then
                For Each row As DataGridViewRow In dgvProdTransact.Rows
                    If row.Cells.Item("product_id").Value = TextBoxProduct.Text Then
                        'rowindex = row.Index.ToString()
                        rowIdx = row.Index
                        row.Cells.Item("qty_stock").Value = row.Cells.Item("qty_stock").Value + CInt(NumericUpDownQtt.Value.ToString)
                        'found = True
                        'Dim actie As String = row.Cells("PRICE").Value.ToString()
                        'MsgBox(actie)
                        'Exit For
                    Else
                        addItem()
                    End If
                Next
            Else
                addItem()
            End If
        End If

    End Sub

    Private Function validateFormItem() As Boolean
        Dim res As Boolean = True
        If String.IsNullOrEmpty(TextBoxRoom.Text) Then
            MessageBox.Show("Please enter supplier", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxRoomName.Text) Then
            MessageBox.Show("Please enter supplier", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxProduct.Text) Then
            MessageBox.Show("Please enter product", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxProductName.Text) Then
            MessageBox.Show("Please enter product", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(NumericUpDownQtt.Text) Then
            MessageBox.Show("Please enter Qty", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        End If
        Return res
    End Function

    Private Function validateTransaction() As Boolean
        Dim res As Boolean = True
        If String.IsNullOrEmpty(TextBoxRoom.Text) Then
            MessageBox.Show("Please enter supplier", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxRoomName.Text) Then
            MessageBox.Show("Please enter supplier", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        End If
        Return res
    End Function


    Private Sub ButtonSaveTransaction_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSaveTransaction.Click
        'If validateTransaction() = True Then
        svrDeliver = New Service.DeliverService()
        Dim deliver As New Model.Deliver()
        deliver.room_id = TextBoxRoom.Text
        For Each r As DataGridViewRow In dgvProdTransact.Rows
            Dim prod As Model.DeliverProduct = New Model.DeliverProduct()
            prod.product_id = r.Cells(0).Value
            prod.qty = r.Cells(3).Value
            listOfProduct.Add(prod)
        Next

        MessageBox.Show(svrDeliver.DeliverAdd(deliver, listOfProduct), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearForm()
    End Sub

    Private Sub ClearForm()
        TextBoxRoom.Text = ""
        TextBoxRoomName.Text = ""
        TextBoxProductName.Text = ""
        TextBoxProduct.Text = ""
        TextBoxProductName.Text = ""
        NumericUpDownQtt.Value = 0
        dgvProdTransact.Rows.Clear()
    End Sub
End Class
