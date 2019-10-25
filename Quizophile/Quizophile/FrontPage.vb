Imports System.Data.OleDb
Public Class FrontPage
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Projects\BCA IV Project\mini p\user.accdb")
    Dim cmd As OleDbCommand
    Dim n As String
    Dim dr As OleDbDataReader
    Public x As Integer
    Public pass As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Registration.Show()
        Me.Hide()

    End Sub

    Private Sub Namebox_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Namebox.KeyDown

        If e.KeyData = Keys.Enter Then
            If Namebox.Text = "" Then
                My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\erro.wav")
                MessageBox.Show("Enter a valid player name")
                My.Computer.Audio.Stop()
            Else
                pass = Namebox.Text
                cmd = New OleDbCommand("select uname from player where uname = '" & Namebox.Text & "' ", con)
                con.Open()
                dr = cmd.ExecuteReader
                If dr.Read = True Then
                    n = dr("uname")
                End If
                If Namebox.Text = n Then
                    Me.Hide()
                    My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\unconvinced.wav")
                    x = 1
                    Start.Show()
                Else
                    My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\erro.wav")
                    MessageBox.Show("Register your self first")
                    My.Computer.Audio.Stop()

                End If
                con.Close()
            End If
        End If


    End Sub

    Private Sub NewToGame_Click_1(sender As System.Object, e As System.EventArgs) Handles NewToGame.Click
        Namebox.Text = String.Empty
        Me.Hide()
        Registration.Show()
    End Sub

    Private Sub FrontPage_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If Namebox.Text = "" Then
            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\erro.wav")
            MessageBox.Show("Enter a valid player name")
            My.Computer.Audio.Stop()
        Else
            pass = Namebox.Text
            cmd = New OleDbCommand("select uname from player where uname = '" & Namebox.Text & "' ", con)
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                n = dr("uname")
            End If
            If Namebox.Text = n Then
                Me.Hide()
                My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\unconvinced.wav")
                x = 1
                Start.Show()
            Else
                My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\erro.wav")
                MessageBox.Show("Register your self first")
                My.Computer.Audio.Stop()

            End If
            con.Close()
        End If


    End Sub
End Class