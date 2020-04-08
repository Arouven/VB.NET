Public Class Form1

    Public Shared tb As TextBox
    Dim secondform As New Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonShow.Click
        Form2.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        End
    End Sub
    Private Sub btnDialogueBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonShowDialog.Click
        Dim frmDialogue As New Form2
        If frmDialogue.ShowDialog() = DialogResult.OK Then
            MsgBox("OK button clicked")
        End If
        If frmDialogue.ShowDialog() = DialogResult.Cancel Then
            MsgBox("Cancel button clicked")
        End If
        'frmDialogue.ShowDialog()

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb = TextBoxSomeText
    End Sub
End Class
