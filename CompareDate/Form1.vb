Public Class FormCompareDate

    Dim myDate As Date


    Private Sub compareDate()
        TextBoxOutBox.Text = ""
        myDate = DateTimePickerToCompare.Value.Date
        TextBoxOutBox.Text = DateTimePickerToCompare.Text
        If myDate = System.DateTime.Today Then
            TextBoxOutBox.Text = "The current date."
        ElseIf myDate > System.DateTime.Today Then
            TextBoxOutBox.Text = "A date in the future."
        Else
            TextBoxOutBox.Text = "A date in the past."
        End If
    End Sub


    Private Sub FormCompareDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        compareDate()
    End Sub
    Private Sub DateTimePickerToCompare_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerToCompare.ValueChanged
        compareDate()
    End Sub


End Class
