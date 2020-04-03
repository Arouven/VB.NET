<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGlobalLocal
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
		Me.ButtonCountJoe = New System.Windows.Forms.Button()
		Me.ButtonCountJack = New System.Windows.Forms.Button()
		Me.ButtonCountJohn = New System.Windows.Forms.Button()
		Me.TextBoxCountJoe = New System.Windows.Forms.TextBox()
		Me.TextBoxCountJack = New System.Windows.Forms.TextBox()
		Me.TextBoxCountJohn = New System.Windows.Forms.TextBox()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ButtonCountJoe
		'
		Me.ButtonCountJoe.Location = New System.Drawing.Point(12, 12)
		Me.ButtonCountJoe.Name = "ButtonCountJoe"
		Me.ButtonCountJoe.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCountJoe.TabIndex = 0
		Me.ButtonCountJoe.Text = "Count Joe"
		Me.ButtonCountJoe.UseVisualStyleBackColor = True
		'
		'ButtonCountJack
		'
		Me.ButtonCountJack.Location = New System.Drawing.Point(12, 41)
		Me.ButtonCountJack.Name = "ButtonCountJack"
		Me.ButtonCountJack.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCountJack.TabIndex = 1
		Me.ButtonCountJack.Text = "Count Jack"
		Me.ButtonCountJack.UseVisualStyleBackColor = True
		'
		'ButtonCountJohn
		'
		Me.ButtonCountJohn.Location = New System.Drawing.Point(12, 70)
		Me.ButtonCountJohn.Name = "ButtonCountJohn"
		Me.ButtonCountJohn.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCountJohn.TabIndex = 2
		Me.ButtonCountJohn.Text = "Count John"
		Me.ButtonCountJohn.UseVisualStyleBackColor = True
		'
		'TextBoxCountJoe
		'
		Me.TextBoxCountJoe.Location = New System.Drawing.Point(93, 14)
		Me.TextBoxCountJoe.Name = "TextBoxCountJoe"
		Me.TextBoxCountJoe.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxCountJoe.TabIndex = 3
		'
		'TextBoxCountJack
		'
		Me.TextBoxCountJack.Location = New System.Drawing.Point(93, 43)
		Me.TextBoxCountJack.Name = "TextBoxCountJack"
		Me.TextBoxCountJack.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxCountJack.TabIndex = 4
		'
		'TextBoxCountJohn
		'
		Me.TextBoxCountJohn.Location = New System.Drawing.Point(93, 72)
		Me.TextBoxCountJohn.Name = "TextBoxCountJohn"
		Me.TextBoxCountJohn.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxCountJohn.TabIndex = 5
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(12, 99)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(181, 23)
		Me.ButtonExit.TabIndex = 6
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'FormGlobalLocal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(207, 131)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.TextBoxCountJohn)
		Me.Controls.Add(Me.TextBoxCountJack)
		Me.Controls.Add(Me.TextBoxCountJoe)
		Me.Controls.Add(Me.ButtonCountJohn)
		Me.Controls.Add(Me.ButtonCountJack)
		Me.Controls.Add(Me.ButtonCountJoe)
		Me.Name = "FormGlobalLocal"
		Me.Text = "Global Local Variables"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonCountJoe As Button
	Friend WithEvents ButtonCountJack As Button
	Friend WithEvents ButtonCountJohn As Button
	Friend WithEvents TextBoxCountJoe As TextBox
	Friend WithEvents TextBoxCountJack As TextBox
	Friend WithEvents TextBoxCountJohn As TextBox
	Friend WithEvents ButtonExit As Button
End Class
