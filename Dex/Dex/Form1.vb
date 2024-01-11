Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        NameTB.Text = ""
        PositionTB.Text = ""
        NumberTB.Text = ""
        AgeTB.Text = ""
        WeightHeaghtTB.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim outFile As New IO.StreamWriter("data.txt")
        outFile.Write(NameTB.Text)
        outFile.Write("|")
        outFile.Write(PositionTB.Text)
        outFile.Write("|")
        outFile.Write(NumberTB.Text)
        outFile.Write("|")
        outFile.Write(AgeTB.Text)
        outFile.Write("|")
        outFile.Write(WeightHeaghtTB.Text)
        outFile.Write("|")
        outFile.WriteLine(PictureBox1.ImageLocation)
        outFile.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub NameTB_TextChanged(sender As Object, e As EventArgs) Handles NameTB.TextChanged

    End Sub
End Class
