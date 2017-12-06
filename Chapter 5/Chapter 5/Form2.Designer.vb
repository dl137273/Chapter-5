<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Coin_Toss
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
        Me.picHeads = New System.Windows.Forms.PictureBox()
        Me.picTails = New System.Windows.Forms.PictureBox()
        Me.btnFlipCoin = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHeads = New System.Windows.Forms.Label()
        Me.lblTails = New System.Windows.Forms.Label()
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picHeads
        '
        Me.picHeads.Image = Global.Chapter_5.My.Resources.Resources.download
        Me.picHeads.Location = New System.Drawing.Point(12, 12)
        Me.picHeads.Name = "picHeads"
        Me.picHeads.Size = New System.Drawing.Size(225, 224)
        Me.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picHeads.TabIndex = 0
        Me.picHeads.TabStop = False
        '
        'picTails
        '
        Me.picTails.Image = Global.Chapter_5.My.Resources.Resources.download__1_
        Me.picTails.Location = New System.Drawing.Point(544, 12)
        Me.picTails.Name = "picTails"
        Me.picTails.Size = New System.Drawing.Size(225, 224)
        Me.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picTails.TabIndex = 1
        Me.picTails.TabStop = False
        '
        'btnFlipCoin
        '
        Me.btnFlipCoin.Location = New System.Drawing.Point(150, 305)
        Me.btnFlipCoin.Name = "btnFlipCoin"
        Me.btnFlipCoin.Size = New System.Drawing.Size(78, 40)
        Me.btnFlipCoin.TabIndex = 2
        Me.btnFlipCoin.Text = "Flip Coin"
        Me.btnFlipCoin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(559, 305)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 40)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(166, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Heads:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(530, 396)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tails:"
        '
        'lblHeads
        '
        Me.lblHeads.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHeads.Location = New System.Drawing.Point(213, 396)
        Me.lblHeads.Name = "lblHeads"
        Me.lblHeads.Size = New System.Drawing.Size(100, 23)
        Me.lblHeads.TabIndex = 6
        '
        'lblTails
        '
        Me.lblTails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTails.Location = New System.Drawing.Point(559, 395)
        Me.lblTails.Name = "lblTails"
        Me.lblTails.Size = New System.Drawing.Size(100, 23)
        Me.lblTails.TabIndex = 7
        '
        'Coin_Toss
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 464)
        Me.Controls.Add(Me.lblTails)
        Me.Controls.Add(Me.lblHeads)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFlipCoin)
        Me.Controls.Add(Me.picTails)
        Me.Controls.Add(Me.picHeads)
        Me.Name = "Coin_Toss"
        Me.Text = "Coin Toss"
        CType(Me.picHeads, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picHeads As System.Windows.Forms.PictureBox
    Friend WithEvents picTails As System.Windows.Forms.PictureBox
    Friend WithEvents btnFlipCoin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHeads As System.Windows.Forms.Label
    Friend WithEvents lblTails As System.Windows.Forms.Label
End Class
