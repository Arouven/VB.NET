Public Class FormCollisionDetection

	Public Function RandomNumber(ByVal MaxNumber As Integer, Optional ByVal MinNumber As Integer = 0) As Integer 'initialize random number generator- it will generate new number when time changes
		Dim r As New Random(System.DateTime.Now.Millisecond) ' based on actual current time
		'if MinNumber > MaxNumber, swap them
		' a 3-step swapping is done here
		If MinNumber > MaxNumber Then
			Dim temp As Integer = MinNumber
			MinNumber = MaxNumber
			MaxNumber = temp
		End If
		' Use the Next method of the Random Class which requires two parameters

		Return r.Next(MinNumber, MaxNumber)
	End Function

	Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
		Dim Loc As Point
		' assuming a 5-pixel move
		Select Case e.KeyCode
			Case Keys.Left ' moving to the left
				If Not PictureBoxPlayer.Location.X - 5 < 0 Then ' if picPlayer x coordinate -5 value not less than 0
					Loc = New Point(PictureBoxPlayer.Location.X - 5, PictureBoxPlayer.Location.Y) ' y coordinates stays the same
					PictureBoxPlayer.Location = Loc ' picPlayer takes new location
				End If
			Case Keys.Right
				If Not PictureBoxPlayer.Location.X + 5 > Me.Width - PictureBoxPlayer.Width - 5 Then
					Loc = New Point(PictureBoxPlayer.Location.X + 5, PictureBoxPlayer.Location.Y)
					PictureBoxPlayer.Location = Loc
				End If
			Case Keys.Up
				If Not PictureBoxPlayer.Location.Y - 5 < 0 Then
					Loc = New Point(PictureBoxPlayer.Location.X, PictureBoxPlayer.Location.Y - 5)
					PictureBoxPlayer.Location = Loc
				End If
			Case Keys.Down
				If Not PictureBoxPlayer.Location.Y - 5 > Me.Height - PictureBoxPlayer.Height * 2 Then ' picPlayer.height * 2 so that it does Not cross lower limit of form
					Loc = New Point(PictureBoxPlayer.Location.X, PictureBoxPlayer.Location.Y + 5)
					PictureBoxPlayer.Location = Loc
				End If
		End Select
		' we check if picPlayer hit picObj2
		If PictureBoxPlayer.Bounds.IntersectsWith(PictureBoxRed.Bounds) Then
			PictureBoxRed.Hide()
			PictureBoxRed.Location = New Point(RandomNumber(Me.Width), RandomNumber(Me.Height))
			MsgBox("You have hit the target")
			PictureBoxRed.Show()
		End If
	End Sub
End Class