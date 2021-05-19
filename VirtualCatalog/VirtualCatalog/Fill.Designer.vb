<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fill
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
        Me.Add_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_qt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_Col = New System.Windows.Forms.ComboBox()
        Me.limp_btn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Add_btn
        '
        Me.Add_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_btn.Location = New System.Drawing.Point(16, 46)
        Me.Add_btn.Name = "Add_btn"
        Me.Add_btn.Size = New System.Drawing.Size(64, 20)
        Me.Add_btn.TabIndex = 26
        Me.Add_btn.Text = "Add"
        Me.Add_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Quantity"
        '
        'TB_qt
        '
        Me.TB_qt.Location = New System.Drawing.Point(81, 16)
        Me.TB_qt.Name = "TB_qt"
        Me.TB_qt.Size = New System.Drawing.Size(62, 20)
        Me.TB_qt.TabIndex = 24
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 72)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(365, 156)
        Me.DataGridView1.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(191, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Decoration"
        '
        'CB_Col
        '
        Me.CB_Col.FormattingEnabled = True
        Me.CB_Col.Location = New System.Drawing.Point(256, 16)
        Me.CB_Col.Name = "CB_Col"
        Me.CB_Col.Size = New System.Drawing.Size(121, 21)
        Me.CB_Col.TabIndex = 29
        '
        'limp_btn
        '
        Me.limp_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limp_btn.Location = New System.Drawing.Point(86, 46)
        Me.limp_btn.Name = "limp_btn"
        Me.limp_btn.Size = New System.Drawing.Size(75, 20)
        Me.limp_btn.TabIndex = 33
        Me.limp_btn.Text = "Clear"
        Me.limp_btn.UseVisualStyleBackColor = True
        '
        'Fill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 240)
        Me.Controls.Add(Me.limp_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_Col)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Add_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_qt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Fill"
        Me.Text = "Fill"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Add_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_qt As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CB_Col As System.Windows.Forms.ComboBox
    Friend WithEvents limp_btn As System.Windows.Forms.Button
End Class
