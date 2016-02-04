Imports ProductSvr.Service
Public Class UserControlRoomData
    Public Property dt As DataTable = New DataTable()
    Public Property dv As DataView = New DataView()

    Dim dtRoom As DataTable
    Dim uc As UserControl
    Dim SearchStr As String = "room_name LIKE '%{0}%'"

    Private Sub formatGridRoom()
        dgvRoom.Columns("number").HeaderText = "#"
        dgvRoom.Columns("number").Width = 50
        dgvRoom.Columns("room_id").HeaderText = "Room ID"
        dgvRoom.Columns("room_id").Width = 200
        dgvRoom.Columns("room_name").HeaderText = "Room Name"
        dgvRoom.Columns("room_name").Width = 600
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
            Dim roomSrv As IRoomService = ClientLibs.InProcFactory.CreateChannel(Of RoomService, IRoomService)()
            AddStyleToGrid(dgvRoom)
            dv.Table = roomSrv.GetRoom()
            dgvRoom.DataSource = dv
            dgvRoom.DefaultCellStyle.SelectionBackColor = Color.BurlyWood
            formatGridRoom()
            ClientLibs.InProcFactory.CloseChannel(roomSrv)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub dgvRoom_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRoom.CellDoubleClick
        If e.RowIndex <> -1 Then
            Dim value As String
            value = Me.dgvRoom.Rows(e.RowIndex).Cells("room_id").Value.ToString()
            uc = New UserControlRoomModify(value)
            Me.Parent.Controls.Add(uc)
            Me.Parent.Controls.Remove(Me)
        End If
    End Sub

    Public Sub rowCount(ByRef rCount As String)
        rCount = dgvRoom.SelectedRows.Count
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxSearch.TextChanged
        Me.dv.RowFilter = String.Format(Me.SearchStr, TextBoxSearch.Text)
    End Sub

    Private Sub ButtonSearch_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearch.Click
        TextBoxSearch.Text = ""
        Me.dv.RowFilter = String.Format(Me.SearchStr, TextBoxSearch.Text)
    End Sub
End Class
