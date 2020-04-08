
Public Class Form1

	' Copy part of the original image.
	Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
		Dim top As Integer = Integer.Parse(txtTop.Text)
		Dim left As Integer = Integer.Parse(txtLeft.Text)
		Dim width As Integer = Integer.Parse(txtWidth.Text)
		Dim height As Integer = Integer.Parse(txtHeight.Text)
		' Make a Bitmap to hold the result.
		Dim bm As New Bitmap(width, height)
		' Associate a Graphics object with the Bitmap
		Using gr As Graphics = Graphics.FromImage(bm)
			' Define source and destination rectangles.
			Dim src_rect As New Rectangle(left, top, width, height)
			Dim dst_rect As New Rectangle(0, 0, width, height)
			' Copy that part of the image.
			gr.DrawImage(picOriginal.Image, dst_rect, src_rect, GraphicsUnit.Pixel)
		End Using
		' Display the result.
		picResult.Image = bm
		picResult.SizeMode = PictureBoxSizeMode.StretchImage
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\picture.png")
		picOriginal.Image = Image.FromFile(imgPath)
		picOriginal.SizeMode = PictureBoxSizeMode.StretchImage

		Dim topImage As Integer = 0
		Dim leftImage As Integer = 0
		Dim widthImage As Integer = Image.FromFile(imgPath).Width
		Dim heightImage As Integer = Image.FromFile(imgPath).Height

		LabelSize.Text = vbCrLf & "Current image has: " & vbCrLf & vbCrLf & "Top: " & topImage & vbCrLf & "Left: " & leftImage & vbCrLf & "Width: " & widthImage & vbCrLf & "Height: " & heightImage
	End Sub

End Class
