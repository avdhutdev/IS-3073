Partial Public Class TransactionForm
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OrderTotalTextBox = New System.Windows.Forms.TextBox
        Me.transactionTotalTextBox = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.MonogramGroupBox = New System.Windows.Forms.GroupBox
        Me.PocketCheckBox = New System.Windows.Forms.CheckBox
        Me.MonogramCheckBox = New System.Windows.Forms.CheckBox
        Me.QuantityTextBox = New System.Windows.Forms.TextBox
        Me.OrderNumberTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SummaryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddtoOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveFromOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearThisItemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderCompleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.optionsMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MonogramMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.pocketMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.sizeMenuItem = New System.Windows.Forms.ToolStripComboBox
        Me.sizeListBox = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.MonogramGroupBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OrderTotalTextBox
        '
        Me.OrderTotalTextBox.Location = New System.Drawing.Point(312, 329)
        Me.OrderTotalTextBox.Name = "OrderTotalTextBox"
        Me.OrderTotalTextBox.ReadOnly = True
        Me.OrderTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OrderTotalTextBox.TabIndex = 13
        Me.OrderTotalTextBox.TabStop = False
        Me.OrderTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'transactionTotalTextBox
        '
        Me.transactionTotalTextBox.Location = New System.Drawing.Point(310, 284)
        Me.transactionTotalTextBox.Name = "transactionTotalTextBox"
        Me.transactionTotalTextBox.ReadOnly = True
        Me.transactionTotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.transactionTotalTextBox.TabIndex = 11
        Me.transactionTotalTextBox.TabStop = False
        Me.transactionTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(214, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Order Total:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(216, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 1)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Label6"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Transaction Total:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MonogramGroupBox
        '
        Me.MonogramGroupBox.Controls.Add(Me.PocketCheckBox)
        Me.MonogramGroupBox.Controls.Add(Me.MonogramCheckBox)
        Me.MonogramGroupBox.Location = New System.Drawing.Point(230, 154)
        Me.MonogramGroupBox.Name = "MonogramGroupBox"
        Me.MonogramGroupBox.Size = New System.Drawing.Size(153, 77)
        Me.MonogramGroupBox.TabIndex = 9
        Me.MonogramGroupBox.TabStop = False
        '
        'PocketCheckBox
        '
        Me.PocketCheckBox.Location = New System.Drawing.Point(16, 40)
        Me.PocketCheckBox.Name = "PocketCheckBox"
        Me.PocketCheckBox.Size = New System.Drawing.Size(110, 15)
        Me.PocketCheckBox.TabIndex = 1
        Me.PocketCheckBox.Text = "Poc&ket       Add $1"
        '
        'MonogramCheckBox
        '
        Me.MonogramCheckBox.Location = New System.Drawing.Point(16, 16)
        Me.MonogramCheckBox.Name = "MonogramCheckBox"
        Me.MonogramCheckBox.Size = New System.Drawing.Size(122, 20)
        Me.MonogramCheckBox.TabIndex = 0
        Me.MonogramCheckBox.Text = "Monog&ram Add $2"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(104, 87)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 2
        '
        'OrderNumberTextBox
        '
        Me.OrderNumberTextBox.Location = New System.Drawing.Point(106, 54)
        Me.OrderNumberTextBox.Name = "OrderNumberTextBox"
        Me.OrderNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.OrderNumberTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Quantity"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Order Number"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SaleToolStripMenuItem, Me.optionsMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(445, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SummaryToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SummaryToolStripMenuItem
        '
        Me.SummaryToolStripMenuItem.Enabled = False
        Me.SummaryToolStripMenuItem.Name = "SummaryToolStripMenuItem"
        Me.SummaryToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SummaryToolStripMenuItem.Text = "&Summary"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(122, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SaleToolStripMenuItem
        '
        Me.SaleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddtoOrderToolStripMenuItem, Me.RemoveFromOrderToolStripMenuItem, Me.ClearThisItemToolStripMenuItem, Me.OrderCompleteToolStripMenuItem})
        Me.SaleToolStripMenuItem.Name = "SaleToolStripMenuItem"
        Me.SaleToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.SaleToolStripMenuItem.Text = "&Sale"
        '
        'AddtoOrderToolStripMenuItem
        '
        Me.AddtoOrderToolStripMenuItem.Name = "AddtoOrderToolStripMenuItem"
        Me.AddtoOrderToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.AddtoOrderToolStripMenuItem.Text = "&Add to Order"
        '
        'RemoveFromOrderToolStripMenuItem
        '
        Me.RemoveFromOrderToolStripMenuItem.Name = "RemoveFromOrderToolStripMenuItem"
        Me.RemoveFromOrderToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.RemoveFromOrderToolStripMenuItem.Text = "&Remove from Order"
        '
        'ClearThisItemToolStripMenuItem
        '
        Me.ClearThisItemToolStripMenuItem.Name = "ClearThisItemToolStripMenuItem"
        Me.ClearThisItemToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ClearThisItemToolStripMenuItem.Text = "C&lear This Item"
        '
        'OrderCompleteToolStripMenuItem
        '
        Me.OrderCompleteToolStripMenuItem.Enabled = False
        Me.OrderCompleteToolStripMenuItem.Name = "OrderCompleteToolStripMenuItem"
        Me.OrderCompleteToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.OrderCompleteToolStripMenuItem.Text = "O&rder Complete"
        '
        'optionsMenuItem
        '
        Me.optionsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.MonogramMenuItem, Me.pocketMenuItem, Me.sizeMenuItem})
        Me.optionsMenuItem.Name = "optionsMenuItem"
        Me.optionsMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.optionsMenuItem.Text = "&Options"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(209, 6)
        '
        'MonogramMenuItem
        '
        Me.MonogramMenuItem.Name = "MonogramMenuItem"
        Me.MonogramMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.MonogramMenuItem.Text = "&Monogram"
        '
        'pocketMenuItem
        '
        Me.pocketMenuItem.Name = "pocketMenuItem"
        Me.pocketMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.pocketMenuItem.Text = "&Pocket"
        '
        'sizeMenuItem
        '
        Me.sizeMenuItem.Items.AddRange(New Object() {"Small", "Medium", "Large", "Extra Large"})
        Me.sizeMenuItem.Name = "sizeMenuItem"
        Me.sizeMenuItem.Size = New System.Drawing.Size(152, 23)
        Me.sizeMenuItem.Text = "Please select a size"
        '
        'sizeListBox
        '
        Me.sizeListBox.FormattingEnabled = True
        Me.sizeListBox.Items.AddRange(New Object() {"Small", "Medium", "Large", "Extra Large"})
        Me.sizeListBox.Location = New System.Drawing.Point(104, 162)
        Me.sizeListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.sizeListBox.Name = "sizeListBox"
        Me.sizeListBox.Size = New System.Drawing.Size(93, 95)
        Me.sizeListBox.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(104, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 14)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Please select a size or enter the size in the textbox below"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(227, 121)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Please specify extra feature"
        '
        'TransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 390)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.sizeListBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.OrderTotalTextBox)
        Me.Controls.Add(Me.OrderNumberTextBox)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.MonogramGroupBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.transactionTotalTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TransactionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction Form"
        Me.MonogramGroupBox.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents transactionTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MonogramGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents PocketCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents MonogramCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrderNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SummaryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddtoOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearThisItemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderCompleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents optionsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MonogramMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pocketMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sizeListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents sizeMenuItem As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents RemoveFromOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
