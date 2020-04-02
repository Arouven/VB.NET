Public Class Covid20


    Private Sub SkipIntro_Click(sender As Object, e As EventArgs) Handles SkipIntro.Click

    End Sub

    Private Sub IntroPlayer_Enter(sender As Object, e As EventArgs) Handles IntroPlayer.Enter
        IntroPlayer.URL = "~/Covid20/AudioVideo/intro.mp4"
    End Sub
End Class
