<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class previewWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(previewWindow))
        Me.nameLabel = New System.Windows.Forms.Label
        Me.visableCheckBox = New System.Windows.Forms.CheckBox
        Me.dobLabel = New System.Windows.Forms.Label
        Me.nameTextBox = New System.Windows.Forms.TextBox
        Me.displayButton = New System.Windows.Forms.Button
        Me.printPreviewButton = New System.Windows.Forms.Button
        Me.yellowButton = New System.Windows.Forms.Button
        Me.redButton = New System.Windows.Forms.Button
        Me.greyButton = New System.Windows.Forms.Button
        Me.blackButton = New System.Windows.Forms.Button
        Me.noneButton = New System.Windows.Forms.Button
        Me.fixedSingleButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.fix3dButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.resetButton = New System.Windows.Forms.Button
        Me.WhiteButton = New System.Windows.Forms.Button
        Me.blueButton = New System.Windows.Forms.Button
        Me.leftRadio = New System.Windows.Forms.RadioButton
        Me.centerRadio = New System.Windows.Forms.RadioButton
        Me.rightRadio = New System.Windows.Forms.RadioButton
        Me.boldButton = New System.Windows.Forms.Button
        Me.italicButton = New System.Windows.Forms.Button
        Me.underlineButton = New System.Windows.Forms.Button
        Me.dobTextBox = New System.Windows.Forms.MaskedTextBox
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.boardStyleBox = New System.Windows.Forms.GroupBox
        Me.bgColor = New System.Windows.Forms.GroupBox
        Me.fgColor = New System.Windows.Forms.GroupBox
        Me.fontStyle = New System.Windows.Forms.GroupBox
        Me.textAlignBox = New System.Windows.Forms.GroupBox
        Me.resetToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.outputBox = New System.Windows.Forms.Label
        Me.boardStyleBox.SuspendLayout()
        Me.bgColor.SuspendLayout()
        Me.fgColor.SuspendLayout()
        Me.fontStyle.SuspendLayout()
        Me.textAlignBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(45, 37)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(45, 17)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Name"
        '
        'visableCheckBox
        '
        Me.visableCheckBox.AutoSize = True
        Me.visableCheckBox.Checked = True
        Me.visableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.visableCheckBox.Location = New System.Drawing.Point(498, 82)
        Me.visableCheckBox.Name = "visableCheckBox"
        Me.visableCheckBox.Size = New System.Drawing.Size(71, 21)
        Me.visableCheckBox.TabIndex = 4
        Me.visableCheckBox.Text = "&Visible"
        Me.visableCheckBox.UseVisualStyleBackColor = True
        '
        'dobLabel
        '
        Me.dobLabel.AutoSize = True
        Me.dobLabel.Location = New System.Drawing.Point(45, 82)
        Me.dobLabel.Name = "dobLabel"
        Me.dobLabel.Size = New System.Drawing.Size(87, 17)
        Me.dobLabel.TabIndex = 2
        Me.dobLabel.Text = "Date of Birth"
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(159, 39)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(168, 22)
        Me.nameTextBox.TabIndex = 1
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(159, 203)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(117, 28)
        Me.displayButton.TabIndex = 6
        Me.displayButton.Text = "&Display"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'printPreviewButton
        '
        Me.printPreviewButton.Location = New System.Drawing.Point(69, 669)
        Me.printPreviewButton.Name = "printPreviewButton"
        Me.printPreviewButton.Size = New System.Drawing.Size(117, 28)
        Me.printPreviewButton.TabIndex = 13
        Me.printPreviewButton.Text = "&PrintPreview"
        Me.printPreviewButton.UseVisualStyleBackColor = True
        '
        'yellowButton
        '
        Me.yellowButton.Location = New System.Drawing.Point(384, 21)
        Me.yellowButton.Name = "yellowButton"
        Me.yellowButton.Size = New System.Drawing.Size(117, 28)
        Me.yellowButton.TabIndex = 2
        Me.yellowButton.Text = "&Yellow"
        Me.yellowButton.UseVisualStyleBackColor = True
        '
        'redButton
        '
        Me.redButton.Location = New System.Drawing.Point(47, 21)
        Me.redButton.Name = "redButton"
        Me.redButton.Size = New System.Drawing.Size(117, 28)
        Me.redButton.TabIndex = 0
        Me.redButton.Text = "&Red"
        Me.redButton.UseVisualStyleBackColor = True
        '
        'greyButton
        '
        Me.greyButton.Location = New System.Drawing.Point(382, 21)
        Me.greyButton.Name = "greyButton"
        Me.greyButton.Size = New System.Drawing.Size(117, 28)
        Me.greyButton.TabIndex = 2
        Me.greyButton.Text = "&Gray"
        Me.greyButton.UseVisualStyleBackColor = True
        '
        'blackButton
        '
        Me.blackButton.Location = New System.Drawing.Point(47, 21)
        Me.blackButton.Name = "blackButton"
        Me.blackButton.Size = New System.Drawing.Size(117, 28)
        Me.blackButton.TabIndex = 0
        Me.blackButton.Text = "Blac&k"
        Me.blackButton.UseVisualStyleBackColor = True
        '
        'noneButton
        '
        Me.noneButton.Location = New System.Drawing.Point(384, 21)
        Me.noneButton.Name = "noneButton"
        Me.noneButton.Size = New System.Drawing.Size(117, 28)
        Me.noneButton.TabIndex = 2
        Me.noneButton.Text = "&None"
        Me.noneButton.UseVisualStyleBackColor = True
        '
        'fixedSingleButton
        '
        Me.fixedSingleButton.Location = New System.Drawing.Point(49, 21)
        Me.fixedSingleButton.Name = "fixedSingleButton"
        Me.fixedSingleButton.Size = New System.Drawing.Size(117, 28)
        Me.fixedSingleButton.TabIndex = 0
        Me.fixedSingleButton.Text = "Fixed &Single"
        Me.fixedSingleButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(350, 203)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(117, 28)
        Me.clearButton.TabIndex = 7
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'fix3dButton
        '
        Me.fix3dButton.Location = New System.Drawing.Point(211, 21)
        Me.fix3dButton.Name = "fix3dButton"
        Me.fix3dButton.Size = New System.Drawing.Size(117, 28)
        Me.fix3dButton.TabIndex = 1
        Me.fix3dButton.Text = "Fixed &3D"
        Me.fix3dButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(418, 669)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(117, 28)
        Me.exitButton.TabIndex = 15
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(238, 669)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(117, 28)
        Me.resetButton.TabIndex = 14
        Me.resetButton.Text = "Rese&t"
        Me.resetToolTip.SetToolTip(Me.resetButton, "Resets All of Text Label Properties To their default values.")
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'WhiteButton
        '
        Me.WhiteButton.Location = New System.Drawing.Point(211, 21)
        Me.WhiteButton.Name = "WhiteButton"
        Me.WhiteButton.Size = New System.Drawing.Size(117, 28)
        Me.WhiteButton.TabIndex = 1
        Me.WhiteButton.Text = "W&hite"
        Me.WhiteButton.UseVisualStyleBackColor = True
        '
        'blueButton
        '
        Me.blueButton.Location = New System.Drawing.Point(211, 21)
        Me.blueButton.Name = "blueButton"
        Me.blueButton.Size = New System.Drawing.Size(117, 28)
        Me.blueButton.TabIndex = 1
        Me.blueButton.Text = "&Blue"
        Me.blueButton.UseVisualStyleBackColor = True
        '
        'leftRadio
        '
        Me.leftRadio.AutoSize = True
        Me.leftRadio.Location = New System.Drawing.Point(82, 21)
        Me.leftRadio.Name = "leftRadio"
        Me.leftRadio.Size = New System.Drawing.Size(53, 21)
        Me.leftRadio.TabIndex = 0
        Me.leftRadio.TabStop = True
        Me.leftRadio.Text = "&Left"
        Me.leftRadio.UseVisualStyleBackColor = True
        '
        'centerRadio
        '
        Me.centerRadio.AutoSize = True
        Me.centerRadio.Location = New System.Drawing.Point(236, 21)
        Me.centerRadio.Name = "centerRadio"
        Me.centerRadio.Size = New System.Drawing.Size(71, 21)
        Me.centerRadio.TabIndex = 1
        Me.centerRadio.TabStop = True
        Me.centerRadio.Text = "&Center"
        Me.centerRadio.UseVisualStyleBackColor = True
        '
        'rightRadio
        '
        Me.rightRadio.AutoSize = True
        Me.rightRadio.Location = New System.Drawing.Point(384, 21)
        Me.rightRadio.Name = "rightRadio"
        Me.rightRadio.Size = New System.Drawing.Size(62, 21)
        Me.rightRadio.TabIndex = 2
        Me.rightRadio.TabStop = True
        Me.rightRadio.Text = "&Right"
        Me.rightRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rightRadio.UseVisualStyleBackColor = True
        '
        'boldButton
        '
        Me.boldButton.Location = New System.Drawing.Point(47, 21)
        Me.boldButton.Name = "boldButton"
        Me.boldButton.Size = New System.Drawing.Size(117, 28)
        Me.boldButton.TabIndex = 0
        Me.boldButton.Text = "&Bold"
        Me.boldButton.UseVisualStyleBackColor = True
        '
        'italicButton
        '
        Me.italicButton.Location = New System.Drawing.Point(211, 21)
        Me.italicButton.Name = "italicButton"
        Me.italicButton.Size = New System.Drawing.Size(117, 28)
        Me.italicButton.TabIndex = 1
        Me.italicButton.Text = "&Italic"
        Me.italicButton.UseVisualStyleBackColor = True
        '
        'underlineButton
        '
        Me.underlineButton.Location = New System.Drawing.Point(382, 21)
        Me.underlineButton.Name = "underlineButton"
        Me.underlineButton.Size = New System.Drawing.Size(117, 28)
        Me.underlineButton.TabIndex = 2
        Me.underlineButton.Text = "&Underline"
        Me.underlineButton.UseVisualStyleBackColor = True
        '
        'dobTextBox
        '
        Me.dobTextBox.Location = New System.Drawing.Point(159, 82)
        Me.dobTextBox.Mask = "00/00/0000"
        Me.dobTextBox.Name = "dobTextBox"
        Me.dobTextBox.Size = New System.Drawing.Size(100, 22)
        Me.dobTextBox.TabIndex = 3
        Me.dobTextBox.ValidatingType = GetType(Date)
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'boardStyleBox
        '
        Me.boardStyleBox.Controls.Add(Me.fixedSingleButton)
        Me.boardStyleBox.Controls.Add(Me.fix3dButton)
        Me.boardStyleBox.Controls.Add(Me.noneButton)
        Me.boardStyleBox.Location = New System.Drawing.Point(48, 271)
        Me.boardStyleBox.Name = "boardStyleBox"
        Me.boardStyleBox.Size = New System.Drawing.Size(521, 65)
        Me.boardStyleBox.TabIndex = 8
        Me.boardStyleBox.TabStop = False
        Me.boardStyleBox.Text = "Border Style"
        '
        'bgColor
        '
        Me.bgColor.Controls.Add(Me.blackButton)
        Me.bgColor.Controls.Add(Me.WhiteButton)
        Me.bgColor.Controls.Add(Me.greyButton)
        Me.bgColor.Location = New System.Drawing.Point(48, 342)
        Me.bgColor.Name = "bgColor"
        Me.bgColor.Size = New System.Drawing.Size(521, 63)
        Me.bgColor.TabIndex = 9
        Me.bgColor.TabStop = False
        Me.bgColor.Text = "Back Color"
        '
        'fgColor
        '
        Me.fgColor.Controls.Add(Me.yellowButton)
        Me.fgColor.Controls.Add(Me.blueButton)
        Me.fgColor.Controls.Add(Me.redButton)
        Me.fgColor.Location = New System.Drawing.Point(48, 422)
        Me.fgColor.Name = "fgColor"
        Me.fgColor.Size = New System.Drawing.Size(521, 62)
        Me.fgColor.TabIndex = 10
        Me.fgColor.TabStop = False
        Me.fgColor.Text = "Fore Color"
        '
        'fontStyle
        '
        Me.fontStyle.Controls.Add(Me.boldButton)
        Me.fontStyle.Controls.Add(Me.italicButton)
        Me.fontStyle.Controls.Add(Me.underlineButton)
        Me.fontStyle.Location = New System.Drawing.Point(48, 505)
        Me.fontStyle.Name = "fontStyle"
        Me.fontStyle.Size = New System.Drawing.Size(520, 79)
        Me.fontStyle.TabIndex = 11
        Me.fontStyle.TabStop = False
        Me.fontStyle.Text = "Font Style"
        '
        'textAlignBox
        '
        Me.textAlignBox.Controls.Add(Me.leftRadio)
        Me.textAlignBox.Controls.Add(Me.centerRadio)
        Me.textAlignBox.Controls.Add(Me.rightRadio)
        Me.textAlignBox.Location = New System.Drawing.Point(48, 590)
        Me.textAlignBox.Name = "textAlignBox"
        Me.textAlignBox.Size = New System.Drawing.Size(520, 56)
        Me.textAlignBox.TabIndex = 12
        Me.textAlignBox.TabStop = False
        Me.textAlignBox.Text = "Text Align"
        '
        'outputBox
        '
        Me.outputBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputBox.Location = New System.Drawing.Point(48, 141)
        Me.outputBox.Name = "outputBox"
        Me.outputBox.Padding = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.outputBox.Size = New System.Drawing.Size(520, 36)
        Me.outputBox.TabIndex = 5
        Me.outputBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'previewWindow
        '
        Me.AcceptButton = Me.displayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(596, 718)
        Me.Controls.Add(Me.outputBox)
        Me.Controls.Add(Me.textAlignBox)
        Me.Controls.Add(Me.fontStyle)
        Me.Controls.Add(Me.fgColor)
        Me.Controls.Add(Me.bgColor)
        Me.Controls.Add(Me.boardStyleBox)
        Me.Controls.Add(Me.dobTextBox)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.printPreviewButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.nameTextBox)
        Me.Controls.Add(Me.dobLabel)
        Me.Controls.Add(Me.visableCheckBox)
        Me.Controls.Add(Me.nameLabel)
        Me.Name = "previewWindow"
        Me.Text = "Text Formatter!"
        Me.boardStyleBox.ResumeLayout(False)
        Me.bgColor.ResumeLayout(False)
        Me.fgColor.ResumeLayout(False)
        Me.fontStyle.ResumeLayout(False)
        Me.textAlignBox.ResumeLayout(False)
        Me.textAlignBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents visableCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents dobLabel As System.Windows.Forms.Label
    Friend WithEvents nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents printPreviewButton As System.Windows.Forms.Button
    Friend WithEvents yellowButton As System.Windows.Forms.Button
    Friend WithEvents redButton As System.Windows.Forms.Button
    Friend WithEvents greyButton As System.Windows.Forms.Button
    Friend WithEvents blackButton As System.Windows.Forms.Button
    Friend WithEvents noneButton As System.Windows.Forms.Button
    Friend WithEvents fixedSingleButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents fix3dButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents resetButton As System.Windows.Forms.Button
    Friend WithEvents WhiteButton As System.Windows.Forms.Button
    Friend WithEvents blueButton As System.Windows.Forms.Button
    Friend WithEvents leftRadio As System.Windows.Forms.RadioButton
    Friend WithEvents centerRadio As System.Windows.Forms.RadioButton
    Friend WithEvents rightRadio As System.Windows.Forms.RadioButton
    Friend WithEvents boldButton As System.Windows.Forms.Button
    Friend WithEvents italicButton As System.Windows.Forms.Button
    Friend WithEvents underlineButton As System.Windows.Forms.Button
    Friend WithEvents dobTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents bgColor As System.Windows.Forms.GroupBox
    Friend WithEvents boardStyleBox As System.Windows.Forms.GroupBox
    Friend WithEvents fontStyle As System.Windows.Forms.GroupBox
    Friend WithEvents fgColor As System.Windows.Forms.GroupBox
    Friend WithEvents textAlignBox As System.Windows.Forms.GroupBox
    Friend WithEvents resetToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents outputBox As System.Windows.Forms.Label

End Class
