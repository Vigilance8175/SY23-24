Class MainWindow
    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        NameTB.Text = ""
        NumTB.Text = ""
        DateTB.Text = ""
        CodeTB.Text = ""
    End Sub
    Private Sub NumTB_TextChanged(sender As Object, e As TextChangedEventArgs) Handles NumTB.TextChanged, NameTB.TextChanged, EmailTB.TextChanged, PhoneTB.TextChanged, DateTB.TextChanged, CodeTB.TextChanged, ZipTB.TextChanged
        If Not PayB Is Nothing Then
            If NumTB.Text Like "#### #### #### ####" And NameTB.Text Like "*" And EmailTB.Text Like "*@*.*" And PhoneTB.Text Like "### ### ####" And DateTB.Text Like "##/##" And CodeTB.Text Like "###" And ZipTB.Text Like "#####" Then
                PayB.IsEnabled = True
            Else
                PayB.IsEnabled = False
            End If
        End If
    End Sub
End Class
