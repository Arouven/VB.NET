Public Class FormGlobalLocal

    Private count As Integer = 2

    ''''''''''''''''''
    Private Sub FormatTextBox(ByVal TextBoxCountJohn As TextBox)
        TextBoxCountJohn.BackColor = Color.Tan
        TextBoxCountJohn.ForeColor = Color.Brown
    End Sub

    Private Sub ButtonCountJoe_Click(sender As Object, e As EventArgs) Handles ButtonCountJoe.Click
        Dim count As Integer = 4
        count = count + 1
        TextBoxCountJoe.Text = CStr(count)
    End Sub

    Private Sub ButtonCountJack_Click(sender As Object, e As EventArgs) Handles ButtonCountJack.Click
        Dim count As Integer = 7
        count = count + 1
        TextBoxCountJack.Text = CStr(count)
    End Sub

    Private Sub ButtonCountJohn_Click(sender As Object, e As EventArgs) Handles ButtonCountJohn.Click
        count = count + 1
        TextBoxCountJohn.Text = CStr(count)
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

End Class





