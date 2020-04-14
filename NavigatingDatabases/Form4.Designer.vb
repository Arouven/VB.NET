<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
		Me.btnLoad = New System.Windows.Forms.Button()
		Me.btnSave = New System.Windows.Forms.Button()
		Me.dgvDisplay = New System.Windows.Forms.DataGridView()
		CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'btnLoad
		'
		Me.btnLoad.Location = New System.Drawing.Point(12, 317)
		Me.btnLoad.Name = "btnLoad"
		Me.btnLoad.Size = New System.Drawing.Size(137, 23)
		Me.btnLoad.TabIndex = 0
		Me.btnLoad.Text = "Load table from dB"
		Me.btnLoad.UseVisualStyleBackColor = True
		'
		'btnSave
		'
		Me.btnSave.Location = New System.Drawing.Point(714, 317)
		Me.btnSave.Name = "btnSave"
		Me.btnSave.Size = New System.Drawing.Size(137, 23)
		Me.btnSave.TabIndex = 1
		Me.btnSave.Text = "Save changes to dB"
		Me.btnSave.UseVisualStyleBackColor = True
		'
		'dgvDisplay
		'
		Me.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvDisplay.Location = New System.Drawing.Point(12, 12)
		Me.dgvDisplay.Name = "dgvDisplay"
		Me.dgvDisplay.Size = New System.Drawing.Size(839, 299)
		Me.dgvDisplay.TabIndex = 2
		'
		'Form4
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(863, 354)
		Me.Controls.Add(Me.dgvDisplay)
		Me.Controls.Add(Me.btnSave)
		Me.Controls.Add(Me.btnLoad)
		Me.Name = "Form4"
		Me.Text = "Update dB with DataGrid"
		CType(Me.dgvDisplay, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnLoad As Button
	Friend WithEvents btnSave As Button
	Friend WithEvents dgvDisplay As DataGridView
End Class
