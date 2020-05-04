<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHakAkses
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbLevel = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ChkPengguna = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ChkPenjualan = New System.Windows.Forms.CheckBox()
        Me.ChkPembelian = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChkPelanggan = New System.Windows.Forms.CheckBox()
        Me.ChkSupplier = New System.Windows.Forms.CheckBox()
        Me.ChkBarang = New System.Windows.Forms.CheckBox()
        Me.ChkSatuan = New System.Windows.Forms.CheckBox()
        Me.ChkJenis = New System.Windows.Forms.CheckBox()
        Me.ChkAkses = New System.Windows.Forms.CheckBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Level:"
        '
        'CmbLevel
        '
        Me.CmbLevel.FormattingEnabled = True
        Me.CmbLevel.Location = New System.Drawing.Point(60, 26)
        Me.CmbLevel.Name = "CmbLevel"
        Me.CmbLevel.Size = New System.Drawing.Size(121, 21)
        Me.CmbLevel.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkPengguna)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 87)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sistem"
        '
        'ChkPengguna
        '
        Me.ChkPengguna.AutoSize = True
        Me.ChkPengguna.Location = New System.Drawing.Point(6, 31)
        Me.ChkPengguna.Name = "ChkPengguna"
        Me.ChkPengguna.Size = New System.Drawing.Size(75, 17)
        Me.ChkPengguna.TabIndex = 0
        Me.ChkPengguna.Text = "Pengguna"
        Me.ChkPengguna.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkPenjualan)
        Me.GroupBox2.Controls.Add(Me.ChkPembelian)
        Me.GroupBox2.Location = New System.Drawing.Point(202, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 87)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transaksi"
        '
        'ChkPenjualan
        '
        Me.ChkPenjualan.AutoSize = True
        Me.ChkPenjualan.Location = New System.Drawing.Point(6, 54)
        Me.ChkPenjualan.Name = "ChkPenjualan"
        Me.ChkPenjualan.Size = New System.Drawing.Size(104, 17)
        Me.ChkPenjualan.TabIndex = 1
        Me.ChkPenjualan.Text = "Penjualan - kasir"
        Me.ChkPenjualan.UseVisualStyleBackColor = True
        '
        'ChkPembelian
        '
        Me.ChkPembelian.AutoSize = True
        Me.ChkPembelian.Location = New System.Drawing.Point(6, 31)
        Me.ChkPembelian.Name = "ChkPembelian"
        Me.ChkPembelian.Size = New System.Drawing.Size(75, 17)
        Me.ChkPembelian.TabIndex = 0
        Me.ChkPembelian.Text = "Pembelian"
        Me.ChkPembelian.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ChkPelanggan)
        Me.GroupBox3.Controls.Add(Me.ChkSupplier)
        Me.GroupBox3.Controls.Add(Me.ChkBarang)
        Me.GroupBox3.Controls.Add(Me.ChkSatuan)
        Me.GroupBox3.Controls.Add(Me.ChkJenis)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(160, 172)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Master Data"
        '
        'ChkPelanggan
        '
        Me.ChkPelanggan.AutoSize = True
        Me.ChkPelanggan.Location = New System.Drawing.Point(6, 145)
        Me.ChkPelanggan.Name = "ChkPelanggan"
        Me.ChkPelanggan.Size = New System.Drawing.Size(77, 17)
        Me.ChkPelanggan.TabIndex = 4
        Me.ChkPelanggan.Text = "Pelanggan"
        Me.ChkPelanggan.UseVisualStyleBackColor = True
        '
        'ChkSupplier
        '
        Me.ChkSupplier.AutoSize = True
        Me.ChkSupplier.Location = New System.Drawing.Point(6, 122)
        Me.ChkSupplier.Name = "ChkSupplier"
        Me.ChkSupplier.Size = New System.Drawing.Size(64, 17)
        Me.ChkSupplier.TabIndex = 3
        Me.ChkSupplier.Text = "Supplier"
        Me.ChkSupplier.UseVisualStyleBackColor = True
        '
        'ChkBarang
        '
        Me.ChkBarang.AutoSize = True
        Me.ChkBarang.Location = New System.Drawing.Point(6, 99)
        Me.ChkBarang.Name = "ChkBarang"
        Me.ChkBarang.Size = New System.Drawing.Size(60, 17)
        Me.ChkBarang.TabIndex = 2
        Me.ChkBarang.Text = "Barang"
        Me.ChkBarang.UseVisualStyleBackColor = True
        '
        'ChkSatuan
        '
        Me.ChkSatuan.AutoSize = True
        Me.ChkSatuan.Location = New System.Drawing.Point(6, 54)
        Me.ChkSatuan.Name = "ChkSatuan"
        Me.ChkSatuan.Size = New System.Drawing.Size(60, 17)
        Me.ChkSatuan.TabIndex = 1
        Me.ChkSatuan.Text = "Satuan"
        Me.ChkSatuan.UseVisualStyleBackColor = True
        '
        'ChkJenis
        '
        Me.ChkJenis.AutoSize = True
        Me.ChkJenis.Location = New System.Drawing.Point(6, 31)
        Me.ChkJenis.Name = "ChkJenis"
        Me.ChkJenis.Size = New System.Drawing.Size(87, 17)
        Me.ChkJenis.TabIndex = 0
        Me.ChkJenis.Text = "Jenis Barang"
        Me.ChkJenis.UseVisualStyleBackColor = True
        '
        'ChkAkses
        '
        Me.ChkAkses.AutoSize = True
        Me.ChkAkses.Location = New System.Drawing.Point(208, 386)
        Me.ChkAkses.Name = "ChkAkses"
        Me.ChkAkses.Size = New System.Drawing.Size(78, 17)
        Me.ChkAkses.TabIndex = 5
        Me.ChkAkses.Text = "Hak Akses"
        Me.ChkAkses.UseVisualStyleBackColor = True
        '
        'OkBtn
        '
        Me.OkBtn.Location = New System.Drawing.Point(21, 380)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 23)
        Me.OkBtn.TabIndex = 6
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'FrmHakAkses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 443)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.ChkAkses)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CmbLevel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmHakAkses"
        Me.Text = "Hak Akses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPengguna As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPenjualan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPembelian As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkPelanggan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSupplier As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBarang As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSatuan As System.Windows.Forms.CheckBox
    Friend WithEvents ChkJenis As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAkses As System.Windows.Forms.CheckBox
    Friend WithEvents OkBtn As System.Windows.Forms.Button
End Class
