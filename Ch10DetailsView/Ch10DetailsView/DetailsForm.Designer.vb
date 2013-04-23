<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailsForm))
        Dim ISBNLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim AuthorLabel As System.Windows.Forms.Label
        Dim PublisherLabel As System.Windows.Forms.Label
        Dim Subject_CodeLabel As System.Windows.Forms.Label
        Dim Shelf_LocationLabel As System.Windows.Forms.Label
        Dim FictionLabel As System.Windows.Forms.Label
        Me.RnrBooksDataSet = New Ch10DetailsView.RnrBooksDataSet
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksTableAdapter = New Ch10DetailsView.RnrBooksDataSetTableAdapters.BooksTableAdapter
        Me.TableAdapterManager = New Ch10DetailsView.RnrBooksDataSetTableAdapters.TableAdapterManager
        Me.BooksBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BooksBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ISBNTextBox = New System.Windows.Forms.TextBox
        Me.TitleTextBox = New System.Windows.Forms.TextBox
        Me.AuthorTextBox = New System.Windows.Forms.TextBox
        Me.PublisherTextBox = New System.Windows.Forms.TextBox
        Me.Subject_CodeTextBox = New System.Windows.Forms.TextBox
        Me.Shelf_LocationTextBox = New System.Windows.Forms.TextBox
        Me.FictionCheckBox = New System.Windows.Forms.CheckBox
        ISBNLabel = New System.Windows.Forms.Label
        TitleLabel = New System.Windows.Forms.Label
        AuthorLabel = New System.Windows.Forms.Label
        PublisherLabel = New System.Windows.Forms.Label
        Subject_CodeLabel = New System.Windows.Forms.Label
        Shelf_LocationLabel = New System.Windows.Forms.Label
        FictionLabel = New System.Windows.Forms.Label
        CType(Me.RnrBooksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BooksBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'RnrBooksDataSet
        '
        Me.RnrBooksDataSet.DataSetName = "RnrBooksDataSet"
        Me.RnrBooksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "Books"
        Me.BooksBindingSource.DataSource = Me.RnrBooksDataSet
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BooksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager.UpdateOrder = Ch10DetailsView.RnrBooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BooksBindingNavigator
        '
        Me.BooksBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BooksBindingNavigator.BindingSource = Me.BooksBindingSource
        Me.BooksBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BooksBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BooksBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BooksBindingNavigatorSaveItem})
        Me.BooksBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BooksBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BooksBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BooksBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BooksBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BooksBindingNavigator.Name = "BooksBindingNavigator"
        Me.BooksBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BooksBindingNavigator.Size = New System.Drawing.Size(469, 25)
        Me.BooksBindingNavigator.TabIndex = 0
        Me.BooksBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BooksBindingNavigatorSaveItem
        '
        Me.BooksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BooksBindingNavigatorSaveItem.Image = CType(resources.GetObject("BooksBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BooksBindingNavigatorSaveItem.Name = "BooksBindingNavigatorSaveItem"
        Me.BooksBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.BooksBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ISBNLabel
        '
        ISBNLabel.AutoSize = True
        ISBNLabel.Location = New System.Drawing.Point(98, 59)
        ISBNLabel.Name = "ISBNLabel"
        ISBNLabel.Size = New System.Drawing.Size(35, 13)
        ISBNLabel.TabIndex = 1
        ISBNLabel.Text = "ISBN:"
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "ISBN", True))
        Me.ISBNTextBox.Location = New System.Drawing.Point(182, 56)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ISBNTextBox.TabIndex = 2
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(98, 85)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(30, 13)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(182, 82)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(104, 20)
        Me.TitleTextBox.TabIndex = 4
        '
        'AuthorLabel
        '
        AuthorLabel.AutoSize = True
        AuthorLabel.Location = New System.Drawing.Point(98, 111)
        AuthorLabel.Name = "AuthorLabel"
        AuthorLabel.Size = New System.Drawing.Size(41, 13)
        AuthorLabel.TabIndex = 5
        AuthorLabel.Text = "Author:"
        '
        'AuthorTextBox
        '
        Me.AuthorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Author", True))
        Me.AuthorTextBox.Location = New System.Drawing.Point(182, 108)
        Me.AuthorTextBox.Name = "AuthorTextBox"
        Me.AuthorTextBox.Size = New System.Drawing.Size(104, 20)
        Me.AuthorTextBox.TabIndex = 6
        '
        'PublisherLabel
        '
        PublisherLabel.AutoSize = True
        PublisherLabel.Location = New System.Drawing.Point(98, 137)
        PublisherLabel.Name = "PublisherLabel"
        PublisherLabel.Size = New System.Drawing.Size(53, 13)
        PublisherLabel.TabIndex = 7
        PublisherLabel.Text = "Publisher:"
        '
        'PublisherTextBox
        '
        Me.PublisherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Publisher", True))
        Me.PublisherTextBox.Location = New System.Drawing.Point(182, 134)
        Me.PublisherTextBox.Name = "PublisherTextBox"
        Me.PublisherTextBox.Size = New System.Drawing.Size(104, 20)
        Me.PublisherTextBox.TabIndex = 8
        '
        'Subject_CodeLabel
        '
        Subject_CodeLabel.AutoSize = True
        Subject_CodeLabel.Location = New System.Drawing.Point(98, 163)
        Subject_CodeLabel.Name = "Subject_CodeLabel"
        Subject_CodeLabel.Size = New System.Drawing.Size(74, 13)
        Subject_CodeLabel.TabIndex = 9
        Subject_CodeLabel.Text = "Subject Code:"
        '
        'Subject_CodeTextBox
        '
        Me.Subject_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Subject_Code", True))
        Me.Subject_CodeTextBox.Location = New System.Drawing.Point(182, 160)
        Me.Subject_CodeTextBox.Name = "Subject_CodeTextBox"
        Me.Subject_CodeTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Subject_CodeTextBox.TabIndex = 10
        '
        'Shelf_LocationLabel
        '
        Shelf_LocationLabel.AutoSize = True
        Shelf_LocationLabel.Location = New System.Drawing.Point(98, 189)
        Shelf_LocationLabel.Name = "Shelf_LocationLabel"
        Shelf_LocationLabel.Size = New System.Drawing.Size(78, 13)
        Shelf_LocationLabel.TabIndex = 11
        Shelf_LocationLabel.Text = "Shelf Location:"
        '
        'Shelf_LocationTextBox
        '
        Me.Shelf_LocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BooksBindingSource, "Shelf_Location", True))
        Me.Shelf_LocationTextBox.Location = New System.Drawing.Point(182, 186)
        Me.Shelf_LocationTextBox.Name = "Shelf_LocationTextBox"
        Me.Shelf_LocationTextBox.Size = New System.Drawing.Size(104, 20)
        Me.Shelf_LocationTextBox.TabIndex = 12
        '
        'FictionLabel
        '
        FictionLabel.AutoSize = True
        FictionLabel.Location = New System.Drawing.Point(98, 217)
        FictionLabel.Name = "FictionLabel"
        FictionLabel.Size = New System.Drawing.Size(41, 13)
        FictionLabel.TabIndex = 13
        FictionLabel.Text = "Fiction:"
        '
        'FictionCheckBox
        '
        Me.FictionCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.BooksBindingSource, "Fiction", True))
        Me.FictionCheckBox.Location = New System.Drawing.Point(182, 212)
        Me.FictionCheckBox.Name = "FictionCheckBox"
        Me.FictionCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.FictionCheckBox.TabIndex = 14
        Me.FictionCheckBox.UseVisualStyleBackColor = True
        '
        'DetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 302)
        Me.Controls.Add(ISBNLabel)
        Me.Controls.Add(Me.ISBNTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(AuthorLabel)
        Me.Controls.Add(Me.AuthorTextBox)
        Me.Controls.Add(PublisherLabel)
        Me.Controls.Add(Me.PublisherTextBox)
        Me.Controls.Add(Subject_CodeLabel)
        Me.Controls.Add(Me.Subject_CodeTextBox)
        Me.Controls.Add(Shelf_LocationLabel)
        Me.Controls.Add(Me.Shelf_LocationTextBox)
        Me.Controls.Add(FictionLabel)
        Me.Controls.Add(Me.FictionCheckBox)
        Me.Controls.Add(Me.BooksBindingNavigator)
        Me.Name = "DetailsForm"
        Me.Text = "R ’n R Books Detail View"
        CType(Me.RnrBooksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BooksBindingNavigator.ResumeLayout(False)
        Me.BooksBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RnrBooksDataSet As Ch10DetailsView.RnrBooksDataSet
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BooksTableAdapter As Ch10DetailsView.RnrBooksDataSetTableAdapters.BooksTableAdapter
    Friend WithEvents TableAdapterManager As Ch10DetailsView.RnrBooksDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BooksBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BooksBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ISBNTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AuthorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PublisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Subject_CodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Shelf_LocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FictionCheckBox As System.Windows.Forms.CheckBox

End Class
