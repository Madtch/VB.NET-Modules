Imports System.IO
Public Class Form1
    Dim key, panjangInput As Integer
    Dim input, output, enkripsi, deksripsi As String

    Sub KondisiAwal()
        CboKategori.Enabled = True
        CboKunci.Enabled = False
        TxtPlain.Enabled = False
        TxtCipher.Enabled = False
        BtnEnkripsi.Enabled = False
        BtnEnkripsi.Enabled = False
        BtnBersih.Enabled = False

    End Sub

    Sub CreateFileLog()
        Dim createFile As StreamWriter
        createFile = File.CreateText("log.txt")

        Dim writePlain, writeCipher As String
        writePlain = TxtPlain.Text
        writeCipher = TxtCipher.Text

        createFile.WriteLine(writePlain & vbNewLine & vbNewLine & writeCipher)
        createFile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboKategori.Text = "---Pilih---"
        CboKategori.Items.Add("Enkripsi")
        CboKategori.Items.Add("Deksripsi")

        CboKunci.Text = "---Pilih---"
        For i = 65 To 90
            CboKunci.Items.Add(Chr(i))
        Next

        KondisiAwal()
    End Sub

    Private Sub CboKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboKategori.SelectedIndexChanged
        If CboKategori.Text <> "---Pilih---" Then
            CboKunci.Enabled = True
            CboKunci.Focus()
        End If
    End Sub

    Private Sub CboKunci_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboKunci.SelectedIndexChanged
        If CboKategori.Text = "Enkripsi" And CboKunci.Text <> "---Pilih---" Then
            TxtPlain.Enabled = True
            TxtPlain.Focus()
            TxtCipher.Enabled = True
            BtnEnkripsi.Enabled = False
            BtnDeksripsi.Enabled = False
        Else
            TxtCipher.Enabled = True
            TxtCipher.Focus()
            TxtPlain.Enabled = True
            BtnDeksripsi.Enabled = True
            BtnEnkripsi.Enabled = False
        End If
    End Sub

    Private Sub TxtPlain_TextChanged(sender As Object, e As EventArgs) Handles TxtPlain.TextChanged
        If TxtPlain.Text = "" Then
            BtnBersih.Enabled = False
        Else
            BtnBersih.Enabled = True
        End If
    End Sub

    Private Sub BtnEnkripsi_Click(sender As Object, e As EventArgs) Handles BtnEnkripsi.Click
        key = Asc(CboKunci.Text) - 64
        input = TxtPlain.Text
        panjangInput = Len(input)
        output = ""

        For i = 1 To panjangInput
            enkripsi = Mid(input, i, 1)
            enkripsi = (Asc(enkripsi) + key) Mod 256
            enkripsi = Chr(enkripsi)
            output &= enkripsi
        Next i

        TxtCipher.Text = output
        CreateFileLog()
        MsgBox("Proses Enkripsi Berhasil!")
    End Sub

    Private Sub BtnDeksripsi_Click(sender As Object, e As EventArgs) Handles BtnDeksripsi.Click
        key = Asc(CboKunci.Text) - 64
        input = TxtCipher.Text
        panjangInput = Len(input)
        output = ""

        For i = 1 To panjangInput
            deksripsi = Mid(input, i, 1)
            deksripsi = Asc(deksripsi) - key
            If deksripsi < 0 Then
                deksripsi = 256 - Math.Abs(CInt(deksripsi))
            End If
            deksripsi = Chr(deksripsi)
            output &= deksripsi
        Next i

        TxtCipher.Text = output
        CreateFileLog()
        MsgBox("Proses Deksripsi Berhasil!")
    End Sub

    Private Sub BtnBersih_Click(sender As Object, e As EventArgs) Handles BtnBersih.Click
        TxtPlain.Text = ""
        TxtCipher.Text = ""
        If CboKategori.Text = "Enkripsi" Then
            TxtPlain.Focus()
        Else
            TxtCipher.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = Format(Now, "h:m:s tt")
    End Sub
End Class
