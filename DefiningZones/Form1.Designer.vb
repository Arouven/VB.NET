<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmployeeData
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.ListBoxEmployee = New System.Windows.Forms.ListBox()
		Me.ButtonDisplayTable = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'ListBoxEmployee
		'
		Me.ListBoxEmployee.FormattingEnabled = True
		Me.ListBoxEmployee.Location = New System.Drawing.Point(12, 12)
		Me.ListBoxEmployee.Name = "ListBoxEmployee"
		Me.ListBoxEmployee.Size = New System.Drawing.Size(498, 186)
		Me.ListBoxEmployee.TabIndex = 0
		'
		'ButtonDisplayTable
		'
		Me.ButtonDisplayTable.Location = New System.Drawing.Point(12, 212)
		Me.ButtonDisplayTable.Name = "ButtonDisplayTable"
		Me.ButtonDisplayTable.Size = New System.Drawing.Size(228, 23)
		Me.ButtonDisplayTable.TabIndex = 1
		Me.ButtonDisplayTable.Text = "Display Table"
		Me.ButtonDisplayTable.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(282, 212)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(228, 23)
		Me.ButtonExit.TabIndex = 2
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'FormEmployeeData
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(522, 247)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonDisplayTable)
		Me.Controls.Add(Me.ListBoxEmployee)
		Me.Name = "FormEmployeeData"
		Me.Text = "EmployeeData"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ListBoxEmployee As ListBox
	Friend WithEvents ButtonDisplayTable As Button
	Friend WithEvents ButtonExit As Button
End Class
