Public Class Form1

	Private Sub btnToUpper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToUpper.Click
		Dim strLower As String
		strLower = txtLower.Text
		txtUpper.Text = strLower.ToUpper()
	End Sub
	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckEmpty.Click
		Dim FirstName As String
		FirstName = Trim(txtFname.Text)
		If FirstName = "" Then
			MsgBox("Please enter your first name in the text box")
		End If
		txtChk.Text = FirstName
	End Sub
	Private Sub btnChkChars_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkChars.Click
		Dim onechar As Char
		Dim First As String
		Dim index, Textlength As Integer
		First = Trim(txtFirst.Text)
		Textlength = First.Length
		MsgBox("Number of characters is: " & Textlength)
		For index = 0 To Textlength - 1
			onechar = First.Chars(index)
			MsgBox(onechar)
		Next
	End Sub
	Private Sub btnChkMail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChkMail.Click
		Dim string1 As String
		Dim string2 As String
		Dim position As Integer
		Dim position1 As Integer = 1
		Dim DotCom As String
		string1 = txtEmail.Text
		string2 = "@"
		position = InStr(string1, string2)
		While string1.Chars(position1) <> "."
			position1 = position1 + 1
		End While
		If position = 0 Then
			MsgBox("Not a valid email address! Please enter again")
		Else
			MsgBox("The @ sign is found at position: " & position)
			DotCom = txtEmail.Text.Substring(position1, 4)
			txtSubstr.Text = DotCom
			If DotCom.Equals(".com") Then
				MsgBox("Email address terminates with :" & DotCom)
			Else
				MsgBox("Email address does NOT terminate with :" & DotCom)
			End If
		End If
	End Sub


End Class