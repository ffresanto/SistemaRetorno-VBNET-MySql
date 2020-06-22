Imports MySql.Data.MySqlClient

Public Class frmDashboard
    Private x, y As Integer
    Private newpoint As Point


    Private Sub Btn_Sair_Click(sender As Object, e As EventArgs) Handles Btn_Sair.Click
        Me.Close()
    End Sub

    Private Sub Btn_Minimizar_Click(sender As Object, e As EventArgs) Handles Btn_Minimizar.Click
        Me.WindowState = FormWindowState.Minimized
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

    Private Sub Pnl_Esquerda_MouseDown(sender As Object, e As MouseEventArgs) Handles Pnl_Esquerda.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Pnl_Esquerda_MouseMove(sender As Object, e As MouseEventArgs) Handles Pnl_Esquerda.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Pnl_Ddsretorno_MouseDown(sender As Object, e As MouseEventArgs) Handles Pnl_Ddsretorno.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click
        Dim mensagemLogout As Integer

        mensagemLogout = MsgBox("Deseja sair do sistema?", vbQuestion + vbYesNo + vbDefaultButton2, "Atenção!")

        If mensagemLogout = vbYes Then
            Me.Hide()
            frmLogin.Show()
        Else
        End If

    End Sub

    Private Sub Dgv_Geral_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Geral.CellContentClick

    End Sub

    Private Sub Pnl_Ddsretorno_MouseMove(sender As Object, e As MouseEventArgs) Handles Pnl_Ddsretorno.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= x
            newpoint.Y -= y
            Me.Location = newpoint
            Application.DoEvents()
        End If
    End Sub

    Private Sub Btn_Adicionar_Click(sender As Object, e As EventArgs) Handles Btn_Adicionar.Click
        frmAdd.Show()
    End Sub

    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        Listar()
    End Sub

    Private Sub Btn_Alterar_Click(sender As Object, e As EventArgs) Handles Btn_Alterar.Click
        frmAlterar.Show()
    End Sub

    Private Sub Btn_Remove_Click(sender As Object, e As EventArgs) Handles Btn_Remove.Click
        frmDeletar.Show()
    End Sub

    Private Sub Btn_Concluido_Click(sender As Object, e As EventArgs) Handles Btn_Concluido.Click
        frmConcl.Show()
    End Sub

    Public Sub Listar()
        Try
            Dim conectar As New conexaoDB()
            Dim strSQL As String = ""
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable


            strSQL = "SELECT ITEM_BACKLOG AS 'ITEM', NOME, EMPRESA, OBS AS 'DETALHES', TELEFONE, DATA_RETORNO AS 'DATA DE RETORNO' FROM tb_cliente t;"

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

End Class