Public Class Login
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub RegisterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterToolStripMenuItem.Click
        Register.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Joseph login
        If TextBox6.Text = "Joseph" Then
            If TextBox5.Text = "JosephPass" Then
                If TextBox7.Text = "9630" Then
                    Joseph.Show()
                Else
                    MessageBox.Show("The 2FA Pin you have entered is incorrect!")
                End If
            Else
                MessageBox.Show("Incorrect Username or Password!")
            End If
        Else
            MessageBox.Show("The account that you have entered is not an Joseph or does not exist!")
        End If
    End Sub
End Class
