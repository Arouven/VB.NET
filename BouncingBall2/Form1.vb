Public Class FormBouncingBall2

    Private xSpeed As Integer = 2.5
    Private ySpeed As Integer = 2.5

    Private Sub FormBouncingBall2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(230, 175)
        Panel1.Size = New Size(110, 110)
        Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\ball.png")
        PictureBoxBall.Image = Image.FromFile(imgPath)
        PictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage
        CenterImge()
    End Sub

    Private Sub ButtonAnimate_Click(sender As Object, e As EventArgs) Handles ButtonAnimate.Click
        Timer1.Start()
        Timer3.Start()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y + ySpeed) 'moving down
        If PictureBoxBall.Location.Y > (Panel1.Height - PictureBoxBall.Height) Then 'panel height = 110, picturebox height = 24
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y - ySpeed) 'moving up
        If PictureBoxBall.Location.Y < 0 Then
            Timer2.Stop()
            Timer1.Start()
        End If
    End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        PictureBoxBall.Location = New Point(PictureBoxBall.Location.X + xSpeed, PictureBoxBall.Location.Y) 'moving right
        If PictureBoxBall.Location.X > (Panel1.Width - PictureBoxBall.Width) Then 'panel height = 110, picturebox height = 24
            Timer3.Stop()
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        PictureBoxBall.Location = New Point(PictureBoxBall.Location.X - xSpeed, PictureBoxBall.Location.Y) 'moving left
        If PictureBoxBall.Location.X < 0 Then
            Timer4.Stop()
            Timer3.Start()
        End If
    End Sub
    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        CenterImge()
    End Sub

    Private Sub CenterImge()
        Dim y As Integer = (Panel1.Height / 2) - (PictureBoxBall.Height / 2)
        Dim x As Integer = (Panel1.Width / 2) - (PictureBoxBall.Width / 2)
        PictureBoxBall.Location = New Point(0, y)
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub

End Class
