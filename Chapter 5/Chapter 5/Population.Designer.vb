<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Population
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrganisms = New System.Windows.Forms.TextBox()
        Me.txtDailyIncrease = New System.Windows.Forms.TextBox()
        Me.txtNumberofDays = New System.Windows.Forms.TextBox()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Starting Name of Organisms:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Average Daily Increase:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Days to Multiply:"
        '
        'txtOrganisms
        '
        Me.txtOrganisms.Location = New System.Drawing.Point(28, 35)
        Me.txtOrganisms.Name = "txtOrganisms"
        Me.txtOrganisms.Size = New System.Drawing.Size(100, 20)
        Me.txtOrganisms.TabIndex = 3
        '
        'txtDailyIncrease
        '
        Me.txtDailyIncrease.Location = New System.Drawing.Point(184, 35)
        Me.txtDailyIncrease.Name = "txtDailyIncrease"
        Me.txtDailyIncrease.Size = New System.Drawing.Size(100, 20)
        Me.txtDailyIncrease.TabIndex = 4
        '
        'txtNumberofDays
        '
        Me.txtNumberofDays.Location = New System.Drawing.Point(349, 35)
        Me.txtNumberofDays.Name = "txtNumberofDays"
        Me.txtNumberofDays.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberofDays.TabIndex = 5
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(145, 102)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(199, 160)
        Me.lstOutput.TabIndex = 6
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(53, 304)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(194, 304)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(331, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Population
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 349)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.txtNumberofDays)
        Me.Controls.Add(Me.txtDailyIncrease)
        Me.Controls.Add(Me.txtOrganisms)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Population"
        Me.Text = "Population"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOrganisms As System.Windows.Forms.TextBox
    Friend WithEvents txtDailyIncrease As System.Windows.Forms.TextBox
    Friend WithEvents txtNumberofDays As System.Windows.Forms.TextBox
    Friend WithEvents lstOutput As System.Windows.Forms.ListBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
