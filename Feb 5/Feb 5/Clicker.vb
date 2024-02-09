Public Class Clicker
    Public Property Count As Integer
    Public Property Increment As Integer = 1
    Public Sub click()
        Count = Count + Increment
    End Sub
    Public Sub reset()
        Count = 0
    End Sub
End Class
