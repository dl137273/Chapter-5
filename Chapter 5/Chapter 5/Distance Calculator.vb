Public Class Distance_Calculator
    Dim intSpeed As Integer
    Dim strSpeed As String

    Dim intTime As Integer
    Dim strTime As String

    Dim intTotal
    Dim strDistance

    Dim strInput As String
    Dim intCount As Integer = 1
    Sub mathCalc()
        intTotal = intSpeed * intCount
        strDistance = intCount.ToString() & "           " & intTotal.ToString()
        listResults.Items.Add(strDistance)
        intCount += 1
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        strInput = InputBox("What is the speed in miles per hour?", "Enter Speed")
        If Decimal.TryParse(strInput, intSpeed) Then
            strInput = InputBox("What is the amount of time in hours?" & intCount.ToString(), "Enter Time")
            If Decimal.TryParse(strInput, intTime) Then
                strSpeed = "Vehicle Speed: " & intSpeed.ToString() & " MPH"
                strTime = "Tme Traveled: " & intTime.ToString() & " hours"

                listResults.Items.Insert(0, strSpeed)
                listResults.Items.Insert(1, strTime)

                listResults.Items.Insert(2, "Hours" & "      " & "Distance Traveled")
                listResults.Items.Insert(3, "________________________")

                Do Until intCount > intTime
                    mathCalc()
                Loop
                listResults.Items.Add("Total Distance: " & intSpeed * intTime)
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
