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
        Me.Label1 = New System.Windows.Forms.Label
        Me.isbnTextBox = New System.Windows.Forms.TextBox
        Me.authorTextBox = New System.Windows.Forms.TextBox
        Me.authorLabel = New System.Windows.Forms.Label
        Me.subjectCodeTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.shelfLocationTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.publisherTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.titleTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ISBN:"
        '
        'isbnTextBox
        '
        Me.isbnTextBox.Location = New System.Drawing.Point(118, 26)
        Me.isbnTextBox.Name = "isbnTextBox"
        Me.isbnTextBox.Size = New System.Drawing.Size(100, 20)
        Me.isbnTextBox.TabIndex = 1
        '
        'authorTextBox
        '
        Me.authorTextBox.Location = New System.Drawing.Point(118, 92)
        Me.authorTextBox.Name = "authorTextBox"
        Me.authorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.authorTextBox.TabIndex = 3
        '
        'authorLabel
        '
        Me.authorLabel.AutoSize = True
        Me.authorLabel.Location = New System.Drawing.Point(30, 92)
        Me.authorLabel.Name = "authorLabel"
        Me.authorLabel.Size = New System.Drawing.Size(38, 13)
        Me.authorLabel.TabIndex = 2
        Me.authorLabel.Text = "Author"
        '
        'subjectCodeTextBox
        '
        Me.subjectCodeTextBox.Location = New System.Drawing.Point(120, 156)
        Me.subjectCodeTextBox.Name = "subjectCodeTextBox"
        Me.subjectCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.subjectCodeTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Subject Code:"
        '
        'shelfLocationTextBox
        '
        Me.shelfLocationTextBox.Location = New System.Drawing.Point(120, 196)
        Me.shelfLocationTextBox.Name = "shelfLocationTextBox"
        Me.shelfLocationTextBox.Size = New System.Drawing.Size(100, 20)
        Me.shelfLocationTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Shelf Location:"
        '
        'publisherTextBox
        '
        Me.publisherTextBox.Location = New System.Drawing.Point(120, 123)
        Me.publisherTextBox.Name = "publisherTextBox"
        Me.publisherTextBox.Size = New System.Drawing.Size(100, 20)
        Me.publisherTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Publisher:"
        '
        'titleTextBox
        '
        Me.titleTextBox.Location = New System.Drawing.Point(118, 60)
        Me.titleTextBox.Name = "titleTextBox"
        Me.titleTextBox.Size = New System.Drawing.Size(100, 20)
        Me.titleTextBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fiction:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(118, 227)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DetailsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.titleTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.publisherTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.shelfLocationTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.subjectCodeTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.authorTextBox)
        Me.Controls.Add(Me.authorLabel)
        Me.Controls.Add(Me.isbnTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "DetailsForm"
        Me.Text = "R ’n R Books Detail View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents isbnTextBox As System.Windows.Forms.TextBox
    Friend WithEvents authorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents authorLabel As System.Windows.Forms.Label
    Friend WithEvents subjectCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents shelfLocationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents publisherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents titleTextBox As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
