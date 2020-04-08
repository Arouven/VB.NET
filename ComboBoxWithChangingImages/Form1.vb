Public Class Form1

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		End
	End Sub

	Private Sub cboDrink_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDrink.SelectedIndexChanged

		Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\")
		picDrink.Image = Image.FromFile(CStr(imgPath + cboDrink.Text + ".png"))
		picDrink.SizeMode = PictureBoxSizeMode.StretchImage
	End Sub

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\")
		Dim di As New IO.DirectoryInfo(imgPath)
		Dim aryFi As IO.FileInfo() = di.GetFiles("*.png")

		For Each fi As IO.FileInfo In aryFi
			cboDrink.Items.Add(fi.Name.Replace(".png", ""))
		Next

		cboDrink.SelectedIndex = 0
	End Sub
End Class