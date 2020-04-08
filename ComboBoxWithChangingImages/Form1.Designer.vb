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
		Me.picDrink = New System.Windows.Forms.PictureBox()
		Me.cboDrink = New System.Windows.Forms.ComboBox()
		Me.btnExit = New System.Windows.Forms.Button()
		CType(Me.picDrink, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 9)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 13)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Select a drink:"
		'
		'picDrink
		'
		Me.picDrink.Location = New System.Drawing.Point(139, 12)
		Me.picDrink.Name = "picDrink"
		Me.picDrink.Size = New System.Drawing.Size(156, 105)
		Me.picDrink.TabIndex = 1
		Me.picDrink.TabStop = False
		'
		'cboDrink
		'
		Me.cboDrink.FormattingEnabled = True
		Me.cboDrink.Location = New System.Drawing.Point(12, 25)
		Me.cboDrink.Name = "cboDrink"
		Me.cboDrink.Size = New System.Drawing.Size(121, 21)
		Me.cboDrink.TabIndex = 2
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(15, 94)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(118, 23)
		Me.btnExit.TabIndex = 3
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(307, 129)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.cboDrink)
		Me.Controls.Add(Me.picDrink)
		Me.Controls.Add(Me.Label1)
		Me.Name = "Form1"
		Me.Text = "Select drink"
		CType(Me.picDrink, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents picDrink As PictureBox
	Friend WithEvents cboDrink As ComboBox
	Friend WithEvents btnExit As Button
End Class
