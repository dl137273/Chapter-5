Public Class Population

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intCount As Integer
        Dim dbltotal As Double

        lstOutput.Items.Add("Day Approximate Population")
        lstOutput.Items.Add("-----------------------------------")
        dbltotal = 2
        intCount = 1

        lstOutput.Items.Add(intCount.ToString + " " + dbltotal.ToString)

        For intCount = intCount + 1 To txtNumberofDays.Text
            dbltotal = (CDbl(txtDailyIncrease.Text * dbltotal) / 100) + dbltotal
            lstOutput.Items.Add(intCount.ToString + " " + dbltotal.ToString)
        Next
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDailyIncrease.Text = " "
        txtNumberofDays.Text = " "
        txtOrganisms.Text = " "
    End Sub
End Class