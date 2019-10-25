Public Class Result
    Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Projects\BCA IV Project\mini p\user.accdb")
    Dim cmd As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub final_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        My.Computer.Audio.Stop()
        If (FrontPage.x = 1) Then
            PlayerName.Text = FrontPage.pass
        Else
            PlayerName.Text = Registration.pose
        End If
        Score.Text = question.s
        cmd = New OleDb.OleDbCommand("select Score from player where uname='" & PlayerName.Text & "'", con)
        con.Open()
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            Tscore.Text = dr("Score")
        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Start.Show()
        question.Close()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub
End Class