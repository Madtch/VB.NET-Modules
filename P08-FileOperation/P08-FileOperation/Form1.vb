Imports System.IO
Public Class Form1

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        If TxtPath.Text = "" Or TxtEditor.Text = "" Then
            MsgBox("Path Or Editor can't be empty!!")
            Exit Sub
        End If

        Dim createFile As StreamWriter
        createFile = File.CreateText(TxtPath.Text)

        Dim writeData As String
        writeData = TxtEditor.Text

        createFile.WriteLine(writeData)
        createFile.Close()

        MsgBox("File Created.")
        TxtPath.Clear()
        TxtEditor.Clear()
    End Sub

    Private Sub BtnRead_Click(sender As Object, e As EventArgs) Handles BtnRead.Click
        If TxtPath.Text = "" Then
            MsgBox("Path can't be empty!")
            Exit Sub
        End If

        Dim readFile As String
        Try
            readFile = My.Computer.FileSystem.ReadAllText(TxtPath.Text)
            TxtEditor.Text = readFile
        Catch ex As Exception
            MsgBox("File not found!")
        End Try
    End Sub
End Class
