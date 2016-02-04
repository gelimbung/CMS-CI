Imports ProductSvr

Public Class UserControlRoomModify
    Dim room_id As String
    Dim svrRoom As New Service.RoomService
    Public Sub New(ByVal item As String)
        InitializeComponent() ' This call is required by the Windows Form Designer.
        room_id = item
        setModify()

    End Sub

    Private Sub setModify()
        Dim rm As Model.Room = svrRoom.RecordRoom(room_id)
        TextBoxId.Text = rm.room_id
        TextBoxName.Text = rm.room_name
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If validateForm() = True Then

            Dim roomSvr As Service.RoomService = New Service.RoomService
            Dim rm As New Model.Room()
            rm.room_id = TextBoxId.Text
            rm.room_name = TextBoxName.Text
            Dim mesResult As String
            mesResult = roomSvr.RoomModify(rm, Me.room_id)
            MessageBox.Show(mesResult, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ShowList()
        End If

    End Sub

    Private Function validateForm() As Boolean
        Dim res As Boolean = True
        If String.IsNullOrEmpty(TextBoxId.Text) Then
            MessageBox.Show("Please enter Room Id", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False
        ElseIf String.IsNullOrEmpty(TextBoxName.Text) Then
            MessageBox.Show("Please enter Room Name", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
            res = False

        End If
        Return res
    End Function

  
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim viewData As New UserControlRoomData
        viewData.Dock = DockStyle.Fill
        viewData.loadData()
        Me.Parent.Controls.Add(viewData)
        Me.Parent.Controls.Remove(Me)
        ShowList()
    End Sub

    Private Sub ShowList()
        Dim viewData As New UserControlRoomData
        viewData.Dock = DockStyle.Fill
        viewData.loadData()
        Me.Parent.Controls.Add(viewData)
        Me.Parent.Controls.Remove(Me)
    End Sub
End Class
