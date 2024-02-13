Public Class CoinSlot
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Event buyevent(p As Image)
    Public Property Quarters As Integer
    Public Property Nickels As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Dim _total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _total = Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickels * 0.05
            Return _total
        End Get
    End Property
    Sub CoinReturn()
        RaiseEvent coinreturnevent(Dollars, Quarters, Dimes, Nickels)
        Quarters = 0
        Dollars = 0
        Dimes = 0
        Nickels = 0
    End Sub
    Sub InsertQuarter()
        Quarters = Quarters + 1
    End Sub
    Sub InsertNickel()
        Nickels = Nickels + 1
    End Sub
    Sub InsertDime()
        Dimes = Dimes + 1
    End Sub
    Sub InsertDollar()
        Dollars = Dollars + 1
    End Sub
    Sub Buy(p As ProductControl)
        If p.ProductCount > 0 And p.ProductPrice <= _total Then
            p.Buy()
            _total = _total - p.ProductPrice
            Quarters = 0
            Dollars = 0
            Dimes = 0
            Nickels = _total / 0.05
            RaiseEvent buyevent(p.ProductPicture)
        End If
    End Sub
End Class
