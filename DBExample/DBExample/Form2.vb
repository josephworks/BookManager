Public Class Form2
    Private Sub VouchersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VouchersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EbooksDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EbooksDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.EbooksDataSet.Books)
        'TODO: This line of code loads data into the 'EbooksDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)
        'TODO: This line of code loads data into the 'EbooksDataSet.Vouchers' table. You can move, or remove it, as needed.
        Me.VouchersTableAdapter.Fill(Me.EbooksDataSet.Vouchers)

        'Load all books into listbox
        Dim books = From b In EbooksDataSet.Books
        For Each book In books
            booksListBox.Items.Add(book.Title)
        Next

        'Load all users into listbox
        Dim users = From u In EbooksDataSet.Users
        For Each user In users
            usersListBox.Items.Add(user.UserName)
        Next
        'Select one of each
        booksListBox.SelectedIndex = 0
        usersListBox.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Find the selected book
        Dim books = From b In EbooksDataSet.Books
                    Where b.Title = booksListBox.SelectedItem
        Dim bookID As Integer
        bookID = books(0).ID

        'Find the selected user
        Dim users = From u In EbooksDataSet.Users
                    Where u.UserName = usersListBox.SelectedItem
        Dim userName As String
        userName = users(0).UserName

        'Add this voucher to the vouchers table
        Dim newVoucher As ebooksDataSet.VouchersRow
        newVoucher = EbooksDataSet.Vouchers.NewVouchersRow
        newVoucher.BookID = bookID
        newVoucher.UserName = userName
        newVoucher.Voucher = voucherTextBox.Text
        EbooksDataSet.Vouchers.AddVouchersRow(newVoucher)

        Me.Validate()
        Me.VouchersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EbooksDataSet)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EditBooks.ShowDialog()
    End Sub
End Class