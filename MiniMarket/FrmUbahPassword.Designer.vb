<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUbahPassword
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
        Me.PswLamaTxt = New System.Windows.Forms.TextBox()
        Me.PswBaruTxt = New System.Windows.Forms.TextBox()
        Me.UbahBtn = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password lama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password baru"
        '
        'PswLamaTxt
        '
        Me.PswLamaTxt.Location = New System.Drawing.Point(131, 31)
        Me.PswLamaTxt.Name = "PswLamaTxt"
        Me.PswLamaTxt.Size = New System.Drawing.Size(135, 20)
        Me.PswLamaTxt.TabIndex = 2
        '
        'PswBaruTxt
        '
        Me.PswBaruTxt.Location = New System.Drawing.Point(131, 57)
        Me.PswBaruTxt.Name = "PswBaruTxt"
        Me.PswBaruTxt.Size = New System.Drawing.Size(135, 20)
        Me.PswBaruTxt.TabIndex = 3
        '
        'UbahBtn
        '
        Me.UbahBtn.Location = New System.Drawing.Point(162, 93)
        Me.UbahBtn.Name = "UbahBtn"
        Me.UbahBtn.Size = New System.Drawing.Size(49, 23)
        Me.UbahBtn.TabIndex = 4
        Me.UbahBtn.Text = "Ubah"
        Me.UbahBtn.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.Location = New System.Drawing.Point(217, 93)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(49, 23)
        Me.BatalBtn.TabIndex = 5
        Me.BatalBtn.Text = "Batal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'FrmUbahPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 147)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.UbahBtn)
        Me.Controls.Add(Me.PswBaruTxt)
        Me.Controls.Add(Me.PswLamaTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmUbahPassword"
        Me.Text = "Ubah Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PswLamaTxt As System.Windows.Forms.TextBox
    Friend WithEvents PswBaruTxt As System.Windows.Forms.TextBox
    Friend WithEvents UbahBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
End Class
