<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.btnPrevious = New System.Windows.Forms.Button()
		Me.btnNext = New System.Windows.Forms.Button()
		Me.btnLast = New System.Windows.Forms.Button()
		Me.btnFirst = New System.Windows.Forms.Button()
		Me.btnUpdate = New System.Windows.Forms.Button()
		Me.btnCommit = New System.Windows.Forms.Button()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnAddNew = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.btnExit = New System.Windows.Forms.Button()
		Me.txtFirstName = New System.Windows.Forms.TextBox()
		Me.txtSurname = New System.Windows.Forms.TextBox()
		Me.txtRowCount = New System.Windows.Forms.TextBox()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(785, 150)
		Me.DataGridView1.TabIndex = 0
		'
		'btnPrevious
		'
		Me.btnPrevious.Location = New System.Drawing.Point(12, 168)
		Me.btnPrevious.Name = "btnPrevious"
		Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
		Me.btnPrevious.TabIndex = 1
		Me.btnPrevious.Text = "<"
		Me.btnPrevious.UseVisualStyleBackColor = True
		'
		'btnNext
		'
		Me.btnNext.Location = New System.Drawing.Point(93, 168)
		Me.btnNext.Name = "btnNext"
		Me.btnNext.Size = New System.Drawing.Size(75, 23)
		Me.btnNext.TabIndex = 2
		Me.btnNext.Text = ">"
		Me.btnNext.UseVisualStyleBackColor = True
		'
		'btnLast
		'
		Me.btnLast.Location = New System.Drawing.Point(93, 197)
		Me.btnLast.Name = "btnLast"
		Me.btnLast.Size = New System.Drawing.Size(75, 23)
		Me.btnLast.TabIndex = 3
		Me.btnLast.Text = ">>"
		Me.btnLast.UseVisualStyleBackColor = True
		'
		'btnFirst
		'
		Me.btnFirst.Location = New System.Drawing.Point(12, 197)
		Me.btnFirst.Name = "btnFirst"
		Me.btnFirst.Size = New System.Drawing.Size(75, 23)
		Me.btnFirst.TabIndex = 4
		Me.btnFirst.Text = "<<"
		Me.btnFirst.UseVisualStyleBackColor = True
		'
		'btnUpdate
		'
		Me.btnUpdate.Location = New System.Drawing.Point(12, 284)
		Me.btnUpdate.Name = "btnUpdate"
		Me.btnUpdate.Size = New System.Drawing.Size(156, 23)
		Me.btnUpdate.TabIndex = 5
		Me.btnUpdate.Text = "Update"
		Me.btnUpdate.UseVisualStyleBackColor = True
		'
		'btnCommit
		'
		Me.btnCommit.Location = New System.Drawing.Point(12, 226)
		Me.btnCommit.Name = "btnCommit"
		Me.btnCommit.Size = New System.Drawing.Size(156, 23)
		Me.btnCommit.TabIndex = 6
		Me.btnCommit.Text = "Commit"
		Me.btnCommit.UseVisualStyleBackColor = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(12, 358)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 23)
		Me.btnClear.TabIndex = 7
		Me.btnClear.Text = "Clear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnAddNew
		'
		Me.btnAddNew.Location = New System.Drawing.Point(12, 255)
		Me.btnAddNew.Name = "btnAddNew"
		Me.btnAddNew.Size = New System.Drawing.Size(156, 23)
		Me.btnAddNew.TabIndex = 8
		Me.btnAddNew.Text = "Add"
		Me.btnAddNew.UseVisualStyleBackColor = True
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(12, 313)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(156, 23)
		Me.btnDelete.TabIndex = 9
		Me.btnDelete.Text = "Delete"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(722, 358)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(75, 23)
		Me.btnExit.TabIndex = 10
		Me.btnExit.Text = "Exit"
		Me.btnExit.UseVisualStyleBackColor = True
		'
		'txtFirstName
		'
		Me.txtFirstName.Location = New System.Drawing.Point(591, 316)
		Me.txtFirstName.Name = "txtFirstName"
		Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
		Me.txtFirstName.TabIndex = 11
		'
		'txtSurname
		'
		Me.txtSurname.Location = New System.Drawing.Point(697, 316)
		Me.txtSurname.Name = "txtSurname"
		Me.txtSurname.Size = New System.Drawing.Size(100, 20)
		Me.txtSurname.TabIndex = 12
		'
		'txtRowCount
		'
		Me.txtRowCount.Location = New System.Drawing.Point(591, 171)
		Me.txtRowCount.Name = "txtRowCount"
		Me.txtRowCount.Size = New System.Drawing.Size(206, 20)
		Me.txtRowCount.TabIndex = 13
		'
		'Form3
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(809, 395)
		Me.Controls.Add(Me.txtRowCount)
		Me.Controls.Add(Me.txtSurname)
		Me.Controls.Add(Me.txtFirstName)
		Me.Controls.Add(Me.btnExit)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnAddNew)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.btnCommit)
		Me.Controls.Add(Me.btnUpdate)
		Me.Controls.Add(Me.btnFirst)
		Me.Controls.Add(Me.btnLast)
		Me.Controls.Add(Me.btnNext)
		Me.Controls.Add(Me.btnPrevious)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "Form3"
		Me.Text = "Update dB with TextBoxes and DataGrid"
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents btnPrevious As Button
	Friend WithEvents btnNext As Button
	Friend WithEvents btnLast As Button
	Friend WithEvents btnFirst As Button
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnCommit As Button
	Friend WithEvents btnClear As Button
	Friend WithEvents btnAddNew As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnExit As Button
	Friend WithEvents txtFirstName As TextBox
	Friend WithEvents txtSurname As TextBox
	Friend WithEvents txtRowCount As TextBox
End Class
