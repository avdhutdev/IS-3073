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
        Me.Label1 = New System.Windows.Forms.Label
        Me.totalDepositTextBox = New System.Windows.Forms.TextBox
        Me.totalWithdrawalTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.totalOverdraftsTextBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.okButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total Number of Deposits"
        '
        'totalDepositTextBox
        '
        Me.totalDepositTextBox.Location = New System.Drawing.Point(194, 62)
        Me.totalDepositTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.totalDepositTextBox.Name = "totalDepositTextBox"
        Me.totalDepositTextBox.ReadOnly = True
        Me.totalDepositTextBox.Size = New System.Drawing.Size(93, 20)
        Me.totalDepositTextBox.TabIndex = 1
        '
        'totalWithdrawalTextBox
        '
        Me.totalWithdrawalTextBox.Location = New System.Drawing.Point(194, 98)
        Me.totalWithdrawalTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.totalWithdrawalTextBox.Name = "totalWithdrawalTextBox"
        Me.totalWithdrawalTextBox.ReadOnly = True
        Me.totalWithdrawalTextBox.Size = New System.Drawing.Size(93, 20)
        Me.totalWithdrawalTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Number of Withdrawals"
        '
        'totalOverdraftsTextBox
        '
        Me.totalOverdraftsTextBox.Location = New System.Drawing.Point(194, 133)
        Me.totalOverdraftsTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.totalOverdraftsTextBox.Name = "totalOverdraftsTextBox"
        Me.totalOverdraftsTextBox.ReadOnly = True
        Me.totalOverdraftsTextBox.Size = New System.Drawing.Size(93, 20)
        Me.totalOverdraftsTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Number of Overdrafts"
        '
        'okButton
        '
        Me.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.okButton.Location = New System.Drawing.Point(134, 178)
        Me.okButton.Margin = New System.Windows.Forms.Padding(2)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(58, 20)
        Me.okButton.TabIndex = 6
        Me.okButton.Text = "&Ok"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'summaryForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.okButton
        Me.ClientSize = New System.Drawing.Size(320, 219)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.totalOverdraftsTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.totalWithdrawalTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totalDepositTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "summaryForm"
        Me.Text = "summaryForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalDepositTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalWithdrawalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents totalOverdraftsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents okButton As System.Windows.Forms.Button
End Class
