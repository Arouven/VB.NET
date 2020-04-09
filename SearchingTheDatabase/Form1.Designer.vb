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
		Me.dgStaff = New System.Windows.Forms.DataGridView()
		Me.txtSearch = New System.Windows.Forms.TextBox()
		Me.ButtonSearch = New System.Windows.Forms.Button()
		Me.EmpDBDataSet = New SearchingTheDatabase.EmpDBDataSet()
		Me.EmpDBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		CType(Me.dgStaff, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmpDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.EmpDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgStaff
		'
		Me.dgStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgStaff.Location = New System.Drawing.Point(12, 12)
		Me.dgStaff.Name = "dgStaff"
		Me.dgStaff.Size = New System.Drawing.Size(474, 195)
		Me.dgStaff.TabIndex = 0
		'
		'txtSearch
		'
		Me.txtSearch.Location = New System.Drawing.Point(12, 223)
		Me.txtSearch.Name = "txtSearch"
		Me.txtSearch.Size = New System.Drawing.Size(334, 20)
		Me.txtSearch.TabIndex = 1
		'
		'ButtonSearch
		'
		Me.ButtonSearch.Location = New System.Drawing.Point(352, 221)
		Me.ButtonSearch.Name = "ButtonSearch"
		Me.ButtonSearch.Size = New System.Drawing.Size(134, 23)
		Me.ButtonSearch.TabIndex = 2
		Me.ButtonSearch.Text = "Search DataGrid"
		Me.ButtonSearch.UseVisualStyleBackColor = True
		'
		'EmpDBDataSet
		'
		Me.EmpDBDataSet.DataSetName = "EmpDBDataSet"
		Me.EmpDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'EmpDBDataSetBindingSource
		'
		Me.EmpDBDataSetBindingSource.DataSource = Me.EmpDBDataSet
		Me.EmpDBDataSetBindingSource.Position = 0
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(499, 259)
		Me.Controls.Add(Me.ButtonSearch)
		Me.Controls.Add(Me.txtSearch)
		Me.Controls.Add(Me.dgStaff)
		Me.Name = "Form1"
		Me.Text = "Search The Database"
		CType(Me.dgStaff, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmpDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.EmpDBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents dgStaff As DataGridView
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents ButtonSearch As Button
	Friend WithEvents EmpDBDataSet As EmpDBDataSet
	Friend WithEvents EmpDBDataSetBindingSource As BindingSource
End Class
