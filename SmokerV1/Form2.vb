Imports System.String

Public Class FormSmokerV2

	Private mblnSmoker As Integer
	Private mStrSmoker As String
	Private mstrAge As String
	Private msngRate As Single


	Private Sub ButtonCalculateInsurance_Click(sender As Object, e As EventArgs) Handles ButtonCalculateInsurance.Click
		mStrSmoker = ComboBoxSmokerOrNot.Text
		mstrAge = ComboBoxAge.Text
		mblnSmoker = String.Compare(mStrSmoker, "Smoker", True)
		If mblnSmoker = 0 Then
			Select Case mstrAge
				Case "0 to 20"
					msngRate = 242.55
				Case "21 to 40"
					msngRate = 265.75
				Case Else
					msngRate = 292.85
			End Select
		Else
			Select Case mstrAge
				Case "0 to 20"
					msngRate = 142.55
				Case "21 to 40"
					msngRate = 165.75
				Case Else
					msngRate = 192.85
			End Select
		End If
		TextBoxInsurance.Text = msngRate
	End Sub

	Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
		ComboBoxSmokerOrNot.Text = " "
		ComboBoxAge.Text = ""
		mStrSmoker = ""
		TextBoxInsurance.Text = ""
	End Sub

	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Me.Close()
	End Sub

	Private Sub FormSmokerV2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ComboBoxSmokerOrNot.Items.Clear()
		ComboBoxSmokerOrNot.Items.Add("Smoker")
		ComboBoxSmokerOrNot.Items.Add("Non-Smoker")

		ComboBoxAge.Items.Clear()
		ComboBoxAge.Items.Add("0 to 20")
		ComboBoxAge.Items.Add("21 to 40")
		ComboBoxAge.Items.Add("Above 40")
	End Sub
End Class

