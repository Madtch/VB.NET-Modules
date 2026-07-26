Public Class FmRelasi
    'variabel
    Dim bil1, bil2 As Double
    Dim hasil As Boolean

    Private Sub TxtBilangan1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBilangan1.KeyPress
        'logika hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnLB_Click(sender As Object, e As EventArgs) Handles BtnLB.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 > bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnLK_Click(sender As Object, e As EventArgs) Handles BtnLK.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 < bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnLBSD_Click(sender As Object, e As EventArgs) Handles BtnLBSD.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 >= bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnLKSD_Click(sender As Object, e As EventArgs) Handles BtnLKSD.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 <= bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnSD_Click(sender As Object, e As EventArgs) Handles BtnSD.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 = bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnTSD_Click(sender As Object, e As EventArgs) Handles BtnTSD.Click
        bil1 = Val(TxtBilangan1.Text)
        bil2 = Val(TxtBilangan2.Text)
        hasil = bil1 <> bil2
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtBilangan1.Clear()
        TxtBilangan2.Clear()
        TxtHasil.Clear()
    End Sub

    Private Sub TxtBilangan2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBilangan2.KeyPress
        'logika hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class