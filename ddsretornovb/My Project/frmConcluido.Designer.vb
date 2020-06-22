<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcluido
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConcluido))
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.Btn_Minimizar = New System.Windows.Forms.Label()
        Me.Txt_Item = New System.Windows.Forms.TextBox()
        Me.Pnl_Item = New System.Windows.Forms.Panel()
        Me.Lbl_Item = New System.Windows.Forms.Label()
        Me.Pnl_Superior = New System.Windows.Forms.Panel()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Pnl_LinhaSuperior = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbl_Minimizar = New System.Windows.Forms.Label()
        Me.Lbl_Fechar = New System.Windows.Forms.Label()
        Me.Btn_Sair = New System.Windows.Forms.Label()
        Me.Pnl_Linha = New System.Windows.Forms.Panel()
        Me.Pnl_Principal = New System.Windows.Forms.Panel()
        Me.Pnl_Item.SuspendLayout()
        Me.Pnl_Superior.SuspendLayout()
        Me.Pnl_LinhaSuperior.SuspendLayout()
        Me.Pnl_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Buscar
        '
        Me.Btn_Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Buscar.FlatAppearance.BorderSize = 0
        Me.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Buscar.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Buscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Btn_Buscar.Image = CType(resources.GetObject("Btn_Buscar.Image"), System.Drawing.Image)
        Me.Btn_Buscar.Location = New System.Drawing.Point(197, 74)
        Me.Btn_Buscar.Name = "Btn_Buscar"
        Me.Btn_Buscar.Size = New System.Drawing.Size(46, 38)
        Me.Btn_Buscar.TabIndex = 19
        Me.Btn_Buscar.UseVisualStyleBackColor = False
        '
        'Btn_Minimizar
        '
        Me.Btn_Minimizar.AutoSize = True
        Me.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Minimizar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Minimizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Minimizar.Location = New System.Drawing.Point(796, 17)
        Me.Btn_Minimizar.Name = "Btn_Minimizar"
        Me.Btn_Minimizar.Size = New System.Drawing.Size(16, 19)
        Me.Btn_Minimizar.TabIndex = 9
        Me.Btn_Minimizar.Text = "-"
        '
        'Txt_Item
        '
        Me.Txt_Item.BackColor = System.Drawing.Color.White
        Me.Txt_Item.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Item.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Item.Location = New System.Drawing.Point(3, 9)
        Me.Txt_Item.MaxLength = 4
        Me.Txt_Item.Name = "Txt_Item"
        Me.Txt_Item.Size = New System.Drawing.Size(56, 19)
        Me.Txt_Item.TabIndex = 1
        '
        'Pnl_Item
        '
        Me.Pnl_Item.BackColor = System.Drawing.Color.White
        Me.Pnl_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Item.Controls.Add(Me.Txt_Item)
        Me.Pnl_Item.Location = New System.Drawing.Point(127, 74)
        Me.Pnl_Item.Name = "Pnl_Item"
        Me.Pnl_Item.Size = New System.Drawing.Size(64, 38)
        Me.Pnl_Item.TabIndex = 1
        '
        'Lbl_Item
        '
        Me.Lbl_Item.AutoSize = True
        Me.Lbl_Item.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Item.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Lbl_Item.Location = New System.Drawing.Point(22, 85)
        Me.Lbl_Item.Name = "Lbl_Item"
        Me.Lbl_Item.Size = New System.Drawing.Size(99, 19)
        Me.Lbl_Item.TabIndex = 5
        Me.Lbl_Item.Text = "Item backlog"
        '
        'Pnl_Superior
        '
        Me.Pnl_Superior.BackColor = System.Drawing.Color.White
        Me.Pnl_Superior.Controls.Add(Me.Lbl_Titulo)
        Me.Pnl_Superior.Controls.Add(Me.Pnl_LinhaSuperior)
        Me.Pnl_Superior.Controls.Add(Me.Lbl_Minimizar)
        Me.Pnl_Superior.Controls.Add(Me.Lbl_Fechar)
        Me.Pnl_Superior.Controls.Add(Me.Btn_Minimizar)
        Me.Pnl_Superior.Controls.Add(Me.Btn_Sair)
        Me.Pnl_Superior.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Superior.Name = "Pnl_Superior"
        Me.Pnl_Superior.Size = New System.Drawing.Size(721, 55)
        Me.Pnl_Superior.TabIndex = 2
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(11, 20)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(123, 19)
        Me.Lbl_Titulo.TabIndex = 20
        Me.Lbl_Titulo.Text = "Alterar Retorno"
        '
        'Pnl_LinhaSuperior
        '
        Me.Pnl_LinhaSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Pnl_LinhaSuperior.Controls.Add(Me.Label9)
        Me.Pnl_LinhaSuperior.Controls.Add(Me.Label10)
        Me.Pnl_LinhaSuperior.Location = New System.Drawing.Point(-1, -4)
        Me.Pnl_LinhaSuperior.Name = "Pnl_LinhaSuperior"
        Me.Pnl_LinhaSuperior.Size = New System.Drawing.Size(721, 10)
        Me.Pnl_LinhaSuperior.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(796, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(816, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "x"
        '
        'Lbl_Minimizar
        '
        Me.Lbl_Minimizar.AutoSize = True
        Me.Lbl_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Minimizar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Minimizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Lbl_Minimizar.Location = New System.Drawing.Point(670, 18)
        Me.Lbl_Minimizar.Name = "Lbl_Minimizar"
        Me.Lbl_Minimizar.Size = New System.Drawing.Size(16, 19)
        Me.Lbl_Minimizar.TabIndex = 8
        Me.Lbl_Minimizar.Text = "-"
        '
        'Lbl_Fechar
        '
        Me.Lbl_Fechar.AutoSize = True
        Me.Lbl_Fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Lbl_Fechar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Fechar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Lbl_Fechar.Location = New System.Drawing.Point(690, 18)
        Me.Lbl_Fechar.Name = "Lbl_Fechar"
        Me.Lbl_Fechar.Size = New System.Drawing.Size(19, 19)
        Me.Lbl_Fechar.TabIndex = 9
        Me.Lbl_Fechar.Text = "x"
        '
        'Btn_Sair
        '
        Me.Btn_Sair.AutoSize = True
        Me.Btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Sair.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Sair.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Sair.Location = New System.Drawing.Point(816, 17)
        Me.Btn_Sair.Name = "Btn_Sair"
        Me.Btn_Sair.Size = New System.Drawing.Size(19, 19)
        Me.Btn_Sair.TabIndex = 8
        Me.Btn_Sair.Text = "x"
        '
        'Pnl_Linha
        '
        Me.Pnl_Linha.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Pnl_Linha.Location = New System.Drawing.Point(0, 47)
        Me.Pnl_Linha.Name = "Pnl_Linha"
        Me.Pnl_Linha.Size = New System.Drawing.Size(721, 10)
        Me.Pnl_Linha.TabIndex = 3
        '
        'Pnl_Principal
        '
        Me.Pnl_Principal.BackColor = System.Drawing.Color.White
        Me.Pnl_Principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Principal.Controls.Add(Me.Btn_Buscar)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Item)
        Me.Pnl_Principal.Controls.Add(Me.Lbl_Item)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Superior)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Linha)
        Me.Pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Principal.Name = "Pnl_Principal"
        Me.Pnl_Principal.Size = New System.Drawing.Size(721, 349)
        Me.Pnl_Principal.TabIndex = 2
        '
        'frmConcluido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 349)
        Me.Controls.Add(Me.Pnl_Principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmConcluido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConcluido"
        Me.Pnl_Item.ResumeLayout(False)
        Me.Pnl_Item.PerformLayout()
        Me.Pnl_Superior.ResumeLayout(False)
        Me.Pnl_Superior.PerformLayout()
        Me.Pnl_LinhaSuperior.ResumeLayout(False)
        Me.Pnl_LinhaSuperior.PerformLayout()
        Me.Pnl_Principal.ResumeLayout(False)
        Me.Pnl_Principal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Btn_Buscar As Button
    Private WithEvents Btn_Minimizar As Label
    Friend WithEvents Txt_Item As TextBox
    Friend WithEvents Pnl_Item As Panel
    Friend WithEvents Lbl_Item As Label
    Friend WithEvents Pnl_Superior As Panel
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Pnl_LinhaSuperior As Panel
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Lbl_Minimizar As Label
    Private WithEvents Lbl_Fechar As Label
    Private WithEvents Btn_Sair As Label
    Friend WithEvents Pnl_Linha As Panel
    Friend WithEvents Pnl_Principal As Panel
End Class
