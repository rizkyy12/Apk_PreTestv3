<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Verif_Profile
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_id_profile = New System.Windows.Forms.Label()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.lbl_no = New System.Windows.Forms.Label()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.btn_quiz = New System.Windows.Forms.Button()
        Me.lbl_telp = New System.Windows.Forms.Label()
        Me.lbl_nama = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(90, 61)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 18)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 61)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 18)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "ID"
        '
        'lbl_id_profile
        '
        Me.lbl_id_profile.AutoSize = True
        Me.lbl_id_profile.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id_profile.Location = New System.Drawing.Point(113, 61)
        Me.lbl_id_profile.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_id_profile.Name = "lbl_id_profile"
        Me.lbl_id_profile.Size = New System.Drawing.Size(26, 18)
        Me.lbl_id_profile.TabIndex = 55
        Me.lbl_id_profile.Text = "ID"
        '
        'lbl_text
        '
        Me.lbl_text.AutoSize = True
        Me.lbl_text.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_text.ForeColor = System.Drawing.Color.Red
        Me.lbl_text.Location = New System.Drawing.Point(13, 168)
        Me.lbl_text.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Size = New System.Drawing.Size(38, 18)
        Me.lbl_text.TabIndex = 54
        Me.lbl_text.Text = "text"
        '
        'lbl_no
        '
        Me.lbl_no.AutoSize = True
        Me.lbl_no.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(273, 168)
        Me.lbl_no.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_no.Name = "lbl_no"
        Me.lbl_no.Size = New System.Drawing.Size(35, 18)
        Me.lbl_no.TabIndex = 53
        Me.lbl_no.Text = "NO"
        '
        'btn_logout
        '
        Me.btn_logout.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.Location = New System.Drawing.Point(10, 201)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(91, 27)
        Me.btn_logout.TabIndex = 52
        Me.btn_logout.Text = "Log Out"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'btn_quiz
        '
        Me.btn_quiz.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quiz.Location = New System.Drawing.Point(276, 201)
        Me.btn_quiz.Name = "btn_quiz"
        Me.btn_quiz.Size = New System.Drawing.Size(91, 27)
        Me.btn_quiz.TabIndex = 51
        Me.btn_quiz.Text = "Soal >>"
        Me.btn_quiz.UseVisualStyleBackColor = True
        '
        'lbl_telp
        '
        Me.lbl_telp.AutoSize = True
        Me.lbl_telp.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telp.Location = New System.Drawing.Point(113, 122)
        Me.lbl_telp.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_telp.Name = "lbl_telp"
        Me.lbl_telp.Size = New System.Drawing.Size(42, 18)
        Me.lbl_telp.TabIndex = 50
        Me.lbl_telp.Text = "Telp"
        '
        'lbl_nama
        '
        Me.lbl_nama.AutoSize = True
        Me.lbl_nama.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nama.Location = New System.Drawing.Point(112, 92)
        Me.lbl_nama.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_nama.Name = "lbl_nama"
        Me.lbl_nama.Size = New System.Drawing.Size(54, 18)
        Me.lbl_nama.TabIndex = 49
        Me.lbl_nama.Text = "Nama"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(90, 122)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 18)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(89, 92)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 18)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 18)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Telp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gotham", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 34)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "It's you?"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Verif_Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(383, 261)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_id_profile)
        Me.Controls.Add(Me.lbl_text)
        Me.Controls.Add(Me.lbl_no)
        Me.Controls.Add(Me.btn_logout)
        Me.Controls.Add(Me.btn_quiz)
        Me.Controls.Add(Me.lbl_telp)
        Me.Controls.Add(Me.lbl_nama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Verif_Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Verif_Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_id_profile As System.Windows.Forms.Label
    Friend WithEvents lbl_text As System.Windows.Forms.Label
    Friend WithEvents lbl_no As System.Windows.Forms.Label
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents btn_quiz As System.Windows.Forms.Button
    Friend WithEvents lbl_telp As System.Windows.Forms.Label
    Friend WithEvents lbl_nama As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
