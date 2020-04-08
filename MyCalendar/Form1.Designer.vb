<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMyCalendar
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
		Me.LblDay = New System.Windows.Forms.Label()
		Me.TimerCalendar = New System.Windows.Forms.Timer(Me.components)
		Me.LblTime = New System.Windows.Forms.Label()
		Me.LblMonth = New System.Windows.Forms.Label()
		Me.LblDate = New System.Windows.Forms.Label()
		Me.LblYear = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'LblDay
		'
		Me.LblDay.AutoSize = True
		Me.LblDay.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDay.Location = New System.Drawing.Point(12, 34)
		Me.LblDay.Name = "LblDay"
		Me.LblDay.Size = New System.Drawing.Size(53, 26)
		Me.LblDay.TabIndex = 0
		Me.LblDay.Text = "Day"
		'
		'TimerCalendar
		'
		Me.TimerCalendar.Enabled = True
		'
		'LblTime
		'
		Me.LblTime.AutoSize = True
		Me.LblTime.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblTime.Location = New System.Drawing.Point(12, 117)
		Me.LblTime.Name = "LblTime"
		Me.LblTime.Size = New System.Drawing.Size(64, 26)
		Me.LblTime.TabIndex = 1
		Me.LblTime.Text = "Time"
		'
		'LblMonth
		'
		Me.LblMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblMonth.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblMonth.Location = New System.Drawing.Point(171, 92)
		Me.LblMonth.Name = "LblMonth"
		Me.LblMonth.Size = New System.Drawing.Size(159, 36)
		Me.LblMonth.TabIndex = 2
		Me.LblMonth.Text = "Month"
		Me.LblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LblDate
		'
		Me.LblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblDate.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDate.Location = New System.Drawing.Point(171, 9)
		Me.LblDate.Name = "LblDate"
		Me.LblDate.Size = New System.Drawing.Size(159, 83)
		Me.LblDate.TabIndex = 3
		Me.LblDate.Text = "Date"
		Me.LblDate.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'LblYear
		'
		Me.LblYear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblYear.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblYear.Location = New System.Drawing.Point(171, 128)
		Me.LblYear.Name = "LblYear"
		Me.LblYear.Size = New System.Drawing.Size(159, 36)
		Me.LblYear.TabIndex = 4
		Me.LblYear.Text = "Year"
		Me.LblYear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'FrmMyCalendar
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(337, 187)
		Me.Controls.Add(Me.LblYear)
		Me.Controls.Add(Me.LblDate)
		Me.Controls.Add(Me.LblMonth)
		Me.Controls.Add(Me.LblTime)
		Me.Controls.Add(Me.LblDay)
		Me.Name = "FrmMyCalendar"
		Me.Text = "My Calendar"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LblDay As Label
	Friend WithEvents TimerCalendar As Timer
	Friend WithEvents LblTime As Label
	Friend WithEvents LblMonth As Label
	Friend WithEvents LblDate As Label
	Friend WithEvents LblYear As Label
End Class
