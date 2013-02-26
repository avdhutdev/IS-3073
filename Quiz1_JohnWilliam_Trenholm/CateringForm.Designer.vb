Partial Public Class CateringForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CateringForm))
        Me.GuestTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PrimeRibRadioButton = New System.Windows.Forms.RadioButton
        Me.ChickenRadioButton = New System.Windows.Forms.RadioButton
        Me.PastaRadioButton = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.OpenBarCheckBox = New System.Windows.Forms.CheckBox
        Me.WineCheckBox = New System.Windows.Forms.CheckBox
        Me.CalculateButton = New System.Windows.Forms.Button
        Me.ClearButton = New System.Windows.Forms.Button
        Me.SummaryButton = New System.Windows.Forms.Button
        Me.ExitButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.AmountDueTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.PrintButton = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GuestTextBox
        '
        Me.GuestTextBox.Location = New System.Drawing.Point(8, 25)
        Me.GuestTextBox.Name = "GuestTextBox"
        Me.GuestTextBox.Size = New System.Drawing.Size(87, 20)
        Me.GuestTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of &Guests"
        '
        'PrimeRibRadioButton
        '
        Me.PrimeRibRadioButton.AutoSize = True
        Me.PrimeRibRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.PrimeRibRadioButton.Name = "PrimeRibRadioButton"
        Me.PrimeRibRadioButton.Size = New System.Drawing.Size(106, 17)
        Me.PrimeRibRadioButton.TabIndex = 0
        Me.PrimeRibRadioButton.Text = "Prime Rib $25.95"
        '
        'ChickenRadioButton
        '
        Me.ChickenRadioButton.AutoSize = True
        Me.ChickenRadioButton.Location = New System.Drawing.Point(6, 48)
        Me.ChickenRadioButton.Name = "ChickenRadioButton"
        Me.ChickenRadioButton.Size = New System.Drawing.Size(100, 17)
        Me.ChickenRadioButton.TabIndex = 1
        Me.ChickenRadioButton.Text = "Chicken $18.95"
        '
        'PastaRadioButton
        '
        Me.PastaRadioButton.AutoSize = True
        Me.PastaRadioButton.Location = New System.Drawing.Point(6, 77)
        Me.PastaRadioButton.Name = "PastaRadioButton"
        Me.PastaRadioButton.Size = New System.Drawing.Size(88, 17)
        Me.PastaRadioButton.TabIndex = 2
        Me.PastaRadioButton.Tag = ""
        Me.PastaRadioButton.Text = "Pasta $12.95"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PastaRadioButton)
        Me.GroupBox1.Controls.Add(Me.PrimeRibRadioButton)
        Me.GroupBox1.Controls.Add(Me.ChickenRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menu Choices"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OpenBarCheckBox)
        Me.GroupBox2.Controls.Add(Me.WineCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(144, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 80)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bar Selection"
        '
        'OpenBarCheckBox
        '
        Me.OpenBarCheckBox.AutoSize = True
        Me.OpenBarCheckBox.Location = New System.Drawing.Point(6, 19)
        Me.OpenBarCheckBox.Name = "OpenBarCheckBox"
        Me.OpenBarCheckBox.Size = New System.Drawing.Size(129, 17)
        Me.OpenBarCheckBox.TabIndex = 0
        Me.OpenBarCheckBox.Text = "Open Bar $25/person"
        '
        'WineCheckBox
        '
        Me.WineCheckBox.AutoSize = True
        Me.WineCheckBox.Location = New System.Drawing.Point(6, 48)
        Me.WineCheckBox.Name = "WineCheckBox"
        Me.WineCheckBox.Size = New System.Drawing.Size(159, 17)
        Me.WineCheckBox.TabIndex = 1
        Me.WineCheckBox.Text = "Wine with Dinner $8/person"
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(20, 235)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 2
        Me.CalculateButton.Text = "Calculate"
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(106, 235)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        '
        'SummaryButton
        '
        Me.SummaryButton.Location = New System.Drawing.Point(193, 235)
        Me.SummaryButton.Name = "SummaryButton"
        Me.SummaryButton.Size = New System.Drawing.Size(75, 23)
        Me.SummaryButton.TabIndex = 5
        Me.SummaryButton.Text = "Summary"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(193, 264)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "Exit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Amount Due"
        '
        'AmountDueTextBox
        '
        Me.AmountDueTextBox.Location = New System.Drawing.Point(85, 13)
        Me.AmountDueTextBox.Name = "AmountDueTextBox"
        Me.AmountDueTextBox.ReadOnly = True
        Me.AmountDueTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AmountDueTextBox.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.AmountDueTextBox)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(83, 168)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(209, 40)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(106, 264)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 0
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(139, 25)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1, 140)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'CateringForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 312)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GuestTextBox)
        Me.Controls.Add(Me.SummaryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CateringForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GuestTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrimeRibRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ChickenRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PastaRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents OpenBarCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents WineCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents SummaryButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AmountDueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PrintButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox

End Class
