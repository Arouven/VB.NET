Public Class FormSimplePongGame

	Dim move_up As Boolean = False
	Dim move_left As Boolean = False
	Dim score As Integer = 0

	Private Sub FormSimplePongGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\ball.png")
		PictureBoxBall.Image = Image.FromFile(imgPath)
		PictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage

		PictureBoxBall.Location = New Point(PictureBoxBall.Location.X + 1, PictureBoxBall.Location.Y + 1)
		LabelScore.Text = "Score: " + CStr(0)
		Timer1.Interval = 1
		Timer1.Start()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		If move_up = False Then
			PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y + 1)
		Else
			PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y - 1)
		End If

		If move_left = False Then
			PictureBoxBall.Location = New Point(PictureBoxBall.Location.X + 1, PictureBoxBall.Location.Y)
		Else
			PictureBoxBall.Location = New Point(PictureBoxBall.Location.X - 1, PictureBoxBall.Location.Y)
		End If

		If (PictureBoxBall.Location.X + (1.5 * PictureBoxBall.Width)) > Me.Width Then
			move_left = True
		End If

		If PictureBoxBall.Location.Y < 0 Then
			move_up = False
		End If

		If PictureBoxBall.Location.Y - PictureBoxBall.Height > Me.Height Then
			Timer1.Stop()
			MsgBox("Game over")
		End If

		If PictureBoxBall.Location.X < 0 Then
			move_left = False
		End If

		If (PictureBoxBall.Bounds.IntersectsWith(picObj2.Bounds)) Then
			move_up = True
			score = score + 1
			LabelScore.Text = "Score: " + CStr(score)
		End If
	End Sub
	Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
		Dim Loc As Point
		' assuming a 5-pixel move
		Select Case e.KeyCode
			Case Keys.Left ' moving to the left
				If Not picObj2.Location.X - 1 < 0 Then ' if picobj2 x coordinate -5 value Not less than(0)
					Loc = New Point(picObj2.Location.X - 3, picObj2.Location.Y) ' y	coordinates stays the same
					picObj2.Location = Loc ' pictureBox1 takes new location
				End If
			Case Keys.Right
				If Not (picObj2.Location.X + (18 + picObj2.Width)) > Me.Width Then
					Loc = New Point(picObj2.Location.X + 3, picObj2.Location.Y)
					picObj2.Location = Loc
				End If
		End Select
	End Sub
End Class

