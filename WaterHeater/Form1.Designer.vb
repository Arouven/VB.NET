<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormWaterHeater
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
		Me.ComboBoxCapacity = New System.Windows.Forms.ComboBox()
		Me.ComboBoxPowerSource = New System.Windows.Forms.ComboBox()
		Me.ComboBoxWarrantyPeriod = New System.Windows.Forms.ComboBox()
		Me.LabelCapacity = New System.Windows.Forms.Label()
		Me.LabelQualifyingModels = New System.Windows.Forms.Label()
		Me.ListBoxQualifyingModels = New System.Windows.Forms.ListBox()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonSearch = New System.Windows.Forms.Button()
		Me.LabelPowerSource = New System.Windows.Forms.Label()
		Me.LabelWarrantyPeriod = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'ComboBoxCapacity
		'
		Me.ComboBoxCapacity.FormattingEnabled = True
		Me.ComboBoxCapacity.Location = New System.Drawing.Point(12, 25)
		Me.ComboBoxCapacity.Name = "ComboBoxCapacity"
		Me.ComboBoxCapacity.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxCapacity.TabIndex = 0
		'
		'ComboBoxPowerSource
		'
		Me.ComboBoxPowerSource.FormattingEnabled = True
		Me.ComboBoxPowerSource.Location = New System.Drawing.Point(12, 65)
		Me.ComboBoxPowerSource.Name = "ComboBoxPowerSource"
		Me.ComboBoxPowerSource.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxPowerSource.TabIndex = 1
		'
		'ComboBoxWarrantyPeriod
		'
		Me.ComboBoxWarrantyPeriod.FormattingEnabled = True
		Me.ComboBoxWarrantyPeriod.Location = New System.Drawing.Point(12, 105)
		Me.ComboBoxWarrantyPeriod.Name = "ComboBoxWarrantyPeriod"
		Me.ComboBoxWarrantyPeriod.Size = New System.Drawing.Size(121, 21)
		Me.ComboBoxWarrantyPeriod.TabIndex = 2
		'
		'LabelCapacity
		'
		Me.LabelCapacity.AutoSize = True
		Me.LabelCapacity.Location = New System.Drawing.Point(12, 9)
		Me.LabelCapacity.Name = "LabelCapacity"
		Me.LabelCapacity.Size = New System.Drawing.Size(48, 13)
		Me.LabelCapacity.TabIndex = 3
		Me.LabelCapacity.Text = "Capacity"
		'
		'LabelQualifyingModels
		'
		Me.LabelQualifyingModels.AutoSize = True
		Me.LabelQualifyingModels.Location = New System.Drawing.Point(159, 9)
		Me.LabelQualifyingModels.Name = "LabelQualifyingModels"
		Me.LabelQualifyingModels.Size = New System.Drawing.Size(90, 13)
		Me.LabelQualifyingModels.TabIndex = 4
		Me.LabelQualifyingModels.Text = "Qualifying Models"
		'
		'ListBoxQualifyingModels
		'
		Me.ListBoxQualifyingModels.FormattingEnabled = True
		Me.ListBoxQualifyingModels.Location = New System.Drawing.Point(162, 25)
		Me.ListBoxQualifyingModels.Name = "ListBoxQualifyingModels"
		Me.ListBoxQualifyingModels.Size = New System.Drawing.Size(120, 95)
		Me.ListBoxQualifyingModels.TabIndex = 5
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(12, 132)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
		Me.ButtonExit.TabIndex = 6
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonSearch
		'
		Me.ButtonSearch.Location = New System.Drawing.Point(207, 132)
		Me.ButtonSearch.Name = "ButtonSearch"
		Me.ButtonSearch.Size = New System.Drawing.Size(75, 23)
		Me.ButtonSearch.TabIndex = 7
		Me.ButtonSearch.Text = "Search"
		Me.ButtonSearch.UseVisualStyleBackColor = True
		'
		'LabelPowerSource
		'
		Me.LabelPowerSource.AutoSize = True
		Me.LabelPowerSource.Location = New System.Drawing.Point(12, 49)
		Me.LabelPowerSource.Name = "LabelPowerSource"
		Me.LabelPowerSource.Size = New System.Drawing.Size(74, 13)
		Me.LabelPowerSource.TabIndex = 8
		Me.LabelPowerSource.Text = "Power Source"
		'
		'LabelWarrantyPeriod
		'
		Me.LabelWarrantyPeriod.AutoSize = True
		Me.LabelWarrantyPeriod.Location = New System.Drawing.Point(12, 89)
		Me.LabelWarrantyPeriod.Name = "LabelWarrantyPeriod"
		Me.LabelWarrantyPeriod.Size = New System.Drawing.Size(83, 13)
		Me.LabelWarrantyPeriod.TabIndex = 9
		Me.LabelWarrantyPeriod.Text = "Warranty Period"
		'
		'FormWaterHeater
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(292, 166)
		Me.Controls.Add(Me.LabelWarrantyPeriod)
		Me.Controls.Add(Me.LabelPowerSource)
		Me.Controls.Add(Me.ButtonSearch)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ListBoxQualifyingModels)
		Me.Controls.Add(Me.LabelQualifyingModels)
		Me.Controls.Add(Me.LabelCapacity)
		Me.Controls.Add(Me.ComboBoxWarrantyPeriod)
		Me.Controls.Add(Me.ComboBoxPowerSource)
		Me.Controls.Add(Me.ComboBoxCapacity)
		Me.Name = "FormWaterHeater"
		Me.Text = "Water Heater"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ComboBoxCapacity As ComboBox
	Friend WithEvents ComboBoxPowerSource As ComboBox
	Friend WithEvents ComboBoxWarrantyPeriod As ComboBox
	Friend WithEvents LabelCapacity As Label
	Friend WithEvents LabelQualifyingModels As Label
	Friend WithEvents ListBoxQualifyingModels As ListBox
	Friend WithEvents ButtonExit As Button
	Friend WithEvents ButtonSearch As Button
	Friend WithEvents LabelPowerSource As Label
	Friend WithEvents LabelWarrantyPeriod As Label
End Class
