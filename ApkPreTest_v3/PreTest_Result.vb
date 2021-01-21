Imports System.Data.OleDb
Public Class PreTest_Result
    Sub showInfo()
        Call Koneksi()
        Cmd = New OleDbCommand("select nama, idPeserta from T_peserta where idPeserta='" & tb_search.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            lbl_nama.Text = "Nama : " + Rd.Item("nama")
            lbl_id.Text = "ID : " + Rd.Item("idPeserta")
        End If
    End Sub
    Sub ShowResult()
        Call Koneksi()
        Da = New OleDbDataAdapter("select idPeserta, idPertanyaan, jawaban, Status from T_jawaban", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "T_jawaban")
        DataGridView1.DataSource = (Ds.Tables("T_jawaban"))
        DataGridView1.ReadOnly = True
    End Sub


    Private Sub btn_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cari.Click
        Call Koneksi()
        Cmd = New OleDbCommand("select idPeserta, idPertanyaan, jawaban, Status from T_jawaban where idPeserta='" & tb_search.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Call showInfo()
            Call Koneksi()
            Da = New OleDbDataAdapter("select idPeserta, idPertanyaan, jawaban, Status from T_jawaban where idPeserta='" & tb_search.Text & "'", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "FindData")
            DataGridView1.DataSource = Ds.Tables("FindData")
            DataGridView1.ReadOnly = True
            lbl_id.Visible = True
            lbl_nama.Visible = True
        Else
            MsgBox("Data not corectly!")
        End If
        If tb_search.Text = "" Then
            MsgBox("Fill the data!")
        End If
    End Sub
    Private Sub PreTest_Result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ShowResult()
        lbl_id.Visible = False
        lbl_nama.Visible = False
    End Sub

    Private Sub bt_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_back.Click
        Me.Hide()
        Page_Admin.Show()
        Call ShowResult()
        lbl_id.Visible = False
        lbl_nama.Visible = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        KunciJawaban.Show()
    End Sub
End Class