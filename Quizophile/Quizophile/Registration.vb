Imports System.Data.OleDb
Public Class Registration
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Projects\BCA IV Project\mini p\user.accdb")
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim n As String
    Public pose As String
    Private Sub Submit_Click(sender As System.Object, e As System.EventArgs) Handles Submit.Click
        Try
            pose = NameBox.Text
            cmd = New OleDbCommand("insert into player (uname,phone,age)values('" & NameBox.Text & "'," & MobBox.Text & "," & AgeBox.Text & ")", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            FrontPage.x = 0
            Me.Hide()
            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\unconvinced.wav")
            Start.Show()
        Catch ex As Exception
            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\erro.wav")
            MessageBox.Show("Something went wrong")
            My.Computer.Audio.Stop()
            NameBox.Text = String.Empty
            MobBox.Text = String.Empty
            AgeBox.Text = String.Empty
            Me.Close()
            FrontPage.Show()
        End Try





    End Sub

    Private Sub Back_Click(sender As System.Object, e As System.EventArgs) Handles Back.Click
        Me.Hide()
        FrontPage.Show()

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()

    End Sub
End Class