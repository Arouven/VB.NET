Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub cmdShowDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShowDetail.Click
        Dim Valid As Boolean
        Dim messagedet As String = ""
        ValidateData(Valid)
        If Not (Valid) Then Exit Sub
        messagedet += "The author name is " + txtauthor.Text + ControlChars.CrLf
        messagedet += "and the year born is " + txtYearBorn.Text + ControlChars.CrLf
        MessageBox.Show(messagedet, "Author's Details", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Record saved.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub ValidateData(ByRef AllOK As Boolean)
        Dim Message As String
        Dim InputYear As Integer, CurrentYear As Integer
        AllOK = True
        Message = ""
        'check for empty textboxes
        If Len(txtYearBorn.Text) = 0 And Len(txtauthor.Text) = 0 Then
            Message = "You must enter an Author Name and Year Born." + ControlChars.CrLf
            txtauthor.Focus()
            AllOK = False
            'Check for name
        ElseIf Len(txtauthor.Text) = 0 Then
            Message = "You must enter an Author Name." + ControlChars.CrLf
            txtauthor.Focus()
            AllOK = False
            'check for year born
        ElseIf Len(txtYearBorn.Text) = 0 Then
            Message = "You must enter Year Born." + ControlChars.CrLf
            txtauthor.Focus()
            AllOK = False
        End If

        'Check length and range on Year Born
        InputYear = Val(txtYearBorn.Text)
        CurrentYear = Val(Format(Now, "yyyy"))
        If Len(txtYearBorn.Text) <> 0 Then
            If InputYear > CurrentYear - 15 Or InputYear < CurrentYear - 150 Then
                Message = Message + "Year Born must be between " & CStr(CurrentYear - 150) & " and" & CStr(CurrentYear - 15)
                txtYearBorn.Focus()
                AllOK = False
            End If
        End If
        If Not (AllOK) Then
            MessageBox.Show(Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Sub txtauthor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtauthor.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 32, 65 To 90, 97 To 122
                e.Handled() = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txtYearBorn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYearBorn.KeyPress
        Select Case Asc(e.KeyChar)
            Case 8, 48 To 57
                e.Handled() = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class
