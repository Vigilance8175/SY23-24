Imports System.ComponentModel.Design
Imports System.Reflection.Emit

Public Class Form2
    Public shoecol As Color
    Public solecol As Color
    Public lacecol As Color
    Public stripecol As Color
    Public Si As Integer
    Public men As Integer
    Public women As Integer
    Public custsole As Integer
    Public brush As Integer
    Public towel As Integer
    Public polish As Integer
    Public supplies As Integer
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox4.Visible = True
            CheckBox5.Visible = True
        Else
            CheckBox4.Visible = False
            CheckBox5.Visible = False
            NumericUpDown1.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            NumericUpDown1.Visible = True
            men = 1

        Else
            NumericUpDown1.Visible = False
            men = 0
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            NumericUpDown1.Visible = True
            women = 1
        Else
            NumericUpDown1.Visible = False
            women = 0
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox8.Visible = True
            CheckBox10.Visible = True
            CheckBox6.Visible = True
            supplies = 1
        Else
            CheckBox8.Visible = False
            CheckBox10.Visible = False
            CheckBox6.Visible = False
            supplies = 0
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
            custsole = 1
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
        f3.Si2 = Si
        f3.men2 = men
        f3.women2 = women
        f3.custsole2 = custsole
        f3.brush2 = brush
        f3.towel2 = towel
        f3.polish2 = polish
        f3.supplies2 = supplies
        f3.ShowDialog()
        Me.Show()
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            brush = 1
        Else
            brush = 0
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            towel = 1
        Else
            towel = 0
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            polish = 1
        Else
            polish = 0
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Si = NumericUpDown1.Value
    End Sub
End Class