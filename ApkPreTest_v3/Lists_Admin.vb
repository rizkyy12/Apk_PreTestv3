Imports System.Data.OleDb
Public Class Lists_Admin
    Sub MunculData()
        Call Koneksi()
        Da = New OleDbDataAdapter("select idUser, nama, username from T_user", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "T_user")
        DataGridView1.DataSource = (Ds.Tables("T_user"))
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub Lists_Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MunculData()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If txt_nim.Text = "" Then
            MsgBox("Input the NIM which you want to DELETE!")
        Else
            Dim HapusData As String = "Delete from T_user where idUser='" & txt_nim.Text & "'"
            Cmd = New OleDbCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data was Deleted!")
            txt_nim.Text = ""
            Call MunculData()
        End If
    End Sub

    Private Sub btn_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_refresh.Click
        MsgBox("Refresh berhasil!")
        Call MunculData()
    End Sub

    Private Sub btn_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_back.Click
        Me.Hide()
        Add_Admin.Show()
    End Sub
End Class