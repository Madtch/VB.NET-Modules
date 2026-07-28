<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnTampil = New System.Windows.Forms.Button()
        Me.TxtOutput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTampil
        '
        Me.BtnTampil.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnTampil.ForeColor = System.Drawing.Color.White
        Me.BtnTampil.Location = New System.Drawing.Point(127, 45)
        Me.BtnTampil.Name = "BtnTampil"
        Me.BtnTampil.Size = New System.Drawing.Size(172, 43)
        Me.BtnTampil.TabIndex = 0
        Me.BtnTampil.Text = "Tampilkan Isi Matriks"
        Me.BtnTampil.UseVisualStyleBackColor = False
        '
        'TxtOutput
        '
        Me.TxtOutput.Location = New System.Drawing.Point(127, 115)
        Me.TxtOutput.Multiline = True
        Me.TxtOutput.Name = "TxtOutput"
        Me.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOutput.Size = New System.Drawing.Size(492, 253)
        Me.TxtOutput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.PapayaWhip
        Me.Label1.Location = New System.Drawing.Point(127, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 51)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Array multi dimensi diimplementasikan sebagai array yang terletak di dalam array " &
    "(matriks)."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtOutput)
        Me.Controls.Add(Me.BtnTampil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Array Multi Dimensi :"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTampil As Button
    Friend WithEvents TxtOutput As TextBox
    Friend WithEvents Label1 As Label
End Class
