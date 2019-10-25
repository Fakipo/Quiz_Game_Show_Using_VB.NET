Public Class Start

    Private Sub Play_Click(sender As System.Object, e As System.EventArgs) Handles Play.Click
        Me.Hide()
        question.Show()
    End Sub

    Private Sub Rules_Click(sender As System.Object, e As System.EventArgs) Handles Rules.Click
        Me.Hide()
        Rule.Show()
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()
        If (FrontPage.x = 1) Then
            PlayerName.Text = FrontPage.pass
        Else
            PlayerName.Text = Registration.pose
        End If

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles PlayerName.Click

    End Sub

    Private Sub Leaderboard_Click(sender As System.Object, e As System.EventArgs) Handles Leaderboard.Click
        Me.Hide()
        Leader.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Application.Exit()
    End Sub
End Class