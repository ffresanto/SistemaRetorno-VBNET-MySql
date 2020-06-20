<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplash))
        Me.Pnl_Primario = New System.Windows.Forms.Panel()
        Me.Pnl_Progress = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Pnl_Primario
        '
        Me.Pnl_Primario.BackColor = System.Drawing.Color.Transparent
        Me.Pnl_Primario.Location = New System.Drawing.Point(363, 356)
        Me.Pnl_Primario.Name = "Pnl_Primario"
        Me.Pnl_Primario.Size = New System.Drawing.Size(222, 11)
        Me.Pnl_Primario.TabIndex = 0
        '
        'Pnl_Progress
        '
        Me.Pnl_Progress.BackColor = System.Drawing.Color.White
        Me.Pnl_Progress.Location = New System.Drawing.Point(363, 356)
        Me.Pnl_Progress.Name = "Pnl_Progress"
        Me.Pnl_Progress.Size = New System.Drawing.Size(22, 11)
        Me.Pnl_Progress.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 20
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(692, 508)
        Me.Controls.Add(Me.Pnl_Progress)
        Me.Controls.Add(Me.Pnl_Primario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSplash"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pnl_Primario As Panel
    Friend WithEvents Pnl_Progress As Panel
    Friend WithEvents Timer1 As Timer
End Class
