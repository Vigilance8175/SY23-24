Class MainWindow
    Private Sub DrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        Dim el As New Ellipse
        el.Width = WidthSlider.Value
        el.Height = HeightSlider.Value
        el.Fill = ColorRectangle1.Fill
        Dim p As Point = Mouse.GetPosition(DrawingCanvas)
        Canvas.SetLeft(el, p.X)
        Canvas.SetTop(el, p.Y)
        DrawingCanvas.Children.Add(el)
    End Sub

    Private Sub ColorRectangle2_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ColorRectangle2.MouseLeftButtonDown, ColorRectangle3.MouseLeftButtonDown, ColorRectangle4.MouseLeftButtonDown, ColorRectangle5.MouseLeftButtonDown
        ColorRectangle1.Fill = sender.fill
    End Sub
End Class
