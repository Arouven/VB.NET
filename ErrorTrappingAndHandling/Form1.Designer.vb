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
		Me.txtauthor = New System.Windows.Forms.TextBox()
		Me.txtYearBorn = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.cmdShowDetail = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'txtauthor
		'
		Me.txtauthor.Location = New System.Drawing.Point(113, 12)
		Me.txtauthor.Name = "txtauthor"
		Me.txtauthor.Size = New System.Drawing.Size(100, 20)
		Me.txtauthor.TabIndex = 0
		'
		'txtYearBorn
		'
		Me.txtYearBorn.Location = New System.Drawing.Point(113, 38)
		Me.txtYearBorn.Name = "txtYearBorn"
		Me.txtYearBorn.Size = New System.Drawing.Size(100, 20)
		Me.txtYearBorn.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(72, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Author Name:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 41)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(57, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Year Born:"
		'
		'cmdShowDetail
		'
		Me.cmdShowDetail.Location = New System.Drawing.Point(15, 64)
		Me.cmdShowDetail.Name = "cmdShowDetail"
		Me.cmdShowDetail.Size = New System.Drawing.Size(198, 23)
		Me.cmdShowDetail.TabIndex = 4
		Me.cmdShowDetail.Text = "Show Details"
		Me.cmdShowDetail.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(227, 103)
		Me.Controls.Add(Me.cmdShowDetail)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtYearBorn)
		Me.Controls.Add(Me.txtauthor)
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtauthor As TextBox
	Friend WithEvents txtYearBorn As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents cmdShowDetail As Button
End Class
