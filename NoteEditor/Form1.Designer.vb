<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
		Me.txtEdit = New System.Windows.Forms.TextBox()
		Me.mnu = New System.Windows.Forms.MenuStrip()
		Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFileBar = New System.Windows.Forms.ToolStripSeparator()
		Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFmt = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFmtBold = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFmtItalic = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFmtUnderline = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFmtSize = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFmtSizeSmall = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFmtSizeMedium = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFmtSizeLarge = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnuFmtSizeNormal = New System.Windows.Forms.ToolStripMenuItem()
		Me.mnu.SuspendLayout()
		Me.SuspendLayout()
		'
		'txtEdit
		'
		Me.txtEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.txtEdit.Location = New System.Drawing.Point(12, 27)
		Me.txtEdit.Multiline = True
		Me.txtEdit.Name = "txtEdit"
		Me.txtEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtEdit.Size = New System.Drawing.Size(244, 103)
		Me.txtEdit.TabIndex = 0
		'
		'mnu
		'
		Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuFmt})
		Me.mnu.Location = New System.Drawing.Point(0, 0)
		Me.mnu.Name = "mnu"
		Me.mnu.Size = New System.Drawing.Size(268, 24)
		Me.mnu.TabIndex = 1
		Me.mnu.Text = "MenuStrip1"
		'
		'mnuFile
		'
		Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileBar, Me.mnuFileExit})
		Me.mnuFile.Name = "mnuFile"
		Me.mnuFile.Size = New System.Drawing.Size(37, 20)
		Me.mnuFile.Text = "&File"
		'
		'mnuFileNew
		'
		Me.mnuFileNew.Name = "mnuFileNew"
		Me.mnuFileNew.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.mnuFileNew.Size = New System.Drawing.Size(141, 22)
		Me.mnuFileNew.Text = "&New"
		'
		'mnuFileBar
		'
		Me.mnuFileBar.Name = "mnuFileBar"
		Me.mnuFileBar.Size = New System.Drawing.Size(138, 6)
		'
		'mnuFileExit
		'
		Me.mnuFileExit.Name = "mnuFileExit"
		Me.mnuFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
		Me.mnuFileExit.Size = New System.Drawing.Size(141, 22)
		Me.mnuFileExit.Text = "E&xit"
		'
		'mnuFmt
		'
		Me.mnuFmt.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFmtBold, Me.mnuFmtItalic, Me.mnuFmtUnderline, Me.mnuFmtSize})
		Me.mnuFmt.Name = "mnuFmt"
		Me.mnuFmt.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.mnuFmt.Size = New System.Drawing.Size(57, 20)
		Me.mnuFmt.Text = "F&ormat"
		'
		'mnuFmtBold
		'
		Me.mnuFmtBold.Name = "mnuFmtBold"
		Me.mnuFmtBold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
		Me.mnuFmtBold.Size = New System.Drawing.Size(167, 22)
		Me.mnuFmtBold.Text = "&Bold"
		'
		'mnuFmtItalic
		'
		Me.mnuFmtItalic.Name = "mnuFmtItalic"
		Me.mnuFmtItalic.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
		Me.mnuFmtItalic.Size = New System.Drawing.Size(167, 22)
		Me.mnuFmtItalic.Text = "&Italic"
		'
		'mnuFmtUnderline
		'
		Me.mnuFmtUnderline.Name = "mnuFmtUnderline"
		Me.mnuFmtUnderline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
		Me.mnuFmtUnderline.Size = New System.Drawing.Size(167, 22)
		Me.mnuFmtUnderline.Text = "&Underline"
		'
		'mnuFmtSize
		'
		Me.mnuFmtSize.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFmtSizeNormal, Me.mnuFmtSizeSmall, Me.mnuFmtSizeMedium, Me.mnuFmtSizeLarge})
		Me.mnuFmtSize.Name = "mnuFmtSize"
		Me.mnuFmtSize.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.mnuFmtSize.Size = New System.Drawing.Size(167, 22)
		Me.mnuFmtSize.Text = "&Size"
		'
		'mnuFmtSizeSmall
		'
		Me.mnuFmtSizeSmall.Name = "mnuFmtSizeSmall"
		Me.mnuFmtSizeSmall.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.mnuFmtSizeSmall.Size = New System.Drawing.Size(196, 22)
		Me.mnuFmtSizeSmall.Text = "$Small"
		'
		'mnuFmtSizeMedium
		'
		Me.mnuFmtSizeMedium.Name = "mnuFmtSizeMedium"
		Me.mnuFmtSizeMedium.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
		Me.mnuFmtSizeMedium.Size = New System.Drawing.Size(196, 22)
		Me.mnuFmtSizeMedium.Text = "&Medium"
		'
		'mnuFmtSizeLarge
		'
		Me.mnuFmtSizeLarge.Name = "mnuFmtSizeLarge"
		Me.mnuFmtSizeLarge.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
		Me.mnuFmtSizeLarge.Size = New System.Drawing.Size(196, 22)
		Me.mnuFmtSizeLarge.Text = "&Large"
		'
		'mnuFmtSizeNormal
		'
		Me.mnuFmtSizeNormal.Name = "mnuFmtSizeNormal"
		Me.mnuFmtSizeNormal.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
		Me.mnuFmtSizeNormal.Size = New System.Drawing.Size(196, 22)
		Me.mnuFmtSizeNormal.Text = "No&rmal"
		'
		'frmEdit
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(268, 142)
		Me.Controls.Add(Me.txtEdit)
		Me.Controls.Add(Me.mnu)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.MainMenuStrip = Me.mnu
		Me.Name = "frmEdit"
		Me.Text = "Note Editor"
		Me.mnu.ResumeLayout(False)
		Me.mnu.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents txtEdit As TextBox
	Friend WithEvents mnu As MenuStrip
	Friend WithEvents mnuFile As ToolStripMenuItem
	Friend WithEvents mnuFileNew As ToolStripMenuItem
	Friend WithEvents mnuFmt As ToolStripMenuItem
	Friend WithEvents mnuFileBar As ToolStripSeparator
	Friend WithEvents mnuFileExit As ToolStripMenuItem
	Friend WithEvents mnuFmtBold As ToolStripMenuItem
	Friend WithEvents mnuFmtItalic As ToolStripMenuItem
	Friend WithEvents mnuFmtUnderline As ToolStripMenuItem
	Friend WithEvents mnuFmtSize As ToolStripMenuItem
	Friend WithEvents mnuFmtSizeSmall As ToolStripMenuItem
	Friend WithEvents mnuFmtSizeMedium As ToolStripMenuItem
	Friend WithEvents mnuFmtSizeLarge As ToolStripMenuItem
	Friend WithEvents mnuFmtSizeNormal As ToolStripMenuItem
End Class
