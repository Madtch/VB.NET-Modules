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
        Me.TxtBrowse = New System.Windows.Forms.TextBox()
        Me.BtnBrowse = New System.Windows.Forms.Button()
        Me.OpenImage = New System.Windows.Forms.OpenFileDialog()
        Me.SaveImage = New System.Windows.Forms.SaveFileDialog()
        Me.BtnGrayscale = New System.Windows.Forms.Button()
        Me.BtnSaveGrayscale = New System.Windows.Forms.Button()
        Me.BtnBiner = New System.Windows.Forms.Button()
        Me.BtnSaveBiner = New System.Windows.Forms.Button()
        Me.PicOriginal = New System.Windows.Forms.PictureBox()
        Me.PicGrayScale = New System.Windows.Forms.PictureBox()
        Me.PicBiner = New System.Windows.Forms.PictureBox()
        CType(Me.PicOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGrayScale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicBiner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Citra Original"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Citra Grayscale"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(577, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Citra Biner"
        '
        'TxtBrowse
        '
        Me.TxtBrowse.Location = New System.Drawing.Point(55, 294)
        Me.TxtBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBrowse.Multiline = True
        Me.TxtBrowse.Name = "TxtBrowse"
        Me.TxtBrowse.Size = New System.Drawing.Size(121, 22)
        Me.TxtBrowse.TabIndex = 2
        '
        'BtnBrowse
        '
        Me.BtnBrowse.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnBrowse.Location = New System.Drawing.Point(180, 294)
        Me.BtnBrowse.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBrowse.Name = "BtnBrowse"
        Me.BtnBrowse.Size = New System.Drawing.Size(75, 32)
        Me.BtnBrowse.TabIndex = 3
        Me.BtnBrowse.Text = "Browse"
        Me.BtnBrowse.UseVisualStyleBackColor = False
        '
        'OpenImage
        '
        Me.OpenImage.FileName = "OpenImage"
        '
        'SaveImage
        '
        Me.SaveImage.FileName = "SaveImage"
        '
        'BtnGrayscale
        '
        Me.BtnGrayscale.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnGrayscale.Location = New System.Drawing.Point(279, 294)
        Me.BtnGrayscale.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnGrayscale.Name = "BtnGrayscale"
        Me.BtnGrayscale.Size = New System.Drawing.Size(75, 32)
        Me.BtnGrayscale.TabIndex = 3
        Me.BtnGrayscale.Text = "GrayScale"
        Me.BtnGrayscale.UseVisualStyleBackColor = False
        '
        'BtnSaveGrayscale
        '
        Me.BtnSaveGrayscale.BackColor = System.Drawing.Color.Red
        Me.BtnSaveGrayscale.Location = New System.Drawing.Point(358, 294)
        Me.BtnSaveGrayscale.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSaveGrayscale.Name = "BtnSaveGrayscale"
        Me.BtnSaveGrayscale.Size = New System.Drawing.Size(75, 32)
        Me.BtnSaveGrayscale.TabIndex = 3
        Me.BtnSaveGrayscale.Text = "Save As"
        Me.BtnSaveGrayscale.UseVisualStyleBackColor = False
        '
        'BtnBiner
        '
        Me.BtnBiner.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnBiner.Location = New System.Drawing.Point(511, 294)
        Me.BtnBiner.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBiner.Name = "BtnBiner"
        Me.BtnBiner.Size = New System.Drawing.Size(75, 32)
        Me.BtnBiner.TabIndex = 3
        Me.BtnBiner.Text = "Biner"
        Me.BtnBiner.UseVisualStyleBackColor = False
        '
        'BtnSaveBiner
        '
        Me.BtnSaveBiner.BackColor = System.Drawing.Color.Red
        Me.BtnSaveBiner.Location = New System.Drawing.Point(601, 294)
        Me.BtnSaveBiner.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnSaveBiner.Name = "BtnSaveBiner"
        Me.BtnSaveBiner.Size = New System.Drawing.Size(75, 32)
        Me.BtnSaveBiner.TabIndex = 3
        Me.BtnSaveBiner.Text = "Save As"
        Me.BtnSaveBiner.UseVisualStyleBackColor = False
        '
        'PicOriginal
        '
        Me.PicOriginal.Location = New System.Drawing.Point(55, 59)
        Me.PicOriginal.Name = "PicOriginal"
        Me.PicOriginal.Size = New System.Drawing.Size(200, 206)
        Me.PicOriginal.TabIndex = 4
        Me.PicOriginal.TabStop = False
        '
        'PicGrayScale
        '
        Me.PicGrayScale.Location = New System.Drawing.Point(279, 59)
        Me.PicGrayScale.Name = "PicGrayScale"
        Me.PicGrayScale.Size = New System.Drawing.Size(200, 206)
        Me.PicGrayScale.TabIndex = 4
        Me.PicGrayScale.TabStop = False
        '
        'PicBiner
        '
        Me.PicBiner.Location = New System.Drawing.Point(511, 59)
        Me.PicBiner.Name = "PicBiner"
        Me.PicBiner.Size = New System.Drawing.Size(200, 206)
        Me.PicBiner.TabIndex = 4
        Me.PicBiner.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 358)
        Me.Controls.Add(Me.PicBiner)
        Me.Controls.Add(Me.PicGrayScale)
        Me.Controls.Add(Me.PicOriginal)
        Me.Controls.Add(Me.BtnBiner)
        Me.Controls.Add(Me.BtnSaveBiner)
        Me.Controls.Add(Me.BtnSaveGrayscale)
        Me.Controls.Add(Me.BtnGrayscale)
        Me.Controls.Add(Me.BtnBrowse)
        Me.Controls.Add(Me.TxtBrowse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PicOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGrayScale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicBiner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBrowse As TextBox
    Friend WithEvents BtnBrowse As Button
    Friend WithEvents OpenImage As OpenFileDialog
    Friend WithEvents SaveImage As SaveFileDialog
    Friend WithEvents BtnGrayscale As Button
    Friend WithEvents BtnSaveGrayscale As Button
    Friend WithEvents BtnBiner As Button
    Friend WithEvents BtnSaveBiner As Button
    Friend WithEvents PicOriginal As PictureBox
    Friend WithEvents PicGrayScale As PictureBox
    Friend WithEvents PicBiner As PictureBox
End Class
