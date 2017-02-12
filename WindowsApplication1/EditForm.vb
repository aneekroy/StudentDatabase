Imports MySql.Data.MySqlClient
Public Class EditForm

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        SName.Text = Form4.dbDataSet.Rows(0).Item(1)
        SRoll.Text = Form4.dbDataSet.Rows(0).Item(0)
        DateTimePicker1.Text = Form4.dbDataSet.Rows(0).Item(2)
        ComboBoxDept.Text = Form4.dbDataSet.Rows(0).Item(3)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Connection As MySqlConnection
        Dim Command As MySqlCommand
        Connection = New MySqlConnection
        Connection.ConnectionString =
            "server=localhost;userid=root;password=root;database=student;"

        Try
            Dim DataReader As MySqlDataReader
            Connection.Open()
            ' MessageBox.Show("Connected to DataBase Student")
            Dim Query As String
            ' Query = "UPDATE student.student_info set (Student_Name='" & SName.Text & "',Date_of_Birth='" & DateTimePicker1.Text & "',Department='" & ComboBoxDept.Text & "') where Roll_Number = '" & SRoll.Text & "';"
            Query = "UPDATE student.student_info set Student_Name='" & SName.Text & "', Date_of_Birth='" & DateTimePicker1.Text & "',Department='" & ComboBoxDept.Text & "' where Roll_Number = '" & SRoll.Text & "';"
            Command = New MySqlCommand(Query, Connection)
            DataReader = Command.ExecuteReader()
            MessageBox.Show("Data is Updated !")
            DataReader.Close()
            Connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub SName_TextChanged(sender As Object, e As EventArgs) Handles SName.TextChanged

    End Sub
End Class