<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudentInformation
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
		Me.LabelName = New System.Windows.Forms.Label()
		Me.TextBoxName = New System.Windows.Forms.TextBox()
		Me.LabelAge = New System.Windows.Forms.Label()
		Me.TextBoxAge = New System.Windows.Forms.TextBox()
		Me.GroupBoxSex = New System.Windows.Forms.GroupBox()
		Me.RadioButtonFamale = New System.Windows.Forms.RadioButton()
		Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
		Me.GroupBoxActivity = New System.Windows.Forms.GroupBox()
		Me.GroupBoxAthleticLevel = New System.Windows.Forms.GroupBox()
		Me.CheckBoxSkating = New System.Windows.Forms.CheckBox()
		Me.CheckBoxSking = New System.Windows.Forms.CheckBox()
		Me.CheckBoxBiking = New System.Windows.Forms.CheckBox()
		Me.CheckBoxSeimming = New System.Windows.Forms.CheckBox()
		Me.CheckBoxWalking = New System.Windows.Forms.CheckBox()
		Me.CheckBoxRunning = New System.Windows.Forms.CheckBox()
		Me.GroupBoxCity = New System.Windows.Forms.GroupBox()
		Me.ComboBoxCity = New System.Windows.Forms.ComboBox()
		Me.GroupBoxAtheleticLevel = New System.Windows.Forms.GroupBox()
		Me.RadioButtonExtreme = New System.Windows.Forms.RadioButton()
		Me.RadioButtonAdvanced = New System.Windows.Forms.RadioButton()
		Me.RadioButtonIntermediate = New System.Windows.Forms.RadioButton()
		Me.RadioButtonBeginner = New System.Windows.Forms.RadioButton()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonShowProfile = New System.Windows.Forms.Button()
		Me.ButtonNewProfile = New System.Windows.Forms.Button()
		Me.GroupBoxSex.SuspendLayout()
		Me.GroupBoxActivity.SuspendLayout()
		Me.GroupBoxCity.SuspendLayout()
		Me.GroupBoxAtheleticLevel.SuspendLayout()
		Me.SuspendLayout()
		'
		'LabelName
		'
		Me.LabelName.AutoSize = True
		Me.LabelName.Location = New System.Drawing.Point(12, 9)
		Me.LabelName.Name = "LabelName"
		Me.LabelName.Size = New System.Drawing.Size(35, 13)
		Me.LabelName.TabIndex = 0
		Me.LabelName.Text = "Name"
		'
		'TextBoxName
		'
		Me.TextBoxName.Location = New System.Drawing.Point(53, 6)
		Me.TextBoxName.Name = "TextBoxName"
		Me.TextBoxName.Size = New System.Drawing.Size(166, 20)
		Me.TextBoxName.TabIndex = 1
		'
		'LabelAge
		'
		Me.LabelAge.AutoSize = True
		Me.LabelAge.Location = New System.Drawing.Point(237, 9)
		Me.LabelAge.Name = "LabelAge"
		Me.LabelAge.Size = New System.Drawing.Size(26, 13)
		Me.LabelAge.TabIndex = 2
		Me.LabelAge.Text = "Age"
		'
		'TextBoxAge
		'
		Me.TextBoxAge.Location = New System.Drawing.Point(269, 6)
		Me.TextBoxAge.Name = "TextBoxAge"
		Me.TextBoxAge.Size = New System.Drawing.Size(62, 20)
		Me.TextBoxAge.TabIndex = 3
		'
		'GroupBoxSex
		'
		Me.GroupBoxSex.Controls.Add(Me.RadioButtonFamale)
		Me.GroupBoxSex.Controls.Add(Me.RadioButtonMale)
		Me.GroupBoxSex.Location = New System.Drawing.Point(12, 32)
		Me.GroupBoxSex.Name = "GroupBoxSex"
		Me.GroupBoxSex.Size = New System.Drawing.Size(156, 69)
		Me.GroupBoxSex.TabIndex = 4
		Me.GroupBoxSex.TabStop = False
		Me.GroupBoxSex.Text = "Sex"
		'
		'RadioButtonFamale
		'
		Me.RadioButtonFamale.AutoSize = True
		Me.RadioButtonFamale.Location = New System.Drawing.Point(6, 42)
		Me.RadioButtonFamale.Name = "RadioButtonFamale"
		Me.RadioButtonFamale.Size = New System.Drawing.Size(59, 17)
		Me.RadioButtonFamale.TabIndex = 1
		Me.RadioButtonFamale.Text = "Female"
		Me.RadioButtonFamale.UseVisualStyleBackColor = True
		'
		'RadioButtonMale
		'
		Me.RadioButtonMale.AutoSize = True
		Me.RadioButtonMale.Checked = True
		Me.RadioButtonMale.Location = New System.Drawing.Point(6, 19)
		Me.RadioButtonMale.Name = "RadioButtonMale"
		Me.RadioButtonMale.Size = New System.Drawing.Size(48, 17)
		Me.RadioButtonMale.TabIndex = 0
		Me.RadioButtonMale.TabStop = True
		Me.RadioButtonMale.Text = "Male"
		Me.RadioButtonMale.UseVisualStyleBackColor = True
		'
		'GroupBoxActivity
		'
		Me.GroupBoxActivity.Controls.Add(Me.GroupBoxAthleticLevel)
		Me.GroupBoxActivity.Controls.Add(Me.CheckBoxSkating)
		Me.GroupBoxActivity.Controls.Add(Me.CheckBoxSking)
		Me.GroupBoxActivity.Controls.Add(Me.CheckBoxBiking)
		Me.GroupBoxActivity.Controls.Add(Me.CheckBoxSeimming)
		Me.GroupBoxActivity.Controls.Add(Me.CheckBoxWalking)
		Me.GroupBoxActivity.Controls.Add(Me.CheckBoxRunning)
		Me.GroupBoxActivity.Location = New System.Drawing.Point(12, 107)
		Me.GroupBoxActivity.Name = "GroupBoxActivity"
		Me.GroupBoxActivity.Size = New System.Drawing.Size(156, 164)
		Me.GroupBoxActivity.TabIndex = 5
		Me.GroupBoxActivity.TabStop = False
		Me.GroupBoxActivity.Text = "Activity"
		'
		'GroupBoxAthleticLevel
		'
		Me.GroupBoxAthleticLevel.Location = New System.Drawing.Point(174, 42)
		Me.GroupBoxAthleticLevel.Name = "GroupBoxAthleticLevel"
		Me.GroupBoxAthleticLevel.Size = New System.Drawing.Size(145, 109)
		Me.GroupBoxAthleticLevel.TabIndex = 7
		Me.GroupBoxAthleticLevel.TabStop = False
		Me.GroupBoxAthleticLevel.Text = "Athletic Level"
		'
		'CheckBoxSkating
		'
		Me.CheckBoxSkating.AutoSize = True
		Me.CheckBoxSkating.Location = New System.Drawing.Point(6, 134)
		Me.CheckBoxSkating.Name = "CheckBoxSkating"
		Me.CheckBoxSkating.Size = New System.Drawing.Size(62, 17)
		Me.CheckBoxSkating.TabIndex = 5
		Me.CheckBoxSkating.Text = "Skating"
		Me.CheckBoxSkating.UseVisualStyleBackColor = True
		'
		'CheckBoxSking
		'
		Me.CheckBoxSking.AutoSize = True
		Me.CheckBoxSking.Location = New System.Drawing.Point(6, 111)
		Me.CheckBoxSking.Name = "CheckBoxSking"
		Me.CheckBoxSking.Size = New System.Drawing.Size(53, 17)
		Me.CheckBoxSking.TabIndex = 4
		Me.CheckBoxSking.Text = "Sking"
		Me.CheckBoxSking.UseVisualStyleBackColor = True
		'
		'CheckBoxBiking
		'
		Me.CheckBoxBiking.AutoSize = True
		Me.CheckBoxBiking.Location = New System.Drawing.Point(6, 65)
		Me.CheckBoxBiking.Name = "CheckBoxBiking"
		Me.CheckBoxBiking.Size = New System.Drawing.Size(55, 17)
		Me.CheckBoxBiking.TabIndex = 3
		Me.CheckBoxBiking.Text = "Biking"
		Me.CheckBoxBiking.UseVisualStyleBackColor = True
		'
		'CheckBoxSeimming
		'
		Me.CheckBoxSeimming.AutoSize = True
		Me.CheckBoxSeimming.Location = New System.Drawing.Point(6, 88)
		Me.CheckBoxSeimming.Name = "CheckBoxSeimming"
		Me.CheckBoxSeimming.Size = New System.Drawing.Size(73, 17)
		Me.CheckBoxSeimming.TabIndex = 2
		Me.CheckBoxSeimming.Text = "Swimming"
		Me.CheckBoxSeimming.UseVisualStyleBackColor = True
		'
		'CheckBoxWalking
		'
		Me.CheckBoxWalking.AutoSize = True
		Me.CheckBoxWalking.Location = New System.Drawing.Point(6, 42)
		Me.CheckBoxWalking.Name = "CheckBoxWalking"
		Me.CheckBoxWalking.Size = New System.Drawing.Size(65, 17)
		Me.CheckBoxWalking.TabIndex = 1
		Me.CheckBoxWalking.Text = "Walking"
		Me.CheckBoxWalking.UseVisualStyleBackColor = True
		'
		'CheckBoxRunning
		'
		Me.CheckBoxRunning.AutoSize = True
		Me.CheckBoxRunning.Location = New System.Drawing.Point(6, 19)
		Me.CheckBoxRunning.Name = "CheckBoxRunning"
		Me.CheckBoxRunning.Size = New System.Drawing.Size(66, 17)
		Me.CheckBoxRunning.TabIndex = 0
		Me.CheckBoxRunning.Text = "Running"
		Me.CheckBoxRunning.UseVisualStyleBackColor = True
		'
		'GroupBoxCity
		'
		Me.GroupBoxCity.Controls.Add(Me.ComboBoxCity)
		Me.GroupBoxCity.Location = New System.Drawing.Point(174, 32)
		Me.GroupBoxCity.Name = "GroupBoxCity"
		Me.GroupBoxCity.Size = New System.Drawing.Size(157, 117)
		Me.GroupBoxCity.TabIndex = 6
		Me.GroupBoxCity.TabStop = False
		Me.GroupBoxCity.Text = "City of Residence"
		'
		'ComboBoxCity
		'
		Me.ComboBoxCity.FormattingEnabled = True
		Me.ComboBoxCity.Items.AddRange(New Object() {"Beau Bassin", "Curepipe", "Flacq", "Mahebourg", "Bambous", "Port-Louis"})
		Me.ComboBoxCity.Location = New System.Drawing.Point(6, 19)
		Me.ComboBoxCity.Name = "ComboBoxCity"
		Me.ComboBoxCity.Size = New System.Drawing.Size(145, 21)
		Me.ComboBoxCity.TabIndex = 0
		'
		'GroupBoxAtheleticLevel
		'
		Me.GroupBoxAtheleticLevel.Controls.Add(Me.RadioButtonExtreme)
		Me.GroupBoxAtheleticLevel.Controls.Add(Me.RadioButtonAdvanced)
		Me.GroupBoxAtheleticLevel.Controls.Add(Me.RadioButtonIntermediate)
		Me.GroupBoxAtheleticLevel.Controls.Add(Me.RadioButtonBeginner)
		Me.GroupBoxAtheleticLevel.Location = New System.Drawing.Point(174, 155)
		Me.GroupBoxAtheleticLevel.Name = "GroupBoxAtheleticLevel"
		Me.GroupBoxAtheleticLevel.Size = New System.Drawing.Size(157, 116)
		Me.GroupBoxAtheleticLevel.TabIndex = 7
		Me.GroupBoxAtheleticLevel.TabStop = False
		Me.GroupBoxAtheleticLevel.Text = "Atheletic Level"
		'
		'RadioButtonExtreme
		'
		Me.RadioButtonExtreme.AutoSize = True
		Me.RadioButtonExtreme.Location = New System.Drawing.Point(6, 19)
		Me.RadioButtonExtreme.Name = "RadioButtonExtreme"
		Me.RadioButtonExtreme.Size = New System.Drawing.Size(63, 17)
		Me.RadioButtonExtreme.TabIndex = 3
		Me.RadioButtonExtreme.Text = "Extreme"
		Me.RadioButtonExtreme.UseVisualStyleBackColor = True
		'
		'RadioButtonAdvanced
		'
		Me.RadioButtonAdvanced.AutoSize = True
		Me.RadioButtonAdvanced.Location = New System.Drawing.Point(6, 42)
		Me.RadioButtonAdvanced.Name = "RadioButtonAdvanced"
		Me.RadioButtonAdvanced.Size = New System.Drawing.Size(74, 17)
		Me.RadioButtonAdvanced.TabIndex = 2
		Me.RadioButtonAdvanced.Text = "Advanced"
		Me.RadioButtonAdvanced.UseVisualStyleBackColor = True
		'
		'RadioButtonIntermediate
		'
		Me.RadioButtonIntermediate.AutoSize = True
		Me.RadioButtonIntermediate.Location = New System.Drawing.Point(6, 65)
		Me.RadioButtonIntermediate.Name = "RadioButtonIntermediate"
		Me.RadioButtonIntermediate.Size = New System.Drawing.Size(83, 17)
		Me.RadioButtonIntermediate.TabIndex = 1
		Me.RadioButtonIntermediate.Text = "Intermediate"
		Me.RadioButtonIntermediate.UseVisualStyleBackColor = True
		'
		'RadioButtonBeginner
		'
		Me.RadioButtonBeginner.AutoSize = True
		Me.RadioButtonBeginner.Checked = True
		Me.RadioButtonBeginner.Location = New System.Drawing.Point(6, 88)
		Me.RadioButtonBeginner.Name = "RadioButtonBeginner"
		Me.RadioButtonBeginner.Size = New System.Drawing.Size(67, 17)
		Me.RadioButtonBeginner.TabIndex = 0
		Me.RadioButtonBeginner.TabStop = True
		Me.RadioButtonBeginner.Text = "Beginner"
		Me.RadioButtonBeginner.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(12, 277)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
		Me.ButtonExit.TabIndex = 8
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonShowProfile
		'
		Me.ButtonShowProfile.Location = New System.Drawing.Point(134, 277)
		Me.ButtonShowProfile.Name = "ButtonShowProfile"
		Me.ButtonShowProfile.Size = New System.Drawing.Size(75, 23)
		Me.ButtonShowProfile.TabIndex = 9
		Me.ButtonShowProfile.Text = "Show Profile"
		Me.ButtonShowProfile.UseVisualStyleBackColor = True
		'
		'ButtonNewProfile
		'
		Me.ButtonNewProfile.Location = New System.Drawing.Point(256, 277)
		Me.ButtonNewProfile.Name = "ButtonNewProfile"
		Me.ButtonNewProfile.Size = New System.Drawing.Size(75, 23)
		Me.ButtonNewProfile.TabIndex = 10
		Me.ButtonNewProfile.Text = "New Profile"
		Me.ButtonNewProfile.UseVisualStyleBackColor = True
		'
		'FormStudentInformation
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(342, 309)
		Me.Controls.Add(Me.ButtonNewProfile)
		Me.Controls.Add(Me.ButtonShowProfile)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.GroupBoxAtheleticLevel)
		Me.Controls.Add(Me.GroupBoxCity)
		Me.Controls.Add(Me.GroupBoxActivity)
		Me.Controls.Add(Me.GroupBoxSex)
		Me.Controls.Add(Me.TextBoxAge)
		Me.Controls.Add(Me.LabelAge)
		Me.Controls.Add(Me.TextBoxName)
		Me.Controls.Add(Me.LabelName)
		Me.Name = "FormStudentInformation"
		Me.Text = "Student Information"
		Me.GroupBoxSex.ResumeLayout(False)
		Me.GroupBoxSex.PerformLayout()
		Me.GroupBoxActivity.ResumeLayout(False)
		Me.GroupBoxActivity.PerformLayout()
		Me.GroupBoxCity.ResumeLayout(False)
		Me.GroupBoxAtheleticLevel.ResumeLayout(False)
		Me.GroupBoxAtheleticLevel.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelName As Label
	Friend WithEvents TextBoxName As TextBox
	Friend WithEvents LabelAge As Label
	Friend WithEvents TextBoxAge As TextBox
	Friend WithEvents GroupBoxSex As GroupBox
	Friend WithEvents RadioButtonFamale As RadioButton
	Friend WithEvents RadioButtonMale As RadioButton
	Friend WithEvents GroupBoxActivity As GroupBox
	Friend WithEvents GroupBoxAthleticLevel As GroupBox
	Friend WithEvents CheckBoxSkating As CheckBox
	Friend WithEvents CheckBoxSking As CheckBox
	Friend WithEvents CheckBoxBiking As CheckBox
	Friend WithEvents CheckBoxSeimming As CheckBox
	Friend WithEvents CheckBoxWalking As CheckBox
	Friend WithEvents CheckBoxRunning As CheckBox
	Friend WithEvents GroupBoxCity As GroupBox
	Friend WithEvents ComboBoxCity As ComboBox
	Friend WithEvents GroupBoxAtheleticLevel As GroupBox
	Friend WithEvents RadioButtonExtreme As RadioButton
	Friend WithEvents RadioButtonAdvanced As RadioButton
	Friend WithEvents RadioButtonIntermediate As RadioButton
	Friend WithEvents RadioButtonBeginner As RadioButton
	Friend WithEvents ButtonExit As Button
	Friend WithEvents ButtonShowProfile As Button
	Friend WithEvents ButtonNewProfile As Button
End Class
