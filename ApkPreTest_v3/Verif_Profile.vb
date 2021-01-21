Imports System.Data.OleDb
Public Class Verif_Profile
    Public Shared ProfileMain
    Dim i As Integer = 0
    Sub MunculData()
        Call Koneksi()
        lbl_id_profile.Text = ProfileMain
        Cmd = New OleDbCommand("select * from T_peserta where idPeserta = '" & lbl_id_profile.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            lbl_nama.Text = Rd.Item("nama")
            lbl_telp.Text = Rd.Item("NoTelp")
            Dim QuizMain1 As New Quiz1
            lbl_id_profile.Text = Rd.Item("idPeserta")
            Quiz1.QuizMain1 = lbl_id_profile.Text
        End If
        Me.Refresh()
    End Sub
    Public Sub load_data()
        Try
            Timer1.Enabled = True
            Me.Refresh()
            Call Koneksi()
            lbl_id_profile.Text = ProfileMain
            Cmd = New OleDbCommand("select MAX(idPertanyaan) from T_jawaban where idPeserta = '" & lbl_id_profile.Text & "'", Conn)
            lbl_no.Text = Cmd.ExecuteScalar().ToString()
            lbl_no.Visible = False
            If lbl_no.Text = "10" Then
                lbl_text.Text = "*This account was be used!"
                btn_quiz.Enabled = False
            Else
                lbl_text.Text = ""
                btn_quiz.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Conn.Close()
        End Try

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
    Private Sub Verif_Profile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MunculData()
        Me.Refresh()
        load_data()
    End Sub

    Private Sub btn_logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_logout.Click
        Me.Hide()
        Login_Peserta.Show()
    End Sub

    Private Sub btn_quiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quiz.Click
        Me.Hide()
        Quiz1.Show()
        Quiz1.Refresh()
    End Sub
End Class