<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.chkBalTextBox = New System.Windows.Forms.TextBox
        Me.CustomerLabel = New System.Windows.Forms.Label
        Me.BalanceLabel = New System.Windows.Forms.Label
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox
        Me.AmountLabel = New System.Windows.Forms.Label
        Me.typeLabel = New System.Windows.Forms.Label
        Me.amountTextBox = New System.Windows.Forms.TextBox
        Me.depositRadioButton = New System.Windows.Forms.RadioButton
        Me.withdrawRadioButton = New System.Windows.Forms.RadioButton
        Me.addButton = New System.Windows.Forms.Button
        Me.okButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.accountListBox = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.savBalTextBox = New System.Windows.Forms.TextBox
        Me.summaryButton = New System.Windows.Forms.Button
        Me.removeButton = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ShowToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(453, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.ShowToolStripMenuItem.Text = "&Edit"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'chkBalTextBox
        '
        Me.chkBalTextBox.Location = New System.Drawing.Point(278, 107)
        Me.chkBalTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBalTextBox.Name = "chkBalTextBox"
        Me.chkBalTextBox.ReadOnly = True
        Me.chkBalTextBox.Size = New System.Drawing.Size(98, 20)
        Me.chkBalTextBox.TabIndex = 11
        Me.chkBalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CustomerLabel
        '
        Me.CustomerLabel.AutoSize = True
        Me.CustomerLabel.Location = New System.Drawing.Point(147, 55)
        Me.CustomerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(82, 13)
        Me.CustomerLabel.TabIndex = 1
        Me.CustomerLabel.Text = "Customer Name"
        '
        'BalanceLabel
        '
        Me.BalanceLabel.AutoSize = True
        Me.BalanceLabel.Location = New System.Drawing.Point(250, 81)
        Me.BalanceLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(137, 13)
        Me.BalanceLabel.TabIndex = 10
        Me.BalanceLabel.Text = "Checking Account Balance"
        '
        'CustomerComboBox
        '
        Me.CustomerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Items.AddRange(New Object() {"Adam", "Christine", "John", "Tracy"})
        Me.CustomerComboBox.Location = New System.Drawing.Point(126, 81)
        Me.CustomerComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(92, 112)
        Me.CustomerComboBox.Sorted = True
        Me.CustomerComboBox.TabIndex = 4
        '
        'AmountLabel
        '
        Me.AmountLabel.AutoSize = True
        Me.AmountLabel.Location = New System.Drawing.Point(9, 280)
        Me.AmountLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.AmountLabel.Name = "AmountLabel"
        Me.AmountLabel.Size = New System.Drawing.Size(102, 13)
        Me.AmountLabel.TabIndex = 8
        Me.AmountLabel.Text = "Transaction Amount"
        '
        'typeLabel
        '
        Me.typeLabel.AutoSize = True
        Me.typeLabel.Location = New System.Drawing.Point(21, 202)
        Me.typeLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(90, 13)
        Me.typeLabel.TabIndex = 5
        Me.typeLabel.Text = "Transaction Type"
        '
        'amountTextBox
        '
        Me.amountTextBox.Location = New System.Drawing.Point(126, 280)
        Me.amountTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(98, 20)
        Me.amountTextBox.TabIndex = 9
        '
        'depositRadioButton
        '
        Me.depositRadioButton.AutoSize = True
        Me.depositRadioButton.Location = New System.Drawing.Point(126, 236)
        Me.depositRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.depositRadioButton.Name = "depositRadioButton"
        Me.depositRadioButton.Size = New System.Drawing.Size(61, 17)
        Me.depositRadioButton.TabIndex = 7
        Me.depositRadioButton.TabStop = True
        Me.depositRadioButton.Text = "&Deposit"
        Me.depositRadioButton.UseVisualStyleBackColor = True
        '
        'withdrawRadioButton
        '
        Me.withdrawRadioButton.AutoSize = True
        Me.withdrawRadioButton.Location = New System.Drawing.Point(126, 202)
        Me.withdrawRadioButton.Margin = New System.Windows.Forms.Padding(2)
        Me.withdrawRadioButton.Name = "withdrawRadioButton"
        Me.withdrawRadioButton.Size = New System.Drawing.Size(70, 17)
        Me.withdrawRadioButton.TabIndex = 6
        Me.withdrawRadioButton.TabStop = True
        Me.withdrawRadioButton.Text = "&Withdraw"
        Me.withdrawRadioButton.UseVisualStyleBackColor = True
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(34, 81)
        Me.addButton.Margin = New System.Windows.Forms.Padding(2)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(66, 24)
        Me.addButton.TabIndex = 2
        Me.addButton.Text = "&Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(23, 331)
        Me.okButton.Margin = New System.Windows.Forms.Padding(2)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(56, 21)
        Me.okButton.TabIndex = 16
        Me.okButton.Text = "&OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(252, 331)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(59, 21)
        Me.clearButton.TabIndex = 18
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(346, 331)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(56, 21)
        Me.exitButton.TabIndex = 19
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'accountListBox
        '
        Me.accountListBox.FormattingEnabled = True
        Me.accountListBox.Items.AddRange(New Object() {"Checking Account", "Savings Account"})
        Me.accountListBox.Location = New System.Drawing.Point(252, 236)
        Me.accountListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.accountListBox.Name = "accountListBox"
        Me.accountListBox.Size = New System.Drawing.Size(125, 30)
        Me.accountListBox.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(250, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Please choose a deposit account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(250, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Savings Account Balance"
        '
        'savBalTextBox
        '
        Me.savBalTextBox.Location = New System.Drawing.Point(278, 158)
        Me.savBalTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.savBalTextBox.Name = "savBalTextBox"
        Me.savBalTextBox.ReadOnly = True
        Me.savBalTextBox.Size = New System.Drawing.Size(98, 20)
        Me.savBalTextBox.TabIndex = 13
        Me.savBalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'summaryButton
        '
        Me.summaryButton.Location = New System.Drawing.Point(126, 331)
        Me.summaryButton.Margin = New System.Windows.Forms.Padding(2)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(68, 21)
        Me.summaryButton.TabIndex = 17
        Me.summaryButton.Text = "&Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(34, 126)
        Me.removeButton.Margin = New System.Windows.Forms.Padding(2)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(66, 23)
        Me.removeButton.TabIndex = 3
        Me.removeButton.Text = "&Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'TransactionForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(453, 395)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.summaryButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.savBalTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.accountListBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.addButton)
        Me.Controls.Add(Me.withdrawRadioButton)
        Me.Controls.Add(Me.depositRadioButton)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.typeLabel)
        Me.Controls.Add(Me.AmountLabel)
        Me.Controls.Add(Me.CustomerComboBox)
        Me.Controls.Add(Me.BalanceLabel)
        Me.Controls.Add(Me.CustomerLabel)
        Me.Controls.Add(Me.chkBalTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TransactionForm"
        Me.Text = "Transaction Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkBalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerLabel As System.Windows.Forms.Label
    Friend WithEvents BalanceLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AmountLabel As System.Windows.Forms.Label
    Friend WithEvents typeLabel As System.Windows.Forms.Label
    Friend WithEvents amountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents depositRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents withdrawRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents addButton As System.Windows.Forms.Button
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents accountListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents savBalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents summaryButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button

End Class
