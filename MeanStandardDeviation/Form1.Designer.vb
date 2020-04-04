<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMeanSD
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
		Me.LabelNum = New System.Windows.Forms.Label()
		Me.TextBoxNumber = New System.Windows.Forms.TextBox()
		Me.ButtonAcceptNumber = New System.Windows.Forms.Button()
		Me.ButtonNewSequence = New System.Windows.Forms.Button()
		Me.ButtonCompute = New System.Windows.Forms.Button()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.LabelMean = New System.Windows.Forms.Label()
		Me.TextBoxMean = New System.Windows.Forms.TextBox()
		Me.LabelSD = New System.Windows.Forms.Label()
		Me.TextBoxSD = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'LabelNum
		'
		Me.LabelNum.AutoSize = True
		Me.LabelNum.Location = New System.Drawing.Point(12, 9)
		Me.LabelNum.Name = "LabelNum"
		Me.LabelNum.Size = New System.Drawing.Size(78, 13)
		Me.LabelNum.TabIndex = 0
		Me.LabelNum.Text = "Enter Number :"
		'
		'TextBoxNumber
		'
		Me.TextBoxNumber.Location = New System.Drawing.Point(187, 6)
		Me.TextBoxNumber.Name = "TextBoxNumber"
		Me.TextBoxNumber.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxNumber.TabIndex = 1
		'
		'ButtonAcceptNumber
		'
		Me.ButtonAcceptNumber.Location = New System.Drawing.Point(172, 32)
		Me.ButtonAcceptNumber.Name = "ButtonAcceptNumber"
		Me.ButtonAcceptNumber.Size = New System.Drawing.Size(115, 23)
		Me.ButtonAcceptNumber.TabIndex = 2
		Me.ButtonAcceptNumber.Text = "Accept Number"
		Me.ButtonAcceptNumber.UseVisualStyleBackColor = True
		'
		'ButtonNewSequence
		'
		Me.ButtonNewSequence.Location = New System.Drawing.Point(12, 32)
		Me.ButtonNewSequence.Name = "ButtonNewSequence"
		Me.ButtonNewSequence.Size = New System.Drawing.Size(115, 23)
		Me.ButtonNewSequence.TabIndex = 3
		Me.ButtonNewSequence.Text = "New Sequence"
		Me.ButtonNewSequence.UseVisualStyleBackColor = True
		'
		'ButtonCompute
		'
		Me.ButtonCompute.Location = New System.Drawing.Point(12, 113)
		Me.ButtonCompute.Name = "ButtonCompute"
		Me.ButtonCompute.Size = New System.Drawing.Size(115, 23)
		Me.ButtonCompute.TabIndex = 4
		Me.ButtonCompute.Text = "Compute"
		Me.ButtonCompute.UseVisualStyleBackColor = True
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(172, 113)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(115, 23)
		Me.ButtonExit.TabIndex = 5
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'LabelMean
		'
		Me.LabelMean.AutoSize = True
		Me.LabelMean.Location = New System.Drawing.Point(12, 64)
		Me.LabelMean.Name = "LabelMean"
		Me.LabelMean.Size = New System.Drawing.Size(37, 13)
		Me.LabelMean.TabIndex = 6
		Me.LabelMean.Text = "Mean:"
		'
		'TextBoxMean
		'
		Me.TextBoxMean.Location = New System.Drawing.Point(187, 61)
		Me.TextBoxMean.Name = "TextBoxMean"
		Me.TextBoxMean.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxMean.TabIndex = 7
		'
		'LabelSD
		'
		Me.LabelSD.AutoSize = True
		Me.LabelSD.Location = New System.Drawing.Point(12, 90)
		Me.LabelSD.Name = "LabelSD"
		Me.LabelSD.Size = New System.Drawing.Size(101, 13)
		Me.LabelSD.TabIndex = 8
		Me.LabelSD.Text = "Standard Deviation:"
		'
		'TextBoxSD
		'
		Me.TextBoxSD.Location = New System.Drawing.Point(187, 87)
		Me.TextBoxSD.Name = "TextBoxSD"
		Me.TextBoxSD.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxSD.TabIndex = 9
		'
		'FormMeanSD
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(299, 147)
		Me.Controls.Add(Me.TextBoxSD)
		Me.Controls.Add(Me.LabelSD)
		Me.Controls.Add(Me.TextBoxMean)
		Me.Controls.Add(Me.LabelMean)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonCompute)
		Me.Controls.Add(Me.ButtonNewSequence)
		Me.Controls.Add(Me.ButtonAcceptNumber)
		Me.Controls.Add(Me.TextBoxNumber)
		Me.Controls.Add(Me.LabelNum)
		Me.Name = "FormMeanSD"
		Me.Text = "Compute Mean and Standard Deviation"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelNum As Label
	Friend WithEvents TextBoxNumber As TextBox
	Friend WithEvents ButtonAcceptNumber As Button
	Friend WithEvents ButtonNewSequence As Button
	Friend WithEvents ButtonCompute As Button
	Friend WithEvents ButtonExit As Button
	Friend WithEvents LabelMean As Label
	Friend WithEvents TextBoxMean As TextBox
	Friend WithEvents LabelSD As Label
	Friend WithEvents TextBoxSD As TextBox
End Class
