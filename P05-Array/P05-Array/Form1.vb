Public Class Form1
    'variabel array
    Dim angka(3) As Double
    Dim gabungan() = {27, 14, 49, "Proasta", "Battuta", 0.25}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'masukkan nilai/elemen array
        angka(0) = 4.5
        angka(1) = 6.3
        angka(2) = 3.9
        angka(3) = 5.1
    End Sub

    Private Sub BtnTampil_Click(sender As Object, e As EventArgs) Handles BtnTampil.Click
        TxtOutput.Clear()

        'tampilkan isi array "angka()"
        TxtOutput.Text = "Elemen array angka()" & vbNewLine
        For i = 0 To 3
            TxtOutput.Text &= "index[" & i & "] -> " & angka(i) & vbNewLine
        Next

        'tampilkan isi array "gabungan()"
        Dim arrayLength = gabungan.GetUpperBound(0)
        TxtOutput.Text &= vbNewLine & "Elemen array gabungan()" & vbNewLine
        For i = 0 To arrayLength
            TxtOutput.Text &= "index[" & i & "] -> " & gabungan(i) & vbNewLine
        Next
    End Sub
End Class
