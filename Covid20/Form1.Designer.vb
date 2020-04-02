<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Covid20
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Covid20))
		Me.IntroPlayer = New AxWMPLib.AxWindowsMediaPlayer()
		Me.SkipIntro = New System.Windows.Forms.Button()
		CType(Me.IntroPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'IntroPlayer
		'
		Me.IntroPlayer.Enabled = True
		Me.IntroPlayer.Location = New System.Drawing.Point(-3, 1)
		Me.IntroPlayer.Name = "IntroPlayer"
		Me.IntroPlayer.OcxState = CType(resources.GetObject("IntroPlayer.OcxState"), System.Windows.Forms.AxHost.State)
		Me.IntroPlayer.Size = New System.Drawing.Size(858, 542)
		Me.IntroPlayer.TabIndex = 0
		'
		'SkipIntro
		'
		Me.SkipIntro.Location = New System.Drawing.Point(742, 496)
		Me.SkipIntro.Name = "SkipIntro"
		Me.SkipIntro.Size = New System.Drawing.Size(75, 23)
		Me.SkipIntro.TabIndex = 1
		Me.SkipIntro.Text = "Skip"
		Me.SkipIntro.UseVisualStyleBackColor = True
		'
		'Covid20
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(853, 544)
		Me.Controls.Add(Me.SkipIntro)
		Me.Controls.Add(Me.IntroPlayer)
		Me.Name = "Covid20"
		Me.Text = "Covid20"
		CType(Me.IntroPlayer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents IntroPlayer As AxWMPLib.AxWindowsMediaPlayer
	Friend WithEvents SkipIntro As Button
End Class
