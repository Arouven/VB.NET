<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
		CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DateTimePicker1
		'
		Me.DateTimePicker1.Location = New System.Drawing.Point(103, 16)
		Me.DateTimePicker1.Name = "DateTimePicker1"
		Me.DateTimePicker1.Size = New System.Drawing.Size(171, 20)
		Me.DateTimePicker1.TabIndex = 0
		Me.DateTimePicker1.Value = New Date(2020, 4, 10, 0, 0, 0, 0)
		'
		'Timer1
		'
		Me.Timer1.Interval = 500
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(91, 55)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(30, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Time"
		'
		'Timer2
		'
		Me.Timer2.Interval = 60000
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(22, 20)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(77, 13)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Set Your Alarm"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(22, 55)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(67, 13)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Current Time"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(196, 55)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(39, 13)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Label4"
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Location = New System.Drawing.Point(25, 90)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(101, 17)
		Me.CheckBox1.TabIndex = 7
		Me.CheckBox1.Text = "Beep Randomly"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'AxWindowsMediaPlayer1
		'
		Me.AxWindowsMediaPlayer1.Enabled = True
		Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(199, 84)
		Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
		Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(75, 23)
		Me.AxWindowsMediaPlayer1.TabIndex = 8
		Me.AxWindowsMediaPlayer1.Visible = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(293, 125)
		Me.Controls.Add(Me.AxWindowsMediaPlayer1)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.DateTimePicker1)
		Me.Name = "Form1"
		Me.Text = "Alarm Clock"
		CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DateTimePicker1 As DateTimePicker
	Friend WithEvents Timer1 As Timer
	Friend WithEvents Label1 As Label
	Friend WithEvents Timer2 As Timer
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
End Class
