Public Class Distance_Calculator

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dbldistanceTraveled As Double
        Dim dblX As Double = 0
        Do While dblX < CDbl(txtX.Text)
            dblX = dblX = 1
            dbldistanceTraveled = CDbl(txtSpeed.Text) * dblX
            listResults.Items.Add(dblX.ToString + "         " + dbldistanceTraveled.ToString)
        Loop
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class