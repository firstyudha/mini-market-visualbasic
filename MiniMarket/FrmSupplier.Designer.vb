<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSupplier))
        Me.DGSupplier = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.CariKontak = New System.Windows.Forms.RadioButton()
        Me.CariNmSupplier = New System.Windows.Forms.RadioButton()
        Me.CariKdSupplier = New System.Windows.Forms.RadioButton()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NmSupplierTxt = New System.Windows.Forms.TextBox()
        Me.KdSupplierTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AlmTxt = New System.Windows.Forms.TextBox()
        Me.KontakTxt = New System.Windows.Forms.TextBox()
        Me.TlpTxt = New System.Windows.Forms.TextBox()
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGSupplier
        '
        Me.DGSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSupplier.Location = New System.Drawing.Point(26, 282)
        Me.DGSupplier.Name = "DGSupplier"
        Me.DGSupplier.Size = New System.Drawing.Size(925, 184)
        Me.DGSupplier.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.CariKontak)
        Me.GroupBox1.Controls.Add(Me.CariNmSupplier)
        Me.GroupBox1.Controls.Add(Me.CariKdSupplier)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 53)
        Me.GroupBox1.TabIndex = 44
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
        'CariKontak
        '
        Me.CariKontak.AutoSize = True
        Me.CariKontak.Location = New System.Drawing.Point(211, 19)
        Me.CariKontak.Name = "CariKontak"
        Me.CariKontak.Size = New System.Drawing.Size(59, 17)
        Me.CariKontak.TabIndex = 2
        Me.CariKontak.TabStop = True
        Me.CariKontak.Text = "Kontak"
        Me.CariKontak.UseVisualStyleBackColor = True
        '
        'CariNmSupplier
        '
        Me.CariNmSupplier.AutoSize = True
        Me.CariNmSupplier.Location = New System.Drawing.Point(115, 19)
        Me.CariNmSupplier.Name = "CariNmSupplier"
        Me.CariNmSupplier.Size = New System.Drawing.Size(94, 17)
        Me.CariNmSupplier.TabIndex = 1
        Me.CariNmSupplier.TabStop = True
        Me.CariNmSupplier.Text = "Nama Supplier"
        Me.CariNmSupplier.UseVisualStyleBackColor = True
        '
        'CariKdSupplier
        '
        Me.CariKdSupplier.AutoSize = True
        Me.CariKdSupplier.Location = New System.Drawing.Point(22, 19)
        Me.CariKdSupplier.Name = "CariKdSupplier"
        Me.CariKdSupplier.Size = New System.Drawing.Size(91, 17)
        Me.CariKdSupplier.TabIndex = 0
        Me.CariKdSupplier.TabStop = True
        Me.CariKdSupplier.Text = "Kode Supplier"
        Me.CariKdSupplier.UseVisualStyleBackColor = True
        '
        'TutupBtn
        '
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutupBtn.Location = New System.Drawing.Point(545, 137)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(55, 52)
        Me.TutupBtn.TabIndex = 43
        Me.TutupBtn.Text = "tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BatalBtn.Location = New System.Drawing.Point(484, 137)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(55, 52)
        Me.BatalBtn.TabIndex = 42
        Me.BatalBtn.Text = "batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Image = CType(resources.GetObject("HapusBtn.Image"), System.Drawing.Image)
        Me.HapusBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.HapusBtn.Location = New System.Drawing.Point(423, 137)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(55, 52)
        Me.HapusBtn.TabIndex = 41
        Me.HapusBtn.Text = "hapus"
        Me.HapusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.Image = CType(resources.GetObject("UbahBtn.Image"), System.Drawing.Image)
        Me.UbahBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UbahBtn.Location = New System.Drawing.Point(362, 136)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(55, 53)
        Me.UbahBtn.TabIndex = 40
        Me.UbahBtn.Text = "ubah"
        Me.UbahBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
        Me.SimpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimpanBtn.Location = New System.Drawing.Point(301, 137)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(55, 52)
        Me.SimpanBtn.TabIndex = 39
        Me.SimpanBtn.Text = "simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(27, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Telepon:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Kontak:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Nm Supplier:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = " Kd Suppler:"
        '
        'NmSupplierTxt
        '
        Me.NmSupplierTxt.Location = New System.Drawing.Point(118, 44)
        Me.NmSupplierTxt.Name = "NmSupplierTxt"
        Me.NmSupplierTxt.Size = New System.Drawing.Size(130, 20)
        Me.NmSupplierTxt.TabIndex = 25
        '
        'KdSupplierTxt
        '
        Me.KdSupplierTxt.Location = New System.Drawing.Point(118, 15)
        Me.KdSupplierTxt.Name = "KdSupplierTxt"
        Me.KdSupplierTxt.Size = New System.Drawing.Size(85, 20)
        Me.KdSupplierTxt.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Alamat:"
        '
        'AlmTxt
        '
        Me.AlmTxt.Location = New System.Drawing.Point(118, 71)
        Me.AlmTxt.Multiline = True
        Me.AlmTxt.Name = "AlmTxt"
        Me.AlmTxt.Size = New System.Drawing.Size(130, 57)
        Me.AlmTxt.TabIndex = 47
        '
        'KontakTxt
        '
        Me.KontakTxt.Location = New System.Drawing.Point(118, 169)
        Me.KontakTxt.Name = "KontakTxt"
        Me.KontakTxt.Size = New System.Drawing.Size(130, 20)
        Me.KontakTxt.TabIndex = 48
        '
        'TlpTxt
        '
        Me.TlpTxt.Location = New System.Drawing.Point(118, 145)
        Me.TlpTxt.Name = "TlpTxt"
        Me.TlpTxt.Size = New System.Drawing.Size(130, 20)
        Me.TlpTxt.TabIndex = 49
        '
        'FrmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 492)
        Me.Controls.Add(Me.TlpTxt)
        Me.Controls.Add(Me.KontakTxt)
        Me.Controls.Add(Me.AlmTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGSupplier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NmSupplierTxt)
        Me.Controls.Add(Me.KdSupplierTxt)
        Me.Name = "FrmSupplier"
        Me.Text = "Supplier"
        CType(Me.DGSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGSupplier As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents CariKontak As System.Windows.Forms.RadioButton
    Friend WithEvents CariNmSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents CariKdSupplier As System.Windows.Forms.RadioButton
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NmSupplierTxt As System.Windows.Forms.TextBox
    Friend WithEvents KdSupplierTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AlmTxt As System.Windows.Forms.TextBox
    Friend WithEvents KontakTxt As System.Windows.Forms.TextBox
    Friend WithEvents TlpTxt As System.Windows.Forms.TextBox
End Class
