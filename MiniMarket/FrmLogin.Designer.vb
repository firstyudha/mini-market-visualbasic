<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.KdPenggunaTxt = New System.Windows.Forms.TextBox()
        Me.PswTxt = New System.Windows.Forms.TextBox()
        Me.LevelTxt = New System.Windows.Forms.TextBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.BatalBtkn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Level :"
        '
        'KdPenggunaTxt
        '
        Me.KdPenggunaTxt.Location = New System.Drawing.Point(104, 38)
        Me.KdPenggunaTxt.Name = "KdPenggunaTxt"
        Me.KdPenggunaTxt.Size = New System.Drawing.Size(136, 20)
        Me.KdPenggunaTxt.TabIndex = 3
        '
        'PswTxt
        '
        Me.PswTxt.Location = New System.Drawing.Point(104, 69)
        Me.PswTxt.Name = "PswTxt"
        Me.PswTxt.Size = New System.Drawing.Size(136, 20)
        Me.PswTxt.TabIndex = 4
        '
        'LevelTxt
        '
        Me.LevelTxt.Location = New System.Drawing.Point(104, 104)
        Me.LevelTxt.Name = "LevelTxt"
        Me.LevelTxt.Size = New System.Drawing.Size(136, 20)
        Me.LevelTxt.TabIndex = 5
        '
        'OkBtn
        '
        Me.OkBtn.Location = New System.Drawing.Point(104, 130)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(65, 23)
        Me.OkBtn.TabIndex = 6
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'BatalBtkn
        '
        Me.BatalBtkn.Location = New System.Drawing.Point(175, 130)
        Me.BatalBtkn.Name = "BatalBtkn"
        Me.BatalBtkn.Size = New System.Drawing.Size(65, 23)
        Me.BatalBtkn.TabIndex = 7
        Me.BatalBtkn.Text = "Batal"
        Me.BatalBtkn.UseVisualStyleBackColor = True
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 183)
        Me.Controls.Add(Me.BatalBtkn)
        Me.Controls.Add(Me.OkBtn)
        Me.Controls.Add(Me.LevelTxt)
        Me.Controls.Add(Me.PswTxt)
        Me.Controls.Add(Me.KdPenggunaTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents KdPenggunaTxt As System.Windows.Forms.TextBox
    Friend WithEvents PswTxt As System.Windows.Forms.TextBox
    Friend WithEvents LevelTxt As System.Windows.Forms.TextBox
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents BatalBtkn As System.Windows.Forms.Button
End Class
