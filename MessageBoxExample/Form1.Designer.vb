<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ButtonInput = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(210, 51)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "This program allows the user to input data from an inputbox and display the resul" &
	"t on a message box"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ButtonInput
		'
		Me.ButtonInput.Location = New System.Drawing.Point(76, 68)
		Me.ButtonInput.Name = "ButtonInput"
		Me.ButtonInput.Size = New System.Drawing.Size(75, 23)
		Me.ButtonInput.TabIndex = 1
		Me.ButtonInput.Text = "Input x"
		Me.ButtonInput.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(234, 103)
		Me.Controls.Add(Me.ButtonInput)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "y = x ^ 10"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents ButtonInput As Button
End Class
