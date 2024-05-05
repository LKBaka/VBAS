Public Class Loading
    Public time
    Private Sub MainPgae_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
        If time = 3 Then
            MainForm.Show()
            Close()
        End If
    End Sub

    Private Sub Loading_Load(sender As Object, e As EventArgs) Handles Me.Load
        'ProcCheck.Show()
        Timer1.Start()
    End Sub
End Class