﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBouncingBall2
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
		Me.components = New System.ComponentModel.Container()
		Me.ButtonExit = New System.Windows.Forms.Button()
		Me.ButtonReset = New System.Windows.Forms.Button()
		Me.ButtonStop = New System.Windows.Forms.Button()
		Me.ButtonAnimate = New System.Windows.Forms.Button()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.PictureBoxBall = New System.Windows.Forms.PictureBox()
		Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
		Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.PictureBoxBall, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'ButtonExit
		'
		Me.ButtonExit.Location = New System.Drawing.Point(12, 99)
		Me.ButtonExit.Name = "ButtonExit"
		Me.ButtonExit.Size = New System.Drawing.Size(75, 23)
		Me.ButtonExit.TabIndex = 8
		Me.ButtonExit.Text = "Exit"
		Me.ButtonExit.UseVisualStyleBackColor = True
		'
		'ButtonReset
		'
		Me.ButtonReset.Location = New System.Drawing.Point(12, 70)
		Me.ButtonReset.Name = "ButtonReset"
		Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
		Me.ButtonReset.TabIndex = 7
		Me.ButtonReset.Text = "Reset"
		Me.ButtonReset.UseVisualStyleBackColor = True
		'
		'ButtonStop
		'
		Me.ButtonStop.Location = New System.Drawing.Point(12, 41)
		Me.ButtonStop.Name = "ButtonStop"
		Me.ButtonStop.Size = New System.Drawing.Size(75, 23)
		Me.ButtonStop.TabIndex = 6
		Me.ButtonStop.Text = "Stop"
		Me.ButtonStop.UseVisualStyleBackColor = True
		'
		'ButtonAnimate
		'
		Me.ButtonAnimate.Location = New System.Drawing.Point(12, 12)
		Me.ButtonAnimate.Name = "ButtonAnimate"
		Me.ButtonAnimate.Size = New System.Drawing.Size(75, 23)
		Me.ButtonAnimate.TabIndex = 5
		Me.ButtonAnimate.Text = "Animate"
		Me.ButtonAnimate.UseVisualStyleBackColor = True
		'
		'Timer1
		'
		'
		'Timer2
		'
		'
		'PictureBoxBall
		'
		Me.PictureBoxBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
		Me.PictureBoxBall.Location = New System.Drawing.Point(153, 12)
		Me.PictureBoxBall.Name = "PictureBoxBall"
		Me.PictureBoxBall.Size = New System.Drawing.Size(24, 24)
		Me.PictureBoxBall.TabIndex = 9
		Me.PictureBoxBall.TabStop = False
		'
		'Timer3
		'
		'
		'FormBouncingBall2
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(254, 136)
		Me.Controls.Add(Me.ButtonExit)
		Me.Controls.Add(Me.ButtonReset)
		Me.Controls.Add(Me.ButtonStop)
		Me.Controls.Add(Me.ButtonAnimate)
		Me.Controls.Add(Me.PictureBoxBall)
		Me.Name = "FormBouncingBall2"
		Me.Text = "Bouncing Ball v2"
		CType(Me.PictureBoxBall, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents ButtonExit As Button
	Friend WithEvents ButtonReset As Button
	Friend WithEvents ButtonStop As Button
	Friend WithEvents ButtonAnimate As Button
	Friend WithEvents Timer1 As Timer
	Friend WithEvents Timer2 As Timer
	Friend WithEvents PictureBoxBall As PictureBox
	Friend WithEvents Timer3 As Timer
	Friend WithEvents Timer4 As Timer
End Class
