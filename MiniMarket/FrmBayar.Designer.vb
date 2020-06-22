<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBayar
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblSubTotal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DiscTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblGrandTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BayarTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblKembali = New System.Windows.Forms.TextBox()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.LblNmPelangdgan = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(66, 33)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Sub Total :"
        '
        'LblSubTotal
        '
        Me.LblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotal.Location = New System.Drawing.Point(202, 30)
        Me.LblSubTotal.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.LblSubTotal.Multiline = True
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(236, 34)
        Me.LblSubTotal.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(66, 85)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "DIsc % :"
        '
        'DiscTxt
        '
        Me.DiscTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscTxt.Location = New System.Drawing.Point(202, 71)
        Me.DiscTxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.DiscTxt.Multiline = True
        Me.DiscTxt.Name = "DiscTxt"
        Me.DiscTxt.Size = New System.Drawing.Size(61, 33)
        Me.DiscTxt.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(66, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Grand Total :"
        '
        'LblGrandTotal
        '
        Me.LblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGrandTotal.Location = New System.Drawing.Point(202, 112)
        Me.LblGrandTotal.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.LblGrandTotal.Multiline = True
        Me.LblGrandTotal.Name = "LblGrandTotal"
        Me.LblGrandTotal.Size = New System.Drawing.Size(236, 37)
        Me.LblGrandTotal.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(66, 180)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Bayar :"
        '
        'BayarTxt
        '
        Me.BayarTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BayarTxt.Location = New System.Drawing.Point(202, 157)
        Me.BayarTxt.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.BayarTxt.Multiline = True
        Me.BayarTxt.Name = "BayarTxt"
        Me.BayarTxt.Size = New System.Drawing.Size(236, 37)
        Me.BayarTxt.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(66, 225)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Kembali :"
        '
        'LblKembali
        '
        Me.LblKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKembali.Location = New System.Drawing.Point(202, 202)
        Me.LblKembali.Margin = New System.Windows.Forms.Padding(5, 3, 5, 3)
        Me.LblKembali.Multiline = True
        Me.LblKembali.Name = "LblKembali"
        Me.LblKembali.Size = New System.Drawing.Size(236, 37)
        Me.LblKembali.TabIndex = 39
        '
        'BtnOk
        '
        Me.BtnOk.Location = New System.Drawing.Point(202, 261)
        Me.BtnOk.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(117, 42)
        Me.BtnOk.TabIndex = 41
        Me.BtnOk.Text = "ok"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'BatalBtn
        '
        Me.BatalBtn.Location = New System.Drawing.Point(322, 261)
        Me.BatalBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(117, 42)
        Me.BatalBtn.TabIndex = 42
        Me.BatalBtn.Text = "batal"
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'LblNmPelangdgan
        '
        Me.LblNmPelangdgan.Location = New System.Drawing.Point(185, 45)
        Me.LblNmPelangdgan.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LblNmPelangdgan.Name = "LblNmPelangdgan"
        Me.LblNmPelangdgan.Size = New System.Drawing.Size(178, 20)
        Me.LblNmPelangdgan.TabIndex = 25
        '
        'FrmBayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 349)
        Me.Controls.Add(Me.BatalBtn)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblKembali)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BayarTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblGrandTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DiscTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblSubTotal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FrmBayar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bayar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DiscTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblGrandTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BayarTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblKembali As System.Windows.Forms.TextBox
    Friend WithEvents BtnOk As System.Windows.Forms.Button
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
    Friend WithEvents LblNmPelangdgan As System.Windows.Forms.TextBox
End Class
