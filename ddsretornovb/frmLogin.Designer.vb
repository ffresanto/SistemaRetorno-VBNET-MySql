<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.Pnl_Esquerda = New System.Windows.Forms.Panel()
        Me.Pic_Bg = New System.Windows.Forms.PictureBox()
        Me.Pnl_Direita = New System.Windows.Forms.Panel()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Pnl_Titulo = New System.Windows.Forms.Panel()
        Me.Txt_Usuario = New System.Windows.Forms.TextBox()
        Me.Pic_Usuario = New System.Windows.Forms.PictureBox()
        Me.Pnl_Senha = New System.Windows.Forms.Panel()
        Me.Txt_Senha = New System.Windows.Forms.TextBox()
        Me.Pic_Senha = New System.Windows.Forms.PictureBox()
        Me.Btn_Entrar = New System.Windows.Forms.Button()
        Me.Pic_Login = New System.Windows.Forms.PictureBox()
        Me.Btn_Sair = New System.Windows.Forms.Label()
        Me.Pnl_Central = New System.Windows.Forms.Panel()
        Me.Btn_Minimizar = New System.Windows.Forms.Label()
        Me.Pnl_Esquerda.SuspendLayout()
        CType(Me.Pic_Bg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Titulo.SuspendLayout()
        CType(Me.Pic_Usuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Senha.SuspendLayout()
        CType(Me.Pic_Senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Central.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Esquerda
        '
        Me.Pnl_Esquerda.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Pnl_Esquerda.Controls.Add(Me.Pic_Bg)
        Me.Pnl_Esquerda.Controls.Add(Me.Pnl_Direita)
        Me.Pnl_Esquerda.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Esquerda.Name = "Pnl_Esquerda"
        Me.Pnl_Esquerda.Size = New System.Drawing.Size(326, 421)
        Me.Pnl_Esquerda.TabIndex = 0
        '
        'Pic_Bg
        '
        Me.Pic_Bg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pic_Bg.Image = CType(resources.GetObject("Pic_Bg.Image"), System.Drawing.Image)
        Me.Pic_Bg.Location = New System.Drawing.Point(0, 0)
        Me.Pic_Bg.Name = "Pic_Bg"
        Me.Pic_Bg.Size = New System.Drawing.Size(326, 421)
        Me.Pic_Bg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Bg.TabIndex = 0
        Me.Pic_Bg.TabStop = False
        '
        'Pnl_Direita
        '
        Me.Pnl_Direita.Location = New System.Drawing.Point(324, 0)
        Me.Pnl_Direita.Name = "Pnl_Direita"
        Me.Pnl_Direita.Size = New System.Drawing.Size(360, 421)
        Me.Pnl_Direita.TabIndex = 6
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Yu Gothic UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Lbl_Titulo.Location = New System.Drawing.Point(361, 9)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(59, 25)
        Me.Lbl_Titulo.TabIndex = 1
        Me.Lbl_Titulo.Text = "Login"
        '
        'Pnl_Titulo
        '
        Me.Pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Pnl_Titulo.Controls.Add(Me.Txt_Usuario)
        Me.Pnl_Titulo.Controls.Add(Me.Pic_Usuario)
        Me.Pnl_Titulo.Location = New System.Drawing.Point(366, 191)
        Me.Pnl_Titulo.Name = "Pnl_Titulo"
        Me.Pnl_Titulo.Size = New System.Drawing.Size(279, 51)
        Me.Pnl_Titulo.TabIndex = 1
        '
        'Txt_Usuario
        '
        Me.Txt_Usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Txt_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Usuario.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Usuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Txt_Usuario.Location = New System.Drawing.Point(38, 14)
        Me.Txt_Usuario.Name = "Txt_Usuario"
        Me.Txt_Usuario.Size = New System.Drawing.Size(228, 22)
        Me.Txt_Usuario.TabIndex = 1
        Me.Txt_Usuario.Text = "Usuário"
        '
        'Pic_Usuario
        '
        Me.Pic_Usuario.Image = CType(resources.GetObject("Pic_Usuario.Image"), System.Drawing.Image)
        Me.Pic_Usuario.Location = New System.Drawing.Point(4, 11)
        Me.Pic_Usuario.Name = "Pic_Usuario"
        Me.Pic_Usuario.Size = New System.Drawing.Size(28, 28)
        Me.Pic_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Usuario.TabIndex = 0
        Me.Pic_Usuario.TabStop = False
        '
        'Pnl_Senha
        '
        Me.Pnl_Senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Pnl_Senha.Controls.Add(Me.Txt_Senha)
        Me.Pnl_Senha.Controls.Add(Me.Pic_Senha)
        Me.Pnl_Senha.Location = New System.Drawing.Point(366, 266)
        Me.Pnl_Senha.Name = "Pnl_Senha"
        Me.Pnl_Senha.Size = New System.Drawing.Size(279, 51)
        Me.Pnl_Senha.TabIndex = 2
        '
        'Txt_Senha
        '
        Me.Txt_Senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Senha.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Txt_Senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Txt_Senha.Location = New System.Drawing.Point(38, 15)
        Me.Txt_Senha.Name = "Txt_Senha"
        Me.Txt_Senha.Size = New System.Drawing.Size(228, 22)
        Me.Txt_Senha.TabIndex = 2
        Me.Txt_Senha.Text = "Senha"
        '
        'Pic_Senha
        '
        Me.Pic_Senha.Image = CType(resources.GetObject("Pic_Senha.Image"), System.Drawing.Image)
        Me.Pic_Senha.Location = New System.Drawing.Point(4, 12)
        Me.Pic_Senha.Name = "Pic_Senha"
        Me.Pic_Senha.Size = New System.Drawing.Size(28, 28)
        Me.Pic_Senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Senha.TabIndex = 1
        Me.Pic_Senha.TabStop = False
        '
        'Btn_Entrar
        '
        Me.Btn_Entrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Entrar.FlatAppearance.BorderSize = 0
        Me.Btn_Entrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Btn_Entrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Entrar.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Entrar.ForeColor = System.Drawing.SystemColors.Control
        Me.Btn_Entrar.Location = New System.Drawing.Point(366, 341)
        Me.Btn_Entrar.Name = "Btn_Entrar"
        Me.Btn_Entrar.Size = New System.Drawing.Size(279, 51)
        Me.Btn_Entrar.TabIndex = 3
        Me.Btn_Entrar.Text = "Entrar"
        Me.Btn_Entrar.UseVisualStyleBackColor = False
        '
        'Pic_Login
        '
        Me.Pic_Login.Image = CType(resources.GetObject("Pic_Login.Image"), System.Drawing.Image)
        Me.Pic_Login.Location = New System.Drawing.Point(442, 48)
        Me.Pic_Login.Name = "Pic_Login"
        Me.Pic_Login.Size = New System.Drawing.Size(125, 125)
        Me.Pic_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic_Login.TabIndex = 5
        Me.Pic_Login.TabStop = False
        '
        'Btn_Sair
        '
        Me.Btn_Sair.AutoSize = True
        Me.Btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Sair.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Sair.Location = New System.Drawing.Point(646, 4)
        Me.Btn_Sair.Name = "Btn_Sair"
        Me.Btn_Sair.Size = New System.Drawing.Size(19, 19)
        Me.Btn_Sair.TabIndex = 6
        Me.Btn_Sair.Text = "x"
        '
        'Pnl_Central
        '
        Me.Pnl_Central.BackColor = System.Drawing.Color.White
        Me.Pnl_Central.Controls.Add(Me.Btn_Minimizar)
        Me.Pnl_Central.Controls.Add(Me.Btn_Sair)
        Me.Pnl_Central.Controls.Add(Me.Pic_Login)
        Me.Pnl_Central.Controls.Add(Me.Btn_Entrar)
        Me.Pnl_Central.Controls.Add(Me.Pnl_Senha)
        Me.Pnl_Central.Controls.Add(Me.Pnl_Titulo)
        Me.Pnl_Central.Controls.Add(Me.Lbl_Titulo)
        Me.Pnl_Central.Controls.Add(Me.Pnl_Esquerda)
        Me.Pnl_Central.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Central.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Central.Name = "Pnl_Central"
        Me.Pnl_Central.Size = New System.Drawing.Size(668, 421)
        Me.Pnl_Central.TabIndex = 4
        '
        'Btn_Minimizar
        '
        Me.Btn_Minimizar.AutoSize = True
        Me.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Minimizar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Minimizar.Location = New System.Drawing.Point(626, 4)
        Me.Btn_Minimizar.Name = "Btn_Minimizar"
        Me.Btn_Minimizar.Size = New System.Drawing.Size(16, 19)
        Me.Btn_Minimizar.TabIndex = 7
        Me.Btn_Minimizar.Text = "-"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 421)
        Me.Controls.Add(Me.Pnl_Central)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Pnl_Esquerda.ResumeLayout(False)
        CType(Me.Pic_Bg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Titulo.ResumeLayout(False)
        Me.Pnl_Titulo.PerformLayout()
        CType(Me.Pic_Usuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Senha.ResumeLayout(False)
        Me.Pnl_Senha.PerformLayout()
        CType(Me.Pic_Senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pic_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Central.ResumeLayout(False)
        Me.Pnl_Central.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents Pnl_Esquerda As Panel
    Private WithEvents Pic_Bg As PictureBox
    Private WithEvents Pnl_Direita As Panel
    Private WithEvents Lbl_Titulo As Label
    Private WithEvents Pnl_Titulo As Panel
    Private WithEvents Txt_Usuario As TextBox
    Private WithEvents Pic_Usuario As PictureBox
    Private WithEvents Pnl_Senha As Panel
    Private WithEvents Txt_Senha As TextBox
    Private WithEvents Pic_Senha As PictureBox
    Private WithEvents Btn_Entrar As Button
    Private WithEvents Pic_Login As PictureBox
    Private WithEvents Btn_Sair As Label
    Private WithEvents Pnl_Central As Panel
    Private WithEvents Btn_Minimizar As Label
End Class
