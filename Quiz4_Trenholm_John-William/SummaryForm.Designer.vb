Partial Public Class SummaryForm
    Inherits EX12Boards.BaseForm

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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TotalTextBox = New System.Windows.Forms.TextBox
        Me.ShirtsTextBox = New System.Windows.Forms.TextBox
        Me.OrdersTextBox = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(80, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total Shirts Ordered:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(80, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of Orders:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(80, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Order Amount:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(193, 187)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.ReadOnly = True
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 7
        Me.TotalTextBox.TabStop = False
        Me.TotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ShirtsTextBox
        '
        Me.ShirtsTextBox.Location = New System.Drawing.Point(193, 106)
        Me.ShirtsTextBox.Name = "ShirtsTextBox"
        Me.ShirtsTextBox.ReadOnly = True
        Me.ShirtsTextBox.Size = New System.Drawing.Size(72, 20)
        Me.ShirtsTextBox.TabIndex = 3
        Me.ShirtsTextBox.TabStop = False
        Me.ShirtsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OrdersTextBox
        '
        Me.OrdersTextBox.Location = New System.Drawing.Point(193, 146)
        Me.OrdersTextBox.Name = "OrdersTextBox"
        Me.OrdersTextBox.ReadOnly = True
        Me.OrdersTextBox.Size = New System.Drawing.Size(72, 20)
        Me.OrdersTextBox.TabIndex = 5
        Me.OrdersTextBox.TabStop = False
        Me.OrdersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SummaryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 293)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ShirtsTextBox)
        Me.Controls.Add(Me.OrdersTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "SummaryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Summary"
        Me.Controls.SetChildIndex(Me.OrdersTextBox, 0)
        Me.Controls.SetChildIndex(Me.ShirtsTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TotalTextBox, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ShirtsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OrdersTextBox As System.Windows.Forms.TextBox
End Class
