<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCompareDate
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
		Me.DateTimePickerToCompare = New System.Windows.Forms.DateTimePicker()
		Me.TextBoxOutBox = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'DateTimePickerToCompare
		'
		Me.DateTimePickerToCompare.Location = New System.Drawing.Point(12, 12)
		Me.DateTimePickerToCompare.Name = "DateTimePickerToCompare"
		Me.DateTimePickerToCompare.Size = New System.Drawing.Size(306, 20)
		Me.DateTimePickerToCompare.TabIndex = 0
		'
		'TextBoxOutBox
		'
		Me.TextBoxOutBox.Enabled = False
		Me.TextBoxOutBox.Location = New System.Drawing.Point(12, 64)
		Me.TextBoxOutBox.Name = "TextBoxOutBox"
		Me.TextBoxOutBox.Size = New System.Drawing.Size(306, 20)
		Me.TextBoxOutBox.TabIndex = 1
		'
		'FormCompareDate
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(330, 96)
		Me.Controls.Add(Me.TextBoxOutBox)
		Me.Controls.Add(Me.DateTimePickerToCompare)
		Me.Name = "FormCompareDate"
		Me.Text = "Compare Date"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DateTimePickerToCompare As DateTimePicker
	Friend WithEvents TextBoxOutBox As TextBox
End Class
