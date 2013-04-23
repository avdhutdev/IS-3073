<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.DataTable1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RnrBooksDataSet1 = New inClass9.RnrBooksDataSet1
        Me.DataTable1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter1 = New inClass9.RnrBooksDataSet1TableAdapters.BooksTableAdapter
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RnrBooksDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2TableAdapter = New inClass9.RnrBooksDataSet1TableAdapters.DataTable2TableAdapter
        Me.ISBNDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AuthorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PublisherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubjectCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ShelfLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FictionDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.SubjectCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SubjectDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnrBooksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RnrBooksDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ISBNDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.AuthorDataGridViewTextBoxColumn, Me.PublisherDataGridViewTextBoxColumn, Me.SubjectCodeDataGridViewTextBoxColumn, Me.ShelfLocationDataGridViewTextBoxColumn, Me.FictionDataGridViewCheckBoxColumn, Me.SubjectCodeDataGridViewTextBoxColumn1, Me.SubjectDataGridViewTextBoxColumn, Me.Subject})
        Me.DataGridView1.DataSource = Me.DataTable2BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(99, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(893, 325)
        Me.DataGridView1.TabIndex = 0
        '
        'DataTable1BindingSource3
        '
        Me.DataTable1BindingSource3.DataMember = "DataTable1"
        Me.DataTable1BindingSource3.DataSource = Me.RnrBooksDataSet1BindingSource
        '
        'DataTable1BindingSource4
        '
        Me.DataTable1BindingSource4.DataMember = "DataTable1"
        Me.DataTable1BindingSource4.DataSource = Me.RnrBooksDataSet1
        '
        'RnrBooksDataSet1
        '
        Me.RnrBooksDataSet1.DataSetName = "RnrBooksDataSet1"
        Me.RnrBooksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource2
        '
        Me.DataTable1BindingSource2.DataMember = "DataTable1"
        Me.DataTable1BindingSource2.DataSource = Me.RnrBooksDataSet1
        '
        'DataTable1BindingSource1
        '
        Me.DataTable1BindingSource1.DataMember = "DataTable1"
        Me.DataTable1BindingSource1.DataSource = Me.RnrBooksDataSet1
        '
        'BooksBindingSource1
        '
        Me.BooksBindingSource1.DataMember = "Books"
        Me.BooksBindingSource1.DataSource = Me.RnrBooksDataSet1
        '
        'BooksTableAdapter1
        '
        Me.BooksTableAdapter1.ClearBeforeFill = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.RnrBooksDataSet1
        '
        'RnrBooksDataSet1BindingSource
        '
        Me.RnrBooksDataSet1BindingSource.DataSource = Me.RnrBooksDataSet1
        Me.RnrBooksDataSet1BindingSource.Position = 0
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.RnrBooksDataSet1
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'ISBNDataGridViewTextBoxColumn
        '
        Me.ISBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.HeaderText = "ISBN"
        Me.ISBNDataGridViewTextBoxColumn.Name = "ISBNDataGridViewTextBoxColumn"
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'AuthorDataGridViewTextBoxColumn
        '
        Me.AuthorDataGridViewTextBoxColumn.DataPropertyName = "Author"
        Me.AuthorDataGridViewTextBoxColumn.HeaderText = "Author"
        Me.AuthorDataGridViewTextBoxColumn.Name = "AuthorDataGridViewTextBoxColumn"
        '
        'PublisherDataGridViewTextBoxColumn
        '
        Me.PublisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.HeaderText = "Publisher"
        Me.PublisherDataGridViewTextBoxColumn.Name = "PublisherDataGridViewTextBoxColumn"
        '
        'SubjectCodeDataGridViewTextBoxColumn
        '
        Me.SubjectCodeDataGridViewTextBoxColumn.DataPropertyName = "Subject_Code"
        Me.SubjectCodeDataGridViewTextBoxColumn.HeaderText = "Subject_Code"
        Me.SubjectCodeDataGridViewTextBoxColumn.Name = "SubjectCodeDataGridViewTextBoxColumn"
        '
        'ShelfLocationDataGridViewTextBoxColumn
        '
        Me.ShelfLocationDataGridViewTextBoxColumn.DataPropertyName = "Shelf_Location"
        Me.ShelfLocationDataGridViewTextBoxColumn.HeaderText = "Shelf_Location"
        Me.ShelfLocationDataGridViewTextBoxColumn.Name = "ShelfLocationDataGridViewTextBoxColumn"
        '
        'FictionDataGridViewCheckBoxColumn
        '
        Me.FictionDataGridViewCheckBoxColumn.DataPropertyName = "Fiction"
        Me.FictionDataGridViewCheckBoxColumn.HeaderText = "Fiction"
        Me.FictionDataGridViewCheckBoxColumn.Name = "FictionDataGridViewCheckBoxColumn"
        '
        'SubjectCodeDataGridViewTextBoxColumn1
        '
        Me.SubjectCodeDataGridViewTextBoxColumn1.DataPropertyName = "SubjectCode"
        Me.SubjectCodeDataGridViewTextBoxColumn1.HeaderText = "SubjectCode"
        Me.SubjectCodeDataGridViewTextBoxColumn1.Name = "SubjectCodeDataGridViewTextBoxColumn1"
        '
        'SubjectDataGridViewTextBoxColumn
        '
        Me.SubjectDataGridViewTextBoxColumn.DataPropertyName = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.HeaderText = "Subject"
        Me.SubjectDataGridViewTextBoxColumn.Name = "SubjectDataGridViewTextBoxColumn"
        '
        'Subject
        '
        Me.Subject.DataPropertyName = "Subject"
        Me.Subject.HeaderText = "Subject"
        Me.Subject.Name = "Subject"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 478)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnrBooksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RnrBooksDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RnrBooksDataSet1 As inClass9.RnrBooksDataSet1
    Friend WithEvents BooksBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter1 As inClass9.RnrBooksDataSet1TableAdapters.BooksTableAdapter
    Friend WithEvents DataTable1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents RnrBooksDataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable2TableAdapter As inClass9.RnrBooksDataSet1TableAdapters.DataTable2TableAdapter
    Friend WithEvents ISBNDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AuthorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PublisherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShelfLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FictionDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents SubjectCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subject As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
