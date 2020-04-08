Public Class Form1

    Private Sub ButtonInput_Click(sender As Object, e As EventArgs) Handles ButtonInput.Click
        Dim prompt As String = "Enter the value of x greater than 10. (y=x^10)"
        Dim title As String = "Input Value"
        Dim x As Integer
        Dim y As Long
        x = InputBox(prompt, title)
        If x > 10 Then
            y = Math.Pow(x, 10)
            MessageBox.Show("The Value of Y is " + CStr(y), "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("This is an invalid value of x...please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
