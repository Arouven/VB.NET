Imports System.IO

Public Class Form1
	Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
		'Add a person's name and year of birth to file
		Dim message As String
		If (txtName.Text <> "") And (txtYOB.Text <> "") And (txtBook.Text <> "") And (txtTel.Text <> "") Then
			Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			Dim mysw As StreamWriter = File.AppendText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\author.TXT")
			mysw.WriteLine(txtName.Text)
			mysw.WriteLine(txtYOB.Text)
			mysw.WriteLine(txtBook.Text)
			mysw.WriteLine(txtTel.Text)
			mysw.Close()
			txtName.Clear()
			txtYOB.Clear()
			txtBook.Clear()
			txtTel.Clear()
			txtName.Focus()
		Else
			message = "You must enter all details about the author."
			MessageBox.Show(message, "Information Incomplete", MessageBoxButtons.OK)
		End If
	End Sub

	Private Sub btnLookUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookUp.Click
		'Determine a person's year of birth
		Dim message As String
		If txtName.Text <> "" Then
			If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\author.TXT") Then
				DisplayYearOfBirth()
			Else
				message = "Either no file has yet been created or "
				message = message & "the file is not where expected."
				MessageBox.Show(message, "File Not Found",
				MessageBoxButtons.OK)
			End If
		Else
			MessageBox.Show("You must enter a name.", "Information Incomplete", MessageBoxButtons.OK)
		End If
		txtName.Focus()
	End Sub

	Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
		'Remove a person from the file
		Dim message As String
		If txtName.Text <> "" Then
			If File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\author.TXT") Then
				DeletePerson()
				MessageBox.Show("The record for author " + txtName.Text + " is deleted " + ControlChars.CrLf + "permanently from the file", "Information", MessageBoxButtons.OK)
			Else
				message = "Either no file has yet been created or "
				message = message & "the file is not where expected."
				MessageBox.Show(message, "File Not Found.", MessageBoxButtons.OK)
			End If
		Else
			MessageBox.Show("You must enter a name.", "Information Incomplete", MessageBoxButtons.OK)
		End If
		txtName.Focus()
	End Sub



	Private Sub DisplayYearOfBirth()
		'Find the year of birth for the person in txtName
		Dim name As String, yob As Integer, book As String, telephone As String
		Dim mes As String
		txtYOB.Clear()
		txtBook.Clear()
		txtTel.Clear()
		Dim mysr As StreamReader = File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\author.TXT")
		Do While (name <> txtName.Text) And (mysr.Peek <> -1)
			name = mysr.ReadLine
			yob = CInt(mysr.ReadLine)
			book = mysr.ReadLine
			telephone = mysr.ReadLine
		Loop
		If name = txtName.Text Then
			mes = name + " was born in " + CStr(yob) + ControlChars.CrLf
			mes += "Book published is " + book + " and the telephone No is " + telephone
			MessageBox.Show(mes, "Name Found", MessageBoxButtons.OK)
			txtName.Clear()
			txtYOB.Clear()
			txtBook.Clear()
			txtTel.Clear()
		Else
			MessageBox.Show("Person is not in file.", "Informaion", MessageBoxButtons.OK)
			txtName.Clear()
		End If
		mysr.Close()
	End Sub

	Private Sub DeletePerson()
		'Remove the person in txtName from the file
		Dim name As String, yob As Integer, book As String, telephone As String
		Dim foundFlag As Boolean = False
		Dim mysr As StreamReader = File.OpenText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\author.TXT")
		Dim mysw As StreamWriter = File.CreateText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\authorTemp.TXT")
		Do While (mysr.Peek <> -1)
			name = mysr.ReadLine
			yob = CInt(mysr.ReadLine)
			book = mysr.ReadLine
			telephone = mysr.ReadLine
			If (name <> txtName.Text) Then
				mysw.WriteLine(name)
				mysw.WriteLine(yob)
				mysw.WriteLine(book)
				mysw.WriteLine(telephone)
			Else
				foundFlag = True
			End If
		Loop

		mysr.Close()
		mysw.Close()
		File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\author.TXT")
		File.Move(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\authorTemp.TXT", Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\author.TXT") 'Rename"authorTemp.TXT" As "author.TXT"
		If Not foundFlag Then
			MessageBox.Show("The name was not found.", "Information",
			MessageBoxButtons.OK)
		Else
			txtName.Clear()
			txtYOB.Clear()
			txtBook.Clear()
			txtTel.Clear()
		End If
	End Sub
End Class
