<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFlightPlanner
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
		Me.LabelDestinationCity = New System.Windows.Forms.Label()
		Me.ComboBoxSeatLocation = New System.Windows.Forms.ComboBox()
		Me.LabelSeatLocation = New System.Windows.Forms.Label()
		Me.LabelMealPreference = New System.Windows.Forms.Label()
		Me.ButtonAssign = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ListBoxCities = New System.Windows.Forms.ListBox()
		Me.ComboBoxMealPreference = New System.Windows.Forms.ComboBox()
		Me.SuspendLayout()
		'
		'LabelDestinationCity
		'
		Me.LabelDestinationCity.AutoSize = True
		Me.LabelDestinationCity.Location = New System.Drawing.Point(12, 9)
		Me.LabelDestinationCity.Name = "LabelDestinationCity"
		Me.LabelDestinationCity.Size = New System.Drawing.Size(80, 13)
		Me.LabelDestinationCity.TabIndex = 0
		Me.LabelDestinationCity.Text = "Destination City"
		'
		'ComboBoxSeatLocation
		'
		Me.ComboBoxSeatLocation.FormattingEnabled = True
		Me.ComboBoxSeatLocation.Location = New System.Drawing.Point(141, 25)
		Me.ComboBoxSeatLocation.Name = "ComboBoxSeatLocation"
		Me.ComboBoxSeatLocation.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxSeatLocation.TabIndex = 1
		'
		'LabelSeatLocation
		'
		Me.LabelSeatLocation.AutoSize = True
		Me.LabelSeatLocation.Location = New System.Drawing.Point(138, 9)
		Me.LabelSeatLocation.Name = "LabelSeatLocation"
		Me.LabelSeatLocation.Size = New System.Drawing.Size(73, 13)
		Me.LabelSeatLocation.TabIndex = 2
		Me.LabelSeatLocation.Text = "Seat Location"
		'
		'LabelMealPreference
		'
		Me.LabelMealPreference.AutoSize = True
		Me.LabelMealPreference.Location = New System.Drawing.Point(265, 9)
		Me.LabelMealPreference.Name = "LabelMealPreference"
		Me.LabelMealPreference.Size = New System.Drawing.Size(85, 13)
		Me.LabelMealPreference.TabIndex = 3
		Me.LabelMealPreference.Text = "Meal Preference"
		'
		'ButtonAssign
		'
		Me.ButtonAssign.Location = New System.Drawing.Point(17, 126)
		Me.ButtonAssign.Name = "ButtonAssign"
		Me.ButtonAssign.Size = New System.Drawing.Size(179, 23)
		Me.ButtonAssign.TabIndex = 4
		Me.ButtonAssign.Text = "Assign"
		Me.ButtonAssign.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(210, 126)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(179, 23)
		Me.ButtonExit.TabIndex = 5
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ListBoxCities
		'
		Me.ListBoxCities.FormattingEnabled = True
		Me.ListBoxCities.Location = New System.Drawing.Point(15, 25)
		Me.ListBoxCities.Name = "ListBoxCities"
		Me.ListBoxCities.Size = New System.Drawing.Size(120, 95)
		Me.ListBoxCities.TabIndex = 6
		'
		'ComboBoxMealPreference
		'
		Me.ComboBoxMealPreference.FormattingEnabled = True
		Me.ComboBoxMealPreference.Location = New System.Drawing.Point(268, 25)
		Me.ComboBoxMealPreference.Name = "ComboBoxMealPreference"
		Me.ComboBoxMealPreference.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxMealPreference.TabIndex = 7
		'
		'FormFlightPlanner
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(403, 163)
		Me.Controls.Add(Me.ComboBoxMealPreference)
		Me.Controls.Add(Me.ListBoxCities)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonAssign)
		Me.Controls.Add(Me.LabelMealPreference)
		Me.Controls.Add(Me.LabelSeatLocation)
		Me.Controls.Add(Me.ComboBoxSeatLocation)
		Me.Controls.Add(Me.LabelDestinationCity)
		Me.Name = "FormFlightPlanner"
		Me.Text = "Flight Planner"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelDestinationCity As Label
	Friend WithEvents ComboBoxSeatLocation As ComboBox
	Friend WithEvents LabelSeatLocation As Label
	Friend WithEvents LabelMealPreference As Label
	Friend WithEvents ButtonAssign As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents ListBoxCities As ListBox
	Friend WithEvents ComboBoxMealPreference As ComboBox
End Class
