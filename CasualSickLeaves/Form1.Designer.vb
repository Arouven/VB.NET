<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCasualSick
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
		Me.LabelDateOfJoining = New System.Windows.Forms.Label()
		Me.LabelDateOfLeaving = New System.Windows.Forms.Label()
		Me.LabelDays = New System.Windows.Forms.Label()
		Me.DateTimePickerJoin = New System.Windows.Forms.DateTimePicker()
		Me.DateTimePickerLeave = New System.Windows.Forms.DateTimePicker()
		Me.ButtonCalculateLeave = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'LabelDateOfJoining
		'
		Me.LabelDateOfJoining.AutoSize = True
		Me.LabelDateOfJoining.Location = New System.Drawing.Point(12, 18)
		Me.LabelDateOfJoining.Name = "LabelDateOfJoining"
		Me.LabelDateOfJoining.Size = New System.Drawing.Size(75, 13)
		Me.LabelDateOfJoining.TabIndex = 0
		Me.LabelDateOfJoining.Text = "Date of joining"
		'
		'LabelDateOfLeaving
		'
		Me.LabelDateOfLeaving.AutoSize = True
		Me.LabelDateOfLeaving.Location = New System.Drawing.Point(12, 84)
		Me.LabelDateOfLeaving.Name = "LabelDateOfLeaving"
		Me.LabelDateOfLeaving.Size = New System.Drawing.Size(83, 13)
		Me.LabelDateOfLeaving.TabIndex = 1
		Me.LabelDateOfLeaving.Text = "Date of Leaving"
		'
		'LabelDays
		'
		Me.LabelDays.AutoSize = True
		Me.LabelDays.Location = New System.Drawing.Point(289, 139)
		Me.LabelDays.Name = "LabelDays"
		Me.LabelDays.Size = New System.Drawing.Size(46, 13)
		Me.LabelDays.TabIndex = 2
		Me.LabelDays.Text = "0 Day(s)"
		'
		'DateTimePickerJoin
		'
		Me.DateTimePickerJoin.Location = New System.Drawing.Point(139, 12)
		Me.DateTimePickerJoin.Name = "DateTimePickerJoin"
		Me.DateTimePickerJoin.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerJoin.TabIndex = 3
		'
		'DateTimePickerLeave
		'
		Me.DateTimePickerLeave.Location = New System.Drawing.Point(139, 78)
		Me.DateTimePickerLeave.Name = "DateTimePickerLeave"
		Me.DateTimePickerLeave.Size = New System.Drawing.Size(200, 20)
		Me.DateTimePickerLeave.TabIndex = 4
		'
		'ButtonCalculateLeave
		'
		Me.ButtonCalculateLeave.Location = New System.Drawing.Point(15, 134)
		Me.ButtonCalculateLeave.Name = "ButtonCalculateLeave"
		Me.ButtonCalculateLeave.Size = New System.Drawing.Size(178, 23)
		Me.ButtonCalculateLeave.TabIndex = 5
		Me.ButtonCalculateLeave.Text = "Calculate Leave"
		Me.ButtonCalculateLeave.UseVisualStyleBackColor = True
		'
		'FormCasualSick
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(351, 173)
		Me.Controls.Add(Me.ButtonCalculateLeave)
		Me.Controls.Add(Me.DateTimePickerLeave)
		Me.Controls.Add(Me.DateTimePickerJoin)
		Me.Controls.Add(Me.LabelDays)
		Me.Controls.Add(Me.LabelDateOfLeaving)
		Me.Controls.Add(Me.LabelDateOfJoining)
		Me.Name = "FormCasualSick"
		Me.Text = "Calculating Casual Sick Leaves"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelDateOfJoining As Label
	Friend WithEvents LabelDateOfLeaving As Label
	Friend WithEvents LabelDays As Label
	Friend WithEvents DateTimePickerJoin As DateTimePicker
	Friend WithEvents DateTimePickerLeave As DateTimePicker
	Friend WithEvents ButtonCalculateLeave As Button
End Class
