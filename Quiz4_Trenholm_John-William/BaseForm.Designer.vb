Partial Public Class BaseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseForm))
        Me.BestboardsLabel = New System.Windows.Forms.Label
        Me.SkatePictureBox = New System.Windows.Forms.PictureBox
        Me.VeryVeryBoardsLabel = New System.Windows.Forms.Label
        Me.OkButton = New System.Windows.Forms.Button
        CType(Me.SkatePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BestboardsLabel
        '
        Me.BestboardsLabel.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BestboardsLabel.ForeColor = System.Drawing.Color.Blue
        Me.BestboardsLabel.Location = New System.Drawing.Point(79, 29)
        Me.BestboardsLabel.Name = "BestboardsLabel"
        Me.BestboardsLabel.Size = New System.Drawing.Size(248, 24)
        Me.BestboardsLabel.TabIndex = 42
        Me.BestboardsLabel.Text = "The Best in Boards"
        '
        'SkatePictureBox
        '
        Me.SkatePictureBox.Image = CType(resources.GetObject("SkatePictureBox.Image"), System.Drawing.Image)
        Me.SkatePictureBox.Location = New System.Drawing.Point(367, 109)
        Me.SkatePictureBox.Name = "SkatePictureBox"
        Me.SkatePictureBox.Size = New System.Drawing.Size(144, 104)
        Me.SkatePictureBox.TabIndex = 51
        Me.SkatePictureBox.TabStop = False
        '
        'VeryVeryBoardsLabel
        '
        Me.VeryVeryBoardsLabel.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VeryVeryBoardsLabel.ForeColor = System.Drawing.Color.Black
        Me.VeryVeryBoardsLabel.Location = New System.Drawing.Point(87, 61)
        Me.VeryVeryBoardsLabel.Name = "VeryVeryBoardsLabel"
        Me.VeryVeryBoardsLabel.Size = New System.Drawing.Size(224, 24)
        Me.VeryVeryBoardsLabel.TabIndex = 43
        Me.VeryVeryBoardsLabel.Text = "Very Very Boards"
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(394, 235)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 50
        Me.OkButton.Text = "&Ok"
        '
        'BaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 334)
        Me.Controls.Add(Me.BestboardsLabel)
        Me.Controls.Add(Me.SkatePictureBox)
        Me.Controls.Add(Me.VeryVeryBoardsLabel)
        Me.Controls.Add(Me.OkButton)
        Me.Name = "BaseForm"
        Me.Text = "BaseForm"
        CType(Me.SkatePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BestboardsLabel As System.Windows.Forms.Label
    Friend WithEvents SkatePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents VeryVeryBoardsLabel As System.Windows.Forms.Label
    Friend WithEvents OkButton As System.Windows.Forms.Button
End Class
