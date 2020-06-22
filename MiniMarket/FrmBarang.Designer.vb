<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBarang))
        Me.KdBarangTxt = New System.Windows.Forms.TextBox()
        Me.BarcodeTxt = New System.Windows.Forms.TextBox()
        Me.NmBarangTxt = New System.Windows.Forms.TextBox()
        Me.StockLbl = New System.Windows.Forms.TextBox()
        Me.HrgJualTxt = New System.Windows.Forms.TextBox()
        Me.HrgBeliTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CmKelompok = New System.Windows.Forms.ComboBox()
        Me.CmbSatuan = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.CariStock = New System.Windows.Forms.RadioButton()
        Me.CariNmBarang = New System.Windows.Forms.RadioButton()
        Me.CariKdBarang = New System.Windows.Forms.RadioButton()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'KdBarangTxt
        '
        Me.KdBarangTxt.Location = New System.Drawing.Point(119, 15)
        Me.KdBarangTxt.Name = "KdBarangTxt"
        Me.KdBarangTxt.Size = New System.Drawing.Size(85, 20)
        Me.KdBarangTxt.TabIndex = 0
        '
        'BarcodeTxt
        '
        Me.BarcodeTxt.Location = New System.Drawing.Point(119, 41)
        Me.BarcodeTxt.Name = "BarcodeTxt"
        Me.BarcodeTxt.Size = New System.Drawing.Size(130, 20)
        Me.BarcodeTxt.TabIndex = 1
        '
        'NmBarangTxt
        '
        Me.NmBarangTxt.Location = New System.Drawing.Point(119, 67)
        Me.NmBarangTxt.Name = "NmBarangTxt"
        Me.NmBarangTxt.Size = New System.Drawing.Size(130, 20)
        Me.NmBarangTxt.TabIndex = 2
        '
        'StockLbl
        '
        Me.StockLbl.Location = New System.Drawing.Point(376, 67)
        Me.StockLbl.Name = "StockLbl"
        Me.StockLbl.Size = New System.Drawing.Size(100, 20)
        Me.StockLbl.TabIndex = 5
        '
        'HrgJualTxt
        '
        Me.HrgJualTxt.Location = New System.Drawing.Point(376, 41)
        Me.HrgJualTxt.Name = "HrgJualTxt"
        Me.HrgJualTxt.Size = New System.Drawing.Size(100, 20)
        Me.HrgJualTxt.TabIndex = 4
        '
        'HrgBeliTxt
        '
        Me.HrgBeliTxt.Location = New System.Drawing.Point(376, 15)
        Me.HrgBeliTxt.Name = "HrgBeliTxt"
        Me.HrgBeliTxt.Size = New System.Drawing.Size(100, 20)
        Me.HrgBeliTxt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = " Kd Barang:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nm Barang:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Barcode:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(300, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Hrg Jual:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(300, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Stock:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Hrg Beli:"
        '
        'CmKelompok
        '
        Me.CmKelompok.FormattingEnabled = True
        Me.CmKelompok.Location = New System.Drawing.Point(119, 94)
        Me.CmKelompok.Name = "CmKelompok"
        Me.CmKelompok.Size = New System.Drawing.Size(121, 21)
        Me.CmKelompok.TabIndex = 12
        '
        'CmbSatuan
        '
        Me.CmbSatuan.FormattingEnabled = True
        Me.CmbSatuan.Location = New System.Drawing.Point(119, 121)
        Me.CmbSatuan.Name = "CmbSatuan"
        Me.CmbSatuan.Size = New System.Drawing.Size(121, 21)
        Me.CmbSatuan.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Satuan:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Kelompok:"
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
        Me.SimpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimpanBtn.Location = New System.Drawing.Point(303, 99)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(55, 52)
        Me.SimpanBtn.TabIndex = 16
        Me.SimpanBtn.Text = "simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.Image = CType(resources.GetObject("UbahBtn.Image"), System.Drawing.Image)
        Me.UbahBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UbahBtn.Location = New System.Drawing.Point(364, 98)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(55, 53)
        Me.UbahBtn.TabIndex = 17
        Me.UbahBtn.Text = "ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Image = CType(resources.GetObject("HapusBtn.Image"), System.Drawing.Image)
        Me.HapusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HapusBtn.Location = New System.Drawing.Point(425, 99)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(55, 52)
        Me.HapusBtn.TabIndex = 18
        Me.HapusBtn.Text = "hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BatalBtn.Location = New System.Drawing.Point(486, 99)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(55, 52)
        Me.BatalBtn.TabIndex = 19
        Me.BatalBtn.Text = "batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'TutupBtn
        '
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutupBtn.Location = New System.Drawing.Point(547, 99)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(55, 52)
        Me.TutupBtn.TabIndex = 20
        Me.TutupBtn.Text = "tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariStock)
        Me.GroupBox1.Controls.Add(Me.CariNmBarang)
        Me.GroupBox1.Controls.Add(Me.CariKdBarang)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 53)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariDataTxt
        '
        Me.CariDataTxt.Location = New System.Drawing.Point(293, 19)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(253, 20)
        Me.CariDataTxt.TabIndex = 22
        '
        'CariStock
        '
        Me.CariStock.AutoSize = True
        Me.CariStock.Location = New System.Drawing.Point(211, 19)
        Me.CariStock.Name = "CariStock"
        Me.CariStock.Size = New System.Drawing.Size(53, 17)
        Me.CariStock.TabIndex = 2
        Me.CariStock.TabStop = True
        Me.CariStock.Text = "Stock"
        Me.CariStock.UseVisualStyleBackColor = True
        '
        'CariNmBarang
        '
        Me.CariNmBarang.AutoSize = True
        Me.CariNmBarang.Location = New System.Drawing.Point(115, 19)
        Me.CariNmBarang.Name = "CariNmBarang"
        Me.CariNmBarang.Size = New System.Drawing.Size(90, 17)
        Me.CariNmBarang.TabIndex = 1
        Me.CariNmBarang.TabStop = True
        Me.CariNmBarang.Text = "Nama Barang"
        Me.CariNmBarang.UseVisualStyleBackColor = True
        '
        'CariKdBarang
        '
        Me.CariKdBarang.AutoSize = True
        Me.CariKdBarang.Location = New System.Drawing.Point(22, 19)
        Me.CariKdBarang.Name = "CariKdBarang"
        Me.CariKdBarang.Size = New System.Drawing.Size(87, 17)
        Me.CariKdBarang.TabIndex = 0
        Me.CariKdBarang.TabStop = True
        Me.CariKdBarang.Text = "Kode Barang"
        Me.CariKdBarang.UseVisualStyleBackColor = True
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(30, 229)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(925, 184)
        Me.DGBarang.TabIndex = 22
        '
        'FrmBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 425)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CmbSatuan)
        Me.Controls.Add(Me.CmKelompok)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StockLbl)
        Me.Controls.Add(Me.HrgJualTxt)
        Me.Controls.Add(Me.HrgBeliTxt)
        Me.Controls.Add(Me.NmBarangTxt)
        Me.Controls.Add(Me.BarcodeTxt)
        Me.Controls.Add(Me.KdBarangTxt)
        Me.Name = "FrmBarang"
        Me.Text = "Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KdBarangTxt As System.Windows.Forms.TextBox
    Friend WithEvents BarcodeTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmBarangTxt As System.Windows.Forms.TextBox
    Friend WithEvents StockLbl As System.Windows.Forms.TextBox
    Friend WithEvents HrgJualTxt As System.Windows.Forms.TextBox
    Friend WithEvents HrgBeliTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CmKelompok As System.Windows.Forms.ComboBox
    Friend WithEvents CmbSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariNmBarang As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdBarang As System.Windows.Forms.RadioButton
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents CariStock As System.Windows.Forms.RadioButton
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
End Class
