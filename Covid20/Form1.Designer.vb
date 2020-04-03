<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Covid20
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Covid20))
		Me.PanelGameIntro = New System.Windows.Forms.Panel()
		Me.SkipIntro = New System.Windows.Forms.Button()
		Me.LblEnNov = New System.Windows.Forms.Label()
		Me.IntroPlayer = New AxWMPLib.AxWindowsMediaPlayer()
		Me.PanelGameIntro.SuspendLayout()
		CType(Me.IntroPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PanelGameIntro
		'
		Me.PanelGameIntro.Controls.Add(Me.SkipIntro)
		Me.PanelGameIntro.Controls.Add(Me.LblEnNov)
		Me.PanelGameIntro.Controls.Add(Me.IntroPlayer)
		Me.PanelGameIntro.Dock = System.Windows.Forms.DockStyle.Fill
		Me.PanelGameIntro.Location = New System.Drawing.Point(0, 0)
		Me.PanelGameIntro.Name = "PanelGameIntro"
		Me.PanelGameIntro.Size = New System.Drawing.Size(799, 506)
		Me.PanelGameIntro.TabIndex = 3
		'
		'SkipIntro
		'
		Me.SkipIntro.Location = New System.Drawing.Point(712, 471)
		Me.SkipIntro.Name = "SkipIntro"
		Me.SkipIntro.Size = New System.Drawing.Size(75, 23)
		Me.SkipIntro.TabIndex = 4
		Me.SkipIntro.Text = "Skip"
		Me.SkipIntro.UseVisualStyleBackColor = True
		'
		'LblEnNov
		'
		Me.LblEnNov.BackColor = System.Drawing.Color.Transparent
		Me.LblEnNov.Font = New System.Drawing.Font("MV Boli", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblEnNov.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.LblEnNov.Location = New System.Drawing.Point(12, 9)
		Me.LblEnNov.Name = "LblEnNov"
		Me.LblEnNov.Size = New System.Drawing.Size(775, 74)
		Me.LblEnNov.TabIndex = 1
		Me.LblEnNov.Text = "En Nov 2019, le novel coronavirus fait son apparition. En Mars 2020 ..."
		Me.LblEnNov.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'IntroPlayer
		'
		Me.IntroPlayer.Enabled = True
		Me.IntroPlayer.Location = New System.Drawing.Point(0, 0)
		Me.IntroPlayer.Name = "IntroPlayer"
		Me.IntroPlayer.OcxState = CType(resources.GetObject("IntroPlayer.OcxState"), System.Windows.Forms.AxHost.State)
		Me.IntroPlayer.Size = New System.Drawing.Size(800, 507)
		Me.IntroPlayer.TabIndex = 3
		'
		'Covid20
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(799, 506)
		Me.Controls.Add(Me.PanelGameIntro)
		Me.Name = "Covid20"
		Me.Text = "Covid20"
		Me.PanelGameIntro.ResumeLayout(False)
		CType(Me.IntroPlayer, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PanelGameIntro As Panel
	Friend WithEvents SkipIntro As Button
	Friend WithEvents LblEnNov As Label
	Friend WithEvents IntroPlayer As AxWMPLib.AxWindowsMediaPlayer
End Class
