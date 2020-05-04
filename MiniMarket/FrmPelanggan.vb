﻿Public Class FrmPelanggan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblpelanggan As DataTable

    Sub Data_Record()
        tblpelanggan = Proses.ExecuteQuery("Select * From TblPelanggan order by Kode_Pelanggan asc")
        Dgpelanggan.DataSource = tblpelanggan
        DGPelanggan.Columns(2).Width = 285
    End Sub
        tblpelanggan = Proses.ExecuteQuery("Select * From TblPelanggan order by Kode_Pelanggan desc")
        If tblpelanggan.Rows.Count = 0 Then
            KdPelangganTxt.Text = "KP-001"
        Else
            With tblpelanggan.Rows(0)
                KdPelangganTxt.Text = .Item("Kode_Pelanggan")
            End With
            If Len(KdPelangganTxt.Text) = 1 Then
                KdPelangganTxt.Text = "KP-00" & KdPelangganTxt.Text & ""
            ElseIf Len(KdPelangganTxt.Text) = 2 Then
                KdPelangganTxt.Text = "KP-0" & KdPelangganTxt.Text & ""
            ElseIf Len(KdPelangganTxt.Text) = 3 Then
                KdPelangganTxt.Text = "KP-" & KdPelangganTxt.Text & ""
            End If
        End If
    End Sub
        KdPelangganTxt.Text = ""
        NmPelanggantxt.Text = ""
        AlmTxt.Text = ""
        TlpTxt.Text = ""
        NmPelanggantxt.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
    End Sub
        Me.Top = 0
        Me.Left = 0
    End Sub
        If KdPelangganTxt.Text = "" Then KdPelangganTxt.Focus() : Exit Sub
        If NmPelangganTxt.Text = "" Then NmPelangganTxt.Focus() : Exit Sub
        If AlmTxt.Text = "" Then AlmTxt.Focus() : Exit Sub
        If TlpTxt.Text = "" Then TlpTxt.Focus() : Exit Sub
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses",
       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub
        If NmPelangganTxt.Text = "" Then NmPelangganTxt.Focus() : Exit Sub
        If AlmTxt.Text = "" Then AlmTxt.Focus() : Exit Sub
        If TlpTxt.Text = "" Then TlpTxt.Focus() : Exit Sub
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah diubah..!!", "Perubahan Data Sukses",
       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub
        Call Bersih()
        KdPelangganTxt.Focus()
    End Sub
        SQL = "Delete From TblPelanggan Where Kode_Pelanggan = '" & KdPelangganTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses",
       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub
        Me.Close()
    End Sub
        If CariKdPelanggan.Checked = True Then
            tblpelanggan = Proses.ExecuteQuery("Select * From TblPelanggan Where Kode_Pelanggan Like '%" & CariDataTxt.Text & "%'")
            If tblpelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblpelanggan
                CariDataTxt.Focus()
            Else
                DGPelanggan.DataSource = tblpelanggan
            End If
            tblpelanggan = Proses.ExecuteQuery("Select * From TblPelanggan Where Nama_Pelanggan Like '%" & CariDataTxt.Text & "%'")
            If tblpelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblpelanggan
                CariDataTxt.Focus()
            Else
                DGPelanggan.DataSource = tblpelanggan
            End If
        End If
    End Sub
        KdPelangganTxt.Text = DGPelanggan.SelectedCells(0).Value
        NmPelangganTxt.Text = DGPelanggan.SelectedCells(1).Value
        AlmTxt.Text = DGPelanggan.SelectedCells(2).Value
        TlpTxt.Text = DGPelanggan.SelectedCells(3).Value
        SimpanBtn.Enabled = False : UbahBtn.Enabled = True : HapusBtn.Enabled = True
        BatalBtn.Enabled = True : TutupBtn.Enabled = False
    End Sub
        CariDataTxt.Focus()
    End Sub
        CariDataTxt.Focus()
    End Sub
