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
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtLastName = New System.Windows.Forms.TextBox()
		Me.txtFirstName = New System.Windows.Forms.TextBox()
		Me.btnLast = New System.Windows.Forms.Button()
		Me.btnFirst = New System.Windows.Forms.Button()
		Me.btnPrevious = New System.Windows.Forms.Button()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(43, 50)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(61, 13)
		Me.Label2.TabIndex = 9
		Me.Label2.Text = "Last Name:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(43, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(63, 13)
		Me.Label1.TabIndex = 8
		Me.Label1.Text = "First Name: "
		'
		'txtLastName
		'
		Me.txtLastName.Location = New System.Drawing.Point(204, 47)
		Me.txtLastName.Name = "txtLastName"
		Me.txtLastName.Size = New System.Drawing.Size(100, 20)
		Me.txtLastName.TabIndex = 7
		'
		'txtFirstName
		'
		Me.txtFirstName.Location = New System.Drawing.Point(204, 21)
		Me.txtFirstName.Name = "txtFirstName"
		Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
		Me.txtFirstName.TabIndex = 6
		'
		'btnLast
		'
		Me.btnLast.Location = New System.Drawing.Point(229, 132)
		Me.btnLast.Name = "btnLast"
		Me.btnLast.Size = New System.Drawing.Size(75, 23)
		Me.btnLast.TabIndex = 5
		Me.btnLast.Text = ">>"
		Me.btnLast.UseVisualStyleBackColor = True
		'
		'btnFirst
		'
		Me.btnFirst.Location = New System.Drawing.Point(46, 132)
		Me.btnFirst.Name = "btnFirst"
		Me.btnFirst.Size = New System.Drawing.Size(75, 23)
		Me.btnFirst.TabIndex = 10
		Me.btnFirst.Text = "<<"
		Me.btnFirst.UseVisualStyleBackColor = True
		'
		'btnPrevious
		'
		Me.btnPrevious.Location = New System.Drawing.Point(74, 89)
		Me.btnPrevious.Name = "btnPrevious"
		Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
		Me.btnPrevious.TabIndex = 11
		Me.btnPrevious.Text = "<"
		Me.btnPrevious.UseVisualStyleBackColor = True
		'
		'btnNext
		'
		Me.btnNext.Location = New System.Drawing.Point(204, 89)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(75, 23)
		Me.btnNext.TabIndex = 12
		Me.btnNext.Text = ">"
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'Form2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(351, 175)
		Me.Controls.Add(Me.btnNext)
		Me.Controls.Add(Me.btnPrevious)
		Me.Controls.Add(Me.btnFirst)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtLastName)
		Me.Controls.Add(Me.txtFirstName)
		Me.Controls.Add(Me.btnLast)
		Me.Name = "Form2"
		Me.Text = "Next Previous"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtLastName As TextBox
	Friend WithEvents txtFirstName As TextBox
	Friend WithEvents btnLast As Button
	Friend WithEvents btnFirst As Button
	Friend WithEvents btnPrevious As Button
	Friend WithEvents btnNext As Button
End Class
