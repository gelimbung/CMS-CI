Imports ProductSvr.Service
Public Class UserControlRoom
    Dim viewData As New UserControlRoomData
    Dim uc As UserControl
    Private Sub UserControlRoom_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        PanelMain.Controls.Clear()
        uc = viewData
        uc.Dock = DockStyle.Fill
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButtonList_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonList.Click
        PanelMain.Controls.Clear()
        uc = viewData
        uc.Dock = DockStyle.Fill
        viewData.loadData()
        uc.Dock = DockStyle.Fill
        Me.PanelMain.Controls.Add(uc)
    End Sub

    Private Sub ToolStripButtonAdd_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonAdd.Click
        PanelMain.Controls.Clear()
        Me.uc = New UserControlRoomInput
        Me.PanelMain.Controls.Add(uc)
        uc.Dock = DockStyle.Fill
        viewData.dgvRoom.ClearSelection()
    End Sub

    Private Sub ToolStripButtonEdit_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonEdit.Click
        If viewData.dgvRoom.SelectedRows.Count > 0 Then
            Me.PanelMain.Controls.Clear()
            Dim value As String = viewData.dgvRoom.CurrentRow.Cells("room_id").Value.ToString()
            uc = New UserControlRoomModify(value)
            Me.PanelMain.Controls.Add(uc)
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ToolStripButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButtonDelete.Click
        If viewData.dgvRoom.SelectedRows.Count > 0 Then
            If MsgBox("Are you sure delete data ?", MsgBoxStyle.YesNo, "Title") = MsgBoxResult.Yes Then
                Dim svrRoom As New RoomService()
                Dim msg As String = svrRoom.RoomDelete(viewData.dgvRoom.CurrentRow.Cells("room_id").Value.ToString())
                MessageBox.Show("Data sucessfully removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                viewData.loadData()
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
