Public Class Form1
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        If TxtInput.Text = "" Then
            MessageBox.Show("Masukkan angka terlebih dahulu!", "Peringatan")
            Exit Sub
        End If

        Dim jumlahLoop As Integer = CInt(TxtInput.Text)
        Dim hasil As String = ""

        For i As Integer = 1 To jumlahLoop
            If i Mod 2 = 0 Then
                hasil &= i & " (Bilangan Genap" & vbNewLine
            Else
                hasil &= i & " (Bilangan Ganjil)" & vbNewLine
            End If
        Next

        TxtHasil.Text = hasil
    End Sub

    Private Sub TxtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtInput.KeyPress
        ' Logika: Hanya izinkan karakter '0' sampai '9' DAN tombol Backspace (vbBack)
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            ' Jika BUKAN angka dan BUKAN backspace, batalkan inputannya!
            e.Handled = True
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtInput.Clear()
        TxtHasil.Clear()
        TxtInput.Focus()
    End Sub
End Class
