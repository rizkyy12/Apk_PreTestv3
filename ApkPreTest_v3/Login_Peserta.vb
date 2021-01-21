Imports System.Data.OleDb
Public Class Login_Peserta

    Private Sub Login_Peserta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        id_responden.Text = ""
        'lbl_id.Visible = False
        lbl_id.Visible = False
    End Sub

    Private Sub bt_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_login.Click
        'Quiz1.Refresh()
        Verif_Profile.load_data()
        Verif_Profile.Refresh()
        If id_responden.Text = "" Then
            MsgBox("Data not correctly!")
        Else
            Call Koneksi()
            Cmd = New OleDbCommand("select * from T_peserta where idPeserta ='" & id_responden.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Hide()
                Dim ProfileMain As New Verif_Profile
                lbl_id.Text = Rd.Item("idPeserta")
                Verif_Profile.ProfileMain = lbl_id.Text
                Verif_Profile.Show()
                Verif_Profile.MunculData()
                id_responden.Text = ""
            Else
                MsgBox("ID Peserta can't Register, Register NOW!")
                id_responden.Text = ""
            End If
        End If
    End Sub

    Private Sub br_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles br_back.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub btn_reg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_reg.Click
        Me.Hide()
        Register_Peserta.Show()
    End Sub
End Class