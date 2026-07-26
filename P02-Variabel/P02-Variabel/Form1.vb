Public Class Form1

    'variabel

    Dim nama, usia As String
    Dim pesan = "Semangat Pro.Asta !!!"

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles BtnProses.Click
        'input nilai ke variabel
        nama = TxtNama.Text
        usia = TxtUsia.Text

        'output value variabel
        MsgBox("Nama Anda : " & nama & vbNewLine & "Usia Anda : " & usia & vbNewLine & pesan)

        TxtOutput.Text = TxtOutput.Text & "Nama Anda : " & nama & vbNewLine & "Usia Anda : " & usia & vbNewLine & pesan

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
