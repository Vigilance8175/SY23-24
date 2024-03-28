Public Class Form3
    Dim correct As Integer
    Public shoecol2 As Color
    Public solecol2 As Color
    Public lacecol2 As Color
    Public stripecol2 As Color
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text Like "#### #### #### ####" Then
            correct += 1
        Else
            correct = correct
        End If
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text Like "##/##" Then
            correct += 1
        Else
            correct = correct
        End If
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text Like "###" Then
            correct += 1
        Else
            correct = correct
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text Like "#####" Then
            correct += 1
        Else
            correct = correct
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackColor = shoecol2
        PictureBox2.BackColor = solecol2
        PictureBox3.BackColor = lacecol2
        PictureBox4.BackColor = stripecol2
    End Sub
End Class