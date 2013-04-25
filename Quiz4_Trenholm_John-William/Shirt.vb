'Class:        Chapter 12 Case Studies: Very Very Boards
'Programmer:   Theresa Berry
'Date:		   August 2008
'Description:  Handles the shirt calculations
'Folder:	   EX12Boards

Option Strict On

Public Class Shirt

    Const SML_Decimal As Decimal = 10D
    Const XL_Decimal As Decimal = 11D
    Const XXL_Decimal As Decimal = 12D
    Const MONOGRAM_Decimal As Decimal = 2D
    Const POCKET_Decimal As Decimal = 1D

    Dim monogramBoolean, pocketBoolean As Boolean
    Dim quatnityInt As Integer
    Dim pocketCostDecimal, monogramCostDecimal, tShirtSizeCostDec, TotalDecimal, totalSalesDecimal As Decimal
    Dim tShirtSizeString As String


    Property monogram() As Boolean
        Get
            Return monogramBoolean
        End Get
        Set(ByVal value As Boolean)
            monogramBoolean = value
        End Set
    End Property
    'Constructor Method
    Property pocket() As Boolean
        Get
            Return pocketBoolean
        End Get
        Set(ByVal value As Boolean)
            pocketBoolean = value
        End Set
    End Property
    'Constructor Method
    Property quantity() As Integer
        Get
            Return quatnityInt
        End Get
        Set(ByVal value As Integer)
            quatnityInt = value
        End Set
    End Property
    'Constructor Method
    Property tShirtSize() As String
        Get
            Return tShirtSizeString
        End Get
        Set(ByVal value As String)
            tShirtSizeString = value
        End Set
    End Property

    Property Total() As Decimal
        Get
            Return TotalDecimal
        End Get
        Set(ByVal value As Decimal)
            TotalDecimal = value
        End Set
    End Property
    Property totalSales() As Decimal
        Get
            Return totalSalesDecimal
        End Get
        Set(ByVal value As Decimal)
            TotalSalesDecimal = value
        End Set
    End Property

    Public Sub New(ByVal monogramIn As Boolean, ByVal pocketIn As Boolean, _
           ByVal quantityIn As Integer, ByVal tShirtSizeIn As String)
        'Constructor Methods
        monogram() = monogramIn
        pocket() = pocketIn
        quantity() = quantityIn
        tShirtSize() = tShirtSizeIn
        Calc()
    End Sub

    Private Sub Calc()
        If monogram Then
            monogramCostDecimal = MONOGRAM_Decimal
        Else
            monogramCostDecimal = 0D
        End If

        If pocket Then
            pocketCostDecimal = POCKET_Decimal
        Else
            pocketCostDecimal = 0D
        End If
        If tShirtSize = "Small" Then
            tShirtSizeCostDec = SML_Decimal
        ElseIf tShirtSize = "Medium" Then
            tShirtSizeCostDec = XL_Decimal
        ElseIf tShirtSize = "Extra Large" Then
            tShirtSizeCostDec = XXL_Decimal
        End If

        Total() = (tShirtSizeCostDec + pocketCostDecimal + monogramCostDecimal) * quantity()
        totalSales = +Total()

    End Sub
End Class
