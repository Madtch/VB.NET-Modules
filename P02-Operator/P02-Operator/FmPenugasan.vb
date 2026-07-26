Public Class FmPenugasan
    'variabel
    Dim angka As Double


    Private Sub TxtAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAngka.KeyPress
        'logika hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        angka = Val(TxtAngka.Text)
        angka *= 5
        TxtHasil.Text = angka
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        angka = Val(TxtAngka.Text)
        angka += 5
        TxtHasil.Text = angka
    End Sub

    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        angka = Val(TxtAngka.Text)
        angka /= 5
        TxtHasil.Text = angka
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        angka = Val(TxtAngka.Text)
        angka -= 5
        TxtHasil.Text = angka
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtAngka.Clear()
        TxtHasil.Clear()
    End Sub
End Class