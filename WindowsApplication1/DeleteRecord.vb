
Imports MySql.Data.MySqlClient

Public Class DeleteRecord
    Dim Connection As MySqlConnection
    Dim Command As MySqlCommand
    Public dbDataSet As New DataTable
    Private Sub DeleteRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Connection = New MySqlConnection

        Connection.ConnectionString = "server=localhost;userid=root;password=root;database=student;"
        Dim bSource As New BindingSource
        Dim DataReader As MySqlDataReader
        Dim SDA As New MySqlDataAdapter
        Try
            '''''
            Connection.Open()
            Dim Query As String
            Query = "Select * from student.student_info where Roll_Number like '" & Me.TextBox1.Text & "';"
            Command = New MySqlCommand(Query, Connection)

            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            If dbDataSet.Rows.Count >= 1 Then
                ' DisplaysingleRecord.Show()
                Query = "DELETE from student.student_info where Roll_Number = '" & Me.TextBox1.Text & "';"
                Command = New MySqlCommand(Query, Connection)

                DataReader = Command.ExecuteReader
                MessageBox.Show("Record Deleted!")
                Me.Hide()
                Connection.Close()

            Else
                MessageBox.Show("No Matching Records Found !")

            End If
        Catch ex As Exception
            ' MessageBox.Show("Hi")
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
        '''''
        TextBox1.Text = Nothing
    End Sub
End Class