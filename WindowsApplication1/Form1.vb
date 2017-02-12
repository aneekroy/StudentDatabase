
Imports MySql.Data.MySqlClient

Public Class Form1

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
            If ((SName.Text.Length = 0 Or SRoll.Text.Length = 0 Or ComboBoxDept.SelectedIndex = -1)) Then
                MessageBox.Show("NULL Values in TextBox !")
            Else
                Query = "insert into student.student_info (Roll_Number,Student_Name,Date_of_Birth,Department) values ('" & SRoll.Text & "','" & SName.Text & "','" & DateTimePicker1.Text & "','" & ComboBoxDept.Text & "')"
                Command = New MySqlCommand(Query, Connection)

                DataReader = Command.ExecuteReader
                MessageBox.Show("Data is Entered into student databse")
                DataReader.Close()
            End If

            Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            Connection.Dispose()
        End Try
        SName.Clear()
        SRoll.Clear()
        DateTimePicker1.Value = DateTimePicker1.MaxDate
        ' ComboBoxDept.Items.Clear()
        ComboBoxDept.SelectedIndex = -1

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub




End Class
