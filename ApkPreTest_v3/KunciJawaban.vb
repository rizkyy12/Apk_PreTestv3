Imports System.Data.OleDb
Public Class KunciJawaban
    Sub ShowResult()
        Call Koneksi()
        Da = New OleDbDataAdapter("select * from T_KunciJwb", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "T_KunciJwb")
        DataGridView1.DataSource = (Ds.Tables("T_KunciJwb"))
        DataGridView1.ReadOnly = True
    End Sub
    Private Sub KunciJawaban_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ShowResult()
    End Sub

    Private Sub bt_back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_back.Click
        Me.Hide()
        PreTest_Result.Show()
    End Sub
End Class