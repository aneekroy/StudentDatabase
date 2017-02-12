Imports MySql.Data.MySqlClient
Public Class Form4
    Dim Roll As String
    Dim Connection As MySqlConnection
    Dim Command As MySqlCommand
    Public dbDataSet As New DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If SRoll.Text Is Nothing Then
            MessageBox.Show("Enter Roll Number !")
        Else
            Connection = New MySqlConnection
            Connection.ConnectionString = "server=localhost;userid=root;password=root;database=student;"
            Dim SDA As New MySqlDataAdapter
            Dim bSource As New BindingSource
            ' Dim DataReader As MySqlDataReader
            Try
                Connection.Open()
                Dim Query As String
                Query = "Select * from student.student_info where Roll_Number like '" & Me.SRoll.Text & "';"
                Command = New MySqlCommand(Query, Connection)

                SDA.SelectCommand = Command
                SDA.Fill(dbDataSet)
                bSource.DataSource = dbDataSet
                If dbDataSet.Rows.Count = 1 Then
                    EditForm.Show()
                    Me.Hide()
                    Connection.Close()
                    ' DataReader.Close()
                Else
                    MessageBox.Show("No Matching Records Found !")

                End If
            Catch ex As Exception
                ' MessageBox.Show("Hi")
                MessageBox.Show(ex.Message)
            Finally
                Connection.Dispose()
            End Try
            'EditForm.Show()
        End If



    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub
End Class