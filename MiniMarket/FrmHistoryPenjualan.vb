Public Class FrmHistoryPenjualan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblhistorypenjualan As DataTable

    Sub Data_Record()
        tblhistorypenjualan = Proses.ExecuteQuery("Select * From v_history_penjualan order by Faktur_Penjualan asc")
        DGHistoryPenjualan.DataSource = tblhistorypenjualan
        DGHistoryPenjualan.Columns(1).Width = 185
        DGHistoryPenjualan.Columns(2).Width = 285
    End Sub
    Private Sub CariDataTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariDataTxt.TextChanged
        If Rbfaktur.Checked = True Then
            tblhistorypenjualan = Proses.ExecuteQuery("Select * From v_history_penjualan Where Faktur_Penjualan Like '%" & CariDataTxt.Text & "%'")
            If tblhistorypenjualan.Rows.Count = 0 Then
                DGHistoryPenjualan.DataSource = tblhistorypenjualan
                CariDataTxt.Focus()
            Else
                DGHistoryPenjualan.DataSource = tblhistorypenjualan
            End If

        ElseIf RbkdPelanggan.Checked = True Then
            tblhistorypenjualan = Proses.ExecuteQuery("Select * From v_history_penjualan Where Kode_Pelanggan Like '%" & CariDataTxt.Text & "%'")
            If tblhistorypenjualan.Rows.Count = 0 Then
                DGHistoryPenjualan.DataSource = tblhistorypenjualan
                CariDataTxt.Focus()
            Else
                DGHistoryPenjualan.DataSource = tblhistorypenjualan
            End If
        End If
    End Sub

    Private Sub FrmHistoryPembelilan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Data_Record()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TutupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupBtn.Click
        Me.Close()
    End Sub
End Class