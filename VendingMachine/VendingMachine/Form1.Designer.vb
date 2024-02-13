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
        Me.DollarB = New System.Windows.Forms.Button()
        Me.QuarterB = New System.Windows.Forms.Button()
        Me.DimeB = New System.Windows.Forms.Button()
        Me.NickelB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CoinReturnB = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.QuarterPictureBox = New System.Windows.Forms.PictureBox()
        Me.DimePictureBox = New System.Windows.Forms.PictureBox()
        Me.NickelPictureBox = New System.Windows.Forms.PictureBox()
        Me.DollarPictureBox = New System.Windows.Forms.PictureBox()
        Me.BuyB = New System.Windows.Forms.Button()
        Me.IDTextbox = New System.Windows.Forms.TextBox()
        Me.ProductPB = New System.Windows.Forms.PictureBox()
        Me.ProductControl16 = New VendingMachine.ProductControl()
        Me.ProductControl15 = New VendingMachine.ProductControl()
        Me.ProductControl14 = New VendingMachine.ProductControl()
        Me.ProductControl13 = New VendingMachine.ProductControl()
        Me.ProductControl12 = New VendingMachine.ProductControl()
        Me.ProductControl11 = New VendingMachine.ProductControl()
        Me.ProductControl10 = New VendingMachine.ProductControl()
        Me.ProductControl9 = New VendingMachine.ProductControl()
        Me.ProductControl8 = New VendingMachine.ProductControl()
        Me.ProductControl7 = New VendingMachine.ProductControl()
        Me.ProductControl6 = New VendingMachine.ProductControl()
        Me.ProductControl5 = New VendingMachine.ProductControl()
        Me.ProductControl4 = New VendingMachine.ProductControl()
        Me.ProductControl3 = New VendingMachine.ProductControl()
        Me.ProductControl2 = New VendingMachine.ProductControl()
        Me.ProductControl1 = New VendingMachine.ProductControl()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuarterPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DimePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NickelPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DollarPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DollarB
        '
        Me.DollarB.Location = New System.Drawing.Point(75, 42)
        Me.DollarB.Name = "DollarB"
        Me.DollarB.Size = New System.Drawing.Size(75, 23)
        Me.DollarB.TabIndex = 0
        Me.DollarB.Text = "Dollar"
        Me.DollarB.UseVisualStyleBackColor = True
        '
        'QuarterB
        '
        Me.QuarterB.Location = New System.Drawing.Point(75, 115)
        Me.QuarterB.Name = "QuarterB"
        Me.QuarterB.Size = New System.Drawing.Size(75, 23)
        Me.QuarterB.TabIndex = 1
        Me.QuarterB.Text = "Quarter"
        Me.QuarterB.UseVisualStyleBackColor = True
        '
        'DimeB
        '
        Me.DimeB.Location = New System.Drawing.Point(75, 191)
        Me.DimeB.Name = "DimeB"
        Me.DimeB.Size = New System.Drawing.Size(75, 23)
        Me.DimeB.TabIndex = 2
        Me.DimeB.Text = "Dime"
        Me.DimeB.UseVisualStyleBackColor = True
        '
        'NickelB
        '
        Me.NickelB.Location = New System.Drawing.Point(75, 264)
        Me.NickelB.Name = "NickelB"
        Me.NickelB.Size = New System.Drawing.Size(75, 23)
        Me.NickelB.TabIndex = 3
        Me.NickelB.Text = "Nickel"
        Me.NickelB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(283, 153)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "$0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Total:"
        '
        'CoinReturnB
        '
        Me.CoinReturnB.Location = New System.Drawing.Point(24, 359)
        Me.CoinReturnB.Name = "CoinReturnB"
        Me.CoinReturnB.Size = New System.Drawing.Size(64, 45)
        Me.CoinReturnB.TabIndex = 10
        Me.CoinReturnB.Text = "Coin Return"
        Me.CoinReturnB.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.VendingMachine.My.Resources.Resources.Nickel
        Me.PictureBox4.Location = New System.Drawing.Point(12, 247)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(57, 59)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.VendingMachine.My.Resources.Resources.Dime
        Me.PictureBox3.Location = New System.Drawing.Point(12, 172)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(57, 62)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.VendingMachine.My.Resources.Resources.Quarter
        Me.PictureBox2.Location = New System.Drawing.Point(12, 96)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.VendingMachine.My.Resources.Resources.DollarCoin
        Me.PictureBox1.Location = New System.Drawing.Point(12, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(57, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'QuarterPictureBox
        '
        Me.QuarterPictureBox.Image = Global.VendingMachine.My.Resources.Resources.Quarter
        Me.QuarterPictureBox.Location = New System.Drawing.Point(88, 432)
        Me.QuarterPictureBox.Name = "QuarterPictureBox"
        Me.QuarterPictureBox.Size = New System.Drawing.Size(58, 59)
        Me.QuarterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.QuarterPictureBox.TabIndex = 7
        Me.QuarterPictureBox.TabStop = False
        Me.QuarterPictureBox.Visible = False
        '
        'DimePictureBox
        '
        Me.DimePictureBox.Image = Global.VendingMachine.My.Resources.Resources.Dime
        Me.DimePictureBox.Location = New System.Drawing.Point(152, 432)
        Me.DimePictureBox.Name = "DimePictureBox"
        Me.DimePictureBox.Size = New System.Drawing.Size(68, 61)
        Me.DimePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DimePictureBox.TabIndex = 6
        Me.DimePictureBox.TabStop = False
        Me.DimePictureBox.Visible = False
        '
        'NickelPictureBox
        '
        Me.NickelPictureBox.Image = Global.VendingMachine.My.Resources.Resources.Nickel
        Me.NickelPictureBox.Location = New System.Drawing.Point(226, 432)
        Me.NickelPictureBox.Name = "NickelPictureBox"
        Me.NickelPictureBox.Size = New System.Drawing.Size(58, 61)
        Me.NickelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.NickelPictureBox.TabIndex = 5
        Me.NickelPictureBox.TabStop = False
        Me.NickelPictureBox.Visible = False
        '
        'DollarPictureBox
        '
        Me.DollarPictureBox.Image = Global.VendingMachine.My.Resources.Resources.DollarCoin
        Me.DollarPictureBox.Location = New System.Drawing.Point(24, 430)
        Me.DollarPictureBox.Name = "DollarPictureBox"
        Me.DollarPictureBox.Size = New System.Drawing.Size(58, 61)
        Me.DollarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DollarPictureBox.TabIndex = 4
        Me.DollarPictureBox.TabStop = False
        Me.DollarPictureBox.Visible = False
        '
        'BuyB
        '
        Me.BuyB.Location = New System.Drawing.Point(239, 200)
        Me.BuyB.Name = "BuyB"
        Me.BuyB.Size = New System.Drawing.Size(75, 34)
        Me.BuyB.TabIndex = 31
        Me.BuyB.Text = "Buy"
        Me.BuyB.UseVisualStyleBackColor = True
        '
        'IDTextbox
        '
        Me.IDTextbox.Location = New System.Drawing.Point(226, 172)
        Me.IDTextbox.Name = "IDTextbox"
        Me.IDTextbox.Size = New System.Drawing.Size(100, 22)
        Me.IDTextbox.TabIndex = 32
        '
        'ProductPB
        '
        Me.ProductPB.Location = New System.Drawing.Point(616, 471)
        Me.ProductPB.Name = "ProductPB"
        Me.ProductPB.Size = New System.Drawing.Size(88, 85)
        Me.ProductPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductPB.TabIndex = 33
        Me.ProductPB.TabStop = False
        '
        'ProductControl16
        '
        Me.ProductControl16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl16.Location = New System.Drawing.Point(773, 359)
        Me.ProductControl16.Name = "ProductControl16"
        Me.ProductControl16.ProductCount = 5
        Me.ProductControl16.ProductID = "D4"
        Me.ProductControl16.ProductPicture = Global.VendingMachine.My.Resources.Resources.TEA
        Me.ProductControl16.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl16.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl16.TabIndex = 30
        '
        'ProductControl15
        '
        Me.ProductControl15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl15.Location = New System.Drawing.Point(660, 359)
        Me.ProductControl15.Name = "ProductControl15"
        Me.ProductControl15.ProductCount = 7
        Me.ProductControl15.ProductID = "D3"
        Me.ProductControl15.ProductPicture = Global.VendingMachine.My.Resources.Resources.APPLEJUICE
        Me.ProductControl15.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl15.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl15.TabIndex = 29
        '
        'ProductControl14
        '
        Me.ProductControl14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl14.Location = New System.Drawing.Point(547, 359)
        Me.ProductControl14.Name = "ProductControl14"
        Me.ProductControl14.ProductCount = 2
        Me.ProductControl14.ProductID = "D2"
        Me.ProductControl14.ProductPicture = Global.VendingMachine.My.Resources.Resources.PINKLEMONADE
        Me.ProductControl14.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl14.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl14.TabIndex = 28
        '
        'ProductControl13
        '
        Me.ProductControl13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl13.Location = New System.Drawing.Point(434, 359)
        Me.ProductControl13.Name = "ProductControl13"
        Me.ProductControl13.ProductCount = 4
        Me.ProductControl13.ProductID = "D1"
        Me.ProductControl13.ProductPicture = Global.VendingMachine.My.Resources.Resources.LEMONADE
        Me.ProductControl13.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl13.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl13.TabIndex = 27
        '
        'ProductControl12
        '
        Me.ProductControl12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl12.Location = New System.Drawing.Point(773, 247)
        Me.ProductControl12.Name = "ProductControl12"
        Me.ProductControl12.ProductCount = 5
        Me.ProductControl12.ProductID = "C4"
        Me.ProductControl12.ProductPicture = Global.VendingMachine.My.Resources.Resources.FIJI
        Me.ProductControl12.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl12.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl12.TabIndex = 26
        '
        'ProductControl11
        '
        Me.ProductControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl11.Location = New System.Drawing.Point(660, 247)
        Me.ProductControl11.Name = "ProductControl11"
        Me.ProductControl11.ProductCount = 6
        Me.ProductControl11.ProductID = "C3"
        Me.ProductControl11.ProductPicture = Global.VendingMachine.My.Resources.Resources.SPRITE
        Me.ProductControl11.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl11.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl11.TabIndex = 25
        '
        'ProductControl10
        '
        Me.ProductControl10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl10.Location = New System.Drawing.Point(547, 247)
        Me.ProductControl10.Name = "ProductControl10"
        Me.ProductControl10.ProductCount = 10
        Me.ProductControl10.ProductID = "C2"
        Me.ProductControl10.ProductPicture = Global.VendingMachine.My.Resources.Resources.PEPSI
        Me.ProductControl10.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl10.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl10.TabIndex = 24
        '
        'ProductControl9
        '
        Me.ProductControl9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl9.Location = New System.Drawing.Point(434, 247)
        Me.ProductControl9.Name = "ProductControl9"
        Me.ProductControl9.ProductCount = 1
        Me.ProductControl9.ProductID = "C1"
        Me.ProductControl9.ProductPicture = Global.VendingMachine.My.Resources.Resources.COCACOLA
        Me.ProductControl9.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl9.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl9.TabIndex = 23
        '
        'ProductControl8
        '
        Me.ProductControl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl8.Location = New System.Drawing.Point(773, 135)
        Me.ProductControl8.Name = "ProductControl8"
        Me.ProductControl8.ProductCount = 6
        Me.ProductControl8.ProductID = "B4"
        Me.ProductControl8.ProductPicture = Global.VendingMachine.My.Resources.Resources.CREAM
        Me.ProductControl8.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl8.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl8.TabIndex = 22
        '
        'ProductControl7
        '
        Me.ProductControl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl7.Location = New System.Drawing.Point(660, 135)
        Me.ProductControl7.Name = "ProductControl7"
        Me.ProductControl7.ProductCount = 3
        Me.ProductControl7.ProductID = "B3"
        Me.ProductControl7.ProductPicture = Global.VendingMachine.My.Resources.Resources.CHERRYFANTA
        Me.ProductControl7.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl7.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl7.TabIndex = 21
        '
        'ProductControl6
        '
        Me.ProductControl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl6.Location = New System.Drawing.Point(434, 135)
        Me.ProductControl6.Name = "ProductControl6"
        Me.ProductControl6.ProductCount = 6
        Me.ProductControl6.ProductID = "B1"
        Me.ProductControl6.ProductPicture = Global.VendingMachine.My.Resources.Resources.FANTA
        Me.ProductControl6.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl6.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl6.TabIndex = 20
        '
        'ProductControl5
        '
        Me.ProductControl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl5.Location = New System.Drawing.Point(547, 135)
        Me.ProductControl5.Name = "ProductControl5"
        Me.ProductControl5.ProductCount = 8
        Me.ProductControl5.ProductID = "B2"
        Me.ProductControl5.ProductPicture = Global.VendingMachine.My.Resources.Resources.GRAPEFANTA
        Me.ProductControl5.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl5.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl5.TabIndex = 19
        '
        'ProductControl4
        '
        Me.ProductControl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl4.Location = New System.Drawing.Point(773, 23)
        Me.ProductControl4.Name = "ProductControl4"
        Me.ProductControl4.ProductCount = 4
        Me.ProductControl4.ProductID = "A4"
        Me.ProductControl4.ProductPicture = Global.VendingMachine.My.Resources.Resources.BAJABLAST
        Me.ProductControl4.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl4.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl4.TabIndex = 18
        '
        'ProductControl3
        '
        Me.ProductControl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl3.Location = New System.Drawing.Point(660, 23)
        Me.ProductControl3.Name = "ProductControl3"
        Me.ProductControl3.ProductCount = 9
        Me.ProductControl3.ProductID = "A3"
        Me.ProductControl3.ProductPicture = Global.VendingMachine.My.Resources.Resources.MTDEW
        Me.ProductControl3.ProductPrice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.ProductControl3.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl3.TabIndex = 17
        '
        'ProductControl2
        '
        Me.ProductControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl2.Location = New System.Drawing.Point(547, 23)
        Me.ProductControl2.Name = "ProductControl2"
        Me.ProductControl2.ProductCount = 7
        Me.ProductControl2.ProductID = "A2"
        Me.ProductControl2.ProductPicture = Global.VendingMachine.My.Resources.Resources.ROOTBEER
        Me.ProductControl2.ProductPrice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl2.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl2.TabIndex = 16
        '
        'ProductControl1
        '
        Me.ProductControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductControl1.Location = New System.Drawing.Point(434, 23)
        Me.ProductControl1.Name = "ProductControl1"
        Me.ProductControl1.ProductCount = 6
        Me.ProductControl1.ProductID = "A1"
        Me.ProductControl1.ProductPicture = Global.VendingMachine.My.Resources.Resources.DRPEPPER
        Me.ProductControl1.ProductPrice = New Decimal(New Integer() {150, 0, 0, 131072})
        Me.ProductControl1.Size = New System.Drawing.Size(107, 106)
        Me.ProductControl1.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 569)
        Me.Controls.Add(Me.ProductPB)
        Me.Controls.Add(Me.IDTextbox)
        Me.Controls.Add(Me.BuyB)
        Me.Controls.Add(Me.ProductControl16)
        Me.Controls.Add(Me.ProductControl15)
        Me.Controls.Add(Me.ProductControl14)
        Me.Controls.Add(Me.ProductControl13)
        Me.Controls.Add(Me.ProductControl12)
        Me.Controls.Add(Me.ProductControl11)
        Me.Controls.Add(Me.ProductControl10)
        Me.Controls.Add(Me.ProductControl9)
        Me.Controls.Add(Me.ProductControl8)
        Me.Controls.Add(Me.ProductControl7)
        Me.Controls.Add(Me.ProductControl6)
        Me.Controls.Add(Me.ProductControl5)
        Me.Controls.Add(Me.ProductControl4)
        Me.Controls.Add(Me.ProductControl3)
        Me.Controls.Add(Me.ProductControl2)
        Me.Controls.Add(Me.ProductControl1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CoinReturnB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QuarterPictureBox)
        Me.Controls.Add(Me.DimePictureBox)
        Me.Controls.Add(Me.NickelPictureBox)
        Me.Controls.Add(Me.DollarPictureBox)
        Me.Controls.Add(Me.NickelB)
        Me.Controls.Add(Me.DimeB)
        Me.Controls.Add(Me.QuarterB)
        Me.Controls.Add(Me.DollarB)
        Me.Name = "Form1"
        Me.Text = "Vending Machine"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuarterPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DimePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NickelPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DollarPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DollarB As Button
    Friend WithEvents QuarterB As Button
    Friend WithEvents DimeB As Button
    Friend WithEvents NickelB As Button
    Friend WithEvents DollarPictureBox As PictureBox
    Friend WithEvents NickelPictureBox As PictureBox
    Friend WithEvents DimePictureBox As PictureBox
    Friend WithEvents QuarterPictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CoinReturnB As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ProductControl1 As ProductControl
    Friend WithEvents ProductControl2 As ProductControl
    Friend WithEvents ProductControl3 As ProductControl
    Friend WithEvents ProductControl4 As ProductControl
    Friend WithEvents ProductControl5 As ProductControl
    Friend WithEvents ProductControl6 As ProductControl
    Friend WithEvents ProductControl7 As ProductControl
    Friend WithEvents ProductControl8 As ProductControl
    Friend WithEvents ProductControl9 As ProductControl
    Friend WithEvents ProductControl10 As ProductControl
    Friend WithEvents ProductControl11 As ProductControl
    Friend WithEvents ProductControl12 As ProductControl
    Friend WithEvents ProductControl13 As ProductControl
    Friend WithEvents ProductControl14 As ProductControl
    Friend WithEvents ProductControl15 As ProductControl
    Friend WithEvents ProductControl16 As ProductControl
    Friend WithEvents BuyB As Button
    Friend WithEvents IDTextbox As TextBox
    Friend WithEvents ProductPB As PictureBox
End Class
