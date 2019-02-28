Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Register.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Admin login
        If TextBox6.Text = "Admin" Then
            If TextBox5.Text = "AdminPass" Then
                If TextBox7.Text = "9630" Then
                    Admin.Show()
                Else
                    MessageBox.Show("The 2FA Pin you have entered is incorrect!")
                End If
            Else
                MessageBox.Show("Incorrect Username or Password!")
            End If
        Else
            MessageBox.Show("The account that you have entered is not an Admin or does not exist!")
        End If
    End Sub
End Class
