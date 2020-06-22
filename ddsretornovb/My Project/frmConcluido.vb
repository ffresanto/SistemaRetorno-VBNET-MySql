Imports MySql.Data.MySqlClient

Public Class frmConcluido
    Private x, y As Integer
    Private newpoint As Point
    Private conectar As New conexaoDB
    Private strSQL As String
    Private conexao As MySqlConnection
    Private comando As MySqlCommand
    Private dr As MySqlDataReader

    Private Sub Lbl_Minimizar_Click(sender As Object, e As EventArgs) Handles Lbl_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub Lbl_Fechar_Click(sender As Object, e As EventArgs) Handles Lbl_Fechar.Click
        Me.Close()
    End Sub

    Private Sub Pnl_Superior_MouseDown(sender As Object, e As MouseEventArgs) Handles Pnl_Superior.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Pnl_Superior_MouseMove(sender As Object, e As MouseEventArgs) Handles Pnl_Superior.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Pnl_Principal_MouseDown(sender As Object, e As MouseEventArgs) Handles Pnl_Principal.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Pnl_Principal_MouseMove(sender As Object, e As MouseEventArgs) Handles Pnl_Principal.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class