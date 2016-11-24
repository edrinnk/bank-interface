Public Class ATMTransaction
    Dim OpeningBalance As Decimal
    Dim Closingbalance As Decimal
    Dim PIN As String
    Dim ATMStage As Integer
    Dim TransactiondDate As Date
    Dim TransactionTime As Date
    Public Sub New()
        OpeningBalance = 1000.0
        Closingbalance = 1000.0
        PIN = "9999"
        ATMStage = 1
    End Sub
    '
    '
    Function GetATMStage() As Integer
        Return ATMStage
    End Function

    Sub SetATMStage(ByVal NewStage As Integer)

    End Sub

    Function CheckPIN(ByVal EnteredPIN As String)
        If EnteredPIN = PIN Then
            Return "PIN accepted."
        Else
            Return "Incorrect PIN please try again."
        End If
    End Function

    Sub MakeWithdrawal(ByVal WithdrawalAmount As Integer)
        Closingbalance = OpeningBalance - WithdrawalAmount
    End Sub

    Function GetOpeningBalance() As Decimal
        Return OpeningBalance
    End Function

    Function GetClosingBalance() As Decimal
        Return Closingbalance
    End Function

    Sub SetPIN(ByVal NewPIN As String)
        PIN = NewPIN
    End Sub
End Class
