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
		Me.LabelAge = New System.Windows.Forms.Label()
		Me.LabelSmokerNot = New System.Windows.Forms.Label()
		Me.ComboBoxSmokerOrNot = New System.Windows.Forms.ComboBox()
		Me.ComboBoxAge = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(175, 117)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(143, 23)
		Me.ButtonExit.TabIndex = 17
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonClear
		'
		Me.ButtonClear.Location = New System.Drawing.Point(15, 117)
		Me.ButtonClear.Name = "ButtonClear"
		Me.ButtonClear.Size = New System.Drawing.Size(143, 23)
		Me.ButtonClear.TabIndex = 16
		Me.ButtonClear.Text = "Clear"
		Me.ButtonClear.UseVisualStyleBackColor = True
		'
		'TextBoxInsurance
		'
		Me.TextBoxInsurance.Enabled = False
		Me.TextBoxInsurance.Location = New System.Drawing.Point(15, 91)
		Me.TextBoxInsurance.Name = "TextBoxInsurance"
		Me.TextBoxInsurance.Size = New System.Drawing.Size(303, 20)
		Me.TextBoxInsurance.TabIndex = 15
		'
		'ButtonCalculateInsurance
		'
		Me.ButtonCalculateInsurance.Location = New System.Drawing.Point(15, 62)
		Me.ButtonCalculateInsurance.Name = "ButtonCalculateInsurance"
		Me.ButtonCalculateInsurance.Size = New System.Drawing.Size(303, 23)
		Me.ButtonCalculateInsurance.TabIndex = 14
		Me.ButtonCalculateInsurance.Text = "Calculate Insurance"
		Me.ButtonCalculateInsurance.UseVisualStyleBackColor = True
		'
		'LabelAge
		'
		Me.LabelAge.AutoSize = True
		Me.LabelAge.Location = New System.Drawing.Point(12, 38)
		Me.LabelAge.Name = "LabelAge"
		Me.LabelAge.Size = New System.Drawing.Size(90, 13)
		Me.LabelAge.TabIndex = 12
		Me.LabelAge.Text = "Please enter age:"
		'
		'LabelSmokerNot
		'
		Me.LabelSmokerNot.AutoSize = True
		Me.LabelSmokerNot.Location = New System.Drawing.Point(12, 10)
		Me.LabelSmokerNot.Name = "LabelSmokerNot"
		Me.LabelSmokerNot.Size = New System.Drawing.Size(182, 13)
		Me.LabelSmokerNot.TabIndex = 11
		Me.LabelSmokerNot.Text = "Please enter Smoker or Non-Smoker:"
		'
		'ComboBoxSmokerOrNot
		'
		Me.ComboBoxSmokerOrNot.FormattingEnabled = True
		Me.ComboBoxSmokerOrNot.Location = New System.Drawing.Point(197, 7)
		Me.ComboBoxSmokerOrNot.Name = "ComboBoxSmokerOrNot"
		Me.ComboBoxSmokerOrNot.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxSmokerOrNot.TabIndex = 18
		'
		'ComboBoxAge
		'
		Me.ComboBoxAge.FormattingEnabled = True
		Me.ComboBoxAge.Location = New System.Drawing.Point(197, 35)
		Me.ComboBoxAge.Name = "ComboBoxAge"
		Me.ComboBoxAge.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxAge.TabIndex = 19
		'
		'FormSmokerV2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(333, 158)
		Me.Controls.Add(Me.ComboBoxAge)
		Me.Controls.Add(Me.ComboBoxSmokerOrNot)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonClear)
		Me.Controls.Add(Me.TextBoxInsurance)
		Me.Controls.Add(Me.ButtonCalculateInsurance)
		Me.Controls.Add(Me.LabelAge)
		Me.Controls.Add(Me.LabelSmokerNot)
		Me.Name = "FormSmokerV2"
		Me.Text = "SmokerV2"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonExit As Button
	Friend WithEvents ButtonClear As Button
	Friend WithEvents TextBoxInsurance As TextBox
	Friend WithEvents ButtonCalculateInsurance As Button
	Friend WithEvents LabelAge As Label
	Friend WithEvents LabelSmokerNot As Label
	Friend WithEvents ComboBoxSmokerOrNot As ComboBox
	Friend WithEvents ComboBoxAge As ComboBox
End Class
