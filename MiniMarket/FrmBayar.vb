Public Class FrmBayar

    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tbljual As DataTable
    Dim disc As Single

    Private Sub FrmBayar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Sub Bersih()
        LblSubTotal.Text = "0"
        DiscTxt.Text = "0"
        LblGrandTotal.Text = "0"
        BayarTxt.Text = "0"
        LblKembali.Text = "0"
    End Sub

    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BayarTxt.Text = "0" Then Exit Sub
        If BayarTxt.Text < Replace(LblGrandTotal.Text, ",", "") Then MsgBox("Pembayaran tidak cukup", MsgBoxStyle.Critical, "Bayar")        SQL = "Insert Into Tblpenjualan Values ('" & FrmPenjualan.LblFaktur.Text & "','" &
        Format(Now, "yyyy/MM/dd") & "','" &
        Microsoft.VisualBasic.Left(FrmPenjualan.CmbPelanggan.Text, 7) & "','" &
        Replace(LblSubTotal.Text, ".", "") & "','" & DiscTxt.Text & "','" &
        Replace(LblGrandTotal.Text, ".", "") & "','" & BayarTxt.Text & "','" &
        Replace(LblKembali.Text, ".", "") & "')"
        Proses.ExecuteNonQuery(SQL)        Call Bersih()
        FrmPenjualan.Bersih()
        FrmPenjualan.BarangTxt.Focus()
        Me.Close()
    End Sub

    Private Sub FrmBayar_Activated(ByVal sender As Object, ByVal e As System.EventArgs)
        DiscTxt.Focus()
    End Sub

    Private Sub DiscTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"        disc = (Val(Replace(LblSubTotal.Text, ".", "") * DiscTxt.Text)) / 100
        LblGrandTotal.Text = (Val(Replace(LblSubTotal.Text, ".", "")) - Val(disc)).ToString("#,#")
    End Sub    Private Sub LblGrandTotal_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If LblGrandTotal.Text = "" Then LblGrandTotal.Text = "0"
    End Sub

    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmPenjualan.BarangTxt.Focus()
        Me.Close()
    End Sub    Private Sub BayarTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If BayarTxt.Text = "" Then BayarTxt.Text = "0"
        LblKembali.Text = Val(BayarTxt.Text) - Replace(LblGrandTotal.Text, ".", "")
        Dim Kembali As Single
        Kembali = Replace(LblKembali.Text, ".", "")
        LblKembali.Text = Kembali.ToString("#,#")
        If LblKembali.Text = "" Then LblKembali.Text = "0"
    End Sub
    Private Sub BayarTxt_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BayarTxt.TextChanged
        If BayarTxt.Text = "" Then BayarTxt.Text = "0"
        LblKembali.Text = Val(BayarTxt.Text) - Replace(LblGrandTotal.Text, ".", "")
        Dim Kembali As Single
        Kembali = Replace(LblKembali.Text, ".", "")
        LblKembali.Text = Kembali.ToString("#,#")
        If LblKembali.Text = "" Then LblKembali.Text = "0"
    End Sub

    Private Sub BtnOk_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        If BayarTxt.Text = "0" Then Exit Sub
        If BayarTxt.Text < Replace(LblGrandTotal.Text, ",", "") Then MsgBox("Pembayaran tidak cukup", MsgBoxStyle.Critical, "Bayar")        SQL = "Insert Into TblPenjualan Values ('" & FrmPenjualan.LblFaktur.Text & "','" &
        Format(Now, "yyyy/MM/dd") & "','" &
        Microsoft.VisualBasic.Left(FrmPenjualan.CmbPelanggan.Text, 6) & "','" &
        Replace(LblSubTotal.Text, ",", "") & "','" & DiscTxt.Text & "','" &
        Replace(LblGrandTotal.Text, ",", "") & "','" & BayarTxt.Text & "','" &
        Replace(LblKembali.Text, ",", "") & "')"
        Proses.ExecuteNonQuery(SQL)        Call Bersih()
        FrmPenjualan.Bersih()
        FrmPenjualan.BarangTxt.Focus()
        Me.Close()
    End Sub

    Private Sub BatalBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        FrmPenjualan.BarangTxt.Focus()
        Me.Close()
    End Sub

    Private Sub DiscTxt_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscTxt.TextChanged
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"        disc = (Val(LblSubTotal.Text * DiscTxt.Text)) / 100
        LblGrandTotal.Text = (Val(LblSubTotal.Text - Val(disc)))
    End Sub

End Class