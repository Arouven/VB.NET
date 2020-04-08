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
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TextboxRadius = New System.Windows.Forms.TextBox()
		Me.TectBoxHeight = New System.Windows.Forms.TextBox()
		Me.TextBoxArea = New System.Windows.Forms.TextBox()
		Me.ButtonSurfaceArea = New System.Windows.Forms.Button()
		Me.ButtonVolume = New System.Windows.Forms.Button()
		Me.TextBoxVolume = New System.Windows.Forms.TextBox()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(244, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Calculating Surface Area and Volume of a Cylinder"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 41)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(68, 13)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Enter Radius"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 63)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(66, 13)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Enter Height"
		'
		'TextboxRadius
		'
		Me.TextboxRadius.Location = New System.Drawing.Point(156, 34)
		Me.TextboxRadius.Name = "TextboxRadius"
		Me.TextboxRadius.Size = New System.Drawing.Size(100, 20)
		Me.TextboxRadius.TabIndex = 3
		'
		'TectBoxHeight
		'
		Me.TectBoxHeight.Location = New System.Drawing.Point(156, 60)
		Me.TectBoxHeight.Name = "TectBoxHeight"
		Me.TectBoxHeight.Size = New System.Drawing.Size(100, 20)
		Me.TectBoxHeight.TabIndex = 4
		'
		'TextBoxArea
		'
		Me.TextBoxArea.Location = New System.Drawing.Point(156, 96)
		Me.TextBoxArea.Name = "TextBoxArea"
		Me.TextBoxArea.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxArea.TabIndex = 5
		'
		'ButtonSurfaceArea
		'
		Me.ButtonSurfaceArea.Location = New System.Drawing.Point(15, 94)
		Me.ButtonSurfaceArea.Name = "ButtonSurfaceArea"
		Me.ButtonSurfaceArea.Size = New System.Drawing.Size(88, 23)
		Me.ButtonSurfaceArea.TabIndex = 6
		Me.ButtonSurfaceArea.Text = "Surface Area"
		Me.ButtonSurfaceArea.UseVisualStyleBackColor = True
		'
		'ButtonVolume
		'
		Me.ButtonVolume.Enabled = False
		Me.ButtonVolume.Location = New System.Drawing.Point(15, 123)
		Me.ButtonVolume.Name = "ButtonVolume"
		Me.ButtonVolume.Size = New System.Drawing.Size(88, 23)
		Me.ButtonVolume.TabIndex = 7
		Me.ButtonVolume.Text = "Volume"
		Me.ButtonVolume.UseVisualStyleBackColor = True
		'
		'TextBoxVolume
		'
		Me.TextBoxVolume.Location = New System.Drawing.Point(156, 125)
		Me.TextBoxVolume.Name = "TextBoxVolume"
		Me.TextBoxVolume.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxVolume.TabIndex = 8
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(168, 153)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(88, 23)
		Me.ButtonExit.TabIndex = 9
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(271, 188)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.TextBoxVolume)
		Me.Controls.Add(Me.ButtonVolume)
		Me.Controls.Add(Me.ButtonSurfaceArea)
		Me.Controls.Add(Me.TextBoxArea)
		Me.Controls.Add(Me.TectBoxHeight)
		Me.Controls.Add(Me.TextboxRadius)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Area and Volume"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents TextboxRadius As TextBox
	Friend WithEvents TectBoxHeight As TextBox
	Friend WithEvents TextBoxArea As TextBox
	Friend WithEvents ButtonSurfaceArea As Button
	Friend WithEvents ButtonVolume As Button
	Friend WithEvents TextBoxVolume As TextBox
	Friend WithEvents ButtonExit As Button
End Class
