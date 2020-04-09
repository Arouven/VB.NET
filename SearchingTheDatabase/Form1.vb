Public Class Form1

	'class level variables
	Dim myconn As New OleDb.OleDbConnection
	Dim sql As String
	Dim b_s_Dataset As New DataSet
	Dim bankAdapter As New OleDb.OleDbDataAdapter

	Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Dim dbPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\DataBases\EmpDB.mdb")

		'connection, connectionstring (Provider, DataSource), open connection
		'sql command, dataAdapter, declare & fill DataSet, close connection
		'display data in textboxes from data table(s) in dataset
		myconn.ConnectionString = ("PROVIDER= Microsoft.Jet.OLEDB.4.0; Data Source = " + dbPath)
		myconn.Open()
		'test if connection is open
		' MsgBox("A connection to the database is open")
		sql = "SELECT * FROM Emp_bank"
		' the adapter links the sql with the connection
		bankAdapter = New OleDb.OleDbDataAdapter(sql, myconn)
		'the adapter fills the data table(s) in the dataset
		bankAdapter.Fill(b_s_Dataset, "bank_staff_Table")
		dgStaff.DataSource = b_s_Dataset
		dgStaff.DataMember = "bank_staff_Table"
		myconn.Close()
	End Sub
	Private Sub btnSearchDatagrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearch.Click
		Dim found As Integer = 0
		Dim mystring As String
		Dim celltext As String = "Enter search word"
		mystring = txtSearch.Text
		For i As Integer = 0 To dgStaff.Rows.Count - 1
			For j As Integer = 0 To dgStaff.ColumnCount - 1
				Try '''''''''''''''''''''''''
					celltext = (dgStaff.Rows(i).Cells(j).Value).ToString '''problem lor la
				Catch Ex As Exception
				End Try
				If celltext = mystring Then
					found = 1
					dgStaff.Rows(i).Cells(j).Style.ForeColor = Color.Aquamarine
					dgStaff.Rows(i).Cells(j).Style.BackColor = Color.Green
					MsgBox("Your Search: " + celltext + " found a match at row " + Str(i + 1) + " column " + Str(j + 1))
				Else
					If found = 1 Then
						found = 1
					Else
						found = 0
					End If
					dgStaff.Rows(i).Cells(j).Style.ForeColor = Color.Red
					dgStaff.Rows(i).Cells(j).Style.BackColor = Color.Gray
				End If
			Next
		Next
		If found = 0 Then
			MsgBox("Your Search: " + txtSearch.Text + " found no matches at all in the database ")
		End If
	End Sub
End Class