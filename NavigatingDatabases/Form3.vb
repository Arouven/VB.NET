Public Class Form3

	Dim inc As Integer
	Dim MaxRows As Integer
	Dim con As New OleDb.OleDbConnection
	Dim dbProvider As String
	Dim dbSource As String
	Dim ds As New DataSet
	Dim da As OleDb.OleDbDataAdapter
	Dim sql As String

	Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
		Dim dbPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\DataBases\AddressBook.mdb")
		dbSource = "Data Source = " & dbPath
		con.ConnectionString = dbProvider & dbSource
		AddressBookDataSet.tblContacts.AcceptChanges()
		con.Open()
		sql = "SELECT * FROM tblContacts"
		da = New OleDb.OleDbDataAdapter(sql, con)
		da.Fill(ds, "AddressBook")
		da.Fill(AddressBookDataSet.tblContacts) ' fill dataset with updated database to display in datagrid
		MsgBox("Test 1 :Database is now open")
		con.Close()
		MsgBox("Test 2: Database is now Closed")
		MaxRows = ds.Tables("AddressBook").Rows.Count
		txtRowCount.Text = (MaxRows).ToString
		inc = -1
		btnUpdate.Enabled = True
	End Sub
	Private Sub NavigateRecords()
		'this sub routine is for navigating thro the text boxes
		txtFirstName.Text = ds.Tables("AddressBook").Rows(inc).Item(1)
		txtSurname.Text = ds.Tables("AddressBook").Rows(inc).Item(2)
	End Sub
	Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
		If inc <> MaxRows - 1 Then
			inc = inc + 1
			NavigateRecords() ' this is only for text boxes navigating
		Else
			MsgBox("No More Rows")
		End If
	End Sub
	Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
		If inc > 0 Then
			inc = inc - 1
			NavigateRecords() 'this is only for text boxes navigating
		ElseIf inc = -1 Then
			MsgBox("No Records Yet")
		ElseIf inc = 0 Then
			MsgBox("First Record")
		End If
	End Sub
	Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
		If inc <> MaxRows - 1 Then
			inc = MaxRows - 1
			NavigateRecords() ' this is only for text boxes navigating
		Else
		End If
	End Sub
	Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
		If inc <> 0 Then
			inc = 0
			NavigateRecords() ' this is only for text boxes navigating
		Else
		End If
	End Sub
	Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
		con.Open()
		MsgBox("Test 3 :Database is now open again")
		Dim cb As New OleDb.OleDbCommandBuilder(da)
		'Updating dataset from text boxes
		ds.Tables("AddressBook").Rows(inc).Item(1) = txtFirstName.Text
		ds.Tables("AddressBook").Rows(inc).Item(2) = txtSurname.Text
		'inc = 0 ' setting the index to first row in datagrid
		'Updating dataset from datagrid
		'for loop to go through all records and check for updates
		' Do
		' txtActualRow.Text = DataGridView1.CurrentRow.Index + 1 & " , " &		DataGridView1.CurrentCell.ColumnIndex
		' ds.Tables("AddressBook").Rows(inc).Item(1) =		DataGridView1.Rows(inc).Cells(1).Value.ToString
		' ds.Tables("AddressBook").Rows(inc).Item(2) =		DataGridView1.Rows(inc).Cells(2).Value.ToString
		' inc = inc + 1
		' Loop While (inc <> MaxRows ‐ 1)
		da.Update(ds, "AddressBook")
		MsgBox("Data updated only in the dataset ..so far")
	End Sub
	Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
		btnCommit.Enabled = True
		btnAddNew.Enabled = False
		btnUpdate.Enabled = False
		btnDelete.Enabled = False
		txtFirstName.Clear()
		txtSurname.Clear()
	End Sub
	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		btnCommit.Enabled = False
		btnAddNew.Enabled = True
		btnUpdate.Enabled = True
		btnDelete.Enabled = True
		inc = 0
		'NavigateRecords()
	End Sub
	Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
		If inc <> -1 Then
			Dim cb As New OleDb.OleDbCommandBuilder(da)
			Dim dsNewRow As DataRow
			dsNewRow = ds.Tables("AddressBook").NewRow()
			'this part is working i.e. commit database update via textboxes
			dsNewRow.Item("FirstName") = txtFirstName.Text
			dsNewRow.Item("Surname") = txtSurname.Text
			'this is for committing update thro dataset
			'inc = 0
			'Do
			' dsNewRow.Item("FirstName") =			ds.Tables.Item("AddressBook").Rows(inc).Item("FirstName").ToString()
			' dsNewRow.Item("Surname") =			ds.Tables.Item("AddressBook").Rows(inc).Item("Surname").ToString()
			' inc = inc + 1
			' 'this is for committing update thro datagrid
			' 'dsNewRow.Item("FirstName") = DataGridView1.Rows(inc).
			' 'dsNewRow.Item("Surname") =			ds.Tables.Item("AddressBook").Rows(inc).Item("Surname").ToString()
			' 'ds.Tables("AddressBook").Rows.Add(dsNewRow)
			'Loop While (inc <> MaxRows ‐ 1)
			da.Update(ds, "AddressBook")
			MsgBox("Record(s) updated in the Database")
			btnCommit.Enabled = False
			btnAddNew.Enabled = True
			btnUpdate.Enabled = True
			btnDelete.Enabled = True
		End If
		con.Close()
		MsgBox("Test 4 :Database is closed again")
	End Sub
	Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
		If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
			MsgBox("Operation Cancelled")
			Exit Sub
		End If
		Dim cb As New OleDb.OleDbCommandBuilder(da)
		ds.Tables("AddressBook").Rows(inc).Delete()
		MaxRows = MaxRows - 1
		inc = 0
		'NavigateRecords()
		da.Update(ds, "AddressBook")
	End Sub
	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

		End
	End Sub
End Class