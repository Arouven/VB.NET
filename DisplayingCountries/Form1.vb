Public Class Form1
    Private Sub btnCreateFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateFile.Click
        'Create the file country.doc
        Dim myDesktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim mysw As IO.StreamWriter = IO.File.CreateText(myDesktop + "\country.doc")
        With mysw
            .WriteLine("Country")
            .WriteLine("--------")
            .WriteLine("France")
            .WriteLine("England")
            .WriteLine("Croatia")
            .WriteLine("USA")
            .WriteLine("Canada")
            .WriteLine("Brazil")
            .WriteLine("Argentina")
            .Close()
        End With
        MsgBox("ckeck your desktop")
    End Sub
    Private Sub btnDisplayFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplayFile.Click
        'Display the contents of the file PIONEERS.TXT in a list box
        Dim myDesktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim mysr As IO.StreamReader = IO.File.OpenText(myDesktop + "\country.doc")

        lstCountry.Items.Clear()
        Do While mysr.Peek <> -1
            lstCountry.Items.Add(mysr.ReadLine)
        Loop
        mysr.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
