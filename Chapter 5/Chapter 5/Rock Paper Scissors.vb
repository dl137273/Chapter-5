Public Class Rock_paper_Scissors
    Dim PlayerWins As Integer = 0
    Dim CPUWins As Integer = 0

    Private Sub btnShoot_Click(sender As Object, e As EventArgs) Handles btnShoot.Click
        Dim rand As New Random


        Dim Num As Integer
        Num = rand.Next(4)
        Const Rock = 1
        Const Paper = 2
        Const Scissors = 3

        If rbRock.Checked And Num = Rock Then
            lblResult.Text = "Computer chose Rock too. Tie!"
        ElseIf rbRock.Checked And Num = Paper Then
            lblResult.Text = "Computer chose Paper. You Lose!"
            CPUWins += 1
        ElseIf rbRock.Checked And Num = Scissors Then
            lblResult.Text = "Computer chose Scissors. You Win!"
            PlayerWins += 1
        End If
        If rbPaper.Checked And Num = Rock Then
            lblResult.Text = "Computer chose Rock. You Win!"
            PlayerWins += 1
        ElseIf rbPaper.Checked And Num = Paper Then
            lblResult.Text = "Computer chose Paper too. Tie!"
        ElseIf rbPaper.Checked And Num = Scissors Then
            lblResult.Text = "Computer chose Scissors. You Lose!"
            CPUWins += 1
        End If
        If rbScissors.Checked And Num = Rock Then
            lblResult.Text = "Computer chose Rock. You Lose!"
            CPUWins += 1
        ElseIf rbScissors.Checked And Num = Paper Then
            lblResult.Text = "Computer chose Paper. You Win!"
            PlayerWins += 1
        ElseIf rbScissors.Checked And Num = Scissors Then
            lblResult.Text = "Computer chose Scissors. Tie!"
        End If
        lblCPUWins.Text = CPUWins.ToString
        lblPlayerWins.Text = PlayerWins.ToString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class