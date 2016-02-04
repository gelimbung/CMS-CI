Imports ProductSvr
Public Class UserControlDeliverData
    Dim SearchStr As String = "room_name LIKE '%{0}%'"

    Dim dv As New DataView()

    Private Sub formatGridRoom()
        dgv.Columns("delivery_id").Visible = True
        dgv.Columns("delivery_id").HeaderText = "No"
        dgv.Columns("delivery_date").HeaderText = "Delivery Date"
        dgv.Columns("delivery_date").Width = 200
        dgv.Columns("room_name").HeaderText = "Room Name"
        dgv.Columns("room_name").Width = 600
        dgv.Columns("room_id").HeaderText = "Room Id"
        dgv.Columns("room_id").Width = 150
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
            'Dim testDt As DataTable = New DataTable()
            'testDt = roomService.GetRoom
            'For Each row As DataRow In testDt.Rows
            '    MsgBox("1")
            'Next
            AddStyleToGrid(dgv)
            Dim dlvSvr As Service.IDeliverService = ClientLibs.InProcFactory.CreateChannel(Of Service.DeliverService, Service.IDeliverService)()
            dv.Table = dlvSvr.GetDeliver()
            dgv.DataSource = dv
            dgv.DefaultCellStyle.SelectionBackColor = Color.BurlyWood
            formatGridRoom()
            ClientLibs.InProcFactory.CloseChannel(dlvSvr)
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub ToolStripButtonDelete_Click(sender As System.Object, e As System.EventArgs)
        If dgv.SelectedRows.Count > 0 Then
            If MsgBox("Are you sure delete data ?", MsgBoxStyle.YesNo, "Title") = MsgBoxResult.Yes Then
                Dim svrOrder As New Service.DeliverService()
                Dim msg As String = svrOrder.DeliveryDelete(Convert.ToInt16(dgv.SelectedCells("0").Value.ToString()))
                MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadData()
            End If
        Else
            MessageBox.Show("Please select data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxSearch.TextChanged
        Me.dv.RowFilter = String.Format(Me.SearchStr, TextBoxSearch.Text)
    End Sub

    Private Sub ButtonSearch_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSearch.Click
        Me.dv.RowFilter = String.Format(Me.SearchStr, "")
    End Sub
End Class
