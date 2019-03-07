<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.booksListBox = New System.Windows.Forms.ListBox()
        Me.EbooksDataSet = New DBExample.ebooksDataSet()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New DBExample.ebooksDataSetTableAdapters.BooksTableAdapter()
        Me.TableAdapterManager = New DBExample.ebooksDataSetTableAdapters.TableAdapterManager()
        Me.VouchersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VouchersTableAdapter = New DBExample.ebooksDataSetTableAdapters.VouchersTableAdapter()
        CType(Me.EbooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VouchersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'booksListBox
        '
        Me.booksListBox.FormattingEnabled = True
        Me.booksListBox.Location = New System.Drawing.Point(3, 55)
        Me.booksListBox.Name = "booksListBox"
        Me.booksListBox.Size = New System.Drawing.Size(120, 95)
        Me.booksListBox.TabIndex = 1
        '
        'EbooksDataSet
        '
        Me.EbooksDataSet.DataSetName = "ebooksDataSet"
        Me.EbooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.EbooksDataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.UpdateOrder = DBExample.ebooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.VouchersTableAdapter = Me.VouchersTableAdapter
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
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.booksListBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.EbooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VouchersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents booksListBox As ListBox
    Friend WithEvents EbooksDataSet As ebooksDataSet
    Friend WithEvents BooksBindingSource As BindingSource
    Friend WithEvents BooksTableAdapter As ebooksDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As ebooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VouchersTableAdapter As ebooksDataSetTableAdapters.VouchersTableAdapter
    Friend WithEvents VouchersBindingSource As BindingSource
End Class
