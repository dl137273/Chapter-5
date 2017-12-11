Public Class Menu

    Private Sub btnCoinFlip_Click(sender As Object, e As EventArgs) Handles btnCoinToss.Click
        Dim box = New Coin_Toss()
        box.Show()
    End Sub
 
    Private Sub btnRaceCarGame_Click(sender As Object, e As EventArgs) Handles btnRaceCarGame.Click
        Dim box = New Race_Car_Game
        box.Show()
    End Sub

    Private Sub btnRockPaperScissors_Click(sender As Object, e As EventArgs) Handles btnRockPaperScissors.Click
        Dim box = New Rock_paper_Scissors
        box.Show()
    End Sub
    Private Sub btnDistanceCalculator_Click(sender As Object, e As EventArgs) Handles btnDistanceCalculator.Click
        Dim box = New Distance_Calculator
        box.Show()
    End Sub

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim box = New Population
        box.Show()
    End Sub
End Class