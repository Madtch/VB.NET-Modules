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
        Me.TxtAngka2 = New System.Windows.Forms.TextBox()
        Me.TxtAngka1 = New System.Windows.Forms.TextBox()
        Me.ComBox = New System.Windows.Forms.ComboBox()
        Me.BtnIfElseif = New System.Windows.Forms.Button()
        Me.BtnSelectCase = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtHasil = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Angka Pertama : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Angka Kedua :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(136, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Operator :"
        '
        'TxtAngka2
        '
        Me.TxtAngka2.Location = New System.Drawing.Point(294, 167)
        Me.TxtAngka2.Name = "TxtAngka2"
        Me.TxtAngka2.Size = New System.Drawing.Size(269, 26)
        Me.TxtAngka2.TabIndex = 2
        '
        'TxtAngka1
        '
        Me.TxtAngka1.Location = New System.Drawing.Point(294, 83)
        Me.TxtAngka1.Name = "TxtAngka1"
        Me.TxtAngka1.Size = New System.Drawing.Size(269, 26)
        Me.TxtAngka1.TabIndex = 2
        '
        'ComBox
        '
        Me.ComBox.FormattingEnabled = True
        Me.ComBox.Items.AddRange(New Object() {"*", "/", "+", "-", "^", "%", "&"})
        Me.ComBox.Location = New System.Drawing.Point(294, 125)
        Me.ComBox.Name = "ComBox"
        Me.ComBox.Size = New System.Drawing.Size(269, 28)
        Me.ComBox.TabIndex = 3
        '
        'BtnIfElseif
        '
        Me.BtnIfElseif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnIfElseif.Location = New System.Drawing.Point(170, 248)
        Me.BtnIfElseif.Name = "BtnIfElseif"
        Me.BtnIfElseif.Size = New System.Drawing.Size(127, 49)
        Me.BtnIfElseif.TabIndex = 4
        Me.BtnIfElseif.Text = "If-Else If-Else Statement"
        Me.BtnIfElseif.UseVisualStyleBackColor = True
        '
        'BtnSelectCase
        '
        Me.BtnSelectCase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelectCase.Location = New System.Drawing.Point(303, 248)
        Me.BtnSelectCase.Name = "BtnSelectCase"
        Me.BtnSelectCase.Size = New System.Drawing.Size(127, 49)
        Me.BtnSelectCase.TabIndex = 4
        Me.BtnSelectCase.Text = "Select-Case Statement"
        Me.BtnSelectCase.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Tomato
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.Location = New System.Drawing.Point(436, 248)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(127, 49)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Hasil :"
        '
        'TxtHasil
        '
        Me.TxtHasil.Location = New System.Drawing.Point(140, 380)
        Me.TxtHasil.Name = "TxtHasil"
        Me.TxtHasil.Size = New System.Drawing.Size(423, 26)
        Me.TxtHasil.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSelectCase)
        Me.Controls.Add(Me.BtnIfElseif)
        Me.Controls.Add(Me.ComBox)
        Me.Controls.Add(Me.TxtAngka1)
        Me.Controls.Add(Me.TxtHasil)
        Me.Controls.Add(Me.TxtAngka2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = ".:Tugas Percabangan:."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAngka2 As TextBox
    Friend WithEvents TxtAngka1 As TextBox
    Friend WithEvents ComBox As ComboBox
    Friend WithEvents BtnIfElseif As Button
    Friend WithEvents BtnSelectCase As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtHasil As TextBox
End Class
