Public Class FrmPembelian
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblBeli As DataTable
    Dim disc As Single

    Sub Data_Record()
        tblBeli = Proses.ExecuteQuery("Select No, Kode_Barang, Nama_Barang, Harga_Beli,Jumlah, Sub_Total From TblPembelian_Rinci where Faktur_Pembelian = '" & LblFaktur.Text & "' order by TblPembelian_Rinci.No asc")
        DGPembelian.DataSource = tblBeli
        DGPembelian.Columns(0).Width = 50
        DGPembelian.Columns(1).Width = 98
        DGPembelian.Columns(2).Width = 150
        DGPembelian.Columns(4).Width = 50
    End Sub

    Sub Suplier()
        tblBeli = Proses.ExecuteQuery("Select * From TblSupplier order by Kode_Supplier Asc ")
        If tblBeli.Rows.Count = 0 Then
        Else
            CmbSupplier.Items.Clear()
            With tblBeli.Columns(1)
                For a = 0 To tblBeli.Rows.Count - 1
                    CmbSupplier.Items.Add(.Table.Rows(a).Item(0) + "/" +
                   .Table.Rows(a).Item(1))
                Next a
            End With
        End If
    End Sub

    Sub Barang()
        tblBeli = Proses.ExecuteQuery("Select * From TblBarang order by Kode_Barang Asc ")
        If tblBeli.Rows.Count = 0 Then
        Else
            CmbBarang.Items.Clear()
            With tblBeli.Columns(1)
                For a = 0 To tblBeli.Rows.Count - 1
                    CmbBarang.Items.Add(.Table.Rows(a).Item(0) + "/" +
                   .Table.Rows(a).Item(2))
                Next a
            End With
        End If
    End Sub

    Sub Bersih()
        CmbBarang.Text = ""
        LblNmBarang.Text = ""
        LblHrg.Text = ""
        LblStock.Text = ""
        TxtJml.Text = ""
        CmbSupplier.Enabled = True
        CmbBarang.Enabled = True
        CmbBarang.Focus()
        Call Suplier()
        Call Barang()
        Call Faktur_Otomatis()
        Call Data_Record()
        On Error Resume Next
        Dim Total_seluruh As Single
        Dim i As Integer
        i = DGPembelian.CurrentRow.Index
        For i = 0 To DGPembelian.Rows.Count - 1
            Total_seluruh = Val(Total_seluruh) + Val(DGPembelian.Item(5, i).Value)
        Next
        LblTotHrgKotor.Text = Total_seluruh.ToString("#,#")
    End Sub

    Sub Faktur_Otomatis()
        tblBeli = Proses.ExecuteQuery("Select * From TblPembelian order by Faktur_Pembelian desc")
        If tblBeli.Rows.Count = 0 Then
            LblFaktur.Text = "0001"
        Else
            With tblBeli.Rows(0)
                LblFaktur.Text = .Item("Faktur_Pembelian")
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

    Private Sub FrmPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Bersih()
        SimpanBtn.Enabled = False
    End Sub

    Private Sub CmbSuplier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbSupplier.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub CmbSuplier_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbSupplier.TextChanged
        tblBeli = Proses.ExecuteQuery("Select * From TblSupplier where Kode_Supplier = '" & Mid(CmbSupplier.Text, 1, 6) & "'")
        If tblBeli.Rows.Count = 0 Then
        Else
            LblNmSuplier.Text = tblBeli.Rows(0).Item("Nama_Supplier")
        End If
    End Sub

    Private Sub CmbBarang_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CmbBarang.KeyPress
        e.KeyChar = Chr(0)
    End Sub

    Private Sub CmbBarang_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmbBarang.TextChanged
        tblBeli = Proses.ExecuteQuery("Select * From TblBarang where Kode_Barang = '" &
       Mid(CmbBarang.Text, 1, 6) & "'")
        If tblBeli.Rows.Count = 0 Then
        Else
            LblNmBarang.Text = tblBeli.Rows(0).Item("Nama_Barang")
            LblHrg.Text = tblBeli.Rows(0).Item("Harga_Beli")

            LblStock.Text = tblBeli.Rows(0).Item("Stock")
            TxtJml.Focus()
        End If
    End Sub

    Private Sub TxtJml_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJml.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TxtJml.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                tblBeli = Proses.ExecuteQuery("select * from TblPembelian_Rinci where Faktur_Pembelian = '" & LblFaktur.Text & "' and Kode_Barang = '" & Mid(CmbBarang.Text, 1, 6) & "'")
                If tblBeli.Rows.Count = 0 Then
                    Dim total = Val(LblHrg.Text) * Val(TxtJml.Text)
                    SQL = "Insert Into TblPembelian_Rinci Values ('" & LblFaktur.Text &
                    "','" & DGPembelian.RowCount & "','" & Mid(CmbBarang.Text, 1, 6) & "','" &
                    LblNmBarang.Text & "','" & LblHrg.Text & "' ,'" & TxtJml.Text & "','" & total & "')"
                    Proses.ExecuteNonQuery(SQL)

                    SimpanBtn.Enabled = True
                Else
                    MsgBox("Proses pembelian tidak dapat dilakukan !")
                End If
                Call Bersih()
                Dim Total_seluruh As Single
                Dim i As Integer
                i = DGPembelian.CurrentRow.Index
                For i = 0 To DGPembelian.Rows.Count - 1
                    Total_seluruh = Val(Total_seluruh) + Val(DGPembelian.Item(5, i).Value)
                Next
                LblTotHrgKotor.Text = Total_seluruh.ToString("#,#")
                disc = (Val(Total_seluruh * (DiscTxt.Text / 100)))
                LblTotHrgBersih.Text = (Val(Total_seluruh) - Val(disc)).ToString("#,#")
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub

    Private Sub DiscTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiscTxt.TextChanged
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"
        Dim disc = (Val(LblTotHrgKotor.Text * (DiscTxt.Text / 100)))
        LblTotHrgBersih.Text = (LblTotHrgKotor.Text - disc).ToString("#,#")
    End Sub

    Private Sub LblTotHrgBersih_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblTotHrgBersih.TextChanged
        If LblTotHrgBersih.Text = "" Then LblTotHrgBersih.Text = "0"
    End Sub
    Private Sub BatalBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo Keluar
        Dim i As Integer
        i = DGPembelian.CurrentRow.Index
        For i = 0 To DGPembelian.Rows.Count - 1
            tblBeli = Proses.ExecuteQuery("select * from TblBarang where Kode_Barang ='" & DGPembelian.Item(2, i).Value & "'")
            If tblBeli.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(tblBeli.Rows(0).Item("Stock")) -
               Val(DGPembelian.Item(4, i).Value)
                SQL = "update TblBarang set Stock = '" & CInt(Jumlah) & "' where Kode_Barang = '" & DGPembelian.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next

        SQL = "delete from TblPembelian_Rinci where Faktur_Pembelian ='" & LblFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        LblTotHrgKotor.Text = "0"
        DiscTxt.Text = "0"
        LblTotHrgBersih.Text = "0"
        Call Bersih()
Keluar:
    End Sub
    Private Sub SimpanBtn_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If LblTotHrgKotor.Text = "0" Then Exit Sub
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"
        SQL = "Insert Into TblPembelian Values ('" & LblFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & Microsoft.VisualBasic.Left(CmbSupplier.Text, 6) & "','" & DiscTxt.Text & "','" & Replace(LblTotHrgBersih.Text, ",", "") & "')"
        Proses.ExecuteNonQuery(SQL)
        Call Bersih()
        CmbSupplier.Text = ""
        LblNmSuplier.Text = ""
        LblTotHrgKotor.Text = "0"
        LblTotHrgBersih.Text = "0"
        DiscTxt.Text = "0"
        CmbSupplier.Focus()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub BatalBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalBtn.Click
        On Error GoTo Keluar
        Dim i As Integer
        i = DGPembelian.CurrentRow.Index
        For i = 0 To DGPembelian.Rows.Count - 1
            tblBeli = Proses.ExecuteQuery("select * from TblBarang where Kode_Barang ='" & DGPembelian.Item(2, i).Value & "'")
            If tblBeli.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(tblBeli.Rows(0).Item("Stock")) -
               Val(DGPembelian.Item(4, i).Value)
                SQL = "update TblBarang set Stock = '" & CInt(Jumlah) & "' where Kode_Barang = '" & DGPembelian.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next

        SQL = "delete from TblPembelian_Rinci where Faktur_Pembelian ='" & LblFaktur.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        LblTotHrgKotor.Text = "0"
        DiscTxt.Text = "0"
        LblTotHrgBersih.Text = "0"
        Call Bersih()
Keluar:
    End Sub


    Private Sub DGPembelian_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGPembelian.CellContentClick

    End Sub

    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If LblTotHrgKotor.Text = "0" Then Exit Sub
        If DiscTxt.Text = "" Then DiscTxt.Text = "0"
        SQL = "Insert Into TblPembelian Values ('" & LblFaktur.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & Microsoft.VisualBasic.Left(CmbSupplier.Text, 6) & "','" & DiscTxt.Text & "','" & Replace(LblTotHrgBersih.Text, ",", "") & "')"
        Proses.ExecuteNonQuery(SQL)
        Call Bersih()
        CmbSupplier.Text = ""
        LblNmSuplier.Text = ""
        LblTotHrgKotor.Text = "0"
        LblTotHrgBersih.Text = "0"
        DiscTxt.Text = "0"
        CmbSupplier.Focus()
    End Sub
End Class


