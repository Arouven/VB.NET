<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.logoPictureBox = New System.Windows.Forms.PictureBox()
		Me.txtmCount = New System.Windows.Forms.TextBox()
		Me.txtMsg = New System.Windows.Forms.TextBox()
		CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		'
		'logoPictureBox
		'
		Me.logoPictureBox.Location = New System.Drawing.Point(12, 12)
		Me.logoPictureBox.Name = "logoPictureBox"
		Me.logoPictureBox.Size = New System.Drawing.Size(371, 219)
		Me.logoPictureBox.TabIndex = 0
		Me.logoPictureBox.TabStop = False
		'
		'txtmCount
		'
		Me.txtmCount.Enabled = False
		Me.txtmCount.Location = New System.Drawing.Point(12, 237)
		Me.txtmCount.Name = "txtmCount"
		Me.txtmCount.Size = New System.Drawing.Size(51, 20)
		Me.txtmCount.TabIndex = 1
		'
		'txtMsg
		'
		Me.txtMsg.Enabled = False
		Me.txtMsg.Location = New System.Drawing.Point(69, 237)
		Me.txtMsg.Name = "txtMsg"
		Me.txtMsg.Size = New System.Drawing.Size(314, 20)
		Me.txtMsg.TabIndex = 2
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(395, 273)
		Me.Controls.Add(Me.txtMsg)
		Me.Controls.Add(Me.txtmCount)
		Me.Controls.Add(Me.logoPictureBox)
		Me.Name = "Form1"
		Me.Text = "Pictures in arraylist"
		CType(Me.logoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Timer1 As Timer
	Friend WithEvents logoPictureBox As PictureBox
	Friend WithEvents txtmCount As TextBox
	Friend WithEvents txtMsg As TextBox
End Class
