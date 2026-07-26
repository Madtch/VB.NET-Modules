<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmLogika
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.TxtC = New System.Windows.Forms.TextBox()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.BtnAnd = New System.Windows.Forms.Button()
        Me.CboD = New System.Windows.Forms.ComboBox()
        Me.BtnOr = New System.Windows.Forms.Button()
        Me.BtnNot = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(64, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nilai A :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nilai B :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(442, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nilai C :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(442, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nilai D :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Hasil :"
        '
        'TxtA
        '
        Me.TxtA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtA.Location = New System.Drawing.Point(177, 45)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(168, 26)
        Me.TxtA.TabIndex = 1
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(177, 97)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(168, 26)
        Me.TxtB.TabIndex = 1
        '
        'TxtC
        '
        Me.TxtC.Location = New System.Drawing.Point(525, 45)
        Me.TxtC.Name = "TxtC"
        Me.TxtC.Size = New System.Drawing.Size(168, 26)
        Me.TxtC.TabIndex = 1
        '
        'TxtHasil
        '
        Me.TxtHasil.Enabled = False
        Me.TxtHasil.Location = New System.Drawing.Point(177, 335)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(516, 26)
        Me.TxtHasil.TabIndex = 1
        '
        'BtnAnd
        '
        Me.BtnAnd.Location = New System.Drawing.Point(162, 155)
        Me.BtnAnd.Name = "BtnAnd"
        Me.BtnAnd.Size = New System.Drawing.Size(174, 54)
        Me.BtnAnd.TabIndex = 2
        Me.BtnAnd.Text = "B < C and B < A"
        Me.BtnAnd.UseVisualStyleBackColor = True
        '
        'CboD
        '
        Me.CboD.FormattingEnabled = True
        Me.CboD.Items.AddRange(New Object() {"True", "False"})
        Me.CboD.Location = New System.Drawing.Point(525, 100)
        Me.CboD.Name = "CboD"
        Me.CboD.Size = New System.Drawing.Size(168, 28)
        Me.CboD.TabIndex = 3
        '
        'BtnOr
        '
        Me.BtnOr.Location = New System.Drawing.Point(162, 215)
        Me.BtnOr.Name = "BtnOr"
        Me.BtnOr.Size = New System.Drawing.Size(174, 54)
        Me.BtnOr.TabIndex = 2
        Me.BtnOr.Text = "B < C or B < A"
        Me.BtnOr.UseVisualStyleBackColor = True
        '
        'BtnNot
        '
        Me.BtnNot.Location = New System.Drawing.Point(392, 155)
        Me.BtnNot.Name = "BtnNot"
        Me.BtnNot.Size = New System.Drawing.Size(174, 54)
        Me.BtnNot.TabIndex = 2
        Me.BtnNot.Text = "Not D"
        Me.BtnNot.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Salmon
        Me.BtnCancel.Location = New System.Drawing.Point(392, 215)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(174, 54)
        Me.BtnCancel.TabIndex = 2
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'FmLogika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CboD)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOr)
        Me.Controls.Add(Me.BtnNot)
        Me.Controls.Add(Me.BtnAnd)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtB)
        Me.Controls.Add(Me.TxtC)
        Me.Controls.Add(Me.TxtA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FmLogika"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Operator Logika :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtA As TextBox
    Friend WithEvents TxtB As TextBox
    Friend WithEvents TxtC As TextBox
    Friend WithEvents TxtHasil As TextBox
    Friend WithEvents BtnAnd As Button
    Friend WithEvents CboD As ComboBox
    Friend WithEvents BtnOr As Button
    Friend WithEvents BtnNot As Button
    Friend WithEvents BtnCancel As Button
End Class
