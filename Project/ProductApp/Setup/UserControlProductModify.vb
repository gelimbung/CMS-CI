Imports ProductSvr
Public Class UserControlProductModify
    Dim prodSvr As Service.ProductService = New Service.ProductService()
    Dim uom_code As String
    Dim product_id As String
    Dim viewData As New UserControlProductData()

    Public Sub New(ByVal id As String)

        ' This call is required by the designer.
        InitializeComponent()
        product_id = id
        ' Add any initialization after the InitializeComponent() call.
        setModify()
    End Sub

    Private Sub setModify()
        Dim rm As Model.Product = prodSvr.recordProduct(product_id)
        TextBoxName.Text = rm.product_name
        TextBoxId.Text = rm.product_id
        TextBoxUom.Text = rm.uom_code
        NumericUpDownQttStock.Value = rm.qty_stock
        NumericUpDownPrice.Value = rm.product_price
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If validateForm() = True Then
            Dim prod As Model.Product = New Model.Product()
            Dim uom As Model.Uom = New Model.Uom
            prod.product_id = TextBoxId.Text
            prod.product_name = TextBoxName.Text
            uom.uom_code = TextBoxUom.Text
            prod.qty_stock = NumericUpDownQttStock.Value
            prod.product_price = NumericUpDownPrice.Value
            Dim mesRes = prodSvr.ProductModify(prod, uom, product_id)
            MessageBox.Show(mesRes, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowList()
        End If


        'If TextBoxId.Text <> "" And TextBoxUom.Text <> "" And TextBoxName.Text <> "" Then
        '    Dim prod As Model.Product = New Model.Product()
        '    Dim uom As Model.Uom = New Model.Uom
        '    prod.product_id = TextBoxId.Text
        '    prod.product_name = TextBoxName.Text
        '    uom.uom_code = TextBoxUom.Text
        '    prod.qtt_stock = NumericUpDownQttStock.Value
        '    prod.product_price = NumericUpDownPrice.Value
        '    'suppSvr.ProductAdd(prod, uom)
        '    MsgBox("Berhasil")
        'Else

        'End If
    End Sub

    Private Sub ButtonSearachUom_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearachUom.Click

        Dim uomSvr As Service.UomService = New Service.UomService()
        Dim lookupFrm As FormLookUp = New FormLookUp(uomSvr.GetUom())
        lookupFrm.columnTable = New List(Of HiddenColumn)
        'Dim hide As New HiddenColumn
        'hide.ColumnName = "uom_code"
        'hide.ColumnName = "description"
        'lookupFrm.columnTable.Add(hide)
        lookupFrm.ReturnValue = "uom_code"
        lookupFrm.ShowDialog(Me)
        TextBoxUom.Text = lookupFrm.resValue
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
