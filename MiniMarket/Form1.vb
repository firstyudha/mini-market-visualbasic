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
End Class
