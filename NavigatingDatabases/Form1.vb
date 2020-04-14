Public Class Form1
	Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click

		Dim con As New OleDb.OleDbConnection
		Dim dbPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\DataBases\AddressBook.mdb")
		con.ConnectionString = ("PROVIDER= Microsoft.Jet.OLEDB.4.0; Data Source = " + dbPath)
		con.Open()
		MsgBox("A connection to the database is now open")
		Dim ds As New DataSet
		Dim da As New OleDb.OleDbDataAdapter
		Dim sql As String
		sql = "SELECT * FROM tblContacts"
		da = New OleDb.OleDbDataAdapter(sql, con)
		da.Fill(ds, "myAddressbook")
		con.Close()
		MsgBox("The connection to the database is now closed")
		txtFirstName.Text = ds.Tables("myAddressbook").Rows(0).Item(1)
		txtLastName.Text = ds.Tables("myAddressbook").Rows(0).Item(2)
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Form2.Show()
		Form3.Show()
		Form4.Show()
	End Sub
End Class