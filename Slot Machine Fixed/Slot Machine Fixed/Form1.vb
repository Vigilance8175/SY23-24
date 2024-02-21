Imports System.Reflection.Emit

Public Class Form1
    Dim nickels As Decimal
    Dim dimes As Decimal
    Dim quarters As Decimal
    Dim dollars As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles spinb.Click
        ReelControl1.Spin()
        ReelControl2.Spin()
        ReelControl3.Spin()
        r1Label.Text = ReelControl1.itemValue
        r2Label.Text = ReelControl2.itemValue
        r3Label.Text = ReelControl3.itemValue
    End Sub
End Class