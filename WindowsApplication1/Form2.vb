Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Public Class Form2
    Dim Connection As MySqlConnection
    Dim Command As MySqlCommand
    Dim Counter As Integer
    Dim No_Of_Rows As Integer
    Dim Curr_Rows As Integer
    Dim SDA As New MySqlDataAdapter
    Dim dbDataSet As New DataTable
    Dim bSource As New BindingSource



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        dbDataSet.Clear()
        If Button2.Enabled = False Then
            Button2.Enabled = True
        End If

        Try

            SDA.SelectCommand = Command

            If ((Counter - 5) >= 0) Then
                SDA.Fill(Counter - 5, 5, dbDataSet)
                Counter = (Counter - 5)
                ' Label3.Text = "Counter =" & (Counter)
            Else
                SDA.Fill(0, 5, dbDataSet)
                Counter = 0
                ' Label3.Text = "Counter =" + (Counter)
                Counter = 0
            End If

            Curr_Rows = dbDataSet.Rows.Count()
            If (Counter <= 0) Then
                Counter = 0
                Button1.Enabled = False
                Button2.Enabled = True
            End If
            Curr_Rows = dbDataSet.Rows.Count()
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
        Label2.Text = "Page " & Int(Math.Round(Counter / 5) + 1) & " of " & Int(Math.Ceiling(No_Of_Rows / 5))
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()
        dbDataSet.Clear()

        Try

            SDA.SelectCommand = Command
            Counter = Counter + Curr_Rows
            SDA.Fill(Counter, 5, dbDataSet)
            ' Label3.Text = "Counter =" & (Counter)
            Curr_Rows = dbDataSet.Rows.Count()
            If (Counter + Curr_Rows) >= No_Of_Rows Then
                Button2.Enabled = False
            Else
                Button2.Enabled = True
            End If
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
        Label2.Text = "Page " & Int(Math.Round(Counter / 5) + 1) & " of " & Int(Math.Ceiling(No_Of_Rows / 5))
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        Button1.Enabled = False
        Button2.Enabled = True
        Counter = 0
        Connection = New MySqlConnection
        Connection.ConnectionString = "server=localhost;userid=root;password=root;database=student;"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            Connection.Open()
            Dim Query As String
            Query = "Select * from student.student_info"
            Command = New MySqlCommand(Query, Connection)
            'DataReader = Command.ExecuteReader
            SDA.SelectCommand = Command
            SDA.Fill(dbDataSet)
            No_Of_Rows = dbDataSet.Rows.Count()
            If dbDataSet.Rows.Count() <= 5 Then
                Button2.Enabled = False
            End If
            dbDataSet.Clear()
            SDA.Fill(0, 5, dbDataSet)

            Counter = 0
            ' Label3.Text = Counter & " " & No_Of_Rows
            Curr_Rows = dbDataSet.Rows.Count()
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)
            Connection.Close()
            Label2.Text = "Page 1 of " & Int(Math.Ceiling(No_Of_Rows / 5))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Connection.Dispose()
        End Try
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub


End Class