Imports System.Data.OleDb
Public Class Quiz2
    Public Shared QuizMain2
    Dim pilihan As String
    Dim idJawaban As String
    Dim i As Integer = 0
    Sub MunculData()
        Call Koneksi()
        lbl_id.Text = QuizMain2
        Cmd = New OleDbCommand("Select idPertanyaan, soal, KunciJawaban from T_pertanyaan where idPertanyaan = 2 ", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            lbl_no.Text = Rd.Item("idPertanyaan")
            lbl_q2.Text = Rd.Item("soal")
            lbl_huruf1.Text = Rd.Item("KunciJawaban")
        End If
    End Sub
    Sub MasukanData()
        Call Koneksi()
        Cmd = New OleDbCommand("Select idPertanyaan, idPeserta FROM T_pertanyaan, T_peserta where idPertanyaan= 2 AND idPeserta = '" & lbl_id.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Dim SimpanData As String = "insert into T_jawaban values('" & idJawaban & "','" & lbl_id.Text & "','" & Rd.Item("idPertanyaan") & "','" & pilihan & "', ' ')"
            Cmd = New OleDbCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            lbl_id.Text = Rd.Item("idPeserta")
            Dim QuizMain3 As New Quiz3
            Quiz3.QuizMain3 = lbl_id.Text
            Me.Hide()
            Quiz3.Show()
        End If
        btn_next.Enabled = False
        btn_update.Visible = True
    End Sub
    Private Sub Quiz2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MunculData()
        btn_update.Visible = False
        lbl_huruf1.Visible = False
        lbl_huruf2.Visible = False
        lbl_status.Visible = False
    End Sub
    Public Sub load_data()
        Try
            Timer1.Enabled = True
            Me.Refresh()
            Call Koneksi()
            Cmd = New OleDbCommand("Select jawaban FROM T_jawaban where idPertanyaan= 2 AND idPeserta = '" & lbl_id.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            lbl_huruf2.Text = Rd.Item("jawaban")
            If lbl_huruf1.Text = lbl_huruf2.Text Then
                lbl_status.Text = "Benar"
            Else
                lbl_status.Text = "Salah"
            End If
            Dim NewData As String = "update T_jawaban set [Status] = '" & lbl_status.Text & "' where [idPertanyaan]= 2 AND [idPeserta] = '" & lbl_id.Text & "'"
            Cmd = New OleDbCommand(NewData, Conn)
            Cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub rb_1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_1.CheckedChanged
        pilihan = "A"
        idJawaban = "1"
    End Sub

    Private Sub rb_2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_2.CheckedChanged
        pilihan = "B"
        idJawaban = "2"
    End Sub

    Private Sub rb_3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_3.CheckedChanged
        pilihan = "C"
        idJawaban = "3"
    End Sub

    Private Sub rb_4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rb_4.CheckedChanged
        pilihan = "D"
        idJawaban = "4"
    End Sub

    Private Sub btn_next_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_next.Click
        If btn_next.Enabled = True Then
            Call MasukanData()
        End If
        load_data()
    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Call Koneksi()
        Dim Update As String = "update T_jawaban set [idJawaban]='" & idJawaban & "', [jawaban] = '" & pilihan & "' where [idPertanyaan]= 2 AND [idPeserta] = '" & lbl_id.Text & "'"
        Cmd = New OleDbCommand(Update, Conn)
        Cmd.ExecuteNonQuery()
        Me.Hide()
        Quiz3.Show()
        load_data()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        Quiz1.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If i = 0 Then
            load_data()
        ElseIf i = 1 Then
            load_data()
        ElseIf i = 2 Then
            load_data()
            i = 0
            Timer1.Enabled = False
            Exit Sub
        End If
        i += 1
    End Sub
End Class