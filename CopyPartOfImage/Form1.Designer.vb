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
		Me.picOriginal = New System.Windows.Forms.PictureBox()
		Me.txtTop = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtLeft = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtWidth = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtHeight = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.btnCopy = New System.Windows.Forms.Button()
		Me.picResult = New System.Windows.Forms.PictureBox()
		Me.LabelSize = New System.Windows.Forms.Label()
		CType(Me.picOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picResult, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'picOriginal
		'
		Me.picOriginal.Location = New System.Drawing.Point(12, 12)
		Me.picOriginal.Name = "picOriginal"
		Me.picOriginal.Size = New System.Drawing.Size(213, 239)
		Me.picOriginal.TabIndex = 0
		Me.picOriginal.TabStop = False
		'
		'txtTop
		'
		Me.txtTop.Location = New System.Drawing.Point(277, 12)
		Me.txtTop.Name = "txtTop"
		Me.txtTop.Size = New System.Drawing.Size(61, 20)
		Me.txtTop.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(231, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(29, 13)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Top:"
		'
		'txtLeft
		'
		Me.txtLeft.Location = New System.Drawing.Point(277, 38)
		Me.txtLeft.Name = "txtLeft"
		Me.txtLeft.Size = New System.Drawing.Size(61, 20)
		Me.txtLeft.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(232, 41)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(28, 13)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Left:"
		'
		'txtWidth
		'
		Me.txtWidth.Location = New System.Drawing.Point(277, 64)
		Me.txtWidth.Name = "txtWidth"
		Me.txtWidth.Size = New System.Drawing.Size(61, 20)
		Me.txtWidth.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(232, 67)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(38, 13)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "Width:"
		'
		'txtHeight
		'
		Me.txtHeight.Location = New System.Drawing.Point(277, 90)
		Me.txtHeight.Name = "txtHeight"
		Me.txtHeight.Size = New System.Drawing.Size(61, 20)
		Me.txtHeight.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(232, 93)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(41, 13)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "Height:"
		'
		'btnCopy
		'
		Me.btnCopy.Location = New System.Drawing.Point(235, 228)
		Me.btnCopy.Name = "btnCopy"
		Me.btnCopy.Size = New System.Drawing.Size(103, 23)
		Me.btnCopy.TabIndex = 9
		Me.btnCopy.Text = "Copy"
		Me.btnCopy.UseVisualStyleBackColor = True
		'
		'picResult
		'
		Me.picResult.Location = New System.Drawing.Point(344, 12)
		Me.picResult.Name = "picResult"
		Me.picResult.Size = New System.Drawing.Size(213, 239)
		Me.picResult.TabIndex = 10
		Me.picResult.TabStop = False
		'
		'LabelSize
		'
		Me.LabelSize.Location = New System.Drawing.Point(235, 113)
		Me.LabelSize.Name = "LabelSize"
		Me.LabelSize.Size = New System.Drawing.Size(103, 112)
		Me.LabelSize.TabIndex = 11
		Me.LabelSize.Text = "Label5"
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(572, 265)
		Me.Controls.Add(Me.LabelSize)
		Me.Controls.Add(Me.picResult)
		Me.Controls.Add(Me.btnCopy)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.txtHeight)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.txtWidth)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.txtLeft)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtTop)
		Me.Controls.Add(Me.picOriginal)
		Me.Name = "Form1"
		Me.Text = "Copy part of image"
		CType(Me.picOriginal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.picResult, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents picOriginal As PictureBox
	Friend WithEvents txtTop As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents txtLeft As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents txtWidth As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtHeight As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents btnCopy As Button
	Friend WithEvents picResult As PictureBox
	Friend WithEvents LabelSize As Label
End Class
