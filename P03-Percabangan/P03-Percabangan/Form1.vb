Public Class Form1
    'variabel
    Dim nilai As Integer
    Dim keterangan As String
    Private Sub TxtNilai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNilai.KeyPress
        'logika hanya boleh angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnIf_Click(sender As Object, e As EventArgs) Handles BtnIf.Click
        nilai = Val(TxtNilai.Text)

        'If Statement
        If nilai > 60 Then
            keterangan = "Lulus"
        End If

        TxtKeterangan.Text = keterangan
    End Sub

    Private Sub BtnIfElse_Click(sender As Object, e As EventArgs) Handles BtnIfElse.Click
        nilai = Val(TxtNilai.Text)

        'If-Else Statement
        If nilai > 60 Then
            keterangan = "Lulus"
        Else
            keterangan = "Tidak Lulus"
        End If

        TxtKeterangan.Text = keterangan
    End Sub

    Private Sub BtnIfElseIfElse_Click(sender As Object, e As EventArgs) Handles BtnIfElseifElse.Click
        nilai = Val(TxtNilai.Text)

        'If-Else if-Else Statement
        If nilai > 80 Then
            keterangan = "Lulus dengan Predikat A"
        ElseIf nilai > 70 And nilai <= 80 Then
            keterangan = "Lulus dengan Predikat B"
        ElseIf nilai > 60 And nilai <= 70 Then
            keterangan = "Lulus dengan Predikat C"
        Else
            keterangan = "Tidak Lulus"
        End If

        TxtKeterangan.Text = keterangan
    End Sub

    Private Sub BtnSelectCase_Click(sender As Object, e As EventArgs) Handles BtnSelectCase.Click
        nilai = Val(TxtNilai.Text)

        Select Case nilai
            Case > 80
                keterangan = "Lulus dengan Predikat A"
            Case > 70
                keterangan = "Lulus dengan Predikat B"
            Case > 60
                keterangan = "Lulus dengan Predikat C"
            Case Else
                keterangan = "Tidak Lulus"
        End Select
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtNilai.Clear()
        TxtKeterangan.Clear()
        nilai = 0
        keterangan = ""
    End Sub
End Class
