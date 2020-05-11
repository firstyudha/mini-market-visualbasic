Public Class FrmHistoryPembelilan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblhistorypembelian As DataTable

    Sub Data_Record()
        tblhistorypembelian = Proses.ExecuteQuery("Select * From v_history_pembelian order by Faktur_Pembelian asc")
        DGHistoryPembelian.DataSource = tblhistorypembelian
        DGHistoryPembelian.Columns(1).Width = 185
        DGHistoryPembelian.Columns(2).Width = 285
    End Sub
    Private Sub CariDataTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CariDataTxt.TextChanged
        If Rbfaktur.Checked = True Then
            tblhistorypembelian = Proses.ExecuteQuery("Select * From v_history_pembelian Where Faktur_Pembelian Like '%" & CariDataTxt.Text & "%'")
            If tblhistorypembelian.Rows.Count = 0 Then
                DGHistoryPembelian.DataSource = tblhistorypembelian
                CariDataTxt.Focus()
            Else
                DGHistoryPembelian.DataSource = tblhistorypembelian
            End If

        ElseIf RbkdBarang.Checked = True Then
            tblhistorypembelian = Proses.ExecuteQuery("Select * From v_history_pembelian Where Kode_Barang Like '%" & CariDataTxt.Text & "%'")
            If tblhistorypembelian.Rows.Count = 0 Then
                DGHistoryPembelian.DataSource = tblhistorypembelian
                CariDataTxt.Focus()
            Else
                DGHistoryPembelian.DataSource = tblhistorypembelian
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