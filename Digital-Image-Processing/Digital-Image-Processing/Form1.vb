Imports System.Drawing.Imaging 'library untuk save file image

Public Class Form1
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click, BtnSaveBiner.Click, BtnBiner.Click, BtnSaveGrayscale.Click, BtnGrayscale.Click
        With OpenImage
            .FileName = String.Empty
            .InitialDirectory = "D:"
            .Title = "Open Image File"
            .Filter = "JPG/JPEG/PNG/BMP|*.jpg;*.jpeg;*.png;*.bmp"
        End With

        Dim result As DialogResult = OpenImage.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Try
                TxtBrowse.Text = OpenImage.FileName
                PicOriginal.ImageLocation = OpenImage.FileName
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub BtnGrayscale_Click(sender As Object, e As EventArgs) Handles BtnGrayscale.Click
        If PicOriginal.Image Is Nothing Then
            MsgBox("Peringatan: Citra original tidak ada !!")
            Exit Sub
        End If

        Dim picture As New Bitmap(PicOriginal.Image)
        Dim x, y, warna As Integer
        For x = 0 To picture.Width - 1
            For y = 0 To picture.Height - 1
                Dim p = picture.GetPixel(x, y)
                warna = CInt((p.R * 1 + p.G * 1 + p.B * 1) / 3)
                picture.SetPixel(x, y, Color.FromArgb(warna, warna, warna))
            Next y
        Next x
        PicGrayscale.Image = picture
    End Sub

    Private Sub BtnSaveGrayscale_Click(sender As Object, e As EventArgs) Handles BtnSaveGrayscale.Click
        If PicGrayscale.Image Is Nothing Then
            MsgBox("Peringatan: Citra grayscale tidak ada!!")
            Exit Sub
        End If

        SaveImage.Filter = "PNG | *.png"
        If SaveImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.CreateDirectory("My Pictures")
            PicGrayscale.Image.Save(SaveImage.FileName, ImageFormat.Png)
            MsgBox("Citra grayscale tersimpan.")
        End If
    End Sub

    Private Sub BtnBiner_Click(sender As Object, e As EventArgs) Handles BtnBiner.Click
        If PicOriginal.Image Is Nothing Then
            MsgBox("Peringatan: Citra original tidak ada!!")
            Exit Sub
        End If

        Dim picture As New Bitmap(PicOriginal.Image)
        Dim x, y, warna As Integer
        For x = 0 To picture.Width - 1
            For y = 0 To picture.Height - 1
                Dim p = picture.GetPixel(x, y)
                warna = CInt((p.R * 1 + p.G * 1 + p.B * 1) / 3)
                If warna > 150 Then 'treshold (ambang batas)
                    warna = 255
                Else
                    warna = 0
                End If
                picture.SetPixel(x, y, Color.FromArgb(warna, warna, warna))
            Next y
        Next x
        PicBiner.Image = picture
    End Sub

    Private Sub BtnSaveBiner_Click(sender As Object, e As EventArgs) Handles BtnSaveBiner.Click
        If PicBiner.Image Is Nothing Then
            MsgBox("Peringatan: Citra biner tidak ada!!")
            Exit Sub
        End If

        SaveImage.Filter = "PNG | *.png"
        If SaveImage.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.CreateDirectory("My Pictures")
            PicBiner.Image.Save(SaveImage.FileName, ImageFormat.Png)
            MsgBox("Citra biner tersimpan.")
        End If
    End Sub
End Class