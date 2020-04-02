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
		Me.GamePanel = New System.Windows.Forms.Panel()
		Me.EnNov = New System.Windows.Forms.Label()
		Me.BtnEnNovNext = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.IntroPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GamePanel.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
		'GamePanel
		'
		Me.GamePanel.Controls.Add(Me.PictureBox1)
		Me.GamePanel.Controls.Add(Me.EnNov)
		Me.GamePanel.Controls.Add(Me.BtnEnNovNext)
		Me.GamePanel.Location = New System.Drawing.Point(-3, 1)
		Me.GamePanel.Name = "GamePanel"
		Me.GamePanel.Size = New System.Drawing.Size(858, 542)
		Me.GamePanel.TabIndex = 2
		'
		'EnNov
		'
		Me.EnNov.AutoSize = True
		Me.EnNov.Font = New System.Drawing.Font("MV Boli", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.EnNov.Location = New System.Drawing.Point(59, 40)
		Me.EnNov.Name = "EnNov"
		Me.EnNov.Size = New System.Drawing.Size(761, 34)
		Me.EnNov.TabIndex = 1
		Me.EnNov.Text = "En nov 2019, le novel coronavirus fait son apparition."
		Me.EnNov.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'BtnEnNovNext
		'
		Me.BtnEnNovNext.Location = New System.Drawing.Point(755, 495)
		Me.BtnEnNovNext.Name = "BtnEnNovNext"
		Me.BtnEnNovNext.Size = New System.Drawing.Size(75, 23)
		Me.BtnEnNovNext.TabIndex = 0
		Me.BtnEnNovNext.Text = "Next"
		Me.BtnEnNovNext.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Location = New System.Drawing.Point(65, 90)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(755, 386)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'Covid20
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(853, 544)
		Me.Controls.Add(Me.GamePanel)
		Me.Controls.Add(Me.SkipIntro)
		Me.Controls.Add(Me.IntroPlayer)
		Me.Name = "Covid20"
		Me.Text = "Covid20"
		CType(Me.IntroPlayer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GamePanel.ResumeLayout(False)
		Me.GamePanel.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents IntroPlayer As AxWMPLib.AxWindowsMediaPlayer
	Friend WithEvents SkipIntro As Button
	Friend WithEvents GamePanel As Panel
	Friend WithEvents BtnEnNovNext As Button
	Friend WithEvents EnNov As Label
	Friend WithEvents PictureBox1 As PictureBox
End Class
