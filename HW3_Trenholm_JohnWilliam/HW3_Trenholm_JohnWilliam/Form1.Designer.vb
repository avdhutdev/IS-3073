<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vbMailOrder
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vbMailOrder))
        Me.Label1 = New System.Windows.Forms.Label
        Me.nameBox = New System.Windows.Forms.TextBox
        Me.zipCode = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cityBox = New System.Windows.Forms.TextBox
        Me.City = New System.Windows.Forms.Label
        Me.addressBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.summaryButton = New System.Windows.Forms.Button
        Me.clearButton = New System.Windows.Forms.Button
        Me.printPreviewButton = New System.Windows.Forms.Button
        Me.exitButton = New System.Windows.Forms.Button
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.salesTaxBox = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dollarOutput = New System.Windows.Forms.Label
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.stateTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(207, 25)
        Me.nameBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(76, 20)
        Me.nameBox.TabIndex = 1
        '
        'zipCode
        '
        Me.zipCode.AutoSize = True
        Me.zipCode.Location = New System.Drawing.Point(36, 151)
        Me.zipCode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.zipCode.Name = "zipCode"
        Me.zipCode.Size = New System.Drawing.Size(47, 13)
        Me.zipCode.TabIndex = 8
        Me.zipCode.Text = "ZipCode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 122)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "State"
        '
        'cityBox
        '
        Me.cityBox.Location = New System.Drawing.Point(207, 90)
        Me.cityBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cityBox.Name = "cityBox"
        Me.cityBox.Size = New System.Drawing.Size(76, 20)
        Me.cityBox.TabIndex = 5
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Location = New System.Drawing.Point(36, 93)
        Me.City.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(24, 13)
        Me.City.TabIndex = 4
        Me.City.Text = "City"
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(207, 59)
        Me.addressBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(76, 20)
        Me.addressBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Address"
        '
        'summaryButton
        '
        Me.summaryButton.Location = New System.Drawing.Point(59, 415)
        Me.summaryButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(235, 35)
        Me.summaryButton.TabIndex = 3
        Me.summaryButton.Text = "&Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(419, 415)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(73, 35)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'printPreviewButton
        '
        Me.printPreviewButton.Location = New System.Drawing.Point(509, 415)
        Me.printPreviewButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.printPreviewButton.Name = "printPreviewButton"
        Me.printPreviewButton.Size = New System.Drawing.Size(87, 35)
        Me.printPreviewButton.TabIndex = 5
        Me.printPreviewButton.Text = "&Print Preview"
        Me.printPreviewButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(609, 415)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(71, 35)
        Me.exitButton.TabIndex = 6
        Me.exitButton.Text = "&Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox20)
        Me.GroupBox2.Controls.Add(Me.TextBox19)
        Me.GroupBox2.Controls.Add(Me.TextBox18)
        Me.GroupBox2.Controls.Add(Me.TextBox17)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.salesTaxBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dollarOutput)
        Me.GroupBox2.Location = New System.Drawing.Point(374, 11)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(327, 180)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Summary"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 95)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Shipping and Handling"
        '
        'salesTaxBox
        '
        Me.salesTaxBox.AutoSize = True
        Me.salesTaxBox.Location = New System.Drawing.Point(26, 64)
        Me.salesTaxBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.salesTaxBox.Name = "salesTaxBox"
        Me.salesTaxBox.Size = New System.Drawing.Size(51, 13)
        Me.salesTaxBox.TabIndex = 2
        Me.salesTaxBox.Text = "SalesTax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 131)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Amount Due"
        '
        'dollarOutput
        '
        Me.dollarOutput.AutoSize = True
        Me.dollarOutput.Location = New System.Drawing.Point(26, 34)
        Me.dollarOutput.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dollarOutput.Name = "dollarOutput"
        Me.dollarOutput.Size = New System.Drawing.Size(104, 13)
        Me.dollarOutput.TabIndex = 0
        Me.dollarOutput.Text = "Dollar Ammount Due"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(207, 148)
        Me.MaskedTextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaskedTextBox1.Mask = "00000-9999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(76, 20)
        Me.MaskedTextBox1.TabIndex = 9
        '
        'stateTextBox
        '
        Me.stateTextBox.Location = New System.Drawing.Point(207, 119)
        Me.stateTextBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(39, 20)
        Me.stateTextBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.TextBox14)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.TextBox12)
        Me.GroupBox1.Controls.Add(Me.TextBox15)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox16)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(55, 195)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(646, 186)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(75, 148)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(190, 20)
        Me.TextBox4.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(75, 121)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(190, 20)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(75, 92)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(190, 20)
        Me.TextBox2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 53)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(190, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 31)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(316, 31)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Weight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 31)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Quantity"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox3.Controls.Add(Me.nameBox)
        Me.GroupBox3.Controls.Add(Me.zipCode)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.stateTextBox)
        Me.GroupBox3.Controls.Add(Me.City)
        Me.GroupBox3.Controls.Add(Me.cityBox)
        Me.GroupBox3.Controls.Add(Me.addressBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(48, 10)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(298, 181)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Info"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(479, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Add this Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(479, 115)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Remove"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(479, 86)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(479, 146)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Remove"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(305, 142)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(52, 20)
        Me.TextBox5.TabIndex = 27
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(305, 115)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(52, 20)
        Me.TextBox6.TabIndex = 26
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(305, 86)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(52, 20)
        Me.TextBox7.TabIndex = 25
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(305, 53)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(52, 20)
        Me.TextBox8.TabIndex = 24
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(7, 148)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(43, 20)
        Me.TextBox9.TabIndex = 31
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(7, 119)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(43, 20)
        Me.TextBox10.TabIndex = 30
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(7, 90)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(43, 20)
        Me.TextBox11.TabIndex = 29
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(7, 53)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(43, 20)
        Me.TextBox12.TabIndex = 28
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(388, 143)
        Me.TextBox13.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(49, 20)
        Me.TextBox13.TabIndex = 35
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(388, 116)
        Me.TextBox14.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(49, 20)
        Me.TextBox14.TabIndex = 34
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(388, 87)
        Me.TextBox15.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(49, 20)
        Me.TextBox15.TabIndex = 33
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(388, 53)
        Me.TextBox16.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(49, 20)
        Me.TextBox16.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(546, 457)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Programmed by: John-William Trenholm"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(160, 27)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ReadOnly = True
        Me.TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.TextBox17.TabIndex = 7
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(160, 61)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.ReadOnly = True
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 8
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(160, 95)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.ReadOnly = True
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 9
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(160, 131)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.ReadOnly = True
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 10
        '
        'vbMailOrder
        '
        Me.AcceptButton = Me.summaryButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(750, 479)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printPreviewButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.summaryButton)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "vbMailOrder"
        Me.Text = "vbMailOrder"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nameBox As System.Windows.Forms.TextBox
    Friend WithEvents zipCode As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cityBox As System.Windows.Forms.TextBox
    Friend WithEvents City As System.Windows.Forms.Label
    Friend WithEvents addressBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents summaryButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button
    Friend WithEvents printPreviewButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents dollarOutput As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents salesTaxBox As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox

End Class
