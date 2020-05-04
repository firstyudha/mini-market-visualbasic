Public Class FrmSupplier
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblsuplier As DataTable

    Sub Data_Record()
        tblsuplier = Proses.ExecuteQuery("Select * From TblSupplier order by Kode_Supplier Asc")
        DGSupplier.DataSource = tblsuplier
        DGSupplier.Columns(1).Width = 150
        DGSupplier.Columns(2).Width = 435
    End Sub

    Sub Kode_Otomatis()
        tblsuplier = Proses.ExecuteQuery("Select * From TblSupplier order by Kode_Supplier desc")
        If tblsuplier.Rows.Count = 0 Then
            KdSupplierTxt.Text = "KS-001"
        Else
            With tblsuplier.Rows(0)
                KdSupplierTxt.Text = .Item("Kode_Supplier")
            End With
            KdSupplierTxt.Text = Val(Microsoft.VisualBasic.Mid(KdSupplierTxt.Text, 4, 3)) + 1
            If Len(KdSupplierTxt.Text) = 1 Then
                KdSupplierTxt.Text = "KS-00" & KdSupplierTxt.Text & ""
            ElseIf Len(KdSupplierTxt.Text) = 2 Then
                KdSupplierTxt.Text = "KS-0" & KdSupplierTxt.Text & ""
            ElseIf Len(KdSupplierTxt.Text) = 3 Then
                KdSupplierTxt.Text = "KS-" & KdSupplierTxt.Text & ""
            End If
        End If
    End Sub

    Sub Bersih()
        KdSupplierTxt.Text = ""
        NmSupplierTxt.Text = ""
        AlmTxt.Text = ""
        TlpTxt.Text = ""
        KontakTxt.Text = ""
        NmSupplierTxt.Focus()
        Call Kode_Otomatis()
        Call Data_Record()
        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
    End Sub

    Private Sub FrmSuplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = 0
        Me.Left = 0
        Call Bersih()
    End Sub

    Private Sub Dgsuplier_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGSupplier.DoubleClick
        KdSupplierTxt.Text = DGSupplier.SelectedCells(0).Value
        NmSupplierTxt.Text = DGSupplier.SelectedCells(1).Value
        AlmTxt.Text = DGSupplier.SelectedCells(2).Value
        TlpTxt.Text = DGSupplier.SelectedCells(3).Value
        KontakTxt.Text = DGSupplier.SelectedCells(4).Value
        SimpanBtn.Enabled = False : UbahBtn.Enabled = True : HapusBtn.Enabled = True
        BatalBtn.Enabled = True : TutupBtn.Enabled = False
    End Sub

    Private Sub CariKdsuplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariKdSupplier.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub CariNmsuplier_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariNmSupplier.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub Carikota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariKontak.CheckedChanged
        CariDataTxt.Focus()
    End Sub

    Private Sub CariDataTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariDataTxt.TextChanged
        If CariKdSupplier.Checked = True Then
            tblsuplier = Proses.ExecuteQuery("Select * From TblSupplier Where Kode_Supplier Like '%" & CariDataTxt.Text & "%'")
            If tblsuplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblsuplier
                CariDataTxt.Focus()
            Else
                DGSupplier.DataSource = tblsuplier
            End If


        ElseIf CariNmSupplier.Checked = True Then
            tblsuplier = Proses.ExecuteQuery("Select * From TblSupplier Where Nama_Supplier Like '%" & CariDataTxt.Text & "%'")
            If tblsuplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblsuplier
                CariDataTxt.Focus()
            Else
                DGSupplier.DataSource = tblsuplier
            End If

        ElseIf CariKontak.Checked = True Then
            tblsuplier = Proses.ExecuteQuery("Select * From TblSupplier Where kontak Like '%" & CariDataTxt.Text & "%'")
            If tblsuplier.Rows.Count = 0 Then
                DGSupplier.DataSource = tblsuplier
                CariDataTxt.Focus()
            Else
                DGSupplier.DataSource = tblsuplier
            End If
        End If
    End Sub


    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If KdSupplierTxt.Text = "" Then KdSupplierTxt.Focus() : Exit Sub
        If NmSupplierTxt.Text = "" Then NmSupplierTxt.Focus() : Exit Sub
        If AlmTxt.Text = "" Then AlmTxt.Focus() : Exit Sub
        If TlpTxt.Text = "" Then TlpTxt.Focus() : Exit Sub
        If KontakTxt.Text = "" Then KontakTxt.Focus() : Exit Sub


        SQL = "Insert Into TblSupplier Values ('" & KdSupplierTxt.Text & "','" & NmSupplierTxt.Text & "' ,'" & AlmTxt.Text & "','" & TlpTxt.Text & "' ,'" &
KontakTxt.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses",
       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If NmSupplierTxt.Text = "" Then NmSupplierTxt.Focus() : Exit Sub
        If AlmTxt.Text = "" Then AlmTxt.Focus() : Exit Sub
        If TlpTxt.Text = "" Then TlpTxt.Focus() : Exit Sub
        If KontakTxt.Text = "" Then KontakTxt.Focus() : Exit Sub

        SQL = "Update TblSupplier Set Nama_Supplier = '" & NmSupplierTxt.Text & "', Alamat = '" & AlmTxt.Text & "', Telepon = '" & TlpTxt.Text & "',Kontak ='" & KontakTxt.Text & "' where Kode_Supplier = '" & KdSupplierTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah diubah..!!", "Perubahan Data Sukses",
       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub HapusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusBtn.Click
        SQL = "Delete From Tblsupplier Where Kode_Supplier = '" & KdSupplierTxt.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses",
       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        Call Bersih()
        KdSupplierTxt.Focus()
    End Sub

    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub
End Class