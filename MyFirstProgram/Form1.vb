Public Class MyFirstProgram
	Private Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click
		TxtDisplay.Text = "Hello World"
	End Sub

	Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
		TxtDisplay.Text = ""
	End Sub

	Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
		Me.Close()
	End Sub
End Class
