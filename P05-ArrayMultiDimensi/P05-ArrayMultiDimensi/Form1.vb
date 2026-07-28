Public Class Form1
    'variabel matriks (array multi-dimensi)
    Dim matriksA(,) As Integer = {{3, 4, 5, 6}, {5, 3, 6, 2}, {4, 6, 3, 1}} '3 baris 4 kolom
    Dim matriksB(,) = {{1, 2.5, "tiga"}, {4, 5.5, "enam"}} '2 baris 3 kolom
    Private Sub BtnTampil_Click(sender As Object, e As EventArgs) Handles BtnTampil.Click
        TxtOutput.Text = "Matriks A" & vbNewLine
        For i = 0 To 2 'baris
            For j = 0 To 3 ' kolom
                TxtOutput.Text &= matriksA(i, j) & vbTab
            Next j
            TxtOutput.Text &= vbNewLine
        Next i

        TxtOutput.Text &= vbNewLine & "Matriks B" & vbNewLine
        For i = 0 To 1 'baris 
            For j = 0 To 2 'kolom
                TxtOutput.Text &= matriksB(i, j) & vbTab
            Next j
            TxtOutput.Text &= vbNewLine
        Next i
    End Sub
End Class
