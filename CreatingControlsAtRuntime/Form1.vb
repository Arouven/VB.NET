Public Class Form1
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ThisControl As Control
        For Each ThisControl In Me.Controls
            If TypeOf ThisControl Is TextBox Then
                With ThisControl
                    .BackColor = Color.Red
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
        For Each ThisControl In Me.Controls
            If TypeOf ThisControl Is ComboBox Then
                With ThisControl
                    .BackColor = Color.Green
                    .ForeColor = Color.Black
                End With
            End If
            If TypeOf ThisControl Is Label Then
                With ThisControl
                    .BackColor = Color.Yellow

                    .ForeColor = Color.Magenta
                End With
            End If
        Next ThisControl
    End Sub
    Private Sub btnNewCombo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Add new control at runtime
        Dim newCombo As New System.Windows.Forms.ComboBox()
        With newCombo
            .Visible = True
            .Size = New Size(100, 50)
            .Location = New Point(298, 141)
            .Text = "I'm a new Combo box"
            .Items.Add("Red")
            .Items.Add("Blue")
            .Items.Add("Green")
        End With
        Me.Controls.Add(newCombo)
    End Sub
End Class