<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RichTextBoxForm
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
        Me.SampleRichTextBox = New System.Windows.Forms.RichTextBox
        Me.TitleRichTextBox = New System.Windows.Forms.RichTextBox
        Me.UrlRichTextBox = New System.Windows.Forms.RichTextBox
        Me.UrlTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'SampleRichTextBox
        '
        Me.SampleRichTextBox.Location = New System.Drawing.Point(14, 78)
        Me.SampleRichTextBox.Name = "SampleRichTextBox"
        Me.SampleRichTextBox.Size = New System.Drawing.Size(298, 135)
        Me.SampleRichTextBox.TabIndex = 0
        Me.SampleRichTextBox.Text = ""
        '
        'TitleRichTextBox
        '
        Me.TitleRichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleRichTextBox.ForeColor = System.Drawing.Color.Maroon
        Me.TitleRichTextBox.Location = New System.Drawing.Point(14, 9)
        Me.TitleRichTextBox.Margin = New System.Windows.Forms.Padding(10, 3, 3, 3)
        Me.TitleRichTextBox.Name = "TitleRichTextBox"
        Me.TitleRichTextBox.Size = New System.Drawing.Size(298, 63)
        Me.TitleRichTextBox.TabIndex = 1
        Me.TitleRichTextBox.Text = ""
        '
        'UrlRichTextBox
        '
        Me.UrlRichTextBox.Location = New System.Drawing.Point(14, 222)
        Me.UrlRichTextBox.Name = "UrlRichTextBox"
        Me.UrlRichTextBox.Size = New System.Drawing.Size(298, 28)
        Me.UrlRichTextBox.TabIndex = 2
        Me.UrlRichTextBox.Text = "http://msdn.microsoft.com"
        '
        'UrlTextBox
        '
        Me.UrlTextBox.Location = New System.Drawing.Point(14, 264)
        Me.UrlTextBox.Name = "UrlTextBox"
        Me.UrlTextBox.Size = New System.Drawing.Size(298, 20)
        Me.UrlTextBox.TabIndex = 3
        Me.UrlTextBox.Text = "http://msdn.microsoft.com"
        '
        'RichTextBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 301)
        Me.Controls.Add(Me.UrlTextBox)
        Me.Controls.Add(Me.UrlRichTextBox)
        Me.Controls.Add(Me.TitleRichTextBox)
        Me.Controls.Add(Me.SampleRichTextBox)
        Me.Name = "RichTextBoxForm"
        Me.Text = "Rich Text Boxes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SampleRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TitleRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents UrlRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents UrlTextBox As System.Windows.Forms.TextBox

End Class
