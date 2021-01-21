Imports System.Data.OleDb
Public Class Page_Admin
    Public Shared AdminMain
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Login_Admin.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Add_Admin.Show()
    End Sub

    Private Sub btn_quisioner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_quisioner.Click
        Me.Hide()
        PreTest_Result.Show()
    End Sub

    Private Sub Page_Admin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbl_nama.Text = AdminMain
    End Sub
End Class