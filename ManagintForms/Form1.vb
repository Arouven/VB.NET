﻿Public Class Form1
    Private Sub ButtonOpenForm2_Click(sender As Object, e As EventArgs) Handles ButtonOpenForm2.Click
        Dim f2 As New Form2()
        f2.Show()
    End Sub

    Private Sub ButtonDialogForm_Click(sender As Object, e As EventArgs) Handles ButtonDialogForm.Click
        Dim f2 As New Form2()
        f2.ShowDialog()
    End Sub
End Class
