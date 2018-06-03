<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input_txt = New System.Windows.Forms.TextBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.exec_btn = New System.Windows.Forms.Button()
        Me.clr_btn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.timer_btn = New System.Windows.Forms.Button()
        Me.waktu = New System.Windows.Forms.Label()
        Me.lifo_rad = New System.Windows.Forms.RadioButton()
        Me.fifo_rad = New System.Windows.Forms.RadioButton()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mode_stat = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukkan data!!"
        '
        'input_txt
        '
        Me.input_txt.Location = New System.Drawing.Point(29, 73)
        Me.input_txt.Name = "input_txt"
        Me.input_txt.Size = New System.Drawing.Size(240, 20)
        Me.input_txt.TabIndex = 1
        '
        'save_btn
        '
        Me.save_btn.Location = New System.Drawing.Point(29, 99)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(75, 23)
        Me.save_btn.TabIndex = 2
        Me.save_btn.Text = "Simpan"
        Me.save_btn.UseVisualStyleBackColor = True
        '
        'exec_btn
        '
        Me.exec_btn.Location = New System.Drawing.Point(170, 193)
        Me.exec_btn.Name = "exec_btn"
        Me.exec_btn.Size = New System.Drawing.Size(75, 23)
        Me.exec_btn.TabIndex = 3
        Me.exec_btn.Text = "Execute"
        Me.exec_btn.UseVisualStyleBackColor = True
        '
        'clr_btn
        '
        Me.clr_btn.Location = New System.Drawing.Point(170, 408)
        Me.clr_btn.Name = "clr_btn"
        Me.clr_btn.Size = New System.Drawing.Size(75, 23)
        Me.clr_btn.TabIndex = 4
        Me.clr_btn.Text = "Bersihkan"
        Me.clr_btn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 193)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(152, 238)
        Me.ListBox1.TabIndex = 5
        '
        'timer_btn
        '
        Me.timer_btn.Location = New System.Drawing.Point(170, 222)
        Me.timer_btn.Name = "timer_btn"
        Me.timer_btn.Size = New System.Drawing.Size(75, 23)
        Me.timer_btn.TabIndex = 7
        Me.timer_btn.Text = "Timer Off"
        Me.timer_btn.UseVisualStyleBackColor = True
        '
        'waktu
        '
        Me.waktu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.waktu.AutoSize = True
        Me.waktu.Location = New System.Drawing.Point(183, 253)
        Me.waktu.Name = "waktu"
        Me.waktu.Size = New System.Drawing.Size(50, 13)
        Me.waktu.TabIndex = 8
        Me.waktu.Text = "Timer Off"
        '
        'lifo_rad
        '
        Me.lifo_rad.AutoSize = True
        Me.lifo_rad.Location = New System.Drawing.Point(282, 93)
        Me.lifo_rad.Name = "lifo_rad"
        Me.lifo_rad.Size = New System.Drawing.Size(48, 17)
        Me.lifo_rad.TabIndex = 9
        Me.lifo_rad.TabStop = True
        Me.lifo_rad.Text = "LIFO"
        Me.lifo_rad.UseVisualStyleBackColor = True
        '
        'fifo_rad
        '
        Me.fifo_rad.AutoSize = True
        Me.fifo_rad.Location = New System.Drawing.Point(282, 73)
        Me.fifo_rad.Name = "fifo_rad"
        Me.fifo_rad.Size = New System.Drawing.Size(48, 17)
        Me.fifo_rad.TabIndex = 10
        Me.fifo_rad.TabStop = True
        Me.fifo_rad.Text = "FIFO"
        Me.fifo_rad.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(251, 193)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(152, 238)
        Me.ListBox2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(249, 38)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Queue && Stack"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mode_stat
        '
        Me.mode_stat.AutoSize = True
        Me.mode_stat.Location = New System.Drawing.Point(279, 113)
        Me.mode_stat.Name = "mode_stat"
        Me.mode_stat.Size = New System.Drawing.Size(34, 13)
        Me.mode_stat.TabIndex = 13
        Me.mode_stat.Text = "Mode"
        Me.mode_stat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "auto exec on 0 "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 443)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mode_stat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.fifo_rad)
        Me.Controls.Add(Me.lifo_rad)
        Me.Controls.Add(Me.waktu)
        Me.Controls.Add(Me.timer_btn)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.clr_btn)
        Me.Controls.Add(Me.exec_btn)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.input_txt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents input_txt As TextBox
    Friend WithEvents save_btn As Button
    Friend WithEvents exec_btn As Button
    Friend WithEvents clr_btn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents timer_btn As Button
    Friend WithEvents waktu As Label
    Friend WithEvents lifo_rad As RadioButton
    Friend WithEvents fifo_rad As RadioButton
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mode_stat As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
End Class
