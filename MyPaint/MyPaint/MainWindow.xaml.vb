Imports Microsoft.Win32
Imports System.IO

Class MainWindow
    Dim grad1 As Color
    Dim grad2 As Color
    Private Sub DrawingCanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingCanvas.MouseMove
        If ShapeLabel.Content = "Ellipse" Then
            Dim el As New Ellipse
            el.Width = WidthSlider.Value
            el.Height = HeightSlider.Value
            el.Fill = ColorRectangle1.Fill
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(el)
            End If
        End If
        If ShapeLabel.Content = "Rectangle" Then
            Dim el As New Rectangle
            el.Width = WidthSlider.Value
            el.Height = HeightSlider.Value
            el.Fill = ColorRectangle1.Fill
            Dim p As Point = Mouse.GetPosition(DrawingCanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                DrawingCanvas.Children.Add(el)
            End If
        End If
    End Sub
    Private Sub ColorRectangle2_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles ColorRectangle2.MouseLeftButtonDown, ColorRectangle3.MouseLeftButtonDown, ColorRectangle4.MouseLeftButtonDown, ColorRectangle5.MouseLeftButtonDown
        ColorRectangle1.Fill = sender.fill
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveRange(1, DrawingCanvas.Children.Count)
    End Sub
    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        DrawingCanvas.Children.RemoveAt(DrawingCanvas.Children.Count - 1)
    End Sub
    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        ShapeLabel.Content = sender.content
    End Sub
    Private Sub EllipseButton_Click(sender As Object, e As RoutedEventArgs) Handles EllipseButton.Click
        ShapeLabel.Content = sender.content
    End Sub
    Public Sub ExportToPng(ByVal surface As Canvas)
        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)

        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        surface.LayoutTransform = transform

        Canvas.SetLeft(DrawingCanvas, 200)

        Canvas.SetTop(DrawingCanvas, 10)

    End Sub
    Private Sub SaveButton_Click(sender As Object, e As RoutedEventArgs) Handles SaveButton.Click
        ExportToPng(DrawingCanvas)
    End Sub
    Private Sub Color1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Color1.MouseDown
        grad1 = Color.FromRgb(R.Value, G.Value, B.Value)
        sender.fill = New SolidColorBrush(grad1)
    End Sub
    Private Sub Color2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles Color2.MouseDown
        grad2 = Color.FromRgb(R.Value, G.Value, B.Value)
        sender.fill = New SolidColorBrush(grad2)
    End Sub
    Private Sub AngleSlider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles AngleSlider.ValueChanged
        ColorRectangle1.Fill = New LinearGradientBrush(grad1, grad2, AngleSlider.Value)
    End Sub
End Class
