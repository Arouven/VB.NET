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
		Me.TextBoxSomeText = New System.Windows.Forms.TextBox()
		Me.ButtonShow = New System.Windows.Forms.Button()
		Me.ButtonShowDialog = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'TextBoxSomeText
		'
		Me.TextBoxSomeText.Location = New System.Drawing.Point(12, 12)
		Me.TextBoxSomeText.Name = "TextBoxSomeText"
		Me.TextBoxSomeText.Size = New System.Drawing.Size(324, 20)
		Me.TextBoxSomeText.TabIndex = 0
		Me.TextBoxSomeText.Text = "Some text"
		'
		'ButtonShow
		'
		Me.ButtonShow.Location = New System.Drawing.Point(136, 81)
		Me.ButtonShow.Name = "ButtonShow"
		Me.ButtonShow.Size = New System.Drawing.Size(75, 23)
		Me.ButtonShow.TabIndex = 1
		Me.ButtonShow.Text = "Show"
		Me.ButtonShow.UseVisualStyleBackColor = True
		'
		'ButtonShowDialog
		'
		Me.ButtonShowDialog.Location = New System.Drawing.Point(261, 81)
		Me.ButtonShowDialog.Name = "ButtonShowDialog"
		Me.ButtonShowDialog.Size = New System.Drawing.Size(75, 23)
		Me.ButtonShowDialog.TabIndex = 2
		Me.ButtonShowDialog.Text = "ShowDialog"
		Me.ButtonShowDialog.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(12, 81)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
		Me.ButtonExit.TabIndex = 3
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(348, 114)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonShowDialog)
		Me.Controls.Add(Me.ButtonShow)
		Me.Controls.Add(Me.TextBoxSomeText)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents TextBoxSomeText As TextBox
	Friend WithEvents ButtonShow As Button
	Friend WithEvents ButtonShowDialog As Button
	Friend WithEvents ButtonExit As Button
End Class
