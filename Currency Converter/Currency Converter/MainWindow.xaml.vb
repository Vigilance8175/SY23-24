Class MainWindow
    Private Sub EuroB_Click(sender As Object, e As RoutedEventArgs) Handles EuroB.Click
        Dim f As Integer
        Integer.TryParse(FromTB.Text, f)
        ToTB.Text = f * 0.93
        EuroPB.Visibility = Visibility.Visible
        VietPB.Visibility = Visibility.Hidden
        JapPB.Visibility = Visibility.Hidden
        BrazPB.Visibility = Visibility.Hidden
        PoundPB.Visibility = Visibility.Hidden
        MexPB.Visibility = Visibility.Hidden
    End Sub
    Private Sub VietB_Click(sender As Object, e As RoutedEventArgs) Handles VietB.Click
        Dim f As Integer
        Integer.TryParse(FromTB.Text, f)
        ToTB.Text = f * 25445.0
        EuroPB.Visibility = Visibility.Hidden
        VietPB.Visibility = Visibility.Visible
        JapPB.Visibility = Visibility.Hidden
        BrazPB.Visibility = Visibility.Hidden
        PoundPB.Visibility = Visibility.Hidden
        MexPB.Visibility = Visibility.Hidden
    End Sub
    Private Sub JapB_Click(sender As Object, e As RoutedEventArgs) Handles JapB.Click
        Dim f As Integer
        Integer.TryParse(FromTB.Text, f)
        ToTB.Text = f * 155.34
        EuroPB.Visibility = Visibility.Hidden
        VietPB.Visibility = Visibility.Hidden
        JapPB.Visibility = Visibility.Visible
        BrazPB.Visibility = Visibility.Hidden
        PoundPB.Visibility = Visibility.Hidden
        MexPB.Visibility = Visibility.Hidden
    End Sub
    Private Sub PoundB_Click(sender As Object, e As RoutedEventArgs) Handles PoundB.Click
        Dim f As Integer
        Integer.TryParse(FromTB.Text, f)
        ToTB.Text = f * 0.8
        EuroPB.Visibility = Visibility.Hidden
        VietPB.Visibility = Visibility.Hidden
        JapPB.Visibility = Visibility.Hidden
        BrazPB.Visibility = Visibility.Hidden
        PoundPB.Visibility = Visibility.Visible
        MexPB.Visibility = Visibility.Hidden
    End Sub
    Private Sub MexB_Click(sender As Object, e As RoutedEventArgs) Handles MexB.Click
        Dim f As Integer
        Integer.TryParse(FromTB.Text, f)
        ToTB.Text = f * 16.95
        EuroPB.Visibility = Visibility.Hidden
        VietPB.Visibility = Visibility.Hidden
        JapPB.Visibility = Visibility.Hidden
        BrazPB.Visibility = Visibility.Hidden
        PoundPB.Visibility = Visibility.Hidden
        MexPB.Visibility = Visibility.Visible
    End Sub
    Private Sub BrazB_Click(sender As Object, e As RoutedEventArgs) Handles BrazB.Click
        Dim f As Integer
        Integer.TryParse(FromTB.Text, f)
        ToTB.Text = f * 5.3
        EuroPB.Visibility = Visibility.Hidden
        VietPB.Visibility = Visibility.Hidden
        JapPB.Visibility = Visibility.Hidden
        BrazPB.Visibility = Visibility.Visible
        PoundPB.Visibility = Visibility.Hidden
        MexPB.Visibility = Visibility.Hidden
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        FromTB.Text = ""
        ToTB.Text = ""
    End Sub
End Class
