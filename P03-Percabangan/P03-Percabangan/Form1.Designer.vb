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
        Me.TxtNilai = New System.Windows.Forms.TextBox()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.BtnIf = New System.Windows.Forms.Button()
        Me.BtnIfElseifElse = New System.Windows.Forms.Button()
        Me.BtnIfElse = New System.Windows.Forms.Button()
        Me.BtnSelectCase = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Masukkan nilai :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Keterangan :"
        '
        'TxtNilai
        '
        Me.TxtNilai.Location = New System.Drawing.Point(280, 91)
        Me.TxtNilai.Name = "TxtNilai"
        Me.TxtNilai.Size = New System.Drawing.Size(287, 26)
        Me.TxtNilai.TabIndex = 1
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Enabled = False
        Me.TxtKeterangan.Location = New System.Drawing.Point(279, 138)
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(288, 26)
        Me.TxtKeterangan.TabIndex = 1
        '
        'BtnIf
        '
        Me.BtnIf.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIf.Location = New System.Drawing.Point(233, 196)
        Me.BtnIf.Name = "BtnIf"
        Me.BtnIf.Size = New System.Drawing.Size(159, 48)
        Me.BtnIf.TabIndex = 2
        Me.BtnIf.Text = "If Statement"
        Me.BtnIf.UseVisualStyleBackColor = True
        '
        'BtnIfElseifElse
        '
        Me.BtnIfElseifElse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIfElseifElse.Location = New System.Drawing.Point(233, 250)
        Me.BtnIfElseifElse.Name = "BtnIfElseifElse"
        Me.BtnIfElseifElse.Size = New System.Drawing.Size(159, 57)
        Me.BtnIfElseifElse.TabIndex = 2
        Me.BtnIfElseifElse.Text = "If-ElseIf-Else Statement"
        Me.BtnIfElseifElse.UseVisualStyleBackColor = True
        '
        'BtnIfElse
        '
        Me.BtnIfElse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIfElse.Location = New System.Drawing.Point(399, 196)
        Me.BtnIfElse.Name = "BtnIfElse"
        Me.BtnIfElse.Size = New System.Drawing.Size(168, 48)
        Me.BtnIfElse.TabIndex = 2
        Me.BtnIfElse.Text = "If-Else Statement"
        Me.BtnIfElse.UseVisualStyleBackColor = True
        '
        'BtnSelectCase
        '
        Me.BtnSelectCase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelectCase.Location = New System.Drawing.Point(399, 250)
        Me.BtnSelectCase.Name = "BtnSelectCase"
        Me.BtnSelectCase.Size = New System.Drawing.Size(168, 57)
        Me.BtnSelectCase.TabIndex = 2
        Me.BtnSelectCase.Text = "Select-Case Statement"
        Me.BtnSelectCase.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Salmon
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(233, 323)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(334, 68)
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
        Me.Controls.Add(Me.BtnSelectCase)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnIfElseifElse)
        Me.Controls.Add(Me.BtnIfElse)
        Me.Controls.Add(Me.BtnIf)
        Me.Controls.Add(Me.TxtKeterangan)
        Me.Controls.Add(Me.TxtNilai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Percabangan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNilai As TextBox
    Friend WithEvents TxtKeterangan As TextBox
    Friend WithEvents BtnIf As Button
    Friend WithEvents BtnIfElseifElse As Button
    Friend WithEvents BtnIfElse As Button
    Friend WithEvents BtnSelectCase As Button
    Friend WithEvents BtnCancel As Button
End Class
