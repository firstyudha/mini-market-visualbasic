<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKelompok
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.KdKelompokTxt = New System.Windows.Forms.TextBox()
        Me.KelompokTxt = New System.Windows.Forms.TextBox()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.DGKelompok = New System.Windows.Forms.DataGridView()
        CType(Me.DGKelompok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kd Kelompok :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kelompok :"
        '
        'KdKelompokTxt
        '
        Me.KdKelompokTxt.Location = New System.Drawing.Point(96, 13)
        Me.KdKelompokTxt.Name = "KdKelompokTxt"
        Me.KdKelompokTxt.Size = New System.Drawing.Size(100, 20)
        Me.KdKelompokTxt.TabIndex = 2
        '
        'KelompokTxt
        '
        Me.KelompokTxt.Location = New System.Drawing.Point(96, 39)
        Me.KelompokTxt.Name = "KelompokTxt"
        Me.KelompokTxt.Size = New System.Drawing.Size(162, 20)
        Me.KelompokTxt.TabIndex = 3
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Location = New System.Drawing.Point(96, 66)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(52, 47)
        Me.SimpanBtn.TabIndex = 4
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.Location = New System.Drawing.Point(151, 66)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(52, 47)
        Me.UbahBtn.TabIndex = 5
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(206, 66)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(52, 47)
        Me.HapusBtn.TabIndex = 6
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'DGKelompok
        '
        Me.DGKelompok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKelompok.Location = New System.Drawing.Point(16, 119)
        Me.DGKelompok.Name = "DGKelompok"
        Me.DGKelompok.Size = New System.Drawing.Size(256, 174)
        Me.DGKelompok.TabIndex = 7
        '
        'FrmKelompok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 305)
        Me.Controls.Add(Me.DGKelompok)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.KelompokTxt)
        Me.Controls.Add(Me.KdKelompokTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmKelompok"
        Me.Text = "Kelompok"
        CType(Me.DGKelompok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents KdKelompokTxt As System.Windows.Forms.TextBox
    Friend WithEvents KelompokTxt As System.Windows.Forms.TextBox
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents DGKelompok As System.Windows.Forms.DataGridView
End Class
