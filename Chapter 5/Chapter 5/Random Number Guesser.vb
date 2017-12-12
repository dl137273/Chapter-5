Public Class Random_Number_Generator
    Dim Counter As Integer
    Dim CG As Integer
    Dim intWins As Integer = 0

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Dim Number As New Random
        CG = Number.Next(100) + 1
        Counter = 0
        txtNumber.Text = (" ")
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim UG As Integer
        UG = CInt(txtNumber.Text)
        Counter = Counter + 1
        Try
            If UG = CG Then
                MessageBox.Show("You guessed the right number!")
                intWins = 1 + intWins
            ElseIf UG < CG Then
                MessageBox.Show("Your guess is too low")
            ElseIf UG > CG Then
                MessageBox.Show("Your guess is too high")
            End If
            lblWins.Text = intWins.ToString("n")
        Catch ex As Exception
            MessageBox.Show("Please enter a number")
        End Try
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Dim R As DialogResult
        R = MessageBox.Show("Are you sure you want to do this? This game is the best!")
        If R = Windows.Forms.DialogResult.No Then
            btnNewGame.PerformClick()
        ElseIf R = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class