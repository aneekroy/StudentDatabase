Imports MySql.Data.MySqlClient


Public Class DisplaysingleRecord

    ' Dim SDA As New MySqlDataAdapter
    ' Dim dbDataSet As New DataTable
    Dim bSource As New BindingSource

    Private Sub DisplaysingleRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        DataGridView1.DataSource = Nothing
        DataGridView1.Rows.Clear()

        bSource.DataSource = DisplayRecord.dbDataSet
        DataGridView1.DataSource = bSource
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub


End Class