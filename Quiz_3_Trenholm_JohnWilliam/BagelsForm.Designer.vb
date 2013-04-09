Partial Public Class BagelsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BagelsForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintBagelListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddBagelTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveBagelTypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearBagelListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.DisplayBagelTypeCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BagelTypesComboBox = New System.Windows.Forms.ComboBox
        Me.PrintBagelsPrintDocument = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.OrderSummaryComboBox = New System.Windows.Forms.ComboBox
        Me.orderButton = New System.Windows.Forms.Button
        Me.removeButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(63, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "&Bagel Types:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(485, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBagelListToolStripMenuItem1, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintBagelListToolStripMenuItem1
        '
        Me.PrintBagelListToolStripMenuItem1.Name = "PrintBagelListToolStripMenuItem1"
        Me.PrintBagelListToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintBagelListToolStripMenuItem1.Size = New System.Drawing.Size(193, 22)
        Me.PrintBagelListToolStripMenuItem1.Text = "&Print Bagel List"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(190, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBagelTypeToolStripMenuItem, Me.RemoveBagelTypeToolStripMenuItem, Me.ClearBagelListToolStripMenuItem, Me.ToolStripSeparator2, Me.DisplayBagelTypeCountToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'AddBagelTypeToolStripMenuItem
        '
        Me.AddBagelTypeToolStripMenuItem.Name = "AddBagelTypeToolStripMenuItem"
        Me.AddBagelTypeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AddBagelTypeToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AddBagelTypeToolStripMenuItem.Text = "&Add Bagel Type"
        '
        'RemoveBagelTypeToolStripMenuItem
        '
        Me.RemoveBagelTypeToolStripMenuItem.Name = "RemoveBagelTypeToolStripMenuItem"
        Me.RemoveBagelTypeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.RemoveBagelTypeToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.RemoveBagelTypeToolStripMenuItem.Text = "&Remove Bagel Type"
        '
        'ClearBagelListToolStripMenuItem
        '
        Me.ClearBagelListToolStripMenuItem.Name = "ClearBagelListToolStripMenuItem"
        Me.ClearBagelListToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.ClearBagelListToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ClearBagelListToolStripMenuItem.Text = "&Clear Bagel List"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(216, 6)
        '
        'DisplayBagelTypeCountToolStripMenuItem
        '
        Me.DisplayBagelTypeCountToolStripMenuItem.Name = "DisplayBagelTypeCountToolStripMenuItem"
        Me.DisplayBagelTypeCountToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.DisplayBagelTypeCountToolStripMenuItem.Text = "&Display Bagel Type Count"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'BagelTypesComboBox
        '
        Me.BagelTypesComboBox.FormattingEnabled = True
        Me.BagelTypesComboBox.Items.AddRange(New Object() {"Banana nut", "Blueberry", "Egg", "Plain", "Poppy Seed", "Rye", "Salt", "Sesame Seed"})
        Me.BagelTypesComboBox.Location = New System.Drawing.Point(63, 95)
        Me.BagelTypesComboBox.Name = "BagelTypesComboBox"
        Me.BagelTypesComboBox.Size = New System.Drawing.Size(121, 21)
        Me.BagelTypesComboBox.Sorted = True
        Me.BagelTypesComboBox.TabIndex = 2
        '
        'PrintBagelsPrintDocument
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'OrderSummaryComboBox
        '
        Me.OrderSummaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.OrderSummaryComboBox.FormattingEnabled = True
        Me.OrderSummaryComboBox.Location = New System.Drawing.Point(256, 95)
        Me.OrderSummaryComboBox.Name = "OrderSummaryComboBox"
        Me.OrderSummaryComboBox.Size = New System.Drawing.Size(128, 176)
        Me.OrderSummaryComboBox.TabIndex = 4
        '
        'orderButton
        '
        Me.orderButton.Location = New System.Drawing.Point(88, 302)
        Me.orderButton.Name = "orderButton"
        Me.orderButton.Size = New System.Drawing.Size(75, 23)
        Me.orderButton.TabIndex = 5
        Me.orderButton.Text = "&Order"
        Me.orderButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(280, 302)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(75, 23)
        Me.removeButton.TabIndex = 6
        Me.removeButton.Text = "Re&move"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Order Summary"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(241, 264)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 35)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Please select or enter the name of the item that you want to remove"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(38, 264)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 35)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Please select the item that you want to order and press the order button"
        '
        'BagelsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 379)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.removeButton)
        Me.Controls.Add(Me.orderButton)
        Me.Controls.Add(Me.OrderSummaryComboBox)
        Me.Controls.Add(Me.BagelTypesComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "BagelsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bradley's Bagels"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintBagelListToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBagelTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveBagelTypeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearBagelListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisplayBagelTypeCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BagelTypesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PrintBagelsPrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents OrderSummaryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents orderButton As System.Windows.Forms.Button
    Friend WithEvents removeButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
