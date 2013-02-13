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
        Me.Label1 = New System.Windows.Forms.Label
        Me.nameBox = New System.Windows.Forms.TextBox
        Me.zipCodeBox = New System.Windows.Forms.TextBox
        Me.zipCode = New System.Windows.Forms.Label
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cityBox = New System.Windows.Forms.TextBox
        Me.City = New System.Windows.Forms.Label
        Me.addressBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(313, 46)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 22)
        Me.nameBox.TabIndex = 1
        '
        'zipCodeBox
        '
        Me.zipCodeBox.Location = New System.Drawing.Point(313, 197)
        Me.zipCodeBox.Name = "zipCodeBox"
        Me.zipCodeBox.Size = New System.Drawing.Size(100, 22)
        Me.zipCodeBox.TabIndex = 5
        '
        'zipCode
        '
        Me.zipCode.AutoSize = True
        Me.zipCode.Location = New System.Drawing.Point(61, 197)
        Me.zipCode.Name = "zipCode"
        Me.zipCode.Size = New System.Drawing.Size(61, 17)
        Me.zipCode.TabIndex = 4
        Me.zipCode.Text = "ZipCode"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(313, 162)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "State"
        '
        'cityBox
        '
        Me.cityBox.Location = New System.Drawing.Point(313, 126)
        Me.cityBox.Name = "cityBox"
        Me.cityBox.Size = New System.Drawing.Size(100, 22)
        Me.cityBox.TabIndex = 9
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Location = New System.Drawing.Point(61, 126)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(31, 17)
        Me.City.TabIndex = 8
        Me.City.Text = "City"
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(313, 88)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(100, 22)
        Me.addressBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 335)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(439, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(551, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(669, 589)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.addressBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cityBox)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.zipCodeBox)
        Me.Controls.Add(Me.zipCode)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nameBox As System.Windows.Forms.TextBox
    Friend WithEvents zipCodeBox As System.Windows.Forms.TextBox
    Friend WithEvents zipCode As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cityBox As System.Windows.Forms.TextBox
    Friend WithEvents City As System.Windows.Forms.Label
    Friend WithEvents addressBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
