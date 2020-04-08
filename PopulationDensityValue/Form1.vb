Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Calculate the population densities of states
        Dim state1 As String
        Dim pop1 As Double
        Dim area1 As Double
        state1 = TxtState.Text
        pop1 = CDbl(TxtPop.Text)
        area1 = CDbl(TxtArea.Text)
        ListBoxDensity.Items.Clear()
        CalculateDensity(state1, pop1, area1)
    End Sub

    Sub CalculateDensity(ByVal state As String, ByVal pop As Double, ByVal area As Double)
        Dim rawDensity, density As Double
        'The density (number of people per square mile)
        'will be displayed rounded to one decimal place
        rawDensity = pop / area
        density = Math.Round(rawDensity, 1) 'Round to one decimal        place
        ListBoxDensity.Items.Add("The density of " & state & " is " & density)
        ListBoxDensity.Items.Add("people per square mile.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBoxDensity.Items.Clear()
        TxtState.Text = ""
        TxtPop.Text = ""
        TxtArea.Text = ""
        TxtState.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f2 As Form2
        f2 = New Form2()
        f2.Show()
    End Sub
End Class
