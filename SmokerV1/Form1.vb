
Imports System.String

Public Class FormSmoker

    Private SmokerNonSmoker As String
    Private mintAge As Integer
    Private msngRate As Single


    Private Sub ButtonCalculateInsurance_Click(sender As Object, e As EventArgs) Handles ButtonCalculateInsurance.Click

        If RadioButtonSmoker.Checked Then
            SmokerNonSmoker = "Smoker"
        ElseIf RadioButtonNonSmoker.Checked Then
            SmokerNonSmoker = "Non-Smoker"
        End If



        mintAge = CInt(TextBoxAge.Text)
        If SmokerNonSmoker = "Smoker" Then
            If mintAge < 20 Then
                msngRate = 242.55
            ElseIf mintAge < 40 Then
                msngRate = 265.75
            Else
                msngRate = 292.85
            End If
        Else
            If mintAge < 20 Then
                msngRate = 142.55
            ElseIf mintAge < 40 Then
                msngRate = 165.75
            Else
                msngRate = 192.85
            End If
        End If
        TextBoxInsurance.Text = msngRate

    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        RadioButtonNonSmoker.Checked = True
        TextBoxAge.Text = ""
        TextBoxInsurance.Text = ""
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        End
    End Sub

End Class


