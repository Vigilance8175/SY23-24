Imports System.ComponentModel
Imports System.Reflection.Emit
Imports System.Security.Cryptography

Public Class Form1
    Dim dollars As Integer
    Dim Earnings As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles spinButton.Click
        Timer1.Enabled = True
        If dollars >= 1 Then
            dollars -= 1
            Label1.Text = dollars.ToString("c2")
            ReelControl1.Spin()
            ReelControl2.Spin()
            ReelControl3.Spin()
            r1Label.Text = ReelControl1.itemValue
            r2Label.Text = ReelControl2.itemValue
            r3Label.Text = ReelControl3.itemValue
        Else
            Label2.Text = ""
        End If
    End Sub

    Private Sub doButton_Click(sender As Object, e As EventArgs) Handles doButton.Click
        dollars += 1
        Label1.Text = dollars.ToString("c2")
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        dollars = 0
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        r1Label.Text = ReelControl1.itemValue
        r2Label.Text = ReelControl2.itemValue
        r3Label.Text = ReelControl3.itemValue
        If ReelControl1.itemValue = ReelControl2.itemValue And
            ReelControl2.itemValue = ReelControl3.itemValue Then
            Label2.Text = "WIN"
        Else
            Label2.Text = "LOSE"
        End If
        If Label2.Text = "WIN" Then
            dollars += 3
            Label1.Text = dollars.ToString("c2")
        End If
        Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        If r1Label.Visible = False And r2Label.Visible = False And r3Label.Visible = False Then
            r1Label.Visible = True
            r2Label.Visible = True
            r3Label.Visible = True
        Else
            r1Label.Visible = False
            r2Label.Visible = False
            r3Label.Visible = False
        End If
    End Sub
End Class