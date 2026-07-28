Public Class Form1
    'variabel array
    Dim angka() As Integer = {27, 14, 49, 30, 34, 75, 90, 12, 43, 18}

    Private Sub LinkArray_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkArray.LinkClicked
        TxtOutputArray.Clear()
        Dim arrayLength = angka.GetUpperBound(0)

        For index = 0 To arrayLength
            TxtOutputArray.Text &= "index [" & index & "] -> " & angka(index) & vbNewLine
        Next

        'mencari elemen array tertinggi
        Dim tertinggi As Integer = 0
        Dim indexTertinggi As Integer = 0

        For index = 0 To arrayLength
            If angka(index) > tertinggi Then
                tertinggi = angka(index)
                indexTertinggi = index
            Else
                tertinggi = tertinggi
                indexTertinggi = indexTertinggi
            End If
        Next
        TxtOutputArray.Text &= vbNewLine & "Elemen tertinggi = " & tertinggi & " -> index [" & indexTertinggi & "]" & vbNewLine

        'mencari elemen array terendah
        Dim terendah As Integer = tertinggi
        Dim indexTerendah As Integer = 0

        For index = 0 To arrayLength
            If angka(index) < terendah Then
                terendah = angka(index)
                indexTerendah = index
            Else
                terendah = terendah
                indexTerendah = indexTerendah
            End If
        Next
        TxtOutputArray.Text &= "Elemen terendah = " & terendah & " -> index[" & indexTerendah & "]" & vbNewLine

        'mencari total elemen
        Dim total = 0
        For index = 0 To arrayLength
            total += angka(index)
        Next
        TxtOutputArray.Text &= "Total elemen = " & total & vbNewLine

        'mencari rata-rata elemen
        Dim rata2 = 0.0
        rata2 = total / (arrayLength + 1)
        TxtOutputArray.Text &= "Rata-rata elemen = " & FormatNumber(rata2, 3)
    End Sub

    'variabel matriks
    Dim matriksA(,) As Integer = {{3, 4, 5, 6}, {5, 3, 6, 2}, {4, 6, 3, 1}} '3 baris 4 kolom
    Dim matriksB(,) = {{4, 2, 3, 1}, {3, 3, 1, 4}, {6, 3, 3, 2}} '3 baris 4 kolom
    Dim matriksC(2, 3), matriksD(2, 3) As Integer '3 baris 4 kolom (start index 0)

    'variabel untuk perkalian matriks
    'kolom matriks X = baris matriks Y
    Dim matriksX(,) = {{3, 4, 6}, {5, 3, 2}} '2 baris 3 kolom
    Dim matriksY(,) = {{4, 2, 3}, {3, 3, 4}, {6, 3, 2}} '3 baris 3 kolom
    'hasil = baris matriks X kolom matriks Y
    Dim matriksZ(1, 2) As Integer '2 baris 3 kolom

    Private Sub LinkMatriks_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkMatriks.LinkClicked
        'penjumlahan dan pengurangan matriks
        TxtOutputMatriks.Text = "Matriks A" & vbNewLine
        For i = 0 To 2 'baris
            For j = 0 To 3 'kolom
                TxtOutputMatriks.Text &= matriksA(i, j) & vbTab
            Next j
            TxtOutputMatriks.Text &= vbNewLine
        Next i
        TxtOutputMatriks.Text &= vbNewLine & "Matriks B" & vbNewLine
        For i = 0 To 2 'baris
            For j = 0 To 3 'kolom
                TxtOutputMatriks.Text &= matriksB(i, j) & vbTab
            Next j
            TxtOutputMatriks.Text &= vbNewLine
        Next i

        'operasi penjumlahan
        TxtOutputMatriks.Text &= vbNewLine & "Hasil penjumlahan Matriks" & vbNewLine
        For i = 0 To 2 'baris
            For j = 0 To 3 'kolom
                matriksC(i, j) = matriksA(i, j) + matriksB(i, j)
                TxtOutputMatriks.Text &= matriksC(i, j) & vbTab
            Next j
            TxtOutputMatriks.Text &= vbNewLine
        Next i

        'operasi pengurangan
        TxtOutputMatriks.Text &= vbNewLine & "Hasil pengurangan Matriks" & vbNewLine
        For i = 0 To 2 'baris
            For j = 0 To 3 'kolom
                matriksD(i, j) = matriksA(i, j) - matriksB(i, j)
                TxtOutputMatriks.Text &= matriksD(i, j) & vbTab
            Next j
            TxtOutputMatriks.Text &= vbNewLine
        Next i

        'perkalian matriks
        TxtOutputMatriks.Text &= vbNewLine & "Matriks X" & vbNewLine
        For i = 0 To 1 'baris
            For j = 0 To 2 'kolom
                TxtOutputMatriks.Text &= matriksX(i, j) & vbTab
            Next
            TxtOutputMatriks.Text &= vbNewLine
        Next

        TxtOutputMatriks.Text &= vbNewLine & "Matriks Y " & vbNewLine
        For i = 0 To 2 'baris
            For j = 0 To 2 'kolom
                TxtOutputMatriks.Text &= matriksY(i, j) & vbTab
            Next
            TxtOutputMatriks.Text &= vbNewLine
        Next

        'operasi perkalian
        TxtOutputMatriks.Text &= vbNewLine & "Hasil perkalian Matriks" & vbNewLine
        For i = 0 To 1 'baris
            For j = 0 To 2 'kolom
                Dim jumlah = 0
                For k = 0 To 2 'kolom matriks X baris matriks Y
                    jumlah += matriksX(i, k) * matriksY(k, j)
                Next
                matriksZ(i, j) = jumlah
                TxtOutputMatriks.Text &= matriksZ(i, j) & vbTab
            Next
                TxtOutputMatriks.Text &= vbNewLine
        Next
    End Sub
End Class
