<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPenjualan
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblFaktur = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtJml = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblHrg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblNmBarang = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGPenjualan = New System.Windows.Forms.DataGridView()
        Me.CmbPelanggan = New System.Windows.Forms.ComboBox()
        Me.LblNmPelanggan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblSubTotal = New System.Windows.Forms.TextBox()
        Me.BarangTxt = New System.Windows.Forms.TextBox()
        Me.LblTotHrga = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(428, 76)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Faktur Penjualan"
        '
        'LblFaktur
        '
        Me.LblFaktur.Location = New System.Drawing.Point(554, 73)
        Me.LblFaktur.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblFaktur.Name = "LblFaktur"
        Me.LblFaktur.Size = New System.Drawing.Size(178, 20)
        Me.LblFaktur.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(797, 175)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Enter"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(686, 154)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Jumlah Beli"
        '
        'TxtJml
        '
        Me.TxtJml.Location = New System.Drawing.Point(689, 172)
        Me.TxtJml.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtJml.Name = "TxtJml"
        Me.TxtJml.Size = New System.Drawing.Size(104, 20)
        Me.TxtJml.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(573, 154)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Stock"
        '
        'LblStock
        '
        Me.LblStock.Location = New System.Drawing.Point(577, 172)
        Me.LblStock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(104, 20)
        Me.LblStock.TabIndex = 31
        Me.LblStock.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(459, 154)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Harga"
        '
        'LblHrg
        '
        Me.LblHrg.Location = New System.Drawing.Point(463, 172)
        Me.LblHrg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblHrg.Name = "LblHrg"
        Me.LblHrg.Size = New System.Drawing.Size(104, 20)
        Me.LblHrg.TabIndex = 29
        Me.LblHrg.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(271, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Nama Barang"
        '
        'LblNmBarang
        '
        Me.LblNmBarang.Location = New System.Drawing.Point(275, 172)
        Me.LblNmBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblNmBarang.Name = "LblNmBarang"
        Me.LblNmBarang.Size = New System.Drawing.Size(178, 20)
        Me.LblNmBarang.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(25, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(26, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Nm Pelanggan"
        '
        'DGPenjualan
        '
        Me.DGPenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPenjualan.Location = New System.Drawing.Point(28, 215)
        Me.DGPenjualan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGPenjualan.Name = "DGPenjualan"
        Me.DGPenjualan.Size = New System.Drawing.Size(765, 182)
        Me.DGPenjualan.TabIndex = 23
        '
        'CmbPelanggan
        '
        Me.CmbPelanggan.FormattingEnabled = True
        Me.CmbPelanggan.Location = New System.Drawing.Point(173, 72)
        Me.CmbPelanggan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbPelanggan.Name = "CmbPelanggan"
        Me.CmbPelanggan.Size = New System.Drawing.Size(178, 21)
        Me.CmbPelanggan.TabIndex = 22
        '
        'LblNmPelanggan
        '
        Me.LblNmPelanggan.Location = New System.Drawing.Point(173, 113)
        Me.LblNmPelanggan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblNmPelanggan.Name = "LblNmPelanggan"
        Me.LblNmPelanggan.Size = New System.Drawing.Size(178, 20)
        Me.LblNmPelanggan.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(26, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Pelanggan"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(531, 420)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 15)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Sub Total"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.Location = New System.Drawing.Point(615, 418)
        Me.LblSubTotal.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(178, 20)
        Me.LblSubTotal.TabIndex = 38
        Me.LblSubTotal.Text = "0"
        '
        'BarangTxt
        '
        Me.BarangTxt.Location = New System.Drawing.Point(89, 172)
        Me.BarangTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BarangTxt.Name = "BarangTxt"
        Me.BarangTxt.Size = New System.Drawing.Size(178, 20)
        Me.BarangTxt.TabIndex = 40
        '
        'LblTotHrga
        '
        Me.LblTotHrga.BackColor = System.Drawing.Color.Yellow
        Me.LblTotHrga.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotHrga.ForeColor = System.Drawing.Color.Red
        Me.LblTotHrga.Location = New System.Drawing.Point(1, 0)
        Me.LblTotHrga.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblTotHrga.Multiline = True
        Me.LblTotHrga.Name = "LblTotHrga"
        Me.LblTotHrga.Size = New System.Drawing.Size(841, 42)
        Me.LblTotHrga.TabIndex = 41
        Me.LblTotHrga.Text = "0"
        Me.LblTotHrga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(25, 422)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(366, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "[F1] - BAYAR | [F2] - BARANG | [F3] - BATAL | [ESC] - KELUAR"
        '
        'FrmPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 456)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblTotHrga)
        Me.Controls.Add(Me.BarangTxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LblSubTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblFaktur)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtJml)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblHrg)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblNmBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGPenjualan)
        Me.Controls.Add(Me.CmbPelanggan)
        Me.Controls.Add(Me.LblNmPelanggan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPenjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        CType(Me.DGPenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtJml As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblStock As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblHrg As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblNmBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DGPenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents CmbPelanggan As System.Windows.Forms.ComboBox
    Friend WithEvents LblNmPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents BarangTxt As System.Windows.Forms.TextBox
    Friend WithEvents LblTotHrga As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
