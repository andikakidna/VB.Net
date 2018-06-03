Public Class Form1
    Dim data_array() As String
    Dim counter As Integer = 0
    Dim Second As Integer = 6
    Dim timer_stat As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop()
        fifo_rad.Checked = True
    End Sub

    Private Sub fifo_rad_CheckedChanged(sender As Object, e As EventArgs) Handles fifo_rad.CheckedChanged
        mode_stat.Text = "Mode FIFO / Queue"
    End Sub

    Private Sub lifo_rad_CheckedChanged(sender As Object, e As EventArgs) Handles lifo_rad.CheckedChanged
        mode_stat.Text = "Mode LIFO / Stack"
    End Sub

    Private Sub input_txt_keypress(sender As Object, e As KeyPressEventArgs) Handles input_txt.KeyPress
        If e.KeyChar = Chr(13) Then
            savedata()
        End If
    End Sub
    Sub savedata()
        If input_txt.Text = "" Then
            MsgBox("Data belum diisi !!", MsgBoxStyle.Critical)
        Else
            If counter = 0 Then
                ReDim data_array(counter)
                data_array(counter) = input_txt.Text.ToString
                ListBox1.Items.Add((counter + 1).ToString & " - " & data_array(counter))
                counter = counter + 1
                input_txt.Text = ""
            Else
                ReDim Preserve data_array(UBound(data_array) + 1)
                data_array(counter) = input_txt.Text.ToString
                ListBox1.Items.Add((counter + 1).ToString & " - " & data_array(counter))
                counter = counter + 1
                input_txt.Text = ""
            End If
        End If
    End Sub
    Private Sub save_btn_Click(sender As Object, e As EventArgs) Handles save_btn.Click
        savedata()
    End Sub

    Sub cekstat()
        If fifo_rad.Checked Then
            next_queue()
        Else
            next_stack()
        End If
    End Sub
    Sub next_queue()
        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        If max < 0 Then
            MsgBox("Data dalam antrian kosong", MsgBoxStyle.Critical)
            waktu_off()
        Else
            Dim temp As String
            ListBox2.Items.Add(data_array(0))
            For i As Integer = 1 To max
                temp = data_array(i)
                data_array(i - 1) = temp
            Next
            ReDim Preserve data_array(max - 1)
            counter = counter - 1
            newlist()
        End If
    End Sub
    Sub next_stack()
        Dim max As Integer = UBound(data_array, 1) 'menghitung jumlah total index pada array data_array
        If max < 0 Then
            MsgBox("Data dalam antrian kosong", MsgBoxStyle.Critical)
            waktu_off()
        Else
            'Dim temp As String
            ListBox2.Items.Add(data_array(max))
            ReDim Preserve data_array(max - 1)
            counter = counter - 1
            newlist()
        End If
    End Sub

    Private Sub exec_btn_Click(sender As Object, e As EventArgs) Handles exec_btn.Click
        If counter = 0 Then
            MsgBox("Data belum diisi !!", MsgBoxStyle.Critical)
        Else
            cekstat()
            waktu_off()
        End If
    End Sub
    Private Sub timer_btn_Click(sender As Object, e As EventArgs) Handles timer_btn.Click
        If counter = 0 Then
            MsgBox("Data belum diisi", MsgBoxStyle.Critical)
        Else
            If timer_stat = 0 Then
                timer_btn.Text = "Timer On"
                waktu_on()
                timer_stat = 1
            Else
                timer_btn.Text = "Timer Off"
                waktu_off()
                timer_stat = 0
            End If
        End If
    End Sub
    Sub waktu_off()
        waktu.Text = "Timer Off"
        Timer1.Stop()
    End Sub
    Sub waktu_on()
        waktu.Text = 5
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        waktu.Text = Second - 1
        Second = Second - 1
        If Second = 0 Then
            cekstat()
            Second = 6
        End If
    End Sub
    Sub newlist()
        Dim max As Integer = UBound(data_array, 1)
        ListBox1.Items.Clear()
        For a As Integer = 0 To max Step 1
            ListBox1.Items.Add((a + 1).ToString & " - " & data_array(a).ToString) 'menambahkan semua data dalam data_array kedalam listbox
        Next

    End Sub

    Private Sub clr_btn_Click(sender As Object, e As EventArgs) Handles clr_btn.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ReDim data_array(0)
        counter = 0
        input_txt.Text = ""
    End Sub
End Class
