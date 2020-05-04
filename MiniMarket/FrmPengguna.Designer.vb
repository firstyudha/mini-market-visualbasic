<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPengguna
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KdPenggunaTxt = New System.Windows.Forms.TextBox()
        Me.NmPenggunaTxt = New System.Windows.Forms.TextBox()
        Me.PasswordTxt = New System.Windows.Forms.TextBox()
        Me.UlgPassword = New System.Windows.Forms.TextBox()
        Me.LevelCbo = New System.Windows.Forms.ComboBox()
        Me.DGPengguna = New System.Windows.Forms.DataGridView()
        Me.SimpanBtn = New System.Windows.Forms.Button()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.HapusBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.TutupBtn = New System.Windows.Forms.Button()
        Me.CariBtn = New System.Windows.Forms.Button()
        CType(Me.DGPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pengguna"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Pengguna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Ulang Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Level"
        '
        'KdPenggunaTxt
        '
        Me.KdPenggunaTxt.Location = New System.Drawing.Point(130, 32)
        Me.KdPenggunaTxt.Name = "KdPenggunaTxt"
        Me.KdPenggunaTxt.Size = New System.Drawing.Size(121, 20)
        Me.KdPenggunaTxt.TabIndex = 5
        '
        'NmPenggunaTxt
        '
        Me.NmPenggunaTxt.Location = New System.Drawing.Point(130, 59)
        Me.NmPenggunaTxt.Name = "NmPenggunaTxt"
        Me.NmPenggunaTxt.Size = New System.Drawing.Size(121, 20)
        Me.NmPenggunaTxt.TabIndex = 6
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Location = New System.Drawing.Point(130, 85)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.Size = New System.Drawing.Size(121, 20)
        Me.PasswordTxt.TabIndex = 7
        '
        'UlgPassword
        '
        Me.UlgPassword.Location = New System.Drawing.Point(130, 111)
        Me.UlgPassword.Name = "UlgPassword"
        Me.UlgPassword.Size = New System.Drawing.Size(121, 20)
        Me.UlgPassword.TabIndex = 8
        '
        'LevelCbo
        '
        Me.LevelCbo.FormattingEnabled = True
        Me.LevelCbo.Location = New System.Drawing.Point(130, 147)
        Me.LevelCbo.Name = "LevelCbo"
        Me.LevelCbo.Size = New System.Drawing.Size(121, 21)
        Me.LevelCbo.TabIndex = 9
        '
        'DGPengguna
        '
        Me.DGPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPengguna.Location = New System.Drawing.Point(257, 32)
        Me.DGPengguna.Name = "DGPengguna"
        Me.DGPengguna.Size = New System.Drawing.Size(359, 150)
        Me.DGPengguna.TabIndex = 10
        '
        'SimpanBtn
        '
        Me.SimpanBtn.Location = New System.Drawing.Point(77, 212)
        Me.SimpanBtn.Name = "SimpanBtn"
        Me.SimpanBtn.Size = New System.Drawing.Size(75, 23)
        Me.SimpanBtn.TabIndex = 11
        Me.SimpanBtn.Text = "Simpan"
        Me.SimpanBtn.UseVisualStyleBackColor = True
        '
        'UbahBtn
        '
        Me.UbahBtn.Location = New System.Drawing.Point(239, 212)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(75, 23)
        Me.UbahBtn.TabIndex = 12
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'HapusBtn
        '
        Me.HapusBtn.Location = New System.Drawing.Point(320, 212)
        Me.HapusBtn.Name = "HapusBtn"
        Me.HapusBtn.Size = New System.Drawing.Size(75, 23)
        Me.HapusBtn.TabIndex = 13
        Me.HapusBtn.Text = "Hapus"
        Me.HapusBtn.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.Location = New System.Drawing.Point(158, 212)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(75, 23)
        Me.BatalBtn.TabIndex = 14
        Me.BatalBtn.Text = "Batal"
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'TutupBtn
        '
        Me.TutupBtn.Location = New System.Drawing.Point(401, 212)
        Me.TutupBtn.Name = "TutupBtn"
        Me.TutupBtn.Size = New System.Drawing.Size(75, 23)
        Me.TutupBtn.TabIndex = 15
        Me.TutupBtn.Text = "Tutup"
        Me.TutupBtn.UseVisualStyleBackColor = True
        '
        'CariBtn
        '
        Me.CariBtn.Location = New System.Drawing.Point(482, 212)
        Me.CariBtn.Name = "CariBtn"
        Me.CariBtn.Size = New System.Drawing.Size(75, 23)
        Me.CariBtn.TabIndex = 16
        Me.CariBtn.Text = "Cari"
        Me.CariBtn.UseVisualStyleBackColor = True
        '
        'FrmPengguna
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 260)
        Me.Controls.Add(Me.CariBtn)
        Me.Controls.Add(Me.TutupBtn)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.HapusBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.SimpanBtn)
        Me.Controls.Add(Me.DGPengguna)
        Me.Controls.Add(Me.LevelCbo)
        Me.Controls.Add(Me.UlgPassword)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.NmPenggunaTxt)
        Me.Controls.Add(Me.KdPenggunaTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPengguna"
        Me.Text = "Pengguna"
        CType(Me.DGPengguna, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents KdPenggunaTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmPenggunaTxt As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTxt As System.Windows.Forms.TextBox
    Friend WithEvents UlgPassword As System.Windows.Forms.TextBox
    Friend WithEvents LevelCbo As System.Windows.Forms.ComboBox
    Friend WithEvents DGPengguna As System.Windows.Forms.DataGridView
    Friend WithEvents SimpanBtn As System.Windows.Forms.Button
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents HapusBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents TutupBtn As System.Windows.Forms.Button
    Friend WithEvents CariBtn As System.Windows.Forms.Button
End Class
