Public Class FormControlProperties
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonChange_Click(sender As Object, e As EventArgs) Handles ButtonChange.Click
        Dim ThisControl As Control
        For Each ThisControl In Me.Controls
            If TypeOf ThisControl Is TextBox Then
                With ThisControl
                    .BackColor = Color.LightBlue
                    .ForeColor = Color.RosyBrown
                End With
            End If
            If TypeOf ThisControl Is Button Then
                With ThisControl
                    .BackColor = Color.Aqua
                    .ForeColor = Color.CornflowerBlue
                End With
            End If
        Next ThisControl
    End Sub
End Class
