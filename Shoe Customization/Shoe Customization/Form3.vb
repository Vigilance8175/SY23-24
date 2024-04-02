Public Class Form3
    Dim num As Integer
    Dim cvv As Integer
    Dim exp As Integer
    Dim cod As Integer
    Public shoecol2 As Color
    Public solecol2 As Color
    Public lacecol2 As Color
    Public stripecol2 As Color
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text Like "#### #### #### ####" Then
            num += 1
            TextBox1.BackColor = Color.Green
        Else
            TextBox1.BackColor = Color.Red
            num = 0
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text Like "##/##" Then
            exp += 1
            TextBox2.BackColor = Color.Green
        Else
            TextBox2.BackColor = Color.Red
            exp = 0
        End If
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text Like "###" Then
            cvv += 1
            TextBox3.BackColor = Color.Green
        Else
            TextBox3.BackColor = Color.Red
            cvv = 0
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text Like "#####" Then
            cod += 1
            TextBox4.BackColor = Color.Green
        Else
            TextBox4.BackColor = Color.Red
            cod = 0
        End If
        If cod = 1 And exp = 1 And cvv = 1 And num = 1 Then
            Button1.Visible = True
        Else
            Button1.Visible = False
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = shoecol2
        PictureBox2.BackColor = solecol2
        PictureBox3.BackColor = lacecol2
        PictureBox4.BackColor = stripecol2
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label16.Visible = True
    End Sub
    Function shoesize(size As Integer, men As Integer, women As Integer) As Integer
        Return 80 + 0.25 * size + 10 * men + 8 * women
    End Function
    Function extra(supplies As Integer, brushes As Integer, towel As Integer, polisher As Integer) As Integer
        Return 17.5 * supplies + 8.75 * brushes + 10 * towel + 7.5 * polisher
    End Function
End Class