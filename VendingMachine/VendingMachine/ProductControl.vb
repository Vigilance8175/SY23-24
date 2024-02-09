Public Class ProductControl
    Public Property ProductID As String
    Public Property ProductPrice As Decimal
    Public Property ProductPicture As Image
    Private Sub ProductControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IDLabel.Text = ProductID
        PriceLabel.Text = ProductPrice.ToString("C2")
        PictureBox1.Image = ProductPicture
    End Sub
End Class
