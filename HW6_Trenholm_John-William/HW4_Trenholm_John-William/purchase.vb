'Project: Homework 7
'Programmer: John-William Trenholm
'Date: 4-7-2013
'Description: Calculations, menus, functions oh my.
Public Class Purchases
    'Class Variables
    Private StereoBoolean, LeatherBoolean, ComputerBoolean, PearlizedBoolean, CustomBoolean As Boolean
    Private CarSalesPriceDeciaml, TradeinAmountDecimal As Decimal
    Private AccessoriesAndFinishDecimal, SubtotalDeciaml, SalesTaxDecimal, TotalDecimal, TradeDecimal, AmountDueDecimal As Decimal

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
                   ByVal CarSalesPriceIn As Decimal, ByVal TradeinAmountIn As Decimal)

        'Constructor Methods
        StereoMethod() = StereoIn
        LeatherMethod() = LeatherIn
        ComputerMethod() = ComputerIn
        PearlizedMethod() = PearlizedIn
        customMethod() = CustomIn
        CarSalesPrice() = CarSalesPriceIn
        TradeinAmount() = TradeinAmountIn

    End Sub
    'Constructor Method
    Property StereoMethod() As Boolean
        Get
            Return StereoBoolean
        End Get
        Set(ByVal value As Boolean)
            StereoBoolean = value
        End Set
    End Property
    'Constructor Method
    Property LeatherMethod() As Boolean
        Get
            Return LeatherBoolean
        End Get
        Set(ByVal value As Boolean)
            LeatherBoolean = value
        End Set
    End Property
    'Constructor Method
    Property ComputerMethod() As Boolean
        Get
            Return ComputerBoolean
        End Get
        Set(ByVal value As Boolean)
            ComputerBoolean = value
        End Set
    End Property
    'Constructor Method
    Property PearlizedMethod() As Boolean
        Get
            Return PearlizedBoolean
        End Get
        Set(ByVal value As Boolean)
            PearlizedBoolean = value
        End Set
    End Property
    'Constructor Method
    Property customMethod() As Boolean
        Get
            Return CustomBoolean
        End Get
        Set(ByVal value As Boolean)
            CustomBoolean = value
        End Set
    End Property
    'Constructor Method
    Property CarSalesPrice() As Decimal
        Get
            Return CarSalesPriceDeciaml
        End Get
        Set(ByVal Value As Decimal)
            If Value >= 0 Then
                CarSalesPriceDeciaml = Value
            End If
        End Set
    End Property
    'Constructor Method
    Property TradeinAmount() As Decimal
        Get
            Return TradeinAmountDecimal
        End Get
        Set(ByVal Value As Decimal)
            If Value >= 0 Then
                TradeinAmountDecimal = Value
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
            SalesTaxDecimal = value
        End Set
    End Property
    'Trade Method
    Property Trade() As Decimal
        Get
            Return TradeinAmountDecimal
        End Get
        Set(ByVal value As Decimal)
            TradeinAmountDecimal = value
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
    'Summary Method
    Shared ReadOnly Property NumberOfSales() As Integer
        Get
            Return NumberOfSalesInteger
        End Get
    End Property
    'Summary Method
    Shared ReadOnly Property TotalTradeIns() As Decimal
        Get
            Return TotalTradeDecimal
        End Get
    End Property
    'Summary Method
    Shared ReadOnly Property TotalSales() As Decimal
        Get
            Return TotalSalesDecimal
        End Get
    End Property
    'Calls calc methods
    Public Sub Calc()
        CalcAccessoriesFinish(StereoMethod(), LeatherMethod(), PearlizedMethod(), customMethod(), ComputerMethod())

        CalcSubTotal(CarSalesPrice(), AccessoriesAndFinish())

        CalcTax(Subtotal())

        CalcTotal(Subtotal(), SalesTax())

        CalcAmountDue(Total(), TradeinAmount())

        CalcTrade(Trade())

        Summary()

    End Sub
    'Calculation Method
    Protected Sub CalcAccessoriesFinish(ByVal Stereo As Boolean, ByVal Leather As Boolean, _
                   ByVal Pearlized As Boolean, ByVal Custom As Boolean, ByVal Computer As Boolean)

        Dim stereoDecimal, leatherDecimal, computerDecimal, FinishDecimal As Decimal

        'If statements to determine values of accessories and finish
        If Stereo Then
            stereoDecimal = STEREOSYSTEM
        Else
            stereoDecimal = 0D
        End If

        If Leather Then
            leatherDecimal = LEATHERINT
        Else
            leatherDecimal = 0D
        End If

        If Computer Then
            computerDecimal = COMPUTERSYS
        Else
            computerDecimal = 0D
        End If

        If Pearlized Then
            FinishDecimal = PEARLIZEDFINISH
        ElseIf Custom Then
            FinishDecimal = CUSTOMFINISH
        Else
            FinishDecimal = 0D
        End If

        'Sums all to Accessories and finish
        AccessoriesAndFinish() = stereoDecimal + leatherDecimal + computerDecimal + FinishDecimal

    End Sub
    'Calculation Method Adds sales price and accessories/finish
    Protected Sub CalcSubTotal(ByVal SalesPriceDecimal As Decimal, ByVal AccessoriesFinish As Decimal)
        Subtotal() = SalesPriceDecimal + AccessoriesFinish
    End Sub
    'Calculation Method Calculates TAX
    Protected Sub CalcTax(ByVal Subtotal As Decimal)
        SalesTax() = Subtotal * TAX
    End Sub
    'Calculation Method Calculates Total
    Protected Sub CalcTotal(ByVal Subtotal As Decimal, ByVal TaxDecimal As Decimal)
        Total() = Subtotal + TaxDecimal
    End Sub
    'Calculation Method Sums Trade
    Protected Sub CalcTrade(ByVal TotalTrade As Decimal)
        Trade() = TotalTrade
    End Sub
    'Calculation Method Amount Due
    Protected Sub CalcAmountDue(ByVal TotalDecimal As Decimal, ByVal TradeInDecimal As Decimal)
        AmtDue() = TotalDecimal - TradeInDecimal
    End Sub
    'Summary Method
    Protected Sub Summary()
        'Summary form values
        NumberOfSalesInteger += 1
        TotalTradeDecimal += TradeinAmountDecimal
        TotalSalesDecimal += TotalDecimal
    End Sub
End Class
