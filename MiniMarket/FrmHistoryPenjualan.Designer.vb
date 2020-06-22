<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoryPenjualan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistoryPenjualan))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGHistoryPenjualan = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.RbkdPelanggan = New System.Windows.Forms.RadioButton()
        Me.Rbfaktur = New System.Windows.Forms.RadioButton()
        Me.TutupBtn = New System.Windows.Forms.Button()
        CType(Me.DGHistoryPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("News701 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 23)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "History Transaksi Pembelian"
        '
        'DGHistoryPenjualan
        '
        Me.DGHistoryPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGHistoryPenjualan.Location = New System.Drawing.Point(31, 144)
        Me.DGHistoryPenjualan.Margin = New System.Windows.Forms.Padding(4)
        Me.DGHistoryPenjualan.Name = "DGHistoryPenjualan"
        Me.DGHistoryPenjualan.Size = New System.Drawing.Size(693, 188)
        Me.DGHistoryPenjualan.TabIndex = 69
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.RbkdPelanggan)
        Me.GroupBox1.Controls.Add(Me.Rbfaktur)
        Me.GroupBox1.Font = New System.Drawing.Font("News701 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(31, 75)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(609, 62)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cari Berdasarkan"
        '
        'CariDataTxt
        '
        Me.CariDataTxt.Location = New System.Drawing.Point(292, 25)
        Me.CariDataTxt.Margin = New System.Windows.Forms.Padding(4)
        Me.CariDataTxt.Name = "CariDataTxt"
        Me.CariDataTxt.Size = New System.Drawing.Size(269, 22)
        Me.CariDataTxt.TabIndex = 22
        '
        'RbkdPelanggan
        '
        Me.RbkdPelanggan.AutoSize = True
        Me.RbkdPelanggan.Location = New System.Drawing.Point(144, 28)
        Me.RbkdPelanggan.Margin = New System.Windows.Forms.Padding(4)
        Me.RbkdPelanggan.Name = "RbkdPelanggan"
        Me.RbkdPelanggan.Size = New System.Drawing.Size(124, 19)
        Me.RbkdPelanggan.TabIndex = 1
        Me.RbkdPelanggan.TabStop = True
        Me.RbkdPelanggan.Text = "Kode Pelanggan"
        Me.RbkdPelanggan.UseVisualStyleBackColor = True
        '
        'Rbfaktur
        '
        Me.Rbfaktur.AutoSize = True
        Me.Rbfaktur.Font = New System.Drawing.Font("News701 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbfaktur.Location = New System.Drawing.Point(29, 26)
        Me.Rbfaktur.Margin = New System.Windows.Forms.Padding(4)
        Me.Rbfaktur.Name = "Rbfaktur"
        Me.Rbfaktur.Size = New System.Drawing.Size(68, 19)
        Me.Rbfaktur.TabIndex = 0
        Me.Rbfaktur.TabStop = True
        Me.Rbfaktur.Text = "Faktur"
        Me.Rbfaktur.UseVisualStyleBackColor = True
        '
        'TutupBtn
        '
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutupBtn.Location = New System.Drawing.Point(648, 75)
        Me.TutupBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(76, 62)
        Me.TutupBtn.TabIndex = 70
        Me.TutupBtn.Text = "tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'FrmHistoryPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.digital_marketing_1433427_1920
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(756, 365)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.DGHistoryPenjualan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmHistoryPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History Penjualan"
        CType(Me.DGHistoryPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents DGHistoryPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents RbkdPelanggan As System.Windows.Forms.RadioButton
    Friend WithEvents Rbfaktur As System.Windows.Forms.RadioButton
End Class
