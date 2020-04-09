Public Class Form1
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
		MsgBox(myBMI(CDbl(TextBoxWeight.Text), CDbl(TextBoxHeight.Text)))
	End Sub
End Class
