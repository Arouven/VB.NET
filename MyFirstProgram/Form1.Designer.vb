<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyFirstProgram
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
		Me.LblDisplayedText = New System.Windows.Forms.Label()
		Me.TxtDisplay = New System.Windows.Forms.TextBox()
		Me.BtnDisplay = New System.Windows.Forms.Button()
		Me.BtnRefresh = New System.Windows.Forms.Button()
		Me.BtnExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'LblDisplayedText
		'
		Me.LblDisplayedText.AutoSize = True
		Me.LblDisplayedText.Location = New System.Drawing.Point(23, 41)
		Me.LblDisplayedText.Name = "LblDisplayedText"
		Me.LblDisplayedText.Size = New System.Drawing.Size(77, 13)
		Me.LblDisplayedText.TabIndex = 0
		Me.LblDisplayedText.Text = "Displayed Text"
		'
		'TxtDisplay
		'
		Me.TxtDisplay.Location = New System.Drawing.Point(139, 38)
		Me.TxtDisplay.Name = "TxtDisplay"
		Me.TxtDisplay.Size = New System.Drawing.Size(103, 20)
		Me.TxtDisplay.TabIndex = 1
		'
		'BtnDisplay
		'
		Me.BtnDisplay.Location = New System.Drawing.Point(26, 94)
		Me.BtnDisplay.Name = "BtnDisplay"
		Me.BtnDisplay.Size = New System.Drawing.Size(75, 23)
		Me.BtnDisplay.TabIndex = 2
		Me.BtnDisplay.Text = "Display"
		Me.BtnDisplay.UseVisualStyleBackColor = True
		'
		'BtnRefresh
		'
		Me.BtnRefresh.Location = New System.Drawing.Point(167, 94)
		Me.BtnRefresh.Name = "BtnRefresh"
		Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
		Me.BtnRefresh.TabIndex = 3
		Me.BtnRefresh.Text = "Refresh"
		Me.BtnRefresh.UseVisualStyleBackColor = True
		'
		'BtnExit
		'
		Me.BtnExit.Location = New System.Drawing.Point(96, 136)
		Me.BtnExit.Name = "BtnExit"
		Me.BtnExit.Size = New System.Drawing.Size(75, 23)
		Me.BtnExit.TabIndex = 4
		Me.BtnExit.Text = "Exit"
		Me.BtnExit.UseVisualStyleBackColor = True
		'
		'MyFirstProgram
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(262, 179)
		Me.Controls.Add(Me.BtnExit)
		Me.Controls.Add(Me.BtnRefresh)
		Me.Controls.Add(Me.BtnDisplay)
		Me.Controls.Add(Me.TxtDisplay)
		Me.Controls.Add(Me.LblDisplayedText)
		Me.Name = "MyFirstProgram"
		Me.Text = "My First Program"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LblDisplayedText As Label
	Friend WithEvents TxtDisplay As TextBox
	Friend WithEvents BtnDisplay As Button
	Friend WithEvents BtnRefresh As Button
	Friend WithEvents BtnExit As Button
End Class
