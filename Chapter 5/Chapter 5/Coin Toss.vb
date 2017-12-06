Public Class Randon_Number_Generator

    Private Sub btnFlip_Click(sender As Object, e As EventArgs) Handles btnFlip.Click
        Dim intSideup As Integer
        Dim HeadsTotal As Integer = 0
        Dim TailsTotal As Integer = 0

        Dim rand As New Random

        intSideup = rand.Next(2)
        If intSideup = 0 Then
            pbHeads.Visible = True
            pbTails.Visible = False


        End If
    End Sub
End Class