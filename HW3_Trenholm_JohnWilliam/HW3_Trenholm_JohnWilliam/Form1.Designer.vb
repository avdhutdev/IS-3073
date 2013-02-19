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
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox
        Me.stateTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox6 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox7 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox8 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox9 = New System.Windows.Forms.MaskedTextBox
        Me.dollarOutput = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.salesTaxBox = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.shippingHandlingOutputBox = New System.Windows.Forms.Label
        Me.salesTaxOutputBox = New System.Windows.Forms.Label
        Me.superTotalOutputBox = New System.Windows.Forms.Label
        Me.totalOutputAmount = New System.Windows.Forms.Label
        Me.MaskedTextBox10 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox11 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox12 = New System.Windows.Forms.MaskedTextBox
        Me.MaskedTextBox13 = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(258, 26)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 22)
        Me.nameBox.TabIndex = 1
        '
        'zipCode
        '
        Me.zipCode.AutoSize = True
        Me.zipCode.Location = New System.Drawing.Point(6, 177)
        Me.zipCode.Name = "zipCode"
        Me.zipCode.Size = New System.Drawing.Size(61, 17)
        Me.zipCode.TabIndex = 8
        Me.zipCode.Text = "ZipCode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "State"
        '
        'cityBox
        '
        Me.cityBox.Location = New System.Drawing.Point(258, 106)
        Me.cityBox.Name = "cityBox"
        Me.cityBox.Size = New System.Drawing.Size(100, 22)
        Me.cityBox.TabIndex = 5
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Location = New System.Drawing.Point(6, 106)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(31, 17)
        Me.City.TabIndex = 4
        Me.City.Text = "City"
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(258, 68)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(100, 22)
        Me.addressBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Address"
        '
        'summaryButton
        '
        Me.summaryButton.Location = New System.Drawing.Point(200, 454)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(313, 43)
        Me.summaryButton.TabIndex = 3
        Me.summaryButton.Text = "Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(200, 528)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'printPreviewButton
        '
        Me.printPreviewButton.Location = New System.Drawing.Point(310, 528)
        Me.printPreviewButton.Name = "printPreviewButton"
        Me.printPreviewButton.Size = New System.Drawing.Size(103, 23)
        Me.printPreviewButton.TabIndex = 5
        Me.printPreviewButton.Text = "&Print Preview"
        Me.printPreviewButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(438, 528)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
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
        Me.GroupBox2.Controls.Add(Me.shippingHandlingOutputBox)
        Me.GroupBox2.Controls.Add(Me.salesTaxOutputBox)
        Me.GroupBox2.Controls.Add(Me.superTotalOutputBox)
        Me.GroupBox2.Controls.Add(Me.totalOutputAmount)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.salesTaxBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dollarOutput)
        Me.GroupBox2.Location = New System.Drawing.Point(71, 248)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(593, 181)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Summary"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(258, 177)
        Me.MaskedTextBox1.Mask = "00000-9999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox1.TabIndex = 9
        '
        'stateTextBox
        '
        Me.stateTextBox.Location = New System.Drawing.Point(258, 142)
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(100, 22)
        Me.stateTextBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox13)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox12)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox11)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox10)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox8)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox9)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox6)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox7)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox5)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox4)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox3)
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(487, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 209)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items"
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
        Me.GroupBox3.Location = New System.Drawing.Point(64, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(397, 209)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Info"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(5, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(252, 22)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(449, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(364, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Weight"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Quantity"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(252, 22)
        Me.TextBox2.TabIndex = 8
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(5, 137)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(252, 22)
        Me.TextBox3.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(6, 172)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(252, 22)
        Me.TextBox4.TabIndex = 16
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(282, 68)
        Me.MaskedTextBox2.Mask = "00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(58, 22)
        Me.MaskedTextBox2.TabIndex = 5
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.Location = New System.Drawing.Point(367, 68)
        Me.MaskedTextBox3.Mask = "00.0"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(68, 22)
        Me.MaskedTextBox3.TabIndex = 6
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.Location = New System.Drawing.Point(367, 103)
        Me.MaskedTextBox4.Mask = "00.0"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(68, 22)
        Me.MaskedTextBox4.TabIndex = 10
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.Location = New System.Drawing.Point(282, 101)
        Me.MaskedTextBox5.Mask = "00"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(58, 22)
        Me.MaskedTextBox5.TabIndex = 9
        '
        'MaskedTextBox6
        '
        Me.MaskedTextBox6.Location = New System.Drawing.Point(367, 137)
        Me.MaskedTextBox6.Mask = "00.0"
        Me.MaskedTextBox6.Name = "MaskedTextBox6"
        Me.MaskedTextBox6.Size = New System.Drawing.Size(68, 22)
        Me.MaskedTextBox6.TabIndex = 14
        '
        'MaskedTextBox7
        '
        Me.MaskedTextBox7.Location = New System.Drawing.Point(282, 139)
        Me.MaskedTextBox7.Mask = "00"
        Me.MaskedTextBox7.Name = "MaskedTextBox7"
        Me.MaskedTextBox7.Size = New System.Drawing.Size(58, 22)
        Me.MaskedTextBox7.TabIndex = 13
        '
        'MaskedTextBox8
        '
        Me.MaskedTextBox8.Location = New System.Drawing.Point(367, 172)
        Me.MaskedTextBox8.Mask = "00.0"
        Me.MaskedTextBox8.Name = "MaskedTextBox8"
        Me.MaskedTextBox8.Size = New System.Drawing.Size(68, 22)
        Me.MaskedTextBox8.TabIndex = 18
        '
        'MaskedTextBox9
        '
        Me.MaskedTextBox9.Location = New System.Drawing.Point(282, 172)
        Me.MaskedTextBox9.Mask = "00"
        Me.MaskedTextBox9.Name = "MaskedTextBox9"
        Me.MaskedTextBox9.Size = New System.Drawing.Size(58, 22)
        Me.MaskedTextBox9.TabIndex = 17
        '
        'dollarOutput
        '
        Me.dollarOutput.AutoSize = True
        Me.dollarOutput.Location = New System.Drawing.Point(8, 34)
        Me.dollarOutput.Name = "dollarOutput"
        Me.dollarOutput.Size = New System.Drawing.Size(138, 17)
        Me.dollarOutput.TabIndex = 0
        Me.dollarOutput.Text = "Dollar Ammount Due"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Amount Due"
        '
        'salesTaxBox
        '
        Me.salesTaxBox.AutoSize = True
        Me.salesTaxBox.Location = New System.Drawing.Point(8, 65)
        Me.salesTaxBox.Name = "salesTaxBox"
        Me.salesTaxBox.Size = New System.Drawing.Size(66, 17)
        Me.salesTaxBox.TabIndex = 2
        Me.salesTaxBox.Text = "SalesTax"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Shipping and Handling"
        '
        'shippingHandlingOutputBox
        '
        Me.shippingHandlingOutputBox.AutoSize = True
        Me.shippingHandlingOutputBox.Location = New System.Drawing.Point(246, 100)
        Me.shippingHandlingOutputBox.Name = "shippingHandlingOutputBox"
        Me.shippingHandlingOutputBox.Size = New System.Drawing.Size(0, 17)
        Me.shippingHandlingOutputBox.TabIndex = 5
        '
        'salesTaxOutputBox
        '
        Me.salesTaxOutputBox.AutoSize = True
        Me.salesTaxOutputBox.Location = New System.Drawing.Point(248, 65)
        Me.salesTaxOutputBox.Name = "salesTaxOutputBox"
        Me.salesTaxOutputBox.Size = New System.Drawing.Size(0, 17)
        Me.salesTaxOutputBox.TabIndex = 3
        '
        'superTotalOutputBox
        '
        Me.superTotalOutputBox.AutoSize = True
        Me.superTotalOutputBox.Location = New System.Drawing.Point(248, 134)
        Me.superTotalOutputBox.Name = "superTotalOutputBox"
        Me.superTotalOutputBox.Size = New System.Drawing.Size(0, 17)
        Me.superTotalOutputBox.TabIndex = 7
        '
        'totalOutputAmount
        '
        Me.totalOutputAmount.AutoSize = True
        Me.totalOutputAmount.Location = New System.Drawing.Point(248, 34)
        Me.totalOutputAmount.Name = "totalOutputAmount"
        Me.totalOutputAmount.Size = New System.Drawing.Size(0, 17)
        Me.totalOutputAmount.TabIndex = 1
        '
        'MaskedTextBox10
        '
        Me.MaskedTextBox10.Location = New System.Drawing.Point(452, 65)
        Me.MaskedTextBox10.Mask = "$999,999.00"
        Me.MaskedTextBox10.Name = "MaskedTextBox10"
        Me.MaskedTextBox10.Size = New System.Drawing.Size(68, 22)
        Me.MaskedTextBox10.TabIndex = 7
        '
        'MaskedTextBox11
        '
        Me.MaskedTextBox11.Location = New System.Drawing.Point(452, 106)
        Me.MaskedTextBox11.Mask = "$999,999.00"
        Me.MaskedTextBox11.Name = "MaskedTextBox11"
        Me.MaskedTextBox11.Size = New System.Drawing.Size(68, 22)
        Me.MaskedTextBox11.TabIndex = 11
        '
        'MaskedTextBox12
        '
        Me.MaskedTextBox12.Location = New System.Drawing.Point(452, 137)
        Me.MaskedTextBox12.Mask = "$999,999.00"
        Me.MaskedTextBox12.Name = "MaskedTextBox12"
        Me.MaskedTextBox12.Size = New System.Drawing.Size(68, 22)
        Me.MaskedTextBox12.TabIndex = 15
        '
        'MaskedTextBox13
        '
        Me.MaskedTextBox13.Location = New System.Drawing.Point(452, 172)
        Me.MaskedTextBox13.Mask = "$999,999.00"
        Me.MaskedTextBox13.Name = "MaskedTextBox13"
        Me.MaskedTextBox13.Size = New System.Drawing.Size(68, 22)
        Me.MaskedTextBox13.TabIndex = 19
        '
        'vbMailOrder
        '
        Me.AcceptButton = Me.summaryButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(1075, 589)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printPreviewButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.summaryButton)
        Me.Name = "vbMailOrder"
        Me.Text = "vbMailOrder"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents MaskedTextBox8 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox9 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox6 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox7 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox5 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox4 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox3 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dollarOutput As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents salesTaxBox As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents shippingHandlingOutputBox As System.Windows.Forms.Label
    Friend WithEvents salesTaxOutputBox As System.Windows.Forms.Label
    Friend WithEvents superTotalOutputBox As System.Windows.Forms.Label
    Friend WithEvents totalOutputAmount As System.Windows.Forms.Label
    Friend WithEvents MaskedTextBox13 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox12 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox11 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox10 As System.Windows.Forms.MaskedTextBox

End Class
