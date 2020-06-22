<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConcl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConcl))
        Me.Pnl_Linha = New System.Windows.Forms.Panel()
        Me.Pnl_Principal = New System.Windows.Forms.Panel()
        Me.Dgv_Geral = New System.Windows.Forms.DataGridView()
        Me.Btn_Concluir = New System.Windows.Forms.Button()
        Me.Pnl_Item = New System.Windows.Forms.Panel()
        Me.Txt_Item = New System.Windows.Forms.TextBox()
        Me.Lbl_Item = New System.Windows.Forms.Label()
        Me.Pnl_Superior = New System.Windows.Forms.Panel()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Pnl_LinhaSuperior = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbl_Minimizar = New System.Windows.Forms.Label()
        Me.Lbl_Fechar = New System.Windows.Forms.Label()
        Me.Btn_Minimizar = New System.Windows.Forms.Label()
        Me.Btn_Sair = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Total = New System.Windows.Forms.Label()
        Me.Pnl_Principal.SuspendLayout()
        CType(Me.Dgv_Geral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Item.SuspendLayout()
        Me.Pnl_Superior.SuspendLayout()
        Me.Pnl_LinhaSuperior.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Linha
        '
        Me.Pnl_Linha.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Pnl_Linha.Location = New System.Drawing.Point(0, 47)
        Me.Pnl_Linha.Name = "Pnl_Linha"
        Me.Pnl_Linha.Size = New System.Drawing.Size(765, 10)
        Me.Pnl_Linha.TabIndex = 3
        '
        'Pnl_Principal
        '
        Me.Pnl_Principal.BackColor = System.Drawing.Color.White
        Me.Pnl_Principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Principal.Controls.Add(Me.Label2)
        Me.Pnl_Principal.Controls.Add(Me.Txt_Total)
        Me.Pnl_Principal.Controls.Add(Me.Dgv_Geral)
        Me.Pnl_Principal.Controls.Add(Me.Btn_Concluir)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Item)
        Me.Pnl_Principal.Controls.Add(Me.Lbl_Item)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Superior)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Linha)
        Me.Pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Principal.Name = "Pnl_Principal"
        Me.Pnl_Principal.Size = New System.Drawing.Size(765, 664)
        Me.Pnl_Principal.TabIndex = 2
        '
        'Dgv_Geral
        '
        Me.Dgv_Geral.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv_Geral.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Geral.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_Geral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Geral.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Geral.ColumnHeadersHeight = 50
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft YaHei UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Geral.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Geral.GridColor = System.Drawing.Color.White
        Me.Dgv_Geral.Location = New System.Drawing.Point(4, 118)
        Me.Dgv_Geral.Name = "Dgv_Geral"
        Me.Dgv_Geral.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Geral.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Geral.RowHeadersVisible = False
        Me.Dgv_Geral.RowHeadersWidth = 60
        Me.Dgv_Geral.Size = New System.Drawing.Size(754, 533)
        Me.Dgv_Geral.TabIndex = 8
        '
        'Btn_Concluir
        '
        Me.Btn_Concluir.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Concluir.FlatAppearance.BorderSize = 0
        Me.Btn_Concluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Concluir.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Concluir.ForeColor = System.Drawing.Color.PaleGreen
        Me.Btn_Concluir.Location = New System.Drawing.Point(197, 74)
        Me.Btn_Concluir.Name = "Btn_Concluir"
        Me.Btn_Concluir.Size = New System.Drawing.Size(108, 38)
        Me.Btn_Concluir.TabIndex = 7
        Me.Btn_Concluir.Text = "CONCLUIR"
        Me.Btn_Concluir.UseVisualStyleBackColor = False
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
        Me.Pnl_Superior.Size = New System.Drawing.Size(764, 55)
        Me.Pnl_Superior.TabIndex = 2
        '
        'Lbl_Titulo
        '
        Me.Lbl_Titulo.AutoSize = True
        Me.Lbl_Titulo.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Lbl_Titulo.Location = New System.Drawing.Point(11, 20)
        Me.Lbl_Titulo.Name = "Lbl_Titulo"
        Me.Lbl_Titulo.Size = New System.Drawing.Size(132, 19)
        Me.Lbl_Titulo.TabIndex = 20
        Me.Lbl_Titulo.Text = "Concluir Retorno"
        '
        'Pnl_LinhaSuperior
        '
        Me.Pnl_LinhaSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Pnl_LinhaSuperior.Controls.Add(Me.Label9)
        Me.Pnl_LinhaSuperior.Controls.Add(Me.Label10)
        Me.Pnl_LinhaSuperior.Location = New System.Drawing.Point(-1, -4)
        Me.Pnl_LinhaSuperior.Name = "Pnl_LinhaSuperior"
        Me.Pnl_LinhaSuperior.Size = New System.Drawing.Size(765, 10)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(311, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 26)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "TOTAL DE RETORNOS RESTANTE:"
        '
        'Txt_Total
        '
        Me.Txt_Total.AutoSize = True
        Me.Txt_Total.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Total.ForeColor = System.Drawing.Color.LimeGreen
        Me.Txt_Total.Location = New System.Drawing.Point(640, 78)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.Size = New System.Drawing.Size(24, 26)
        Me.Txt_Total.TabIndex = 9
        Me.Txt_Total.Text = "0"
        '
        'frmConcl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 664)
        Me.Controls.Add(Me.Pnl_Principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConcl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DDSRetorno - Concluido"
        Me.Pnl_Principal.ResumeLayout(False)
        Me.Pnl_Principal.PerformLayout()
        CType(Me.Dgv_Geral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Item.ResumeLayout(False)
        Me.Pnl_Item.PerformLayout()
        Me.Pnl_Superior.ResumeLayout(False)
        Me.Pnl_Superior.PerformLayout()
        Me.Pnl_LinhaSuperior.ResumeLayout(False)
        Me.Pnl_LinhaSuperior.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Linha As Panel
    Friend WithEvents Pnl_Principal As Panel
    Friend WithEvents Btn_Concluir As Button
    Friend WithEvents Pnl_Item As Panel
    Friend WithEvents Txt_Item As TextBox
    Friend WithEvents Lbl_Item As Label
    Friend WithEvents Pnl_Superior As Panel
    Friend WithEvents Lbl_Titulo As Label
    Friend WithEvents Pnl_LinhaSuperior As Panel
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Private WithEvents Lbl_Minimizar As Label
    Private WithEvents Lbl_Fechar As Label
    Private WithEvents Btn_Minimizar As Label
    Private WithEvents Btn_Sair As Label
    Friend WithEvents Dgv_Geral As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Total As Label
End Class
