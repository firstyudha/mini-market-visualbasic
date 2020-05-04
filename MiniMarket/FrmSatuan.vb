Public Class FrmSatuan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblsatuan As DataTable

    Sub Data_Record()
        tblsatuan = Proses.ExecuteQuery("select * from TblSatuan order by No asc")
        DGSatuan.DataSource = tblsatuan
        DGSatuan.Columns(1).Width = 130
    End Sub

    Sub Kode_Otomatis()
        tblsatuan = Proses.ExecuteQuery("select * from TblSatuan order by No desc")
        If tblsatuan.Rows.Count = 0 Then
            KdSatuanTxt.Text = "STN-001"
        Else
            With tblsatuan.Rows(0)
                KdSatuanTxt.Text = .Item("No")
            End With

            KdSatuanTxt.Text = Val(Microsoft.VisualBasic.Mid(KdSatuanTxt.Text, 5)) + 1
            If Len(KdSatuanTxt.Text) = 1 Then
                KdSatuanTxt.Text = "STN-00" & KdSatuanTxt.Text & ""
            ElseIf Len(KdSatuanTxt.Text) = 2 Then
                KdSatuanTxt.Text = "STN-0" & KdSatuanTxt.Text & ""
            ElseIf Len(KdSatuanTxt.Text) = 3 Then
                KdSatuanTxt.Text = "STN-" & KdSatuanTxt.Text & ""
            End If
        End If
    End Sub

    Sub bersih()
        Call Data_Record()
        Call Kode_Otomatis()
        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
        KdSatuanTxt.Enabled = False
        SatuanTxt.Text = ""
        SatuanTxt.Focus()
    End Sub


    Private Sub FrmSatuan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersih()

    End Sub

    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If SatuanTxt.Text = "" Then SatuanTxt.Focus() : Exit Sub
        SQL = "Insert into TblSatuan Values ('" & KdSatuanTxt.Text & "','" & SatuanTxt.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        Call bersih()
    End Sub

    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If SatuanTxt.Text = "" Then SatuanTxt.Focus() : Exit Sub
        SQL = " Update TblSatuan set Satuan = '" & SatuanTxt.Text & "' where No = '" & KdSatuanTxt.Text & "' "
        Proses.ExecuteNonQuery(SQL)
        Call bersih()
    End Sub

    Private Sub HapusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusBtn.Click
        SQL = "Delete from TblSatuan where No = '" & KdSatuanTxt.Text & "' "
        Proses.ExecuteNonQuery(SQL)
        Call bersih()
    End Sub

    Private Sub DGSatuan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGSatuan.DoubleClick
        KdSatuanTxt.Text = DGSatuan.SelectedCells(0).Value
        SatuanTxt.Text = DGSatuan.SelectedCells(1).Value

        UbahBtn.Enabled = True
        HapusBtn.Enabled = True
        SimpanBtn.Enabled = False

    End Sub


End Class