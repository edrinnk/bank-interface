Public Class Form1
    Dim pATMTransaction As ATMTransaction
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ATMDisplay.Text = ATMDisplay.Text + "1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ATMDisplay.Text = ATMDisplay.Text + "2"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ATMDisplay.Text = ATMDisplay.Text + "3"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ATMDisplay.Text = ATMDisplay.Text + "4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        ATMDisplay.Text = ATMDisplay.Text + "5"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        ATMDisplay.Text = ATMDisplay.Text + "6"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        ATMDisplay.Text = ATMDisplay.Text + "7"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ATMDisplay.Text = ATMDisplay.Text + "8"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ATMDisplay.Text = ATMDisplay.Text + "9"
    End Sub

    Private Sub Button0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button0.Click
        ATMDisplay.Text = ATMDisplay.Text + "0"
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pATMTransaction = New ATMTransaction
    End Sub
    Sub PrivateVisual()
        Select Case pATMTransaction.GetATMStage
            Case 1
                WithdrawButton.Visible = False
                ChangePINButton.Visible = False
                CancelButton.Visible = True
                EnterButton.Visible = True
                ATMMessage.Text = "Please enter 4 digit PIN."
            Case 2
                WithdrawButton.Visible = True
                ChangePINButton.Visible = True
                CancelButton.Visible = False
                EnterButton.Visible = False
                ATMMessage.Text = "Choose ATM option."
            Case 3
                WithdrawButton.Visible = False
                ChangePINButton.Visible = False
                CancelButton.Visible = True
                EnterButton.Visible = True
                ATMMessage.Text = "Withdrawal selected. Your balance is " & pATMTransaction.GetClosingBalance
            Case 4
                WithdrawButton.Visible = False
                ChangePINButton.Visible = False
                CancelButton.Visible = True
                EnterButton.Visible = True
                ATMMessage.Text = "Change PIN selected. Please enter new PIN."
        End Select
    End Sub

    Private Sub EnterButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterButton.Click
        Select Case pATMTransaction.GetATMStage
            Case 1
                ATMMessage.Text = pATMTransaction.CheckPIN(ATMDisplay.Text)
                If ATMMessage.Text = "" Then

                End If
            Case 2

            Case 3

            Case 4

        End Select
    End Sub
End Class
