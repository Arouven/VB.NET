<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControlProperties
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
		Me.ButtonChange = New System.Windows.Forms.Button()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'ButtonChange
		'
		Me.ButtonChange.Location = New System.Drawing.Point(152, 89)
		Me.ButtonChange.Name = "ButtonChange"
		Me.ButtonChange.Size = New System.Drawing.Size(75, 23)
		Me.ButtonChange.TabIndex = 0
		Me.ButtonChange.Text = "Change"
		Me.ButtonChange.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(12, 23)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Button1"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(127, 25)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 20)
		Me.TextBox1.TabIndex = 2
		'
		'FormControlProperties
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(252, 130)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.ButtonChange)
		Me.Name = "FormControlProperties"
		Me.Text = "Control Properties"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonChange As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox1 As TextBox
End Class
