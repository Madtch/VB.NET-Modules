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
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsia = New System.Windows.Forms.TextBox()
        Me.TxtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(320, 196)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(116, 46)
        Me.BtnProses.TabIndex = 0
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(175, 66)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(413, 26)
        Me.TxtNama.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Masukkan Nama Anda :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Masukkan Usia Anda :"
        '
        'TxtUsia
        '
        Me.TxtUsia.Location = New System.Drawing.Point(175, 154)
        Me.TxtUsia.Name = "TxtUsia"
        Me.TxtUsia.Size = New System.Drawing.Size(413, 26)
        Me.TxtUsia.TabIndex = 1
        '
        'TxtOutput
        '
        Me.TxtOutput.Location = New System.Drawing.Point(175, 261)
        Me.TxtOutput.Multiline = True
        Me.TxtOutput.Name = "TxtOutput"
        Me.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOutput.Size = New System.Drawing.Size(413, 177)
        Me.TxtOutput.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtOutput)
        Me.Controls.Add(Me.TxtUsia)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.BtnProses)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " .:Variabel:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnProses As Button
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsia As TextBox
    Friend WithEvents TxtOutput As TextBox
End Class
