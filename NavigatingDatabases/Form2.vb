
Imports System.Data
Public Class Form2

	Dim con As New OleDb.OleDbConnection
	Dim ds As New DataSet
	Dim da As New OleDb.OleDbDataAdapter
	Dim sql As String
	Dim maxRows As Integer
	Dim inc As Integer = -1

	Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Dim dbPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\DataBases\AddressBook.mdb")
		con.ConnectionString = ("PROVIDER= Microsoft.Jet.OLEDB.4.0; Data Source = " + dbPath)
		con.Open()
		MsgBox("A connection to the database is now open")
		sql = "SELECT * FROM tblContacts"
		da = New OleDb.OleDbDataAdapter(sql, con)
		da.Fill(ds, "myAddressbook")
		maxRows = ds.Tables("myAddressbook").Rows.Count
	End Sub
	Private Sub NavigateRecords()
		txtFirstName.Text = ds.Tables("myAddressbook").Rows(inc).Item(1)
		txtLastName.Text = ds.Tables("myAddressbook").Rows(inc).Item(2)
	End Sub
	Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
		If inc <> maxRows - 1 Then
			inc = inc + 1
			NavigateRecords()
		Else
			MsgBox("No more records to display")
		End If
	End Sub
	Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
		If inc > 0 Then
			inc = inc - 1
			NavigateRecords()
		ElseIf inc = -1 Then
			MsgBox("No records yet!")
		ElseIf inc = 0 Then
			MsgBox("First record")
		End If
	End Sub
	Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
		If inc <> 0 Then
			inc = 0
			NavigateRecords()
		End If
	End Sub
	Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
		If inc <> maxRows - 1 Then
			inc = maxRows - 1
			NavigateRecords()
		End If
	End Sub
End Class