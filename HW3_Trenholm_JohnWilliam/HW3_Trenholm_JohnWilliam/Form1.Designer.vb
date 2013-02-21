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
        Me.totalAmountBox = New System.Windows.Forms.TextBox
        Me.shippingBox = New System.Windows.Forms.TextBox
        Me.taxBox = New System.Windows.Forms.TextBox
        Me.amountBox = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.salesTaxBox = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.dollarOutput = New System.Windows.Forms.Label
        Me.zipBox = New System.Windows.Forms.MaskedTextBox
        Me.stateTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.item4PriceBox = New System.Windows.Forms.TextBox
        Me.item4quantBox = New System.Windows.Forms.TextBox
        Me.item4WeightBox = New System.Windows.Forms.TextBox
        Me.removeItem4Button = New System.Windows.Forms.Button
        Me.item4TextBox = New System.Windows.Forms.TextBox
        Me.item3PriceBox = New System.Windows.Forms.TextBox
        Me.item3quantBox = New System.Windows.Forms.TextBox
        Me.item2quantBox = New System.Windows.Forms.TextBox
        Me.item2PriceBox = New System.Windows.Forms.TextBox
        Me.item1quantBox = New System.Windows.Forms.TextBox
        Me.itemquantBox = New System.Windows.Forms.TextBox
        Me.item1PriceBox = New System.Windows.Forms.TextBox
        Me.item3WeightBox = New System.Windows.Forms.TextBox
        Me.itemPriceBox = New System.Windows.Forms.TextBox
        Me.removeItem3Button = New System.Windows.Forms.Button
        Me.item2WeightBox = New System.Windows.Forms.TextBox
        Me.removeItem1Button = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.itemWeightBox = New System.Windows.Forms.TextBox
        Me.removeItem2Button = New System.Windows.Forms.Button
        Me.item1WeightBox = New System.Windows.Forms.TextBox
        Me.addItem1Button = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.item3TextBox = New System.Windows.Forms.TextBox
        Me.item2TextBox = New System.Windows.Forms.TextBox
        Me.item1TextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.itemTextBox = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name:"
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(276, 31)
        Me.nameBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 22)
        Me.nameBox.TabIndex = 1
        '
        'zipCode
        '
        Me.zipCode.AutoSize = True
        Me.zipCode.Location = New System.Drawing.Point(48, 186)
        Me.zipCode.Name = "zipCode"
        Me.zipCode.Size = New System.Drawing.Size(61, 17)
        Me.zipCode.TabIndex = 8
        Me.zipCode.Text = "ZipCode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "State"
        '
        'cityBox
        '
        Me.cityBox.Location = New System.Drawing.Point(276, 111)
        Me.cityBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cityBox.Name = "cityBox"
        Me.cityBox.Size = New System.Drawing.Size(100, 22)
        Me.cityBox.TabIndex = 5
        '
        'City
        '
        Me.City.AutoSize = True
        Me.City.Location = New System.Drawing.Point(48, 114)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(31, 17)
        Me.City.TabIndex = 4
        Me.City.Text = "City"
        '
        'addressBox
        '
        Me.addressBox.Location = New System.Drawing.Point(276, 73)
        Me.addressBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.addressBox.Name = "addressBox"
        Me.addressBox.Size = New System.Drawing.Size(100, 22)
        Me.addressBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Address"
        '
        'summaryButton
        '
        Me.summaryButton.Location = New System.Drawing.Point(64, 583)
        Me.summaryButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.summaryButton.Name = "summaryButton"
        Me.summaryButton.Size = New System.Drawing.Size(313, 43)
        Me.summaryButton.TabIndex = 3
        Me.summaryButton.Text = "&Summary"
        Me.summaryButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.clearButton.Location = New System.Drawing.Point(544, 583)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(97, 43)
        Me.clearButton.TabIndex = 4
        Me.clearButton.Text = "Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'printPreviewButton
        '
        Me.printPreviewButton.Location = New System.Drawing.Point(664, 583)
        Me.printPreviewButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.printPreviewButton.Name = "printPreviewButton"
        Me.printPreviewButton.Size = New System.Drawing.Size(116, 43)
        Me.printPreviewButton.TabIndex = 5
        Me.printPreviewButton.Text = "&Print Preview"
        Me.printPreviewButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(797, 583)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(95, 43)
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
        Me.GroupBox2.Controls.Add(Me.totalAmountBox)
        Me.GroupBox2.Controls.Add(Me.shippingBox)
        Me.GroupBox2.Controls.Add(Me.taxBox)
        Me.GroupBox2.Controls.Add(Me.amountBox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.salesTaxBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.dollarOutput)
        Me.GroupBox2.Location = New System.Drawing.Point(499, 14)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(436, 222)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Order Summary"
        '
        'totalAmountBox
        '
        Me.totalAmountBox.Location = New System.Drawing.Point(213, 161)
        Me.totalAmountBox.Margin = New System.Windows.Forms.Padding(4)
        Me.totalAmountBox.Name = "totalAmountBox"
        Me.totalAmountBox.ReadOnly = True
        Me.totalAmountBox.Size = New System.Drawing.Size(132, 22)
        Me.totalAmountBox.TabIndex = 10
        '
        'shippingBox
        '
        Me.shippingBox.Location = New System.Drawing.Point(213, 117)
        Me.shippingBox.Margin = New System.Windows.Forms.Padding(4)
        Me.shippingBox.Name = "shippingBox"
        Me.shippingBox.ReadOnly = True
        Me.shippingBox.Size = New System.Drawing.Size(132, 22)
        Me.shippingBox.TabIndex = 9
        '
        'taxBox
        '
        Me.taxBox.Location = New System.Drawing.Point(213, 75)
        Me.taxBox.Margin = New System.Windows.Forms.Padding(4)
        Me.taxBox.Name = "taxBox"
        Me.taxBox.ReadOnly = True
        Me.taxBox.Size = New System.Drawing.Size(132, 22)
        Me.taxBox.TabIndex = 8
        '
        'amountBox
        '
        Me.amountBox.Location = New System.Drawing.Point(213, 33)
        Me.amountBox.Margin = New System.Windows.Forms.Padding(4)
        Me.amountBox.Name = "amountBox"
        Me.amountBox.ReadOnly = True
        Me.amountBox.Size = New System.Drawing.Size(132, 22)
        Me.amountBox.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(35, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(151, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Shipping and Handling"
        '
        'salesTaxBox
        '
        Me.salesTaxBox.AutoSize = True
        Me.salesTaxBox.Location = New System.Drawing.Point(35, 79)
        Me.salesTaxBox.Name = "salesTaxBox"
        Me.salesTaxBox.Size = New System.Drawing.Size(66, 17)
        Me.salesTaxBox.TabIndex = 2
        Me.salesTaxBox.Text = "SalesTax"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(35, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Total Amount Due"
        '
        'dollarOutput
        '
        Me.dollarOutput.AutoSize = True
        Me.dollarOutput.Location = New System.Drawing.Point(35, 42)
        Me.dollarOutput.Name = "dollarOutput"
        Me.dollarOutput.Size = New System.Drawing.Size(138, 17)
        Me.dollarOutput.TabIndex = 0
        Me.dollarOutput.Text = "Dollar Ammount Due"
        '
        'zipBox
        '
        Me.zipBox.Location = New System.Drawing.Point(276, 182)
        Me.zipBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.zipBox.Mask = "00000-9999"
        Me.zipBox.Name = "zipBox"
        Me.zipBox.Size = New System.Drawing.Size(69, 22)
        Me.zipBox.TabIndex = 9
        '
        'stateTextBox
        '
        Me.stateTextBox.Location = New System.Drawing.Point(276, 146)
        Me.stateTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.stateTextBox.MaxLength = 2
        Me.stateTextBox.Name = "stateTextBox"
        Me.stateTextBox.Size = New System.Drawing.Size(30, 22)
        Me.stateTextBox.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.item4PriceBox)
        Me.GroupBox1.Controls.Add(Me.item4quantBox)
        Me.GroupBox1.Controls.Add(Me.item4WeightBox)
        Me.GroupBox1.Controls.Add(Me.removeItem4Button)
        Me.GroupBox1.Controls.Add(Me.item4TextBox)
        Me.GroupBox1.Controls.Add(Me.item3PriceBox)
        Me.GroupBox1.Controls.Add(Me.item3quantBox)
        Me.GroupBox1.Controls.Add(Me.item2quantBox)
        Me.GroupBox1.Controls.Add(Me.item2PriceBox)
        Me.GroupBox1.Controls.Add(Me.item1quantBox)
        Me.GroupBox1.Controls.Add(Me.itemquantBox)
        Me.GroupBox1.Controls.Add(Me.item1PriceBox)
        Me.GroupBox1.Controls.Add(Me.item3WeightBox)
        Me.GroupBox1.Controls.Add(Me.itemPriceBox)
        Me.GroupBox1.Controls.Add(Me.removeItem3Button)
        Me.GroupBox1.Controls.Add(Me.item2WeightBox)
        Me.GroupBox1.Controls.Add(Me.removeItem1Button)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.itemWeightBox)
        Me.GroupBox1.Controls.Add(Me.removeItem2Button)
        Me.GroupBox1.Controls.Add(Me.item1WeightBox)
        Me.GroupBox1.Controls.Add(Me.addItem1Button)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.item3TextBox)
        Me.GroupBox1.Controls.Add(Me.item2TextBox)
        Me.GroupBox1.Controls.Add(Me.item1TextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.itemTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(73, 240)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(861, 302)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items"
        '
        'item4PriceBox
        '
        Me.item4PriceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item4PriceBox.Location = New System.Drawing.Point(391, 262)
        Me.item4PriceBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item4PriceBox.Name = "item4PriceBox"
        Me.item4PriceBox.ReadOnly = True
        Me.item4PriceBox.Size = New System.Drawing.Size(64, 22)
        Me.item4PriceBox.TabIndex = 26
        '
        'item4quantBox
        '
        Me.item4quantBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item4quantBox.Location = New System.Drawing.Point(9, 261)
        Me.item4quantBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item4quantBox.Name = "item4quantBox"
        Me.item4quantBox.ReadOnly = True
        Me.item4quantBox.Size = New System.Drawing.Size(56, 22)
        Me.item4quantBox.TabIndex = 24
        '
        'item4WeightBox
        '
        Me.item4WeightBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item4WeightBox.Location = New System.Drawing.Point(497, 265)
        Me.item4WeightBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item4WeightBox.Name = "item4WeightBox"
        Me.item4WeightBox.ReadOnly = True
        Me.item4WeightBox.Size = New System.Drawing.Size(68, 22)
        Me.item4WeightBox.TabIndex = 27
        '
        'removeItem4Button
        '
        Me.removeItem4Button.Location = New System.Drawing.Point(639, 259)
        Me.removeItem4Button.Margin = New System.Windows.Forms.Padding(4)
        Me.removeItem4Button.Name = "removeItem4Button"
        Me.removeItem4Button.Size = New System.Drawing.Size(100, 28)
        Me.removeItem4Button.TabIndex = 28
        Me.removeItem4Button.Text = "Remove"
        Me.removeItem4Button.UseVisualStyleBackColor = True
        '
        'item4TextBox
        '
        Me.item4TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item4TextBox.Location = New System.Drawing.Point(100, 261)
        Me.item4TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item4TextBox.Name = "item4TextBox"
        Me.item4TextBox.ReadOnly = True
        Me.item4TextBox.Size = New System.Drawing.Size(252, 22)
        Me.item4TextBox.TabIndex = 25
        '
        'item3PriceBox
        '
        Me.item3PriceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item3PriceBox.Location = New System.Drawing.Point(391, 225)
        Me.item3PriceBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item3PriceBox.Name = "item3PriceBox"
        Me.item3PriceBox.ReadOnly = True
        Me.item3PriceBox.Size = New System.Drawing.Size(64, 22)
        Me.item3PriceBox.TabIndex = 21
        '
        'item3quantBox
        '
        Me.item3quantBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item3quantBox.Location = New System.Drawing.Point(9, 224)
        Me.item3quantBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item3quantBox.Name = "item3quantBox"
        Me.item3quantBox.ReadOnly = True
        Me.item3quantBox.Size = New System.Drawing.Size(56, 22)
        Me.item3quantBox.TabIndex = 19
        '
        'item2quantBox
        '
        Me.item2quantBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item2quantBox.Location = New System.Drawing.Point(9, 188)
        Me.item2quantBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item2quantBox.Name = "item2quantBox"
        Me.item2quantBox.ReadOnly = True
        Me.item2quantBox.Size = New System.Drawing.Size(56, 22)
        Me.item2quantBox.TabIndex = 14
        '
        'item2PriceBox
        '
        Me.item2PriceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item2PriceBox.Location = New System.Drawing.Point(391, 191)
        Me.item2PriceBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item2PriceBox.Name = "item2PriceBox"
        Me.item2PriceBox.ReadOnly = True
        Me.item2PriceBox.Size = New System.Drawing.Size(64, 22)
        Me.item2PriceBox.TabIndex = 16
        '
        'item1quantBox
        '
        Me.item1quantBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item1quantBox.Location = New System.Drawing.Point(9, 153)
        Me.item1quantBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item1quantBox.Name = "item1quantBox"
        Me.item1quantBox.ReadOnly = True
        Me.item1quantBox.Size = New System.Drawing.Size(56, 22)
        Me.item1quantBox.TabIndex = 9
        '
        'itemquantBox
        '
        Me.itemquantBox.Location = New System.Drawing.Point(9, 65)
        Me.itemquantBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.itemquantBox.Name = "itemquantBox"
        Me.itemquantBox.Size = New System.Drawing.Size(56, 22)
        Me.itemquantBox.TabIndex = 4
        '
        'item1PriceBox
        '
        Me.item1PriceBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item1PriceBox.Location = New System.Drawing.Point(391, 155)
        Me.item1PriceBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item1PriceBox.Name = "item1PriceBox"
        Me.item1PriceBox.ReadOnly = True
        Me.item1PriceBox.Size = New System.Drawing.Size(64, 22)
        Me.item1PriceBox.TabIndex = 11
        '
        'item3WeightBox
        '
        Me.item3WeightBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item3WeightBox.Location = New System.Drawing.Point(497, 228)
        Me.item3WeightBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item3WeightBox.Name = "item3WeightBox"
        Me.item3WeightBox.ReadOnly = True
        Me.item3WeightBox.Size = New System.Drawing.Size(68, 22)
        Me.item3WeightBox.TabIndex = 22
        '
        'itemPriceBox
        '
        Me.itemPriceBox.Location = New System.Drawing.Point(391, 65)
        Me.itemPriceBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.itemPriceBox.Name = "itemPriceBox"
        Me.itemPriceBox.Size = New System.Drawing.Size(64, 22)
        Me.itemPriceBox.TabIndex = 6
        '
        'removeItem3Button
        '
        Me.removeItem3Button.Location = New System.Drawing.Point(639, 222)
        Me.removeItem3Button.Margin = New System.Windows.Forms.Padding(4)
        Me.removeItem3Button.Name = "removeItem3Button"
        Me.removeItem3Button.Size = New System.Drawing.Size(100, 28)
        Me.removeItem3Button.TabIndex = 23
        Me.removeItem3Button.Text = "Remove"
        Me.removeItem3Button.UseVisualStyleBackColor = True
        '
        'item2WeightBox
        '
        Me.item2WeightBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item2WeightBox.Location = New System.Drawing.Point(497, 188)
        Me.item2WeightBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item2WeightBox.Name = "item2WeightBox"
        Me.item2WeightBox.ReadOnly = True
        Me.item2WeightBox.Size = New System.Drawing.Size(68, 22)
        Me.item2WeightBox.TabIndex = 17
        '
        'removeItem1Button
        '
        Me.removeItem1Button.Location = New System.Drawing.Point(639, 148)
        Me.removeItem1Button.Margin = New System.Windows.Forms.Padding(4)
        Me.removeItem1Button.Name = "removeItem1Button"
        Me.removeItem1Button.Size = New System.Drawing.Size(100, 28)
        Me.removeItem1Button.TabIndex = 13
        Me.removeItem1Button.Text = "Remove"
        Me.removeItem1Button.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(511, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Weight"
        '
        'itemWeightBox
        '
        Me.itemWeightBox.Location = New System.Drawing.Point(497, 65)
        Me.itemWeightBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.itemWeightBox.Name = "itemWeightBox"
        Me.itemWeightBox.Size = New System.Drawing.Size(68, 22)
        Me.itemWeightBox.TabIndex = 7
        '
        'removeItem2Button
        '
        Me.removeItem2Button.Location = New System.Drawing.Point(639, 184)
        Me.removeItem2Button.Margin = New System.Windows.Forms.Padding(4)
        Me.removeItem2Button.Name = "removeItem2Button"
        Me.removeItem2Button.Size = New System.Drawing.Size(100, 28)
        Me.removeItem2Button.TabIndex = 18
        Me.removeItem2Button.Text = "Remove"
        Me.removeItem2Button.UseVisualStyleBackColor = True
        '
        'item1WeightBox
        '
        Me.item1WeightBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item1WeightBox.Location = New System.Drawing.Point(497, 155)
        Me.item1WeightBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item1WeightBox.Name = "item1WeightBox"
        Me.item1WeightBox.ReadOnly = True
        Me.item1WeightBox.Size = New System.Drawing.Size(68, 22)
        Me.item1WeightBox.TabIndex = 12
        '
        'addItem1Button
        '
        Me.addItem1Button.Location = New System.Drawing.Point(639, 62)
        Me.addItem1Button.Margin = New System.Windows.Forms.Padding(4)
        Me.addItem1Button.Name = "addItem1Button"
        Me.addItem1Button.Size = New System.Drawing.Size(100, 28)
        Me.addItem1Button.TabIndex = 8
        Me.addItem1Button.Text = "Add this Item"
        Me.addItem1Button.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Quantity"
        '
        'item3TextBox
        '
        Me.item3TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item3TextBox.Location = New System.Drawing.Point(100, 224)
        Me.item3TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item3TextBox.Name = "item3TextBox"
        Me.item3TextBox.ReadOnly = True
        Me.item3TextBox.Size = New System.Drawing.Size(252, 22)
        Me.item3TextBox.TabIndex = 20
        '
        'item2TextBox
        '
        Me.item2TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item2TextBox.Location = New System.Drawing.Point(100, 191)
        Me.item2TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item2TextBox.Name = "item2TextBox"
        Me.item2TextBox.ReadOnly = True
        Me.item2TextBox.Size = New System.Drawing.Size(252, 22)
        Me.item2TextBox.TabIndex = 15
        '
        'item1TextBox
        '
        Me.item1TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.item1TextBox.Location = New System.Drawing.Point(100, 155)
        Me.item1TextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.item1TextBox.Name = "item1TextBox"
        Me.item1TextBox.ReadOnly = True
        Me.item1TextBox.Size = New System.Drawing.Size(252, 22)
        Me.item1TextBox.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'itemTextBox
        '
        Me.itemTextBox.Location = New System.Drawing.Point(97, 65)
        Me.itemTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.Size = New System.Drawing.Size(252, 22)
        Me.itemTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(405, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.zipBox)
        Me.GroupBox3.Controls.Add(Me.nameBox)
        Me.GroupBox3.Controls.Add(Me.zipCode)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.stateTextBox)
        Me.GroupBox3.Controls.Add(Me.City)
        Me.GroupBox3.Controls.Add(Me.cityBox)
        Me.GroupBox3.Controls.Add(Me.addressBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Location = New System.Drawing.Point(64, 12)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(397, 223)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Info"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(713, 634)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(260, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Programmed by: John-William Trenholm"
        '
        'vbMailOrder
        '
        Me.AcceptButton = Me.summaryButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.clearButton
        Me.ClientSize = New System.Drawing.Size(1004, 652)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.printPreviewButton)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.summaryButton)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents zipBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents itemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents item3TextBox As System.Windows.Forms.TextBox
    Friend WithEvents item2TextBox As System.Windows.Forms.TextBox
    Friend WithEvents item1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents dollarOutput As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents salesTaxBox As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents removeItem3Button As System.Windows.Forms.Button
    Friend WithEvents removeItem1Button As System.Windows.Forms.Button
    Friend WithEvents removeItem2Button As System.Windows.Forms.Button
    Friend WithEvents addItem1Button As System.Windows.Forms.Button
    Friend WithEvents item3quantBox As System.Windows.Forms.TextBox
    Friend WithEvents item2quantBox As System.Windows.Forms.TextBox
    Friend WithEvents item1quantBox As System.Windows.Forms.TextBox
    Friend WithEvents itemquantBox As System.Windows.Forms.TextBox
    Friend WithEvents item3WeightBox As System.Windows.Forms.TextBox
    Friend WithEvents item2WeightBox As System.Windows.Forms.TextBox
    Friend WithEvents item1WeightBox As System.Windows.Forms.TextBox
    Friend WithEvents itemWeightBox As System.Windows.Forms.TextBox
    Friend WithEvents item3PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents item2PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents item1PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents itemPriceBox As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents totalAmountBox As System.Windows.Forms.TextBox
    Friend WithEvents shippingBox As System.Windows.Forms.TextBox
    Friend WithEvents taxBox As System.Windows.Forms.TextBox
    Friend WithEvents amountBox As System.Windows.Forms.TextBox
    Friend WithEvents item4PriceBox As System.Windows.Forms.TextBox
    Friend WithEvents item4quantBox As System.Windows.Forms.TextBox
    Friend WithEvents item4WeightBox As System.Windows.Forms.TextBox
    Friend WithEvents removeItem4Button As System.Windows.Forms.Button
    Friend WithEvents item4TextBox As System.Windows.Forms.TextBox

End Class
