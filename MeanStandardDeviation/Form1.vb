Public Class FormMeanSD

	Private x_List As New List(Of Double)


	Private Sub ButtonAcceptNumber_Click(sender As Object, e As EventArgs) Handles ButtonAcceptNumber.Click
		x_List.Add(CDbl(TextBoxNumber.Text))
		TextBoxNumber.Text = ""
	End Sub
	Private Sub ButtonCompute_Click(sender As Object, e As EventArgs) Handles ButtonCompute.Click
		Dim n As Integer = x_List.Count
		Dim xSum As Double = 0.0
		Dim x2Sum As Double = 0.0

		For Each x As Double In x_List
			xSum = xSum + x
			x2Sum = x2Sum + (x * x)
		Next

		Dim xBar As Double = xSum / n
		TextBoxMean.Text = CStr(xBar)

		Dim sDeviation As Double = (((n * x2Sum) - (xBar ^ 2)) / (n * (n - 1))) ^ 0.5
		TextBoxSD.Text = CStr(sDeviation)
	End Sub
	Private Sub ButtonNewSequence_Click(sender As Object, e As EventArgs) Handles ButtonNewSequence.Click
		x_List.Clear()
		TextBoxSD.Text = ""
		TextBoxMean.Text = ""
		TextBoxNumber.Text = ""
		TextBoxNumber.Select()
		AcceptButton = ButtonAcceptNumber
	End Sub
	Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
		Me.Close()
	End Sub

	Private Sub FormMeanSD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TextBoxNumber.Select()
		AcceptButton = ButtonAcceptNumber
	End Sub
End Class
