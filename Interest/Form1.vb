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
        ListBoxInterest
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click

    End Sub

    Private Sub TextBoxTime_TextChanged(sender As Object, e As EventArgs) Handles TextBoxTime.TextChanged

    End Sub

    Private Sub TextBoxCompound_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCompound.TextChanged

    End Sub

    Private Sub TextBoxRate_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRate.TextChanged

    End Sub

    Private Sub TextBoxPrincipal_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrincipal.TextChanged

    End Sub

    Private Sub ListBoxInterest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInterest.SelectedIndexChanged

    End Sub
End Class
