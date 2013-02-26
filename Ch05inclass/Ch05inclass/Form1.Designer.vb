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
        Me.components = New System.ComponentModel.Container
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DesignToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.YourmomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SandwhichToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.totalContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FontToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.TotalContextMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SubTotalTextBox = New System.Windows.Forms.TextBox
        Me.subTotalcContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ColorToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.SubTotalContextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.totalContextMenu.SuspendLayout()
        Me.subTotalcContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem, Me.YourmomToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem, Me.ToolStripTextBox1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DesignToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DesignToolStripMenuItem
        '
        Me.DesignToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.DesignToolStripMenuItem.Name = "DesignToolStripMenuItem"
        Me.DesignToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DesignToolStripMenuItem.Text = "Design"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Checked = True
        Me.FontToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'YourmomToolStripMenuItem
        '
        Me.YourmomToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SandwhichToolStripMenuItem})
        Me.YourmomToolStripMenuItem.Name = "YourmomToolStripMenuItem"
        Me.YourmomToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.YourmomToolStripMenuItem.Text = "Your-mom"
        '
        'SandwhichToolStripMenuItem
        '
        Me.SandwhichToolStripMenuItem.Name = "SandwhichToolStripMenuItem"
        Me.SandwhichToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.SandwhichToolStripMenuItem.Text = "Sandwhich"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.ContextMenuStrip = Me.totalContextMenu
        Me.TotalTextBox.Location = New System.Drawing.Point(57, 166)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(85, 20)
        Me.TotalTextBox.TabIndex = 1
        '
        'totalContextMenu
        '
        Me.totalContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem1, Me.FontToolStripMenuItem2, Me.TotalContextMenuToolStripMenuItem, Me.ClearToolStripMenuItem2})
        Me.totalContextMenu.Name = "totalContextMenu"
        Me.totalContextMenu.Size = New System.Drawing.Size(174, 114)
        '
        'ColorToolStripMenuItem1
        '
        Me.ColorToolStripMenuItem1.Name = "ColorToolStripMenuItem1"
        Me.ColorToolStripMenuItem1.Size = New System.Drawing.Size(173, 22)
        Me.ColorToolStripMenuItem1.Text = "Color"
        '
        'FontToolStripMenuItem2
        '
        Me.FontToolStripMenuItem2.Name = "FontToolStripMenuItem2"
        Me.FontToolStripMenuItem2.Size = New System.Drawing.Size(173, 22)
        Me.FontToolStripMenuItem2.Text = "Font"
        '
        'TotalContextMenuToolStripMenuItem
        '
        Me.TotalContextMenuToolStripMenuItem.Name = "TotalContextMenuToolStripMenuItem"
        Me.TotalContextMenuToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.TotalContextMenuToolStripMenuItem.Text = "TotalContextMenu"
        '
        'SubTotalTextBox
        '
        Me.SubTotalTextBox.ContextMenuStrip = Me.subTotalcContext
        Me.SubTotalTextBox.Location = New System.Drawing.Point(57, 111)
        Me.SubTotalTextBox.Name = "SubTotalTextBox"
        Me.SubTotalTextBox.Size = New System.Drawing.Size(182, 20)
        Me.SubTotalTextBox.TabIndex = 2
        '
        'subTotalcContext
        '
        Me.subTotalcContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem1, Me.ColorToolStripMenuItem2, Me.SubTotalContextToolStripMenuItem, Me.ClearToolStripMenuItem1})
        Me.subTotalcContext.Name = "ContextMenuStrip1"
        Me.subTotalcContext.Size = New System.Drawing.Size(163, 92)
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.FontToolStripMenuItem1.Text = "&Font"
        '
        'ColorToolStripMenuItem2
        '
        Me.ColorToolStripMenuItem2.Name = "ColorToolStripMenuItem2"
        Me.ColorToolStripMenuItem2.Size = New System.Drawing.Size(162, 22)
        Me.ColorToolStripMenuItem2.Text = "Color"
        '
        'SubTotalContextToolStripMenuItem
        '
        Me.SubTotalContextToolStripMenuItem.Name = "SubTotalContextToolStripMenuItem"
        Me.SubTotalContextToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.SubTotalContextToolStripMenuItem.Text = "SubTotalContext"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(162, 22)
        Me.ClearToolStripMenuItem1.Text = "Clear"
        '
        'ClearToolStripMenuItem2
        '
        Me.ClearToolStripMenuItem2.Name = "ClearToolStripMenuItem2"
        Me.ClearToolStripMenuItem2.Size = New System.Drawing.Size(173, 22)
        Me.ClearToolStripMenuItem2.Text = "Clear"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.SubTotalTextBox)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.totalContextMenu.ResumeLayout(False)
        Me.subTotalcContext.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YourmomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DesignToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SandwhichToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents subTotalcContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents FontToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents totalContextMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubTotalContextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalContextMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
