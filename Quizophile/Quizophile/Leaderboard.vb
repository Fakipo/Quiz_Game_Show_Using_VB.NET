Public Class leader
    Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Projects\BCA IV Project\mini p\user.accdb")
    Dim cmd1 As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Private Sub leaderboard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim cmd As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter("select uname,score from player order by score desc ", con)
        Dim ds As DataSet = New DataSet
        cmd.Fill(ds, "player")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "player"
        'uname
        Name1.Text = DataGridView1.Rows(0).Cells(0).Value
        Name2.Text = DataGridView1.Rows(1).Cells(0).Value
        Name3.Text = DataGridView1.Rows(2).Cells(0).Value
        Name4.Text = DataGridView1.Rows(3).Cells(0).Value + Name5.Text = DataGridView1.Rows(4).Cells(0).Value
        'score
        Score1.Text = DataGridView1.Rows(0).Cells(1).Value
        Score2.Text = DataGridView1.Rows(1).Cells(1).Value
        Score3.Text = DataGridView1.Rows(2).Cells(1).Value
        Score4.Text = DataGridView1.Rows(3).Cells(1).Value
        Score5.Text = DataGridView1.Rows(4).Cells(1).Value
        con.Close()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Start.Show()
        Me.Hide()
    End Sub
End Class