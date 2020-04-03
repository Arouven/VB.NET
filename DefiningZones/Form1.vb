Public Class FormEmployeeData
    Private Sub ButtonDisplayTable_Click(sender As Object, e As EventArgs) Handles ButtonDisplayTable.Click
        Dim fmtHeader As String = "{0,0}{1,40}{2,40:N2}{3,40:N2}"
        Dim fmtDetails As String = "{0,0}{1,50}{2,43:N2}{3,42:N2}"
        Const hrrate As Single = 100.5
        Dim hrswork As Single
        With ListBoxEmployee.Items
            .Clear()
            .Add(String.Format(fmtHeader, "Employee ID", "Hrswork", "Basic Salary", "Extra Bonus"))
            hrswork = 200
            .Add(String.Format(fmtDetails, "1001", hrswork, hrrate * hrswork, hrrate * hrswork * 0.1))
            hrswork = 235
            .Add(String.Format(fmtDetails, "1002", hrswork, hrrate * hrswork, hrrate * hrswork * 0.1))
        End With
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class
