Public Class FormFlightPlanner
    Private Sub ButtonAssign_Click(sender As Object, e As EventArgs) Handles ButtonAssign.Click
        'Build message box that gives your assignment
        Dim Message As String
        Message = "Destination: " & ListBoxCities.Text & vbCr
        Message = Message & "Seat Location: " & ComboBoxSeatLocation.Text & vbCr
        Message = Message & "Meal: " & ComboBoxMealPreference.Text & vbCr
        MessageBox.Show(Message, "Your Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FormFlightPlanner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add city names to list box
        ListBoxCities.Items.Clear()
        ListBoxCities.Items.Add("London")
        ListBoxCities.Items.Add("Los Angeles")
        ListBoxCities.Items.Add("Paris")
        ListBoxCities.Items.Add("Athen")
        ListBoxCities.Items.Add("Moscow")
        ListBoxCities.Items.Add("Sidney")
        ListBoxCities.Items.Add("Tana")
        ListBoxCities.Items.Add("Bombay")
        ListBoxCities.SelectedIndex = 2
        'Add seat types to first combo box
        ComboBoxSeatLocation.Items.Add("Aisle")
        ComboBoxSeatLocation.Items.Add("Middle")
        ComboBoxSeatLocation.Items.Add("Window")
        ComboBoxSeatLocation.SelectedIndex = 2
        'Add meal types to second combo box
        ComboBoxMealPreference.Items.Add("Chicken")
        ComboBoxMealPreference.Items.Add("Mystery Meat")
        ComboBoxMealPreference.Items.Add("Kosher")
        ComboBoxMealPreference.Items.Add("Vegetarian")
        ComboBoxMealPreference.Items.Add("Fruit Plate")
        ComboBoxMealPreference.Text = "No Preference"
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub


End Class
