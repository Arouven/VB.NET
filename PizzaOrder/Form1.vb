Public Class FormPizzaOrder


	Private Sub ButtonBuildPizza_Click(sender As Object, e As EventArgs) Handles ButtonBuildPizza.Click
		Dim message As String = "Where: " + ControlChars.CrLf
		'where
		If RadioButtonEateIn.Checked Then
			message = message + RadioButtonEateIn.Text + ControlChars.CrLf
		End If
		If RadioButtonTakeOut.Checked Then
			message = message + RadioButtonTakeOut.Text + ControlChars.CrLf
		End If
		'pizza size
		message += ControlChars.CrLf + "Size: " + ControlChars.CrLf
		If RadioButtonSmall.Checked Then
			message = message + RadioButtonSmall.Text + ControlChars.CrLf
		End If
		If RadioButtonMedium.Checked Then
			message = message + RadioButtonMedium.Text + ControlChars.CrLf
		End If
		If RadioButtonLarge.Checked Then
			message = message + RadioButtonLarge.Text + ControlChars.CrLf
		End If
		'pizza crust
		message += ControlChars.CrLf + "Crust: " + ControlChars.CrLf
		If RadioButtonThickCrust.Checked Then
			message = message + RadioButtonThickCrust.Text + ControlChars.CrLf
		End If
		If RadioButtonThinCrust.Checked Then
			message = message + RadioButtonThinCrust.Text + ControlChars.CrLf
		End If
		'pizza topping
		message += ControlChars.CrLf + "Topping: " + ControlChars.CrLf
		If CheckBoxExtraCheese.Checked Then
			message = message + CheckBoxExtraCheese.Text + ControlChars.CrLf
		End If
		If CheckBoxOnions.Checked Then
			message = message + CheckBoxOnions.Text + ControlChars.CrLf
		End If
		If CheckBoxMushrooms.Checked Then
			message = message + CheckBoxMushrooms.Text + ControlChars.CrLf
		End If
		If CheckBoxGreenPepper.Checked Then
			message = message + CheckBoxGreenPepper.Text + ControlChars.CrLf
		End If
		If CheckBoxBlackOlive.Checked Then
			message = message + CheckBoxBlackOlive.Text + ControlChars.CrLf
		End If
		If CheckBoxTomatoes.Checked Then
			message = message + CheckBoxTomatoes.Text + ControlChars.CrLf
		End If
		MessageBox.Show(message)
	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Me.Close()
	End Sub

End Class
