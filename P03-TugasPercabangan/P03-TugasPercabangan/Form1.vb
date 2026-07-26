Public Class Form1

    Private Sub TxtAngka1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAngka1.KeyPress
        'logika hanya angka dan backspace
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtAngka2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAngka2.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComBox.SelectedIndexChanged

    End Sub

    Private Sub BtnIfElseif_Click(sender As Object, e As EventArgs) Handles BtnIfElseif.Click
        Dim angka1, angka2 As Double
        Dim hasil As String
        Dim op As String = ComBox.Text

        'validasi input kedua angka
        If TxtAngka1.Text = "" Or TxtAngka2.Text = "" Then
            TxtHasil.Text = "Isi Dulu Kedua Angka!"
            Exit Sub
        End If


        angka1 = CDbl(TxtAngka1.Text)
        angka2 = CDbl(TxtAngka2.Text)

        If op = "*" Then
            hasil = angka1 * angka2
        ElseIf op = "/" Then
            hasil = angka1 / angka2
        ElseIf op = "+" Then
            hasil = angka1 + angka2
        ElseIf op = "-" Then
            hasil = angka1 - angka2
        ElseIf op = "^" Then
            hasil = angka1 ^ angka2
        ElseIf op = "%" Then
            hasil = angka1 Mod angka2
        ElseIf op = "&" Then
            hasil = TxtAngka1.Text & TxtAngka2.Text
        Else
            hasil = "Masukkan Angka Yang Benar!"
        End If

        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnSelectCase_Click(sender As Object, e As EventArgs) Handles BtnSelectCase.Click
        Dim angka1, angka2 As Double
        Dim hasil As String
        Dim op As String = ComBox.Text

        'validasi input kedua angka
        If TxtAngka1.Text = "" Or TxtAngka2.Text = "" Then
            TxtHasil.Text = "Isi Dulu Kedua Angka!"
            Exit Sub
        End If

        angka1 = CDbl(TxtAngka1.Text)
        angka2 = CDbl(TxtAngka2.Text)

        Select Case op
            Case "*"
                hasil = angka1 * angka2
            Case "/"
                hasil = angka1 / angka2
            Case "+"
                hasil = angka1 + angka2
            Case "-"
                hasil = angka1 - angka2
            Case "^"
                hasil = angka1 ^ angka2
            Case "%"
                hasil = angka1 Mod angka2
            Case "&"
                hasil = TxtAngka1.Text & TxtAngka2.Text
            Case Else
                hasil = "Pilih operator terlebih dahulu!"
        End Select

        TxtHasil.Text = hasil
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        TxtAngka1.Clear()
        TxtAngka2.Clear()
        ComBox.Text = ""
        TxtHasil.Clear()
    End Sub

    Private Sub TxtHasil_TextChanged(sender As Object, e As EventArgs) Handles TxtHasil.TextChanged

    End Sub

End Class
