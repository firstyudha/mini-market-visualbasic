Public Class FrmBarang
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblbarang As DataTable

    Sub Data_Record()
        tblbarang = Proses.ExecuteQuery("select * from TblBarang order by Kode_Barang asc")
        DGBarang.DataSource = tblbarang
        DGBarang.Columns(2).Width = 250
        DGBarang.Columns(7).Width = 75
    End Sub

    Sub Kelompok()
        tblbarang = Proses.ExecuteQuery("Select * from TblKelompok order by No asc")
        If tblbarang.Rows.Count = 0 Then
        Else
            CmKelompok.Items.Clear()
            With tblbarang.Columns(1)
                For a = 0 To tblbarang.Rows.Count - 1
                    CmKelompok.Items.Add(.Table.Rows(a).Item(1))
                Next a
            End With

        End If
    End Sub

    Sub Satuan()
        tblbarang = Proses.ExecuteQuery("Select * from TblSatuan order by No asc")
        If tblbarang.Rows.Count = 0 Then
        Else
            CmbSatuan.Items.Clear()
            With tblbarang.Columns(1)
                For a = 0 To tblbarang.Rows.Count - 1
                    CmbSatuan.Items.Add(.Table.Rows(a).Item(1))
                Next a
            End With

        End If
    End Sub

    Sub Kode_Otomatis()
        tblbarang = Proses.ExecuteQuery("select * from TblBarang order by Kode_Barang desc")
        If tblbarang.Rows.Count = 0 Then
            KdBarangTxt.Text = "KB-001"
        Else
            With tblbarang.Rows(0)
                KdBarangTxt.Text = .Item("Kode_Barang")
            End With

            KdBarangTxt.Text = Val(Microsoft.VisualBasic.Mid(KdBarangTxt.Text, 4, 3)) + 1
            If Len(KdBarangTxt.Text) = 1 Then
                KdBarangTxt.Text = "KB-00" & KdBarangTxt.Text & ""
            ElseIf Len(KdBarangTxt.Text) = 2 Then
                KdBarangTxt.Text = "KB-0" & KdBarangTxt.Text & ""
            ElseIf Len(KdBarangTxt.Text) = 3 Then
                KdBarangTxt.Text = "KB-" & KdBarangTxt.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        BarcodeTxt.Text = ""
        NmBarangTxt.Text = ""
        CmKelompok.Text = ""
        CmbSatuan.Text = ""
        HrgBeliTxt.Text = ""
        HrgJualTxt.Text = ""
        StockLbl.Text = "0"
        BarcodeTxt.Focus()

        Call Data_Record()
        Call Kode_Otomatis()
        Call Kelompok()
        Call Satuan()
        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
    End Sub

    Private Sub FrmBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()

    End Sub

    Private Sub HrgBeliTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HrgBeliTxt.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                HrgBeliTxt.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub HrgJualTxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HrgJualTxt.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                HrgJualTxt.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub CariDataTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariDataTxt.TextChanged
        If CariKdBarang.Checked = True Then
            tblbarang = Proses.ExecuteQuery("select * from TblBarang where Kode_Barang Like '%" & CariDataTxt.Text & "%' ")
            If tblbarang.Rows.Count = 0 Then
                DGBarang.DataSource = tblbarang
                CariDataTxt.Focus()
            Else
                DGBarang.DataSource = tblbarang
            End If

        ElseIf CariKdBarang.Checked = True Then
            tblbarang = Proses.ExecuteQuery("select * from TblBarang where Nama_Barang Like '%" & CariDataTxt.Text & "%' ")
            If tblbarang.Rows.Count = 0 Then
                DGBarang.DataSource = tblbarang
                CariDataTxt.Focus()
            Else
                DGBarang.DataSource = tblbarang
            End If

        ElseIf CariStock.Checked = True Then
            tblbarang = Proses.ExecuteQuery("select * from TblBarang where Stock Like '%" & CariDataTxt.Text & "%' ")
            If tblbarang.Rows.Count = 0 Then
                DGBarang.DataSource = tblbarang
                CariDataTxt.Focus()
            Else
                DGBarang.DataSource = tblbarang
            End If



        End If

    End Sub


    Private Sub DGBarang_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGBarang.DoubleClick
        KdBarangTxt.Text = DGBarang.SelectedCells(0).Value
        BarcodeTxt.Text = DGBarang.SelectedCells(1).Value
        NmBarangTxt.Text = DGBarang.SelectedCells(2).Value
        CmKelompok.Text = DGBarang.SelectedCells(3).Value
        CmbSatuan.Text = DGBarang.SelectedCells(4).Value
        HrgBeliTxt.Text = DGBarang.SelectedCells(5).Value
        HrgJualTxt.Text = DGBarang.SelectedCells(6).Value
        StockLbl.Text = DGBarang.SelectedCells(7).Value

        SimpanBtn.Enabled = False : UbahBtn.Enabled = True : HapusBtn.Enabled = True
        BatalBtn.Enabled = True : TutupBtn.Enabled = True

    End Sub

    Private Sub CariKdBarang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariKdBarang.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub CariNmBarang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariNmBarang.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub CariStock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariStock.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If BarcodeTxt.Text = "" Then BarcodeTxt.Focus() : Exit Sub
        If NmBarangTxt.Text = "" Then NmBarangTxt.Focus() : Exit Sub
        If CmKelompok.Text = "" Then CmKelompok.Focus() : Exit Sub
        If CmbSatuan.Text = "" Then CmbSatuan.Focus() : Exit Sub
        If HrgBeliTxt.Text = "" Then HrgBeliTxt.Focus() : Exit Sub
        If HrgJualTxt.Text = "" Then HrgJualTxt.Focus() : Exit Sub

        SQL = "Insert into TblBarang Values('" & KdBarangTxt.Text & "', '" & BarcodeTxt.Text & "','" & NmBarangTxt.Text & "', '" & CmKelompok.Text & "','" & CmbSatuan.Text & "','" & HrgBeliTxt.Text & "','" & HrgJualTxt.Text & "','" & StockLbl.Text & "')"
        Proses.ExecuteNonQuery(SQL)

        MessageBox.Show("Data Baru Telah Disimpan...!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Bersih()



    End Sub

    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If BarcodeTxt.Text = "" Then BarcodeTxt.Focus() : Exit Sub
        If NmBarangTxt.Text = "" Then NmBarangTxt.Focus() : Exit Sub
        If CmKelompok.Text = "" Then CmKelompok.Focus() : Exit Sub
        If CmbSatuan.Text = "" Then CmbSatuan.Focus() : Exit Sub
        If HrgBeliTxt.Text = "" Then HrgBeliTxt.Focus() : Exit Sub
        If HrgJualTxt.Text = "" Then HrgJualTxt.Focus() : Exit Sub

        SQL = "update TblBarang set Kode_Barcode = '" & BarcodeTxt.Text & "', Nama_Barang = '" & NmBarangTxt.Text & "', Kelompok = '" & CmKelompok.Text & "', Satuan = '" & CmbSatuan.Text & "',Harga_Beli = '" & HrgBeliTxt.Text & "', Harga_Jual = '" & HrgJualTxt.Text & "', Stock = '" & StockLbl.Text & "' where Kode_Barang = '" & KdBarangTxt.Text & "' "
        Proses.ExecuteNonQuery(SQL)

        MessageBox.Show("Data Telah Diubah...!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Bersih()
    End Sub

    Private Sub HapusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusBtn.Click
        SQL = "delete from TblBarang where Kode_Barang = '" & KdBarangTxt.Text & "' "
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Telah Dihapus...!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Call Bersih()
    End Sub

    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        Call Bersih()
        KdBarangTxt.Focus()

    End Sub

    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()

    End Sub

End Class