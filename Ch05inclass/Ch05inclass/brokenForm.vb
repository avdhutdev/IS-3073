Public Class brokenForm

    Private minorFemale, female, minorMale, male As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub goButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles goButton.Click

        If (maleradio.Checked) Then
            If ageBox.Text >= 21 Then
                male += 1
            Else
                minorMale += 1
            End If
        Else
            If ageBox.Text >= 21 Then
                female += 1
            Else
                minorFemale += 1
            End If
        End If
        maleBox.Text = male
        maleMinor.Text = minorMale
        femaleBox.Text = female
        femaleMinor.Text = minorFemale
        ageBox.Text = ""
        maleradio.Checked = False
    End Sub

End Class
