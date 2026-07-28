Public Class Form1

    Private Sub TxtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtInput.KeyPress
        ' Hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        ' 1. Validasi input kosong
        If TxtInput.Text = "" Then
            MessageBox.Show("Masukkan batas angka terlebih dahulu!", "Peringatan")
            Exit Sub
        End If

        Dim input As Integer = CInt(TxtInput.Text)
        Dim hasil As String = ""

        ' 2. Loop Luar (i): WAJIB mulai dari 1 sampai input
        For i As Integer = 1 To input
            Dim isPrima As Boolean = True

            ' Loop Dalam (j): Cek pembagi dari 2 sampai (i - 1)
            For j As Integer = 2 To i - 1
                If i Mod j = 0 Then
                    isPrima = False
                    Exit For
                End If
            Next

            ' 3. Format Output
            ' Angka Prima (dan harus > 1)
            If isPrima AndAlso i > 1 Then
                hasil &= i & " adalah bilangan prima" & vbNewLine
            Else
                ' Jika bukan prima (seperti angka 1, 4, 6, dst), cetak angkanya saja
                hasil &= i & vbNewLine
            End If
        Next

        ' 4. Tampilkan ke TxtOutput
        TxtOutput.Text = hasil
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtInput.Clear()
        TxtOutput.Clear()
        TxtInput.Focus()
    End Sub

End Class