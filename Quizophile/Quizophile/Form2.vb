Imports System.Data.OleDb
Public Class Form2
    Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPP-PC\Desktop\mini p\user.accdb")
    Dim cmd As OleDbCommand
    Dim n As String
    Dim dr As OleDbDataReader
    Public x As Integer
    Public pass As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

  

    Private Sub TextBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyData = Keys.Enter Then
            pass = TextBox1.Text

            cmd = New OleDbCommand("select uname from user1 where uname = '" & TextBox1.Text & "' ", con)
            con.Open()
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                n = dr("uname")
                con.Close()
            End If
            If TextBox1.Text = n Then
                Me.Hide()
                x = 1
                Form4.Show()
            Else
                MessageBox.Show("Register your self first")

            End If


        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class