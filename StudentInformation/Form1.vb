Public Class FormStudentInformation

    Dim msg As String

    Private Sub ButtonShowProfile_Click(sender As Object, e As EventArgs) Handles ButtonShowProfile.Click
        MsgBox(msg)
    End Sub

    Private Sub ButtonNewProfile_Click(sender As Object, e As EventArgs) Handles ButtonNewProfile.Click
        Dim activityButton As RadioButton = GroupBoxAtheleticLevel.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)
        Dim sexButton As RadioButton = GroupBoxSex.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)

        msg = ""
        msg += TextBoxName.Text & " is " & TextBoxAge.Text & " years old of " & sexButton.Text & " sex." & vbCrLf
        msg += TextBoxName.Text & " lives in " & ComboBoxCity.Text & vbCrLf
        msg += TextBoxName.Text & " has atheletic level of " & activityButton.Text & vbCrLf
        msg += "Activities include: " & vbCrLf

        For Each cb As CheckBox In GroupBoxActivity.Controls.OfType(Of CheckBox)
            If cb.Checked Then
                msg += vbTab + cb.Text + vbCrLf
            End If
        Next
        TextBoxName.Text = ""
        TextBoxAge.Text = ""
        RadioButtonBeginner.Checked = True
        RadioButtonMale.Checked = True
        ComboBoxCity.SelectedIndex = 0
        For Each cb As CheckBox In GroupBoxActivity.Controls.OfType(Of CheckBox)
            If cb.Checked Then
                cb.Checked = False
            End If
        Next
        MsgBox("new profile created")
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub FormStudentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = ButtonNewProfile
        ComboBoxCity.SelectedIndex = 0
    End Sub
End Class
