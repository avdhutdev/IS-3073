' Project: HomeWork1
' Programmer: John-William Trenholm
' Date: 2-10-2013
' Description: Future value of an investment with compound interest

Public Class Form1
    'Quits the program
    Private Sub exitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub
    'Clears the boxes.
    Private Sub clearBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearBox.Click
        outputBox.Clear()
        NameBox1.Clear()
        interestBox.Clear()
        principalBox.Clear()
        If (year5Interest.Checked) Then
            year5Interest.Checked = False
        ElseIf (year10Interest.Checked) Then
            year10Interest.Checked = False
        ElseIf (year15Interest.Checked) Then
            year15Interest.Checked = False
        End If
    End Sub
    'Calculates the interest & throws errors if the user did not submit the correct information.
    Private Sub calculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateButton.Click
        'Define some variables.
        Dim interestDecimal, totalInvestment As Decimal
        Dim principalInt, years As Integer
        Dim tempInterest As String

        'Figure out what chceckbox is selected, if nothing is selected inform the user.
        If (year5Interest.Checked) Then
            years = 5
        ElseIf (year10Interest.Checked) Then
            years = 10
        ElseIf (year15Interest.Checked) Then
            years = 15
        End If
        Try
            'figure out if there's a % in the interest box
            If interestBox.Text.Contains("%") Then
                tempInterest = interestBox.Text
                tempInterest = tempInterest.Replace("%", "")
                If Decimal.TryParse(tempInterest.Trim, interestDecimal) Then
                    'good number, convert percent to decimal
                    interestDecimal = tempInterest / 100
                End If
            Else
                interestDecimal = Decimal.Parse(interestBox.Text)
            End If
            'parse text from text boxes into variables
            Try
                principalInt = Integer.Parse(principalBox.Text)
            Catch ex As Exception
                MessageBox.Show("Error in principal input", "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
            'calulate total
            totalInvestment = principalInt * (1 + (interestDecimal / 12)) ^ (years * 12)
            'Make sure the user selected a value for the year.
            If (years = 0) Then
                outputBox.Text = "Please select a length of time"
            Else
                'Format the output
                outputBox.Text = "if " & NameBox1.Text & " Invested " & principalBox.Text & " @ " & interestDecimal.ToString & " for " & years & "Years. The total would be: " & totalInvestment.ToString("c")
            End If
        Catch ex As Exception
            MessageBox.Show("Error in interest input", "input error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class
