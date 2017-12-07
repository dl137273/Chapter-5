Public Class Race_Car_Game
    Dim intParrot As Integer
    Dim intPelican As Integer
    Dim intPenguin As Integer

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        Dim intCount1, intCount2, intCount3 As Integer
        Dim rand As New Random

        Dim intScore As Integer = 1
        Dim intYouwin As Integer = 10

        For intCount1 = 60 To rand.Next(250) + 500
            picParrot.Left = intCount1
        Next
        For intCount2 = 60 To rand.Next(250) + 500
            picPelican.Left = intCount2
        Next
        For intCount3 = 60 To rand.Next(250) + 500
            picPengin.Left = intCount3
        Next
        If intCount1 > intCount2 And intCount3 Then
            intParrot += 1
        ElseIf intCount2 > intCount1 And intCount3 Then
            intPelican += 1
        ElseIf intCount3 > intCount1 And intCount2 Then
            intPenguin += 1
        End If
        lblParrot.Text = intParrot.ToString
        lblPelican.Text = intPelican.ToString
        lblPenguin.Text = intPenguin.ToString

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class