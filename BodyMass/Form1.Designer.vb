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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBoxWeight = New System.Windows.Forms.TextBox()
		Me.TextBoxHeight = New System.Windows.Forms.TextBox()
		Me.ButtonCalculate = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(61, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Weight(lb): "
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 41)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(55, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Height(in):"
		'
		'TextBoxWeight
		'
		Me.TextBoxWeight.Location = New System.Drawing.Point(116, 12)
		Me.TextBoxWeight.Name = "TextBoxWeight"
		Me.TextBoxWeight.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxWeight.TabIndex = 2
		'
		'TextBoxHeight
		'
		Me.TextBoxHeight.Location = New System.Drawing.Point(116, 38)
		Me.TextBoxHeight.Name = "TextBoxHeight"
		Me.TextBoxHeight.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxHeight.TabIndex = 3
		'
		'ButtonCalculate
		'
		Me.ButtonCalculate.Location = New System.Drawing.Point(15, 73)
		Me.ButtonCalculate.Name = "ButtonCalculate"
		Me.ButtonCalculate.Size = New System.Drawing.Size(201, 23)
		Me.ButtonCalculate.TabIndex = 4
		Me.ButtonCalculate.Text = "Calculate"
		Me.ButtonCalculate.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(233, 108)
		Me.Controls.Add(Me.ButtonCalculate)
		Me.Controls.Add(Me.TextBoxHeight)
		Me.Controls.Add(Me.TextBoxWeight)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "BMI"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBoxWeight As TextBox
	Friend WithEvents TextBoxHeight As TextBox
	Friend WithEvents ButtonCalculate As Button
End Class
