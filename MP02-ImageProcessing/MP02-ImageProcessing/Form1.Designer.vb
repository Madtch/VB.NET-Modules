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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PicOriginal = New System.Windows.Forms.PictureBox()
        Me.PicGrayscale = New System.Windows.Forms.PictureBox()
        Me.PicBiner = New System.Windows.Forms.PictureBox()
        Me.TxtBrowse = New System.Windows.Forms.TextBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.BtnGrayscale = New System.Windows.Forms.Button()
        Me.BtnBiner = New System.Windows.Forms.Button()
        Me.OpenImage = New System.Windows.Forms.OpenFileDialog()
        Me.SaveImage = New System.Windows.Forms.SaveFileDialog()
        Me.BtnSaveGrayscale = New System.Windows.Forms.Button()
        Me.BtnSaveBiner = New System.Windows.Forms.Button()
        CType(Me.PicOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGrayscale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBiner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(111, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Citra Original"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(387, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Citra Grayscale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(680, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Citra Biner"
        '
        'PicOriginal
        '
        Me.PicOriginal.BackColor = System.Drawing.Color.Snow
        Me.PicOriginal.Location = New System.Drawing.Point(12, 30)
        Me.PicOriginal.Name = "PicOriginal"
        Me.PicOriginal.Size = New System.Drawing.Size(265, 252)
        Me.PicOriginal.TabIndex = 3
        Me.PicOriginal.TabStop = False
        '
        'PicGrayscale
        '
        Me.PicGrayscale.BackColor = System.Drawing.Color.Snow
        Me.PicGrayscale.Location = New System.Drawing.Point(294, 30)
        Me.PicGrayscale.Name = "PicGrayscale"
        Me.PicGrayscale.Size = New System.Drawing.Size(265, 252)
        Me.PicGrayscale.TabIndex = 4
        Me.PicGrayscale.TabStop = False
        '
        'PicBiner
        '
        Me.PicBiner.BackColor = System.Drawing.Color.Snow
        Me.PicBiner.Location = New System.Drawing.Point(575, 30)
        Me.PicBiner.Name = "PicBiner"
        Me.PicBiner.Size = New System.Drawing.Size(265, 252)
        Me.PicBiner.TabIndex = 5
        Me.PicBiner.TabStop = False
        '
        'TxtBrowse
        '
        Me.TxtBrowse.Location = New System.Drawing.Point(12, 290)
        Me.TxtBrowse.Name = "TxtBrowse"
        Me.TxtBrowse.Size = New System.Drawing.Size(184, 20)
        Me.TxtBrowse.TabIndex = 6
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnBrowse.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBrowse.Location = New System.Drawing.Point(202, 288)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.BtnBrowse.TabIndex = 7
        Me.BtnBrowse.Text = "Browse..."
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'BtnGrayscale
        '
        Me.BtnGrayscale.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnGrayscale.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnGrayscale.Location = New System.Drawing.Point(294, 288)
        Me.BtnGrayscale.Name = "BtnGrayscale"
        Me.BtnGrayscale.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrayscale.TabIndex = 8
        Me.BtnGrayscale.Text = "Grayscale"
        Me.BtnGrayscale.UseVisualStyleBackColor = False
        '
        'BtnBiner
        '
        Me.BtnBiner.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnBiner.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnBiner.Location = New System.Drawing.Point(575, 288)
        Me.BtnBiner.Name = "BtnBiner"
        Me.BtnBiner.Size = New System.Drawing.Size(75, 23)
        Me.BtnBiner.TabIndex = 9
        Me.BtnBiner.Text = "Biner"
        Me.BtnBiner.UseVisualStyleBackColor = False
        '
        'OpenImage
        '
        Me.OpenImage.FileName = "OpenFileDialog1"
        '
        'BtnSaveGrayscale
        '
        Me.BtnSaveGrayscale.BackColor = System.Drawing.Color.Crimson
        Me.BtnSaveGrayscale.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSaveGrayscale.Location = New System.Drawing.Point(375, 288)
        Me.BtnSaveGrayscale.Name = "BtnSaveGrayscale"
        Me.BtnSaveGrayscale.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveGrayscale.TabIndex = 8
        Me.BtnSaveGrayscale.Text = "Save As..."
        Me.BtnSaveGrayscale.UseVisualStyleBackColor = False
        '
        'BtnSaveBiner
        '
        Me.BtnSaveBiner.BackColor = System.Drawing.Color.Crimson
        Me.BtnSaveBiner.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnSaveBiner.Location = New System.Drawing.Point(656, 288)
        Me.BtnSaveBiner.Name = "BtnSaveBiner"
        Me.BtnSaveBiner.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveBiner.TabIndex = 9
        Me.BtnSaveBiner.Text = "Save As..."
        Me.BtnSaveBiner.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(852, 316)
        Me.Controls.Add(Me.BtnSaveBiner)
        Me.Controls.Add(Me.BtnBiner)
        Me.Controls.Add(Me.BtnSaveGrayscale)
        Me.Controls.Add(Me.BtnGrayscale)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.TxtBrowse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicBiner)
        Me.Controls.Add(Me.PicGrayscale)
        Me.Controls.Add(Me.PicOriginal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Image Processing [Representasi Citra dan Warna] :."
        CType(Me.PicOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGrayscale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBiner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PicOriginal As PictureBox
    Friend WithEvents PicGrayscale As PictureBox
    Friend WithEvents PicBiner As PictureBox
    Friend WithEvents TxtBrowse As TextBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents BtnGrayscale As Button
    Friend WithEvents BtnBiner As Button
    Friend WithEvents OpenImage As OpenFileDialog
    Friend WithEvents SaveImage As SaveFileDialog
    Friend WithEvents BtnSaveGrayscale As Button
    Friend WithEvents BtnSaveBiner As Button
End Class
