<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Message_Formatter
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
        Me.nameLabel = New System.Windows.Forms.Label
        Me.messageLabel = New System.Windows.Forms.Label
        Me.nameTextBox = New System.Windows.Forms.TextBox
        Me.messageTextBox = New System.Windows.Forms.TextBox
        Me.colorGroupBox = New System.Windows.Forms.GroupBox
        Me.blackRadio = New System.Windows.Forms.RadioButton
        Me.blueRadio = New System.Windows.Forms.RadioButton
        Me.greenRadio = New System.Windows.Forms.RadioButton
        Me.redRadio = New System.Windows.Forms.RadioButton
        Me.viewMessage = New System.Windows.Forms.CheckBox
        Me.messageOutPutBox = New System.Windows.Forms.Label
        Me.displayButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.colorGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(27, 12)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "&Name"
        '
        'messageLabel
        '
        Me.messageLabel.AutoSize = True
        Me.messageLabel.Location = New System.Drawing.Point(27, 58)
        Me.messageLabel.Name = "messageLabel"
        Me.messageLabel.Size = New System.Drawing.Size(50, 13)
        Me.messageLabel.TabIndex = 2
        Me.messageLabel.Text = "&Message"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(124, 13)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(316, 20)
        Me.nameTextBox.TabIndex = 1
        '
        'messageTextBox
        '
        Me.messageTextBox.Location = New System.Drawing.Point(124, 58)
        Me.messageTextBox.Name = "messageTextBox"
        Me.messageTextBox.Size = New System.Drawing.Size(316, 20)
        Me.messageTextBox.TabIndex = 3
        '
        'colorGroupBox
        '
        Me.colorGroupBox.Controls.Add(Me.blackRadio)
        Me.colorGroupBox.Controls.Add(Me.blueRadio)
        Me.colorGroupBox.Controls.Add(Me.greenRadio)
        Me.colorGroupBox.Controls.Add(Me.redRadio)
        Me.colorGroupBox.Location = New System.Drawing.Point(30, 115)
        Me.colorGroupBox.Name = "colorGroupBox"
        Me.colorGroupBox.Size = New System.Drawing.Size(122, 145)
        Me.colorGroupBox.TabIndex = 4
        Me.colorGroupBox.TabStop = False
        Me.colorGroupBox.Text = "Color"
        '
        'blackRadio
        '
        Me.blackRadio.AutoSize = True
        Me.blackRadio.Checked = True
        Me.blackRadio.Location = New System.Drawing.Point(15, 88)
        Me.blackRadio.Name = "blackRadio"
        Me.blackRadio.Size = New System.Drawing.Size(52, 17)
        Me.blackRadio.TabIndex = 3
        Me.blackRadio.TabStop = True
        Me.blackRadio.Text = "B&lack"
        Me.blackRadio.UseVisualStyleBackColor = True
        '
        'blueRadio
        '
        Me.blueRadio.AutoSize = True
        Me.blueRadio.Location = New System.Drawing.Point(15, 65)
        Me.blueRadio.Name = "blueRadio"
        Me.blueRadio.Size = New System.Drawing.Size(46, 17)
        Me.blueRadio.TabIndex = 2
        Me.blueRadio.Text = "&Blue"
        Me.blueRadio.UseVisualStyleBackColor = True
        '
        'greenRadio
        '
        Me.greenRadio.AutoSize = True
        Me.greenRadio.Location = New System.Drawing.Point(15, 42)
        Me.greenRadio.Name = "greenRadio"
        Me.greenRadio.Size = New System.Drawing.Size(54, 17)
        Me.greenRadio.TabIndex = 1
        Me.greenRadio.Text = "&Green"
        Me.greenRadio.UseVisualStyleBackColor = True
        '
        'redRadio
        '
        Me.redRadio.AutoSize = True
        Me.redRadio.Location = New System.Drawing.Point(15, 19)
        Me.redRadio.Name = "redRadio"
        Me.redRadio.Size = New System.Drawing.Size(45, 17)
        Me.redRadio.TabIndex = 0
        Me.redRadio.Text = "&Red"
        Me.redRadio.UseVisualStyleBackColor = True
        '
        'viewMessage
        '
        Me.viewMessage.AutoSize = True
        Me.viewMessage.Checked = True
        Me.viewMessage.CheckState = System.Windows.Forms.CheckState.Checked
        Me.viewMessage.Location = New System.Drawing.Point(267, 127)
        Me.viewMessage.Name = "viewMessage"
        Me.viewMessage.Size = New System.Drawing.Size(95, 17)
        Me.viewMessage.TabIndex = 5
        Me.viewMessage.Text = "Message &View"
        Me.viewMessage.UseVisualStyleBackColor = True
        '
        'messageOutPutBox
        '
        Me.messageOutPutBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.messageOutPutBox.Location = New System.Drawing.Point(264, 160)
        Me.messageOutPutBox.Name = "messageOutPutBox"
        Me.messageOutPutBox.Size = New System.Drawing.Size(224, 100)
        Me.messageOutPutBox.TabIndex = 6
        Me.messageOutPutBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(349, 289)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(139, 23)
        Me.displayButton.TabIndex = 7
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(349, 374)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(139, 23)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(349, 334)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(139, 23)
        Me.clearButton.TabIndex = 8
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(45, 307)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Message_Formatter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 409)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.messageOutPutBox)
        Me.Controls.Add(Me.viewMessage)
        Me.Controls.Add(Me.colorGroupBox)
        Me.Controls.Add(Me.messageTextBox)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.messageLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Name = "Message_Formatter"
        Me.Text = "Message_Formatter"
        Me.colorGroupBox.ResumeLayout(False)
        Me.colorGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents messageLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents messageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents colorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents viewMessage As System.Windows.Forms.CheckBox
    Friend WithEvents messageOutPutBox As System.Windows.Forms.Label
    Friend WithEvents blackRadio As System.Windows.Forms.RadioButton
    Friend WithEvents blueRadio As System.Windows.Forms.RadioButton
    Friend WithEvents greenRadio As System.Windows.Forms.RadioButton
    Friend WithEvents redRadio As System.Windows.Forms.RadioButton
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
