<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboKategori = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboKunci = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtCipher = New System.Windows.Forms.TextBox()
        Me.TxtPlain = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnEnkripsi = New System.Windows.Forms.Button()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.BtnDeksripsi = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblJam = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboKategori)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 220)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kategori"
        '
        'CboKategori
        '
        Me.CboKategori.FormattingEnabled = True
        Me.CboKategori.Location = New System.Drawing.Point(72, 62)
        Me.CboKategori.Name = "CboKategori"
        Me.CboKategori.Size = New System.Drawing.Size(177, 28)
        Me.CboKategori.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboKunci)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 220)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kunci"
        '
        'CboKunci
        '
        Me.CboKunci.FormattingEnabled = True
        Me.CboKunci.Location = New System.Drawing.Point(72, 60)
        Me.CboKunci.Name = "CboKunci"
        Me.CboKunci.Size = New System.Drawing.Size(177, 28)
        Me.CboKunci.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtCipher)
        Me.GroupBox3.Controls.Add(Me.TxtPlain)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(384, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(740, 464)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Masukkan Kalimat"
        '
        'TxtCipher
        '
        Me.TxtCipher.Location = New System.Drawing.Point(151, 244)
        Me.TxtCipher.Multiline = True
        Me.TxtCipher.Name = "TxtCipher"
        Me.TxtCipher.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtCipher.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtCipher.Size = New System.Drawing.Size(565, 154)
        Me.TxtCipher.TabIndex = 0
        '
        'TxtPlain
        '
        Me.TxtPlain.Location = New System.Drawing.Point(152, 66)
        Me.TxtPlain.Multiline = True
        Me.TxtPlain.Name = "TxtPlain"
        Me.TxtPlain.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPlain.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtPlain.Size = New System.Drawing.Size(565, 154)
        Me.TxtPlain.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cipherteks"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plainteks"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnEnkripsi)
        Me.GroupBox4.Controls.Add(Me.BtnBersih)
        Me.GroupBox4.Controls.Add(Me.BtnDeksripsi)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(384, 494)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(740, 141)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proses"
        '
        'BtnEnkripsi
        '
        Me.BtnEnkripsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnEnkripsi.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnEnkripsi.ForeColor = System.Drawing.Color.White
        Me.BtnEnkripsi.Location = New System.Drawing.Point(96, 44)
        Me.BtnEnkripsi.Name = "BtnEnkripsi"
        Me.BtnEnkripsi.Size = New System.Drawing.Size(166, 60)
        Me.BtnEnkripsi.TabIndex = 0
        Me.BtnEnkripsi.Text = "Enkripsi"
        Me.BtnEnkripsi.UseVisualStyleBackColor = False
        '
        'BtnBersih
        '
        Me.BtnBersih.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnBersih.BackColor = System.Drawing.Color.Crimson
        Me.BtnBersih.ForeColor = System.Drawing.Color.White
        Me.BtnBersih.Location = New System.Drawing.Point(440, 44)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(166, 60)
        Me.BtnBersih.TabIndex = 0
        Me.BtnBersih.Text = "Bersih"
        Me.BtnBersih.UseVisualStyleBackColor = False
        '
        'BtnDeksripsi
        '
        Me.BtnDeksripsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnDeksripsi.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnDeksripsi.ForeColor = System.Drawing.Color.White
        Me.BtnDeksripsi.Location = New System.Drawing.Point(268, 44)
        Me.BtnDeksripsi.Name = "BtnDeksripsi"
        Me.BtnDeksripsi.Size = New System.Drawing.Size(166, 60)
        Me.BtnDeksripsi.TabIndex = 0
        Me.BtnDeksripsi.Text = "Deksripsi"
        Me.BtnDeksripsi.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'LblJam
        '
        Me.LblJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJam.Location = New System.Drawing.Point(113, 551)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(108, 39)
        Me.LblJam.TabIndex = 1
        Me.LblJam.Text = "Label 3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1139, 656)
        Me.Controls.Add(Me.LblJam)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TxtPlain As TextBox
    Friend WithEvents TxtCipher As TextBox
    Friend WithEvents CboKategori As ComboBox
    Friend WithEvents CboKunci As ComboBox
    Friend WithEvents BtnDeksripsi As Button
    Friend WithEvents BtnEnkripsi As Button
    Friend WithEvents BtnBersih As Button
    Friend WithEvents LblJam As Label
End Class
