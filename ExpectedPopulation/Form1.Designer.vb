<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPopulationGrowth
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
		Me.ButtonGenerateGrowth = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ListBoxYearPopulation = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'ButtonGenerateGrowth
		'
		Me.ButtonGenerateGrowth.Location = New System.Drawing.Point(12, 12)
		Me.ButtonGenerateGrowth.Name = "ButtonGenerateGrowth"
		Me.ButtonGenerateGrowth.Size = New System.Drawing.Size(108, 23)
		Me.ButtonGenerateGrowth.TabIndex = 0
		Me.ButtonGenerateGrowth.Text = "Generate Growth"
		Me.ButtonGenerateGrowth.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(12, 136)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(108, 23)
		Me.ButtonExit.TabIndex = 1
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ListBoxYearPopulation
		'
		Me.ListBoxYearPopulation.FormattingEnabled = True
		Me.ListBoxYearPopulation.Location = New System.Drawing.Point(126, 12)
		Me.ListBoxYearPopulation.Name = "ListBoxYearPopulation"
		Me.ListBoxYearPopulation.Size = New System.Drawing.Size(211, 147)
		Me.ListBoxYearPopulation.TabIndex = 2
		'
		'FormPopulationGrowth
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(351, 170)
		Me.Controls.Add(Me.ListBoxYearPopulation)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonGenerateGrowth)
		Me.Name = "FormPopulationGrowth"
		Me.Text = "Population Growth"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ButtonGenerateGrowth As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents ListBoxYearPopulation As ListBox
End Class
