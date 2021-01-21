Imports System.Data.OleDb
Public Class Register_Peserta

    Private Sub Register_Peserta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_reg.Visible = False
        lbl_id.Visible = False
    End Sub

    Private Sub btn_reg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reg.Click
        If txt_nama.Text = "" Or txt_telp.Text = "" Then
            MsgBox("Isi data dengan benar!")
        Else
            Call Koneksi()
            Cmd = New OleDbCommand("Select * from T_peserta where idPeserta in (select max (idPeserta) from T_peserta)", Conn)
            Dim UrutanKode As String
            Dim Hitung As Long
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                UrutanKode = "001"
            Else
                Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 3) + 1
                UrutanKode = Microsoft.VisualBasic.Right("000" & Hitung, 3)
            End If
            lbl_reg.Text = "Your ID Peserta is "
            lbl_id.Text = UrutanKode
            Dim SimpanData As String = "insert into T_peserta values('" & lbl_id.Text & "','" & txt_nama.Text & "','" & txt_telp.Text & "')"
            Cmd = New OleDbCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil ditambahkan!")
            txt_nama.Text = ""
            txt_telp.Text = ""
            lbl_id.Visible = True
            lbl_reg.Visible = True
        End If
    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Me.Hide()
        Login_Peserta.Show()
    End Sub
End Class