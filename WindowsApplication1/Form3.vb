Imports MySql.Data.MySqlClient
Public Class Form3
    Dim MySqlConnection As MySqlConnection
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim result = MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            MySqlConnection.Close()
            Me.Close()
        End If

    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False

        MySqlConnection = New MySqlConnection
        MySqlConnection.ConnectionString =
            "server=localhost;userid=root;password=root;database=student;"

        Try
            MySqlConnection.Open()
            MessageBox.Show("Connected to DataBase Student")
            MySqlConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Me.Close()
        Finally
            MySqlConnection.Dispose()
        End Try

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DisplayRecord.Show()
    End Sub

    'Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    '    MySqlConnection.Close()
    '    Close()
    'End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form2.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DeleteRecord.Show()
    End Sub
End Class