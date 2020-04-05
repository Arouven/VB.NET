<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInterest
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
		Me.LabelPrincipal = New System.Windows.Forms.Label()
		Me.TextBoxPrincipal = New System.Windows.Forms.TextBox()
		Me.LabelRate = New System.Windows.Forms.Label()
		Me.TextBoxRate = New System.Windows.Forms.TextBox()
		Me.LabelCompound = New System.Windows.Forms.Label()
		Me.LabelTime = New System.Windows.Forms.Label()
		Me.TextBoxTime = New System.Windows.Forms.TextBox()
		Me.ButtonCalculate = New System.Windows.Forms.Button()
		Me.ButtonClear = New System.Windows.Forms.Button()
		Me.TextBoxCompound = New System.Windows.Forms.TextBox()
		Me.ListBoxInterest = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'LabelPrincipal
		'
		Me.LabelPrincipal.AutoSize = True
		Me.LabelPrincipal.Location = New System.Drawing.Point(338, 12)
		Me.LabelPrincipal.Name = "LabelPrincipal"
		Me.LabelPrincipal.Size = New System.Drawing.Size(65, 13)
		Me.LabelPrincipal.TabIndex = 0
		Me.LabelPrincipal.Text = "Principal ($):"
		'
		'TextBoxPrincipal
		'
		Me.TextBoxPrincipal.Location = New System.Drawing.Point(454, 9)
		Me.TextBoxPrincipal.Name = "TextBoxPrincipal"
		Me.TextBoxPrincipal.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxPrincipal.TabIndex = 1
		'
		'LabelRate
		'
		Me.LabelRate.AutoSize = True
		Me.LabelRate.Location = New System.Drawing.Point(338, 38)
		Me.LabelRate.Name = "LabelRate"
		Me.LabelRate.Size = New System.Drawing.Size(97, 13)
		Me.LabelRate.TabIndex = 2
		Me.LabelRate.Text = "Rate per anum (%):"
		'
		'TextBoxRate
		'
		Me.TextBoxRate.Location = New System.Drawing.Point(454, 35)
		Me.TextBoxRate.Name = "TextBoxRate"
		Me.TextBoxRate.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxRate.TabIndex = 3
		'
		'LabelCompound
		'
		Me.LabelCompound.AutoSize = True
		Me.LabelCompound.Location = New System.Drawing.Point(338, 64)
		Me.LabelCompound.Name = "LabelCompound"
		Me.LabelCompound.Size = New System.Drawing.Size(110, 13)
		Me.LabelCompound.TabIndex = 4
		Me.LabelCompound.Text = "Compound (Annually):"
		'
		'LabelTime
		'
		Me.LabelTime.AutoSize = True
		Me.LabelTime.Location = New System.Drawing.Point(338, 90)
		Me.LabelTime.Name = "LabelTime"
		Me.LabelTime.Size = New System.Drawing.Size(64, 13)
		Me.LabelTime.TabIndex = 5
		Me.LabelTime.Text = "Time (Year):"
		'
		'TextBoxTime
		'
		Me.TextBoxTime.Location = New System.Drawing.Point(454, 87)
		Me.TextBoxTime.Name = "TextBoxTime"
		Me.TextBoxTime.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxTime.TabIndex = 6
		'
		'ButtonCalculate
		'
		Me.ButtonCalculate.Location = New System.Drawing.Point(479, 175)
		Me.ButtonCalculate.Name = "ButtonCalculate"
		Me.ButtonCalculate.Size = New System.Drawing.Size(75, 23)
		Me.ButtonCalculate.TabIndex = 7
		Me.ButtonCalculate.Text = "Calculate"
		Me.ButtonCalculate.UseVisualStyleBackColor = True
		'
		'ButtonClear
		'
		Me.ButtonClear.Location = New System.Drawing.Point(341, 175)
		Me.ButtonClear.Name = "ButtonClear"
		Me.ButtonClear.Size = New System.Drawing.Size(75, 23)
		Me.ButtonClear.TabIndex = 8
		Me.ButtonClear.Text = "Clear"
		Me.ButtonClear.UseVisualStyleBackColor = True
		'
		'TextBoxCompound
		'
		Me.TextBoxCompound.Location = New System.Drawing.Point(454, 61)
		Me.TextBoxCompound.Name = "TextBoxCompound"
		Me.TextBoxCompound.Size = New System.Drawing.Size(100, 20)
		Me.TextBoxCompound.TabIndex = 10
		'
		'ListBoxInterest
		'
		Me.ListBoxInterest.FormattingEnabled = True
		Me.ListBoxInterest.Location = New System.Drawing.Point(12, 12)
		Me.ListBoxInterest.Name = "ListBoxInterest"
		Me.ListBoxInterest.Size = New System.Drawing.Size(320, 186)
		Me.ListBoxInterest.TabIndex = 11
		'
		'FormInterest
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(564, 212)
		Me.Controls.Add(Me.ListBoxInterest)
		Me.Controls.Add(Me.TextBoxCompound)
		Me.Controls.Add(Me.ButtonClear)
		Me.Controls.Add(Me.ButtonCalculate)
		Me.Controls.Add(Me.TextBoxTime)
		Me.Controls.Add(Me.LabelTime)
		Me.Controls.Add(Me.LabelCompound)
		Me.Controls.Add(Me.TextBoxRate)
		Me.Controls.Add(Me.LabelRate)
		Me.Controls.Add(Me.TextBoxPrincipal)
		Me.Controls.Add(Me.LabelPrincipal)
		Me.Name = "FormInterest"
		Me.Text = "Interest"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelPrincipal As Label
	Friend WithEvents TextBoxPrincipal As TextBox
	Friend WithEvents LabelRate As Label
	Friend WithEvents TextBoxRate As TextBox
	Friend WithEvents LabelCompound As Label
	Friend WithEvents LabelTime As Label
	Friend WithEvents TextBoxTime As TextBox
	Friend WithEvents ButtonCalculate As Button
	Friend WithEvents ButtonClear As Button
	Friend WithEvents TextBoxCompound As TextBox
	Friend WithEvents ListBoxInterest As ListBox
End Class
