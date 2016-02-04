Imports ProductSvr

Public Class UserControlRoomInput
    Dim viewData As New UserControlRoomData

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If validateForm() = True Then
            Dim roomSvr As Service.RoomService = New Service.RoomService
            Dim rm As New Model.Room()
            rm.room_id = TextBoxId.Text
            rm.room_name = TextBoxName.Text
            Dim mesResult As String
            mesResult = roomSvr.RoomAdd(rm)
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
        ShowList()
    End Sub

    Private Sub ShowList()
        Me.Parent.Controls.Add(viewData)
        Me.Parent.Controls.Remove(Me)
        viewData.Dock = DockStyle.Fill
        viewData.loadData()
    End Sub
End Class
