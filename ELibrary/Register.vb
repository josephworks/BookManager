Public Class Register
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EbooksDataSet)

    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EbooksDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)
        GradeLabel.Hide()
        GradeTextBox.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newUser As ebooksDataSet.UsersRow
        newUser = EbooksDataSet.Users.NewUsersRow
        newUser.UserName = TextBox1.Text
        newUser.Password = TextBox2.Text
        newUser.Role = ComboBox1.Text
        EbooksDataSet.Users.AddUsersRow(newUser)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EbooksDataSet)
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Dim newUser As ebooksDataSet.UsersRow
        newUser = EbooksDataSet.Users.NewUsersRow
        newUser.UserName = TextBox1.Text
        newUser.Password = TextBox2.Text
        newUser.Role = ComboBox1.Text
        EbooksDataSet.Users.AddUsersRow(newUser)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EbooksDataSet)
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.ResetText()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "S" Then
            'Show grade level
            GradeTextBox.Show()
            GradeLabel.Show()
        End If
    End Sub
End Class