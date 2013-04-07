<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class summaryForm
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
        Me.ExitButton = New System.Windows.Forms.Button
        Me.SumTotalTradeInsTextBox = New System.Windows.Forms.TextBox
        Me.SumTotalSalesTextBox = New System.Windows.Forms.TextBox
        Me.SumNumOfSalesTextBox = New System.Windows.Forms.TextBox
        Me.TtlTradeLabel = New System.Windows.Forms.Label
        Me.NumSalesLabel = New System.Windows.Forms.Label
        Me.TtlSalesLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(207, 147)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(100, 28)
        Me.ExitButton.TabIndex = 13
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SumTotalTradeInsTextBox
        '
        Me.SumTotalTradeInsTextBox.Location = New System.Drawing.Point(174, 115)
        Me.SumTotalTradeInsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SumTotalTradeInsTextBox.Name = "SumTotalTradeInsTextBox"
        Me.SumTotalTradeInsTextBox.ReadOnly = True
        Me.SumTotalTradeInsTextBox.Size = New System.Drawing.Size(132, 22)
        Me.SumTotalTradeInsTextBox.TabIndex = 12
        '
        'SumTotalSalesTextBox
        '
        Me.SumTotalSalesTextBox.Location = New System.Drawing.Point(174, 73)
        Me.SumTotalSalesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SumTotalSalesTextBox.Name = "SumTotalSalesTextBox"
        Me.SumTotalSalesTextBox.ReadOnly = True
        Me.SumTotalSalesTextBox.Size = New System.Drawing.Size(132, 22)
        Me.SumTotalSalesTextBox.TabIndex = 11
        '
        'SumNumOfSalesTextBox
        '
        Me.SumNumOfSalesTextBox.Location = New System.Drawing.Point(174, 38)
        Me.SumNumOfSalesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SumNumOfSalesTextBox.Name = "SumNumOfSalesTextBox"
        Me.SumNumOfSalesTextBox.ReadOnly = True
        Me.SumNumOfSalesTextBox.Size = New System.Drawing.Size(132, 22)
        Me.SumNumOfSalesTextBox.TabIndex = 10
        '
        'TtlTradeLabel
        '
        Me.TtlTradeLabel.Location = New System.Drawing.Point(32, 119)
        Me.TtlTradeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TtlTradeLabel.Name = "TtlTradeLabel"
        Me.TtlTradeLabel.Size = New System.Drawing.Size(133, 28)
        Me.TtlTradeLabel.TabIndex = 9
        Me.TtlTradeLabel.Text = "Total Trade-Ins:"
        '
        'NumSalesLabel
        '
        Me.NumSalesLabel.Location = New System.Drawing.Point(32, 41)
        Me.NumSalesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumSalesLabel.Name = "NumSalesLabel"
        Me.NumSalesLabel.Size = New System.Drawing.Size(133, 28)
        Me.NumSalesLabel.TabIndex = 8
        Me.NumSalesLabel.Text = "Number of Sales:"
        '
        'TtlSalesLabel
        '
        Me.TtlSalesLabel.Location = New System.Drawing.Point(32, 77)
        Me.TtlSalesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TtlSalesLabel.Name = "TtlSalesLabel"
        Me.TtlSalesLabel.Size = New System.Drawing.Size(133, 28)
        Me.TtlSalesLabel.TabIndex = 7
        Me.TtlSalesLabel.Text = "Total Sales:"
        '
        'summaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 237)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SumTotalTradeInsTextBox)
        Me.Controls.Add(Me.SumTotalSalesTextBox)
        Me.Controls.Add(Me.SumNumOfSalesTextBox)
        Me.Controls.Add(Me.TtlTradeLabel)
        Me.Controls.Add(Me.NumSalesLabel)
        Me.Controls.Add(Me.TtlSalesLabel)
        Me.Name = "summaryForm"
        Me.Text = "Summary Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents SumTotalTradeInsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SumTotalSalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SumNumOfSalesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TtlTradeLabel As System.Windows.Forms.Label
    Friend WithEvents NumSalesLabel As System.Windows.Forms.Label
    Friend WithEvents TtlSalesLabel As System.Windows.Forms.Label
End Class
