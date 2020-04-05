<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDigitalClock
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
		Me.components = New System.ComponentModel.Container()
		Me.LabelDigitalClock = New System.Windows.Forms.Label()
		Me.TextBoxDigitalClock = New System.Windows.Forms.TextBox()
		Me.ButtonStartTime = New System.Windows.Forms.Button()
		Me.ButtonEndTime = New System.Windows.Forms.Button()
		Me.TextBoxStartTime = New System.Windows.Forms.TextBox()
		Me.TextBoxEndTime = New System.Windows.Forms.TextBox()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.Timer = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'LabelDigitalClock
		'
		Me.LabelDigitalClock.AutoSize = True
		Me.LabelDigitalClock.Location = New System.Drawing.Point(13, 13)
		Me.LabelDigitalClock.Name = "LabelDigitalClock"
		Me.LabelDigitalClock.Size = New System.Drawing.Size(66, 13)
		Me.LabelDigitalClock.TabIndex = 0
		Me.LabelDigitalClock.Text = "Digital Clock"
		'
		'TextBoxDigitalClock
		'
		Me.TextBoxDigitalClock.Enabled = False
		Me.TextBoxDigitalClock.Location = New System.Drawing.Point(137, 10)
		Me.TextBoxDigitalClock.Name = "TextBoxDigitalClock"
		Me.TextBoxDigitalClock.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxDigitalClock.TabIndex = 1
		'
		'ButtonStartTime
		'
		Me.ButtonStartTime.Location = New System.Drawing.Point(16, 34)
		Me.ButtonStartTime.Name = "ButtonStartTime"
		Me.ButtonStartTime.Size = New System.Drawing.Size(75, 23)
		Me.ButtonStartTime.TabIndex = 2
		Me.ButtonStartTime.Text = "Start Time"
		Me.ButtonStartTime.UseVisualStyleBackColor = True
		'
		'ButtonEndTime
		'
		Me.ButtonEndTime.Location = New System.Drawing.Point(16, 63)
		Me.ButtonEndTime.Name = "ButtonEndTime"
		Me.ButtonEndTime.Size = New System.Drawing.Size(75, 23)
		Me.ButtonEndTime.TabIndex = 3
		Me.ButtonEndTime.Text = "End Time"
		Me.ButtonEndTime.UseVisualStyleBackColor = True
		'
		'TextBoxStartTime
		'
		Me.TextBoxStartTime.Enabled = False
		Me.TextBoxStartTime.Location = New System.Drawing.Point(137, 36)
		Me.TextBoxStartTime.Name = "TextBoxStartTime"
		Me.TextBoxStartTime.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxStartTime.TabIndex = 4
		'
		'TextBoxEndTime
		'
		Me.TextBoxEndTime.Enabled = False
		Me.TextBoxEndTime.Location = New System.Drawing.Point(137, 65)
		Me.TextBoxEndTime.Name = "TextBoxEndTime"
		Me.TextBoxEndTime.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxEndTime.TabIndex = 5
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(162, 91)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
		Me.ButtonExit.TabIndex = 6
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'Timer
		'
		'
		'FormDigitalClock
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(255, 130)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.TextBoxEndTime)
		Me.Controls.Add(Me.TextBoxStartTime)
		Me.Controls.Add(Me.ButtonEndTime)
		Me.Controls.Add(Me.ButtonStartTime)
		Me.Controls.Add(Me.TextBoxDigitalClock)
		Me.Controls.Add(Me.LabelDigitalClock)
		Me.Name = "FormDigitalClock"
		Me.Text = "Digital Clock"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelDigitalClock As Label
	Friend WithEvents TextBoxDigitalClock As TextBox
	Friend WithEvents ButtonStartTime As Button
	Friend WithEvents ButtonEndTime As Button
	Friend WithEvents TextBoxStartTime As TextBox
	Friend WithEvents TextBoxEndTime As TextBox
	Friend WithEvents ButtonExit As Button
	Friend WithEvents Timer As Timer
End Class
