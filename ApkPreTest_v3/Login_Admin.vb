Imports System.Data.OleDb
Public Class Login_Admin
    Sub Login()
        If tb_nim.Text = "" Or tb_pwd.Text = "" Then
            MsgBox("Isi data dengan benar!")
        Else

            Call Koneksi()
            Cmd = New OleDbCommand("select * from T_user where idUser ='" & tb_nim.Text & "' and password ='" & tb_pwd.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            'Cmd = New OleDbCommand("select nama from T_user where idUser ='" & tb_nim.Text & "'", Conn)
            'Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Hide()
                Dim AdminMain As New Page_Admin
                tb_nama.Text = Rd.Item("nama") + " !"
                Page_Admin.AdminMain = tb_nama.Text
                Page_Admin.Show()
                tb_nim.Text = ""
                tb_pwd.Text = ""

            Else
                MsgBox("NIM/Password salah!")
                tb_nim.Text = ""
                tb_pwd.Text = ""
            End If
        End If
    End Sub

    Private Sub Login_Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb_nim.Text = ""
        tb_pwd.Text = ""
    End Sub

    Private Sub bt_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_login.Click
        Call Login()
    End Sub

    Private Sub bt_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_back.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class