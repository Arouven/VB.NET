<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLottoGame
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
		Me.ButtonSpin = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.TextBoxSpin1 = New System.Windows.Forms.TextBox()
		Me.TextBoxSpin2 = New System.Windows.Forms.TextBox()
		Me.TextBoxSpin3 = New System.Windows.Forms.TextBox()
		Me.TextBoxInput1 = New System.Windows.Forms.TextBox()
		Me.TextBoxInput2 = New System.Windows.Forms.TextBox()
		Me.TextBoxInput3 = New System.Windows.Forms.TextBox()
		Me.lblResult = New System.Windows.Forms.Label()
		Me.LabelInput = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'ButtonSpin
		'
		Me.ButtonSpin.Location = New System.Drawing.Point(12, 61)
		Me.ButtonSpin.Name = "ButtonSpin"
		Me.ButtonSpin.Size = New System.Drawing.Size(240, 23)
		Me.ButtonSpin.TabIndex = 0
		Me.ButtonSpin.Text = "Spin"
		Me.ButtonSpin.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(12, 186)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(240, 23)
		Me.ButtonExit.TabIndex = 1
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'TextBoxSpin1
		'
		Me.TextBoxSpin1.BackColor = System.Drawing.Color.PaleTurquoise
		Me.TextBoxSpin1.Location = New System.Drawing.Point(12, 137)
		Me.TextBoxSpin1.Name = "TextBoxSpin1"
		Me.TextBoxSpin1.Size = New System.Drawing.Size(53, 20)
		Me.TextBoxSpin1.TabIndex = 2
		'
		'TextBoxSpin2
		'
		Me.TextBoxSpin2.BackColor = System.Drawing.Color.Orange
		Me.TextBoxSpin2.Location = New System.Drawing.Point(107, 137)
		Me.TextBoxSpin2.Name = "TextBoxSpin2"
		Me.TextBoxSpin2.Size = New System.Drawing.Size(53, 20)
		Me.TextBoxSpin2.TabIndex = 3
		'
		'TextBoxSpin3
		'
		Me.TextBoxSpin3.BackColor = System.Drawing.Color.PaleGreen
		Me.TextBoxSpin3.Location = New System.Drawing.Point(199, 137)
		Me.TextBoxSpin3.Name = "TextBoxSpin3"
		Me.TextBoxSpin3.Size = New System.Drawing.Size(53, 20)
		Me.TextBoxSpin3.TabIndex = 4
		'
		'TextBoxInput1
		'
		Me.TextBoxInput1.BackColor = System.Drawing.Color.PaleTurquoise
		Me.TextBoxInput1.Location = New System.Drawing.Point(12, 35)
		Me.TextBoxInput1.Name = "TextBoxInput1"
		Me.TextBoxInput1.Size = New System.Drawing.Size(53, 20)
		Me.TextBoxInput1.TabIndex = 5
		'
		'TextBoxInput2
		'
		Me.TextBoxInput2.BackColor = System.Drawing.Color.Orange
		Me.TextBoxInput2.Location = New System.Drawing.Point(107, 35)
		Me.TextBoxInput2.Name = "TextBoxInput2"
		Me.TextBoxInput2.Size = New System.Drawing.Size(53, 20)
		Me.TextBoxInput2.TabIndex = 6
		'
		'TextBoxInput3
		'
		Me.TextBoxInput3.BackColor = System.Drawing.Color.PaleGreen
		Me.TextBoxInput3.Location = New System.Drawing.Point(199, 35)
		Me.TextBoxInput3.Name = "TextBoxInput3"
		Me.TextBoxInput3.Size = New System.Drawing.Size(53, 20)
		Me.TextBoxInput3.TabIndex = 7
		'
		'lblResult
		'
		Me.lblResult.Location = New System.Drawing.Point(9, 160)
		Me.lblResult.Name = "lblResult"
		Me.lblResult.Size = New System.Drawing.Size(243, 23)
		Me.lblResult.TabIndex = 8
		Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelInput
		'
		Me.LabelInput.Location = New System.Drawing.Point(9, 9)
		Me.LabelInput.Name = "LabelInput"
		Me.LabelInput.Size = New System.Drawing.Size(243, 23)
		Me.LabelInput.TabIndex = 9
		Me.LabelInput.Text = "Please Enter three integer numbers"
		Me.LabelInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FormLottoGame
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(264, 221)
		Me.Controls.Add(Me.LabelInput)
		Me.Controls.Add(Me.lblResult)
		Me.Controls.Add(Me.TextBoxInput3)
		Me.Controls.Add(Me.TextBoxInput2)
		Me.Controls.Add(Me.TextBoxInput1)
		Me.Controls.Add(Me.TextBoxSpin3)
		Me.Controls.Add(Me.TextBoxSpin2)
		Me.Controls.Add(Me.TextBoxSpin1)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonSpin)
		Me.Name = "FormLottoGame"
		Me.Text = "Mini Lotto Game"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ButtonSpin As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents TextBoxSpin1 As TextBox
	Friend WithEvents TextBoxSpin2 As TextBox
	Friend WithEvents TextBoxSpin3 As TextBox
	Friend WithEvents TextBoxInput1 As TextBox
	Friend WithEvents TextBoxInput2 As TextBox
	Friend WithEvents TextBoxInput3 As TextBox
	Friend WithEvents lblResult As Label
	Friend WithEvents LabelInput As Label
End Class
