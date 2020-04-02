Public Class FrmStopwatchApplication

    Dim StartTime As Date
    Dim EndTime As Date
    Dim ElapsedTime As Long

    Private Sub BtnStartTime_Click(sender As Object, e As EventArgs) Handles BtnStartTime.Click
        StartTime = DateTime.Now
        TxtStartTime.Text = Format(StartTime, "hh:mm:ss")
        TxtEndTime.Text = ""
        TxtElapsedTime.Text = ""
    End Sub

    Private Sub BtnEndTime_Click(sender As Object, e As EventArgs) Handles BtnEndTime.Click
        EndTime = DateTime.Now
        ElapsedTime = DateDiff(DateInterval.Second, StartTime, EndTime)
        TxtEndTime.Text = Format(EndTime, "hh:mm:ss")
        TxtElapsedTime.Text = ElapsedTime
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

End Class
