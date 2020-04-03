Public Class FormValueReference

    Public VarA As Integer = 5

    Private Sub FormValueReference_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxABefore.Text = CStr(VarA)
    End Sub


    Sub incrementvaldata(ByVal VarA1 As Integer)
        VarA1 = VarA1 + 5
    End Sub
    Sub incrementrefdata(ByRef VarA2 As Integer)
        VarA2 = VarA2 + 5
    End Sub


    Private Sub ButtonModifyByValue_Click(sender As Object, e As EventArgs) Handles ButtonModifyByValue.Click
        Dim VarA1 As Integer = VarA
        incrementvaldata(VarA1)
        TextBoxModifyByRef.Text = ""
        TextBoxModifyByValue.Text = CStr(VarA1)
    End Sub
    Private Sub ButtonModifyByRef_Click(sender As Object, e As EventArgs) Handles ButtonModifyByRef.Click
        Dim VarA2 As Integer = VarA
        incrementrefdata(VarA2)
        TextBoxModifyByRef.Text = CStr(VarA2)
        TextBoxModifyByValue.Text = ""
    End Sub


    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxABefore.Text = ""
        TextBoxModifyByValue.Text = ""
        TextBoxModifyByRef.Text = ""
    End Sub
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

End Class







