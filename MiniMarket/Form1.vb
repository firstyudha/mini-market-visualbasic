Public Class FrmMenuUtama

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TsPengguna.Click

    End Sub

    Private Sub PenggunaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenggunaToolStripMenuItem.Click
        FrmPengguna.MdiParent = Me
        FrmPengguna.Show()
    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahPasswordToolStripMenuItem.Click
        FrmUbahPassword.MdiParent = Me
        FrmUbahPassword.Show()
    End Sub

    Private Sub HakAksesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HakAksesToolStripMenuItem.Click
        FrmHakAkses.MdiParent = Me
        FrmHakAkses.Show()
    End Sub

    Private Sub KelompokToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KelompokToolStripMenuItem.Click
        FrmKelompok.MdiParent = Me
        FrmKelompok.Show()
    End Sub

    Private Sub SatuanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SatuanToolStripMenuItem.Click
        FrmSatuan.MdiParent = Me
        FrmSatuan.Show()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FrmBarang.MdiParent = Me
        FrmBarang.Show()
    End Sub

    Private Sub SuplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuplierToolStripMenuItem.Click
        FrmSupplier.MdiParent = Me
        FrmSupplier.Show()
    End Sub

    Private Sub PelangganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PelangganToolStripMenuItem.Click
        FrmPelanggan.MdiParent = Me
        FrmPelanggan.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        FrmPembelian.MdiParent = Me
        FrmPembelian.Show()
    End Sub

    Private Sub HistoryPembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryPembelianToolStripMenuItem.Click
        FrmHistoryPembelilan.MdiParent = Me
        FrmHistoryPembelilan.Show()
    End Sub

    Private Sub PenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjualanToolStripMenuItem.Click
        FrmPenjualan.MdiParent = Me
        FrmPenjualan.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()
        FrmLogin.Show()
        
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub HistoryPenjualanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryPenjualanToolStripMenuItem.Click
        FrmHistoryPenjualan.MdiParent = Me
        FrmHistoryPenjualan.Show()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FrmPengguna.MdiParent = Me
        FrmPengguna.Show()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        FrmBarang.MdiParent = Me
        FrmBarang.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        FrmSupplier.MdiParent = Me
        FrmSupplier.Show()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        FrmPelanggan.MdiParent = Me
        FrmPelanggan.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        FrmPembelian.MdiParent = Me
        FrmPembelian.Show()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        FrmPenjualan.MdiParent = Me
        FrmPenjualan.Show()
    End Sub
End Class
