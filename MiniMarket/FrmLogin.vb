Public Class FrmLogin

    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblLogin As DataTable

    Sub Login()
        If KdPenggunaTxt.Text = "" Then KdPenggunaTxt.Focus() : Exit Sub
        If PswTxt.Text = "" Then PswTxt.Focus() : Exit Sub
        tblLogin = Proses.ExecuteQuery("select * from TblPengguna where kode_pengguna = '" & KdPenggunaTxt.Text & "' and password= '" & PswTxt.Text & "'")
        If tblLogin.Rows.Count = 0 Then
            MessageBox.Show("Login tidak berhasil...!!", "Informasi",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            KdPenggunaTxt.Focus()
        Else
            FrmMenuUtama.TsPengguna.Text = KdPenggunaTxt.Text
            FrmMenuUtama.TsLevel.Text = LevelTxt.Text
            Me.Hide()
            FrmMenuUtama.Show()
        End If

    End Sub

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KdPenggunaTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles KdPenggunaTxt.KeyPress
        If e.KeyChar = Chr(13) Then
            tblLogin = Proses.ExecuteQuery("select * from TblPengguna where Kode_Pengguna = '" & KdPenggunaTxt.Text & "'")
            If tblLogin.Rows.Count = 0 Then
                MessageBox.Show("Kode tidak ditemukan..!!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                KdPenggunaTxt.Focus()
            Else
                LevelTxt.Text = tblLogin.Rows(0).Item("Level")
                PswTxt.Focus()
            End If
        End If
    End Sub

    Private Sub PswTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PswTxt.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Login()
        End If
    End Sub

    
    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click
        Call Login()
    End Sub

    Private Sub BatalBtkn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtkn.Click
        End
    End Sub

    Private Sub KdPenggunaTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KdPenggunaTxt.TextChanged

    End Sub
End Class