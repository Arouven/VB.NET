<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
		Me.LabelSandwich = New System.Windows.Forms.Label()
		Me.CheckBoxPickles = New System.Windows.Forms.CheckBox()
		Me.CheckBoxOnions = New System.Windows.Forms.CheckBox()
		Me.CheckBoxTomatoes = New System.Windows.Forms.CheckBox()
		Me.LabelWith = New System.Windows.Forms.Label()
		Me.RadioButtonSaladBar = New System.Windows.Forms.RadioButton()
		Me.RadioButtonSoup = New System.Windows.Forms.RadioButton()
		Me.RadioButtonDesert = New System.Windows.Forms.RadioButton()
		Me.LabelSelected = New System.Windows.Forms.Label()
		Me.ListBoxMenu = New System.Windows.Forms.ListBox()
		Me.ButtonDisplay = New System.Windows.Forms.Button()
		Me.ButtonClear = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'LabelSandwich
		'
		Me.LabelSandwich.Location = New System.Drawing.Point(12, 9)
		Me.LabelSandwich.Name = "LabelSandwich"
		Me.LabelSandwich.Size = New System.Drawing.Size(100, 34)
		Me.LabelSandwich.TabIndex = 0
		Me.LabelSandwich.Text = "I want the following on my sandwich"
		'
		'CheckBoxPickles
		'
		Me.CheckBoxPickles.AutoSize = True
		Me.CheckBoxPickles.Location = New System.Drawing.Point(15, 46)
		Me.CheckBoxPickles.Name = "CheckBoxPickles"
		Me.CheckBoxPickles.Size = New System.Drawing.Size(60, 17)
		Me.CheckBoxPickles.TabIndex = 1
		Me.CheckBoxPickles.Text = "Pickles"
		Me.CheckBoxPickles.UseVisualStyleBackColor = True
		'
		'CheckBoxOnions
		'
		Me.CheckBoxOnions.AutoSize = True
		Me.CheckBoxOnions.Location = New System.Drawing.Point(15, 69)
		Me.CheckBoxOnions.Name = "CheckBoxOnions"
		Me.CheckBoxOnions.Size = New System.Drawing.Size(59, 17)
		Me.CheckBoxOnions.TabIndex = 2
		Me.CheckBoxOnions.Text = "Onions"
		Me.CheckBoxOnions.UseVisualStyleBackColor = True
		'
		'CheckBoxTomatoes
		'
		Me.CheckBoxTomatoes.AutoSize = True
		Me.CheckBoxTomatoes.Location = New System.Drawing.Point(15, 92)
		Me.CheckBoxTomatoes.Name = "CheckBoxTomatoes"
		Me.CheckBoxTomatoes.Size = New System.Drawing.Size(73, 17)
		Me.CheckBoxTomatoes.TabIndex = 3
		Me.CheckBoxTomatoes.Text = "Tomatoes"
		Me.CheckBoxTomatoes.UseVisualStyleBackColor = True
		'
		'LabelWith
		'
		Me.LabelWith.AutoSize = True
		Me.LabelWith.Location = New System.Drawing.Point(141, 9)
		Me.LabelWith.Name = "LabelWith"
		Me.LabelWith.Size = New System.Drawing.Size(66, 13)
		Me.LabelWith.TabIndex = 4
		Me.LabelWith.Text = "I want it with"
		'
		'RadioButtonSaladBar
		'
		Me.RadioButtonSaladBar.AutoSize = True
		Me.RadioButtonSaladBar.Location = New System.Drawing.Point(141, 25)
		Me.RadioButtonSaladBar.Name = "RadioButtonSaladBar"
		Me.RadioButtonSaladBar.Size = New System.Drawing.Size(71, 17)
		Me.RadioButtonSaladBar.TabIndex = 5
		Me.RadioButtonSaladBar.TabStop = True
		Me.RadioButtonSaladBar.Text = "Salad Bar"
		Me.RadioButtonSaladBar.UseVisualStyleBackColor = True
		'
		'RadioButtonSoup
		'
		Me.RadioButtonSoup.AutoSize = True
		Me.RadioButtonSoup.Location = New System.Drawing.Point(141, 48)
		Me.RadioButtonSoup.Name = "RadioButtonSoup"
		Me.RadioButtonSoup.Size = New System.Drawing.Size(50, 17)
		Me.RadioButtonSoup.TabIndex = 6
		Me.RadioButtonSoup.TabStop = True
		Me.RadioButtonSoup.Text = "Soup"
		Me.RadioButtonSoup.UseVisualStyleBackColor = True
		'
		'RadioButtonDesert
		'
		Me.RadioButtonDesert.AutoSize = True
		Me.RadioButtonDesert.Location = New System.Drawing.Point(141, 71)
		Me.RadioButtonDesert.Name = "RadioButtonDesert"
		Me.RadioButtonDesert.Size = New System.Drawing.Size(56, 17)
		Me.RadioButtonDesert.TabIndex = 7
		Me.RadioButtonDesert.TabStop = True
		Me.RadioButtonDesert.Text = "Desert"
		Me.RadioButtonDesert.UseVisualStyleBackColor = True
		'
		'LabelSelected
		'
		Me.LabelSelected.AutoSize = True
		Me.LabelSelected.Location = New System.Drawing.Point(246, 9)
		Me.LabelSelected.Name = "LabelSelected"
		Me.LabelSelected.Size = New System.Drawing.Size(134, 13)
		Me.LabelSelected.TabIndex = 8
		Me.LabelSelected.Text = "You selected the following:"
		'
		'ListBoxMenu
		'
		Me.ListBoxMenu.FormattingEnabled = True
		Me.ListBoxMenu.Location = New System.Drawing.Point(249, 25)
		Me.ListBoxMenu.Name = "ListBoxMenu"
		Me.ListBoxMenu.Size = New System.Drawing.Size(131, 95)
		Me.ListBoxMenu.TabIndex = 9
		'
		'ButtonDisplay
		'
		Me.ButtonDisplay.Location = New System.Drawing.Point(287, 126)
		Me.ButtonDisplay.Name = "ButtonDisplay"
		Me.ButtonDisplay.Size = New System.Drawing.Size(93, 23)
		Me.ButtonDisplay.TabIndex = 10
		Me.ButtonDisplay.Text = "Display Menu"
		Me.ButtonDisplay.UseVisualStyleBackColor = True
		'
		'ButtonClear
		'
		Me.ButtonClear.Location = New System.Drawing.Point(153, 126)
		Me.ButtonClear.Name = "ButtonClear"
		Me.ButtonClear.Size = New System.Drawing.Size(93, 23)
		Me.ButtonClear.TabIndex = 11
		Me.ButtonClear.Text = "Clear"
		Me.ButtonClear.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(12, 126)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(93, 23)
		Me.ButtonExit.TabIndex = 12
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'FormMenu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(393, 160)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonClear)
		Me.Controls.Add(Me.ButtonDisplay)
		Me.Controls.Add(Me.ListBoxMenu)
		Me.Controls.Add(Me.LabelSelected)
		Me.Controls.Add(Me.RadioButtonDesert)
		Me.Controls.Add(Me.RadioButtonSoup)
		Me.Controls.Add(Me.RadioButtonSaladBar)
		Me.Controls.Add(Me.LabelWith)
		Me.Controls.Add(Me.CheckBoxTomatoes)
		Me.Controls.Add(Me.CheckBoxOnions)
		Me.Controls.Add(Me.CheckBoxPickles)
		Me.Controls.Add(Me.LabelSandwich)
		Me.Name = "FormMenu"
		Me.Text = "Menu"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelSandwich As Label
	Friend WithEvents CheckBoxPickles As CheckBox
	Friend WithEvents CheckBoxOnions As CheckBox
	Friend WithEvents CheckBoxTomatoes As CheckBox
	Friend WithEvents LabelWith As Label
	Friend WithEvents RadioButtonSaladBar As RadioButton
	Friend WithEvents RadioButtonSoup As RadioButton
	Friend WithEvents RadioButtonDesert As RadioButton
	Friend WithEvents LabelSelected As Label
	Friend WithEvents ListBoxMenu As ListBox
	Friend WithEvents ButtonDisplay As Button
	Friend WithEvents ButtonClear As Button
	Friend WithEvents ButtonExit As Button
End Class
