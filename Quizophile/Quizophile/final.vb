Public Class final

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub final_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If (Form2.x = 1) Then
            Label2.Text = Form2.pass
        Else
            Label2.Text = Form3.pose
        End If
        Label5.Text = question.s
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Application.Exit()

    End Sub
End Class