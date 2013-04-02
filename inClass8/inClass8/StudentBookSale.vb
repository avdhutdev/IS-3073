Public Class StudentBookSale
    Inherits BookSale
    Private Shared DiscountTotalDecimal As Decimal
    Const DISCOUNT_RATE_Decimal As Decimal = 0.15D

    Sub New(ByVal TitleIn As String, ByVal QuantityIn As Integer, ByVal PriceIn As Decimal)
        ' Call the base class constructor.
        MyBase.New(TitleIn, QuantityIn, PriceIn)
    End Sub
    Shared ReadOnly Property DiscountTotal() As Decimal
        Get
            Return DiscountTotalDecimal
        End Get
    End Property
    Protected Overrides Sub CalculateExtendedPrice()
        ' Calculate the discount, extended price, and add to the total.
        Dim DiscountDecimal As Decimal
        DiscountDecimal = Quantity * Price * DISCOUNT_RATE_Decimal
        ExtendedPrice = Quantity * Price - DiscountDecimal
        DiscountTotalDecimal += DiscountDecimal
    End Sub
End Class
