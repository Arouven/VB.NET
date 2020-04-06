Public Class FormBouncingBall2
	Private Sub FormBouncingBall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\ball.png")
		PictureBoxBall.Image = Image.FromFile(imgPath)
		PictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage
	End Sub

	Private Sub ButtonAnimate_Click(sender As Object, e As EventArgs) Handles ButtonAnimate.Click
		Timer1.Start()
		'Timer3.Start()
	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Me.Hide()
		FormBouncingBall.Show()
	End Sub



	Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
		PictureBoxBall.Location = New Point(300, 0)
	End Sub

	Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
		Timer1.Stop()
		Timer2.Stop()
		'Timer3.Stop()
		'Timer4.Stop()
	End Sub
	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y + 5)
		If PictureBoxBall.Location.Y + (1.5 * PictureBoxBall.Height) > Me.Height Then
			'Console.WriteLine(Me.Height)
			Timer1.Stop()
			Timer2.Start()
		End If
	End Sub

	Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
		PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y - 5)
		If PictureBoxBall.Location.Y + (1.5 * PictureBoxBall.Height) < 1.5 * PictureBoxBall.Height Then
			'Console.WriteLine(Me.Height)
			Timer2.Stop()
			Timer1.Start()
		End If
	End Sub

	Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

	End Sub
End Class
