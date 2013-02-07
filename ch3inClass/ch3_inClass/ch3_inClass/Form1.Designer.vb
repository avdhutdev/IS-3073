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
        Me.priceTextBox = New System.Windows.Forms.TextBox
        Me.quantityTextBox = New System.Windows.Forms.TextBox
        Me.priceLabel = New System.Windows.Forms.Label
        Me.quantityLabel = New System.Windows.Forms.Label
        Me.totalLabel = New System.Windows.Forms.Label
        Me.totalTextBox = New System.Windows.Forms.TextBox
        Me.exitButton = New System.Windows.Forms.Button
        Me.calculateButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.orderTotalTextBox = New System.Windows.Forms.TextBox
        Me.orderTotalLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(147, 56)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(160, 20)
        Me.priceTextBox.TabIndex = 0
        '
        'quantityTextBox
        '
        Me.quantityTextBox.Location = New System.Drawing.Point(147, 82)
        Me.quantityTextBox.Name = "quantityTextBox"
        Me.quantityTextBox.Size = New System.Drawing.Size(160, 20)
        Me.quantityTextBox.TabIndex = 1
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(102, 63)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(30, 13)
        Me.priceLabel.TabIndex = 2
        Me.priceLabel.Text = "price"
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.Location = New System.Drawing.Point(102, 89)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(44, 13)
        Me.quantityLabel.TabIndex = 3
        Me.quantityLabel.Text = "quantity"
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(114, 147)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(27, 13)
        Me.totalLabel.TabIndex = 4
        Me.totalLabel.Text = "total"
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(147, 140)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(160, 20)
        Me.totalTextBox.TabIndex = 5
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(292, 227)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'calculateButton
        '
        Me.calculateButton.Location = New System.Drawing.Point(172, 227)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 7
        Me.calculateButton.Text = "calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(66, 227)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 8
        Me.clearButton.Text = "clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'orderTotalTextBox
        '
        Me.orderTotalTextBox.Location = New System.Drawing.Point(147, 181)
        Me.orderTotalTextBox.Name = "orderTotalTextBox"
        Me.orderTotalTextBox.Size = New System.Drawing.Size(160, 20)
        Me.orderTotalTextBox.TabIndex = 9
        '
        'orderTotalLabel
        '
        Me.orderTotalLabel.AutoSize = True
        Me.orderTotalLabel.Location = New System.Drawing.Point(86, 188)
        Me.orderTotalLabel.Name = "orderTotalLabel"
        Me.orderTotalLabel.Size = New System.Drawing.Size(55, 13)
        Me.orderTotalLabel.TabIndex = 10
        Me.orderTotalLabel.Text = "orderTotal"
        '
        'Form1
        '
        Me.AcceptButton = Me.calculateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(413, 324)
        Me.Controls.Add(Me.orderTotalLabel)
        Me.Controls.Add(Me.orderTotalTextBox)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.quantityLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.quantityTextBox)
        Me.Controls.Add(Me.priceTextBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents priceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents quantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents priceLabel As System.Windows.Forms.Label
    Friend WithEvents quantityLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents totalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents orderTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents orderTotalLabel As System.Windows.Forms.Label

End Class
