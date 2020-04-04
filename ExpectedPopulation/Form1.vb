Public Class FormPopulationGrowth
    Private Sub ListBoxYearPopulation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxYearPopulation.SelectedIndexChanged

    End Sub

    Private Sub ButtonGenerateGrowth_Click(sender As Object, e As EventArgs) Handles ButtonGenerateGrowth.Click
        Dim pop As Double = 1125000
        Const yr As Integer = 2005
        Dim year As Integer
        Dim fmthr As String = "{0,4}{1,47:N0}"
        Dim fmtstr As String = "{0,4}{1,45:N0}"
        ListBoxYearPopulation.Items.Clear()
        ListBoxYearPopulation.Items.Add(String.Format(fmthr, "Year",
        "Population"))
        For year = yr To yr + 100
            ListBoxYearPopulation.Items.Add(String.Format(fmtstr, year, pop))
            pop += 0.019 * pop
        Next
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub
End Class
