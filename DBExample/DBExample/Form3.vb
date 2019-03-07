Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EbooksDataSet.Vouchers' table. You can move, or remove it, as needed.
        Me.VouchersTableAdapter.Fill(Me.EbooksDataSet.Vouchers)
        'TODO: This line of code loads data into the 'EbooksDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.EbooksDataSet.Books)
        Label1.Text = currentUser

        'load listbox with all books this student has checked out 
        'this is a fancy query that uses two tables 
        Dim books = From v In EbooksDataSet.Vouchers, b In EbooksDataSet.Books
                    Where v.UserName = currentUser And v.BookID = b.ID
        For Each checkout In books
            booksListBox.Items.Add(checkout.b.Title)
        Next
    End Sub

    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EbooksDataSet)

    End Sub
End Class