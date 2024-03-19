Public Class frm2Dplatformer
    Dim moveSpeed As Integer = 10
    Dim isJumping As Boolean
    Dim score As Integer
    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Left
                tmrLeft.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
        End Select
    End Sub
    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += moveSpeed
    End Sub
    Private Sub frm2Dplatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Left
                tmrLeft.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
        End Select
    End Sub
    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= moveSpeed
    End Sub
    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= moveSpeed
    End Sub
    Private Sub frm2Dplatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub
    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        Else
            If isJumping = False Then
                tmrGravity.Start()
            End If
        End If
        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
            End If
            If TypeOf b Is PictureBox Then
                If b.Tag = "restart" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        picPlayer.Location = PictureBox10.Location
                        PictureBox13.Visible = True
                        PictureBox6.Visible = True
                        PictureBox9.Visible = True
                        PictureBox7.Visible = True
                        ProgressBar1.Value -= 25
                        score = 0
                        ScoreLabel.Text = score
                    End If
                End If
            End If
            If TypeOf b Is PictureBox Then
                If b.Tag = "collectable" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) And b.Visible = True Then
                        b.Visible = False
                        score += 1
                        ScoreLabel.Text = score
                    End If
                End If
            End If
        Next
        If score = 4 Then
            WLabel.Visible = True
            ResetB.Visible = True
            moveSpeed = 0
        End If
        If ProgressBar1.Value = 0 Then
            Label2.Visible = True
            ResetB.Visible = True
            moveSpeed = 0
        End If
    End Sub
    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += moveSpeed
    End Sub
    Private Sub ResetB_Click(sender As Object, e As EventArgs) Handles ResetB.Click
        ProgressBar1.Value = 100
        ResetB.Visible = False
        Label2.Visible = False
        WLabel.Visible = False
        moveSpeed = 10
        picPlayer.Location = PictureBox10.Location
        score = 0
        ScoreLabel.Text = score
        PictureBox13.Visible = True
        PictureBox6.Visible = True
        PictureBox9.Visible = True
        PictureBox7.Visible = True
    End Sub
End Class