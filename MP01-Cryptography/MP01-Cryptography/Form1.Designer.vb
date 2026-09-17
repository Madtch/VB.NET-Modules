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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboKategori = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CboKunci = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCipher = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPlain = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnEnkripsi = New System.Windows.Forms.Button()
        Me.BtnDekripsi = New System.Windows.Forms.Button()
        Me.BtnBersih = New System.Windows.Forms.Button()
        Me.LblJam = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboKategori)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kategori"
        '
        'CboKategori
        '
        Me.CboKategori.FormattingEnabled = True
        Me.CboKategori.Location = New System.Drawing.Point(35, 32)
        Me.CboKategori.Name = "CboKategori"
        Me.CboKategori.Size = New System.Drawing.Size(121, 21)
        Me.CboKategori.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboKunci)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Location = New System.Drawing.Point(12, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 74)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kunci"
        '
        'CboKunci
        '
        Me.CboKunci.FormattingEnabled = True
        Me.CboKunci.Location = New System.Drawing.Point(35, 28)
        Me.CboKunci.Name = "CboKunci"
        Me.CboKunci.Size = New System.Drawing.Size(121, 21)
        Me.CboKunci.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtCipher)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtPlain)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 152)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Masukkan Kalimat"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Plainteks"
        '
        'TxtCipher
        '
        Me.TxtCipher.Location = New System.Drawing.Point(84, 87)
        Me.TxtCipher.Multiline = True
        Me.TxtCipher.Name = "TxtCipher"
        Me.TxtCipher.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtCipher.Size = New System.Drawing.Size(254, 57)
        Me.TxtCipher.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(6, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cipherteks"
        '
        'TxtPlain
        '
        Me.TxtPlain.Location = New System.Drawing.Point(84, 24)
        Me.TxtPlain.Multiline = True
        Me.TxtPlain.Name = "TxtPlain"
        Me.TxtPlain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtPlain.Size = New System.Drawing.Size(254, 57)
        Me.TxtPlain.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnEnkripsi)
        Me.GroupBox4.Controls.Add(Me.BtnDekripsi)
        Me.GroupBox4.Controls.Add(Me.BtnBersih)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Location = New System.Drawing.Point(218, 170)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 100)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Proses"
        '
        'BtnEnkripsi
        '
        Me.BtnEnkripsi.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnEnkripsi.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnEnkripsi.Location = New System.Drawing.Point(14, 34)
        Me.BtnEnkripsi.Name = "BtnEnkripsi"
        Me.BtnEnkripsi.Size = New System.Drawing.Size(99, 42)
        Me.BtnEnkripsi.TabIndex = 5
        Me.BtnEnkripsi.Text = "Enkripsi"
        Me.BtnEnkripsi.UseVisualStyleBackColor = False
        '
        'BtnDekripsi
        '
        Me.BtnDekripsi.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnDekripsi.ForeColor = System.Drawing.Color.AliceBlue
        Me.BtnDekripsi.Location = New System.Drawing.Point(127, 34)
        Me.BtnDekripsi.Name = "BtnDekripsi"
        Me.BtnDekripsi.Size = New System.Drawing.Size(99, 42)
        Me.BtnDekripsi.TabIndex = 6
        Me.BtnDekripsi.Text = "Dekripsi"
        Me.BtnDekripsi.UseVisualStyleBackColor = False
        '
        'BtnBersih
        '
        Me.BtnBersih.BackColor = System.Drawing.Color.Crimson
        Me.BtnBersih.Location = New System.Drawing.Point(240, 34)
        Me.BtnBersih.Name = "BtnBersih"
        Me.BtnBersih.Size = New System.Drawing.Size(99, 42)
        Me.BtnBersih.TabIndex = 7
        Me.BtnBersih.Text = "Bersih"
        Me.BtnBersih.UseVisualStyleBackColor = False
        '
        'LblJam
        '
        Me.LblJam.AutoSize = True
        Me.LblJam.Font = New System.Drawing.Font("MS Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblJam.ForeColor = System.Drawing.SystemColors.Control
        Me.LblJam.Location = New System.Drawing.Point(43, 214)
        Me.LblJam.Name = "LblJam"
        Me.LblJam.Size = New System.Drawing.Size(75, 19)
        Me.LblJam.TabIndex = 2
        Me.LblJam.Text = "Label3"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(582, 282)
        Me.Controls.Add(Me.LblJam)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = ".: Cryptography [Caesar Cipher] :."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblJam As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtCipher As TextBox
    Friend WithEvents TxtPlain As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnEnkripsi As Button
    Friend WithEvents CboKategori As ComboBox
    Friend WithEvents CboKunci As ComboBox
    Friend WithEvents BtnDekripsi As Button
    Friend WithEvents BtnBersih As Button
End Class
