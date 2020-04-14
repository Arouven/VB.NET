Public Class Form4
    'Class-level variables
    Dim dbPath As String = AppDomain.CurrentDomain.BaseDirectory.Replace("\bin\Debug\", "\DataBases\AddressBook.mdb")
    Dim connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source= " & dbPath
    Dim sqlStr As String = "SELECT * FROM tblContacts"
    Dim dt As New DataTable()

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AddressBookDataSet.tblContacts' table. You       can Move, Or remove it, as needed.
        'Me.TblContactsTableAdapter.Fill(Me.AddressBookDataSet.tblContacts)
    End Sub
    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        'Displays the table's data in the data grid
        'Clear the current contents of the table.
        dt.Clear()
        'Fill the data table with data from the database.
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, connStr)
        dataAdapter.Fill(dt)
        dataAdapter.Dispose()
        'Display the table in the data grid.
        dgvDisplay.DataSource = dt
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save the tables's changes back to the database.
        Dim changes As Integer
        'Open a connection to the database for updating.

        connStr = "Provider=Microsoft.Jet.OLEDB.4.0;" & "Data Source= " & dbPath
        Dim dataAdapter As New OleDb.OleDbDataAdapter(sqlStr, connStr)
        Dim commandBuilder As New OleDb.OleDbCommandBuilder(dataAdapter)
        'Update the database with changes from the data table.
        changes = dataAdapter.Update(dt)
        dataAdapter.Dispose()
        'Display the number of changes made.
        If changes > 0 Then
            MsgBox(changes & " changed rows were stored in the database.")
        Else
            MsgBox("No changes made.")
        End If
    End Sub
End Class