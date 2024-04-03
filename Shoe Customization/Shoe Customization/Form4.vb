Imports System.Security

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Nextbtn.Click
        Me.Hide()
        Dim f1 As New Form1
        f1.ShowDialog()
        Me.Show()
    End Sub
End Class