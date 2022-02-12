Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            wav-vatsim23.Show()
            Me.Hide()
        End If
        Label1.Text = ProgressBar1.Value & (" %")
    End Sub
End Class
