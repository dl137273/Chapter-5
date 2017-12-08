<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCoinToss = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRockPaperScissors = New System.Windows.Forms.Button()
        Me.btnRaceCarGame = New System.Windows.Forms.Button()
        Me.btnSumOfNumbers = New System.Windows.Forms.Button()
        Me.btnDistanceCalculator = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCoinToss
        '
        Me.btnCoinToss.Location = New System.Drawing.Point(160, 125)
        Me.btnCoinToss.Name = "btnCoinToss"
        Me.btnCoinToss.Size = New System.Drawing.Size(75, 23)
        Me.btnCoinToss.TabIndex = 0
        Me.btnCoinToss.Text = "Coin Toss"
        Me.btnCoinToss.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(168, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Menu"
        '
        'btnRockPaperScissors
        '
        Me.btnRockPaperScissors.Location = New System.Drawing.Point(160, 69)
        Me.btnRockPaperScissors.Name = "btnRockPaperScissors"
        Me.btnRockPaperScissors.Size = New System.Drawing.Size(75, 38)
        Me.btnRockPaperScissors.TabIndex = 4
        Me.btnRockPaperScissors.Text = "Rock Paper Scissors"
        Me.btnRockPaperScissors.UseVisualStyleBackColor = True
        '
        'btnRaceCarGame
        '
        Me.btnRaceCarGame.Location = New System.Drawing.Point(160, 166)
        Me.btnRaceCarGame.Name = "btnRaceCarGame"
        Me.btnRaceCarGame.Size = New System.Drawing.Size(75, 37)
        Me.btnRaceCarGame.TabIndex = 5
        Me.btnRaceCarGame.Text = "Race Car Game"
        Me.btnRaceCarGame.UseVisualStyleBackColor = True
        '
        'btnSumOfNumbers
        '
        Me.btnSumOfNumbers.Location = New System.Drawing.Point(160, 223)
        Me.btnSumOfNumbers.Name = "btnSumOfNumbers"
        Me.btnSumOfNumbers.Size = New System.Drawing.Size(75, 37)
        Me.btnSumOfNumbers.TabIndex = 6
        Me.btnSumOfNumbers.Text = "Sum Of Numbers"
        Me.btnSumOfNumbers.UseVisualStyleBackColor = True
        '
        'btnDistanceCalculator
        '
        Me.btnDistanceCalculator.Location = New System.Drawing.Point(160, 277)
        Me.btnDistanceCalculator.Name = "btnDistanceCalculator"
        Me.btnDistanceCalculator.Size = New System.Drawing.Size(75, 37)
        Me.btnDistanceCalculator.TabIndex = 7
        Me.btnDistanceCalculator.Text = "Distance Calculator"
        Me.btnDistanceCalculator.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 458)
        Me.Controls.Add(Me.btnDistanceCalculator)
        Me.Controls.Add(Me.btnSumOfNumbers)
        Me.Controls.Add(Me.btnRaceCarGame)
        Me.Controls.Add(Me.btnRockPaperScissors)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCoinToss)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCoinToss As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnRockPaperScissors As System.Windows.Forms.Button
    Friend WithEvents btnRaceCarGame As System.Windows.Forms.Button
    Friend WithEvents btnSumOfNumbers As System.Windows.Forms.Button
    Friend WithEvents btnDistanceCalculator As System.Windows.Forms.Button
End Class
