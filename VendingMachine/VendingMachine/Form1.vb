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
                CS.Buy(ProductControl1)
            Case ProductControl2.ProductID
                CS.Buy(ProductControl2)
            Case ProductControl3.ProductID
                CS.Buy(ProductControl3)
            Case ProductControl4.ProductID
                CS.Buy(ProductControl4)
            Case ProductControl5.ProductID
                CS.Buy(ProductControl5)
            Case ProductControl6.ProductID
                CS.Buy(ProductControl6)
            Case ProductControl7.ProductID
                CS.Buy(ProductControl7)
            Case ProductControl8.ProductID
                CS.Buy(ProductControl8)
            Case ProductControl9.ProductID
                CS.Buy(ProductControl9)
            Case ProductControl10.ProductID
                CS.Buy(ProductControl10)
            Case ProductControl11.ProductID
                CS.Buy(ProductControl11)
            Case ProductControl12.ProductID
                CS.Buy(ProductControl12)
            Case ProductControl13.ProductID
                CS.Buy(ProductControl13)
            Case ProductControl14.ProductID
                CS.Buy(ProductControl14)
            Case ProductControl15.ProductID
                CS.Buy(ProductControl15)
            Case ProductControl16.ProductID
                CS.Buy(ProductControl16)
            Case Else

        End Select
        Label1.Text = CS.Total.ToString("C2")
    End Sub
    Private Sub CS_buyevent(p As Image) Handles CS.buyevent
        ProductPB.Image = p
    End Sub
End Class
