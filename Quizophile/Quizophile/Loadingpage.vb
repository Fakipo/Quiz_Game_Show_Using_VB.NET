Public Class Loadingpage

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If Timer1.Interval = 3000 Then
            Me.Hide()
            Timer1.Enabled = False

        End If
        FrontPage.Show()
    End Sub
End Class


