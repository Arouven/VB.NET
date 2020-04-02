<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDotNetTech
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDotNetTech))
		Me.RtxtQA = New System.Windows.Forms.RichTextBox()
		Me.LblDotNetTechnologies = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'RtxtQA
		'
		Me.RtxtQA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.RtxtQA.Location = New System.Drawing.Point(12, 70)
		Me.RtxtQA.Name = "RtxtQA"
		Me.RtxtQA.Size = New System.Drawing.Size(776, 368)
		Me.RtxtQA.TabIndex = 0
		Me.RtxtQA.Text = resources.GetString("RtxtQA.Text")
		'
		'LblDotNetTechnologies
		'
		Me.LblDotNetTechnologies.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblDotNetTechnologies.Font = New System.Drawing.Font("Arial Black", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDotNetTechnologies.Location = New System.Drawing.Point(12, 9)
		Me.LblDotNetTechnologies.Name = "LblDotNetTechnologies"
		Me.LblDotNetTechnologies.Size = New System.Drawing.Size(776, 50)
		Me.LblDotNetTechnologies.TabIndex = 1
		Me.LblDotNetTechnologies.Text = ".NET Technologies"
		Me.LblDotNetTechnologies.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'FrmDotNetTech
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.LblDotNetTechnologies)
		Me.Controls.Add(Me.RtxtQA)
		Me.Name = "FrmDotNetTech"
		Me.Text = ".NET Technologies Questions & Answers"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents RtxtQA As RichTextBox
	Friend WithEvents LblDotNetTechnologies As Label
End Class
