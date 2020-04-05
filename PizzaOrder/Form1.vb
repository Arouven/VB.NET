Public Class FormPizzaOrder
	Private Sub FormPizzaOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub ButtonBuildPizza_Click(sender As Object, e As EventArgs) Handles ButtonBuildPizza.Click
		Dim message As String = "Where: " + ControlChars.CrLf
		'where
		If radEat.Checked Then
			message = message + radEat.Text + ControlChars.CrLf
		End If
		If radTake.Checked Then
			message = message + radTake.Text + ControlChars.CrLf
		End If
		'pizza size
		message += ControlChars.CrLf + "Size: " + ControlChars.CrLf
		If radSmall.Checked Then
			message = message + radSmall.Text + ControlChars.CrLf
		End If
		If radMedium.Checked Then
			message = message + radMedium.Text + ControlChars.CrLf
		End If
		If radLarge.Checked Then
			message = message + radLarge.Text + ControlChars.CrLf
		End If
		'pizza crust
		message += ControlChars.CrLf + "Crust: " + ControlChars.CrLf
		If radthick.Checked Then
			message = message + radthick.Text + ControlChars.CrLf
		End If
		If radthin.Checked Then
			message = message + radthin.Text + ControlChars.CrLf
		End If
		'pizza topping
		message += ControlChars.CrLf + "Topping: " + ControlChars.CrLf
		If chkCheese.Checked Then
			message = message + chkCheese.Text + ControlChars.CrLf
		End If
		If chkOnion.Checked Then
			message = message + chkOnion.Text + ControlChars.CrLf
		End If
		If chkMushroom.Checked Then
			message = message + chkMushroom.Text + ControlChars.CrLf
		End If
		If chkPepper.Checked Then
			message = message + chkPepper.Text + ControlChars.CrLf
		End If
		If chkOlive.Checked Then
			message = message + chkOlive.Text + ControlChars.CrLf
		End If
		If chkTomatoes.Checked Then
			message = message + chkTomatoes.Text + ControlChars.CrLf
		End If
		MessageBox.Show(message)
	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click

	End Sub

	Private Sub RadioButtonSmall_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSmall.CheckedChanged

	End Sub

	Private Sub RadioButtonMedium_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMedium.CheckedChanged

	End Sub

	Private Sub RadioButtonLarge_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonLarge.CheckedChanged

	End Sub

	Private Sub RadioButtonThinCrust_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonThinCrust.CheckedChanged

	End Sub

	Private Sub RadioButtonThickCrust_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonThickCrust.CheckedChanged

	End Sub

	Private Sub CheckBoxExtraCheese_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxExtraCheese.CheckedChanged

	End Sub

	Private Sub CheckBoxMushrooms_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxMushrooms.CheckedChanged

	End Sub

	Private Sub CheckBoxBlackOlive_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBlackOlive.CheckedChanged

	End Sub

	Private Sub CheckBoxOnions_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOnions.CheckedChanged

	End Sub

	Private Sub CheckBoxGreenPepper_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxGreenPepper.CheckedChanged

	End Sub

	Private Sub CheckBoxTomatoes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTomatoes.CheckedChanged

	End Sub

	Private Sub RadioButtonEateIn_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonEateIn.CheckedChanged

	End Sub

	Private Sub RadioButtonTakeOut_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonTakeOut.CheckedChanged

	End Sub
End Class
