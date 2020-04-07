<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCollisionDetection
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
		Me.PictureBoxPlayer = New System.Windows.Forms.PictureBox()
		Me.PictureBoxRed = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBoxPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBoxRed, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBoxPlayer
		'
		Me.PictureBoxPlayer.BackColor = System.Drawing.Color.Lime
		Me.PictureBoxPlayer.Location = New System.Drawing.Point(12, 12)
		Me.PictureBoxPlayer.Name = "PictureBoxPlayer"
		Me.PictureBoxPlayer.Size = New System.Drawing.Size(50, 50)
		Me.PictureBoxPlayer.TabIndex = 0
		Me.PictureBoxPlayer.TabStop = False
		'
		'PictureBoxRed
		'
		Me.PictureBoxRed.BackColor = System.Drawing.Color.Red
		Me.PictureBoxRed.Location = New System.Drawing.Point(142, 64)
		Me.PictureBoxRed.Name = "PictureBoxRed"
		Me.PictureBoxRed.Size = New System.Drawing.Size(50, 50)
		Me.PictureBoxRed.TabIndex = 1
		Me.PictureBoxRed.TabStop = False
		'
		'FormCollisionDetection
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(342, 226)
		Me.Controls.Add(Me.PictureBoxRed)
		Me.Controls.Add(Me.PictureBoxPlayer)
		Me.Name = "FormCollisionDetection"
		Me.Text = "Collision Detection"
		CType(Me.PictureBoxPlayer, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBoxRed, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PictureBoxPlayer As PictureBox
	Friend WithEvents PictureBoxRed As PictureBox
End Class
