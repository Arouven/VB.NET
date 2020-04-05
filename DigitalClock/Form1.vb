Public Class FormDigitalClock



    Private Sub FormDigitalClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Enabled = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        TextBoxDigitalClock.Text = Format(System.DateTime.Now, "hh:mm:ss")
    End Sub

    Private Sub ButtonStartTime_Click(sender As Object, e As EventArgs) Handles ButtonStartTime.Click
        Timer.Enabled = True
        TextBoxStartTime.Text = TextBoxDigitalClock.Text
        TextBoxEndTime.Text = ""
    End Sub

    Private Sub ButtonEndTime_Click(sender As Object, e As EventArgs) Handles ButtonEndTime.Click
        TextBoxEndTime.Text = TextBoxDigitalClock.Text
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class
