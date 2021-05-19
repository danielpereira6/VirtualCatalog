<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Query
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Query))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Col = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Consulta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_qt = New System.Windows.Forms.TextBox()
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.TB_ref = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.limp_btn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(450, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Decoration"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CB_Col
        '
        Me.CB_Col.FormattingEnabled = True
        Me.CB_Col.Location = New System.Drawing.Point(515, 12)
        Me.CB_Col.Name = "CB_Col"
        Me.CB_Col.Size = New System.Drawing.Size(121, 21)
        Me.CB_Col.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Product"
        '
        'TB_Consulta
        '
        Me.TB_Consulta.Location = New System.Drawing.Point(216, 12)
        Me.TB_Consulta.Name = "TB_Consulta"
        Me.TB_Consulta.Size = New System.Drawing.Size(217, 20)
        Me.TB_Consulta.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Quantity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TB_qt
        '
        Me.TB_qt.Location = New System.Drawing.Point(78, 63)
        Me.TB_qt.Name = "TB_qt"
        Me.TB_qt.Size = New System.Drawing.Size(62, 20)
        Me.TB_qt.TabIndex = 12
        '
        'Add_btn
        '
        Me.Add_btn.Location = New System.Drawing.Point(146, 59)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(82, 26)
        Me.Add_btn.TabIndex = 20
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'TB_ref
        '
        Me.TB_ref.Location = New System.Drawing.Point(62, 12)
        Me.TB_ref.Name = "TB_ref"
        Me.TB_ref.Size = New System.Drawing.Size(82, 20)
        Me.TB_ref.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Code"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'limp_btn
        '
        Me.limp_btn.Location = New System.Drawing.Point(232, 59)
        Me.limp_btn.Name = "limp_btn"
        Me.limp_btn.Size = New System.Drawing.Size(75, 26)
        Me.limp_btn.TabIndex = 23
        Me.limp_btn.Text = "Clear"
        Me.limp_btn.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 91)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(624, 248)
        Me.DataGridView1.TabIndex = 26
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(336, 65)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox1.TabIndex = 27
        Me.CheckBox1.Text = "Simulation"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Query
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 351)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.limp_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_ref)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_Col)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_Consulta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_qt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Query"
        Me.Text = "Query"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CB_Col As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_Consulta As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_qt As System.Windows.Forms.TextBox
    Friend WithEvents Add_btn As System.Windows.Forms.Button
    Friend WithEvents TB_ref As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents limp_btn As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
