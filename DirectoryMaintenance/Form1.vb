Imports System.IO

Public Class Form1

	Private Sub cmdCreateDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreateDirectory.Click
		Try
			If txtDirectory.Text <> "" Then
				Directory.CreateDirectory(txtDirectory.Text)
				'Creating a directory by specifying a path in the				TextBox, say you specified c:    \examples
				'where example is the name of the created directory
				MessageBox.Show("Directory is succesfully created", "Information", MessageBoxButtons.OK)
			Else
				MessageBox.Show("Please enter a directory's name", "Information", MessageBoxButtons.OK)
				txtDirectory.Focus()
			End If
		Catch
		End Try
	End Sub

	Private Sub cmdcopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCopy.Click
		Try
			If OpenFileDialog1.ShowDialog <> DialogResult.Cancel Then
				File.Copy(OpenFileDialog1.FileName, txtDirectory.Text & "\" & OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\")))
				'The above line of code uses OpenFileDialog control to open a dialog box where you can select a file to copy into the newly Created Directory
				MessageBox.Show("File Copied Successfully", "Information", MessageBoxButtons.OK)
			End If

		Catch
			MessageBox.Show("The directory does not exist", "Error Information", MessageBoxButtons.OK)
		End Try
	End Sub
End Class
