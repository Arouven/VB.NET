<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
		Me.ButtonClose = New System.Windows.Forms.Button()
		Me.ButtonHide = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ButtonClose
		'
		Me.ButtonClose.Location = New System.Drawing.Point(12, 12)
		Me.ButtonClose.Name = "ButtonClose"
		Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
		Me.ButtonClose.TabIndex = 0
		Me.ButtonClose.Text = "Close"
		Me.ButtonClose.UseVisualStyleBackColor = True
		'
		'ButtonHide
		'
		Me.ButtonHide.Location = New System.Drawing.Point(93, 12)
		Me.ButtonHide.Name = "ButtonHide"
		Me.ButtonHide.Size = New System.Drawing.Size(75, 23)
		Me.ButtonHide.TabIndex = 1
		Me.ButtonHide.Text = "Hide"
		Me.ButtonHide.UseVisualStyleBackColor = True
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(180, 46)
		Me.Controls.Add(Me.ButtonHide)
		Me.Controls.Add(Me.ButtonClose)
		Me.Name = "Form2"
		Me.Text = "Form2"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ButtonClose As Button
	Friend WithEvents ButtonHide As Button
End Class
