﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quiz5
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
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.rb_4 = New System.Windows.Forms.RadioButton()
        Me.rb_3 = New System.Windows.Forms.RadioButton()
        Me.rb_2 = New System.Windows.Forms.RadioButton()
        Me.rb_1 = New System.Windows.Forms.RadioButton()
        Me.lbl_no = New System.Windows.Forms.Label()
        Me.lbl_q5 = New System.Windows.Forms.Label()
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
        Me.Label1.Location = New System.Drawing.Point(902, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Your ID :"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(983, 22)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(26, 18)
        Me.lbl_id.TabIndex = 62
        Me.lbl_id.Text = "ID"
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(904, 222)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 27)
        Me.btn_update.TabIndex = 61
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_next.Location = New System.Drawing.Point(985, 222)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(75, 27)
        Me.btn_next.TabIndex = 60
        Me.btn_next.Text = "Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(18, 220)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 27)
        Me.btn_back.TabIndex = 59
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'rb_4
        '
        Me.rb_4.AutoSize = True
        Me.rb_4.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_4.Location = New System.Drawing.Point(325, 168)
        Me.rb_4.Name = "rb_4"
        Me.rb_4.Size = New System.Drawing.Size(191, 22)
        Me.rb_4.TabIndex = 58
        Me.rb_4.TabStop = True
        Me.rb_4.Text = "D. MATLAB Simulink"
        Me.rb_4.UseVisualStyleBackColor = True
        '
        'rb_3
        '
        Me.rb_3.AutoSize = True
        Me.rb_3.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_3.Location = New System.Drawing.Point(325, 118)
        Me.rb_3.Name = "rb_3"
        Me.rb_3.Size = New System.Drawing.Size(141, 22)
        Me.rb_3.TabIndex = 57
        Me.rb_3.TabStop = True
        Me.rb_3.Text = "C. Visual Basic"
        Me.rb_3.UseVisualStyleBackColor = True
        '
        'rb_2
        '
        Me.rb_2.AutoSize = True
        Me.rb_2.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_2.Location = New System.Drawing.Point(38, 168)
        Me.rb_2.Name = "rb_2"
        Me.rb_2.Size = New System.Drawing.Size(123, 22)
        Me.rb_2.TabIndex = 56
        Me.rb_2.TabStop = True
        Me.rb_2.Text = "B. LabVIEW"
        Me.rb_2.UseVisualStyleBackColor = True
        '
        'rb_1
        '
        Me.rb_1.AutoSize = True
        Me.rb_1.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_1.Location = New System.Drawing.Point(38, 118)
        Me.rb_1.Name = "rb_1"
        Me.rb_1.Size = New System.Drawing.Size(109, 22)
        Me.rb_1.TabIndex = 55
        Me.rb_1.TabStop = True
        Me.rb_1.Text = "A. SCADA"
        Me.rb_1.UseVisualStyleBackColor = True
        '
        'lbl_no
        '
        Me.lbl_no.AutoSize = True
        Me.lbl_no.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_no.Location = New System.Drawing.Point(15, 69)
        Me.lbl_no.Name = "lbl_no"
        Me.lbl_no.Size = New System.Drawing.Size(18, 18)
        Me.lbl_no.TabIndex = 54
        Me.lbl_no.Text = "5"
        '
        'lbl_q5
        '
        Me.lbl_q5.AutoSize = True
        Me.lbl_q5.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_q5.Location = New System.Drawing.Point(35, 69)
        Me.lbl_q5.Name = "lbl_q5"
        Me.lbl_q5.Size = New System.Drawing.Size(41, 18)
        Me.lbl_q5.TabIndex = 53
        Me.lbl_q5.Text = "Soal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gotham", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 34)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "SOAL"
        '
        'lbl_huruf2
        '
        Me.lbl_huruf2.AutoSize = True
        Me.lbl_huruf2.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_huruf2.Location = New System.Drawing.Point(783, 227)
        Me.lbl_huruf2.Name = "lbl_huruf2"
        Me.lbl_huruf2.Size = New System.Drawing.Size(17, 18)
        Me.lbl_huruf2.TabIndex = 66
        Me.lbl_huruf2.Text = "J"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(982, 193)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(55, 18)
        Me.lbl_status.TabIndex = 65
        Me.lbl_status.Text = "status"
        '
        'lbl_huruf1
        '
        Me.lbl_huruf1.AutoSize = True
        Me.lbl_huruf1.Font = New System.Drawing.Font("Gotham", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_huruf1.Location = New System.Drawing.Point(705, 227)
        Me.lbl_huruf1.Name = "lbl_huruf1"
        Me.lbl_huruf1.Size = New System.Drawing.Size(29, 18)
        Me.lbl_huruf1.TabIndex = 64
        Me.lbl_huruf1.Text = "KJ"
        '
        'Timer1
        '
        Me.Timer1.Interval = 200
        '
        'Quiz5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1072, 261)
        Me.Controls.Add(Me.lbl_huruf2)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.lbl_huruf1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_next)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.rb_4)
        Me.Controls.Add(Me.rb_3)
        Me.Controls.Add(Me.rb_2)
        Me.Controls.Add(Me.rb_1)
        Me.Controls.Add(Me.lbl_no)
        Me.Controls.Add(Me.lbl_q5)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Quiz5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quiz5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents rb_4 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_3 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_2 As System.Windows.Forms.RadioButton
    Friend WithEvents rb_1 As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_no As System.Windows.Forms.Label
    Friend WithEvents lbl_q5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_huruf2 As System.Windows.Forms.Label
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents lbl_huruf1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
