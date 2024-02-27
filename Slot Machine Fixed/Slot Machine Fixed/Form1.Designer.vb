<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.spinButton = New System.Windows.Forms.Button()
        Me.r1Label = New System.Windows.Forms.Label()
        Me.r2Label = New System.Windows.Forms.Label()
        Me.r3Label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.doButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReelControl3 = New Slot_Machine_Fixed.ReelControl()
        Me.ReelControl2 = New Slot_Machine_Fixed.ReelControl()
        Me.ReelControl1 = New Slot_Machine_Fixed.ReelControl()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spinButton
        '
        Me.spinButton.BackColor = System.Drawing.Color.DarkRed
        Me.spinButton.Location = New System.Drawing.Point(737, 62)
        Me.spinButton.Name = "spinButton"
        Me.spinButton.Size = New System.Drawing.Size(69, 68)
        Me.spinButton.TabIndex = 3
        Me.spinButton.UseVisualStyleBackColor = False
        '
        'r1Label
        '
        Me.r1Label.AutoSize = True
        Me.r1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r1Label.Location = New System.Drawing.Point(258, 410)
        Me.r1Label.Name = "r1Label"
        Me.r1Label.Size = New System.Drawing.Size(26, 29)
        Me.r1Label.TabIndex = 4
        Me.r1Label.Text = "0"
        Me.r1Label.Visible = False
        '
        'r2Label
        '
        Me.r2Label.AutoSize = True
        Me.r2Label.BackColor = System.Drawing.Color.White
        Me.r2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r2Label.Location = New System.Drawing.Point(436, 410)
        Me.r2Label.Name = "r2Label"
        Me.r2Label.Size = New System.Drawing.Size(26, 29)
        Me.r2Label.TabIndex = 5
        Me.r2Label.Text = "0"
        Me.r2Label.Visible = False
        '
        'r3Label
        '
        Me.r3Label.AutoSize = True
        Me.r3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r3Label.Location = New System.Drawing.Point(615, 410)
        Me.r3Label.Name = "r3Label"
        Me.r3Label.Size = New System.Drawing.Size(26, 29)
        Me.r3Label.TabIndex = 6
        Me.r3Label.Text = "0"
        Me.r3Label.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(415, 513)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "$0.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Stencil", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(415, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 51)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "    "
        '
        'doButton
        '
        Me.doButton.BackColor = System.Drawing.SystemColors.Control
        Me.doButton.BackgroundImage = Global.Slot_Machine_Fixed.My.Resources.Resources.DollarCoin
        Me.doButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.doButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doButton.ForeColor = System.Drawing.Color.White
        Me.doButton.Location = New System.Drawing.Point(857, 228)
        Me.doButton.Name = "doButton"
        Me.doButton.Size = New System.Drawing.Size(89, 81)
        Me.doButton.TabIndex = 9
        Me.doButton.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Slot_Machine_Fixed.My.Resources.Resources.Slot
        Me.PictureBox1.Location = New System.Drawing.Point(127, -59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(704, 569)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(857, 521)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Show"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReelControl3
        '
        Me.ReelControl3.BackColor = System.Drawing.Color.White
        Me.ReelControl3.itemValue = 0
        Me.ReelControl3.Location = New System.Drawing.Point(555, 177)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(147, 146)
        Me.ReelControl3.spinTime = 2000
        Me.ReelControl3.TabIndex = 2
        '
        'ReelControl2
        '
        Me.ReelControl2.BackColor = System.Drawing.Color.White
        Me.ReelControl2.itemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(376, 177)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(147, 146)
        Me.ReelControl2.spinTime = 2000
        Me.ReelControl2.TabIndex = 1
        '
        'ReelControl1
        '
        Me.ReelControl1.BackColor = System.Drawing.Color.White
        Me.ReelControl1.itemValue = 0
        Me.ReelControl1.Location = New System.Drawing.Point(198, 177)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(147, 146)
        Me.ReelControl1.spinTime = 2000
        Me.ReelControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 579)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.doButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.r3Label)
        Me.Controls.Add(Me.r2Label)
        Me.Controls.Add(Me.r1Label)
        Me.Controls.Add(Me.spinButton)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Slot Machine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
    Friend WithEvents spinButton As Button
    Friend WithEvents r1Label As Label
    Friend WithEvents r2Label As Label
    Friend WithEvents r3Label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents doButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
End Class
