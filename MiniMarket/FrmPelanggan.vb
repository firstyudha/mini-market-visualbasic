Public Class FrmPelanggan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblpelanggan As DataTable

    Sub Data_Record()
        tblpelanggan = Proses.ExecuteQuery("Select * From TblPelanggan order by Kode_Pelanggan asc")
        Dgpelanggan.DataSource = tblpelanggan
        DGPelanggan.Columns(1).Width = 185
        DGPelanggan.Columns(2).Width = 285
    End Sub

    Sub Kode_Otomatis()
        tblpelanggan = Proses.ExecuteQuery("Select * From TblPelanggan order by Kode_Pelanggan desc")
        If tblpelanggan.Rows.Count = 0 Then
            KdPelangganTxt.Text = "KP-001"
        Else
            With tblpelanggan.Rows(0)
                KdPelangganTxt.Text = .Item("Kode_Pelanggan")
            End With

            KdPelangganTxt.Text = Val(Microsoft.VisualBasic.Mid(KdPelangganTxt.Text, 4, 3)) + 1
            If Len(KdPelangganTxt.Text) = 1 Then
                KdPelangganTxt.Text = "KP-00" & KdPelangganTxt.Text & ""
            ElseIf Len(KdPelangganTxt.Text) = 2 Then
                KdPelangganTxt.Text = "KP-0" & KdPelangganTxt.Text & ""
            ElseIf Len(KdPelangganTxt.Text) = 3 Then
                KdPelangganTxt.Text = "KP-" & KdPelangganTxt.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
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

    Private Sub FrmPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If KdPelangganTxt.Text = "" Then KdPelangganTxt.Focus() : Exit Sub
        If NmPelangganTxt.Text = "" Then NmPelangganTxt.Focus() : Exit Sub
        If AlmTxt.Text = "" Then AlmTxt.Focus() : Exit Sub
        If TlpTxt.Text = "" Then TlpTxt.Focus() : Exit Sub
        SQL = "Insert Into TblPelanggan Values ('" & KdPelangganTxt.Text & "','" & NmPelangganTxt.Text & "' ,'" & AlmTxt.Text & "','" & TlpTxt.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses",
       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If NmPelangganTxt.Text = "" Then NmPelangganTxt.Focus() : Exit Sub
        If AlmTxt.Text = "" Then AlmTxt.Focus() : Exit Sub
        If TlpTxt.Text = "" Then TlpTxt.Focus() : Exit Sub
        SQL = "Update TblPelanggan Set Nama_Pelanggan = '" & NmPelangganTxt.Text & "', Alamat = '" & AlmTxt.Text & "', Telepon = '" & TlpTxt.Text & "' where Kode_Pelanggan = '" & KdPelangganTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah diubah..!!", "Perubahan Data Sukses",
       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        Call Bersih()
        KdPelangganTxt.Focus()
    End Sub

    Private Sub HapusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusBtn.Click
        SQL = "Delete From TblPelanggan Where Kode_Pelanggan = '" & KdPelangganTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses",
       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub

    Private Sub CariDataTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariDataTxt.TextChanged
        If CariKdPelanggan.Checked = True Then
            tblpelanggan = Proses.ExecuteQuery("Select * From TblPelanggan Where Kode_Pelanggan Like '%" & CariDataTxt.Text & "%'")
            If tblpelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblpelanggan
                CariDataTxt.Focus()
            Else
                DGPelanggan.DataSource = tblpelanggan
            End If

        ElseIf CariNmPelanggan.Checked = True Then
            tblpelanggan = Proses.ExecuteQuery("Select * From TblPelanggan Where Nama_Pelanggan Like '%" & CariDataTxt.Text & "%'")
            If tblpelanggan.Rows.Count = 0 Then
                DGPelanggan.DataSource = tblpelanggan
                CariDataTxt.Focus()
            Else
                DGPelanggan.DataSource = tblpelanggan
            End If
        End If
    End Sub

    Private Sub DgPelanggan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGPelanggan.DoubleClick
        KdPelangganTxt.Text = DGPelanggan.SelectedCells(0).Value
        NmPelangganTxt.Text = DGPelanggan.SelectedCells(1).Value
        AlmTxt.Text = DGPelanggan.SelectedCells(2).Value
        TlpTxt.Text = DGPelanggan.SelectedCells(3).Value
        SimpanBtn.Enabled = False : UbahBtn.Enabled = True : HapusBtn.Enabled = True
        BatalBtn.Enabled = True : TutupBtn.Enabled = False
    End Sub


    Private Sub CariKdPelanggan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariKdPelanggan.CheckedChanged
        CariDataTxt.Focus()
    End Sub


    Private Sub CariNmPelanggan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariNmPelanggan.CheckedChanged
        CariDataTxt.Focus()
    End Sub


End Class













