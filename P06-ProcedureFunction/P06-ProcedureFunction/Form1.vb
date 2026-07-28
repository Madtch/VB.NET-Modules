Public Class Form1
    'PROCEDURE
    'procedure tanpa parameter
    Sub Hello()
        TxtProcOutput.Text &= "Hello World!" & vbNewLine
    End Sub

    'procedure dengan parameter
    Sub Message(paramMessage)
        TxtProcOutput.Text &= paramMessage & vbNewLine
    End Sub
    Private Sub BtnProcedure_Click(sender As Object, e As EventArgs) Handles BtnProcedure.Click
        If TxtProcInput.Text = "" Then
            Hello()
        Else
            Message(TxtProcInput.Text)
        End If
    End Sub

    'FUNCTION
    'function tanpa parameter
    Function Hitung()
        Dim hasilHitung = 10 * 2
        Return hasilHitung
    End Function

    'function dengan parameter
    Function Pangkat(num1, num2)
        Dim hasilPangkat = num1 ^ num2
        Return hasilPangkat
    End Function

    Private Sub BtnFunction_Click(sender As Object, e As EventArgs) Handles BtnFunction.Click
        If TxtNum1.Text = "" Or TxtNum2.Text = "" Then
            Dim tambahHitung = Hitung() + 2
            TxtFuncOutput.Text &= tambahHitung & vbNewLine
        Else
            TxtFuncOutput.Text &= Pangkat(TxtNum1.Text, TxtNum2.Text) & vbNewLine
        End If
    End Sub
End Class
