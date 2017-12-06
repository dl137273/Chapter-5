<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rock_paper_Scissors
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
        Me.rbRock = New System.Windows.Forms.RadioButton()
        Me.rbPaper = New System.Windows.Forms.RadioButton()
        Me.rbScissors = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnShoot = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPlayerWins = New System.Windows.Forms.Label()
        Me.lblCPUWins = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbRock
        '
        Me.rbRock.AutoSize = True
        Me.rbRock.Location = New System.Drawing.Point(23, 54)
        Me.rbRock.Name = "rbRock"
        Me.rbRock.Size = New System.Drawing.Size(51, 17)
        Me.rbRock.TabIndex = 0
        Me.rbRock.TabStop = True
        Me.rbRock.Text = "Rock"
        Me.rbRock.UseVisualStyleBackColor = True
        '
        'rbPaper
        '
        Me.rbPaper.AutoSize = True
        Me.rbPaper.Location = New System.Drawing.Point(175, 54)
        Me.rbPaper.Name = "rbPaper"
        Me.rbPaper.Size = New System.Drawing.Size(53, 17)
        Me.rbPaper.TabIndex = 1
        Me.rbPaper.TabStop = True
        Me.rbPaper.Text = "Paper"
        Me.rbPaper.UseVisualStyleBackColor = True
        '
        'rbScissors
        '
        Me.rbScissors.AutoSize = True
        Me.rbScissors.Location = New System.Drawing.Point(324, 54)
        Me.rbScissors.Name = "rbScissors"
        Me.rbScissors.Size = New System.Drawing.Size(64, 17)
        Me.rbScissors.TabIndex = 2
        Me.rbScissors.TabStop = True
        Me.rbScissors.Text = "Scissors"
        Me.rbScissors.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 205)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Player Wins:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "CPU Wins:"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(48, 240)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(343, 36)
        Me.lblResult.TabIndex = 5
        '
        'btnShoot
        '
        Me.btnShoot.Location = New System.Drawing.Point(69, 324)
        Me.btnShoot.Name = "btnShoot"
        Me.btnShoot.Size = New System.Drawing.Size(75, 23)
        Me.btnShoot.TabIndex = 7
        Me.btnShoot.Text = "Shoot"
        Me.btnShoot.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(271, 324)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRock)
        Me.GroupBox1.Controls.Add(Me.rbPaper)
        Me.GroupBox1.Controls.Add(Me.rbScissors)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 107)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choices"
        '
        'lblPlayerWins
        '
        Me.lblPlayerWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPlayerWins.Location = New System.Drawing.Point(92, 188)
        Me.lblPlayerWins.Name = "lblPlayerWins"
        Me.lblPlayerWins.Size = New System.Drawing.Size(110, 36)
        Me.lblPlayerWins.TabIndex = 13
        '
        'lblCPUWins
        '
        Me.lblCPUWins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCPUWins.Location = New System.Drawing.Point(312, 188)
        Me.lblCPUWins.Name = "lblCPUWins"
        Me.lblCPUWins.Size = New System.Drawing.Size(110, 36)
        Me.lblCPUWins.TabIndex = 14
        '
        'Rock_paper_Scissors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 389)
        Me.Controls.Add(Me.lblCPUWins)
        Me.Controls.Add(Me.lblPlayerWins)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShoot)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Rock_paper_Scissors"
        Me.Text = "Rock Paper Scissors"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbRock As System.Windows.Forms.RadioButton
    Friend WithEvents rbPaper As System.Windows.Forms.RadioButton
    Friend WithEvents rbScissors As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnShoot As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlayerWins As System.Windows.Forms.Label
    Friend WithEvents lblCPUWins As System.Windows.Forms.Label
End Class
