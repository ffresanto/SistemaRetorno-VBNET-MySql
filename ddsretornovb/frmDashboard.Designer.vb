<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.Pnl_Principal = New System.Windows.Forms.Panel()
        Me.Pnl_Superior = New System.Windows.Forms.Panel()
        Me.Btn_Minimizar = New System.Windows.Forms.Label()
        Me.Btn_Sair = New System.Windows.Forms.Label()
        Me.Pnl_Esquerda = New System.Windows.Forms.Panel()
        Me.btn_Principal = New System.Windows.Forms.Button()
        Me.Pnl_Ddsretorno = New System.Windows.Forms.Panel()
        Me.Lbl_Copyright = New System.Windows.Forms.Label()
        Me.Btn_Logout = New System.Windows.Forms.Button()
        Me.Btn_Adicionar = New System.Windows.Forms.Button()
        Me.Btn_Alterar = New System.Windows.Forms.Button()
        Me.Btn_Remove = New System.Windows.Forms.Button()
        Me.Btn_Concluido = New System.Windows.Forms.Button()
        Me.Pnl_Principal.SuspendLayout()
        Me.Pnl_Superior.SuspendLayout()
        Me.Pnl_Esquerda.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pnl_Principal
        '
        Me.Pnl_Principal.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Superior)
        Me.Pnl_Principal.Controls.Add(Me.Pnl_Esquerda)
        Me.Pnl_Principal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pnl_Principal.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Principal.Name = "Pnl_Principal"
        Me.Pnl_Principal.Size = New System.Drawing.Size(1080, 737)
        Me.Pnl_Principal.TabIndex = 0
        '
        'Pnl_Superior
        '
        Me.Pnl_Superior.BackColor = System.Drawing.Color.White
        Me.Pnl_Superior.Controls.Add(Me.Btn_Minimizar)
        Me.Pnl_Superior.Controls.Add(Me.Btn_Sair)
        Me.Pnl_Superior.Location = New System.Drawing.Point(237, 0)
        Me.Pnl_Superior.Name = "Pnl_Superior"
        Me.Pnl_Superior.Size = New System.Drawing.Size(843, 52)
        Me.Pnl_Superior.TabIndex = 1
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
        'Pnl_Esquerda
        '
        Me.Pnl_Esquerda.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Pnl_Esquerda.Controls.Add(Me.Btn_Concluido)
        Me.Pnl_Esquerda.Controls.Add(Me.Btn_Remove)
        Me.Pnl_Esquerda.Controls.Add(Me.Btn_Alterar)
        Me.Pnl_Esquerda.Controls.Add(Me.Btn_Adicionar)
        Me.Pnl_Esquerda.Controls.Add(Me.Btn_Logout)
        Me.Pnl_Esquerda.Controls.Add(Me.Lbl_Copyright)
        Me.Pnl_Esquerda.Controls.Add(Me.btn_Principal)
        Me.Pnl_Esquerda.Controls.Add(Me.Pnl_Ddsretorno)
        Me.Pnl_Esquerda.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Esquerda.Name = "Pnl_Esquerda"
        Me.Pnl_Esquerda.Size = New System.Drawing.Size(237, 737)
        Me.Pnl_Esquerda.TabIndex = 0
        '
        'btn_Principal
        '
        Me.btn_Principal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Principal.FlatAppearance.BorderSize = 0
        Me.btn_Principal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btn_Principal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Principal.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Principal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.btn_Principal.Image = CType(resources.GetObject("btn_Principal.Image"), System.Drawing.Image)
        Me.btn_Principal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Principal.Location = New System.Drawing.Point(0, 119)
        Me.btn_Principal.Name = "btn_Principal"
        Me.btn_Principal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_Principal.Size = New System.Drawing.Size(237, 93)
        Me.btn_Principal.TabIndex = 3
        Me.btn_Principal.Text = "PRINCIPAL"
        Me.btn_Principal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Principal.UseVisualStyleBackColor = True
        '
        'Pnl_Ddsretorno
        '
        Me.Pnl_Ddsretorno.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Pnl_Ddsretorno.BackgroundImage = CType(resources.GetObject("Pnl_Ddsretorno.BackgroundImage"), System.Drawing.Image)
        Me.Pnl_Ddsretorno.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Ddsretorno.Name = "Pnl_Ddsretorno"
        Me.Pnl_Ddsretorno.Size = New System.Drawing.Size(237, 119)
        Me.Pnl_Ddsretorno.TabIndex = 2
        '
        'Lbl_Copyright
        '
        Me.Lbl_Copyright.AutoSize = True
        Me.Lbl_Copyright.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Copyright.ForeColor = System.Drawing.Color.White
        Me.Lbl_Copyright.Location = New System.Drawing.Point(21, 714)
        Me.Lbl_Copyright.Name = "Lbl_Copyright"
        Me.Lbl_Copyright.Size = New System.Drawing.Size(195, 16)
        Me.Lbl_Copyright.TabIndex = 4
        Me.Lbl_Copyright.Text = "Copyright © 2020 | DDS Informática"
        '
        'Btn_Logout
        '
        Me.Btn_Logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Logout.FlatAppearance.BorderSize = 0
        Me.Btn_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Logout.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Logout.Image = CType(resources.GetObject("Btn_Logout.Image"), System.Drawing.Image)
        Me.Btn_Logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Logout.Location = New System.Drawing.Point(0, 618)
        Me.Btn_Logout.Name = "Btn_Logout"
        Me.Btn_Logout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Logout.Size = New System.Drawing.Size(237, 76)
        Me.Btn_Logout.TabIndex = 5
        Me.Btn_Logout.Text = "LOGOUT"
        Me.Btn_Logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Logout.UseVisualStyleBackColor = True
        '
        'Btn_Adicionar
        '
        Me.Btn_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Adicionar.FlatAppearance.BorderSize = 0
        Me.Btn_Adicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Adicionar.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Adicionar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Btn_Adicionar.Image = CType(resources.GetObject("Btn_Adicionar.Image"), System.Drawing.Image)
        Me.Btn_Adicionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Adicionar.Location = New System.Drawing.Point(0, 218)
        Me.Btn_Adicionar.Name = "Btn_Adicionar"
        Me.Btn_Adicionar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Adicionar.Size = New System.Drawing.Size(237, 93)
        Me.Btn_Adicionar.TabIndex = 6
        Me.Btn_Adicionar.Text = "ADICIONAR"
        Me.Btn_Adicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Adicionar.UseVisualStyleBackColor = True
        '
        'Btn_Alterar
        '
        Me.Btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Alterar.FlatAppearance.BorderSize = 0
        Me.Btn_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Alterar.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Alterar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Btn_Alterar.Image = CType(resources.GetObject("Btn_Alterar.Image"), System.Drawing.Image)
        Me.Btn_Alterar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Alterar.Location = New System.Drawing.Point(0, 317)
        Me.Btn_Alterar.Name = "Btn_Alterar"
        Me.Btn_Alterar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Alterar.Size = New System.Drawing.Size(237, 93)
        Me.Btn_Alterar.TabIndex = 7
        Me.Btn_Alterar.Text = "ALTERAR"
        Me.Btn_Alterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Alterar.UseVisualStyleBackColor = True
        '
        'Btn_Remove
        '
        Me.Btn_Remove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Remove.FlatAppearance.BorderSize = 0
        Me.Btn_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Remove.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Remove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.Btn_Remove.Image = CType(resources.GetObject("Btn_Remove.Image"), System.Drawing.Image)
        Me.Btn_Remove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Remove.Location = New System.Drawing.Point(3, 416)
        Me.Btn_Remove.Name = "Btn_Remove"
        Me.Btn_Remove.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Remove.Size = New System.Drawing.Size(237, 93)
        Me.Btn_Remove.TabIndex = 8
        Me.Btn_Remove.Text = "REMOVER"
        Me.Btn_Remove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Remove.UseVisualStyleBackColor = True
        '
        'Btn_Concluido
        '
        Me.Btn_Concluido.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Concluido.FlatAppearance.BorderSize = 0
        Me.Btn_Concluido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Btn_Concluido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Concluido.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Concluido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(14, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(14, Byte), Integer))
        Me.Btn_Concluido.Image = CType(resources.GetObject("Btn_Concluido.Image"), System.Drawing.Image)
        Me.Btn_Concluido.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Concluido.Location = New System.Drawing.Point(3, 515)
        Me.Btn_Concluido.Name = "Btn_Concluido"
        Me.Btn_Concluido.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Concluido.Size = New System.Drawing.Size(237, 93)
        Me.Btn_Concluido.TabIndex = 10
        Me.Btn_Concluido.Text = "CONCLUIDO"
        Me.Btn_Concluido.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Concluido.UseVisualStyleBackColor = True
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 737)
        Me.Controls.Add(Me.Pnl_Principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DDSRetorno - Principal"
        Me.Pnl_Principal.ResumeLayout(False)
        Me.Pnl_Superior.ResumeLayout(False)
        Me.Pnl_Superior.PerformLayout()
        Me.Pnl_Esquerda.ResumeLayout(False)
        Me.Pnl_Esquerda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Principal As Panel
    Friend WithEvents Pnl_Esquerda As Panel
    Friend WithEvents Pnl_Superior As Panel
    Friend WithEvents Pnl_Ddsretorno As Panel
    Friend WithEvents btn_Principal As Button
    Private WithEvents Btn_Minimizar As Label
    Private WithEvents Btn_Sair As Label
    Friend WithEvents Lbl_Copyright As Label
    Friend WithEvents Btn_Logout As Button
    Friend WithEvents Btn_Adicionar As Button
    Friend WithEvents Btn_Alterar As Button
    Friend WithEvents Btn_Remove As Button
    Friend WithEvents Btn_Concluido As Button
End Class
