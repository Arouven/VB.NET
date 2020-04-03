<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSmoker
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
		Me.RadioButtonSmoker = New System.Windows.Forms.RadioButton()
		Me.RadioButtonNonSmoker = New System.Windows.Forms.RadioButton()
		Me.LabelSmokerNot = New System.Windows.Forms.Label()
		Me.LabelAge = New System.Windows.Forms.Label()
		Me.TextBoxAge = New System.Windows.Forms.TextBox()
		Me.ButtonCalculateInsurance = New System.Windows.Forms.Button()
		Me.TextBoxInsurance = New System.Windows.Forms.TextBox()
		Me.ButtonClear = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'RadioButtonSmoker
		'
		Me.RadioButtonSmoker.AutoSize = True
		Me.RadioButtonSmoker.Location = New System.Drawing.Point(16, 29)
		Me.RadioButtonSmoker.Name = "RadioButtonSmoker"
		Me.RadioButtonSmoker.Size = New System.Drawing.Size(61, 17)
		Me.RadioButtonSmoker.TabIndex = 0
		Me.RadioButtonSmoker.Text = "Smoker"
		Me.RadioButtonSmoker.UseVisualStyleBackColor = True
		'
		'RadioButtonNonSmoker
		'
		Me.RadioButtonNonSmoker.AutoSize = True
		Me.RadioButtonNonSmoker.Checked = True
		Me.RadioButtonNonSmoker.Location = New System.Drawing.Point(16, 52)
		Me.RadioButtonNonSmoker.Name = "RadioButtonNonSmoker"
		Me.RadioButtonNonSmoker.Size = New System.Drawing.Size(84, 17)
		Me.RadioButtonNonSmoker.TabIndex = 1
		Me.RadioButtonNonSmoker.TabStop = True
		Me.RadioButtonNonSmoker.Text = "Non-Smoker"
		Me.RadioButtonNonSmoker.UseVisualStyleBackColor = True
		'
		'LabelSmokerNot
		'
		Me.LabelSmokerNot.AutoSize = True
		Me.LabelSmokerNot.Location = New System.Drawing.Point(13, 13)
		Me.LabelSmokerNot.Name = "LabelSmokerNot"
		Me.LabelSmokerNot.Size = New System.Drawing.Size(182, 13)
		Me.LabelSmokerNot.TabIndex = 2
		Me.LabelSmokerNot.Text = "Please enter Smoker or Non-Smoker:"
		'
		'LabelAge
		'
		Me.LabelAge.AutoSize = True
		Me.LabelAge.Location = New System.Drawing.Point(13, 72)
		Me.LabelAge.Name = "LabelAge"
		Me.LabelAge.Size = New System.Drawing.Size(90, 13)
		Me.LabelAge.TabIndex = 3
		Me.LabelAge.Text = "Please enter age:"
		'
		'TextBoxAge
		'
		Me.TextBoxAge.Location = New System.Drawing.Point(106, 69)
		Me.TextBoxAge.Name = "TextBoxAge"
		Me.TextBoxAge.Size = New System.Drawing.Size(86, 20)
		Me.TextBoxAge.TabIndex = 4
		'
		'ButtonCalculateInsurance
		'
		Me.ButtonCalculateInsurance.Location = New System.Drawing.Point(16, 95)
		Me.ButtonCalculateInsurance.Name = "ButtonCalculateInsurance"
		Me.ButtonCalculateInsurance.Size = New System.Drawing.Size(176, 23)
		Me.ButtonCalculateInsurance.TabIndex = 5
		Me.ButtonCalculateInsurance.Text = "Calculate Insurance"
		Me.ButtonCalculateInsurance.UseVisualStyleBackColor = True
		'
		'TextBoxInsurance
		'
		Me.TextBoxInsurance.Enabled = False
		Me.TextBoxInsurance.Location = New System.Drawing.Point(16, 124)
		Me.TextBoxInsurance.Name = "TextBoxInsurance"
		Me.TextBoxInsurance.Size = New System.Drawing.Size(176, 20)
		Me.TextBoxInsurance.TabIndex = 6
		'
		'ButtonClear
		'
		Me.ButtonClear.Location = New System.Drawing.Point(16, 150)
		Me.ButtonClear.Name = "ButtonClear"
		Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
		Me.ButtonClear.TabIndex = 7
		Me.ButtonClear.Text = "Clear"
		Me.ButtonClear.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(117, 150)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
		Me.ButtonExit.TabIndex = 8
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'FormSmoker
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(210, 188)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonClear)
		Me.Controls.Add(Me.TextBoxInsurance)
		Me.Controls.Add(Me.ButtonCalculateInsurance)
		Me.Controls.Add(Me.TextBoxAge)
		Me.Controls.Add(Me.LabelAge)
		Me.Controls.Add(Me.LabelSmokerNot)
		Me.Controls.Add(Me.RadioButtonNonSmoker)
		Me.Controls.Add(Me.RadioButtonSmoker)
		Me.Name = "FormSmoker"
		Me.Text = "Smoker"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents RadioButtonSmoker As RadioButton
	Friend WithEvents RadioButtonNonSmoker As RadioButton
	Friend WithEvents LabelSmokerNot As Label
	Friend WithEvents LabelAge As Label
	Friend WithEvents TextBoxAge As TextBox
	Friend WithEvents ButtonCalculateInsurance As Button
	Friend WithEvents TextBoxInsurance As TextBox
	Friend WithEvents ButtonClear As Button
	Friend WithEvents ButtonExit As Button
End Class
