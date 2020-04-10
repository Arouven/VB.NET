Imports WMPLib

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = "hh:mm tt"
        DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        DateTimePicker1.ShowUpDown = True

        Timer1.Enabled = True
        Timer1.Start()

        Timer2.Enabled = False
        Label4.Text = "Waiting"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Format(Now, "hh:mm tt")

        Dim DateTime1 As String = DateTimePicker1.Value.ToString("hh:mm tt").Trim()
        Dim DateTime2 As String = Label1.Text.Trim()

        If DateTime1 = DateTime2 Then
            AxWindowsMediaPlayer1.URL = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Sounds\AlarmClock.mp3")
            AxWindowsMediaPlayer1.Ctlcontrols.play()
            Label4.Text = "Ringing"
        Else
            Label4.Text = "Waiting"
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        AxWindowsMediaPlayer1.URL = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Sounds\AlarmClock.mp3")
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Timer2.Enabled = True
            Timer2.Start()
        Else
            Timer2.Enabled = False
            Timer2.Stop()
            AxWindowsMediaPlayer1.Ctlcontrols.stop()
        End If
    End Sub

End Class


