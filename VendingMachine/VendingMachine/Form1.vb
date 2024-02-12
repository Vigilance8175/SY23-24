Imports System.Security.Cryptography

Public Class Form1
    Dim WithEvents CS As New CoinSlot
    Private Sub NickelB_Click(sender As Object, e As EventArgs) Handles NickelB.Click
        CS.InsertNickel()
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub DimeB_Click(sender As Object, e As EventArgs) Handles DimeB.Click
        CS.InsertDime()
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub QuarterB_Click(sender As Object, e As EventArgs) Handles QuarterB.Click
        CS.InsertQuarter()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub DollarB_Click(sender As Object, e As EventArgs) Handles DollarB.Click
        CS.InsertDollar()
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub CoinReturnB_Click(sender As Object, e As EventArgs) Handles CoinReturnB.Click
        CS.CoinReturn()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer) Handles CS.coinreturnevent
        If d > 0 Then
            DollarPictureBox.Visible = True
        Else
            DollarPictureBox.Visible = False
        End If
        If q > 0 Then
            QuarterPictureBox.Visible = True
        Else
            QuarterPictureBox.Visible = False
        End If
        If di > 0 Then
            DimePictureBox.Visible = True
        Else
            DimePictureBox.Visible = False
        End If
        If n > 0 Then
            NickelPictureBox.Visible = True
        Else
            NickelPictureBox.Visible = False
        End If
    End Sub

    Private Sub BuyB_Click(sender As Object, e As EventArgs) Handles BuyB.Click
        Select Case IDTextbox.Text
            Case ProductControl1.ProductID
                ProductControl1.Buy()
            Case 2

            Case Else

        End Select
        ProductControl1.Buy()
    End Sub
End Class
