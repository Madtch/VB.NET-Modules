<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmPenugasan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAngka = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnKali = New System.Windows.Forms.Button()
        Me.BtnBagi = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.BtnKurang = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(156, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukkan sebuah angka :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasil : "
        '
        'TxtAngka
        '
        Me.TxtAngka.Location = New System.Drawing.Point(361, 69)
        Me.TxtAngka.Name = "TxtAngka"
        Me.TxtAngka.Size = New System.Drawing.Size(100, 26)
        Me.TxtAngka.TabIndex = 1
        '
        'TxtHasil
        '
        Me.TxtHasil.Enabled = False
        Me.TxtHasil.Location = New System.Drawing.Point(218, 307)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(100, 26)
        Me.TxtHasil.TabIndex = 1
        '
        'BtnKali
        '
        Me.BtnKali.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnKali.Location = New System.Drawing.Point(155, 127)
        Me.BtnKali.Name = "BtnKali"
        Me.BtnKali.Size = New System.Drawing.Size(179, 59)
        Me.BtnKali.TabIndex = 2
        Me.BtnKali.Text = "*="
        Me.BtnKali.UseVisualStyleBackColor = True
        '
        'BtnBagi
        '
        Me.BtnBagi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBagi.Location = New System.Drawing.Point(155, 192)
        Me.BtnBagi.Name = "BtnBagi"
        Me.BtnBagi.Size = New System.Drawing.Size(179, 59)
        Me.BtnBagi.TabIndex = 2
        Me.BtnBagi.Text = "/="
        Me.BtnBagi.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTambah.Location = New System.Drawing.Point(340, 127)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(179, 59)
        Me.BtnTambah.TabIndex = 2
        Me.BtnTambah.Text = "+="
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'BtnKurang
        '
        Me.BtnKurang.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnKurang.Location = New System.Drawing.Point(340, 192)
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(179, 59)
        Me.BtnKurang.TabIndex = 2
        Me.BtnKurang.Text = "-="
        Me.BtnKurang.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Salmon
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(525, 127)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(127, 124)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FmPenugasan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnKurang)
        Me.Controls.Add(Me.BtnBagi)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.BtnKali)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtAngka)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FmPenugasan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Operator Penugasan (Assignment) :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAngka As TextBox
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents BtnKali As Button
    Friend WithEvents BtnBagi As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnKurang As Button
    Friend WithEvents BtnCancel As Button
End Class
