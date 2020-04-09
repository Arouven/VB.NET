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
		Me.txtYOB = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtBook = New System.Windows.Forms.TextBox()
		Me.txtTel = New System.Windows.Forms.TextBox()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.btnLookUp = New System.Windows.Forms.Button()
		Me.btnDelete = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'txtYOB
		'
		Me.txtYOB.Location = New System.Drawing.Point(147, 38)
		Me.txtYOB.Name = "txtYOB"
		Me.txtYOB.Size = New System.Drawing.Size(100, 20)
		Me.txtYOB.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(82, 13)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Author's Name: "
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 41)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(68, 13)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Year of Birth:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 67)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(84, 13)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Book Published:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 93)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(81, 13)
		Me.Label4.TabIndex = 4
		Me.Label4.Text = "Telephone No.:"
		'
		'txtName
		'
		Me.txtName.Location = New System.Drawing.Point(147, 12)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(100, 20)
		Me.txtName.TabIndex = 8
		'
		'txtBook
		'
		Me.txtBook.Location = New System.Drawing.Point(147, 64)
		Me.txtBook.Name = "txtBook"
		Me.txtBook.Size = New System.Drawing.Size(100, 20)
		Me.txtBook.TabIndex = 9
		'
		'txtTel
		'
		Me.txtTel.Location = New System.Drawing.Point(147, 90)
		Me.txtTel.Name = "txtTel"
		Me.txtTel.Size = New System.Drawing.Size(100, 20)
		Me.txtTel.TabIndex = 10
		'
		'btnAdd
		'
		Me.btnAdd.Location = New System.Drawing.Point(15, 116)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(232, 23)
		Me.btnAdd.TabIndex = 11
		Me.btnAdd.Text = "Add Person to File"
		Me.btnAdd.UseVisualStyleBackColor = True
		'
		'btnLookUp
		'
		Me.btnLookUp.Location = New System.Drawing.Point(15, 145)
		Me.btnLookUp.Name = "btnLookUp"
		Me.btnLookUp.Size = New System.Drawing.Size(232, 23)
		Me.btnLookUp.TabIndex = 12
		Me.btnLookUp.Text = "Search a person"
		Me.btnLookUp.UseVisualStyleBackColor = True
		'
		'btnDelete
		'
		Me.btnDelete.Location = New System.Drawing.Point(15, 174)
		Me.btnDelete.Name = "btnDelete"
		Me.btnDelete.Size = New System.Drawing.Size(232, 23)
		Me.btnDelete.TabIndex = 13
		Me.btnDelete.Text = "Delete Person from File"
		Me.btnDelete.UseVisualStyleBackColor = True
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(259, 210)
		Me.Controls.Add(Me.btnDelete)
		Me.Controls.Add(Me.btnLookUp)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.txtTel)
		Me.Controls.Add(Me.txtBook)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.txtYOB)
		Me.Name = "Form1"
		Me.Text = "Author's Details"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtYOB As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents txtBook As TextBox
	Friend WithEvents txtTel As TextBox
	Friend WithEvents btnAdd As Button
	Friend WithEvents btnLookUp As Button
	Friend WithEvents btnDelete As Button
End Class
