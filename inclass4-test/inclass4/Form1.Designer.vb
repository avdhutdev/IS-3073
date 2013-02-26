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
        Me.Button2 = New System.Windows.Forms.Button
        Me.maleradio = New System.Windows.Forms.RadioButton
        Me.ageBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.goButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.maleBox = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.maleMinor = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.femaleBox = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.femaleMinor = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(29, 427)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'maleradio
        '
        Me.maleradio.AutoSize = True
        Me.maleradio.Location = New System.Drawing.Point(51, 45)
        Me.maleradio.Name = "maleradio"
        Me.maleradio.Size = New System.Drawing.Size(64, 17)
        Me.maleradio.TabIndex = 6
        Me.maleradio.TabStop = True
        Me.maleradio.Text = "Is male?"
        Me.maleradio.UseVisualStyleBackColor = True
        '
        'ageBox
        '
        Me.ageBox.Location = New System.Drawing.Point(95, 94)
        Me.ageBox.Name = "ageBox"
        Me.ageBox.Size = New System.Drawing.Size(100, 20)
        Me.ageBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Age?"
        '
        'goButton
        '
        Me.goButton.Location = New System.Drawing.Point(29, 135)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(75, 23)
        Me.goButton.TabIndex = 9
        Me.goButton.Text = "Go!"
        Me.goButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Male"
        '
        'maleBox
        '
        Me.maleBox.AutoSize = True
        Me.maleBox.Location = New System.Drawing.Point(142, 245)
        Me.maleBox.Name = "maleBox"
        Me.maleBox.Size = New System.Drawing.Size(0, 13)
        Me.maleBox.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 278)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Male Minor"
        '
        'maleMinor
        '
        Me.maleMinor.AutoSize = True
        Me.maleMinor.Location = New System.Drawing.Point(142, 278)
        Me.maleMinor.Name = "maleMinor"
        Me.maleMinor.Size = New System.Drawing.Size(0, 13)
        Me.maleMinor.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Female"
        '
        'femaleBox
        '
        Me.femaleBox.AutoSize = True
        Me.femaleBox.Location = New System.Drawing.Point(142, 332)
        Me.femaleBox.Name = "femaleBox"
        Me.femaleBox.Size = New System.Drawing.Size(0, 13)
        Me.femaleBox.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(60, 381)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Female Minor"
        '
        'femaleMinor
        '
        Me.femaleMinor.AutoSize = True
        Me.femaleMinor.Location = New System.Drawing.Point(142, 381)
        Me.femaleMinor.Name = "femaleMinor"
        Me.femaleMinor.Size = New System.Drawing.Size(0, 13)
        Me.femaleMinor.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 505)
        Me.Controls.Add(Me.femaleMinor)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.femaleBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.maleMinor)
        Me.Controls.Add(Me.maleBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.goButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ageBox)
        Me.Controls.Add(Me.maleradio)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents maleradio As System.Windows.Forms.RadioButton
    Friend WithEvents ageBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents goButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents maleBox As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents maleMinor As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents femaleBox As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents femaleMinor As System.Windows.Forms.Label

End Class
