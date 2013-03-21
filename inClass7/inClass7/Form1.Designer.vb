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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.inputTextBox = New System.Windows.Forms.TextBox
        Me.addButton = New System.Windows.Forms.Button
        Me.insertButton = New System.Windows.Forms.Button
        Me.positionBox = New System.Windows.Forms.TextBox
        Me.countButton = New System.Windows.Forms.Button
        Me.changeButton = New System.Windows.Forms.Button
        Me.changeTextBox = New System.Windows.Forms.TextBox
        Me.removeAtbutton = New System.Windows.Forms.Button
        Me.removeTextBox = New System.Windows.Forms.TextBox
        Me.removePizza = New System.Windows.Forms.Button
        Me.removeStringTextBox = New System.Windows.Forms.TextBox
        Me.searchButton = New System.Windows.Forms.Button
        Me.searchTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Beerz", "Chicken Wings", "Hamburgers", "Hotdogs", "Pizza"})
        Me.ListBox1.Location = New System.Drawing.Point(150, 68)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.ListBox1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Beerz", "Chicken Wings", "Hamburgers", "Hotdogs", "Pizza"})
        Me.ComboBox1.Location = New System.Drawing.Point(76, 41)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 1
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Beerz", "Chicken Wings", "Hamburgers", "Hotdogs", "Ice Cream", "Pizza"})
        Me.ComboBox2.Location = New System.Drawing.Point(23, 68)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(100, 124)
        Me.ComboBox2.Sorted = True
        Me.ComboBox2.TabIndex = 2
        '
        'inputTextBox
        '
        Me.inputTextBox.Location = New System.Drawing.Point(150, 159)
        Me.inputTextBox.Name = "inputTextBox"
        Me.inputTextBox.Size = New System.Drawing.Size(120, 20)
        Me.inputTextBox.TabIndex = 3
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(23, 198)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 4
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'insertButton
        '
        Me.insertButton.Location = New System.Drawing.Point(23, 236)
        Me.insertButton.Name = "insertButton"
        Me.insertButton.Size = New System.Drawing.Size(75, 23)
        Me.insertButton.TabIndex = 5
        Me.insertButton.Text = "Insert"
        Me.insertButton.UseVisualStyleBackColor = True
        '
        'positionBox
        '
        Me.positionBox.Location = New System.Drawing.Point(133, 239)
        Me.positionBox.Name = "positionBox"
        Me.positionBox.Size = New System.Drawing.Size(100, 20)
        Me.positionBox.TabIndex = 6
        '
        'countButton
        '
        Me.countButton.Location = New System.Drawing.Point(23, 273)
        Me.countButton.Name = "countButton"
        Me.countButton.Size = New System.Drawing.Size(75, 23)
        Me.countButton.TabIndex = 7
        Me.countButton.Text = "Count"
        Me.countButton.UseVisualStyleBackColor = True
        '
        'changeButton
        '
        Me.changeButton.Location = New System.Drawing.Point(23, 312)
        Me.changeButton.Name = "changeButton"
        Me.changeButton.Size = New System.Drawing.Size(75, 23)
        Me.changeButton.TabIndex = 8
        Me.changeButton.Text = "Change"
        Me.changeButton.UseVisualStyleBackColor = True
        '
        'changeTextBox
        '
        Me.changeTextBox.Location = New System.Drawing.Point(133, 312)
        Me.changeTextBox.Name = "changeTextBox"
        Me.changeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.changeTextBox.TabIndex = 9
        '
        'removeAtbutton
        '
        Me.removeAtbutton.Location = New System.Drawing.Point(23, 359)
        Me.removeAtbutton.Name = "removeAtbutton"
        Me.removeAtbutton.Size = New System.Drawing.Size(75, 23)
        Me.removeAtbutton.TabIndex = 10
        Me.removeAtbutton.Text = "Remove"
        Me.removeAtbutton.UseVisualStyleBackColor = True
        '
        'removeTextBox
        '
        Me.removeTextBox.Location = New System.Drawing.Point(133, 359)
        Me.removeTextBox.Name = "removeTextBox"
        Me.removeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.removeTextBox.TabIndex = 11
        '
        'removePizza
        '
        Me.removePizza.Location = New System.Drawing.Point(23, 404)
        Me.removePizza.Name = "removePizza"
        Me.removePizza.Size = New System.Drawing.Size(75, 23)
        Me.removePizza.TabIndex = 12
        Me.removePizza.Text = "removePizza"
        Me.removePizza.UseVisualStyleBackColor = True
        '
        'removeStringTextBox
        '
        Me.removeStringTextBox.Location = New System.Drawing.Point(133, 404)
        Me.removeStringTextBox.Name = "removeStringTextBox"
        Me.removeStringTextBox.Size = New System.Drawing.Size(100, 20)
        Me.removeStringTextBox.TabIndex = 13
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(23, 452)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 14
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(133, 452)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(100, 20)
        Me.searchTextBox.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 552)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.removeStringTextBox)
        Me.Controls.Add(Me.removePizza)
        Me.Controls.Add(Me.removeTextBox)
        Me.Controls.Add(Me.removeAtbutton)
        Me.Controls.Add(Me.changeTextBox)
        Me.Controls.Add(Me.changeButton)
        Me.Controls.Add(Me.countButton)
        Me.Controls.Add(Me.positionBox)
        Me.Controls.Add(Me.insertButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.inputTextBox)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents inputTextBox As System.Windows.Forms.TextBox
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents insertButton As System.Windows.Forms.Button
    Friend WithEvents positionBox As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents countButton As System.Windows.Forms.Button
    Friend WithEvents changeButton As System.Windows.Forms.Button
    Friend WithEvents changeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents removeAtbutton As System.Windows.Forms.Button
    Friend WithEvents removeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents removePizza As System.Windows.Forms.Button
    Friend WithEvents removeStringTextBox As System.Windows.Forms.TextBox
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents searchTextBox As System.Windows.Forms.TextBox

End Class
