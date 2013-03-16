<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vbinfo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.navigationCheckbox = New System.Windows.Forms.CheckBox
        Me.leatherCheckbox = New System.Windows.Forms.CheckBox
        Me.stereoCheckbox = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.customizedRadio = New System.Windows.Forms.RadioButton
        Me.pearlRadio = New System.Windows.Forms.RadioButton
        Me.standardRadio = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.carSalesPriceTextBox = New System.Windows.Forms.TextBox
        Me.accessoriesFinishLabel = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.subTotalBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.salesTaxBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.totalBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tradeInValueBox = New System.Windows.Forms.TextBox
        Me.tradeinLabel = New System.Windows.Forms.Label
        Me.amountDueBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.calcButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CLearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.navigationCheckbox)
        Me.GroupBox1.Controls.Add(Me.leatherCheckbox)
        Me.GroupBox1.Controls.Add(Me.stereoCheckbox)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 143)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Accessories"
        '
        'navigationCheckbox
        '
        Me.navigationCheckbox.AutoSize = True
        Me.navigationCheckbox.Location = New System.Drawing.Point(19, 88)
        Me.navigationCheckbox.Name = "navigationCheckbox"
        Me.navigationCheckbox.Size = New System.Drawing.Size(162, 21)
        Me.navigationCheckbox.TabIndex = 2
        Me.navigationCheckbox.Text = "Computer &Navigation"
        Me.navigationCheckbox.UseVisualStyleBackColor = True
        '
        'leatherCheckbox
        '
        Me.leatherCheckbox.AutoSize = True
        Me.leatherCheckbox.Location = New System.Drawing.Point(19, 61)
        Me.leatherCheckbox.Name = "leatherCheckbox"
        Me.leatherCheckbox.Size = New System.Drawing.Size(127, 21)
        Me.leatherCheckbox.TabIndex = 1
        Me.leatherCheckbox.Text = "Leather &Interior"
        Me.leatherCheckbox.UseVisualStyleBackColor = True
        '
        'stereoCheckbox
        '
        Me.stereoCheckbox.AutoSize = True
        Me.stereoCheckbox.Location = New System.Drawing.Point(19, 34)
        Me.stereoCheckbox.Name = "stereoCheckbox"
        Me.stereoCheckbox.Size = New System.Drawing.Size(122, 21)
        Me.stereoCheckbox.TabIndex = 0
        Me.stereoCheckbox.Text = "&Stereo System"
        Me.stereoCheckbox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.customizedRadio)
        Me.GroupBox2.Controls.Add(Me.pearlRadio)
        Me.GroupBox2.Controls.Add(Me.standardRadio)
        Me.GroupBox2.Location = New System.Drawing.Point(56, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 135)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exterior Finish"
        '
        'customizedRadio
        '
        Me.customizedRadio.AutoSize = True
        Me.customizedRadio.Location = New System.Drawing.Point(19, 88)
        Me.customizedRadio.Name = "customizedRadio"
        Me.customizedRadio.Size = New System.Drawing.Size(161, 21)
        Me.customizedRadio.TabIndex = 2
        Me.customizedRadio.Text = "Customized &Detailing"
        Me.customizedRadio.UseVisualStyleBackColor = True
        '
        'pearlRadio
        '
        Me.pearlRadio.AutoSize = True
        Me.pearlRadio.Location = New System.Drawing.Point(19, 61)
        Me.pearlRadio.Name = "pearlRadio"
        Me.pearlRadio.Size = New System.Drawing.Size(88, 21)
        Me.pearlRadio.TabIndex = 1
        Me.pearlRadio.Text = "&Pearlized"
        Me.pearlRadio.UseVisualStyleBackColor = True
        '
        'standardRadio
        '
        Me.standardRadio.AutoSize = True
        Me.standardRadio.Checked = True
        Me.standardRadio.Location = New System.Drawing.Point(19, 34)
        Me.standardRadio.Name = "standardRadio"
        Me.standardRadio.Size = New System.Drawing.Size(87, 21)
        Me.standardRadio.TabIndex = 0
        Me.standardRadio.TabStop = True
        Me.standardRadio.Text = "St&andard"
        Me.standardRadio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(318, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "C&ar Sales Price:"
        '
        'carSalesPriceTextBox
        '
        Me.carSalesPriceTextBox.Location = New System.Drawing.Point(466, 66)
        Me.carSalesPriceTextBox.Name = "carSalesPriceTextBox"
        Me.carSalesPriceTextBox.Size = New System.Drawing.Size(100, 22)
        Me.carSalesPriceTextBox.TabIndex = 3
        '
        'accessoriesFinishLabel
        '
        Me.accessoriesFinishLabel.Location = New System.Drawing.Point(466, 102)
        Me.accessoriesFinishLabel.Name = "accessoriesFinishLabel"
        Me.accessoriesFinishLabel.ReadOnly = True
        Me.accessoriesFinishLabel.Size = New System.Drawing.Size(100, 22)
        Me.accessoriesFinishLabel.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(318, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Accessories && Finish:"
        '
        'subTotalBox
        '
        Me.subTotalBox.Location = New System.Drawing.Point(466, 152)
        Me.subTotalBox.Name = "subTotalBox"
        Me.subTotalBox.ReadOnly = True
        Me.subTotalBox.Size = New System.Drawing.Size(100, 22)
        Me.subTotalBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Subtotal:"
        '
        'salesTaxBox
        '
        Me.salesTaxBox.Location = New System.Drawing.Point(466, 192)
        Me.salesTaxBox.Name = "salesTaxBox"
        Me.salesTaxBox.ReadOnly = True
        Me.salesTaxBox.Size = New System.Drawing.Size(100, 22)
        Me.salesTaxBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(318, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sales Tax (8%):"
        '
        'totalBox
        '
        Me.totalBox.Location = New System.Drawing.Point(466, 239)
        Me.totalBox.Name = "totalBox"
        Me.totalBox.ReadOnly = True
        Me.totalBox.Size = New System.Drawing.Size(100, 22)
        Me.totalBox.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(318, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total:"
        '
        'tradeInValueBox
        '
        Me.tradeInValueBox.Location = New System.Drawing.Point(466, 278)
        Me.tradeInValueBox.Name = "tradeInValueBox"
        Me.tradeInValueBox.Size = New System.Drawing.Size(100, 22)
        Me.tradeInValueBox.TabIndex = 13
        Me.tradeInValueBox.Text = "0"
        '
        'tradeinLabel
        '
        Me.tradeinLabel.AutoSize = True
        Me.tradeinLabel.Location = New System.Drawing.Point(317, 281)
        Me.tradeinLabel.Name = "tradeinLabel"
        Me.tradeinLabel.Size = New System.Drawing.Size(133, 17)
        Me.tradeinLabel.TabIndex = 12
        Me.tradeinLabel.Text = "T&rade-in Allowance:"
        '
        'amountDueBox
        '
        Me.amountDueBox.Location = New System.Drawing.Point(466, 321)
        Me.amountDueBox.Name = "amountDueBox"
        Me.amountDueBox.ReadOnly = True
        Me.amountDueBox.Size = New System.Drawing.Size(100, 22)
        Me.amountDueBox.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(318, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Amount Due:"
        '
        'calcButton
        '
        Me.calcButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.calcButton.Location = New System.Drawing.Point(287, 387)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(75, 23)
        Me.calcButton.TabIndex = 16
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(394, 387)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 17
        Me.clearButton.Text = "C&lear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(491, 387)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 18
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(637, 28)
        Me.MenuStrip1.TabIndex = 19
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.CLearToolStripMenuItem, Me.ToolStripSeparator1, Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.CalculateToolStripMenuItem.Text = "&Calculate"
        '
        'CLearToolStripMenuItem
        '
        Me.CLearToolStripMenuItem.Name = "CLearToolStripMenuItem"
        Me.CLearToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.CLearToolStripMenuItem.Text = "C&lear"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.ColorToolStripMenuItem.Text = "C&olor"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 24)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'vbinfo
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(637, 453)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.amountDueBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tradeInValueBox)
        Me.Controls.Add(Me.tradeinLabel)
        Me.Controls.Add(Me.totalBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.salesTaxBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.subTotalBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.accessoriesFinishLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.carSalesPriceTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "vbinfo"
        Me.Text = "VB Auto Center"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents navigationCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents leatherCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents stereoCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents standardRadio As System.Windows.Forms.RadioButton
    Friend WithEvents customizedRadio As System.Windows.Forms.RadioButton
    Friend WithEvents pearlRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents carSalesPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents accessoriesFinishLabel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents subTotalBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents salesTaxBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents totalBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tradeinLabel As System.Windows.Forms.Label
    Friend WithEvents amountDueBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents calcButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CLearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Public WithEvents tradeInValueBox As System.Windows.Forms.TextBox

End Class
