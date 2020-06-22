Imports MySql.Data.MySqlClient

Public Class frmAdd
    Private x, y As Integer
    Private newpoint As Point

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

    Private Sub Txt_Item_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Item.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                    AndAlso (Not Char.IsDigit(e.KeyChar) _
                    AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Btn_Adicionar_Click(sender As Object, e As EventArgs) Handles Btn_Adicionar.Click
        Dim conectar As New conexaoDB()
        Dim comando As MySqlCommand
        Dim strSQL As String


        Dim mensagemLogout As Integer

        mensagemLogout = MsgBox("Deseja adicionar esse retorno?", vbQuestion + vbYesNo + vbDefaultButton2, "Atenção!")

        If mensagemLogout = vbYes Then

            Try

                strSQL = "INSERT INTO TB_CLIENTE (NOME, EMPRESA, OBS, TELEFONE, DATA_RETORNO, ITEM_BACKLOG) VALUES (@NOME, @EMPRESA, @OBS, @TELEFONE, @DATA_RETORNO, @ITEM_BACKLOG)"

                comando = New MySqlCommand(strSQL, conectar.conexao)
                comando.Parameters.AddWithValue("@NOME", Txt_Nome.Text)
                comando.Parameters.AddWithValue("@EMPRESA", Txt_Empresa.Text)
                comando.Parameters.AddWithValue("@OBS", Txt_Obs.Text)
                comando.Parameters.AddWithValue("@TELEFONE", Txt_Telefone.Text)
                comando.Parameters.AddWithValue("@DATA_RETORNO", Dtp_Data.Text)
                comando.Parameters.AddWithValue("@ITEM_BACKLOG", Txt_Item.Text)

                conectar.abrir()
                comando.ExecuteNonQuery()
                frmDashboard.Listar()
                MessageBox.Show("Adicionado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conectar.fechar()
                conectar = Nothing
                conectar = Nothing

                Txt_Item.Text = ""
                Txt_Nome.Text = ""
                Txt_Obs.Text = ""
                Txt_Telefone.Text = ""
                Dtp_Data.ResetText()
                Txt_Empresa.Text = ""
            End Try

        Else
        End If
    End Sub

    Private Sub Txt_Telefone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Telefone.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
            AndAlso (Not Char.IsDigit(e.KeyChar) _
            AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub
End Class