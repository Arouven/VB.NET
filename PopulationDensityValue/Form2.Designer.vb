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
		Me.TxtState = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtArea = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtPop = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.ListBoxDensity = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'TxtState
		'
		Me.TxtState.Location = New System.Drawing.Point(114, 12)
		Me.TxtState.Name = "TxtState"
		Me.TxtState.Size = New System.Drawing.Size(150, 20)
		Me.TxtState.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Enter State:"
		'
		'TxtArea
		'
		Me.TxtArea.Location = New System.Drawing.Point(114, 64)
		Me.TxtArea.Name = "TxtArea"
		Me.TxtArea.Size = New System.Drawing.Size(150, 20)
		Me.TxtArea.TabIndex = 2
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 41)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(88, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Enter Population:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 67)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(60, 13)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Enter Area:"
		'
		'TxtPop
		'
		Me.TxtPop.Location = New System.Drawing.Point(114, 38)
		Me.TxtPop.Name = "TxtPop"
		Me.TxtPop.Size = New System.Drawing.Size(150, 20)
		Me.TxtPop.TabIndex = 5
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(15, 112)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(88, 23)
		Me.Button1.TabIndex = 7
		Me.Button1.Text = "Display Density"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(15, 165)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(114, 23)
		Me.Button2.TabIndex = 8
		Me.Button2.Text = "Clear"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(150, 165)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(114, 23)
		Me.Button3.TabIndex = 9
		Me.Button3.Text = "Exit"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'ListBoxDensity
		'
		Me.ListBoxDensity.FormattingEnabled = True
		Me.ListBoxDensity.Location = New System.Drawing.Point(114, 90)
		Me.ListBoxDensity.Name = "ListBoxDensity"
		Me.ListBoxDensity.Size = New System.Drawing.Size(150, 69)
		Me.ListBoxDensity.TabIndex = 10
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(278, 201)
		Me.Controls.Add(Me.ListBoxDensity)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TxtPop)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TxtArea)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.TxtState)
		Me.Name = "Form2"
		Me.Text = "Population Density 'pass by ref'"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TxtState As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents TxtArea As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TxtPop As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
	Friend WithEvents Button3 As Button
	Friend WithEvents ListBoxDensity As ListBox
End Class
