Public Class FormWaterHeater
    Private Sub FormWaterHeater_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxCapacity.Items.Add("30 gallons")
        ComboBoxCapacity.Items.Add("40 gallons")
        ComboBoxCapacity.Items.Add("50 gallons")
        ComboBoxPowerSource.Items.Add("Natural gas")
        ComboBoxPowerSource.Items.Add("Electric")
        ComboBoxPowerSource.Items.Add("LP gas")
        ComboBoxWarrantyPeriod.Items.Add("1 year")
        ComboBoxWarrantyPeriod.Items.Add("5 years")
        ComboBoxWarrantyPeriod.Items.Add("8 years")
        ComboBoxWarrantyPeriod.Items.Add("10 years")
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        End
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        ListBoxQualifyingModels.Items.Clear()
        ListBoxQualifyingModels.Items.Add(ComboBoxCapacity.Text)
        ListBoxQualifyingModels.Items.Add(ComboBoxPowerSource.Text)
        ListBoxQualifyingModels.Items.Add(ComboBoxWarrantyPeriod.Text)
    End Sub
End Class
