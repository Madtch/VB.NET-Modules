Public Class Form1
    'variabel
    Dim number() = {15, 23, 10, 3, 31, 29, 7, 40, 5, 18}
    Dim temp
    Dim lenNumber = number.GetUpperBound(0)
    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        'before sorting
        TxtSorting.Text = "Before Sorting" & vbNewLine
        For i = 0 To lenNumber
            TxtSorting.Text &= number(i) & " "
        Next

        'sorting process
        For i = 0 To lenNumber
            For j = i + 1 To lenNumber
                If number(i) > number(j) Then
                    temp = number(i)
                    number(i) = number(j)
                    number(j) = temp
                End If
            Next j
        Next i

        'after sorting
        TxtSorting.Text &= vbNewLine & vbNewLine & "After Sorting" & vbNewLine
        For i = 0 To lenNumber
            TxtSorting.Text &= number(i) & " "
        Next
    End Sub
End Class
