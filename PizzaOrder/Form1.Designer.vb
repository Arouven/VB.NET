<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPizzaOrder
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
		Me.ButtonBuildPizza = New System.Windows.Forms.Button()
		Me.PanelSize = New System.Windows.Forms.Panel()
		Me.RadioButtonSmall = New System.Windows.Forms.RadioButton()
		Me.RadioButtonMedium = New System.Windows.Forms.RadioButton()
		Me.RadioButtonLarge = New System.Windows.Forms.RadioButton()
		Me.PanelCrustType = New System.Windows.Forms.Panel()
		Me.RadioButtonThinCrust = New System.Windows.Forms.RadioButton()
		Me.RadioButtonThickCrust = New System.Windows.Forms.RadioButton()
		Me.PanelToppings = New System.Windows.Forms.Panel()
		Me.CheckBoxExtraCheese = New System.Windows.Forms.CheckBox()
		Me.CheckBoxMushrooms = New System.Windows.Forms.CheckBox()
		Me.CheckBoxBlackOlive = New System.Windows.Forms.CheckBox()
		Me.CheckBoxOnions = New System.Windows.Forms.CheckBox()
		Me.CheckBoxGreenPepper = New System.Windows.Forms.CheckBox()
		Me.CheckBoxTomatoes = New System.Windows.Forms.CheckBox()
		Me.RadioButtonEateIn = New System.Windows.Forms.RadioButton()
		Me.RadioButtonTakeOut = New System.Windows.Forms.RadioButton()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.PanelSize.SuspendLayout()
		Me.PanelCrustType.SuspendLayout()
		Me.PanelToppings.SuspendLayout()
		Me.SuspendLayout()
		'
		'ButtonBuildPizza
		'
		Me.ButtonBuildPizza.Location = New System.Drawing.Point(10, 147)
		Me.ButtonBuildPizza.Name = "ButtonBuildPizza"
		Me.ButtonBuildPizza.Size = New System.Drawing.Size(133, 23)
		Me.ButtonBuildPizza.TabIndex = 0
		Me.ButtonBuildPizza.Text = "Build Pizza"
		Me.ButtonBuildPizza.UseVisualStyleBackColor = True
		'
		'PanelSize
		'
		Me.PanelSize.Controls.Add(Me.RadioButtonLarge)
		Me.PanelSize.Controls.Add(Me.RadioButtonMedium)
		Me.PanelSize.Controls.Add(Me.RadioButtonSmall)
		Me.PanelSize.Location = New System.Drawing.Point(12, 12)
		Me.PanelSize.Name = "PanelSize"
		Me.PanelSize.Size = New System.Drawing.Size(93, 73)
		Me.PanelSize.TabIndex = 1
		'
		'RadioButtonSmall
		'
		Me.RadioButtonSmall.AutoSize = True
		Me.RadioButtonSmall.Checked = True
		Me.RadioButtonSmall.Location = New System.Drawing.Point(3, 3)
		Me.RadioButtonSmall.Name = "RadioButtonSmall"
		Me.RadioButtonSmall.Size = New System.Drawing.Size(50, 17)
		Me.RadioButtonSmall.TabIndex = 0
		Me.RadioButtonSmall.TabStop = True
		Me.RadioButtonSmall.Text = "Small"
		Me.RadioButtonSmall.UseVisualStyleBackColor = True
		'
		'RadioButtonMedium
		'
		Me.RadioButtonMedium.AutoSize = True
		Me.RadioButtonMedium.Location = New System.Drawing.Point(3, 26)
		Me.RadioButtonMedium.Name = "RadioButtonMedium"
		Me.RadioButtonMedium.Size = New System.Drawing.Size(62, 17)
		Me.RadioButtonMedium.TabIndex = 1
		Me.RadioButtonMedium.Text = "Medium"
		Me.RadioButtonMedium.UseVisualStyleBackColor = True
		'
		'RadioButtonLarge
		'
		Me.RadioButtonLarge.AutoSize = True
		Me.RadioButtonLarge.Location = New System.Drawing.Point(3, 49)
		Me.RadioButtonLarge.Name = "RadioButtonLarge"
		Me.RadioButtonLarge.Size = New System.Drawing.Size(52, 17)
		Me.RadioButtonLarge.TabIndex = 2
		Me.RadioButtonLarge.Text = "Large"
		Me.RadioButtonLarge.UseVisualStyleBackColor = True
		'
		'PanelCrustType
		'
		Me.PanelCrustType.Controls.Add(Me.RadioButtonThickCrust)
		Me.PanelCrustType.Controls.Add(Me.RadioButtonThinCrust)
		Me.PanelCrustType.Location = New System.Drawing.Point(10, 91)
		Me.PanelCrustType.Name = "PanelCrustType"
		Me.PanelCrustType.Size = New System.Drawing.Size(95, 50)
		Me.PanelCrustType.TabIndex = 2
		'
		'RadioButtonThinCrust
		'
		Me.RadioButtonThinCrust.AutoSize = True
		Me.RadioButtonThinCrust.Checked = True
		Me.RadioButtonThinCrust.Location = New System.Drawing.Point(3, 3)
		Me.RadioButtonThinCrust.Name = "RadioButtonThinCrust"
		Me.RadioButtonThinCrust.Size = New System.Drawing.Size(73, 17)
		Me.RadioButtonThinCrust.TabIndex = 0
		Me.RadioButtonThinCrust.TabStop = True
		Me.RadioButtonThinCrust.Text = "Thin Crust"
		Me.RadioButtonThinCrust.UseVisualStyleBackColor = True
		'
		'RadioButtonThickCrust
		'
		Me.RadioButtonThickCrust.AutoSize = True
		Me.RadioButtonThickCrust.Location = New System.Drawing.Point(3, 26)
		Me.RadioButtonThickCrust.Name = "RadioButtonThickCrust"
		Me.RadioButtonThickCrust.Size = New System.Drawing.Size(79, 17)
		Me.RadioButtonThickCrust.TabIndex = 1
		Me.RadioButtonThickCrust.Text = "Thick Crust"
		Me.RadioButtonThickCrust.UseVisualStyleBackColor = True
		'
		'PanelToppings
		'
		Me.PanelToppings.Controls.Add(Me.CheckBoxTomatoes)
		Me.PanelToppings.Controls.Add(Me.CheckBoxGreenPepper)
		Me.PanelToppings.Controls.Add(Me.CheckBoxOnions)
		Me.PanelToppings.Controls.Add(Me.CheckBoxBlackOlive)
		Me.PanelToppings.Controls.Add(Me.CheckBoxMushrooms)
		Me.PanelToppings.Controls.Add(Me.CheckBoxExtraCheese)
		Me.PanelToppings.Location = New System.Drawing.Point(121, 12)
		Me.PanelToppings.Name = "PanelToppings"
		Me.PanelToppings.Size = New System.Drawing.Size(200, 70)
		Me.PanelToppings.TabIndex = 3
		'
		'CheckBoxExtraCheese
		'
		Me.CheckBoxExtraCheese.AutoSize = True
		Me.CheckBoxExtraCheese.Location = New System.Drawing.Point(3, 3)
		Me.CheckBoxExtraCheese.Name = "CheckBoxExtraCheese"
		Me.CheckBoxExtraCheese.Size = New System.Drawing.Size(89, 17)
		Me.CheckBoxExtraCheese.TabIndex = 0
		Me.CheckBoxExtraCheese.Text = "Extra Cheese"
		Me.CheckBoxExtraCheese.UseVisualStyleBackColor = True
		'
		'CheckBoxMushrooms
		'
		Me.CheckBoxMushrooms.AutoSize = True
		Me.CheckBoxMushrooms.Location = New System.Drawing.Point(3, 26)
		Me.CheckBoxMushrooms.Name = "CheckBoxMushrooms"
		Me.CheckBoxMushrooms.Size = New System.Drawing.Size(80, 17)
		Me.CheckBoxMushrooms.TabIndex = 1
		Me.CheckBoxMushrooms.Text = "Mushrooms"
		Me.CheckBoxMushrooms.UseVisualStyleBackColor = True
		'
		'CheckBoxBlackOlive
		'
		Me.CheckBoxBlackOlive.AutoSize = True
		Me.CheckBoxBlackOlive.Location = New System.Drawing.Point(3, 49)
		Me.CheckBoxBlackOlive.Name = "CheckBoxBlackOlive"
		Me.CheckBoxBlackOlive.Size = New System.Drawing.Size(80, 17)
		Me.CheckBoxBlackOlive.TabIndex = 2
		Me.CheckBoxBlackOlive.Text = "Black Olive"
		Me.CheckBoxBlackOlive.UseVisualStyleBackColor = True
		'
		'CheckBoxOnions
		'
		Me.CheckBoxOnions.AutoSize = True
		Me.CheckBoxOnions.Location = New System.Drawing.Point(98, 3)
		Me.CheckBoxOnions.Name = "CheckBoxOnions"
		Me.CheckBoxOnions.Size = New System.Drawing.Size(59, 17)
		Me.CheckBoxOnions.TabIndex = 3
		Me.CheckBoxOnions.Text = "Onions"
		Me.CheckBoxOnions.UseVisualStyleBackColor = True
		'
		'CheckBoxGreenPepper
		'
		Me.CheckBoxGreenPepper.AutoSize = True
		Me.CheckBoxGreenPepper.Location = New System.Drawing.Point(98, 26)
		Me.CheckBoxGreenPepper.Name = "CheckBoxGreenPepper"
		Me.CheckBoxGreenPepper.Size = New System.Drawing.Size(92, 17)
		Me.CheckBoxGreenPepper.TabIndex = 4
		Me.CheckBoxGreenPepper.Text = "Green Pepper"
		Me.CheckBoxGreenPepper.UseVisualStyleBackColor = True
		'
		'CheckBoxTomatoes
		'
		Me.CheckBoxTomatoes.AutoSize = True
		Me.CheckBoxTomatoes.Location = New System.Drawing.Point(98, 49)
		Me.CheckBoxTomatoes.Name = "CheckBoxTomatoes"
		Me.CheckBoxTomatoes.Size = New System.Drawing.Size(73, 17)
		Me.CheckBoxTomatoes.TabIndex = 5
		Me.CheckBoxTomatoes.Text = "Tomatoes"
		Me.CheckBoxTomatoes.UseVisualStyleBackColor = True
		'
		'RadioButtonEateIn
		'
		Me.RadioButtonEateIn.AutoSize = True
		Me.RadioButtonEateIn.Checked = True
		Me.RadioButtonEateIn.Location = New System.Drawing.Point(124, 107)
		Me.RadioButtonEateIn.Name = "RadioButtonEateIn"
		Me.RadioButtonEateIn.Size = New System.Drawing.Size(53, 17)
		Me.RadioButtonEateIn.TabIndex = 4
		Me.RadioButtonEateIn.TabStop = True
		Me.RadioButtonEateIn.Text = "Eat In"
		Me.RadioButtonEateIn.UseVisualStyleBackColor = True
		'
		'RadioButtonTakeOut
		'
		Me.RadioButtonTakeOut.AutoSize = True
		Me.RadioButtonTakeOut.Location = New System.Drawing.Point(241, 107)
		Me.RadioButtonTakeOut.Name = "RadioButtonTakeOut"
		Me.RadioButtonTakeOut.Size = New System.Drawing.Size(70, 17)
		Me.RadioButtonTakeOut.TabIndex = 5
		Me.RadioButtonTakeOut.Text = "Take Out"
		Me.RadioButtonTakeOut.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(188, 147)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(133, 23)
		Me.ButtonExit.TabIndex = 6
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'FormPizzaOrder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(335, 182)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.RadioButtonTakeOut)
		Me.Controls.Add(Me.RadioButtonEateIn)
		Me.Controls.Add(Me.PanelToppings)
		Me.Controls.Add(Me.PanelCrustType)
		Me.Controls.Add(Me.PanelSize)
		Me.Controls.Add(Me.ButtonBuildPizza)
		Me.Name = "FormPizzaOrder"
		Me.Text = "Pizza Order"
		Me.PanelSize.ResumeLayout(False)
		Me.PanelSize.PerformLayout()
		Me.PanelCrustType.ResumeLayout(False)
		Me.PanelCrustType.PerformLayout()
		Me.PanelToppings.ResumeLayout(False)
		Me.PanelToppings.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonBuildPizza As Button
	Friend WithEvents PanelSize As Panel
	Friend WithEvents RadioButtonLarge As RadioButton
	Friend WithEvents RadioButtonMedium As RadioButton
	Friend WithEvents RadioButtonSmall As RadioButton
	Friend WithEvents PanelCrustType As Panel
	Friend WithEvents RadioButtonThickCrust As RadioButton
	Friend WithEvents RadioButtonThinCrust As RadioButton
	Friend WithEvents PanelToppings As Panel
	Friend WithEvents CheckBoxTomatoes As CheckBox
	Friend WithEvents CheckBoxGreenPepper As CheckBox
	Friend WithEvents CheckBoxOnions As CheckBox
	Friend WithEvents CheckBoxBlackOlive As CheckBox
	Friend WithEvents CheckBoxMushrooms As CheckBox
	Friend WithEvents CheckBoxExtraCheese As CheckBox
	Friend WithEvents RadioButtonEateIn As RadioButton
	Friend WithEvents RadioButtonTakeOut As RadioButton
	Friend WithEvents ButtonExit As Button
End Class
