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
		Me.ckEmpty = New System.Windows.Forms.Button()
		Me.btnToUpper = New System.Windows.Forms.Button()
		Me.btnChkMail = New System.Windows.Forms.Button()
		Me.btnChkChars = New System.Windows.Forms.Button()
		Me.txtLower = New System.Windows.Forms.TextBox()
		Me.txtUpper = New System.Windows.Forms.TextBox()
		Me.txtFname = New System.Windows.Forms.TextBox()
		Me.txtChk = New System.Windows.Forms.TextBox()
		Me.txtFirst = New System.Windows.Forms.TextBox()
		Me.txtEmail = New System.Windows.Forms.TextBox()
		Me.txtSubstr = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'ckEmpty
		'
		Me.ckEmpty.Location = New System.Drawing.Point(12, 117)
		Me.ckEmpty.Name = "ckEmpty"
		Me.ckEmpty.Size = New System.Drawing.Size(206, 23)
		Me.ckEmpty.TabIndex = 0
		Me.ckEmpty.Text = "Check if Empty"
		Me.ckEmpty.UseVisualStyleBackColor = True
		'
		'btnToUpper
		'
		Me.btnToUpper.Location = New System.Drawing.Point(12, 38)
		Me.btnToUpper.Name = "btnToUpper"
		Me.btnToUpper.Size = New System.Drawing.Size(206, 23)
		Me.btnToUpper.TabIndex = 1
		Me.btnToUpper.Text = "ToUpper"
		Me.btnToUpper.UseVisualStyleBackColor = True
		'
		'btnChkMail
		'
		Me.btnChkMail.Location = New System.Drawing.Point(12, 276)
		Me.btnChkMail.Name = "btnChkMail"
		Me.btnChkMail.Size = New System.Drawing.Size(206, 23)
		Me.btnChkMail.TabIndex = 2
		Me.btnChkMail.Text = "Check Email format"
		Me.btnChkMail.UseVisualStyleBackColor = True
		'
		'btnChkChars
		'
		Me.btnChkChars.Location = New System.Drawing.Point(12, 198)
		Me.btnChkChars.Name = "btnChkChars"
		Me.btnChkChars.Size = New System.Drawing.Size(206, 23)
		Me.btnChkChars.TabIndex = 3
		Me.btnChkChars.Text = "Check Char"
		Me.btnChkChars.UseVisualStyleBackColor = True
		'
		'txtLower
		'
		Me.txtLower.Location = New System.Drawing.Point(12, 12)
		Me.txtLower.Name = "txtLower"
		Me.txtLower.Size = New System.Drawing.Size(100, 20)
		Me.txtLower.TabIndex = 4
		'
		'txtUpper
		'
		Me.txtUpper.Location = New System.Drawing.Point(118, 12)
		Me.txtUpper.Name = "txtUpper"
		Me.txtUpper.Size = New System.Drawing.Size(100, 20)
		Me.txtUpper.TabIndex = 5
		'
		'txtFname
		'
		Me.txtFname.Location = New System.Drawing.Point(12, 91)
		Me.txtFname.Name = "txtFname"
		Me.txtFname.Size = New System.Drawing.Size(100, 20)
		Me.txtFname.TabIndex = 6
		'
		'txtChk
		'
		Me.txtChk.Location = New System.Drawing.Point(118, 91)
		Me.txtChk.Name = "txtChk"
		Me.txtChk.Size = New System.Drawing.Size(100, 20)
		Me.txtChk.TabIndex = 7
		'
		'txtFirst
		'
		Me.txtFirst.Location = New System.Drawing.Point(12, 172)
		Me.txtFirst.Name = "txtFirst"
		Me.txtFirst.Size = New System.Drawing.Size(206, 20)
		Me.txtFirst.TabIndex = 8
		'
		'txtEmail
		'
		Me.txtEmail.Location = New System.Drawing.Point(12, 250)
		Me.txtEmail.Name = "txtEmail"
		Me.txtEmail.Size = New System.Drawing.Size(206, 20)
		Me.txtEmail.TabIndex = 9
		'
		'txtSubstr
		'
		Me.txtSubstr.Location = New System.Drawing.Point(64, 346)
		Me.txtSubstr.Name = "txtSubstr"
		Me.txtSubstr.Size = New System.Drawing.Size(100, 20)
		Me.txtSubstr.TabIndex = 10
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(231, 483)
		Me.Controls.Add(Me.txtSubstr)
		Me.Controls.Add(Me.txtEmail)
		Me.Controls.Add(Me.txtFirst)
		Me.Controls.Add(Me.txtChk)
		Me.Controls.Add(Me.txtFname)
		Me.Controls.Add(Me.txtUpper)
		Me.Controls.Add(Me.txtLower)
		Me.Controls.Add(Me.btnChkChars)
		Me.Controls.Add(Me.btnChkMail)
		Me.Controls.Add(Me.btnToUpper)
		Me.Controls.Add(Me.ckEmpty)
		Me.Name = "Form1"
		Me.Text = "String Manipulation"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ckEmpty As Button
	Friend WithEvents btnToUpper As Button
	Friend WithEvents btnChkMail As Button
	Friend WithEvents btnChkChars As Button
	Friend WithEvents txtLower As TextBox
	Friend WithEvents txtUpper As TextBox
	Friend WithEvents txtFname As TextBox
	Friend WithEvents txtChk As TextBox
	Friend WithEvents txtFirst As TextBox
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents txtSubstr As TextBox
End Class
