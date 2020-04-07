Public Class FormLottoGame

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
		End
	End Sub


	Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSpin.Click
		'generate first random number
		TextBoxSpin1.Text = CStr(Int(Rnd() * 10))
		'generate second random number
		TextBoxSpin2.Text = CStr(Int(Rnd() * 10))
		' check first number generated to prevent same number from generated again
		If (TextBoxSpin2.Text = TextBoxSpin1.Text) Then
			TextBoxSpin2.Text = CStr(Int(Rnd() * 10))
		End If
		' check first and second numbers generated to prevent same numbers from generated		again
		'generate third random number
		TextBoxSpin3.Text = CStr(Int(Rnd() * 10))
		If ((TextBoxSpin3.Text = TextBoxSpin1.Text) Or ((TextBoxSpin3.Text = TextBoxSpin2.Text))) Then
			TextBoxSpin3.Text = CStr(Int(Rnd() * 10))
		End If      '-----------------------------------------------------------------------------------------------------------------
		'test for one match (starting with first number)
		If (TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text) Then
			lblResult.Text = "You have one match"
			'Nested if statement to test for two matches
			If ((TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text)) And ((TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text)) Then
				lblResult.Text = "You have two matches"
				'Nested if statement to test for three matches
				If ((TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text)) And ((TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text)) And ((TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text)) Then
					lblResult.Text = "You have three matches"
				End If
			End If
			'Nested if statement to test for two matches

			If ((TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text)) And ((TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text)) Then
				lblResult.Text = "You have two matches"
				'Nested if statement to test for three matches
				If ((TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text)) And ((TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text)) And ((TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text)) Then
					lblResult.Text = "You have three matches"
				End If
			End If
			'Nested if statement to test for two matches
			If ((TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text)) And ((TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text)) Then
				lblResult.Text = "You have two matches"
				'Nested if statement to test for three matches
				If ((TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text)) And ((TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text)) And ((TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text)) Then
					lblResult.Text = "You have three matches"
				End If
			End If
		End If      '------------------------------------------------------------------------------------------------------------------------------------------------
		'test for one match (starting with second number)
		If (TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text) Then
			lblResult.Text = "You have one match"
			'Nested if statement to test for two matches
			If ((TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text)) And ((TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
			'Nested if statement to test for two matches
			If ((TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text)) And ((TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text)) Then
				lblResult.Text = "You have two matches"
			End If

			'Nested if statement to test for two matches
			If ((TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text)) And ((TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
		End If
		'--------------------------------------------------------------------------------
		'----------------------------------------------------------------
		'test for one match (starting with third number)
		If (TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text) Then
			lblResult.Text = "You have one match"
			'Nested if statement to test for two matches
			If ((TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text)) And ((TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
			'Nested if statement to test for two matches
			If ((TextBoxInput2.Text = TextBoxSpin1.Text) Or (TextBoxInput2.Text = TextBoxSpin2.Text) Or (TextBoxInput2.Text = TextBoxSpin3.Text)) And ((TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
			'Nested if statement to test for two matches
			If ((TextBoxInput1.Text = TextBoxSpin1.Text) Or (TextBoxInput1.Text = TextBoxSpin2.Text) Or (TextBoxInput1.Text = TextBoxSpin3.Text)) And ((TextBoxInput3.Text = TextBoxSpin1.Text) Or (TextBoxInput3.Text = TextBoxSpin2.Text) Or (TextBoxInput3.Text = TextBoxSpin3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
		End If
	End Sub



End Class
