Public Class FrmHakAkses

    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblHakAkses As DataTable

    Sub kosong()
        ChkPengguna.Checked = False
        ChkJenis.Checked = False
        ChkSatuan.Checked = False
        ChkBarang.Checked = False
        ChkSupplier.Checked = False
        ChkPelanggan.Checked = False
        ChkPembelian.Checked = False
        ChkPenjualan.Checked = False
    End Sub

    Sub Hak_Akses()
        tblHakAkses = Proses.ExecuteQuery("Select * from TblHakAkses Where Level ='" & CmbLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            Call kosong()
        Else
            With tblHakAkses.Rows(0)
                ChkPengguna.Checked = .Item("Pengguna")
                ChkJenis.Checked = .Item("Jenis_Barang")
                ChkSatuan.Checked = .Item("Satuan")
                ChkBarang.Checked = .Item("Barang")
                ChkSupplier.Checked = .Item("Supplier")
                ChkPelanggan.Checked = .Item("Pelanggan")
                ChkPembelian.Checked = .Item("Pengguna")
                ChkPengguna.Checked = .Item("Pembelian")
                ChkPenjualan.Checked = .Item("Penjualan")
                ChkAkses.Checked = .Item("HakAkses")
            End With
        End If

    End Sub


    Private Sub FrmHakAkses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmbLevel.Items.Add("ADMIN")
        CmbLevel.Items.Add("OPERATOR")
        CmbLevel.Items.Add("USER")
    End Sub

    Private Sub FrmHakAkses_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Hak_Akses()
    End Sub


    Private Sub CmbLevel_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbLevel.TextChanged
        Call Hak_Akses()
    End Sub

    Private Sub OkBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkBtn.Click

        If CmbLevel.Text = "" Then Exit Sub

        tblHakAkses = Proses.ExecuteQuery("select * from TblHakAkses where Level ='" & CmbLevel.Text & "'")
        If tblHakAkses.Rows.Count = 0 Then
            SQL = "Insert into TblHakAkses Values('" & CmbLevel.Text & "' , '" & CInt(ChkPengguna.Checked) * -1 & "' ,'" & CInt(ChkJenis.Checked) * -1 & "' ,'" & CInt(ChkSatuan.Checked) * -1 & "' ,'" & CInt(ChkBarang.Checked) * -1 & "' ,'" & CInt(ChkSupplier.Checked) * -1 & "' ,'" & CInt(ChkPelanggan.Checked) * -1 & "' ,'" & CInt(ChkPembelian.Checked) * -1 & "' ,'" & CInt(ChkPenjualan.Checked) * -1 & "'  ,'" & CInt(ChkAkses.Checked) * -1 & "')"
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            SQL = "Update TblHakAkses Set Pengguna = '" & CInt(ChkPengguna.Checked) * -1 & "', Jenis_Barang = '" & CInt(ChkJenis.Checked) * -1 & "',Satuan = '" & CInt(ChkSatuan.Checked) * -1 & "',Barang = '" & CInt(ChkBarang.Checked) * -1 & "',Supplier = '" & CInt(ChkSupplier.Checked) * -1 & "',Pelanggan = '" & CInt(ChkPelanggan.Checked) * -1 & "',Pembelian = '" & CInt(ChkPembelian.Checked) * -1 & "',Penjualan = '" & CInt(ChkPenjualan.Checked) * -1 & "',HakAkses = '" & CInt(ChkAkses.Checked) * -1 & "' where Level = '" & CmbLevel.Text & "' "
            Proses.ExecuteNonQuery(SQL)
            MessageBox.Show("Data telah diubah..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub




End Class