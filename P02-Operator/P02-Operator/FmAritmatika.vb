Public Class FmAritmatika
    'variabel

    Dim bil1, bil2, hasil As Double

    Private Sub TxtBilangan1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBilangan1.KeyPress
        'logika hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtBilangan2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBilangan2.KeyPress
        'logika hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 + bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 - bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnPangkat_Click(sender As Object, e As EventArgs) Handles BtnPangkat.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 ^ bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnMod_Click(sender As Object, e As EventArgs) Handles BtnMod.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 Mod bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnMerge_Click(sender As Object, e As EventArgs) Handles BtnMerge.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 & bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 * bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 / bil2
        TxtHasil.Text = hasil
    End Sub


    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtBilangan1.Clear()
        TxtBilangan2.Clear()
        TxtHasil.Clear()
    End Sub

End Class