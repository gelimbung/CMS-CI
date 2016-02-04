Imports ProductSvr
Public Class UserControlProductInput
    Dim prodSvr As Service.IProductService
    Dim uom_code As String
    Dim viewData As New UserControlProductData()
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If validateForm() = True Then
            prodSvr = ClientLibs.InProcFactory.CreateChannel(Of Service.ProductService, Service.IProductService)()
            Dim prod As Model.Product = New Model.Product()
            Dim uom As Model.Uom = New Model.Uom
            prod.product_id = TextBoxId.Text
            prod.product_name = TextBoxName.Text
            uom.uom_code = TextBoxUom.Text
            prod.qty_stock = NumericUpDownQttStock.Value
            prod.product_price = NumericUpDownPrice.Value
            Dim mesRes As String = prodSvr.ProductAdd(prod, uom)
            MessageBox.Show(mesRes, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowList()
            ClientLibs.InProcFactory.CloseChannel(Me.prodSvr)
        End If

    End Sub

    Private Sub ButtonSearachUom_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearachUom.Click
        prodSvr = ClientLibs.InProcFactory.CreateChannel(Of Service.ProductService, Service.IProductService)()
        Dim uomSvr As Service.UomService = New Service.UomService()
        Dim lookupFrm As FormLookUp = New FormLookUp(uomSvr.GetUom())
         lookupFrm.columnTable = New List(Of HiddenColumn)
        'Dim hide As New HiddenColumn
        'hide.ColumnName = "uom_code"
        'hide.ColumnName = "description"
        'lookupFrm.columnTable.Add(hide)
        lookupFrm.SearchStr = "description LIKE '%{0}%'"
        '= "description LIKE '%{0}%'"
        lookupFrm.ReturnValue = "uom_code"
        lookupFrm.ShowDialog(Me)
        TextBoxUom.Text = lookupFrm.resValue
        ClientLibs.InProcFactory.CloseChannel(Me.prodSvr)
    End Sub

    Private Function validateForm() As Boolean
        Dim res As Boolean = True
        If String.IsNullOrEmpty(TextBoxId.Text) Then
            MessageBox.Show("Please enter Product Id", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxUom.Text) Then
            MessageBox.Show("Please enter Uom Code", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxName.Text) Then
            MessageBox.Show("Please enter Product Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        End If
        Return res
    End Function

    Private Sub ShowList()
        Me.Parent.Controls.Add(viewData)
        Me.Parent.Controls.Remove(Me)
        viewData.Dock = DockStyle.Fill
        viewData.loadData()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        ShowList()
    End Sub
End Class
