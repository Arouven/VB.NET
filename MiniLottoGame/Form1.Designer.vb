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
		Me.btnSpin = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.txtNumber1 = New System.Windows.Forms.TextBox()
		Me.txtNumber2 = New System.Windows.Forms.TextBox()
		Me.txtNumber3 = New System.Windows.Forms.TextBox()
		Me.txtNum1 = New System.Windows.Forms.TextBox()
		Me.txtNum2 = New System.Windows.Forms.TextBox()
		Me.txtNum3 = New System.Windows.Forms.TextBox()
		Me.lblResult = New System.Windows.Forms.Label()
		Me.LabelInput = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnSpin
		'
		Me.btnSpin.Location = New System.Drawing.Point(12, 61)
		Me.btnSpin.Name = "btnSpin"
		Me.btnSpin.Size = New System.Drawing.Size(240, 23)
		Me.btnSpin.TabIndex = 0
		Me.btnSpin.Text = "Spin"
		Me.btnSpin.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(12, 186)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(240, 23)
		Me.btnExit.TabIndex = 1
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'txtNumber1
		'
		Me.txtNumber1.BackColor = System.Drawing.Color.PaleTurquoise
		Me.txtNumber1.Location = New System.Drawing.Point(12, 137)
		Me.txtNumber1.Name = "txtNumber1"
		Me.txtNumber1.Size = New System.Drawing.Size(53, 20)
		Me.txtNumber1.TabIndex = 2
		'
		'txtNumber2
		'
		Me.txtNumber2.BackColor = System.Drawing.Color.Orange
		Me.txtNumber2.Location = New System.Drawing.Point(107, 137)
		Me.txtNumber2.Name = "txtNumber2"
		Me.txtNumber2.Size = New System.Drawing.Size(53, 20)
		Me.txtNumber2.TabIndex = 3
		'
		'txtNumber3
		'
		Me.txtNumber3.BackColor = System.Drawing.Color.PaleGreen
		Me.txtNumber3.Location = New System.Drawing.Point(199, 137)
		Me.txtNumber3.Name = "txtNumber3"
		Me.txtNumber3.Size = New System.Drawing.Size(53, 20)
		Me.txtNumber3.TabIndex = 4
		'
		'txtNum1
		'
		Me.txtNum1.BackColor = System.Drawing.Color.PaleTurquoise
		Me.txtNum1.Location = New System.Drawing.Point(12, 35)
		Me.txtNum1.Name = "txtNum1"
		Me.txtNum1.Size = New System.Drawing.Size(53, 20)
		Me.txtNum1.TabIndex = 5
		'
		'txtNum2
		'
		Me.txtNum2.BackColor = System.Drawing.Color.Orange
		Me.txtNum2.Location = New System.Drawing.Point(107, 35)
		Me.txtNum2.Name = "txtNum2"
		Me.txtNum2.Size = New System.Drawing.Size(53, 20)
		Me.txtNum2.TabIndex = 6
		'
		'txtNum3
		'
		Me.txtNum3.BackColor = System.Drawing.Color.PaleGreen
		Me.txtNum3.Location = New System.Drawing.Point(199, 35)
		Me.txtNum3.Name = "txtNum3"
		Me.txtNum3.Size = New System.Drawing.Size(53, 20)
		Me.txtNum3.TabIndex = 7
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
		Me.Controls.Add(Me.txtNum3)
		Me.Controls.Add(Me.txtNum2)
		Me.Controls.Add(Me.txtNum1)
		Me.Controls.Add(Me.txtNumber3)
		Me.Controls.Add(Me.txtNumber2)
		Me.Controls.Add(Me.txtNumber1)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnSpin)
		Me.Name = "FormLottoGame"
		Me.Text = "Mini Lotto Game"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnSpin As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents txtNumber1 As TextBox
	Friend WithEvents txtNumber2 As TextBox
	Friend WithEvents txtNumber3 As TextBox
	Friend WithEvents txtNum1 As TextBox
	Friend WithEvents txtNum2 As TextBox
	Friend WithEvents txtNum3 As TextBox
	Friend WithEvents lblResult As Label
	Friend WithEvents LabelInput As Label
End Class
