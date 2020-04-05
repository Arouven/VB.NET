<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPizzaOrder
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
		Me.ButtonBuildPizza = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ButtonBuildPizza
		'
		Me.ButtonBuildPizza.Location = New System.Drawing.Point(46, 224)
		Me.ButtonBuildPizza.Name = "ButtonBuildPizza"
		Me.ButtonBuildPizza.Size = New System.Drawing.Size(75, 23)
		Me.ButtonBuildPizza.TabIndex = 0
		Me.ButtonBuildPizza.Text = "Build Pizza"
		Me.ButtonBuildPizza.UseVisualStyleBackColor = True
		'
		'FormPizzaOrder
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(406, 310)
		Me.Controls.Add(Me.ButtonBuildPizza)
		Me.Name = "FormPizzaOrder"
		Me.Text = "Pizza Order"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ButtonBuildPizza As Button
End Class
