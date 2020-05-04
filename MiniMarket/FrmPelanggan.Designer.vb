<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPelanggan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPelanggan))
        Me.TlpTxt = New System.Windows.Forms.TextBox()
        Me.AlmTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGPelanggan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.CariNmPelanggan = New System.Windows.Forms.RadioButton()
        Me.CariKdPelanggan = New System.Windows.Forms.RadioButton()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NmPelangganTxt = New System.Windows.Forms.TextBox()
        Me.KdPelangganTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TlpTxt
        '
        Me.TlpTxt.Location = New System.Drawing.Point(107, 147)
        Me.TlpTxt.Name = "TlpTxt"
        Me.TlpTxt.Size = New System.Drawing.Size(130, 20)
        Me.TlpTxt.TabIndex = 66
        '
        'AlmTxt
        '
        Me.AlmTxt.Location = New System.Drawing.Point(107, 73)
        Me.AlmTxt.Multiline = True
        Me.AlmTxt.Name = "AlmTxt"
        Me.AlmTxt.Size = New System.Drawing.Size(130, 57)
        Me.AlmTxt.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Alamat:"
        '
        'DGPelanggan
        '
        Me.DGPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPelanggan.Location = New System.Drawing.Point(15, 260)
        Me.DGPelanggan.Name = "DGPelanggan"
        Me.DGPelanggan.Size = New System.Drawing.Size(767, 184)
        Me.DGPelanggan.TabIndex = 62
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariNmPelanggan)
        Me.GroupBox1.Controls.Add(Me.CariKdPelanggan)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 201)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 53)
        Me.GroupBox1.TabIndex = 61
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
        'CariNmPelanggan
        '
        Me.CariNmPelanggan.AutoSize = True
        Me.CariNmPelanggan.Location = New System.Drawing.Point(132, 19)
        Me.CariNmPelanggan.Name = "CariNmPelanggan"
        Me.CariNmPelanggan.Size = New System.Drawing.Size(107, 17)
        Me.CariNmPelanggan.TabIndex = 1
        Me.CariNmPelanggan.TabStop = True
        Me.CariNmPelanggan.Text = "Nama Pelanggan"
        Me.CariNmPelanggan.UseVisualStyleBackColor = True
        '
        'CariKdPelanggan
        '
        Me.CariKdPelanggan.AutoSize = True
        Me.CariKdPelanggan.Location = New System.Drawing.Point(22, 19)
        Me.CariKdPelanggan.Name = "CariKdPelanggan"
        Me.CariKdPelanggan.Size = New System.Drawing.Size(104, 17)
        Me.CariKdPelanggan.TabIndex = 0
        Me.CariKdPelanggan.TabStop = True
        Me.CariKdPelanggan.Text = "Kode Pelanggan"
        Me.CariKdPelanggan.UseVisualStyleBackColor = True
        '
        'TutupBtn
        '
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutupBtn.Location = New System.Drawing.Point(532, 115)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(55, 52)
        Me.TutupBtn.TabIndex = 60
        Me.TutupBtn.Text = "tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BatalBtn.Location = New System.Drawing.Point(471, 115)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(55, 52)
        Me.BatalBtn.TabIndex = 59
        Me.BatalBtn.Text = "batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Image = CType(resources.GetObject("HapusBtn.Image"), System.Drawing.Image)
        Me.HapusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HapusBtn.Location = New System.Drawing.Point(410, 115)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(55, 52)
        Me.HapusBtn.TabIndex = 58
        Me.HapusBtn.Text = "hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.Image = CType(resources.GetObject("UbahBtn.Image"), System.Drawing.Image)
        Me.UbahBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UbahBtn.Location = New System.Drawing.Point(349, 114)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(55, 53)
        Me.UbahBtn.TabIndex = 57
        Me.UbahBtn.Text = "ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
        Me.SimpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimpanBtn.Location = New System.Drawing.Point(288, 115)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(55, 52)
        Me.SimpanBtn.TabIndex = 56
        Me.SimpanBtn.Text = "simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Telepon:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Nm Pelanggan:"
        '
        'NmPelangganTxt
        '
        Me.NmPelangganTxt.Location = New System.Drawing.Point(107, 46)
        Me.NmPelangganTxt.Name = "NmPelangganTxt"
        Me.NmPelangganTxt.Size = New System.Drawing.Size(130, 20)
        Me.NmPelangganTxt.TabIndex = 51
        '
        'KdPelangganTxt
        '
        Me.KdPelangganTxt.Location = New System.Drawing.Point(107, 17)
        Me.KdPelangganTxt.Name = "KdPelangganTxt"
        Me.KdPelangganTxt.Size = New System.Drawing.Size(85, 20)
        Me.KdPelangganTxt.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Kd Pelanggan:"
        '
        'FrmPelanggan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 470)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TlpTxt)
        Me.Controls.Add(Me.AlmTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGPelanggan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NmPelangganTxt)
        Me.Controls.Add(Me.KdPelangganTxt)
        Me.Name = "FrmPelanggan"
        Me.Text = "Pelanggan"
        CType(Me.DGPelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TlpTxt As System.Windows.Forms.TextBox
    Friend WithEvents AlmTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DGPelanggan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents CariNmPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NmPelangganTxt As System.Windows.Forms.TextBox
    Friend WithEvents KdPelangganTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
