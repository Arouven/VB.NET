Public Class FormInterest

    '''''''''''''asi=p*(1+(r*t))''''''''''''
    'A = Total Accrued Amount (principal + interest)
    'P = Principal Amount
    'I = Interest Amount
    'r = Rate of Interest per year in decimal; r = R/100
    'R = Rate of Interest per year as a percent; R = r * 100
    't = Time Period involved in months Or years






    ''''''''''''aci=p*((1+(r/n))^(n*t))''''''''''''''
    'A = Accrued Amount (principal + interest)
    'P = Principal Amount
    'I = Interest Amount
    'R = Annual Nominal Interest Rate in percent
    'r = Annual Nominal Interest Rate as a decimal
    'r = R/100
    't = Time Involved in years, 0.5 years Is calculated as 6 months, etc.
    'n = number of compounding periods per unit t; at the END of each period

    Private Sub FormInterest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        Dim fmtHeader As String = "{0,0}{1,25}{2,30}"
        Dim fmtDetails As String = "{0,0}{1,20:N2}{2,35:N2}"

        Dim currentYear As Integer = DateTime.Now.ToString("yyyy")
        Dim simple As Double
        Dim compound As Double
        Dim p As Double = 2500 'TextBoxPrincipal.Text
        Dim r As Double = 7 'TextBoxRate.Text
        Dim n As Double = 4 'TextBoxCompound.Text
        Dim t As Double = 10 'TextBoxTime.Text

        With ListBoxInterest.Items
            .Clear()
            .Add(String.Format(fmtHeader, "Year", "Simple Interest", "Compound Interest"))
            For ty As Integer = 0 To t Step 1
                simple = (p * r * ty) / 100
                compound = 0
                .Add(String.Format(fmtDetails, ty, simple, compound))
            Next
        End With
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        TextBoxPrincipal.Text = ""
        TextBoxRate.Text = ""
        TextBoxCompound.Text = ""
        TextBoxTime.Text = ""
    End Sub


End Class
