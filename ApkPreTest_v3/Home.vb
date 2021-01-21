Public Class Home

    Private Sub btn_admin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_admin.Click
        Me.Hide()
        Login_Admin.Show()
    End Sub

    Private Sub btn_responden_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_responden.Click
        Me.Hide()
        Login_Peserta.Show()
    End Sub

End Class
