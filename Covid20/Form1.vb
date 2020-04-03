Public Class Covid20

    Private Sub Covid20_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IntroPlayer.URL = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\AudioVideo\intro.mp4")
        IntroPlayer.Parent = PanelGameIntro         'pa bon
        LblEnNov.Parent = IntroPlayer
        LblEnNov.BackColor = Color.Transparent
        LblEnNov.BringToFront()                     ''''''''

    End Sub

    Private Sub SkipIntro_Click(sender As Object, e As EventArgs) Handles SkipIntro.Click
        IntroPlayer.close()
        IntroPlayer.Dispose()
        'PanelGameIntro.Visible = True
    End Sub


End Class
