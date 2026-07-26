<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmAritmatika
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBilangan1 = New System.Windows.Forms.TextBox()
        Me.TxtBilangan2 = New System.Windows.Forms.TextBox()
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.BtnBagi = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.BtnPangkat = New System.Windows.Forms.Button()
        Me.BtnMod = New System.Windows.Forms.Button()
        Me.BtnMerge = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilangan Pertama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bilangan Kedua :"
        '
        'TxtBilangan1
        '
        Me.TxtBilangan1.Location = New System.Drawing.Point(238, 83)
        Me.TxtBilangan1.Name = "TxtBilangan1"
        Me.TxtBilangan1.Size = New System.Drawing.Size(193, 26)
        Me.TxtBilangan1.TabIndex = 1
        '
        'TxtBilangan2
        '
        Me.TxtBilangan2.Location = New System.Drawing.Point(238, 145)
        Me.TxtBilangan2.Name = "TxtBilangan2"
        Me.TxtBilangan2.Size = New System.Drawing.Size(193, 26)
        Me.TxtBilangan2.TabIndex = 1
        '
        'BtnKali
        '
        Me.BtnKali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnKali.Location = New System.Drawing.Point(93, 201)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(105, 50)
        Me.BtnKali.TabIndex = 2
        Me.BtnKali.Text = "Kali"
        Me.BtnKali.UseVisualStyleBackColor = True
        '
        'BtnBagi
        '
        Me.BtnBagi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBagi.Location = New System.Drawing.Point(93, 257)
        Me.BtnBagi.Name = "BtnBagi"
        Me.BtnBagi.Size = New System.Drawing.Size(105, 50)
        Me.BtnBagi.TabIndex = 2
        Me.BtnBagi.Text = "Bagi"
        Me.BtnBagi.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Location = New System.Drawing.Point(204, 201)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(105, 50)
        Me.BtnTambah.TabIndex = 2
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnKurang
        '
        Me.BtnKurang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnKurang.Location = New System.Drawing.Point(204, 257)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(105, 50)
        Me.BtnKurang.TabIndex = 2
        Me.BtnKurang.Text = "Kurang"
        Me.BtnKurang.UseVisualStyleBackColor = True
        '
        'BtnPangkat
        '
        Me.BtnPangkat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPangkat.Location = New System.Drawing.Point(315, 201)
        Me.BtnPangkat.Name = "BtnPangkat"
        Me.BtnPangkat.Size = New System.Drawing.Size(105, 50)
        Me.BtnPangkat.TabIndex = 2
        Me.BtnPangkat.Text = "Pangkat"
        Me.BtnPangkat.UseVisualStyleBackColor = True
        '
        'BtnMod
        '
        Me.BtnMod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMod.Location = New System.Drawing.Point(315, 257)
        Me.BtnMod.Name = "BtnMod"
        Me.BtnMod.Size = New System.Drawing.Size(105, 50)
        Me.BtnMod.TabIndex = 2
        Me.BtnMod.Text = "Mod"
        Me.BtnMod.UseVisualStyleBackColor = True
        '
        'BtnMerge
        '
        Me.BtnMerge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMerge.Location = New System.Drawing.Point(426, 201)
        Me.BtnMerge.Name = "BtnMerge"
        Me.BtnMerge.Size = New System.Drawing.Size(105, 50)
        Me.BtnMerge.TabIndex = 2
        Me.BtnMerge.Text = "Merge"
        Me.BtnMerge.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Salmon
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(426, 257)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(105, 50)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 353)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hasil :"
        '
        'TxtHasil
        '
        Me.TxtHasil.Enabled = False
        Me.TxtHasil.Location = New System.Drawing.Point(147, 353)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(193, 26)
        Me.TxtHasil.TabIndex = 1
        '
        'FmAritmatika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(776, 486)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnMod)
        Me.Controls.Add(Me.BtnKurang)
        Me.Controls.Add(Me.BtnBagi)
        Me.Controls.Add(Me.BtnMerge)
        Me.Controls.Add(Me.BtnPangkat)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnKali)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtBilangan2)
        Me.Controls.Add(Me.TxtBilangan1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FmAritmatika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Operator Aritmatika :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBilangan1 As TextBox
    Friend WithEvents TxtBilangan2 As TextBox
    Friend WithEvents BtnKali As Button
    Friend WithEvents BtnBagi As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnKurang As Button
    Friend WithEvents BtnPangkat As Button
    Friend WithEvents BtnMod As Button
    Friend WithEvents BtnMerge As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtHasil As TextBox
End Class
