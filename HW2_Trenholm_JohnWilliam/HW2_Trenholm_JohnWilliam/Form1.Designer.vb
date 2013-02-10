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
        Me.Label1 = New System.Windows.Forms.Label
        Me.yearGroupbox1 = New System.Windows.Forms.GroupBox
        Me.year15Interest = New System.Windows.Forms.RadioButton
        Me.year10Interest = New System.Windows.Forms.RadioButton
        Me.year5Interest = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.interestBox = New System.Windows.Forms.TextBox
        Me.principalBox = New System.Windows.Forms.TextBox
        Me.NameBox1 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.outputBox = New System.Windows.Forms.TextBox
        Me.calculateButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.clearBox = New System.Windows.Forms.Button
        Me.yearGroupbox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 569)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Future value of an investment with compound interest John-William Trenholm"
        '
        'yearGroupbox1
        '
        Me.yearGroupbox1.Controls.Add(Me.year15Interest)
        Me.yearGroupbox1.Controls.Add(Me.year10Interest)
        Me.yearGroupbox1.Controls.Add(Me.year5Interest)
        Me.yearGroupbox1.Location = New System.Drawing.Point(18, 193)
        Me.yearGroupbox1.Name = "yearGroupbox1"
        Me.yearGroupbox1.Size = New System.Drawing.Size(200, 117)
        Me.yearGroupbox1.TabIndex = 1
        Me.yearGroupbox1.TabStop = False
        Me.yearGroupbox1.Text = "Years to invest"
        '
        'year15Interest
        '
        Me.year15Interest.AutoSize = True
        Me.year15Interest.Location = New System.Drawing.Point(25, 90)
        Me.year15Interest.Name = "year15Interest"
        Me.year15Interest.Size = New System.Drawing.Size(86, 21)
        Me.year15Interest.TabIndex = 2
        Me.year15Interest.Text = "15 &Years"
        Me.year15Interest.UseVisualStyleBackColor = True
        '
        'year10Interest
        '
        Me.year10Interest.AutoSize = True
        Me.year10Interest.Location = New System.Drawing.Point(25, 62)
        Me.year10Interest.Name = "year10Interest"
        Me.year10Interest.Size = New System.Drawing.Size(86, 21)
        Me.year10Interest.TabIndex = 1
        Me.year10Interest.Text = "&10 Years"
        Me.year10Interest.UseVisualStyleBackColor = True
        '
        'year5Interest
        '
        Me.year5Interest.AutoSize = True
        Me.year5Interest.Location = New System.Drawing.Point(25, 34)
        Me.year5Interest.Name = "year5Interest"
        Me.year5Interest.Size = New System.Drawing.Size(78, 21)
        Me.year5Interest.TabIndex = 0
        Me.year5Interest.Text = "&5 Years"
        Me.year5Interest.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.interestBox)
        Me.GroupBox1.Controls.Add(Me.principalBox)
        Me.GroupBox1.Controls.Add(Me.NameBox1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 137)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'interestBox
        '
        Me.interestBox.Location = New System.Drawing.Point(212, 90)
        Me.interestBox.Name = "interestBox"
        Me.interestBox.Size = New System.Drawing.Size(121, 22)
        Me.interestBox.TabIndex = 5
        '
        'principalBox
        '
        Me.principalBox.Location = New System.Drawing.Point(212, 62)
        Me.principalBox.Name = "principalBox"
        Me.principalBox.Size = New System.Drawing.Size(312, 22)
        Me.principalBox.TabIndex = 3
        '
        'NameBox1
        '
        Me.NameBox1.Location = New System.Drawing.Point(212, 31)
        Me.NameBox1.Name = "NameBox1"
        Me.NameBox1.Size = New System.Drawing.Size(312, 22)
        Me.NameBox1.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "&Annual Interest Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "&Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Principal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.outputBox)
        Me.GroupBox2.Controls.Add(Me.calculateButton)
        Me.GroupBox2.Controls.Add(Me.exitButton)
        Me.GroupBox2.Controls.Add(Me.clearBox)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 351)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(569, 181)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'outputBox
        '
        Me.outputBox.Location = New System.Drawing.Point(25, 83)
        Me.outputBox.Name = "outputBox"
        Me.outputBox.ReadOnly = True
        Me.outputBox.Size = New System.Drawing.Size(526, 22)
        Me.outputBox.TabIndex = 3
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(6, 36)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 0
        Me.calculateButton.Text = "&Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(419, 139)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearBox
        '
        Me.clearBox.Location = New System.Drawing.Point(6, 139)
        Me.clearBox.Name = "clearBox"
        Me.clearBox.Size = New System.Drawing.Size(75, 23)
        Me.clearBox.TabIndex = 1
        Me.clearBox.Text = "C&lear"
        Me.clearBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearBox
        Me.ClientSize = New System.Drawing.Size(608, 595)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.yearGroupbox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Future value of an investment with compound interest"
        Me.yearGroupbox1.ResumeLayout(False)
        Me.yearGroupbox1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents yearGroupbox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents year15Interest As System.Windows.Forms.RadioButton
    Friend WithEvents year10Interest As System.Windows.Forms.RadioButton
    Friend WithEvents year5Interest As System.Windows.Forms.RadioButton
    Friend WithEvents interestBox As System.Windows.Forms.TextBox
    Friend WithEvents principalBox As System.Windows.Forms.TextBox
    Friend WithEvents NameBox1 As System.Windows.Forms.TextBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearBox As System.Windows.Forms.Button
    Friend WithEvents outputBox As System.Windows.Forms.TextBox

End Class
