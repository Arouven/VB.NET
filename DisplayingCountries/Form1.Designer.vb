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
		Me.btnDisplayFile = New System.Windows.Forms.Button()
		Me.btnCreateFile = New System.Windows.Forms.Button()
		Me.lstCountry = New System.Windows.Forms.ListBox()
		Me.SuspendLayout()
		'
		'btnDisplayFile
		'
		Me.btnDisplayFile.Location = New System.Drawing.Point(12, 84)
		Me.btnDisplayFile.Name = "btnDisplayFile"
		Me.btnDisplayFile.Size = New System.Drawing.Size(91, 23)
		Me.btnDisplayFile.TabIndex = 0
		Me.btnDisplayFile.Text = "Display File"
		Me.btnDisplayFile.UseVisualStyleBackColor = True
		'
		'btnCreateFile
		'
		Me.btnCreateFile.Location = New System.Drawing.Point(12, 12)
		Me.btnCreateFile.Name = "btnCreateFile"
		Me.btnCreateFile.Size = New System.Drawing.Size(91, 23)
		Me.btnCreateFile.TabIndex = 1
		Me.btnCreateFile.Text = "Create File"
		Me.btnCreateFile.UseVisualStyleBackColor = True
		'
		'lstCountry
		'
		Me.lstCountry.FormattingEnabled = True
		Me.lstCountry.Location = New System.Drawing.Point(109, 12)
		Me.lstCountry.Name = "lstCountry"
		Me.lstCountry.Size = New System.Drawing.Size(159, 95)
		Me.lstCountry.TabIndex = 2
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(281, 118)
		Me.Controls.Add(Me.lstCountry)
		Me.Controls.Add(Me.btnCreateFile)
		Me.Controls.Add(Me.btnDisplayFile)
		Me.Name = "Form1"
		Me.Text = "Displaying Countries"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnDisplayFile As Button
	Friend WithEvents btnCreateFile As Button
	Friend WithEvents lstCountry As ListBox
End Class
