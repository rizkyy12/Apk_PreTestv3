<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Admin
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
        Me.tb_nama = New System.Windows.Forms.Label()
        Me.bt_back = New System.Windows.Forms.Button()
        Me.bt_login = New System.Windows.Forms.Button()
        Me.tb_pwd = New System.Windows.Forms.TextBox()
        Me.tb_nim = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_nama
        '
        Me.tb_nama.AutoSize = True
        Me.tb_nama.Font = New System.Drawing.Font("Mazzard M", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_nama.Location = New System.Drawing.Point(122, 215)
        Me.tb_nama.Name = "tb_nama"
        Me.tb_nama.Size = New System.Drawing.Size(57, 19)
        Me.tb_nama.TabIndex = 22
        Me.tb_nama.Text = "NAMA"
        Me.tb_nama.Visible = False
        '
        'bt_back
        '
        Me.bt_back.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_back.Location = New System.Drawing.Point(20, 215)
        Me.bt_back.Name = "bt_back"
        Me.bt_back.Size = New System.Drawing.Size(75, 27)
        Me.bt_back.TabIndex = 21
        Me.bt_back.Text = "Back"
        Me.bt_back.UseVisualStyleBackColor = True
        '
        'bt_login
        '
        Me.bt_login.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_login.Location = New System.Drawing.Point(229, 167)
        Me.bt_login.Name = "bt_login"
        Me.bt_login.Size = New System.Drawing.Size(75, 27)
        Me.bt_login.TabIndex = 20
        Me.bt_login.Text = "Login"
        Me.bt_login.UseVisualStyleBackColor = True
        '
        'tb_pwd
        '
        Me.tb_pwd.Location = New System.Drawing.Point(145, 132)
        Me.tb_pwd.Name = "tb_pwd"
        Me.tb_pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_pwd.Size = New System.Drawing.Size(159, 20)
        Me.tb_pwd.TabIndex = 19
        '
        'tb_nim
        '
        Me.tb_nim.Location = New System.Drawing.Point(145, 85)
        Me.tb_nim.Name = "tb_nim"
        Me.tb_nim.Size = New System.Drawing.Size(159, 20)
        Me.tb_nim.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Mazzard M", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Mazzard M", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "NIM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gotham", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 34)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "LOGIN ADMIN"
        '
        'Login_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 261)
        Me.Controls.Add(Me.tb_nama)
        Me.Controls.Add(Me.bt_back)
        Me.Controls.Add(Me.bt_login)
        Me.Controls.Add(Me.tb_pwd)
        Me.Controls.Add(Me.tb_nim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login_Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_nama As System.Windows.Forms.Label
    Friend WithEvents bt_back As System.Windows.Forms.Button
    Friend WithEvents bt_login As System.Windows.Forms.Button
    Friend WithEvents tb_pwd As System.Windows.Forms.TextBox
    Friend WithEvents tb_nim As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
