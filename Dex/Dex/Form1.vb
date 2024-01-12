Imports System.IO

Public Class Form1
    Dim records(50) As String
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New IO.StreamReader("data.txt")
            records(0) = inFile.ReadLine
            records(1) = inFile.ReadLine
            inFile.Close()
        End If
    End Sub
End Class
