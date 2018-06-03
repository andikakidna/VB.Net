Public Class Dynamic
    Dim data_nomor() As Single
    Dim counter As Integer
    Dim dataid As Integer

    Private Sub Dynamic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim data_nomor(counter)
    End Sub
    Private Sub input_btn_Click(sender As Object, e As EventArgs) Handles input_btn.Click
        cari()
        refreshdata()
    End Sub
    Private Sub input_btn_enter(sender As Object, e As KeyPressEventArgs) Handles nid_txt.KeyPress
        If e.KeyChar = Chr(13) Then
            cari()
            refreshdata()
        End If
    End Sub

    Private Sub sama_CheckedChanged(sender As Object, e As EventArgs) Handles sama.CheckedChanged
        stats.Text = "Pencarian Sama Dengan"
        cekbtn()
    End Sub

    Private Sub antara_CheckedChanged(sender As Object, e As EventArgs) Handles antara.CheckedChanged
        stats.Text = "Pencarian Antara"
        cekbtn()
    End Sub

    Private Sub kurang_CheckedChanged(sender As Object, e As EventArgs) Handles kurang.CheckedChanged
        stats.Text = "Pencarian Kurang Dari"
        cekbtn()
    End Sub

    Private Sub lebih_CheckedChanged(sender As Object, e As EventArgs) Handles lebih.CheckedChanged
        stats.Text = "Pencarian Lebih Dari"
        cekbtn()
    End Sub

    Sub cari()
        If IsNumeric(nid_txt.Text) Then
            If counter = 0 Then
                data_nomor(counter) = nid_txt.Text
                daftar.Items.Add(data_nomor(counter))
                counter = counter + 1
                nid_txt.Text = ""
            Else
                ReDim Preserve data_nomor(UBound(data_nomor) + 1)
                data_nomor(counter) = nid_txt.Text
                daftar.Items.Add(data_nomor(counter))
                counter = counter + 1
                nid_txt.Text = ""
            End If
        Else
            MsgBox("Hanya Nomor", MsgBoxStyle.Critical)
        End If
    End Sub

    Sub cekbtn()
        If antara.Checked Then
            cari_txt.Visible = False
            cari_low_txt.Visible = True
            cari_max_txt.Visible = True
            sampai_tbox.Visible = True
        Else
            cari_txt.Visible = True
            cari_low_txt.Visible = False
            cari_max_txt.Visible = False
            sampai_tbox.Visible = False
        End If
    End Sub


    Private Sub cari_btn_Click(sender As Object, e As EventArgs) Handles cari_btn.Click
        If sama.Checked Then
            sama_find()
        ElseIf antara.Checked Then
            antara_find()
        ElseIf kurang.Checked Then
            kurang_find()
        ElseIf lebih.Checked Then
            lebih_find()
        End If
    End Sub

    Sub sama_find()
        Dim cari As Single = cari_txt.Text
        Dim max As Integer = UBound(data_nomor, 1)

        daftar.Items.Clear()
        For i As Integer = 0 To max
            If cari = data_nomor(i) Then
                dataid = dataid + 1
                daftar.Items.Add(data_nomor(i))
            End If
        Next
        cekdata()
    End Sub
    Sub antara_find()
        Dim cari As Single = cari_low_txt.Text
        Dim akhir As Single = cari_max_txt.Text
        Dim max As Integer = UBound(data_nomor, 1)
        daftar.Items.Clear()
        For i As Integer = 0 To max
            If cari <= data_nomor(i) And akhir >= data_nomor(i) Then
                dataid = dataid + 1
                daftar.Items.Add(data_nomor(i))
            End If
        Next
        cekdata()
    End Sub
    Sub kurang_find()
        Dim cari As Single = cari_txt.Text
        Dim max As Integer = UBound(data_nomor, 1)
        daftar.Items.Clear()
        For i As Integer = 0 To max
            If cari > data_nomor(i) Then
                dataid = dataid + 1
                daftar.Items.Add(data_nomor(i))
            End If
        Next
        cekdata()
    End Sub
    Sub lebih_find()
        Dim cari As Single = cari_txt.Text
        Dim max As Integer = UBound(data_nomor, 1)

        daftar.Items.Clear()
        For i As Integer = 0 To max
            If cari < data_nomor(i) Then
                dataid = dataid + 1
                daftar.Items.Add(data_nomor(i))
            End If
        Next
        cekdata()
    End Sub
    Sub cekdata()
        If dataid = 0 Then
            MsgBox("Data tidak ada", MsgBoxStyle.Critical)
        Else
            MsgBox("Ditemukan " + dataid.ToString + " Data, Dari " + counter.ToString + " Data", MsgBoxStyle.Information)
        End If
        dataid = 0
    End Sub
    Sub refreshdata()
        Dim max As Integer = UBound(data_nomor, 1)
        daftar.Items.Clear()
        For i As Integer = 0 To max
            daftar.Items.Add(data_nomor(i))
        Next
    End Sub

    Private Sub wipe_btn_Click(sender As Object, e As EventArgs) Handles wipe_btn.Click
        daftar.Items.Clear()
        ReDim data_nomor(0)
        counter = 0
    End Sub

    Private Sub showall_btn_Click(sender As Object, e As EventArgs) Handles showall_btn.Click
        refreshdata()
    End Sub
End Class
