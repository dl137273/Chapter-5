Public Class Coin_Toss

    Dim totalHeads As Integer
    Dim totalTails As Integer
    Private Sub btnFlipCoin_Click(sender As Object, e As EventArgs) Handles btnFlipCoin.Click
        Dim intCoinFlip As Integer
        Dim rand As New Random

        intCoinFlip = rand.Next(2)

        If intCoinFlip = 0 Then
            picHeads.Visible = True
            picTails.Visible = False
            totalHeads += 1
        Else
            picTails.Visible = True
            picHeads.Visible = False
            totalTails += 1
        End If
        lblHeads.Text = totalHeads
        lblTails.Text = totalTails
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class