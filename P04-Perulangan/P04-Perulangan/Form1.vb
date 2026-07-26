Public Class Form1
    'variabel
    Dim input As Integer

    Private Sub TxtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtInput.KeyPress
        'logika hanya boleh angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled() = True
        End If
    End Sub

    Private Sub BtnFor_Click(sender As Object, e As EventArgs) Handles BtnFor.Click
        TxtOutput.Clear()
        TxtOutput.Text &= "--- Perulangan dengan For - Next ----" & vbNewLine

        input = Val(TxtInput.Text)

        For i = 1 To input 'step +1
            TxtOutput.Text &= "Perulangan Ke-" & i & vbNewLine
        Next
    End Sub

    Private Sub BtnWhile_Click(sender As Object, e As EventArgs) Handles BtnWhile.Click
        TxtOutput.Clear()
        TxtOutput.Text &= "--- Perulangan dengan While - End While ----" & vbNewLine

        input = Val(TxtInput.Text)

        Dim i As Integer = 1
        While i <= input
            TxtOutput.Text &= "Perulangan Ke-" & i & vbNewLine
            i += 1 'pertambahan 1
        End While
    End Sub

    Private Sub BtnDoWhile_Click(sender As Object, e As EventArgs) Handles BtnDoWhile.Click
        TxtOutput.Clear()
        TxtOutput.Text &= "--- Perulangan dengan Do While - Loop ----" & vbNewLine

        input = Val(TxtInput.Text)

        Dim i As Integer = 1
        Do While i <= input
            TxtOutput.Text &= "Perulangan Ke-" & i & vbNewLine
            i += 1 'pertambahan 1
        Loop
    End Sub

    Private Sub BtnDo_Click(sender As Object, e As EventArgs) Handles BtnDo.Click
        TxtOutput.Clear()
        TxtOutput.Text &= "--- Perulangan dengan Do - Loop While ----" & vbNewLine

        input = Val(TxtInput.Text)

        Dim i As Integer = 1
        Do
            TxtOutput.Text &= "Perulangan Ke-" & i & vbNewLine
            i += 1 'pertambahan 1
        Loop While i <= input
    End Sub

    Private Sub BtnBoom_Click(sender As Object, e As EventArgs) Handles BtnBoom.Click
        TxtOutput.Clear()
        TxtOutput.Text &= "--- Perulangan BOOM !!! pada kelipatan 5 ----" & vbNewLine

        input = Val(TxtInput.Text)

        For i = 1 To input
            If i Mod 5 = 0 Then
                TxtOutput.Text &= "BOOM !!!" & vbNewLine
                Continue For
            End If
            TxtOutput.Text &= "Perulangan Ke-" & i & vbNewLine
        Next
    End Sub
End Class
