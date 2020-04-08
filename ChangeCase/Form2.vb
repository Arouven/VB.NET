Public Class Form2

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOK.Click
        Dim ChangeCase As String
        ChangeCase = Form1.tb.Text
        If RadioButtonUC.Checked Then
            ChangeCase = ChangeCase.ToUpper
        ElseIf RadioButtonLC.Checked Then
            ChangeCase = ChangeCase.ToLower
        ElseIf RadioButtonPC.Checked Then
            ChangeCase = StrConv(ChangeCase, VbStrConv.ProperCase)
        End If
        Form1.tb.Text = ChangeCase
        Me.DialogResult = DialogResult.OK
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class