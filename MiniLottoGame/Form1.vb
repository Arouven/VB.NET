Public Class FormLottoGame

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		End
	End Sub


	Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
		'generate first random number
		txtNumber1.Text = CStr(Int(Rnd() * 10))
		'generate second random number
		txtNumber2.Text = CStr(Int(Rnd() * 10))
		' check first number generated to prevent same number from generated again
		If (txtNumber2.Text = txtNumber1.Text) Then
			txtNumber2.Text = CStr(Int(Rnd() * 10))
		End If
		' check first and second numbers generated to prevent same numbers from generated		again
		'generate third random number
		txtNumber3.Text = CStr(Int(Rnd() * 10))
		If ((txtNumber3.Text = txtNumber1.Text) Or ((txtNumber3.Text = txtNumber2.Text))) Then
			txtNumber3.Text = CStr(Int(Rnd() * 10))
		End If      '-----------------------------------------------------------------------------------------------------------------
		'test for one match (starting with first number)
		If (txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text) Then
			lblResult.Text = "You have one match"
			'Nested if statement to test for two matches
			If ((txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text)) And ((txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text)) Then
				lblResult.Text = "You have two matches"
				'Nested if statement to test for three matches
				If ((txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text)) And ((txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text)) And ((txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text)) Then
					lblResult.Text = "You have three matches"
				End If
			End If
			'Nested if statement to test for two matches

			If ((txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text)) And ((txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text)) Then
				lblResult.Text = "You have two matches"
				'Nested if statement to test for three matches
				If ((txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text)) And ((txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text)) And ((txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text)) Then
					lblResult.Text = "You have three matches"
				End If
			End If
			'Nested if statement to test for two matches
			If ((txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text)) And ((txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text)) Then
				lblResult.Text = "You have two matches"
				'Nested if statement to test for three matches
				If ((txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text)) And ((txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text)) And ((txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text)) Then
					lblResult.Text = "You have three matches"
				End If
			End If
		End If      '------------------------------------------------------------------------------------------------------------------------------------------------
		'test for one match (starting with second number)
		If (txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text) Then
			lblResult.Text = "You have one match"
			'Nested if statement to test for two matches
			If ((txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text)) And ((txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
			'Nested if statement to test for two matches
			If ((txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text)) And ((txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text)) Then
				lblResult.Text = "You have two matches"
			End If

			'Nested if statement to test for two matches
			If ((txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text)) And ((txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
		End If
		'--------------------------------------------------------------------------------
		'----------------------------------------------------------------
		'test for one match (starting with third number)
		If (txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text) Then
			lblResult.Text = "You have one match"
			'Nested if statement to test for two matches
			If ((txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text)) And ((txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
			'Nested if statement to test for two matches
			If ((txtNum2.Text = txtNumber1.Text) Or (txtNum2.Text = txtNumber2.Text) Or (txtNum2.Text = txtNumber3.Text)) And ((txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
			'Nested if statement to test for two matches
			If ((txtNum1.Text = txtNumber1.Text) Or (txtNum1.Text = txtNumber2.Text) Or (txtNum1.Text = txtNumber3.Text)) And ((txtNum3.Text = txtNumber1.Text) Or (txtNum3.Text = txtNumber2.Text) Or (txtNum3.Text = txtNumber3.Text)) Then
				lblResult.Text = "You have two matches"
			End If
		End If
	End Sub



End Class
