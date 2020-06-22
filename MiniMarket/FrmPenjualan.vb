Public Class FrmPenjualan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tbljual As DataTable
    Private Sub FrmPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Data_Record()
        Call Bersih()

    End Sub

    Sub Data_Record()
        tbljual = Proses.ExecuteQuery("Select TblPenjualan_Rinci.No, TblPenjualan_Rinci.Kode_Barcode, TblBarang.Nama_Barang, TblPenjualan_Rinci.Harga_Jual,TblPenjualan_Rinci.Jumlah, TblPenjualan_Rinci.Sub_Total From TblPenjualan_Rinci inner join TblBarang on TblPenjualan_Rinci.Kode_Barcode = TblBarang.Kode_Barcode where TblPenjualan_Rinci.Faktur_Penjualan = '" & LblFaktur.Text & "' order by TblPenjualan_Rinci.No asc")
        DGPenjualan.DataSource = tbljual
        DGPenjualan.Columns(0).Width = 50
        DGPenjualan.Columns(1).Width = 98
        DGPenjualan.Columns(2).Width = 150
        DGPenjualan.Columns(4).Width = 50
    End Sub    Sub Pelanggan()
        tbljual = Proses.ExecuteQuery("Select * From TblPelanggan order by Kode_Pelanggan asc")
        If tbljual.Rows.Count = 0 Then
        Else
            CmbPelanggan.Items.Clear()
            With tbljual.Columns(1)
                For a = 0 To tbljual.Rows.Count - 1
                    CmbPelanggan.Items.Add(.Table.Rows(a).Item(0) + "/" +
                   .Table.Rows(a).Item(1))
                Next a
            End With
        End If
    End Sub    Sub Bersih()
        BarangTxt.Text = ""
        LblNmBarang.Text = ""
        LblHrg.Text = ""
        LblStock.Text = ""
        TxtJml.Text = ""
        CmbPelanggan.Enabled = True
        BarangTxt.Enabled = True
        BarangTxt.Focus()
        Call Pelanggan()
        Call Faktur_Otomatis()
        Call Data_Record()
        On Error Resume Next
        Dim Total_seluruh As Single
        Dim i As Integer
        i = DGPenjualan.CurrentRow.Index
        For i = 0 To DGPenjualan.Rows.Count - 1
            Total_seluruh = Val(Total_seluruh) + Val(DGPenjualan.Item(5, i).Value)
        Next
        LblSubTotal.Text = Total_seluruh.ToString("#,#")
        'LblTotHrga.Text = LblSubTotal.Text
    End Sub    Sub Faktur_Otomatis()
        tbljual = Proses.ExecuteQuery("Select * From TblPenjualan order by Faktur_Penjualan desc")
        If tbljual.Rows.Count = 0 Then
            LblFaktur.Text = "0001"
        Else
            With tbljual.Rows(0)
                LblFaktur.Text = .Item("Faktur_Penjualan")
            End With
            LblFaktur.Text = Val(LblFaktur.Text) + 1
            If Len(LblFaktur.Text) = 1 Then
                LblFaktur.Text = "000" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 2 Then
                LblFaktur.Text = "00" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 3 Then
                LblFaktur.Text = "0" & LblFaktur.Text & ""
            ElseIf Len(LblFaktur.Text) = 4 Then
                LblFaktur.Text = "" & LblFaktur.Text & ""
            End If
        End If
    End Sub
    Private Sub CmbPelanggan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbPelanggan.KeyPress
        e.KeyChar = Chr(0)
    End Sub    Private Sub CmbPelanggan_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbPelanggan.TextChanged
        tbljual = Proses.ExecuteQuery("Select * From TblPelanggan where Kode_Pelanggan = '" & Mid(CmbPelanggan.Text, 1, 6) & "'")
        If tbljual.Rows.Count = 0 Then
        Else
            LblNmPelanggan.Text = tbljual.Rows(0).Item("Nama_Pelanggan")
        End If
    End Sub    Private Sub TxtJml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJml.KeyPress
        If TxtJml.Text = "" Or TxtJml.Text = "0" Then Exit Sub
        If Val(LblStock.Text) < Val(TxtJml.Text) Then MsgBox("Stock tidak mencukupi !",
       MsgBoxStyle.Critical, "Message") : TxtJml.Text = "0" : Exit Sub
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TxtJml.Focus()            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                tbljual = Proses.ExecuteQuery("select * from TblPenjualan_Rinci where Faktur_Penjualan = '" & LblFaktur.Text & "' and Kode_Barcode = '" & BarangTxt.Text & "'")
                If tbljual.Rows.Count = 0 Then
                    Dim total = Val(LblHrg.Text) * Val(TxtJml.Text)
                    SQL = "Insert Into TblPenjualan_Rinci Values ('" & LblFaktur.Text & "','" & DGPenjualan.RowCount & "','" & BarangTxt.Text & "','" & LblHrg.Text & "' ,'" & TxtJml.Text & "','" & total & "')"
                    Proses.ExecuteNonQuery(SQL)
                Else
                    MsgBox("Proses penjualan tidak dapat dilakukan !")
                    BarangTxt.Text = ""
                    BarangTxt.Focus()
                    Exit Sub
                End If                Call Bersih()
                Dim Total_seluruh As Single
                Dim i As Integer
                i = DGPenjualan.CurrentRow.Index
                For i = 0 To DGPenjualan.Rows.Count - 1
                    Total_seluruh = Val(Total_seluruh) + Val(DGPenjualan.Item(5,i).Value)
                Next
                LblSubTotal.Text = Total_seluruh.ToString("#,#")
                LblTotHrga.Text = LblSubTotal.Text            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo Keluar
        Dim i As Integer
        i = DGPenjualan.CurrentRow.Index
        For i = 0 To DGPenjualan.Rows.Count - 1
            tbljual = Proses.ExecuteQuery("select * from TblBarang where Kode_Barcode ='" & DGPenjualan.Item(2, i).Value & "'")
            If tbljual.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(tbljual.Rows(0).Item("stock")) +
               Val(DGPenjualan.Item(4, i).Value)
                SQL = "update TblBarang set Stock = '" & CInt(Jumlah) & "' where Kode_Barcode = '" & DGPenjualan.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next        SQL = "delete from TblPenjualan_Rinci where Faktur_Penjualan ='" & LblFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        LblSubTotal.Text = "Rp,"
        Call Bersih()
Keluar:

    End Sub    Private Sub BarangTxt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BarangTxt.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim Sub_Total As Single
            Sub_Total = Replace(LblSubTotal.Text, ".", "")
            FrmBayar.LblSubTotal.Text = Sub_Total.ToString("#,#")
            FrmBayar.LblGrandTotal.Text = Sub_Total.ToString("#,#")
            FrmBayar.ShowDialog()        ElseIf e.KeyCode = Keys.F2 Then
            FrmBarang.ShowDialog()        ElseIf e.KeyCode = Keys.F3 Then
            'On Error GoTo Keluar
            Dim i As Integer
            i = DGPenjualan.CurrentRow.Index
            For i = 0 To DGPenjualan.Rows.Count - 1
                tbljual = Proses.ExecuteQuery("select * from TblBarang where Kode_Barcode = '" & DGPenjualan.Item(2, i).Value & "'")
                If tbljual.Rows.Count = 0 Then
                Else
                    Dim Jumlah = Val(tbljual.Rows(0).Item("Stock")) +
                   Val(DGPenjualan.Item(4, i).Value)
                    SQL = "update TblBarang set Stock = '" & CInt(Jumlah) & "' where Kode_Barcode = '" & DGPenjualan.Item(2, i).Value & "'"
                    Proses.ExecuteNonQuery(SQL)
                End If
            Next
            SQL = "delete from TblPenjualan_Rinci where Faktur_Penjualan ='" &
           LblFaktur.Text & "'"
            Proses.ExecuteNonQuery(SQL)
            LblSubTotal.Text = "Rp,"
            LblTotHrga.Text = 0
            Call Bersih()        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub    Private Sub BarangTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangTxt.TextChanged
        tbljual = Proses.ExecuteQuery("Select * From TblBarang where kode_barcode = '" & BarangTxt.Text & "'")
        If tbljual.Rows.Count = 0 Then
        Else
            LblNmBarang.Text = tbljual.Rows(0).Item("Nama_Barang")
            LblHrg.Text = tbljual.Rows(0).Item("Harga_Jual")
            LblStock.Text = tbljual.Rows(0).Item("Stock")
            TxtJml.Focus()
        End If
    End Sub
    Private Sub CmbPelanggan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbPelanggan.SelectedIndexChanged

    End Sub

    Private Sub LblNmPelanggan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblNmPelanggan.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class