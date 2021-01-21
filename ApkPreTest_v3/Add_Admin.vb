Imports System.Data.OleDb
Public Class Add_Admin

    Private Sub btn_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        If txt_nama.Text = "" Or txt_nim.Text = "" Or txt_username.Text = "" Or txt_pwd.Text = "" Then
            MsgBox("Data harus diisi!")
        Else
            Call Koneksi()
            Dim SimpanData As String = "Insert into T_user values('" & txt_nim.Text & "','" & txt_nama.Text & "','" & txt_username.Text & "','" & txt_pwd.Text & "')"
            Cmd = New OleDbCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data berhasil ditambahkan!")
            txt_nama.Text = ""
            txt_nim.Text = ""
            txt_username.Text = ""
            txt_pwd.Text = ""
        End If
    End Sub

    Private Sub btn_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_list.Click
        Me.Hide()
        Lists_Admin.Show()
        Lists_Admin.Refresh()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        Page_Admin.Show()
    End Sub
End Class