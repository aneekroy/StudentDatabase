Imports MySql.Data.MySqlClient
Public Class Form5
    Dim Connection As MySqlConnection
    Dim Command As MySqlCommand
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Connection = New MySqlConnection
        Connection.ConnectionString = "server=localhost;userid=root;password=root;database=student;"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        ' Dim DataReader As MySqlDataReader
        Try
            Connection.Open()
            Dim Query As String
            Query = "Select * from student.student_info"
            Command = New MySqlCommand(Query, Connection)
            'DataReader = Command.ExecuteReader
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            ' DataReader.Close()\
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            Connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
    End Sub


End Class