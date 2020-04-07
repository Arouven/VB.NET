Public Class frmEdit

	Dim fStyle As FontStyle
	Dim fSize As Integer

	Private Sub mnuFileNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileNew.Click
		'If user wants new file, clear out text
		Dim Response As DialogResult
		Response = MessageBox.Show("Are you sure you want to start a new file?", "New File", MessageBoxButtons.YesNo)
		If Response = DialogResult.Yes Then txtEdit.Text = ""
	End Sub

	Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
		'Make sure user really wants to exit
		Dim Response As DialogResult
		Response = MessageBox.Show("Are you sure you want to exit the note editor?", "Exit Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
		If Response = DialogResult.No Then
			Exit Sub
		Else
			Me.Close()
		End If
	End Sub

	Private Sub mnuFmtBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFmtBold.Click
		mnuFmtBold.Checked = Not (mnuFmtBold.Checked)
		fStyle = fStyle Xor FontStyle.Bold
		txtEdit.Font = New Font(txtEdit.Font.FontFamily, fSize, fStyle)
	End Sub

	Private Sub mnuFmtItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFmtItalic.Click
		mnuFmtItalic.Checked = Not (mnuFmtItalic.Checked)
		fStyle = fStyle Xor FontStyle.Italic
		txtEdit.Font = New Font(txtEdit.Font.FontFamily, fSize, fStyle)
	End Sub

	Private Sub mnuFormatUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFmtUnderline.Click
		mnuFmtUnderline.Checked = Not (mnuFmtUnderline.Checked)
		fStyle = fStyle Xor FontStyle.Underline
		txtEdit.Font = New Font(txtEdit.Font.FontFamily, fSize, fStyle)
	End Sub

	Private Sub mnuFmtSizeSmall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFmtSizeSmall.Click
		fSize = 12
		txtEdit.Font = New Font(txtEdit.Font.FontFamily, fSize, fStyle)
	End Sub

	Private Sub mnuFmtSizeMedium_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFmtSizeMedium.Click
		fSize = 15
		txtEdit.Font = New Font(txtEdit.Font.FontFamily, fSize, fStyle)
	End Sub

	Private Sub mnuFmtSizeLarge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFmtSizeLarge.Click
		fSize = 18
		txtEdit.Font = New Font(txtEdit.Font.FontFamily, fSize, fStyle)
	End Sub

	Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		txtEdit.Font = New Font(txtEdit.Font.FontFamily, 9, FontStyle.Regular)
		fSize = txtEdit.Font.Size
		fStyle = txtEdit.Font.Style
	End Sub
End Class
