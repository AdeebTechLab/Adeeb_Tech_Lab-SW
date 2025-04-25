Public Class SplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.ProgressBar.Value = ProgressBar.Value + 1
        If ProgressBar.Value >= 100 Then
            Timer1.Stop()
            Form1.Show()
            Me.Hide()
        End If
    End Sub
End Class