Public Class Form1
    'variabel
    Dim angka As Integer

    Private Sub TxtAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAngka.KeyPress
        'hanya boleh angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        TxtHasil.Clear()
        angka = Val(TxtAngka.Text)

        'pola ke -1
        TxtHasil.Text = "BENTUK POLA KE-1" & vbNewLine
        For i = 1 To angka
            For j = 1 To i
                TxtHasil.Text &= i & " " & j
            Next
            TxtHasil.Text &= vbNewLine
        Next

        'pola ke -2
        TxtHasil.Text &= vbNewLine & "BENTUK POLA KE-2" & vbNewLine
        For i = 1 To angka
            For j = 1 To angka
                TxtHasil.Text &= "#"
            Next
            TxtHasil.Text &= vbNewLine
        Next

        'pola ke -3
        TxtHasil.Text &= vbNewLine & "BENTUK POLA KE-3" & vbNewLine
        For i = 1 To angka
            For j = 1 To i
                TxtHasil.Text &= "#"
            Next
            TxtHasil.Text &= vbNewLine
        Next

        'pola ke -4
        TxtHasil.Text &= vbNewLine & "BENTUK POLA KE-4" & vbNewLine
        For i = 1 To angka
            For j = angka To i Step -1
                TxtHasil.Text &= "#"
            Next
            TxtHasil.Text &= vbNewLine
        Next

        'pola ke -5
        TxtHasil.Text &= vbNewLine & "BENTUK POLA KE-5" & vbNewLine
        For i = 1 To angka
            For j = angka To i + 1 Step -1
                TxtHasil.Text &= "  "
            Next
            For k = 1 To i
                TxtHasil.Text &= "#"
            Next
            TxtHasil.Text &= vbNewLine
        Next

        'pola ke -6
        TxtHasil.Text &= vbNewLine & "BENTUK POLA KE-6" & vbNewLine
        For i = 1 To angka
            For j = 1 To i - 1
                TxtHasil.Text &= "  "
            Next
            For k = angka To i Step -1
                TxtHasil.Text &= "#"
            Next
            TxtHasil.Text &= vbNewLine
        Next

        'pola ke -7
        TxtHasil.Text &= vbNewLine & "BENTUK POLA KE-7" & vbNewLine
        For i = 1 To angka
            For j = angka To i + 1 Step -1
                TxtHasil.Text &= "  "
            Next
            For k = 1 To i
                TxtHasil.Text &= "#"
            Next
            For l = 1 To i - 1
                TxtHasil.Text &= "#"
            Next
            TxtHasil.Text &= vbNewLine
        Next

        'pola ke -8
        TxtHasil.Text &= vbNewLine & "BENTUK POLA KE-8" & vbNewLine
        For i = 1 To angka
            For j = 1 To i - 1
                TxtHasil.Text &= "  "
            Next
            For k = angka To i Step -1
                TxtHasil.Text &= "#"
            Next
            For l = angka To i + 1 Step -1
                TxtHasil.Text &= "#"
            Next
            TxtHasil.Text &= vbNewLine
            Next
    End Sub
End Class
