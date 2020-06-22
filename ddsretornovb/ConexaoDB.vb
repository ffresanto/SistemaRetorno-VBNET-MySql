Imports MySql.Data.MySqlClient

Public Class conexaoDB
    Public conexao As New MySqlConnection("Server=localhost;Port=3307;Database=db_nomebanco;Uid=seu_usuario;Pwd=sua_senha;")
    Public Sub abrir()
        Try
            If conexao.State = 0 Then
                conexao.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao conectar com Banco de Dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Public Sub fechar()
        Try
            If conexao.State = 1 Then
                conexao.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Falha ao fechar conexão com o banco de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
