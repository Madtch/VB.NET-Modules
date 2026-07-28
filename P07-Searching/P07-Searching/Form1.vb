Imports System.ComponentModel.Design

Public Class Form1
    'variabel
    Dim number() = {15, 23, 10, 3, 31, 29, 7, 40, 5, 18}
    Dim key, loc
    Dim lenNumber = number.GetUpperBound(0)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'tampilkan data dari variabel number()
        TxtData.Text = "The Numbers" & vbNewLine
        For i = 0 To lenNumber
            TxtData.Text &= number(i) & " "
        Next
    End Sub

    Private Sub BtnProcess_Click(sender As Object, e As EventArgs) Handles BtnProcess.Click
        If TxtKey.Text = "" Then
            MsgBox("Key Can't be empty!")
            Exit Sub
        End If

        key = TxtKey.Text

        For i = 0 To lenNumber
            If number(i) = key Then
                loc = i + 1
                Exit For
            Else
                loc = 0
            End If
        Next

        If loc <> 0 Then
            MsgBox("Key Found at Position " & loc & " in the numbers")
        Else
            MsgBox("Couldn't find given key in the numbers!")
        End If
    End Sub
End Class
