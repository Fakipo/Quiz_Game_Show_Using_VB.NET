Imports System.Data.OleDb
Public Class Form3
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPP-PC\Desktop\mini p\user.accdb")
    Dim cmd As OleDbCommand
    Public pose As String
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        pose = TextBox1.Text
        cmd = New OleDbCommand("insert into user1 (uname,phone,age)values('" & TextBox1.Text & "'," & TextBox2.Text & "," & TextBox3.Text & ")", con)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        Form2.x = 0
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Stop()

    End Sub
End Class