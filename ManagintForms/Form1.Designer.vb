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
		Me.ButtonOpenForm2 = New System.Windows.Forms.Button()
		Me.ButtonDialogForm = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ButtonOpenForm2
		'
		Me.ButtonOpenForm2.Location = New System.Drawing.Point(12, 12)
		Me.ButtonOpenForm2.Name = "ButtonOpenForm2"
		Me.ButtonOpenForm2.Size = New System.Drawing.Size(75, 23)
		Me.ButtonOpenForm2.TabIndex = 0
		Me.ButtonOpenForm2.Text = "Open Form2"
		Me.ButtonOpenForm2.UseVisualStyleBackColor = True
		'
		'ButtonDialogForm
		'
		Me.ButtonDialogForm.Location = New System.Drawing.Point(93, 12)
		Me.ButtonDialogForm.Name = "ButtonDialogForm"
		Me.ButtonDialogForm.Size = New System.Drawing.Size(75, 23)
		Me.ButtonDialogForm.TabIndex = 1
		Me.ButtonDialogForm.Text = "Dialog Form"
		Me.ButtonDialogForm.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(176, 45)
		Me.Controls.Add(Me.ButtonDialogForm)
		Me.Controls.Add(Me.ButtonOpenForm2)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ButtonOpenForm2 As Button
	Friend WithEvents ButtonDialogForm As Button
End Class
