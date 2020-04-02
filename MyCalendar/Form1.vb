Public Class FrmMyCalendar
    Private Sub TimerCalendar_Tick(sender As Object, e As EventArgs) Handles TimerCalendar.Tick
        LblDay.Text = Date.Today.ToString("dddd")



        LblTime.Text = Format(DateTime.Now, "hh:mm:ss tt")

        LblMonth.Text = DateTime.Now.ToString("MMMM")

        LblDate.Text = DateTime.Now.ToString("dd")


        LblYear.Text = DateTime.Now.ToString("yyyy")


    End Sub
End Class
