<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormValueReference
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
		Me.LabelABefore = New System.Windows.Forms.Label()
		Me.TextBoxABefore = New System.Windows.Forms.TextBox()
		Me.ButtonModifyByValue = New System.Windows.Forms.Button()
		Me.ButtonModifyByRef = New System.Windows.Forms.Button()
		Me.LabelAAfter = New System.Windows.Forms.Label()
		Me.TextBoxModifyByValue = New System.Windows.Forms.TextBox()
		Me.TextBoxModifyByRef = New System.Windows.Forms.TextBox()
		Me.ButtonClear = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'LabelABefore
		'
		Me.LabelABefore.AutoSize = True
		Me.LabelABefore.Location = New System.Drawing.Point(12, 9)
		Me.LabelABefore.Name = "LabelABefore"
		Me.LabelABefore.Size = New System.Drawing.Size(132, 13)
		Me.LabelABefore.TabIndex = 0
		Me.LabelABefore.Text = "Value of variable A before:"
		'
		'TextBoxABefore
		'
		Me.TextBoxABefore.Location = New System.Drawing.Point(150, 6)
		Me.TextBoxABefore.Name = "TextBoxABefore"
		Me.TextBoxABefore.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxABefore.TabIndex = 1
		'
		'ButtonModifyByValue
		'
		Me.ButtonModifyByValue.Location = New System.Drawing.Point(151, 32)
		Me.ButtonModifyByValue.Name = "ButtonModifyByValue"
		Me.ButtonModifyByValue.Size = New System.Drawing.Size(99, 23)
		Me.ButtonModifyByValue.TabIndex = 2
		Me.ButtonModifyByValue.Text = "Modify by Value"
		Me.ButtonModifyByValue.UseVisualStyleBackColor = True
		'
		'ButtonModifyByRef
		'
		Me.ButtonModifyByRef.Location = New System.Drawing.Point(15, 32)
		Me.ButtonModifyByRef.Name = "ButtonModifyByRef"
		Me.ButtonModifyByRef.Size = New System.Drawing.Size(99, 23)
		Me.ButtonModifyByRef.TabIndex = 3
		Me.ButtonModifyByRef.Text = "Modify by Ref"
		Me.ButtonModifyByRef.UseVisualStyleBackColor = True
		'
		'LabelAAfter
		'
		Me.LabelAAfter.Location = New System.Drawing.Point(12, 90)
		Me.LabelAAfter.Name = "LabelAAfter"
		Me.LabelAAfter.Size = New System.Drawing.Size(238, 23)
		Me.LabelAAfter.TabIndex = 4
		Me.LabelAAfter.Text = "Value of variable A after:"
		Me.LabelAAfter.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'TextBoxModifyByValue
		'
		Me.TextBoxModifyByValue.Location = New System.Drawing.Point(150, 116)
		Me.TextBoxModifyByValue.Name = "TextBoxModifyByValue"
		Me.TextBoxModifyByValue.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxModifyByValue.TabIndex = 5
		'
		'TextBoxModifyByRef
		'
		Me.TextBoxModifyByRef.Location = New System.Drawing.Point(15, 116)
		Me.TextBoxModifyByRef.Name = "TextBoxModifyByRef"
		Me.TextBoxModifyByRef.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxModifyByRef.TabIndex = 6
		'
		'ButtonClear
		'
		Me.ButtonClear.Location = New System.Drawing.Point(15, 142)
		Me.ButtonClear.Name = "ButtonClear"
		Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
		Me.ButtonClear.TabIndex = 7
		Me.ButtonClear.Text = "Clear"
		Me.ButtonClear.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(175, 142)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
		Me.ButtonExit.TabIndex = 8
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'FormValueReference
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(267, 180)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonClear)
		Me.Controls.Add(Me.TextBoxModifyByRef)
		Me.Controls.Add(Me.TextBoxModifyByValue)
		Me.Controls.Add(Me.LabelAAfter)
		Me.Controls.Add(Me.ButtonModifyByRef)
		Me.Controls.Add(Me.ButtonModifyByValue)
		Me.Controls.Add(Me.TextBoxABefore)
		Me.Controls.Add(Me.LabelABefore)
		Me.Name = "FormValueReference"
		Me.Text = "Pass by value and reference"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelABefore As Label
	Friend WithEvents TextBoxABefore As TextBox
	Friend WithEvents ButtonModifyByValue As Button
	Friend WithEvents ButtonModifyByRef As Button
	Friend WithEvents LabelAAfter As Label
	Friend WithEvents TextBoxModifyByValue As TextBox
	Friend WithEvents TextBoxModifyByRef As TextBox
	Friend WithEvents ButtonClear As Button
	Friend WithEvents ButtonExit As Button
End Class
