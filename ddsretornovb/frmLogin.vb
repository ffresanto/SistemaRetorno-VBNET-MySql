Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private x, y As Integer
    Private newpoint As Point

    Private Sub frmLogin_Click(sender As Object, e As EventArgs) Handles Btn_Sair.Click
        Me.Close()
    End Sub

    Private Sub Pnl_Central_MouseDown(sender As Object, e As MouseEventArgs) Handles Pnl_Central.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Pnl_Central_MouseMove(sender As Object, e As MouseEventArgs) Handles Pnl_Central.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Pic_Bg_MouseDown(sender As Object, e As MouseEventArgs) Handles Pic_Bg.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Txt_Usuario_Enter(sender As Object, e As EventArgs) Handles Txt_Usuario.Enter
        If Txt_Usuario.Text = "Usuário" Then
            Txt_Usuario.Text = ""
            Txt_Usuario.ForeColor = Color.Gray()
        End If
    End Sub

    Private Sub Txt_Usuario_Leave(sender As Object, e As EventArgs) Handles Txt_Usuario.Leave
        If Txt_Usuario.Text = "" Then
            Txt_Usuario.Text = "Usuário"
            Txt_Usuario.ForeColor = Color.Gray()
        End If
    End Sub

    Private Sub Txt_Senha_Enter(sender As Object, e As EventArgs) Handles Txt_Senha.Enter
        If Txt_Senha.Text = "Senha" Then
            Txt_Senha.Text = ""
            Txt_Senha.ForeColor = Color.Gray()
            Txt_Senha.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Txt_Senha_Leave(sender As Object, e As EventArgs) Handles Txt_Senha.Leave
        If Txt_Senha.Text = "" Then
            Txt_Senha.Text = "Senha"
            Txt_Senha.ForeColor = Color.Gray()
            Txt_Senha.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Btn_Entrar_Click(sender As Object, e As EventArgs) Handles Btn_Entrar.Click
        Dim conectar As New conexaoDB()
        Dim strSQL As String

        Dim usuario As String = Txt_Usuario.Text
        Dim senha As String = Txt_Senha.Text
        Try
            If usuario = "" Or senha = "" Then
                MessageBox.Show("Preencha os campos!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                conectar.abrir()
                strSQL = "SELECT * FROM TB_LOGIN WHERE USUARIO = '" & Txt_Usuario.Text & "' AND SENHA = '" & Txt_Senha.Text & "'"

                Dim cmd As New MySqlCommand(strSQL, conectar.conexao)
                Dim dr As MySqlDataReader = cmd.ExecuteReader

                If dr.Read = False Then
                    MessageBox.Show("Usuario ou Senha invalida!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Txt_Usuario.Text = ""
                    Txt_Senha.Text = ""
                    Txt_Usuario.Focus()
                Else
                    frmSplash.Show()
                    Me.Hide()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conectar.fechar()
        End Try

    End Sub

    Private Sub Pic_Bg_MouseMove(sender As Object, e As MouseEventArgs) Handles Pic_Bg.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub
End Class
