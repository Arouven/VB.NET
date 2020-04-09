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
		Me.cmdCreateDirectory = New System.Windows.Forms.Button()
		Me.txtDirectory = New System.Windows.Forms.TextBox()
		Me.cmdCopy = New System.Windows.Forms.Button()
		Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
		Me.SuspendLayout()
		'
		'cmdCreateDirectory
		'
		Me.cmdCreateDirectory.Location = New System.Drawing.Point(12, 75)
		Me.cmdCreateDirectory.Name = "cmdCreateDirectory"
		Me.cmdCreateDirectory.Size = New System.Drawing.Size(104, 23)
		Me.cmdCreateDirectory.TabIndex = 0
		Me.cmdCreateDirectory.Text = "Create Directory"
		Me.cmdCreateDirectory.UseVisualStyleBackColor = True
		'
		'txtDirectory
		'
		Me.txtDirectory.Location = New System.Drawing.Point(12, 12)
		Me.txtDirectory.Name = "txtDirectory"
		Me.txtDirectory.Size = New System.Drawing.Size(245, 20)
		Me.txtDirectory.TabIndex = 1
		'
		'cmdCopy
		'
		Me.cmdCopy.Location = New System.Drawing.Point(153, 75)
		Me.cmdCopy.Name = "cmdCopy"
		Me.cmdCopy.Size = New System.Drawing.Size(104, 23)
		Me.cmdCopy.TabIndex = 2
		Me.cmdCopy.Text = "Copy File"
		Me.cmdCopy.UseVisualStyleBackColor = True
		'
		'OpenFileDialog1
		'
		Me.OpenFileDialog1.FileName = "OpenFileDialog1"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(271, 117)
		Me.Controls.Add(Me.cmdCopy)
		Me.Controls.Add(Me.txtDirectory)
		Me.Controls.Add(Me.cmdCreateDirectory)
		Me.Name = "Form1"
		Me.Text = "Directory Maintenance"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents cmdCreateDirectory As Button
	Friend WithEvents txtDirectory As TextBox
	Friend WithEvents cmdCopy As Button
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
