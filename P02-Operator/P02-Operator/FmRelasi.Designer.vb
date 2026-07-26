<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmRelasi
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
        Me.TxtBilangan1 = New System.Windows.Forms.TextBox()
        Me.TxtBilangan2 = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnLB = New System.Windows.Forms.Button()
        Me.BtnLK = New System.Windows.Forms.Button()
        Me.BtnLBSD = New System.Windows.Forms.Button()
        Me.BtnLKSD = New System.Windows.Forms.Button()
        Me.BtnSD = New System.Windows.Forms.Button()
        Me.BtnTSD = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bilangan Pertama :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(139, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bilangan Kedua :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Hasil :"
        '
        'TxtBilangan1
        '
        Me.TxtBilangan1.Location = New System.Drawing.Point(334, 53)
        Me.TxtBilangan1.Name = "TxtBilangan1"
        Me.TxtBilangan1.Size = New System.Drawing.Size(327, 26)
        Me.TxtBilangan1.TabIndex = 1
        '
        'TxtBilangan2
        '
        Me.TxtBilangan2.Location = New System.Drawing.Point(334, 89)
        Me.TxtBilangan2.Name = "TxtBilangan2"
        Me.TxtBilangan2.Size = New System.Drawing.Size(327, 26)
        Me.TxtBilangan2.TabIndex = 1
        '
        'TxtHasil
        '
        Me.TxtHasil.Enabled = False
        Me.TxtHasil.Location = New System.Drawing.Point(229, 334)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(432, 26)
        Me.TxtHasil.TabIndex = 1
        '
        'BtnLB
        '
        Me.BtnLB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLB.Location = New System.Drawing.Point(143, 134)
        Me.BtnLB.Name = "BtnLB"
        Me.BtnLB.Size = New System.Drawing.Size(125, 56)
        Me.BtnLB.TabIndex = 2
        Me.BtnLB.Text = ">"
        Me.BtnLB.UseVisualStyleBackColor = True
        '
        'BtnLK
        '
        Me.BtnLK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLK.Location = New System.Drawing.Point(143, 196)
        Me.BtnLK.Name = "BtnLK"
        Me.BtnLK.Size = New System.Drawing.Size(125, 56)
        Me.BtnLK.TabIndex = 2
        Me.BtnLK.Text = "<"
        Me.BtnLK.UseVisualStyleBackColor = True
        '
        'BtnLBSD
        '
        Me.BtnLBSD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLBSD.Location = New System.Drawing.Point(274, 134)
        Me.BtnLBSD.Name = "BtnLBSD"
        Me.BtnLBSD.Size = New System.Drawing.Size(125, 56)
        Me.BtnLBSD.TabIndex = 2
        Me.BtnLBSD.Text = ">="
        Me.BtnLBSD.UseVisualStyleBackColor = True
        '
        'BtnLKSD
        '
        Me.BtnLKSD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLKSD.Location = New System.Drawing.Point(274, 196)
        Me.BtnLKSD.Name = "BtnLKSD"
        Me.BtnLKSD.Size = New System.Drawing.Size(125, 56)
        Me.BtnLKSD.TabIndex = 2
        Me.BtnLKSD.Text = "<="
        Me.BtnLKSD.UseVisualStyleBackColor = True
        '
        'BtnSD
        '
        Me.BtnSD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSD.Location = New System.Drawing.Point(405, 134)
        Me.BtnSD.Name = "BtnSD"
        Me.BtnSD.Size = New System.Drawing.Size(125, 56)
        Me.BtnSD.TabIndex = 2
        Me.BtnSD.Text = "="
        Me.BtnSD.UseVisualStyleBackColor = True
        '
        'BtnTSD
        '
        Me.BtnTSD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTSD.Location = New System.Drawing.Point(405, 196)
        Me.BtnTSD.Name = "BtnTSD"
        Me.BtnTSD.Size = New System.Drawing.Size(125, 56)
        Me.BtnTSD.TabIndex = 2
        Me.BtnTSD.Text = "<>"
        Me.BtnTSD.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Salmon
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(536, 134)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(125, 118)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FmRelasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnTSD)
        Me.Controls.Add(Me.BtnLKSD)
        Me.Controls.Add(Me.BtnLK)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSD)
        Me.Controls.Add(Me.BtnLBSD)
        Me.Controls.Add(Me.BtnLB)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtBilangan2)
        Me.Controls.Add(Me.TxtBilangan1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "FmRelasi"
        Me.Text = "FmRelasi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtBilangan1 As TextBox
    Friend WithEvents TxtBilangan2 As TextBox
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents BtnLB As Button
    Friend WithEvents BtnLK As Button
    Friend WithEvents BtnLBSD As Button
    Friend WithEvents BtnLKSD As Button
    Friend WithEvents BtnSD As Button
    Friend WithEvents BtnTSD As Button
    Friend WithEvents BtnCancel As Button
End Class
