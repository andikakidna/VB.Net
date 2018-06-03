<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dynamic
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
        Me.sama = New System.Windows.Forms.RadioButton()
        Me.antara = New System.Windows.Forms.RadioButton()
        Me.kurang = New System.Windows.Forms.RadioButton()
        Me.lebih = New System.Windows.Forms.RadioButton()
        Me.cari_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cari_txt = New System.Windows.Forms.TextBox()
        Me.daftar = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nid_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.input_btn = New System.Windows.Forms.Button()
        Me.stats = New System.Windows.Forms.Label()
        Me.cari_low_txt = New System.Windows.Forms.TextBox()
        Me.cari_max_txt = New System.Windows.Forms.TextBox()
        Me.sampai_tbox = New System.Windows.Forms.Label()
        Me.wipe_btn = New System.Windows.Forms.Button()
        Me.showall_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'sama
        '
        Me.sama.AutoSize = True
        Me.sama.Location = New System.Drawing.Point(34, 165)
        Me.sama.Name = "sama"
        Me.sama.Size = New System.Drawing.Size(31, 17)
        Me.sama.TabIndex = 0
        Me.sama.TabStop = True
        Me.sama.Text = "="
        Me.sama.UseVisualStyleBackColor = True
        '
        'antara
        '
        Me.antara.AutoSize = True
        Me.antara.Location = New System.Drawing.Point(34, 188)
        Me.antara.Name = "antara"
        Me.antara.Size = New System.Drawing.Size(57, 17)
        Me.antara.TabIndex = 1
        Me.antara.TabStop = True
        Me.antara.Text = "Range"
        Me.antara.UseVisualStyleBackColor = True
        '
        'kurang
        '
        Me.kurang.AutoSize = True
        Me.kurang.Location = New System.Drawing.Point(130, 165)
        Me.kurang.Name = "kurang"
        Me.kurang.Size = New System.Drawing.Size(72, 17)
        Me.kurang.TabIndex = 2
        Me.kurang.TabStop = True
        Me.kurang.Text = "LessThan"
        Me.kurang.UseVisualStyleBackColor = True
        '
        'lebih
        '
        Me.lebih.AutoSize = True
        Me.lebih.Location = New System.Drawing.Point(130, 188)
        Me.lebih.Name = "lebih"
        Me.lebih.Size = New System.Drawing.Size(74, 17)
        Me.lebih.TabIndex = 3
        Me.lebih.TabStop = True
        Me.lebih.Text = "MoreThan"
        Me.lebih.UseVisualStyleBackColor = True
        '
        'cari_btn
        '
        Me.cari_btn.Location = New System.Drawing.Point(146, 211)
        Me.cari_btn.Name = "cari_btn"
        Me.cari_btn.Size = New System.Drawing.Size(75, 23)
        Me.cari_btn.TabIndex = 4
        Me.cari_btn.Text = "Cari"
        Me.cari_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cari Nomor ID"
        '
        'cari_txt
        '
        Me.cari_txt.Location = New System.Drawing.Point(12, 139)
        Me.cari_txt.Name = "cari_txt"
        Me.cari_txt.Size = New System.Drawing.Size(209, 20)
        Me.cari_txt.TabIndex = 6
        '
        'daftar
        '
        Me.daftar.FormattingEnabled = True
        Me.daftar.Location = New System.Drawing.Point(12, 263)
        Me.daftar.Name = "daftar"
        Me.daftar.Size = New System.Drawing.Size(209, 225)
        Me.daftar.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Result"
        '
        'nid_txt
        '
        Me.nid_txt.Location = New System.Drawing.Point(15, 58)
        Me.nid_txt.Name = "nid_txt"
        Me.nid_txt.Size = New System.Drawing.Size(209, 20)
        Me.nid_txt.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Input Nomor ID"
        '
        'input_btn
        '
        Me.input_btn.Location = New System.Drawing.Point(149, 84)
        Me.input_btn.Name = "input_btn"
        Me.input_btn.Size = New System.Drawing.Size(75, 23)
        Me.input_btn.TabIndex = 11
        Me.input_btn.Text = "Input"
        Me.input_btn.UseVisualStyleBackColor = True
        '
        'stats
        '
        Me.stats.AutoSize = True
        Me.stats.Location = New System.Drawing.Point(12, 216)
        Me.stats.Name = "stats"
        Me.stats.Size = New System.Drawing.Size(37, 13)
        Me.stats.TabIndex = 12
        Me.stats.Text = "Status"
        '
        'cari_low_txt
        '
        Me.cari_low_txt.Location = New System.Drawing.Point(12, 139)
        Me.cari_low_txt.Name = "cari_low_txt"
        Me.cari_low_txt.Size = New System.Drawing.Size(79, 20)
        Me.cari_low_txt.TabIndex = 13
        '
        'cari_max_txt
        '
        Me.cari_max_txt.Location = New System.Drawing.Point(145, 139)
        Me.cari_max_txt.Name = "cari_max_txt"
        Me.cari_max_txt.Size = New System.Drawing.Size(79, 20)
        Me.cari_max_txt.TabIndex = 14
        '
        'sampai_tbox
        '
        Me.sampai_tbox.AutoSize = True
        Me.sampai_tbox.Location = New System.Drawing.Point(97, 142)
        Me.sampai_tbox.Name = "sampai_tbox"
        Me.sampai_tbox.Size = New System.Drawing.Size(42, 13)
        Me.sampai_tbox.TabIndex = 15
        Me.sampai_tbox.Text = "Sampai"
        '
        'wipe_btn
        '
        Me.wipe_btn.Location = New System.Drawing.Point(146, 494)
        Me.wipe_btn.Name = "wipe_btn"
        Me.wipe_btn.Size = New System.Drawing.Size(75, 23)
        Me.wipe_btn.TabIndex = 16
        Me.wipe_btn.Text = "Wipe Data"
        Me.wipe_btn.UseVisualStyleBackColor = True
        '
        'showall_btn
        '
        Me.showall_btn.Location = New System.Drawing.Point(12, 494)
        Me.showall_btn.Name = "showall_btn"
        Me.showall_btn.Size = New System.Drawing.Size(128, 23)
        Me.showall_btn.TabIndex = 17
        Me.showall_btn.Text = "Tampilkan Semua Data"
        Me.showall_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(94, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Created by @andikakidna"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(185, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Dynamic Array - Final Release 1/6/18"
        '
        'Dynamic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 523)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.showall_btn)
        Me.Controls.Add(Me.wipe_btn)
        Me.Controls.Add(Me.sampai_tbox)
        Me.Controls.Add(Me.cari_max_txt)
        Me.Controls.Add(Me.cari_low_txt)
        Me.Controls.Add(Me.stats)
        Me.Controls.Add(Me.input_btn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nid_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.daftar)
        Me.Controls.Add(Me.cari_txt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cari_btn)
        Me.Controls.Add(Me.lebih)
        Me.Controls.Add(Me.kurang)
        Me.Controls.Add(Me.antara)
        Me.Controls.Add(Me.sama)
        Me.Name = "Dynamic"
        Me.Text = "Dynamic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sama As System.Windows.Forms.RadioButton
    Friend WithEvents antara As System.Windows.Forms.RadioButton
    Friend WithEvents kurang As System.Windows.Forms.RadioButton
    Friend WithEvents lebih As System.Windows.Forms.RadioButton
    Friend WithEvents cari_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cari_txt As System.Windows.Forms.TextBox
    Friend WithEvents daftar As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nid_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents input_btn As System.Windows.Forms.Button
    Friend WithEvents stats As System.Windows.Forms.Label
    Friend WithEvents cari_low_txt As System.Windows.Forms.TextBox
    Friend WithEvents cari_max_txt As System.Windows.Forms.TextBox
    Friend WithEvents sampai_tbox As System.Windows.Forms.Label
    Friend WithEvents wipe_btn As System.Windows.Forms.Button
    Friend WithEvents showall_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
