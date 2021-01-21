<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz10
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.rb_4 = New System.Windows.Forms.RadioButton()
        Me.rb_3 = New System.Windows.Forms.RadioButton()
        Me.rb_2 = New System.Windows.Forms.RadioButton()
        Me.rb_1 = New System.Windows.Forms.RadioButton()
        Me.lbl_no = New System.Windows.Forms.Label()
        Me.lbl_q10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_huruf2 = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_huruf1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(652, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Your ID :"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(733, 22)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(26, 18)
        Me.lbl_id.TabIndex = 113
        Me.lbl_id.Text = "ID"
        '
        'btn_next
        '
        Me.btn_next.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(747, 237)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(75, 27)
        Me.btn_next.TabIndex = 112
        Me.btn_next.Text = "Finish"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(18, 237)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 27)
        Me.btn_back.TabIndex = 111
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'rb_4
        '
        Me.rb_4.AutoSize = True
        Me.rb_4.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_4.Location = New System.Drawing.Point(38, 202)
        Me.rb_4.Name = "rb_4"
        Me.rb_4.Size = New System.Drawing.Size(468, 22)
        Me.rb_4.TabIndex = 110
        Me.rb_4.TabStop = True
        Me.rb_4.Text = "D. Saklar penghubung kumparan medan (field winding)"
        Me.rb_4.UseVisualStyleBackColor = True
        '
        'rb_3
        '
        Me.rb_3.AutoSize = True
        Me.rb_3.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_3.Location = New System.Drawing.Point(38, 174)
        Me.rb_3.Name = "rb_3"
        Me.rb_3.Size = New System.Drawing.Size(556, 22)
        Me.rb_3.TabIndex = 109
        Me.rb_3.TabStop = True
        Me.rb_3.Text = "C. Pemutus kumparan utama (main winding) ketika motor berputar"
        Me.rb_3.UseVisualStyleBackColor = True
        '
        'rb_2
        '
        Me.rb_2.AutoSize = True
        Me.rb_2.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_2.Location = New System.Drawing.Point(38, 146)
        Me.rb_2.Name = "rb_2"
        Me.rb_2.Size = New System.Drawing.Size(550, 22)
        Me.rb_2.TabIndex = 108
        Me.rb_2.TabStop = True
        Me.rb_2.Text = "B. Pemutus kumparan bantu (auxiliary winding) ketika motor diam"
        Me.rb_2.UseVisualStyleBackColor = True
        '
        'rb_1
        '
        Me.rb_1.AutoSize = True
        Me.rb_1.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_1.Location = New System.Drawing.Point(38, 118)
        Me.rb_1.Name = "rb_1"
        Me.rb_1.Size = New System.Drawing.Size(580, 22)
        Me.rb_1.TabIndex = 107
        Me.rb_1.TabStop = True
        Me.rb_1.Text = "A. Pemutus kumparan bantu (auxiliary winding) ketika motor berputar"
        Me.rb_1.UseVisualStyleBackColor = True
        '
        'lbl_no
        '
        Me.lbl_no.AutoSize = True
        Me.lbl_no.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(15, 69)
        Me.lbl_no.Name = "lbl_no"
        Me.lbl_no.Size = New System.Drawing.Size(29, 18)
        Me.lbl_no.TabIndex = 106
        Me.lbl_no.Text = "10."
        '
        'lbl_q10
        '
        Me.lbl_q10.AutoSize = True
        Me.lbl_q10.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_q10.Location = New System.Drawing.Point(42, 69)
        Me.lbl_q10.Name = "lbl_q10"
        Me.lbl_q10.Size = New System.Drawing.Size(41, 18)
        Me.lbl_q10.TabIndex = 105
        Me.lbl_q10.Text = "Soal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gotham", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 34)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "SOAL"
        '
        'lbl_huruf2
        '
        Me.lbl_huruf2.AutoSize = True
        Me.lbl_huruf2.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_huruf2.Location = New System.Drawing.Point(545, 245)
        Me.lbl_huruf2.Name = "lbl_huruf2"
        Me.lbl_huruf2.Size = New System.Drawing.Size(17, 18)
        Me.lbl_huruf2.TabIndex = 117
        Me.lbl_huruf2.Text = "J"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(744, 211)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(55, 18)
        Me.lbl_status.TabIndex = 116
        Me.lbl_status.Text = "status"
        '
        'lbl_huruf1
        '
        Me.lbl_huruf1.AutoSize = True
        Me.lbl_huruf1.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_huruf1.Location = New System.Drawing.Point(467, 245)
        Me.lbl_huruf1.Name = "lbl_huruf1"
        Me.lbl_huruf1.Size = New System.Drawing.Size(29, 18)
        Me.lbl_huruf1.TabIndex = 115
        Me.lbl_huruf1.Text = "KJ"
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Quiz10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 276)
        Me.Controls.Add(Me.lbl_huruf2)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.lbl_huruf1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.rb_4)
        Me.Controls.Add(Me.rb_3)
        Me.Controls.Add(Me.rb_2)
        Me.Controls.Add(Me.rb_1)
        Me.Controls.Add(Me.lbl_no)
        Me.Controls.Add(Me.lbl_q10)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Quiz10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents rb_4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_1 As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_no As System.Windows.Forms.Label
    Friend WithEvents lbl_q10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_huruf2 As System.Windows.Forms.Label
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents lbl_huruf1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
