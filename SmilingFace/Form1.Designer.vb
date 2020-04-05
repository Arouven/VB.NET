<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSmilingFace
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
		Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
		Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
		Me.LabelO = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'HScrollBar1
		'
		Me.HScrollBar1.Location = New System.Drawing.Point(9, 9)
		Me.HScrollBar1.Name = "HScrollBar1"
		Me.HScrollBar1.Size = New System.Drawing.Size(234, 17)
		Me.HScrollBar1.TabIndex = 0
		'
		'VScrollBar1
		'
		Me.VScrollBar1.Location = New System.Drawing.Point(243, 26)
		Me.VScrollBar1.Name = "VScrollBar1"
		Me.VScrollBar1.Size = New System.Drawing.Size(17, 196)
		Me.VScrollBar1.TabIndex = 1
		'
		'LabelO
		'
		Me.LabelO.AutoSize = True
		Me.LabelO.Location = New System.Drawing.Point(115, 113)
		Me.LabelO.Name = "LabelO"
		Me.LabelO.Size = New System.Drawing.Size(15, 13)
		Me.LabelO.TabIndex = 2
		Me.LabelO.Text = "O"
		'
		'FormSmilingFace
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(271, 231)
		Me.Controls.Add(Me.LabelO)
		Me.Controls.Add(Me.VScrollBar1)
		Me.Controls.Add(Me.HScrollBar1)
		Me.Name = "FormSmilingFace"
		Me.Text = "Smiling Face"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents HScrollBar1 As HScrollBar
	Friend WithEvents VScrollBar1 As VScrollBar
	Friend WithEvents LabelO As Label
End Class
