Public Class frmSplash
    Private Sub frmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = (BackColor)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Pnl_Progress.Width += 1
        If Pnl_Progress.Width >= 220 Then
            Timer1.Stop()
            frmDashboard.Show()
            Me.Close()
        End If

    End Sub
End Class