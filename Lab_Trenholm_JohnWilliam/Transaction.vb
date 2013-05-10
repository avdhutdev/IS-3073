Public Class Transaction

    'Class Variables
    Private transactionAmountDec, accountBalanceDec As Decimal
    Private transactionType As Boolean

    'Summary form
    Private Shared numberOfDepositsInt, numberOfWithdrawlsInt, numberOfOverdraftsInt As Integer

    'Constructor Methods
    Public Sub New(ByVal transactionAmount As Decimal, ByVal accountBalance As Decimal, ByVal transactionType As Boolean)


        settransactionAmount() = transactionAmount
        setaccountBalance() = accountBalance
        settransactionType() = transactionType
        Calc()
    End Sub

    'Transaction Property
    Property settransactionAmount() As Decimal
        Get
            Return transactionAmountDec
        End Get
        Set(ByVal value As Decimal)
            transactionAmountDec = value
        End Set
    End Property
    'Account Balance Property
    Property setaccountBalance() As Decimal
        Get
            Return accountBalanceDec
        End Get
        Set(ByVal value As Decimal)
            accountBalanceDec = value
        End Set
    End Property
    'TransactionType Property
    Property settransactionType() As Boolean
        Get
            Return transactionType
        End Get
        Set(ByVal value As Boolean)
            transactionType = value
        End Set
    End Property

    Public Sub Calc()
        If settransactionType > setaccountBalance Then
            MessageBox.Show("Insufficient Balance, an overdraft fee of $25 will be charged.", "Insufficient Balance!", _
                MessageBoxButtons.OK, MessageBoxIcon.Information)

            numberOfOverdrafts() = numberOfOverdrafts() + 1
            setaccountBalance() = setaccountBalance() - 25
        End If

        If settransactionType() Then
            setaccountBalance() = setaccountBalance() - settransactionAmount()
            numberOfWithdrawls() = numberOfWithdrawls() + 1


        Else
            setaccountBalance() = setaccountBalance() + settransactionAmount()
            numberOfDeposits() = numberOfDeposits() + 1

        End If



    End Sub

    'Summary form totals
    Shared Property numberOfDeposits() As Decimal
        Get
            Return numberOfDepositsInt
        End Get
        Set(ByVal value As Decimal)
            numberOfDepositsInt = value
        End Set
    End Property

    Shared Property numberOfWithdrawls() As Decimal
        Get
            Return numberOfWithdrawlsInt
        End Get
        Set(ByVal value As Decimal)
            numberOfWithdrawlsInt = value
        End Set
    End Property

    Shared Property numberOfOverdrafts() As Decimal
        Get
            Return numberOfOverdraftsInt
        End Get
        Set(ByVal value As Decimal)
            numberOfOverdraftsInt = value
        End Set
    End Property
End Class
