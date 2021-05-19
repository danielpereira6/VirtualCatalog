<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cart))
        Me.ListBox7 = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharJanelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FecharAplicaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eliminar_btn = New System.Windows.Forms.Button()
        Me.ListBox8 = New System.Windows.Forms.ListBox()
        Me.ListBox9 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.At_qt_btn = New System.Windows.Forms.Button()
        Me.TB_desc = New System.Windows.Forms.MaskedTextBox()
        Me.n_items = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.n_artigos = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox7
        '
        Me.ListBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox7.FormatString = "C2"
        Me.ListBox7.FormattingEnabled = True
        Me.ListBox7.ItemHeight = 16
        Me.ListBox7.Location = New System.Drawing.Point(505, 417)
        Me.ListBox7.Name = "ListBox7"
        Me.ListBox7.Size = New System.Drawing.Size(70, 20)
        Me.ListBox7.TabIndex = 134
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.EmailToolStripMenuItem, Me.FecharToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(579, 24)
        Me.MenuStrip1.TabIndex = 145
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ConsultaToolStripMenuItem.Text = "Query"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.GuardarToolStripMenuItem.Text = "Save"
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        Me.EmailToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.EmailToolStripMenuItem.Text = "Email"
        '
        'FecharToolStripMenuItem
        '
        Me.FecharToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FecharJanelaToolStripMenuItem, Me.FecharAplicaçãoToolStripMenuItem})
        Me.FecharToolStripMenuItem.Name = "FecharToolStripMenuItem"
        Me.FecharToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.FecharToolStripMenuItem.Text = "Close"
        '
        'FecharJanelaToolStripMenuItem
        '
        Me.FecharJanelaToolStripMenuItem.Name = "FecharJanelaToolStripMenuItem"
        Me.FecharJanelaToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FecharJanelaToolStripMenuItem.Text = "Close window"
        '
        'FecharAplicaçãoToolStripMenuItem
        '
        Me.FecharAplicaçãoToolStripMenuItem.Name = "FecharAplicaçãoToolStripMenuItem"
        Me.FecharAplicaçãoToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.FecharAplicaçãoToolStripMenuItem.Text = "Close app"
        '
        'eliminar_btn
        '
        Me.eliminar_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.eliminar_btn.Location = New System.Drawing.Point(24, 424)
        Me.eliminar_btn.Name = "eliminar_btn"
        Me.eliminar_btn.Size = New System.Drawing.Size(75, 23)
        Me.eliminar_btn.TabIndex = 146
        Me.eliminar_btn.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.eliminar_btn, "Apaga a linha selecionada")
        Me.eliminar_btn.UseVisualStyleBackColor = True
        '
        'ListBox8
        '
        Me.ListBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox8.FormatString = "C2"
        Me.ListBox8.FormattingEnabled = True
        Me.ListBox8.ItemHeight = 16
        Me.ListBox8.Location = New System.Drawing.Point(505, 461)
        Me.ListBox8.Name = "ListBox8"
        Me.ListBox8.Size = New System.Drawing.Size(70, 20)
        Me.ListBox8.TabIndex = 152
        '
        'ListBox9
        '
        Me.ListBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox9.FormatString = "C2"
        Me.ListBox9.FormattingEnabled = True
        Me.ListBox9.ItemHeight = 16
        Me.ListBox9.Location = New System.Drawing.Point(505, 483)
        Me.ListBox9.Name = "ListBox9"
        Me.ListBox9.Size = New System.Drawing.Size(70, 20)
        Me.ListBox9.TabIndex = 154
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(105, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 156
        Me.Button1.Text = "Simulate"
        Me.ToolTip1.SetToolTip(Me.Button1, "Mostra os mesmos produtos em diferentes coleções")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'At_qt_btn
        '
        Me.At_qt_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.At_qt_btn.BackgroundImage = Global.VirtualCatalog.My.Resources.Resources.refresh
        Me.At_qt_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.At_qt_btn.Location = New System.Drawing.Point(357, 424)
        Me.At_qt_btn.Name = "At_qt_btn"
        Me.At_qt_btn.Size = New System.Drawing.Size(30, 30)
        Me.At_qt_btn.TabIndex = 144
        Me.ToolTip1.SetToolTip(Me.At_qt_btn, "Atualiza a quantidade da linha selecionada")
        Me.At_qt_btn.UseVisualStyleBackColor = True
        '
        'TB_desc
        '
        Me.TB_desc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TB_desc.Location = New System.Drawing.Point(505, 440)
        Me.TB_desc.Mask = "##.##%"
        Me.TB_desc.Name = "TB_desc"
        Me.TB_desc.Size = New System.Drawing.Size(70, 20)
        Me.TB_desc.TabIndex = 158
        '
        'n_items
        '
        Me.n_items.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.n_items.AutoSize = True
        Me.n_items.Location = New System.Drawing.Point(245, 424)
        Me.n_items.Name = "n_items"
        Me.n_items.Size = New System.Drawing.Size(35, 13)
        Me.n_items.TabIndex = 159
        Me.n_items.Text = "Lines:"
        Me.n_items.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(450, 443)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 641
        Me.Label10.Text = "Discount"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(412, 465)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 640
        Me.Label9.Text = "Discount amount"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(468, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 639
        Me.Label8.Text = "Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(403, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 638
        Me.Label1.Text = "Total with discount"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(5, 28)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(570, 390)
        Me.ListView1.TabIndex = 642
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Code"
        Me.ColumnHeader1.Width = 64
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Decoration"
        Me.ColumnHeader2.Width = 118
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Product"
        Me.ColumnHeader3.Width = 192
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Quantity"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 72
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total"
        Me.ColumnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'n_artigos
        '
        Me.n_artigos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.n_artigos.AutoSize = True
        Me.n_artigos.Location = New System.Drawing.Point(228, 440)
        Me.n_artigos.Name = "n_artigos"
        Me.n_artigos.Size = New System.Drawing.Size(52, 13)
        Me.n_artigos.TabIndex = 160
        Me.n_artigos.Text = "Products:"
        Me.n_artigos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 506)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.n_artigos)
        Me.Controls.Add(Me.n_items)
        Me.Controls.Add(Me.TB_desc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox9)
        Me.Controls.Add(Me.ListBox8)
        Me.Controls.Add(Me.eliminar_btn)
        Me.Controls.Add(Me.At_qt_btn)
        Me.Controls.Add(Me.ListBox7)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Cart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cart"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox7 As System.Windows.Forms.ListBox
    Friend WithEvents At_qt_btn As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents eliminar_btn As System.Windows.Forms.Button
    Friend WithEvents FecharToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecharJanelaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FecharAplicaçãoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListBox8 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox9 As System.Windows.Forms.ListBox
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TB_desc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents n_items As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents EmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents n_artigos As Label
End Class
