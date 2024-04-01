Imports System.ComponentModel.Design
Imports System.Reflection.Emit

Public Class Form2
    Public shoecol As Color
    Public solecol As Color
    Public lacecol As Color
    Public stripecol As Color
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox4.Visible = True
            CheckBox5.Visible = True
        Else
            CheckBox4.Visible = False
            CheckBox5.Visible = False
            DomainUpDown1.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            DomainUpDown1.Visible = True
        Else
            DomainUpDown1.Visible = False
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            DomainUpDown1.Visible = True
        Else
            DomainUpDown1.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox8.Visible = True
            CheckBox10.Visible = True
            CheckBox6.Visible = True
        Else
            CheckBox8.Visible = False
            CheckBox10.Visible = False
            CheckBox6.Visible = False
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub nextbtn_Click(sender As Object, e As EventArgs) Handles nextbtn.Click
        Me.Hide()
        Dim f3 As New Form3
        f3.shoecol2 = shoecol
        f3.solecol2 = solecol
        f3.lacecol2 = lacecol
        f3.stripecol2 = stripecol
        f3.ShowDialog()
        Me.Show()
    End Sub
End Class