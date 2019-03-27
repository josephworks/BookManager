Public Class Login
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EbooksDataSet)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EbooksDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)
        Dim logins = From user In EbooksDataSet.Users
                     Where user.UserName = userNameTextBox.Text
        If logins.Count = 1 AndAlso logins(0).Password = passwordTextBox.Text Then
            currentUser = logins(0).UserName
            If logins(0).Role = "T" Then
                Teacher.Show()
            End If
            If logins(0).Role = "S" Then
                Student.Show()
            End If
        Else
            MessageBox.Show("Login Failed", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Register.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Register.ShowDialog()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)
        Dim logins = From user In EbooksDataSet.Users
                     Where user.UserName = userNameTextBox.Text
        If logins.Count = 1 AndAlso logins(0).Password = passwordTextBox.Text Then
            currentUser = logins(0).UserName
            If logins(0).Role = "T" Then
                Dim f2 As New Teacher
                f2.ShowDialog()
            End If
            If logins(0).Role = "S" Then
                Dim f3 As New Student
                f3.ShowDialog()
            End If

        Else
            MessageBox.Show("Login Failed", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        userNameTextBox.Clear()
        passwordTextBox.Clear()
    End Sub
End Class
