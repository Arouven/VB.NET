Public Class Form1

    'declare global variables here
    'variables to switch between true and false
    Dim Ready_to_move As Boolean
    Dim LeftSet As Boolean
    Dim TopSet As Boolean

    ' mouse position
    Dim HoldLeft As Integer
    Dim HoldTop As Integer

    ' These variables will hold the offset of the mouse in the element
    Dim OffLeft As Integer
    Dim OffTop As Integer


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Reset the picture location to the top left i.e. (0,0)
        picBox.Location = New Point(0, 0)
        Dim imgPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\Images\picture.png")
        picBox.Image = CType(Image.FromFile(imgPath), Image)
        picBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub picBox_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBox.MouseUp
        Ready_to_move = False
        LeftSet = False
        TopSet = False
    End Sub

    Private Sub picBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBox.MouseDown
        Ready_to_move = True
    End Sub

    Private Sub picBox_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picBox.MouseMove
        ' Check if the mouse is down
        If Ready_to_move = True Then
            ' Set the mouse position
            HoldLeft = (Control.MousePosition.X - Me.Left)
            HoldTop = (Control.MousePosition.Y - Me.Top)
            ' Find where the mouse was clicked ONE TIME
            If TopSet = False Then
                OffTop = HoldTop - sender.Top
                ' Once the position is held, flip the switch
                ' so that it doesn't keep trying to find the position
                TopSet = True
            End If
            If LeftSet = False Then
                OffLeft = HoldLeft - sender.Left
                ' Once the position is held, flip the switch
                ' so that it doesn't keep trying to find the position
                LeftSet = True
            End If
            ' Set the position of the object
            sender.Left = HoldLeft - OffLeft
            sender.Top = HoldTop - OffTop
        End If
    End Sub


End Class