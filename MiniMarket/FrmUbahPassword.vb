Public Class FrmUbahPassword
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblUbahPsw As DataTable

    Sub bersih()
        PswLamaTxt.Text = ""
        PswBaruTxt.Text = ""
        PswLamaTxt.Focus()
    End Sub


    Private Sub FrmUbahPassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If PswLamaTxt.Text = "" Then PswLamaTxt.Focus() : Exit Sub
        If PswBaruTxt.Text = "" Then PswBaruTxt.Focus() : Exit Sub
        tblUbahPsw = Proses.ExecuteQuery("select * from TblPengguna where password = '" & PswLamaTxt.Text & "'")
        If tblUbahPsw.Rows.Count = 0 Then
            MessageBox.Show("Perubahan password tidak berhasil...!!!", "Informasi", MessageBoxButtons.OK,
            MessageBoxIcon.Information)
            PswLamaTxt.SelectedText = PswLamaTxt.Text
            PswLamaTxt.Focus()
        Else
            SQL = "Update TblPengguna Set password = '" & PswBaruTxt.Text & "' where kode_pengguna = '" & FrmMenuUtama.TsPengguna.Text & "' "
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Password telah diubah!!", "Perubahan Password Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Call bersih()
            Me.Close()
        End If
    End Sub
End Class