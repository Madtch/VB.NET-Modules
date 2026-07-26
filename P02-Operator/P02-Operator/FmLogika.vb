Public Class FmLogika
    'variabel
    Dim a, b, c As Double
    Dim d, hasil As Boolean

    Private Sub BtnAnd_Click(sender As Object, e As EventArgs) Handles BtnAnd.Click
        a = Val(TxtA.Text)
        b = Val(TxtB.Text)
        c = Val(TxtC.Text)

        hasil = b < c And b < a
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnOr_Click(sender As Object, e As EventArgs) Handles BtnOr.Click
        a = Val(TxtA.Text)
        b = Val(TxtB.Text)
        c = Val(TxtC.Text)

        hasil = b < c Or b < a
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnNot_Click(sender As Object, e As EventArgs) Handles BtnNot.Click
        d = CboD.Text

        hasil = Not d
        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtA.Clear()
        TxtB.Clear()
        TxtC.Clear()
        CboD.Text = ""
        TxtHasil.Clear()
    End Sub

    Private Sub TxtA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtA.KeyPress
        'logika hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtB.KeyPress
        'logika hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtC.KeyPress
        'logika hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub
End Class