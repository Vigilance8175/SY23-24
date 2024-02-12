Public Class ProductControl
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductPicture As Image
    Public Property ProductCount As Integer
    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDLabel.Text = ProductID
        PriceLabel.Text = ProductPrice.ToString("C2")
        PictureBox1.Image = ProductPicture
    End Sub
    Sub Buy()
        If ProductCount > 0 Then
            ProductCount = ProductCount - 1
        End If
        If ProductCount = 0 Then
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
