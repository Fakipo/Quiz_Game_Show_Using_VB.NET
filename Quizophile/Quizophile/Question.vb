Public Class question
    Dim con As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=F:\Projects\BCA IV Project\mini p\user.accdb")
    Dim cmd1 As OleDb.OleDbCommand
    Dim dr As OleDb.OleDbDataReader
    Dim st As String
    Dim i As Integer = 1
    Dim j As Integer = 1
    Public s As Integer = 0
    Dim rn As New Random
    Dim b As Integer = 0
    Dim name2 As String
    Dim q As Integer = rn.Next(1, 50)
    Private Sub question_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer3.Start()
        My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\Tik tik.wav")
        If (FrontPage.x = 1) Then
            PlayerName.Text = FrontPage.pass
        Else
            PlayerName.Text = Registration.pose
        End If
        cmd1 = New OleDb.OleDbCommand("select * from questions where qno = " & q & "  ", con)

        con.Open()
        dr = cmd1.ExecuteReader()
        If dr.Read = True Then
            Questions.Text = dr("question")
            Option1.Text = dr("o1")
            Option2.Text = dr("o2")
            Option3.Text = dr("o3")
            st = dr("ca")
        End If
        con.Close()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Option1.BackColor = Color.White
        Option2.BackColor = Color.White
        Option3.BackColor = Color.White
        Option1.Enabled = True
        Option2.Enabled = True
        Option3.Enabled = True



        If Timer1.Interval = 14000 Then
            PictureBox3.Visible = False
            Label4.Visible = True
            Label7.Visible = True
            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\Tik tik.wav")
            Timer1.Stop()
            b = 0
            Timer1.Start()
            Timer3.Start()
            Label4.Text = 10
            Timer2.Stop()
            Timer2.Start()
            j = j + 1
            If j = 11 Then
                My.Computer.Audio.Stop()
                Timer1.Stop()
                Timer2.Stop()
                Me.Hide()
                Result.Show()
            End If
            Qno.Text = "Q" + j.ToString()

            q = rn.Next(1, 50)

            cmd1 = New OleDb.OleDbCommand("select * from questions where qno = " & q & "  ", con)
            con.Open()
            dr = cmd1.ExecuteReader()
            If dr.Read = True Then
                Questions.Text = dr("question")
                Option1.Text = dr("o1")
                Option2.Text = dr("o2")
                Option3.Text = dr("o3")
                st = dr("ca")
                con.Close()
            End If



        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        If Timer2.Interval = 12000 And b = 0 Then
            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\wrong-answer-sound-effect.wav")
            If Option1.Text = st Then
                Option1.BackColor = Color.Green
                Option2.BackColor = Color.Red
                Option3.BackColor = Color.Red
            ElseIf Option2.Text = st Then
                Option2.BackColor = Color.Green
                Option1.BackColor = Color.Red
                Option3.BackColor = Color.Red
            ElseIf Option3.Text = st Then
                Option3.BackColor = Color.Green
                Option1.BackColor = Color.Red
                Option2.BackColor = Color.Red
            End If
            Option3.Enabled = False
            Option2.Enabled = False
            Option1.Enabled = False
            b = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Option1.Click
        sender.backcolor = Color.Gray
        If Option1.Text = st Then

            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\correct-answer-sound-effect-19.wav")
            sender.backcolor = Color.Green
            s = s + 20
            Score.Text = s
            cmd1 = New OleDb.OleDbCommand("update player set score = score+20 where uname = '" & PlayerName.Text & "'", con)
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
        Else
            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\wrong-answer-sound-effect.wav")
            sender.backcolor = Color.Red
        End If
        Option2.Enabled = False
        Option3.Enabled = False
        If Option2.Text = st Then
            Option2.BackColor = Color.Green
        ElseIf Option3.Text = st Then
            Option3.BackColor = Color.Green

        End If
        b = 1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Option2.Click
        sender.backcolor = Color.Gray
        If Option2.Text = st Then
            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\correct-answer-sound-effect-19.wav")
            sender.backcolor = Color.Green
            s = s + 20
            Score.Text = s
            cmd1 = New OleDb.OleDbCommand("update player set score = score+20 where uname = '" & PlayerName.Text & "'", con)
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
        Else
            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\wrong-answer-sound-effect.wav")
            sender.backcolor = Color.Red

        End If
        Option1.Enabled = False
        Option3.Enabled = False

        If Option1.Text = st Then
            Option1.BackColor = Color.Green
        ElseIf Option3.Text = st Then
            Option3.BackColor = Color.Green

        End If
        b = 1
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Option3.Click
        sender.backcolor = Color.Gray
        If Option3.Text = st Then

            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\correct-answer-sound-effect-19.wav")
            sender.backcolor = Color.Green
            s = s + 20
            Score.Text = s
            cmd1 = New OleDb.OleDbCommand("update player set score = score+20 where uname = '" & PlayerName.Text & "'", con)
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
        Else
            My.Computer.Audio.Play("F:\Projects\BCA IV Project\mini p\wrong-answer-sound-effect.wav")
            sender.backcolor = Color.Red

        End If
        Option2.Enabled = False
        Option1.Enabled = False
        If Option1.Text = st Then
            Option1.BackColor = Color.Green
        ElseIf Option2.Text = st Then
            Option2.BackColor = Color.Green
        End If
        b = 1
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles PlayerName.Click

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Questions.Click

    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        If Timer3.Interval Mod 1000 = 0 Then
            Label4.Text = (Label4.Text - 1)
            If Label4.Text = 0 Then
                Timer3.Stop()
                Label4.Visible = False
                Label7.Visible = False
                PictureBox3.Visible = True
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Score_Click(sender As Object, e As EventArgs) Handles Score.Click

    End Sub
End Class