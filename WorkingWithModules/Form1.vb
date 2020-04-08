Public Class Form1
    Private Sub cmdSA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSurfaceArea.Click
        Dim area As Single
        inputdata()
        area = mySA(h, r)
        TextBoxArea.Text = Str(area)
        ButtonVolume.Enabled = True
    End Sub
    Private Sub cmdVol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVolume.Click
        Dim vol As Double
        inputdata()
        vol = myVol(h, r)
        TextBoxVolume.Text = Str(vol)
        ButtonVolume.Enabled = False
    End Sub
    Private Sub inputdata()
        r = CShort(TextboxRadius.Text)
        h = CShort(TectBoxHeight.Text)
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ButtonVolume.Enabled = False
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class