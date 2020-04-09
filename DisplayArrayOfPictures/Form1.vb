Public Class Form1

	Private mImages As ArrayList = New ArrayList()
	Dim mCount As Integer = 0
	Dim numOfPic As Integer = 12

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		' load all images
		Dim i As Integer
		' loop for 13 pictures and place them in array list
		For i = 0 To numOfPic
			mImages.Add(Image.FromFile(AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\" & i & ".png")))
			'Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\" & i & ".png"))
		Next
		' load first image
		logoPictureBox.Image = CType(mImages(0), Image)
		logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
	End Sub
	Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
		' increment counter
		mCount = mCount + 1
		Timer1.Interval = 3000
		txtmCount.text = mCount.ToString()
		'load next image if mCount <= numOfPic
		If (mCount <= numOfPic) Then
			logoPictureBox.Image = CType(mImages(mCount), Image)
			logoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
		Else
			Timer1.Enabled = False
			txtMsg.Text = "No more pictures to display"
		End If
	End Sub


End Class