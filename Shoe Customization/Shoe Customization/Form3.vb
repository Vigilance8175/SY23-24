Public Class Form3
    Dim correct As Integer
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
End Class