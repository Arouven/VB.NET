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
		Me.GroupBoxChangeCase = New System.Windows.Forms.GroupBox()
		Me.RadioButtonUC = New System.Windows.Forms.RadioButton()
		Me.RadioButtonLC = New System.Windows.Forms.RadioButton()
		Me.RadioButtonPC = New System.Windows.Forms.RadioButton()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonOK = New System.Windows.Forms.Button()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.GroupBoxChangeCase.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBoxChangeCase
		'
		Me.GroupBoxChangeCase.Controls.Add(Me.RadioButtonPC)
		Me.GroupBoxChangeCase.Controls.Add(Me.RadioButtonLC)
		Me.GroupBoxChangeCase.Controls.Add(Me.RadioButtonUC)
		Me.GroupBoxChangeCase.Location = New System.Drawing.Point(12, 12)
		Me.GroupBoxChangeCase.Name = "GroupBoxChangeCase"
		Me.GroupBoxChangeCase.Size = New System.Drawing.Size(237, 95)
		Me.GroupBoxChangeCase.TabIndex = 0
		Me.GroupBoxChangeCase.TabStop = False
		Me.GroupBoxChangeCase.Text = "Change Case"
		'
		'RadioButtonUC
		'
		Me.RadioButtonUC.AutoSize = True
		Me.RadioButtonUC.Location = New System.Drawing.Point(81, 19)
		Me.RadioButtonUC.Name = "RadioButtonUC"
		Me.RadioButtonUC.Size = New System.Drawing.Size(81, 17)
		Me.RadioButtonUC.TabIndex = 0
		Me.RadioButtonUC.Text = "Upper Case"
		Me.RadioButtonUC.UseVisualStyleBackColor = True
		'
		'RadioButtonLC
		'
		Me.RadioButtonLC.AutoSize = True
		Me.RadioButtonLC.Location = New System.Drawing.Point(81, 42)
		Me.RadioButtonLC.Name = "RadioButtonLC"
		Me.RadioButtonLC.Size = New System.Drawing.Size(81, 17)
		Me.RadioButtonLC.TabIndex = 1
		Me.RadioButtonLC.Text = "Lower Case"
		Me.RadioButtonLC.UseVisualStyleBackColor = True
		'
		'RadioButtonPC
		'
		Me.RadioButtonPC.AutoSize = True
		Me.RadioButtonPC.Checked = True
		Me.RadioButtonPC.Location = New System.Drawing.Point(81, 65)
		Me.RadioButtonPC.Name = "RadioButtonPC"
		Me.RadioButtonPC.Size = New System.Drawing.Size(83, 17)
		Me.RadioButtonPC.TabIndex = 2
		Me.RadioButtonPC.TabStop = True
		Me.RadioButtonPC.Text = "Proper Case"
		Me.RadioButtonPC.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(12, 113)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
		Me.ButtonExit.TabIndex = 1
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonOK
		'
		Me.ButtonOK.Location = New System.Drawing.Point(174, 113)
		Me.ButtonOK.Name = "ButtonOK"
		Me.ButtonOK.Size = New System.Drawing.Size(75, 23)
		Me.ButtonOK.TabIndex = 2
		Me.ButtonOK.Text = "OK"
		Me.ButtonOK.UseVisualStyleBackColor = True
		'
		'ButtonCancel
		'
		Me.ButtonCancel.Location = New System.Drawing.Point(93, 113)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCancel.TabIndex = 3
		Me.ButtonCancel.Text = "Cancel"
		Me.ButtonCancel.UseVisualStyleBackColor = True
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(260, 146)
		Me.Controls.Add(Me.ButtonCancel)
		Me.Controls.Add(Me.ButtonOK)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.GroupBoxChangeCase)
		Me.Name = "Form2"
		Me.Text = "Form2"
		Me.GroupBoxChangeCase.ResumeLayout(False)
		Me.GroupBoxChangeCase.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBoxChangeCase As GroupBox
	Friend WithEvents RadioButtonPC As RadioButton
	Friend WithEvents RadioButtonLC As RadioButton
	Friend WithEvents RadioButtonUC As RadioButton
	Friend WithEvents ButtonExit As Button
	Friend WithEvents ButtonOK As Button
	Friend WithEvents ButtonCancel As Button
End Class
