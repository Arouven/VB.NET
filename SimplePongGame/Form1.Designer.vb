<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSimplePongGame
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
		Me.PictureBoxBall = New System.Windows.Forms.PictureBox()
		Me.picObj2 = New System.Windows.Forms.PictureBox()
		Me.LabelScore = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		CType(Me.PictureBoxBall, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picObj2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBoxBall
		'
		Me.PictureBoxBall.BackColor = System.Drawing.SystemColors.Control
		Me.PictureBoxBall.Location = New System.Drawing.Point(127, 12)
		Me.PictureBoxBall.Name = "PictureBoxBall"
		Me.PictureBoxBall.Size = New System.Drawing.Size(24, 24)
		Me.PictureBoxBall.TabIndex = 0
		Me.PictureBoxBall.TabStop = False
		'
		'picObj2
		'
		Me.picObj2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.picObj2.Location = New System.Drawing.Point(183, 186)
		Me.picObj2.Name = "picObj2"
		Me.picObj2.Size = New System.Drawing.Size(77, 14)
		Me.picObj2.TabIndex = 1
		Me.picObj2.TabStop = False
		'
		'LabelScore
		'
		Me.LabelScore.AutoSize = True
		Me.LabelScore.Location = New System.Drawing.Point(12, 206)
		Me.LabelScore.Name = "LabelScore"
		Me.LabelScore.Size = New System.Drawing.Size(38, 13)
		Me.LabelScore.TabIndex = 2
		Me.LabelScore.Text = "Score:"
		'
		'Timer1
		'
		'
		'FormSimplePongGame
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(272, 228)
		Me.Controls.Add(Me.LabelScore)
		Me.Controls.Add(Me.picObj2)
		Me.Controls.Add(Me.PictureBoxBall)
		Me.MaximizeBox = False
		Me.Name = "FormSimplePongGame"
		Me.Text = "Simple Pong Game"
		CType(Me.PictureBoxBall, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picObj2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBoxBall As PictureBox
	Friend WithEvents picObj2 As PictureBox
	Friend WithEvents LabelScore As Label
	Friend WithEvents Timer1 As Timer
End Class
