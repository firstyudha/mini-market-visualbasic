<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSatuan
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
        Me.DGSatuan = New System.Windows.Forms.DataGridView()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.SatuanTxt = New System.Windows.Forms.TextBox()
        Me.KdSatuanTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HapusBtn = New System.Windows.Forms.Button()
        CType(Me.DGSatuan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGSatuan
        '
        Me.DGSatuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGSatuan.Location = New System.Drawing.Point(12, 119)
        Me.DGSatuan.Name = "DGSatuan"
        Me.DGSatuan.Size = New System.Drawing.Size(256, 174)
        Me.DGSatuan.TabIndex = 14
        '
        'UbahBtn
        '
        Me.UbahBtn.Location = New System.Drawing.Point(147, 66)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(52, 47)
        Me.UbahBtn.TabIndex = 13
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Location = New System.Drawing.Point(92, 66)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(52, 47)
        Me.SimpanBtn.TabIndex = 12
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'SatuanTxt
        '
        Me.SatuanTxt.Location = New System.Drawing.Point(92, 39)
        Me.SatuanTxt.Name = "SatuanTxt"
        Me.SatuanTxt.Size = New System.Drawing.Size(162, 20)
        Me.SatuanTxt.TabIndex = 11
        '
        'KdSatuanTxt
        '
        Me.KdSatuanTxt.Location = New System.Drawing.Point(92, 13)
        Me.KdSatuanTxt.Name = "KdSatuanTxt"
        Me.KdSatuanTxt.Size = New System.Drawing.Size(100, 20)
        Me.KdSatuanTxt.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Satuan :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Kode Satuan :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(205, 65)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(52, 47)
        Me.HapusBtn.TabIndex = 15
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'FrmSatuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 303)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.DGSatuan)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.SatuanTxt)
        Me.Controls.Add(Me.KdSatuanTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSatuan"
        Me.Text = "FrmSatuan"
        CType(Me.DGSatuan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGSatuan As System.Windows.Forms.DataGridView
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents SatuanTxt As System.Windows.Forms.TextBox
    Friend WithEvents KdSatuanTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
End Class
