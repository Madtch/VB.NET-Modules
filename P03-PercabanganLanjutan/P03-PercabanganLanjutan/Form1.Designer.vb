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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNilai = New System.Windows.Forms.TextBox()
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.TxtPredikat = New System.Windows.Forms.TextBox()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukkan Nilai : "
        '
        'TxtNilai
        '
        Me.TxtNilai.Location = New System.Drawing.Point(292, 72)
        Me.TxtNilai.Name = "TxtNilai"
        Me.TxtNilai.Size = New System.Drawing.Size(265, 26)
        Me.TxtNilai.TabIndex = 1
        '
        'BtnProcess
        '
        Me.BtnProcess.Location = New System.Drawing.Point(292, 126)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(127, 45)
        Me.BtnProcess.TabIndex = 2
        Me.BtnProcess.Text = "Process"
        Me.BtnProcess.UseVisualStyleBackColor = True
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(292, 198)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(265, 26)
        Me.TxtHasil.TabIndex = 1
        '
        'TxtPredikat
        '
        Me.TxtPredikat.Location = New System.Drawing.Point(292, 249)
        Me.TxtPredikat.Name = "TxtPredikat"
        Me.TxtPredikat.Size = New System.Drawing.Size(265, 26)
        Me.TxtPredikat.TabIndex = 1
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Location = New System.Drawing.Point(292, 295)
        Me.TxtKeterangan.Multiline = True
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtKeterangan.Size = New System.Drawing.Size(265, 120)
        Me.TxtKeterangan.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Hasil :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 249)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Predikat :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 295)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Keterangan :"
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Salmon
        Me.BtnCancel.Location = New System.Drawing.Point(430, 126)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(127, 45)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnProcess)
        Me.Controls.Add(Me.TxtKeterangan)
        Me.Controls.Add(Me.TxtPredikat)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtNilai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Percabangan Lanjutan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNilai As TextBox
    Friend WithEvents BtnProcess As Button
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents TxtPredikat As TextBox
    Friend WithEvents TxtKeterangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCancel As Button
End Class
