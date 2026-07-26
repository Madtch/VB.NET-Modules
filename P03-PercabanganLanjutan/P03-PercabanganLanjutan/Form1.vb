Public Class Form1
    'variabel
    Dim nilai As Integer
    Dim hasil, predikat, keterangan As String

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtNilai.Clear()
        TxtHasil.Clear()
        TxtPredikat.Clear()
        TxtKeterangan.Clear()
        TxtNilai.Focus()
    End Sub

    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles BtnProcess.Click
        'input nilai ke variabel
        nilai = Val(TxtNilai.Text)

        'jika nilai lebih dari 100 atau kurang dari 0
        If nilai > 100 Or nilai < 0 Then
            MsgBox("Nilai tidak boleh lebih dari 100 atau kurang dari nol!")
            Exit Sub
        End If

        'pengkondisian / nested if
        If nilai > 70 Then
            hasil = "lulus"
            If nilai >= 95 And nilai <= 100 Then
                predikat = "Predikat A"
                If nilai >= 98 And nilai <= 100 Then
                    keterangan = "Reward Buku"
                Else
                    keterangan = "Reward Pulpen"
                End If
            ElseIf nilai >= 80 And nilai <= 94 Then
                predikat = "Predikat B"
                keterangan = "-"
            Else
                predikat = "Predikat C"
                keterangan = "-"
            End If
        Else
            hasil = "Tidak Lulus"
            If nilai >= 60 And nilai <= 70 Then
                predikat = "Predikat D"
                If nilai >= 65 And nilai <= 70 Then
                    keterangan = "Ujian Ulang"
                Else
                    keterangan = "Mengulang Kelas"
                End If
            Else
                predikat = "Predikat E"
                keterangan = "Mengulang Kelas"
            End If
        End If

        'output 
        TxtHasil.Text = hasil
        TxtPredikat.Text = predikat
        TxtKeterangan.Text = keterangan
    End Sub

    Private Sub TxtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNilai.KeyPress
        'validasi cuma boleh angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class
