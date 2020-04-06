Public Class FormMenu

	Private Sub ButtonDisplay_Click(sender As Object, e As EventArgs) Handles ButtonDisplay.Click
		ListBoxMenu.Items.Clear()
		If CheckBoxPickles.CheckState = CheckState.Checked Then
			ListBoxMenu.Items.Add("Pickles")
		End If
		If CheckBoxOnions.CheckState = CheckState.Checked Then
			ListBoxMenu.Items.Add("Onions")
		End If
		If CheckBoxTomatoes.CheckState = CheckState.Checked Then
			ListBoxMenu.Items.Add("Tomatoes")
		End If
		If RadioButtonSaladBar.Checked = True Then
			RadioButtonSoup.Checked = False
			RadioButtonDesert.Checked = False
			ListBoxMenu.Items.Add("Salad")
		End If
		If RadioButtonSoup.Checked = True Then
			RadioButtonSaladBar.Checked = False
			RadioButtonDesert.Checked = False
			ListBoxMenu.Items.Add("Soup")
		End If

		If RadioButtonDesert.Checked = True Then
			RadioButtonSoup.Checked = False
			RadioButtonSaladBar.Checked = False
			ListBoxMenu.Items.Add("Dessert")
		End If
	End Sub

	Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
		ListBoxMenu.Items.Clear()
	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		End
	End Sub

End Class
