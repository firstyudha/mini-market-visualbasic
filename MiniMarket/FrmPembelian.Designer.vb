<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPembelian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPembelian))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNmSuplier = New System.Windows.Forms.TextBox()
        Me.CmbSupplier = New System.Windows.Forms.ComboBox()
        Me.DGPembelian = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbBarang = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblNmBarang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblHrg = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblStock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtJml = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblFaktur = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblTotHrgKotor = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DiscTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblTotHrgBersih = New System.Windows.Forms.TextBox()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Supplier"
        '
        'LblNmSuplier
        '
        Me.LblNmSuplier.Location = New System.Drawing.Point(200, 92)
        Me.LblNmSuplier.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblNmSuplier.Name = "LblNmSuplier"
        Me.LblNmSuplier.Size = New System.Drawing.Size(178, 22)
        Me.LblNmSuplier.TabIndex = 1
        '
        'CmbSupplier
        '
        Me.CmbSupplier.FormattingEnabled = True
        Me.CmbSupplier.Location = New System.Drawing.Point(200, 51)
        Me.CmbSupplier.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbSupplier.Name = "CmbSupplier"
        Me.CmbSupplier.Size = New System.Drawing.Size(178, 23)
        Me.CmbSupplier.TabIndex = 2
        '
        'DGPembelian
        '
        Me.DGPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPembelian.Location = New System.Drawing.Point(55, 194)
        Me.DGPembelian.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DGPembelian.Name = "DGPembelian"
        Me.DGPembelian.Size = New System.Drawing.Size(765, 182)
        Me.DGPembelian.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(53, 92)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(52, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Barang"
        '
        'CmbBarang
        '
        Me.CmbBarang.FormattingEnabled = True
        Me.CmbBarang.Location = New System.Drawing.Point(114, 151)
        Me.CmbBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.CmbBarang.Name = "CmbBarang"
        Me.CmbBarang.Size = New System.Drawing.Size(178, 23)
        Me.CmbBarang.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(298, 133)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nama Barang"
        '
        'LblNmBarang
        '
        Me.LblNmBarang.Location = New System.Drawing.Point(302, 151)
        Me.LblNmBarang.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblNmBarang.Name = "LblNmBarang"
        Me.LblNmBarang.Size = New System.Drawing.Size(178, 22)
        Me.LblNmBarang.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(486, 133)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Harga"
        '
        'LblHrg
        '
        Me.LblHrg.Location = New System.Drawing.Point(490, 151)
        Me.LblHrg.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblHrg.Name = "LblHrg"
        Me.LblHrg.Size = New System.Drawing.Size(104, 22)
        Me.LblHrg.TabIndex = 11
        Me.LblHrg.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(600, 133)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 15)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Stock"
        '
        'LblStock
        '
        Me.LblStock.Location = New System.Drawing.Point(604, 151)
        Me.LblStock.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(104, 22)
        Me.LblStock.TabIndex = 13
        Me.LblStock.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(713, 133)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Jumlah Beli"
        '
        'TxtJml
        '
        Me.TxtJml.Location = New System.Drawing.Point(716, 151)
        Me.TxtJml.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TxtJml.Name = "TxtJml"
        Me.TxtJml.Size = New System.Drawing.Size(104, 22)
        Me.TxtJml.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(824, 154)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Enter"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(455, 55)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Faktur Pembelian"
        '
        'LblFaktur
        '
        Me.LblFaktur.Location = New System.Drawing.Point(581, 52)
        Me.LblFaktur.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblFaktur.Name = "LblFaktur"
        Me.LblFaktur.Size = New System.Drawing.Size(178, 22)
        Me.LblFaktur.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(520, 404)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Harga Kotor :"
        '
        'LblTotHrgKotor
        '
        Me.LblTotHrgKotor.Location = New System.Drawing.Point(642, 396)
        Me.LblTotHrgKotor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblTotHrgKotor.Name = "LblTotHrgKotor"
        Me.LblTotHrgKotor.Size = New System.Drawing.Size(178, 22)
        Me.LblTotHrgKotor.TabIndex = 21
        Me.LblTotHrgKotor.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(520, 442)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 15)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Diskon % :"
        '
        'DiscTxt
        '
        Me.DiscTxt.Location = New System.Drawing.Point(642, 434)
        Me.DiscTxt.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DiscTxt.Name = "DiscTxt"
        Me.DiscTxt.Size = New System.Drawing.Size(178, 22)
        Me.DiscTxt.TabIndex = 23
        Me.DiscTxt.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(520, 482)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 15)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Harga Bersih :"
        '
        'LblTotHrgBersih
        '
        Me.LblTotHrgBersih.Location = New System.Drawing.Point(642, 478)
        Me.LblTotHrgBersih.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblTotHrgBersih.Name = "LblTotHrgBersih"
        Me.LblTotHrgBersih.Size = New System.Drawing.Size(178, 22)
        Me.LblTotHrgBersih.TabIndex = 25
        Me.LblTotHrgBersih.Text = "0"
        '
        'BatalBtn
        '
        Me.BatalBtn.ForeColor = System.Drawing.Color.DimGray
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BatalBtn.Location = New System.Drawing.Point(138, 404)
        Me.BatalBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(74, 60)
        Me.BatalBtn.TabIndex = 61
        Me.BatalBtn.Text = "batal"
        Me.BatalBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.ForeColor = System.Drawing.Color.DimGray
        Me.SimpanBtn.Image = CType(resources.GetObject("SimpanBtn.Image"), System.Drawing.Image)
        Me.SimpanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.SimpanBtn.Location = New System.Drawing.Point(56, 404)
        Me.SimpanBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(74, 60)
        Me.SimpanBtn.TabIndex = 60
        Me.SimpanBtn.Text = "simpan"
        Me.SimpanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("News701 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(27, 9)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(274, 23)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "Form Transaksi Pembelian"
        '
        'FrmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.shopping_879498_1920
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(869, 563)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LblTotHrgBersih)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DiscTxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblTotHrgKotor)
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
        Me.Controls.Add(Me.CmbBarang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGPembelian)
        Me.Controls.Add(Me.CmbSupplier)
        Me.Controls.Add(Me.LblNmSuplier)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("News706 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembelian"
        CType(Me.DGPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblNmSuplier As System.Windows.Forms.TextBox
    Friend WithEvents CmbSupplier As System.Windows.Forms.ComboBox
    Friend WithEvents DGPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbBarang As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblNmBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblHrg As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LblStock As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtJml As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LblFaktur As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblTotHrgKotor As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DiscTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblTotHrgBersih As System.Windows.Forms.TextBox
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
