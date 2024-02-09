Public Class CoinSlot
    Public Event coinreturnevent(d As Integer, q As Integer, di As Integer, n As Integer)
    Public Property Quarters As Integer
    Public Property Nickels As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Public ReadOnly Property Total As Decimal
        Get
            Return Dollars + Quarters * 0.25 + Dimes * 0.1 + Nickels * 0.05
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
End Class
