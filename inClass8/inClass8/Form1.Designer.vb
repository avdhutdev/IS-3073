<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesForm
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
        Me.titleBox = New System.Windows.Forms.TextBox
        Me.QuantityBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.priceBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.extendedPriceBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculateSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.summaryMenuStrip = New System.Windows.Forms.ToolStripMenuItem
        Me.studentCheckBox = New System.Windows.Forms.CheckBox
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'titleBox
        '
        Me.titleBox.Location = New System.Drawing.Point(203, 70)
        Me.titleBox.Name = "titleBox"
        Me.titleBox.Size = New System.Drawing.Size(266, 20)
        Me.titleBox.TabIndex = 1
        '
        'QuantityBox
        '
        Me.QuantityBox.Location = New System.Drawing.Point(203, 125)
        Me.QuantityBox.Name = "QuantityBox"
        Me.QuantityBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantity"
        '
        'priceBox
        '
        Me.priceBox.Location = New System.Drawing.Point(203, 164)
        Me.priceBox.Name = "priceBox"
        Me.priceBox.Size = New System.Drawing.Size(100, 20)
        Me.priceBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Price"
        '
        'extendedPriceBox
        '
        Me.extendedPriceBox.Location = New System.Drawing.Point(203, 200)
        Me.extendedPriceBox.Name = "extendedPriceBox"
        Me.extendedPriceBox.ReadOnly = True
        Me.extendedPriceBox.Size = New System.Drawing.Size(100, 20)
        Me.extendedPriceBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Extended Price:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(518, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateSalesToolStripMenuItem, Me.summaryMenuStrip, Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'CalculateSalesToolStripMenuItem
        '
        Me.CalculateSalesToolStripMenuItem.Name = "CalculateSalesToolStripMenuItem"
        Me.CalculateSalesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CalculateSalesToolStripMenuItem.Text = "Calculate &Sales"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'summaryMenuStrip
        '
        Me.summaryMenuStrip.Name = "summaryMenuStrip"
        Me.summaryMenuStrip.Size = New System.Drawing.Size(152, 22)
        Me.summaryMenuStrip.Text = "Summary"
        '
        'studentCheckBox
        '
        Me.studentCheckBox.AutoSize = True
        Me.studentCheckBox.Location = New System.Drawing.Point(423, 123)
        Me.studentCheckBox.Name = "studentCheckBox"
        Me.studentCheckBox.Size = New System.Drawing.Size(74, 17)
        Me.studentCheckBox.TabIndex = 9
        Me.studentCheckBox.Text = "Is Student"
        Me.studentCheckBox.UseVisualStyleBackColor = True
        '
        'SalesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 261)
        Me.Controls.Add(Me.studentCheckBox)
        Me.Controls.Add(Me.extendedPriceBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.priceBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.QuantityBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.titleBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SalesForm"
        Me.Text = "SalesForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents titleBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents priceBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents extendedPriceBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculateSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents summaryMenuStrip As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents studentCheckBox As System.Windows.Forms.CheckBox

End Class
