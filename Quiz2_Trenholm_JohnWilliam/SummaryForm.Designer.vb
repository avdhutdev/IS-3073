Partial Public Class SummaryForm
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
        Me.WinnerTextBox = New System.Windows.Forms.TextBox
        Me.TotalTestersTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.AppleAvgTextBox = New System.Windows.Forms.TextBox
        Me.PruneAvgTextBox = New System.Windows.Forms.TextBox
        Me.OkButton = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'WinnerTextBox
        '
        Me.WinnerTextBox.Location = New System.Drawing.Point(7, 19)
        Me.WinnerTextBox.Name = "WinnerTextBox"
        Me.WinnerTextBox.ReadOnly = True
        Me.WinnerTextBox.Size = New System.Drawing.Size(205, 20)
        Me.WinnerTextBox.TabIndex = 0
        Me.WinnerTextBox.TabStop = False
        Me.WinnerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalTestersTextBox
        '
        Me.TotalTestersTextBox.Location = New System.Drawing.Point(7, 50)
        Me.TotalTestersTextBox.Name = "TotalTestersTextBox"
        Me.TotalTestersTextBox.ReadOnly = True
        Me.TotalTestersTextBox.Size = New System.Drawing.Size(205, 20)
        Me.TotalTestersTextBox.TabIndex = 1
        Me.TotalTestersTextBox.TabStop = False
        Me.TotalTestersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apple Ade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Prune Punch"
        '
        'AppleAvgTextBox
        '
        Me.AppleAvgTextBox.Location = New System.Drawing.Point(92, 24)
        Me.AppleAvgTextBox.Name = "AppleAvgTextBox"
        Me.AppleAvgTextBox.ReadOnly = True
        Me.AppleAvgTextBox.Size = New System.Drawing.Size(55, 20)
        Me.AppleAvgTextBox.TabIndex = 1
        Me.AppleAvgTextBox.TabStop = False
        Me.AppleAvgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PruneAvgTextBox
        '
        Me.PruneAvgTextBox.Location = New System.Drawing.Point(92, 63)
        Me.PruneAvgTextBox.Name = "PruneAvgTextBox"
        Me.PruneAvgTextBox.ReadOnly = True
        Me.PruneAvgTextBox.Size = New System.Drawing.Size(55, 20)
        Me.PruneAvgTextBox.TabIndex = 3
        Me.PruneAvgTextBox.TabStop = False
        Me.PruneAvgTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(100, 232)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 2
        Me.OkButton.Text = "&Ok"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PruneAvgTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.AppleAvgTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(179, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Average Rating For Each Drink"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TotalTestersTextBox)
        Me.GroupBox2.Controls.Add(Me.WinnerTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 85)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Winner's Circle"
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 280)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.OkButton)
        Me.Name = "SummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Results Are In!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WinnerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TotalTestersTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AppleAvgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PruneAvgTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
