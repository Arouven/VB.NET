Module Module1

	Public Function myBMI(ByRef w As Double, ByRef h As Double) As String
		'Underweight	less than 18.5
		'Normal Weight	18.5 – 24.9
		'Overweight  25 – 29.9
		'Obesity(Class 1)	30 – 34.9
		'Obesity(Class 2)	35 – 39.9
		'Extreme Obesity(Class 3)	40+
		Dim bmi As Double = (703 * w) / (h ^ 2)
		Dim msg As String = "Your BMI is " & bmi.ToString("N2") & " you are "
		If bmi < 18.5 Then
			msg += "Underweight"
		ElseIf bmi >= 18.5 And bmi < 25.0 Then
			msg += "Normal Weight"
		ElseIf bmi >= 25.0 And bmi < 30.0 Then
			msg += "Overweight"
		ElseIf bmi >= 30.0 And bmi < 35.0 Then
			msg += "Obesity(Class 1)"
		ElseIf bmi >= 35.0 And bmi < 40.0 Then
			msg += "Obesity(Class 2)"
		ElseIf bmi >= 40.0 Then
			msg += "Obesity(Class 3)"
		End If
		Return msg
	End Function

End Module


