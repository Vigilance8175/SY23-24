<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm2Dplatformer
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
        Me.picPlayer = New System.Windows.Forms.PictureBox()
        Me.picAir = New System.Windows.Forms.PictureBox()
        Me.picGround = New System.Windows.Forms.PictureBox()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.tmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGravity = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.BDogPB = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.WLabel = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Mover2 = New _2D_Platformer_Game.Mover()
        Me.Mover1 = New _2D_Platformer_Game.Mover()
        Me.Mover3 = New _2D_Platformer_Game.Mover()
        Me.Mover4 = New _2D_Platformer_Game.Mover()
        Me.Mover5 = New _2D_Platformer_Game.Mover()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ResetB = New System.Windows.Forms.Button()
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDogPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picPlayer
        '
        Me.picPlayer.BackColor = System.Drawing.Color.Purple
        Me.picPlayer.BackgroundImage = Global._2D_Platformer_Game.My.Resources.Resources.DoodleCharacter
        Me.picPlayer.Image = Global._2D_Platformer_Game.My.Resources.Resources.DoodleCharacter
        Me.picPlayer.Location = New System.Drawing.Point(12, 390)
        Me.picPlayer.Name = "picPlayer"
        Me.picPlayer.Size = New System.Drawing.Size(48, 47)
        Me.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPlayer.TabIndex = 0
        Me.picPlayer.TabStop = False
        '
        'picAir
        '
        Me.picAir.BackColor = System.Drawing.SystemColors.Control
        Me.picAir.BackgroundImage = Global._2D_Platformer_Game.My.Resources.Resources.DoodleBackground
        Me.picAir.Location = New System.Drawing.Point(-2, -3)
        Me.picAir.Name = "picAir"
        Me.picAir.Size = New System.Drawing.Size(844, 401)
        Me.picAir.TabIndex = 1
        Me.picAir.TabStop = False
        '
        'picGround
        '
        Me.picGround.BackColor = System.Drawing.Color.SpringGreen
        Me.picGround.Location = New System.Drawing.Point(-2, 443)
        Me.picGround.Name = "picGround"
        Me.picGround.Size = New System.Drawing.Size(844, 50)
        Me.picGround.TabIndex = 2
        Me.picGround.TabStop = False
        '
        'tmrRight
        '
        Me.tmrRight.Interval = 10
        '
        'tmrLeft
        '
        Me.tmrLeft.Interval = 10
        '
        'tmrUp
        '
        Me.tmrUp.Interval = 10
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 10
        '
        'tmrGravity
        '
        Me.tmrGravity.Interval = 10
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Red
        Me.PictureBox5.Location = New System.Drawing.Point(384, 130)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(110, 13)
        Me.PictureBox5.TabIndex = 7
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Tag = "restart"
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.White
        Me.PictureBox8.Image = Global._2D_Platformer_Game.My.Resources.Resources.Puppy
        Me.PictureBox8.Location = New System.Drawing.Point(9980, 201)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(47, 34)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        Me.PictureBox8.Tag = "collectable"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Sad Puppies Saved:"
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.BackColor = System.Drawing.Color.Transparent
        Me.ScoreLabel.Location = New System.Drawing.Point(70, 109)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(14, 16)
        Me.ScoreLabel.TabIndex = 14
        Me.ScoreLabel.Text = "0"
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.White
        Me.PictureBox12.Image = Global._2D_Platformer_Game.My.Resources.Resources.Puppy
        Me.PictureBox12.Location = New System.Drawing.Point(2458, 159)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(47, 34)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox12.TabIndex = 17
        Me.PictureBox12.TabStop = False
        Me.PictureBox12.Tag = "collectable"
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.Image = Global._2D_Platformer_Game.My.Resources.Resources.Puppy
        Me.PictureBox13.Location = New System.Drawing.Point(400, 252)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(47, 34)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox13.TabIndex = 19
        Me.PictureBox13.TabStop = False
        Me.PictureBox13.Tag = "collectable"
        '
        'BDogPB
        '
        Me.BDogPB.Image = Global._2D_Platformer_Game.My.Resources.Resources.BadDog
        Me.BDogPB.Location = New System.Drawing.Point(328, 365)
        Me.BDogPB.Name = "BDogPB"
        Me.BDogPB.Size = New System.Drawing.Size(64, 74)
        Me.BDogPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BDogPB.TabIndex = 20
        Me.BDogPB.TabStop = False
        Me.BDogPB.Tag = "restart"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(384, 338)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 13)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "restart"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Indigo
        Me.PictureBox2.Location = New System.Drawing.Point(118, 268)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(108, 25)
        Me.PictureBox2.TabIndex = 23
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "bound"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Indigo
        Me.PictureBox3.Location = New System.Drawing.Point(673, 268)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(108, 25)
        Me.PictureBox3.TabIndex = 24
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "bound"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Indigo
        Me.PictureBox4.Location = New System.Drawing.Point(384, 64)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(108, 25)
        Me.PictureBox4.TabIndex = 25
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bound"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global._2D_Platformer_Game.My.Resources.Resources.Puppy
        Me.PictureBox6.Location = New System.Drawing.Point(76, 298)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(47, 34)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 27
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Tag = "collectable"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = Global._2D_Platformer_Game.My.Resources.Resources.Puppy
        Me.PictureBox7.Location = New System.Drawing.Point(499, 92)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(47, 34)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 28
        Me.PictureBox7.TabStop = False
        Me.PictureBox7.Tag = "collectable"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = Global._2D_Platformer_Game.My.Resources.Resources.Puppy
        Me.PictureBox9.Location = New System.Drawing.Point(634, 298)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(47, 34)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox9.TabIndex = 29
        Me.PictureBox9.TabStop = False
        Me.PictureBox9.Tag = "collectable"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-2, 471)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 22)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.Text = "Click Here To Play!"
        '
        'WLabel
        '
        Me.WLabel.AutoSize = True
        Me.WLabel.BackColor = System.Drawing.Color.Transparent
        Me.WLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.WLabel.Location = New System.Drawing.Point(342, 189)
        Me.WLabel.Name = "WLabel"
        Me.WLabel.Size = New System.Drawing.Size(198, 91)
        Me.WLabel.TabIndex = 33
        Me.WLabel.Text = "WIN"
        Me.WLabel.Visible = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Location = New System.Drawing.Point(12, 390)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(48, 47)
        Me.PictureBox10.TabIndex = 34
        Me.PictureBox10.TabStop = False
        Me.PictureBox10.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(15, 28)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(263, 23)
        Me.ProgressBar1.TabIndex = 35
        Me.ProgressBar1.Value = 100
        '
        'Mover2
        '
        Me.Mover2.BackColor = System.Drawing.Color.Transparent
        Me.Mover2.interval = 500
        Me.Mover2.Location = New System.Drawing.Point(118, 380)
        Me.Mover2.Name = "Mover2"
        Me.Mover2.Size = New System.Drawing.Size(634, 18)
        Me.Mover2.speed = 15
        Me.Mover2.sprite = Me.BDogPB
        Me.Mover2.TabIndex = 21
        '
        'Mover1
        '
        Me.Mover1.BackColor = System.Drawing.Color.Transparent
        Me.Mover1.interval = 500
        Me.Mover1.Location = New System.Drawing.Point(410, 172)
        Me.Mover1.Name = "Mover1"
        Me.Mover1.Size = New System.Drawing.Size(45, 121)
        Me.Mover1.speed = 10
        Me.Mover1.sprite = Me.PictureBox13
        Me.Mover1.TabIndex = 18
        '
        'Mover3
        '
        Me.Mover3.BackColor = System.Drawing.Color.Transparent
        Me.Mover3.interval = 500
        Me.Mover3.Location = New System.Drawing.Point(66, 228)
        Me.Mover3.Name = "Mover3"
        Me.Mover3.Size = New System.Drawing.Size(159, 62)
        Me.Mover3.speed = 10
        Me.Mover3.sprite = Me.PictureBox6
        Me.Mover3.TabIndex = 26
        '
        'Mover4
        '
        Me.Mover4.BackColor = System.Drawing.Color.Transparent
        Me.Mover4.interval = 500
        Me.Mover4.Location = New System.Drawing.Point(329, 22)
        Me.Mover4.Name = "Mover4"
        Me.Mover4.Size = New System.Drawing.Size(165, 66)
        Me.Mover4.speed = 10
        Me.Mover4.sprite = Me.PictureBox7
        Me.Mover4.TabIndex = 30
        '
        'Mover5
        '
        Me.Mover5.BackColor = System.Drawing.Color.Transparent
        Me.Mover5.interval = 500
        Me.Mover5.Location = New System.Drawing.Point(624, 228)
        Me.Mover5.Name = "Mover5"
        Me.Mover5.Size = New System.Drawing.Size(157, 65)
        Me.Mover5.speed = 10
        Me.Mover5.sprite = Me.PictureBox9
        Me.Mover5.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(312, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 91)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "LOSE"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Health:"
        '
        'ResetB
        '
        Me.ResetB.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetB.Location = New System.Drawing.Point(346, 299)
        Me.ResetB.Name = "ResetB"
        Me.ResetB.Size = New System.Drawing.Size(187, 65)
        Me.ResetB.TabIndex = 38
        Me.ResetB.Text = "Reset"
        Me.ResetB.UseVisualStyleBackColor = True
        Me.ResetB.Visible = False
        '
        'frm2Dplatformer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global._2D_Platformer_Game.My.Resources.Resources.DoodleBackground
        Me.ClientSize = New System.Drawing.Size(839, 494)
        Me.Controls.Add(Me.ResetB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.picPlayer)
        Me.Controls.Add(Me.WLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BDogPB)
        Me.Controls.Add(Me.Mover2)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.Mover1)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.picGround)
        Me.Controls.Add(Me.Mover3)
        Me.Controls.Add(Me.Mover4)
        Me.Controls.Add(Me.Mover5)
        Me.Controls.Add(Me.picAir)
        Me.Controls.Add(Me.PictureBox10)
        Me.Name = "frm2Dplatformer"
        Me.Text = "Form1"
        CType(Me.picPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDogPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Mover1 As Mover
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents BDogPB As PictureBox
    Friend WithEvents Mover2 As Mover
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Mover3 As Mover
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents Mover4 As Mover
    Friend WithEvents Mover5 As Mover
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents WLabel As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ResetB As Button
End Class
