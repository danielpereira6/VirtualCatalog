<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InserirImagemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.clr_btn = New System.Windows.Forms.Button()
        Me.cmp_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DBList = New System.Windows.Forms.ListBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(849, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem1, Me.ListaDeComprasToolStripMenuItem, Me.InserirImagemToolStripMenuItem})
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ConsultaToolStripMenuItem.Text = "Open"
        '
        'ConsultaToolStripMenuItem1
        '
        Me.ConsultaToolStripMenuItem1.Name = "ConsultaToolStripMenuItem1"
        Me.ConsultaToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.ConsultaToolStripMenuItem1.Text = "Query"
        '
        'ListaDeComprasToolStripMenuItem
        '
        Me.ListaDeComprasToolStripMenuItem.Name = "ListaDeComprasToolStripMenuItem"
        Me.ListaDeComprasToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ListaDeComprasToolStripMenuItem.Text = "Shopping list"
        '
        'InserirImagemToolStripMenuItem
        '
        Me.InserirImagemToolStripMenuItem.Name = "InserirImagemToolStripMenuItem"
        Me.InserirImagemToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.InserirImagemToolStripMenuItem.Text = "Add Image"
        '
        'clr_btn
        '
        Me.clr_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.clr_btn.BackgroundImage = Global.VirtualCatalog.My.Resources.Resources.Broom_icon
        Me.clr_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.clr_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.clr_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.clr_btn.Location = New System.Drawing.Point(18, 442)
        Me.clr_btn.Name = "clr_btn"
        Me.clr_btn.Size = New System.Drawing.Size(45, 45)
        Me.clr_btn.TabIndex = 938
        Me.ToolTip1.SetToolTip(Me.clr_btn, "Limpar")
        Me.clr_btn.UseVisualStyleBackColor = True
        '
        'cmp_btn
        '
        Me.cmp_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmp_btn.BackgroundImage = Global.VirtualCatalog.My.Resources.Resources.cart
        Me.cmp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmp_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cmp_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmp_btn.Location = New System.Drawing.Point(91, 442)
        Me.cmp_btn.Name = "cmp_btn"
        Me.cmp_btn.Size = New System.Drawing.Size(45, 45)
        Me.cmp_btn.TabIndex = 935
        Me.ToolTip1.SetToolTip(Me.cmp_btn, "Adicionar ao carrinho")
        Me.cmp_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DBList)
        Me.Panel1.Controls.Add(Me.clr_btn)
        Me.Panel1.Controls.Add(Me.cmp_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 512)
        Me.Panel1.TabIndex = 2
        '
        'DBList
        '
        Me.DBList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DBList.FormattingEnabled = True
        Me.DBList.Location = New System.Drawing.Point(8, 15)
        Me.DBList.Name = "DBList"
        Me.DBList.Size = New System.Drawing.Size(155, 420)
        Me.DBList.TabIndex = 936
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(177, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(672, 512)
        Me.Panel2.TabIndex = 3
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(849, 536)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Virtual Catalog"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListaDeComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents InserirImagemToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DBList As System.Windows.Forms.ListBox
    Friend WithEvents clr_btn As System.Windows.Forms.Button
    Friend WithEvents cmp_btn As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel

End Class
