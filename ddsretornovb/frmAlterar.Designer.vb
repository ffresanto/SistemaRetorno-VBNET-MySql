<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlterar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlterar))
        Me.Lbl_Nome = New System.Windows.Forms.Label()
        Me.Pnl_Nome = New System.Windows.Forms.Panel()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.Lbl_Item = New System.Windows.Forms.Label()
        Me.Pnl_LinhaSuperior = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Lbl_Empresa = New System.Windows.Forms.Label()
        Me.Lbl_Telefone = New System.Windows.Forms.Label()
        Me.Pnl_Telefone = New System.Windows.Forms.Panel()
        Me.Txt_Telefone = New System.Windows.Forms.TextBox()
        Me.Lbl_Titulo = New System.Windows.Forms.Label()
        Me.Lbl_Minimizar = New System.Windows.Forms.Label()
        Me.Lbl_Obs = New System.Windows.Forms.Label()
        Me.Lbl_Fechar = New System.Windows.Forms.Label()
        Me.Btn_Adicionar = New System.Windows.Forms.Button()
        Me.Lbl_Data = New System.Windows.Forms.Label()
        Me.Dtp_Data = New System.Windows.Forms.DateTimePicker()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Txt_Obs = New System.Windows.Forms.TextBox()
        Me.Btn_Minimizar = New System.Windows.Forms.Label()
        Me.Pnl_Item = New System.Windows.Forms.Panel()
        Me.Txt_Item = New System.Windows.Forms.TextBox()
        Me.Pnl_Empresa = New System.Windows.Forms.Panel()
        Me.Txt_Empresa = New System.Windows.Forms.TextBox()
        Me.Pnl_Superior = New System.Windows.Forms.Panel()
        Me.Btn_Sair = New System.Windows.Forms.Label()
        Me.Pnl_Principal = New System.Windows.Forms.Panel()
        Me.Btn_Buscar = New System.Windows.Forms.Button()
        Me.Pnl_Linha = New System.Windows.Forms.Panel()
        Me.Pnl_Nome.SuspendLayout()
        Me.Pnl_LinhaSuperior.SuspendLayout()
        Me.Pnl_Telefone.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Pnl_Item.SuspendLayout()
        Me.Pnl_Empresa.SuspendLayout()
        Me.Pnl_Superior.SuspendLayout()
        Me.Pnl_Principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Nome
        '
        Me.Lbl_Nome.AutoSize = True
        Me.Lbl_Nome.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Nome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Lbl_Nome.Location = New System.Drawing.Point(69, 128)
        Me.Lbl_Nome.Name = "Lbl_Nome"
        Me.Lbl_Nome.Size = New System.Drawing.Size(52, 19)
        Me.Lbl_Nome.TabIndex = 8
        Me.Lbl_Nome.Text = "Nome"
        '
        'Pnl_Nome
        '
        Me.Pnl_Nome.BackColor = System.Drawing.Color.White
        Me.Pnl_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Nome.Controls.Add(Me.Txt_Nome)
        Me.Pnl_Nome.Location = New System.Drawing.Point(127, 118)
        Me.Pnl_Nome.Name = "Pnl_Nome"
        Me.Pnl_Nome.Size = New System.Drawing.Size(160, 38)
        Me.Pnl_Nome.TabIndex = 2
        '
        'Txt_Nome
        '
        Me.Txt_Nome.BackColor = System.Drawing.Color.White
        Me.Txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Nome.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Nome.Location = New System.Drawing.Point(6, 10)
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(147, 18)
        Me.Txt_Nome.TabIndex = 2
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
        'Lbl_Empresa
        '
        Me.Lbl_Empresa.AutoSize = True
        Me.Lbl_Empresa.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Empresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Lbl_Empresa.Location = New System.Drawing.Point(48, 172)
        Me.Lbl_Empresa.Name = "Lbl_Empresa"
        Me.Lbl_Empresa.Size = New System.Drawing.Size(73, 19)
        Me.Lbl_Empresa.TabIndex = 11
        Me.Lbl_Empresa.Text = "Empresa"
        '
        'Lbl_Telefone
        '
        Me.Lbl_Telefone.AutoSize = True
        Me.Lbl_Telefone.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telefone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Lbl_Telefone.Location = New System.Drawing.Point(48, 216)
        Me.Lbl_Telefone.Name = "Lbl_Telefone"
        Me.Lbl_Telefone.Size = New System.Drawing.Size(70, 19)
        Me.Lbl_Telefone.TabIndex = 14
        Me.Lbl_Telefone.Text = "Telefone"
        '
        'Pnl_Telefone
        '
        Me.Pnl_Telefone.BackColor = System.Drawing.Color.White
        Me.Pnl_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Telefone.Controls.Add(Me.Txt_Telefone)
        Me.Pnl_Telefone.Location = New System.Drawing.Point(127, 206)
        Me.Pnl_Telefone.Name = "Pnl_Telefone"
        Me.Pnl_Telefone.Size = New System.Drawing.Size(160, 38)
        Me.Pnl_Telefone.TabIndex = 4
        '
        'Txt_Telefone
        '
        Me.Txt_Telefone.BackColor = System.Drawing.Color.White
        Me.Txt_Telefone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Telefone.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Telefone.Location = New System.Drawing.Point(5, 8)
        Me.Txt_Telefone.MaxLength = 11
        Me.Txt_Telefone.Name = "Txt_Telefone"
        Me.Txt_Telefone.Size = New System.Drawing.Size(147, 20)
        Me.Txt_Telefone.TabIndex = 4
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
        'Lbl_Obs
        '
        Me.Lbl_Obs.AutoSize = True
        Me.Lbl_Obs.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Obs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Lbl_Obs.Location = New System.Drawing.Point(294, 93)
        Me.Lbl_Obs.Name = "Lbl_Obs"
        Me.Lbl_Obs.Size = New System.Drawing.Size(95, 19)
        Me.Lbl_Obs.TabIndex = 15
        Me.Lbl_Obs.Text = "Observação"
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
        'Btn_Adicionar
        '
        Me.Btn_Adicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Btn_Adicionar.FlatAppearance.BorderSize = 0
        Me.Btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Adicionar.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Btn_Adicionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Btn_Adicionar.Location = New System.Drawing.Point(6, 295)
        Me.Btn_Adicionar.Name = "Btn_Adicionar"
        Me.Btn_Adicionar.Size = New System.Drawing.Size(281, 46)
        Me.Btn_Adicionar.TabIndex = 7
        Me.Btn_Adicionar.Text = "ALTERAR"
        Me.Btn_Adicionar.UseVisualStyleBackColor = False
        '
        'Lbl_Data
        '
        Me.Lbl_Data.AutoSize = True
        Me.Lbl_Data.Font = New System.Drawing.Font("Helvetica", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Data.ForeColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Lbl_Data.Location = New System.Drawing.Point(2, 260)
        Me.Lbl_Data.Name = "Lbl_Data"
        Me.Lbl_Data.Size = New System.Drawing.Size(119, 19)
        Me.Lbl_Data.TabIndex = 18
        Me.Lbl_Data.Text = "Data de retorno"
        '
        'Dtp_Data
        '
        Me.Dtp_Data.CalendarFont = New System.Drawing.Font("Helvetica", 11.25!)
        Me.Dtp_Data.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Dtp_Data.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Dtp_Data.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Dtp_Data.Checked = False
        Me.Dtp_Data.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_Data.Font = New System.Drawing.Font("Segoe UI", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_Data.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_Data.Location = New System.Drawing.Point(127, 250)
        Me.Dtp_Data.Name = "Dtp_Data"
        Me.Dtp_Data.Size = New System.Drawing.Size(160, 38)
        Me.Dtp_Data.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Txt_Obs)
        Me.Panel5.Location = New System.Drawing.Point(294, 118)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(416, 223)
        Me.Panel5.TabIndex = 6
        '
        'Txt_Obs
        '
        Me.Txt_Obs.BackColor = System.Drawing.Color.White
        Me.Txt_Obs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Obs.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Obs.Location = New System.Drawing.Point(3, 4)
        Me.Txt_Obs.Multiline = True
        Me.Txt_Obs.Name = "Txt_Obs"
        Me.Txt_Obs.Size = New System.Drawing.Size(405, 211)
        Me.Txt_Obs.TabIndex = 6
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
        'Pnl_Empresa
        '
        Me.Pnl_Empresa.BackColor = System.Drawing.Color.White
        Me.Pnl_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Empresa.Controls.Add(Me.Txt_Empresa)
        Me.Pnl_Empresa.Location = New System.Drawing.Point(127, 162)
        Me.Pnl_Empresa.Name = "Pnl_Empresa"
        Me.Pnl_Empresa.Size = New System.Drawing.Size(160, 38)
        Me.Pnl_Empresa.TabIndex = 3
        '
        'Txt_Empresa
        '
        Me.Txt_Empresa.BackColor = System.Drawing.Color.White
        Me.Txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Empresa.Font = New System.Drawing.Font("Helvetica", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Empresa.Location = New System.Drawing.Point(6, 9)
        Me.Txt_Empresa.Name = "Txt_Empresa"
        Me.Txt_Empresa.Size = New System.Drawing.Size(147, 18)
        Me.Txt_Empresa.TabIndex = 3
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
        'Pnl_Principal
        '
        Me.Pnl_Principal.BackColor = System.Drawing.Color.White
        Me.Pnl_Principal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl_Principal.Controls.Add(Me.Btn_Buscar)
        Me.Pnl_Principal.Controls.Add(Me.Btn_Adicionar)
        Me.Pnl_Principal.Controls.Add(Me.Lbl_Data)
        Me.Pnl_Principal.Controls.Add(Me.Dtp_Data)
        Me.Pnl_Principal.Controls.Add(Me.Panel5)
        Me.Pnl_Principal.Controls.Add(Me.Lbl_Obs)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Item)
        Me.Pnl_Principal.Controls.Add(Me.Lbl_Telefone)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Telefone)
        Me.Pnl_Principal.Controls.Add(Me.Lbl_Empresa)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Empresa)
        Me.Pnl_Principal.Controls.Add(Me.Lbl_Nome)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Nome)
        Me.Pnl_Principal.Controls.Add(Me.Lbl_Item)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Superior)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Linha)
        Me.Pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Principal.Name = "Pnl_Principal"
        Me.Pnl_Principal.Size = New System.Drawing.Size(721, 349)
        Me.Pnl_Principal.TabIndex = 1
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
        'Pnl_Linha
        '
        Me.Pnl_Linha.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Pnl_Linha.Location = New System.Drawing.Point(0, 47)
        Me.Pnl_Linha.Name = "Pnl_Linha"
        Me.Pnl_Linha.Size = New System.Drawing.Size(721, 10)
        Me.Pnl_Linha.TabIndex = 3
        '
        'frmAlterar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 349)
        Me.Controls.Add(Me.Pnl_Principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlterar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DDSRetorno - Alterar"
        Me.Pnl_Nome.ResumeLayout(False)
        Me.Pnl_Nome.PerformLayout()
        Me.Pnl_LinhaSuperior.ResumeLayout(False)
        Me.Pnl_LinhaSuperior.PerformLayout()
        Me.Pnl_Telefone.ResumeLayout(False)
        Me.Pnl_Telefone.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Pnl_Item.ResumeLayout(False)
        Me.Pnl_Item.PerformLayout()
        Me.Pnl_Empresa.ResumeLayout(False)
        Me.Pnl_Empresa.PerformLayout()
        Me.Pnl_Superior.ResumeLayout(False)
        Me.Pnl_Superior.PerformLayout()
        Me.Pnl_Principal.ResumeLayout(False)
        Me.Pnl_Principal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_Nome As Label
    Friend WithEvents Pnl_Nome As Panel
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents Lbl_Item As Label
    Friend WithEvents Pnl_LinhaSuperior As Panel
    Private WithEvents Label9 As Label
    Private WithEvents Label10 As Label
    Friend WithEvents Lbl_Empresa As Label
    Friend WithEvents Lbl_Telefone As Label
    Friend WithEvents Pnl_Telefone As Panel
    Friend WithEvents Txt_Telefone As TextBox
    Friend WithEvents Lbl_Titulo As Label
    Private WithEvents Lbl_Minimizar As Label
    Friend WithEvents Lbl_Obs As Label
    Private WithEvents Lbl_Fechar As Label
    Friend WithEvents Btn_Adicionar As Button
    Friend WithEvents Lbl_Data As Label
    Friend WithEvents Dtp_Data As DateTimePicker
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Txt_Obs As TextBox
    Private WithEvents Btn_Minimizar As Label
    Friend WithEvents Pnl_Item As Panel
    Friend WithEvents Txt_Item As TextBox
    Friend WithEvents Pnl_Empresa As Panel
    Friend WithEvents Txt_Empresa As TextBox
    Friend WithEvents Pnl_Superior As Panel
    Private WithEvents Btn_Sair As Label
    Friend WithEvents Pnl_Principal As Panel
    Friend WithEvents Btn_Buscar As Button
    Friend WithEvents Pnl_Linha As Panel
End Class
