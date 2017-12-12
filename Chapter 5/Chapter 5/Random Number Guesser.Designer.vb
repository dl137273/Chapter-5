<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Random_Number_Generator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.lblWins = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a Number 0-100"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(247, 29)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Wins"
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(35, 254)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(75, 23)
        Me.btnNewGame.TabIndex = 4
        Me.btnNewGame.Text = "New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(291, 254)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 5
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(156, 254)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 6
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'lblWins
        '
        Me.lblWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWins.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWins.Location = New System.Drawing.Point(100, 155)
        Me.lblWins.Name = "lblWins"
        Me.lblWins.Size = New System.Drawing.Size(113, 31)
        Me.lblWins.TabIndex = 7
        '
        'Random_Number_Generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 320)
        Me.Controls.Add(Me.lblWins)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Random_Number_Generator"
        Me.Text = "Random Number Guesser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNewGame As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents lblWins As System.Windows.Forms.Label
End Class
