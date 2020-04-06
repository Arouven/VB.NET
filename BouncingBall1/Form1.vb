Public Class FormBouncingBall
    Private Sub FormBouncingBall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBouncingBall2.Show()
        Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\ball.png")
        PictureBoxBall.Image = Image.FromFile(imgPath)
        PictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub ButtonAnimate_Click(sender As Object, e As EventArgs) Handles ButtonAnimate.Click
        Timer1.Start()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y + 5)
        If PictureBoxBall.Location.Y + (1.5 * PictureBoxBall.Height) > Me.Height Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y - 5)
        If PictureBoxBall.Location.Y + (1.5 * PictureBoxBall.Height) < 1.5 * PictureBoxBall.Height Then
            Timer2.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        PictureBoxBall.Location = New Point(300, 0)
    End Sub

    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
        Timer1.Stop()
        Timer2.Stop()
    End Sub
End Class




'Public Class FormBouncingBall2
'    Private Sub FormBouncingBall2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\ball.png")
'        PictureBoxBall.Image = Image.FromFile(imgPath)
'        PictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage
'        CenterImge()
'    End Sub

'    Private Sub ButtonAnimate_Click(sender As Object, e As EventArgs) Handles ButtonAnimate.Click
'        Timer1.Start()
'    End Sub

'    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
'        Me.Close()
'    End Sub

'    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
'        PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y + 5)
'        If PictureBoxBall.Location.Y > (Panel1.Height - PictureBoxBall.Height) Then 'panel height = 110, picturebox height = 24
'            Timer1.Stop()
'            Console.WriteLine("timer2. go up")
'            Timer2.Start()
'        End If
'        Console.WriteLine(PictureBoxBall.Location.Y & "          " & Panel1.Height)
'    End Sub

'    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
'        PictureBoxBall.Location = New Point(PictureBoxBall.Location.X, PictureBoxBall.Location.Y - 5)
'        If PictureBoxBall.Location.Y < 0 Then
'            Timer2.Stop()
'            Console.WriteLine("timer1. go down")
'            Timer1.Start()
'        End If
'        Console.WriteLine(PictureBoxBall.Location.Y & "          " & Panel1.Height)
'    End Sub



'    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick

'    End Sub

'    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

'    End Sub
'    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
'        CenterImge()
'    End Sub

'    Private Sub CenterImge()
'        Dim x As Integer = (Panel1.Width / 2) - (PictureBoxBall.Width / 2)
'        Dim y As Integer = (Panel1.Height / 2) - (PictureBoxBall.Height / 2)
'        PictureBoxBall.Location = New Point(x, y)
'    End Sub

'    Private Sub ButtonStop_Click(sender As Object, e As EventArgs) Handles ButtonStop.Click
'        Timer1.Stop()
'        Timer2.Stop()
'    End Sub

'End Class
