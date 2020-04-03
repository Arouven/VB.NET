<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSmokerV2
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
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonClear = New System.Windows.Forms.Button()
		Me.TextBoxInsurance = New System.Windows.Forms.TextBox()
		Me.ButtonCalculateInsurance = New System.Windows.Forms.Button()
		Me.TextBoxAge = New System.Windows.Forms.TextBox()
		Me.LabelAge = New System.Windows.Forms.Label()
		Me.LabelSmokerNot = New System.Windows.Forms.Label()
		Me.RadioButtonNonSmoker = New System.Windows.Forms.RadioButton()
		Me.RadioButtonSmoker = New System.Windows.Forms.RadioButton()
		Me.SuspendLayout()
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(113, 147)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
		Me.ButtonExit.TabIndex = 17
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonClear
		'
		Me.ButtonClear.Location = New System.Drawing.Point(12, 147)
		Me.ButtonClear.Name = "ButtonClear"
		Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
		Me.ButtonClear.TabIndex = 16
		Me.ButtonClear.Text = "Clear"
		Me.ButtonClear.UseVisualStyleBackColor = True
		'
		'TextBoxInsurance
		'
		Me.TextBoxInsurance.Enabled = False
		Me.TextBoxInsurance.Location = New System.Drawing.Point(12, 121)
		Me.TextBoxInsurance.Name = "TextBoxInsurance"
		Me.TextBoxInsurance.Size = New System.Drawing.Size(176, 20)
		Me.TextBoxInsurance.TabIndex = 15
		'
		'ButtonCalculateInsurance
		'
		Me.ButtonCalculateInsurance.Location = New System.Drawing.Point(12, 92)
		Me.ButtonCalculateInsurance.Name = "ButtonCalculateInsurance"
		Me.ButtonCalculateInsurance.Size = New System.Drawing.Size(176, 23)
		Me.ButtonCalculateInsurance.TabIndex = 14
		Me.ButtonCalculateInsurance.Text = "Calculate Insurance"
		Me.ButtonCalculateInsurance.UseVisualStyleBackColor = True
		'
		'TextBoxAge
		'
		Me.TextBoxAge.Location = New System.Drawing.Point(102, 66)
		Me.TextBoxAge.Name = "TextBoxAge"
		Me.TextBoxAge.Size = New System.Drawing.Size(86, 20)
		Me.TextBoxAge.TabIndex = 13
		'
		'LabelAge
		'
		Me.LabelAge.AutoSize = True
		Me.LabelAge.Location = New System.Drawing.Point(9, 69)
		Me.LabelAge.Name = "LabelAge"
		Me.LabelAge.Size = New System.Drawing.Size(90, 13)
		Me.LabelAge.TabIndex = 12
		Me.LabelAge.Text = "Please enter age:"
		'
		'LabelSmokerNot
		'
		Me.LabelSmokerNot.AutoSize = True
		Me.LabelSmokerNot.Location = New System.Drawing.Point(9, 10)
		Me.LabelSmokerNot.Name = "LabelSmokerNot"
		Me.LabelSmokerNot.Size = New System.Drawing.Size(182, 13)
		Me.LabelSmokerNot.TabIndex = 11
		Me.LabelSmokerNot.Text = "Please enter Smoker or Non-Smoker:"
		'
		'RadioButtonNonSmoker
		'
		Me.RadioButtonNonSmoker.AutoSize = True
		Me.RadioButtonNonSmoker.Checked = True
		Me.RadioButtonNonSmoker.Location = New System.Drawing.Point(12, 49)
		Me.RadioButtonNonSmoker.Name = "RadioButtonNonSmoker"
		Me.RadioButtonNonSmoker.Size = New System.Drawing.Size(84, 17)
		Me.RadioButtonNonSmoker.TabIndex = 10
		Me.RadioButtonNonSmoker.TabStop = True
		Me.RadioButtonNonSmoker.Text = "Non-Smoker"
		Me.RadioButtonNonSmoker.UseVisualStyleBackColor = True
		'
		'RadioButtonSmoker
		'
		Me.RadioButtonSmoker.AutoSize = True
		Me.RadioButtonSmoker.Location = New System.Drawing.Point(12, 26)
		Me.RadioButtonSmoker.Name = "RadioButtonSmoker"
		Me.RadioButtonSmoker.Size = New System.Drawing.Size(61, 17)
		Me.RadioButtonSmoker.TabIndex = 9
		Me.RadioButtonSmoker.Text = "Smoker"
		Me.RadioButtonSmoker.UseVisualStyleBackColor = True
		'
		'FormSmokerV2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(199, 188)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonClear)
		Me.Controls.Add(Me.TextBoxInsurance)
		Me.Controls.Add(Me.ButtonCalculateInsurance)
		Me.Controls.Add(Me.TextBoxAge)
		Me.Controls.Add(Me.LabelAge)
		Me.Controls.Add(Me.LabelSmokerNot)
		Me.Controls.Add(Me.RadioButtonNonSmoker)
		Me.Controls.Add(Me.RadioButtonSmoker)
		Me.Name = "FormSmokerV2"
		Me.Text = "SmokerV2"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonExit As Button
	Friend WithEvents ButtonClear As Button
	Friend WithEvents TextBoxInsurance As TextBox
	Friend WithEvents ButtonCalculateInsurance As Button
	Friend WithEvents TextBoxAge As TextBox
	Friend WithEvents LabelAge As Label
	Friend WithEvents LabelSmokerNot As Label
	Friend WithEvents RadioButtonNonSmoker As RadioButton
	Friend WithEvents RadioButtonSmoker As RadioButton
End Class
