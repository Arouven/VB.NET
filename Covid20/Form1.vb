Public Class Covid20

    Private Sub Covid20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IntroPlayer.Visible = False

    End Sub

    Private Sub SkipIntro_Click(sender As Object, e As EventArgs) Handles SkipIntro.Click
        IntroPlayer.close()
        IntroPlayer.Dispose()
        GamePanel.Visible = True
    End Sub

    Private Sub IntroPlayer_Enter(sender As Object, e As EventArgs) Handles IntroPlayer.Enter
    End Sub


    Private Sub Play_Click(sender As Object, e As EventArgs) Handles BtnEnNovNext.Click
        GamePanel.Visible = False


        IntroPlayer.Visible = True

        IntroPlayer.URL = "C:\Users\Arouven\Source\Repos\VB.NET\Covid20\AudioVideo\intro.mp4" 'bizin fr sa url la vin dinamic

    End Sub

End Class
