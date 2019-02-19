Public Class Admin
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BookManagerDataSet1)

    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BookManagerDataSet1.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.BookManagerDataSet1.Users)
        'TODO: This line of code loads data into the 'BookManagerDataSet1.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.BookManagerDataSet1.Books)

    End Sub
End Class