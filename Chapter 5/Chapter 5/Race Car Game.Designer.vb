<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Race_Car_Game
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
        Me.picFinish = New System.Windows.Forms.PictureBox()
        Me.picPengin = New System.Windows.Forms.PictureBox()
        Me.picPelican = New System.Windows.Forms.PictureBox()
        Me.picParrot = New System.Windows.Forms.PictureBox()
        Me.btnRace = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblParrot = New System.Windows.Forms.Label()
        Me.lblPelican = New System.Windows.Forms.Label()
        Me.lblPenguin = New System.Windows.Forms.Label()
        CType(Me.picFinish, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPengin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPelican, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picParrot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picFinish
        '
        Me.picFinish.Image = Global.Chapter_5.My.Resources.Resources.fin
        Me.picFinish.Location = New System.Drawing.Point(620, 0)
        Me.picFinish.Name = "picFinish"
        Me.picFinish.Size = New System.Drawing.Size(292, 473)
        Me.picFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFinish.TabIndex = 3
        Me.picFinish.TabStop = False
        '
        'picPengin
        '
        Me.picPengin.Image = Global.Chapter_5.My.Resources.Resources.penguin
        Me.picPengin.Location = New System.Drawing.Point(0, 231)
        Me.picPengin.Name = "picPengin"
        Me.picPengin.Size = New System.Drawing.Size(120, 123)
        Me.picPengin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPengin.TabIndex = 2
        Me.picPengin.TabStop = False
        '
        'picPelican
        '
        Me.picPelican.Image = Global.Chapter_5.My.Resources.Resources.pelican1
        Me.picPelican.Location = New System.Drawing.Point(0, 116)
        Me.picPelican.Name = "picPelican"
        Me.picPelican.Size = New System.Drawing.Size(120, 109)
        Me.picPelican.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPelican.TabIndex = 1
        Me.picPelican.TabStop = False
        '
        'picParrot
        '
        Me.picParrot.Image = Global.Chapter_5.My.Resources.Resources.parrot
        Me.picParrot.Location = New System.Drawing.Point(0, 0)
        Me.picParrot.Name = "picParrot"
        Me.picParrot.Size = New System.Drawing.Size(120, 110)
        Me.picParrot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picParrot.TabIndex = 0
        Me.picParrot.TabStop = False
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(22, 385)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(75, 23)
        Me.btnRace.TabIndex = 4
        Me.btnRace.Text = "Race!"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(22, 434)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 373)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Wins:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 395)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Parrot"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(452, 395)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Penguin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pelican"
        '
        'lblParrot
        '
        Me.lblParrot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParrot.Location = New System.Drawing.Point(192, 424)
        Me.lblParrot.Name = "lblParrot"
        Me.lblParrot.Size = New System.Drawing.Size(61, 33)
        Me.lblParrot.TabIndex = 10
        '
        'lblPelican
        '
        Me.lblPelican.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPelican.Location = New System.Drawing.Point(323, 424)
        Me.lblPelican.Name = "lblPelican"
        Me.lblPelican.Size = New System.Drawing.Size(61, 33)
        Me.lblPelican.TabIndex = 11
        '
        'lblPenguin
        '
        Me.lblPenguin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPenguin.Location = New System.Drawing.Point(455, 424)
        Me.lblPenguin.Name = "lblPenguin"
        Me.lblPenguin.Size = New System.Drawing.Size(61, 33)
        Me.lblPenguin.TabIndex = 12
        '
        'Race_Car_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(914, 469)
        Me.Controls.Add(Me.lblPenguin)
        Me.Controls.Add(Me.lblPelican)
        Me.Controls.Add(Me.lblParrot)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRace)
        Me.Controls.Add(Me.picPengin)
        Me.Controls.Add(Me.picPelican)
        Me.Controls.Add(Me.picParrot)
        Me.Controls.Add(Me.picFinish)
        Me.Name = "Race_Car_Game"
        Me.Text = "`"
        CType(Me.picFinish, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPengin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPelican, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picParrot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picParrot As System.Windows.Forms.PictureBox
    Friend WithEvents picPelican As System.Windows.Forms.PictureBox
    Friend WithEvents picPengin As System.Windows.Forms.PictureBox
    Friend WithEvents picFinish As System.Windows.Forms.PictureBox
    Friend WithEvents btnRace As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblParrot As System.Windows.Forms.Label
    Friend WithEvents lblPelican As System.Windows.Forms.Label
    Friend WithEvents lblPenguin As System.Windows.Forms.Label
End Class
