Imports MySql.Data.MySqlClient

Public Class DisplayRecord
    Dim Connection As MySqlConnection
    Dim Command As MySqlCommand
    Public dbDataSet As New DataTable
    Private Sub DisplayRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Connection = New MySqlConnection
        Connection.ConnectionString = "server=localhost;userid=root;password=root;database=student;"
        Dim SDA As New MySqlDataAdapter

        Dim bSource As New BindingSource
        ' Dim DataReader As MySqlDataReader
        Try
            '''''
            Dim Query As String
            Query = "Select * from student.student_info where Roll_Number like '" & Me.TextBox1.Text & "';"
            Command = New MySqlCommand(Query, Connection)
            dbDataSet.Clear()
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            If dbDataSet.Rows.Count > 0 Then
                DisplaysingleRecord.Show()
                Me.Hide()
                Connection.Close()
                ' DataReader.Close()
            Else
                MessageBox.Show("No Matching Records Found !")

            End If
            TextBox1.Text = Nothing
        Catch ex As Exception
            ' MessageBox.Show("Hi")
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
        '''''

    End Sub
End Class