<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.EbooksDataSet = New ELibrary.ebooksDataSet()
        Me.VouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VouchersTableAdapter = New ELibrary.ebooksDataSetTableAdapters.VouchersTableAdapter()
        Me.TableAdapterManager = New ELibrary.ebooksDataSetTableAdapters.TableAdapterManager()
        Me.BooksTableAdapter = New ELibrary.ebooksDataSetTableAdapters.BooksTableAdapter()
        Me.UsersTableAdapter = New ELibrary.ebooksDataSetTableAdapters.UsersTableAdapter()
        Me.usersListBox = New System.Windows.Forms.ListBox()
        Me.voucherTextBox = New System.Windows.Forms.TextBox()
        Me.booksListBox = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VouchersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.EbooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VouchersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EbooksDataSet
        '
        Me.EbooksDataSet.DataSetName = "ebooksDataSet"
        Me.EbooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VouchersBindingSource
        '
        Me.VouchersBindingSource.DataMember = "Vouchers"
        Me.VouchersBindingSource.DataSource = Me.EbooksDataSet
        '
        'VouchersTableAdapter
        '
        Me.VouchersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.UpdateOrder = ELibrary.ebooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Me.UsersTableAdapter
        Me.TableAdapterManager.VouchersTableAdapter = Me.VouchersTableAdapter
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'UsersTableAdapter
        '
        Me.UsersTableAdapter.ClearBeforeFill = True
        '
        'usersListBox
        '
        Me.usersListBox.FormattingEnabled = True
        Me.usersListBox.Location = New System.Drawing.Point(12, 12)
        Me.usersListBox.Name = "usersListBox"
        Me.usersListBox.Size = New System.Drawing.Size(120, 95)
        Me.usersListBox.TabIndex = 0
        '
        'voucherTextBox
        '
        Me.voucherTextBox.Location = New System.Drawing.Point(315, 12)
        Me.voucherTextBox.Name = "voucherTextBox"
        Me.voucherTextBox.Size = New System.Drawing.Size(100, 20)
        Me.voucherTextBox.TabIndex = 1
        Me.voucherTextBox.Text = "ABC-123-DEF"
        '
        'booksListBox
        '
        Me.booksListBox.FormattingEnabled = True
        Me.booksListBox.Location = New System.Drawing.Point(175, 12)
        Me.booksListBox.Name = "booksListBox"
        Me.booksListBox.Size = New System.Drawing.Size(120, 95)
        Me.booksListBox.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(315, 53)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add Voucher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VouchersDataGridView
        '
        Me.VouchersDataGridView.AutoGenerateColumns = False
        Me.VouchersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VouchersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.VouchersDataGridView.DataSource = Me.VouchersBindingSource
        Me.VouchersDataGridView.Location = New System.Drawing.Point(12, 126)
        Me.VouchersDataGridView.Name = "VouchersDataGridView"
        Me.VouchersDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.VouchersDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "UserName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "UserName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BookID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BookID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Voucher"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Voucher"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.EbooksDataSet
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.EbooksDataSet
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(445, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Edit Books"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.VouchersDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.booksListBox)
        Me.Controls.Add(Me.voucherTextBox)
        Me.Controls.Add(Me.usersListBox)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.EbooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VouchersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EbooksDataSet As ebooksDataSet
    Friend WithEvents VouchersBindingSource As BindingSource
    Friend WithEvents VouchersTableAdapter As ebooksDataSetTableAdapters.VouchersTableAdapter
    Friend WithEvents TableAdapterManager As ebooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents usersListBox As ListBox
    Friend WithEvents voucherTextBox As TextBox
    Friend WithEvents booksListBox As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents VouchersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents UsersTableAdapter As ebooksDataSetTableAdapters.UsersTableAdapter
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As ebooksDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents Button2 As Button
End Class
