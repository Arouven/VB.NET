<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStopwatchApplication
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
		Me.BtnStartTime = New System.Windows.Forms.Button()
		Me.BtnEndTime = New System.Windows.Forms.Button()
		Me.BtnExit = New System.Windows.Forms.Button()
		Me.LblStartTime = New System.Windows.Forms.Label()
		Me.LblEndTime = New System.Windows.Forms.Label()
		Me.LblElapsedTime = New System.Windows.Forms.Label()
		Me.TxtStartTime = New System.Windows.Forms.TextBox()
		Me.TxtEndTime = New System.Windows.Forms.TextBox()
		Me.TxtElapsedTime = New System.Windows.Forms.TextBox()
		Me.SuspendLayout()
		'
		'BtnStartTime
		'
		Me.BtnStartTime.Location = New System.Drawing.Point(12, 22)
		Me.BtnStartTime.Name = "BtnStartTime"
		Me.BtnStartTime.Size = New System.Drawing.Size(75, 23)
		Me.BtnStartTime.TabIndex = 0
		Me.BtnStartTime.Text = "Start Time"
		Me.BtnStartTime.UseVisualStyleBackColor = True
		'
		'BtnEndTime
		'
		Me.BtnEndTime.Location = New System.Drawing.Point(13, 70)
		Me.BtnEndTime.Name = "BtnEndTime"
		Me.BtnEndTime.Size = New System.Drawing.Size(75, 23)
		Me.BtnEndTime.TabIndex = 1
		Me.BtnEndTime.Text = "End Time"
		Me.BtnEndTime.UseVisualStyleBackColor = True
		'
		'BtnExit
		'
		Me.BtnExit.Location = New System.Drawing.Point(13, 121)
		Me.BtnExit.Name = "BtnExit"
		Me.BtnExit.Size = New System.Drawing.Size(75, 23)
		Me.BtnExit.TabIndex = 2
		Me.BtnExit.Text = "Exit"
		Me.BtnExit.UseVisualStyleBackColor = True
		'
		'LblStartTime
		'
		Me.LblStartTime.AutoSize = True
		Me.LblStartTime.Location = New System.Drawing.Point(109, 27)
		Me.LblStartTime.Name = "LblStartTime"
		Me.LblStartTime.Size = New System.Drawing.Size(55, 13)
		Me.LblStartTime.TabIndex = 3
		Me.LblStartTime.Text = "Start Time"
		'
		'LblEndTime
		'
		Me.LblEndTime.AutoSize = True
		Me.LblEndTime.Location = New System.Drawing.Point(109, 75)
		Me.LblEndTime.Name = "LblEndTime"
		Me.LblEndTime.Size = New System.Drawing.Size(52, 13)
		Me.LblEndTime.TabIndex = 4
		Me.LblEndTime.Text = "End Time"
		'
		'LblElapsedTime
		'
		Me.LblElapsedTime.AutoSize = True
		Me.LblElapsedTime.Location = New System.Drawing.Point(109, 126)
		Me.LblElapsedTime.Name = "LblElapsedTime"
		Me.LblElapsedTime.Size = New System.Drawing.Size(71, 13)
		Me.LblElapsedTime.TabIndex = 5
		Me.LblElapsedTime.Text = "Elapsed Time"
		'
		'TxtStartTime
		'
		Me.TxtStartTime.Enabled = False
		Me.TxtStartTime.Location = New System.Drawing.Point(181, 24)
		Me.TxtStartTime.Name = "TxtStartTime"
		Me.TxtStartTime.Size = New System.Drawing.Size(100, 20)
		Me.TxtStartTime.TabIndex = 6
		'
		'TxtEndTime
		'
		Me.TxtEndTime.Enabled = False
		Me.TxtEndTime.Location = New System.Drawing.Point(181, 72)
		Me.TxtEndTime.Name = "TxtEndTime"
		Me.TxtEndTime.Size = New System.Drawing.Size(100, 20)
		Me.TxtEndTime.TabIndex = 7
		'
		'TxtElapsedTime
		'
		Me.TxtElapsedTime.Enabled = False
		Me.TxtElapsedTime.Location = New System.Drawing.Point(181, 123)
		Me.TxtElapsedTime.Name = "TxtElapsedTime"
		Me.TxtElapsedTime.Size = New System.Drawing.Size(100, 20)
		Me.TxtElapsedTime.TabIndex = 8
		'
		'FrmStopwatchApplication
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(290, 159)
		Me.Controls.Add(Me.TxtElapsedTime)
		Me.Controls.Add(Me.TxtEndTime)
		Me.Controls.Add(Me.TxtStartTime)
		Me.Controls.Add(Me.LblElapsedTime)
		Me.Controls.Add(Me.LblEndTime)
		Me.Controls.Add(Me.LblStartTime)
		Me.Controls.Add(Me.BtnExit)
		Me.Controls.Add(Me.BtnEndTime)
		Me.Controls.Add(Me.BtnStartTime)
		Me.Name = "FrmStopwatchApplication"
		Me.Text = "Stopwatch Application"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents BtnStartTime As Button
	Friend WithEvents BtnEndTime As Button
	Friend WithEvents BtnExit As Button
	Friend WithEvents LblStartTime As Label
	Friend WithEvents LblEndTime As Label
	Friend WithEvents LblElapsedTime As Label
	Friend WithEvents TxtStartTime As TextBox
	Friend WithEvents TxtEndTime As TextBox
	Friend WithEvents TxtElapsedTime As TextBox
End Class
