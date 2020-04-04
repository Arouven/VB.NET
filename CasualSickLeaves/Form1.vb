Public Class FormCasualSick
    Private Sub ButtonCalculateLeave_Click(sender As Object, e As EventArgs) Handles ButtonCalculateLeave.Click
        Dim d1 As DateTime = DateTimePickerJoin.Value
        Dim d2 As DateTime = DateTimePickerLeave.Value
        Dim result As TimeSpan = d2.Subtract(d1)
        Dim days As Integer = result.TotalDays + 1
        LabelDays.Text = CStr(days) + " Day(s)"
    End Sub

    Private Sub FormCasualSick_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Calculating Casual/Sick Leaves"
    End Sub
End Class
