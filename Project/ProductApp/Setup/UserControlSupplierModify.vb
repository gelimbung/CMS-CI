Imports ProductSvr
Public Class UserControlSupplierModify
    Dim supplier_id As Integer
    Dim svrSupplier As New Service.SupplierService()
    Dim suppSvr As Service.SupplierService = New Service.SupplierService()
    Dim viewData As New UserControlSupplierData()
    Public Sub New(ByVal id As Integer)
        supplier_id = id
        ' This call is required by the designer.
        InitializeComponent()
        setModify()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub setModify()
        Dim rm As Model.Supplier = suppSvr.RecordSupplier(supplier_id)
        TextBoxName.Text = rm.supplier_name
        TextBoxAddress.Text = rm.address
        TextBoxEmail.Text = rm.email
        TextBoxPhone.Text = rm.phone
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If validateForm() = True Then
            Dim suppMod As Model.Supplier = New Model.Supplier()
            suppMod.supplier_name = TextBoxName.Text
            suppMod.address = TextBoxAddress.Text
            suppMod.email = TextBoxEmail.Text
            suppMod.phone = TextBoxPhone.Text
            suppMod.supplier_id = supplier_id
            Dim mesRes As String = suppSvr.SupplierModify(suppMod)
            MessageBox.Show(mesRes, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowList()
        End If
    End Sub

    Private Function validateForm() As Boolean
        Dim res As Boolean = True
        If String.IsNullOrEmpty(TextBoxName.Text) Then
            MessageBox.Show("Please enter name of supplier", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxAddress.Text) Then
            MessageBox.Show("Please enter address", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxEmail.Text) Then
            MessageBox.Show("Please enter email", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxPhone.Text) Then
            MessageBox.Show("Please enter phone", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
