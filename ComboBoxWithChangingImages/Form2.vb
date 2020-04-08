Public Class Form2

    'sends the selected items to the list box
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex > -1 Then
            Dim sindex As Integer
            sindex = ComboBox1.SelectedIndex
            Dim sitem As Object
            sitem = ComboBox1.SelectedItem
            ListBox1.Items.Add(sitem)
        End If
    End Sub

    'populates the list
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Safety")
        ComboBox1.Items.Add("Security")
        ComboBox1.Items.Add("Governance")
        ComboBox1.Items.Add("Good Music")
        ComboBox1.Items.Add("Good Movies")
        ComboBox1.Items.Add("Good Books")
        ComboBox1.Items.Add("Education")
        ComboBox1.Items.Add("Roads")
        ComboBox1.Items.Add("Health")
        ComboBox1.Items.Add("Food for all")
        ComboBox1.Items.Add("Shelter for all")
        ComboBox1.Items.Add("Industrialisation")
        ComboBox1.Items.Add("Peace")
        ComboBox1.Items.Add("Liberty")
        ComboBox1.Items.Add("Freedom of Speech")
        ComboBox1.Text = "Select from..."
    End Sub

    'sorting the list
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox1.Sorted = True
    End Sub

    'clears the list
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Items.Clear()
    End Sub

    'displaying the selected item on the label
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label1.Text = ComboBox1.SelectedItem.ToString()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the caption bar text of the form.
        Me.Text = "Wish list"
    End Sub


End Class