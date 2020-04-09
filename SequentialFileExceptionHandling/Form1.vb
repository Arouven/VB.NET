Public Class Form1

	Private Sub cmdDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplay.Click
		Dim mysr As IO.StreamReader
		Dim message As String
		Try
			mysr = IO.File.OpenText("F:\author.txt")
			MessageBox.Show("The Author's name is " + mysr.ReadLine, "Information ", MessageBoxButtons.OK)
		Catch exp As IO.DirectoryNotFoundException
			MessageBox.Show("Check to see if the mobile is connected", "Information Error: " + CStr(Err.Number), MessageBoxButtons.OK)
		Catch exp As IO.FileNotFoundException
			MessageBox.Show("The file does not exist in this directory", "Information Error: " + CStr(Err.Number),
			MessageBoxButtons.OK)
		Catch
			MessageBox.Show("Something has gone wrong", "Information Error", MessageBoxButtons.OK)
		Finally
			Try
				mysr.Close() 'clean-Up - It protects from any exceptions that might occur.
			Catch
			End Try
		End Try
	End Sub
End Class
