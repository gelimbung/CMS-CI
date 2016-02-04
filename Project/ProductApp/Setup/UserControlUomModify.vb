Imports ProductSvr

Public Class UserControlUomModify
    Dim uom_code As String
    Dim svr As New Service.UomService()
    Dim viewData As New UserControlUomData()
    Public Sub New(ByVal code As String)

        ' This call is required by the designer.
        InitializeComponent()
        uom_code = code
        setModify()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub setModify()
        Dim rm As Model.Uom = svr.RecordUom(uom_code)
        TextBoxCode.Text = rm.uom_code
        TextBoxDesc.Text = rm.description
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If validateForm() = True Then
            Dim UomSvr As Service.UomService = New Service.UomService
            Dim rm As New Model.Uom()
            rm.uom_code = TextBoxCode.Text
            rm.description = TextBoxDesc.Text
            Dim mesResult As String
            mesResult = svr.UomModify(rm, uom_code)
            MessageBox.Show(mesResult, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowList()
        End If

    End Sub

    Private Function validateForm() As Boolean
        Dim res As Boolean = True
        If String.IsNullOrEmpty(TextBoxCode.Text) Then
            MessageBox.Show("Please enter Room Id", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxDesc.Text) Then
            MessageBox.Show("Please enter Room Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
