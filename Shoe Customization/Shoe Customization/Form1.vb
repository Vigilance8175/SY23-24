Public Class Form1
    Dim Sc As Color
    Private Sub shoecolor_Click(sender As Object, e As EventArgs) Handles shoecolor.Click
        PictureBox1.BackColor = Sc
        PictureBox2.BackColor = Sc
        PictureBox3.BackColor = Sc
        PictureBox4.BackColor = Sc
        PictureBox5.BackColor = Sc
        PictureBox6.BackColor = Sc
        PictureBox7.BackColor = Sc
        PictureBox8.BackColor = Sc
        PictureBox9.BackColor = Sc
        PictureBox10.BackColor = Sc
        PictureBox11.BackColor = Sc
        PictureBox12.BackColor = Sc
        PictureBox13.BackColor = Sc
        PictureBox14.BackColor = Sc
        PictureBox15.BackColor = Sc
        PictureBox16.BackColor = Sc
    End Sub

    Private Sub solecolor_Click(sender As Object, e As EventArgs) Handles solecolor.Click
        PictureBox27.BackColor = Sc
        PictureBox21.BackColor = Sc
        PictureBox28.BackColor = Sc
        PictureBox22.BackColor = Sc
        PictureBox20.BackColor = Sc
        PictureBox29.BackColor = Sc
        PictureBox30.BackColor = Sc
        PictureBox31.BackColor = Sc
        PictureBox32.BackColor = Sc
        PictureBox33.BackColor = Sc
    End Sub

    Private Sub lacecolor_Click(sender As Object, e As EventArgs) Handles lacecolor.Click
        PictureBox17.BackColor = Sc
        PictureBox18.BackColor = Sc
        PictureBox19.BackColor = Sc
    End Sub

    Private Sub stripecolor_Click(sender As Object, e As EventArgs) Handles stripecolor.Click
        PictureBox23.BackColor = Sc
        PictureBox24.BackColor = Sc
        PictureBox25.BackColor = Sc
        PictureBox26.BackColor = Sc
    End Sub

    Private Sub Color_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click
        Sc = sender.backcolor
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Sc = Color.White
        PictureBox1.BackColor = Sc
        PictureBox2.BackColor = Sc
        PictureBox3.BackColor = Sc
        PictureBox4.BackColor = Sc
        PictureBox5.BackColor = Sc
        PictureBox6.BackColor = Sc
        PictureBox7.BackColor = Sc
        PictureBox8.BackColor = Sc
        PictureBox9.BackColor = Sc
        PictureBox10.BackColor = Sc
        PictureBox11.BackColor = Sc
        PictureBox12.BackColor = Sc
        PictureBox13.BackColor = Sc
        PictureBox14.BackColor = Sc
        PictureBox15.BackColor = Sc
        PictureBox16.BackColor = Sc
        PictureBox27.BackColor = Sc
        PictureBox21.BackColor = Sc
        PictureBox28.BackColor = Sc
        PictureBox22.BackColor = Sc
        PictureBox20.BackColor = Sc
        PictureBox29.BackColor = Sc
        PictureBox30.BackColor = Sc
        PictureBox31.BackColor = Sc
        PictureBox32.BackColor = Sc
        PictureBox33.BackColor = Sc
        PictureBox17.BackColor = Sc
        PictureBox18.BackColor = Sc
        PictureBox19.BackColor = Sc
        PictureBox23.BackColor = Sc
        PictureBox24.BackColor = Sc
        PictureBox25.BackColor = Sc
        PictureBox26.BackColor = Sc
    End Sub
End Class
