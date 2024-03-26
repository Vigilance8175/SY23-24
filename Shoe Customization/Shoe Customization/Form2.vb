Public Class Form2
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox4.Visible = True
            CheckBox5.Visible = True
        Else
            CheckBox4.Visible = False
            CheckBox5.Visible = False
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
        End If
    End Sub
End Class