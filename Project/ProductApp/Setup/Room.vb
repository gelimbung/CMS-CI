Imports System.Data
Imports ProductSvr.Service
Public Class Room
    Dim dtRoom As DataTable
    Dim dvRoom As DataView

    Dim roomSvr As ProductSvr.Service.IRoomService

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        roomSvr = ClientLibs.InProcFactory.CreateChannel(Of ProductSvr.Service.RoomService, ProductSvr.Service.IRoomService)()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ToolStripButtonRoomAdd_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonRoomAdd.Click
        'Dim roomFrm As New RoomForm
        'roomFrm.MdiParent = Me.MdiParent
        'roomFrm.Show()
        'Me.Close()




    End Sub

    Private Sub formatGridRoom()
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



    End Sub


    Private Sub loadData()
        Try
            'Dim testDt As DataTable = New DataTable()
            'testDt = roomService.GetRoom
            'For Each row As DataRow In testDt.Rows
            '    MsgBox("1")
            'Next



            AddStyleToGrid(dgvRoom)
            dtRoom = New DataTable()
            dtRoom = roomSvr.GetRoom()
            dgvRoom.DataSource = dtRoom
            dgvRoom.DefaultCellStyle.SelectionBackColor = Color.BurlyWood
            formatGridRoom()
            ClientLibs.InProcFactory.CloseChannel(Me.roomSvr)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub Room_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadData()
    End Sub


    Private Sub ToolStripButtonRoomDelete_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonRoomDelete.Click

    End Sub
End Class