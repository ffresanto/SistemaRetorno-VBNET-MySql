Imports MySql.Data.MySqlClient

Public Class frmConcl
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

    Private Sub Txt_Item_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Item.KeyPress
        If (Not Char.IsControl(e.KeyChar) _
                    AndAlso (Not Char.IsDigit(e.KeyChar) _
                    AndAlso (e.KeyChar <> Microsoft.VisualBasic.ChrW(46)))) Then
            e.Handled = True
        End If
    End Sub

    Public Sub Listar()
        Try
            Dim conectar As New conexaoDB()
            Dim strSQL As String = ""
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable


            strSQL = "SELECT ITEM_BACKLOG AS 'ITEM', NOME, EMPRESA, OBS AS 'DETALHES', TELEFONE, DATA_RETORNO AS 'DATA DE RETORNO' FROM TB_CONCLUIDO"

            da = New MySqlDataAdapter(strSQL, conectar.conexao)
            da.Fill(dt)
            Dgv_Geral.DataSource = dt

            For i = 0 To Dgv_Geral.Rows.Count - 1
                Dgv_Geral.Rows(i).Height = 50
            Next

            Dim x As Integer = Dgv_Geral.Rows.Count
            Txt_Total.Text = CInt(x) - 1

            Dgv_Geral.Columns.Item("ITEM").Width = 60
            Dgv_Geral.Columns.Item("EMPRESA").Width = 90
            Dgv_Geral.Columns.Item("TELEFONE").Width = 100
            Dgv_Geral.Columns.Item("DATA DE RETORNO").Width = 200
            Dgv_Geral.Columns.Item("NOME").Width = 120


        Catch ex As Exception

        Finally
        End Try
    End Sub

    Private Sub Btn_Concluir_Click(sender As Object, e As EventArgs) Handles Btn_Concluir.Click
        Dim mensagemLogout As Integer

        mensagemLogout = MsgBox("Deseja concluir esse retorno?", vbQuestion + vbYesNo + vbDefaultButton2, "Atenção!")

        If mensagemLogout = vbYes Then
            Try
                strSQL = "INSERT INTO TB_CONCLUIDO (NOME, EMPRESA, OBS, TELEFONE, DATA_RETORNO, ITEM_BACKLOG)
                SELECT NOME, EMPRESA, OBS, TELEFONE, DATA_RETORNO, ITEM_BACKLOG FROM TB_CLIENTE WHERE ITEM_BACKLOG = @ITEM_BACKLOG;

                DELETE FROM TB_CLIENTE WHERE ITEM_BACKLOG = @ITEM_BACKLOG;"

                comando = New MySqlCommand(strSQL, conectar.conexao)

                comando.Parameters.AddWithValue("@ITEM_BACKLOG", Txt_Item.Text)

                conectar.abrir()
                comando.ExecuteNonQuery()

                Listar()
                frmDashboard.Listar()
                MessageBox.Show("Retorno concluido com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                conectar.fechar()
            End Try
        End If
    End Sub

    Private Sub frmConcl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Listar()
    End Sub
End Class