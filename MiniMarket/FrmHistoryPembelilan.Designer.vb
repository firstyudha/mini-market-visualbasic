<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistoryPembelilan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistoryPembelilan))
        Me.DGHistoryPembelian = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CariDataTxt = New System.Windows.Forms.TextBox()
        Me.RbkdBarang = New System.Windows.Forms.RadioButton()
        Me.Rbfaktur = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TutupBtn = New System.Windows.Forms.Button()
        CType(Me.DGHistoryPembelian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGHistoryPembelian
        '
        Me.DGHistoryPembelian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGHistoryPembelian.Location = New System.Drawing.Point(28, 143)
        Me.DGHistoryPembelian.Margin = New System.Windows.Forms.Padding(4)
        Me.DGHistoryPembelian.Name = "DGHistoryPembelian"
        Me.DGHistoryPembelian.Size = New System.Drawing.Size(693, 188)
        Me.DGHistoryPembelian.TabIndex = 64
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DimGray
        Me.GroupBox1.Controls.Add(Me.CariDataTxt)
        Me.GroupBox1.Controls.Add(Me.RbkdBarang)
        Me.GroupBox1.Controls.Add(Me.Rbfaktur)
        Me.GroupBox1.Font = New System.Drawing.Font("News701 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(28, 74)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(609, 62)
        Me.GroupBox1.TabIndex = 63
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
        'RbkdBarang
        '
        Me.RbkdBarang.AutoSize = True
        Me.RbkdBarang.Location = New System.Drawing.Point(144, 28)
        Me.RbkdBarang.Margin = New System.Windows.Forms.Padding(4)
        Me.RbkdBarang.Name = "RbkdBarang"
        Me.RbkdBarang.Size = New System.Drawing.Size(105, 19)
        Me.RbkdBarang.TabIndex = 1
        Me.RbkdBarang.TabStop = True
        Me.RbkdBarang.Text = "Kode Barang"
        Me.RbkdBarang.UseVisualStyleBackColor = True
        '
        'Rbfaktur
        '
        Me.Rbfaktur.AutoSize = True
        Me.Rbfaktur.Font = New System.Drawing.Font("News701 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rbfaktur.Location = New System.Drawing.Point(29, 22)
        Me.Rbfaktur.Margin = New System.Windows.Forms.Padding(4)
        Me.Rbfaktur.Name = "Rbfaktur"
        Me.Rbfaktur.Size = New System.Drawing.Size(68, 19)
        Me.Rbfaktur.TabIndex = 0
        Me.Rbfaktur.TabStop = True
        Me.Rbfaktur.Text = "Faktur"
        Me.Rbfaktur.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("News701 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(293, 23)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "History Transaksi Pembelian"
        '
        'TutupBtn
        '
        Me.TutupBtn.Image = CType(resources.GetObject("TutupBtn.Image"), System.Drawing.Image)
        Me.TutupBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TutupBtn.Location = New System.Drawing.Point(645, 74)
        Me.TutupBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(76, 62)
        Me.TutupBtn.TabIndex = 66
        Me.TutupBtn.Text = "tutup"
        Me.TutupBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'FrmHistoryPembelilan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.MiniMarket.My.Resources.Resources.digital_marketing_1433427_1920
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(747, 371)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.DGHistoryPembelian)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("News701 BT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmHistoryPembelilan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History Pembelian"
        CType(Me.DGHistoryPembelian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGHistoryPembelian As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CariDataTxt As System.Windows.Forms.TextBox
    Friend WithEvents RbkdBarang As System.Windows.Forms.RadioButton
    Friend WithEvents Rbfaktur As System.Windows.Forms.RadioButton
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
