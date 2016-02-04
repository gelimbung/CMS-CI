
Public Class Form1

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        Dim obj As New HmisTemplate.AuthHmis()

        If obj.AuthLogin(txtLogin.Text.Trim, txtPwd.Text.Trim) Then
            Dim frmMenu As New HmisTemplate.HMISMenu()
            frmMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("Login gagal !", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub txtPwd_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtPwd.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

End Class
