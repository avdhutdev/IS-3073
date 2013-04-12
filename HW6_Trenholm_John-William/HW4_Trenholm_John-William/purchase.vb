'Project: Homework 7
'Programmer: John-William Trenholm
'Date: 4-7-2013
'Description: Calculations, objects, functions oh my.
Public Class Purchases
    'Class Variables
    Private StereoBoolean, LeatherBoolean, ComputerBoolean, PearlizedBoolean, CustomBoolean As Boolean
    Private setCarSalesPriceDeciaml, setTradeinAmountDecimal As Decimal
    Shared AccessoriesAndFinishDecimal, SubtotalDeciaml, SalesTaxDecimal, TotalDecimal, TradeDecimal, AmountDueDecimal As Decimal
    Private stereoDecimal, leatherDecimal, computerDecimal, finishDecimal As Decimal

    'Constaints
    Const PEARLIZEDFINISH As Decimal = 345.72D
    Const CUSTOMFINISH As Decimal = 599.99D
    Const STEREOSYSTEM As Decimal = 425.76D
    Const LEATHERINT As Decimal = 987.41D
    Const COMPUTERSYS As Decimal = 1741.23D
    Const TAX As Decimal = 0.08D

    'Summary form
    Private Shared NumberOfSalesInteger As Integer
    Private Shared TotalSalesDecimal, TotalTradeDecimal As Decimal

    '7 Constructor variables
    Public Sub New(ByVal StereoIn As Boolean, ByVal LeatherIn As Boolean, ByVal ComputerIn As Boolean, _
                   ByVal PearlizedIn As Boolean, ByVal CustomIn As Boolean, _
                   ByVal setCarSalesPriceIn As Decimal, ByVal setTradeinAmountIn As Decimal)

        'Constructor Methods
        setStereo() = StereoIn
        setLeather() = LeatherIn
        setComputer() = ComputerIn
        setPearlized() = PearlizedIn
        setCustom() = CustomIn
        setCarSalesPrice() = setCarSalesPriceIn
        setTradeinAmount() = setTradeinAmountIn
        Calc()
    End Sub

    'Constructor Method
    Property setStereo() As Boolean
        Get
            Return StereoBoolean
        End Get
        Set(ByVal value As Boolean)
            StereoBoolean = value
        End Set
    End Property
    'Constructor Method
    Property setLeather() As Boolean
        Get
            Return LeatherBoolean
        End Get
        Set(ByVal value As Boolean)
            LeatherBoolean = value
        End Set
    End Property
    'Constructor Method
    Property setComputer() As Boolean
        Get
            Return ComputerBoolean
        End Get
        Set(ByVal value As Boolean)
            ComputerBoolean = value
        End Set
    End Property
    'Constructor Method
    Property setPearlized() As Boolean
        Get
            Return PearlizedBoolean
        End Get
        Set(ByVal value As Boolean)
            PearlizedBoolean = value
        End Set
    End Property
    'Constructor Method
    Property setCustom() As Boolean
        Get
            Return CustomBoolean
        End Get
        Set(ByVal value As Boolean)
            CustomBoolean = value
        End Set
    End Property
    'Constructor Method
    Property setCarSalesPrice() As Decimal
        Get
            Return setCarSalesPriceDeciaml
        End Get
        Set(ByVal Value As Decimal)
            If Value >= 0 Then
                setCarSalesPriceDeciaml = Value
            End If
        End Set
    End Property
    'Constructor Method
    Property setTradeinAmount() As Decimal
        Get
            Return setTradeinAmountDecimal
        End Get
        Set(ByVal Value As Decimal)
            If Value >= 0 Then
                setTradeinAmountDecimal = Value
            End If
        End Set
    End Property
    'Accessories Method
    Property AccessoriesAndFinish() As Decimal
        Get
            Return AccessoriesAndFinishDecimal
        End Get
        Set(ByVal value As Decimal)
            AccessoriesAndFinishDecimal = value
        End Set
    End Property
    'Subtotal Method
    Property Subtotal() As Decimal
        Get
            Return SubtotalDeciaml
        End Get
        Set(ByVal value As Decimal)
            SubtotalDeciaml = value
        End Set
    End Property
    'Sales Tax Method
    Property SalesTax() As Decimal
        Get
            Return SalesTaxDecimal
        End Get
        Set(ByVal value As Decimal)
            SalesTaxDecimal = value * TAX
        End Set
    End Property
    'Trade Method
    Property TradeinAmount() As Decimal
        Get
            Return setTradeinAmountDecimal
        End Get
        Set(ByVal value As Decimal)
            setTradeinAmountDecimal = value
        End Set
    End Property
    'Total Method
    Property Total() As Decimal
        Get
            Return TotalDecimal
        End Get
        Set(ByVal value As Decimal)
            TotalDecimal = value
        End Set
    End Property
    'Amount Due Method
    Property AmtDue() As Decimal
        Get
            Return AmountDueDecimal
        End Get
        Set(ByVal value As Decimal)
            AmountDueDecimal = value
        End Set
    End Property
    Shared Property NumberOfSales() As Decimal
        Get
            Return NumberOfSalesInteger
        End Get
        Set(ByVal value As Decimal)
            NumberOfSalesInteger = +1
        End Set
    End Property
    Shared Property TotalTradeIns() As Decimal
        Get
            Return TotalTradeDecimal
        End Get
        Set(ByVal value As Decimal)
            TotalTradeDecimal = +1
        End Set
    End Property
    Shared Property TotalSales() As Decimal
        Get
            Return TotalDecimal
        End Get
        Set(ByVal value As Decimal)

        End Set
    End Property
    'Calc method
    Public Sub Calc()
        If setStereo Then
            stereoDecimal = STEREOSYSTEM
        Else
            stereoDecimal = 0D
        End If

        If setLeather Then
            leatherDecimal = LEATHERINT
        Else
            leatherDecimal = 0D
        End If

        If setComputer Then
            computerDecimal = COMPUTERSYS
        Else
            computerDecimal = 0D
        End If

        If setPearlized Then
            FinishDecimal = PEARLIZEDFINISH
        ElseIf setCustom Then
            FinishDecimal = CUSTOMFINISH
        Else
            FinishDecimal = 0D
        End If
        AccessoriesAndFinish() = stereoDecimal + leatherDecimal + computerDecimal + finishDecimal
        Subtotal() = setCarSalesPrice() + stereoDecimal + leatherDecimal + computerDecimal + finishDecimal
        SalesTax() = Subtotal()
        Total() = SalesTax + Subtotal()
        AmtDue() = (SalesTax() + Subtotal()) - TradeinAmount
        NumberOfSales() += 1
        TotalTradeIns() += setTradeinAmountDecimal
        TotalSales() += TotalDecimal + AmtDue()
    End Sub
End Class
