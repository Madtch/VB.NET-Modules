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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LinkArray = New System.Windows.Forms.LinkLabel()
        Me.TxtOutputArray = New System.Windows.Forms.TextBox()
        Me.TxtOutputMatriks = New System.Windows.Forms.TextBox()
        Me.LinkMatriks = New System.Windows.Forms.LinkLabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(79, 46)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(649, 368)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TxtOutputArray)
        Me.TabPage1.Controls.Add(Me.LinkArray)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(641, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Operasi Array"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LinkMatriks)
        Me.TabPage2.Controls.Add(Me.TxtOutputMatriks)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(641, 335)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Operasi Matriks"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LinkArray
        '
        Me.LinkArray.AutoSize = True
        Me.LinkArray.Location = New System.Drawing.Point(40, 18)
        Me.LinkArray.Name = "LinkArray"
        Me.LinkArray.Size = New System.Drawing.Size(117, 20)
        Me.LinkArray.TabIndex = 0
        Me.LinkArray.TabStop = True
        Me.LinkArray.Text = "Proses Operasi"
        '
        'TxtOutputArray
        '
        Me.TxtOutputArray.Location = New System.Drawing.Point(44, 58)
        Me.TxtOutputArray.Multiline = True
        Me.TxtOutputArray.Name = "TxtOutputArray"
        Me.TxtOutputArray.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOutputArray.Size = New System.Drawing.Size(559, 257)
        Me.TxtOutputArray.TabIndex = 1
        '
        'TxtOutputMatriks
        '
        Me.TxtOutputMatriks.Location = New System.Drawing.Point(44, 57)
        Me.TxtOutputMatriks.Multiline = True
        Me.TxtOutputMatriks.Name = "TxtOutputMatriks"
        Me.TxtOutputMatriks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOutputMatriks.Size = New System.Drawing.Size(564, 259)
        Me.TxtOutputMatriks.TabIndex = 0
        '
        'LinkMatriks
        '
        Me.LinkMatriks.AutoSize = True
        Me.LinkMatriks.Location = New System.Drawing.Point(40, 15)
        Me.LinkMatriks.Name = "LinkMatriks"
        Me.LinkMatriks.Size = New System.Drawing.Size(117, 20)
        Me.LinkMatriks.TabIndex = 1
        Me.LinkMatriks.TabStop = True
        Me.LinkMatriks.Text = "Proses Operasi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Array Lanjutan :."
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TxtOutputArray As TextBox
    Friend WithEvents LinkArray As LinkLabel
    Friend WithEvents LinkMatriks As LinkLabel
    Friend WithEvents TxtOutputMatriks As TextBox
    Friend WithEvents TabControl1 As TabControl
End Class
