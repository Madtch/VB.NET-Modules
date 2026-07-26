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
        Me.BtnAritmatika = New System.Windows.Forms.Button()
        Me.BtnRelasi = New System.Windows.Forms.Button()
        Me.BtnPenugasan = New System.Windows.Forms.Button()
        Me.BtnLogika = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnAritmatika
        '
        Me.BtnAritmatika.Location = New System.Drawing.Point(170, 96)
        Me.BtnAritmatika.Name = "BtnAritmatika"
        Me.BtnAritmatika.Size = New System.Drawing.Size(224, 108)
        Me.BtnAritmatika.TabIndex = 0
        Me.BtnAritmatika.Text = "Operator Aritmatika"
        Me.BtnAritmatika.UseVisualStyleBackColor = True
        '
        'BtnRelasi
        '
        Me.BtnRelasi.Location = New System.Drawing.Point(170, 219)
        Me.BtnRelasi.Name = "BtnRelasi"
        Me.BtnRelasi.Size = New System.Drawing.Size(224, 108)
        Me.BtnRelasi.TabIndex = 0
        Me.BtnRelasi.Text = "Operator Relasi"
        Me.BtnRelasi.UseVisualStyleBackColor = True
        '
        'BtnPenugasan
        '
        Me.BtnPenugasan.Location = New System.Drawing.Point(400, 96)
        Me.BtnPenugasan.Name = "BtnPenugasan"
        Me.BtnPenugasan.Size = New System.Drawing.Size(224, 108)
        Me.BtnPenugasan.TabIndex = 0
        Me.BtnPenugasan.Text = "Operator Penugasan"
        Me.BtnPenugasan.UseVisualStyleBackColor = True
        '
        'BtnLogika
        '
        Me.BtnLogika.Location = New System.Drawing.Point(400, 219)
        Me.BtnLogika.Name = "BtnLogika"
        Me.BtnLogika.Size = New System.Drawing.Size(224, 108)
        Me.BtnLogika.TabIndex = 0
        Me.BtnLogika.Text = "Operator Logika"
        Me.BtnLogika.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnLogika)
        Me.Controls.Add(Me.BtnPenugasan)
        Me.Controls.Add(Me.BtnRelasi)
        Me.Controls.Add(Me.BtnAritmatika)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Operator :."
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnAritmatika As Button
    Friend WithEvents BtnRelasi As Button
    Friend WithEvents BtnPenugasan As Button
    Friend WithEvents BtnLogika As Button
End Class
