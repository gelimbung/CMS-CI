Imports System.Collections.Generic

Public Class FormLookUp
    Public Property dt As DataTable = New DataTable()
    Public Property columnTable As List(Of HiddenColumn) = New List(Of HiddenColumn)()
    Public Property dv As DataView = New DataView()

    Public Property ReturnValue As String
    Public Property SearchStr As String
    Public Property resValue As String

    Public Sub New(ByVal d As DataTable)

        ' This call is required by the designer.
        InitializeComponent()
        dt = d
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub AddStyleToGrid(ByVal dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue
        'dgv.RowHeadersVisible = False
        dgv.GridColor = Color.Black
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv.AllowUserToResizeRows = False
    End Sub

    Private Sub FormLookUp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.dgv.AutoResizeColumns()
        Me.dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        'dt.TableName = "lookup"
        'dv.Table = dt
        FormatGrid(dgv)
        Me.dv.Table = dt
        dgv.DataSource = dv
        For Each item As HiddenColumn In columnTable
            Me.dgv.Columns(item.ColumnName).Visible = False
        Next

    End Sub

    'Public Overrides Sub Close()
    '    Me.Close()
    '    dt = New DataTable()
    'End Sub


    Private Sub FormatGrid(dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateBlue
        dgv.RowHeadersVisible = False
        dgv.GridColor = Color.Black
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None
        dgv.AllowUserToResizeRows = False
    End Sub


    Private Sub dgv_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellDoubleClick
        If e.RowIndex <> -1 Then

            ' MsgBox(Me.dgv.Rows(e.RowIndex).Cells(ReturnValue).Value.ToString())
            resValue = Me.dgv.Rows(e.RowIndex).Cells(ReturnValue).Value.ToString()
            Me.Close()

        End If
    End Sub

   
   
    Private Sub TextBoxKeyword_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxKeyword.TextChanged
        Me.dv.RowFilter = String.Format(SearchStr, TextBoxKeyword.Text)
     End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.dv.RowFilter = String.Format(SearchStr, "")
    End Sub
End Class


Public Class HiddenColumn
    Public Property ColumnName As String

    'Dim _ColumnName As String = String.Empty

    'Property ColumnName() As String
    '    Get
    '        Return _ColumnName
    '    End Get
    '    Set(ByVal value As String)
    '        _ColumnName = value
    '    End Set
    'End Property

End Class