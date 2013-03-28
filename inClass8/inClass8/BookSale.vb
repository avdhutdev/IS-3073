'Class Name: BookSale
'Programmer: John-William Trenholm
'Date: March 28 2013
'Description: Handle book sale information.
'Folder: Ch12SBS


Public Class BookSale
    Private TitleString As String
    Private QuantityInteger As Integer
    Private PriceDecimal, ExtendedPriceDecimal As Decimal

    Property Title() As String
        Get
            Return TitleString
        End Get
        Set(ByVal value As String)
            TitleString = value
        End Set
    End Property
    Property Quantity() As Integer
        Get
            Return QuantityInteger
        End Get
        Set(ByVal value As Integer)
            If value >= 0 Then
                QuantityInteger = value
            End If
        End Set
    End Property

    Property Price() As Decimal
        Get
            Return PriceDecimal
        End Get
        Set(ByVal value As Decimal)
            If value >= 0 Then
                PriceDecimal = value
            End If
        End Set
    End Property
    Property ExtendedPrice() As Decimal
        Get
            Return ExtendedPriceDecimal
        End Get
        Set(ByVal value As Decimal)
            If value >= 0 Then
                ExtendedPriceDecimal = value
            End If
        End Set
    End Property

    Public Sub New(ByVal TitleIn As String, ByVal QuantityIn As Integer, _
        ByVal PriceIn As Decimal)
        ' Assign the property values.
        Title = TitleIn
        Quantity = QuantityIn
        Price = PriceIn
        CalculateExtendedPrice()
    End Sub
    Protected Sub CalculateExtendedPrice()
        ExtendedPriceDecimal = QuantityInteger * PriceDecimal
    End Sub



End Class
