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
		Me.btnLoad = New System.Windows.Forms.Button()
		Me.txtFirstName = New System.Windows.Forms.TextBox()
		Me.txtLastName = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnLoad
		'
		Me.btnLoad.Location = New System.Drawing.Point(36, 76)
		Me.btnLoad.Name = "btnLoad"
		Me.btnLoad.Size = New System.Drawing.Size(75, 23)
		Me.btnLoad.TabIndex = 0
		Me.btnLoad.Text = "Load"
		Me.btnLoad.UseVisualStyleBackColor = True
		'
		'txtFirstName
		'
		Me.txtFirstName.Location = New System.Drawing.Point(194, 12)
		Me.txtFirstName.Name = "txtFirstName"
		Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
		Me.txtFirstName.TabIndex = 1
		'
		'txtLastName
		'
		Me.txtLastName.Location = New System.Drawing.Point(194, 38)
		Me.txtLastName.Name = "txtLastName"
		Me.txtLastName.Size = New System.Drawing.Size(100, 20)
		Me.txtLastName.TabIndex = 2
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(33, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "First Name: "
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(33, 41)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(61, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Last Name:"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(333, 126)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtLastName)
		Me.Controls.Add(Me.txtFirstName)
		Me.Controls.Add(Me.btnLoad)
		Me.Name = "Form1"
		Me.Text = "Open Connection"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents btnLoad As Button
	Friend WithEvents txtFirstName As TextBox
	Friend WithEvents txtLastName As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
End Class
