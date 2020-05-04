Public Class FrmKelompok
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblkelompok As DataTable

    Sub Data_Record()
        tblkelompok = Proses.ExecuteQuery("select * from TblKelompok order by No asc")
        DGKelompok.DataSource = tblkelompok
        DGKelompok.Columns(1).Width = 130
    End Sub

    Sub Kode_Otomatis()
        tblkelompok = Proses.ExecuteQuery("select * from TblKelompok order by No desc")
        If tblkelompok.Rows.Count = 0 Then
            KdKelompokTxt.Text = "KLP-001"
        Else
            With tblkelompok.Rows(0)
                KdKelompokTxt.Text = .Item("No")
            End With

            KdKelompokTxt.Text = Val(Microsoft.VisualBasic.Mid(KdKelompokTxt.Text, 5)) + 1
            If Len(KdKelompokTxt.Text) = 1 Then
                KdKelompokTxt.Text = "KLP-00" & KdKelompokTxt.Text & ""
            ElseIf Len(KdKelompokTxt.Text) = 2 Then
                KdKelompokTxt.Text = "KLP-0" & KdKelompokTxt.Text & ""
            ElseIf Len(KdKelompokTxt.Text) = 3 Then
                KdKelompokTxt.Text = "KLP-" & KdKelompokTxt.Text & ""
            End If
        End If
    End Sub

    Sub bersih()
        Call Data_Record()
        Call Kode_Otomatis()
        SimpanBtn.Enabled = True
        UbahBtn.Enabled = False
        HapusBtn.Enabled = False
        KdKelompokTxt.Enabled = False
        KelompokTxt.Text = ""
        KelompokTxt.Focus()
    End Sub


    Private Sub FrmKelompok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersih()
    End Sub

    Private Sub SimpanBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanBtn.Click
        If KelompokTxt.Text = "" Then KelompokTxt.Focus() : Exit Sub
        SQL = "Insert into TblKelompok Values ('" & KdKelompokTxt.Text & "','" & KelompokTxt.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        Call bersih()
    End Sub

    Private Sub UbahBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahBtn.Click
        If KelompokTxt.Text = "" Then KelompokTxt.Focus() : Exit Sub
        SQL = " Update TblKelompok set Kelompok = '" & KelompokTxt.Text & "' where No = '" & KdKelompokTxt.Text & "' "
        Proses.ExecuteNonQuery(SQL)
        Call bersih()
    End Sub

    Private Sub HapusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusBtn.Click
        SQL = "Delete from TblKelompok where No = '" & KdKelompokTxt.Text & "' "
        Proses.ExecuteNonQuery(SQL)
        Call bersih()
    End Sub

    Private Sub DGKelompok_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGKelompok.DoubleClick
        KdKelompokTxt.Text = DGKelompok.SelectedCells(0).Value
        KelompokTxt.Text = DGKelompok.SelectedCells(1).Value

        UbahBtn.Enabled = True
        HapusBtn.Enabled = True
        SimpanBtn.Enabled = False

    End Sub
End Class