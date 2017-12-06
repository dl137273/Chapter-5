Public Class Menu

    Private Sub btnCoinFlip_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
        Dim box = New Coin_Toss()
        box.Show()
    End Sub
    Private Sub btnTestScores_Click(sender As Object, e As EventArgs)
        Dim box = New Test_Scores
        box.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim box = New Rock_paper_Scissors
        box.Show()
    End Sub
End Class