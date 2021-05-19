<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email
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
        Me.user = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.destin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.envia_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(81, 12)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(138, 20)
        Me.user.TabIndex = 0
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(81, 38)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(138, 20)
        Me.pass.TabIndex = 644
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 645
        Me.Label1.Text = "E-mail:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 646
        Me.Label2.Text = "Passe:"
        '
        'destin
        '
        Me.destin.Location = New System.Drawing.Point(81, 64)
        Me.destin.Name = "destin"
        Me.destin.Size = New System.Drawing.Size(138, 20)
        Me.destin.TabIndex = 647
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 648
        Me.Label3.Text = "Destinatário:"
        '
        'envia_btn
        '
        Me.envia_btn.Location = New System.Drawing.Point(105, 90)
        Me.envia_btn.Name = "envia_btn"
        Me.envia_btn.Size = New System.Drawing.Size(75, 23)
        Me.envia_btn.TabIndex = 649
        Me.envia_btn.Text = "Enviar"
        Me.envia_btn.UseVisualStyleBackColor = True
        '
        'Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 121)
        Me.Controls.Add(Me.envia_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.destin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Email"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents destin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents envia_btn As System.Windows.Forms.Button
End Class
