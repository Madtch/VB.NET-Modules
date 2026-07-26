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
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.TxtOutput = New System.Windows.Forms.TextBox()
        Me.BtnBoom = New System.Windows.Forms.Button()
        Me.BtnFor = New System.Windows.Forms.Button()
        Me.BtnWhile = New System.Windows.Forms.Button()
        Me.BtnDoWhile = New System.Windows.Forms.Button()
        Me.BtnDo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(98, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Input sebuah angka :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(98, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Output :"
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(102, 97)
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.Size = New System.Drawing.Size(300, 26)
        Me.TxtInput.TabIndex = 1
        '
        'TxtOutput
        '
        Me.TxtOutput.Location = New System.Drawing.Point(102, 271)
        Me.TxtOutput.Multiline = True
        Me.TxtOutput.Name = "TxtOutput"
        Me.TxtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOutput.Size = New System.Drawing.Size(429, 217)
        Me.TxtOutput.TabIndex = 1
        '
        'BtnBoom
        '
        Me.BtnBoom.BackColor = System.Drawing.Color.Salmon
        Me.BtnBoom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBoom.Location = New System.Drawing.Point(408, 64)
        Me.BtnBoom.Name = "BtnBoom"
        Me.BtnBoom.Size = New System.Drawing.Size(123, 59)
        Me.BtnBoom.TabIndex = 2
        Me.BtnBoom.Text = "Boom !!!"
        Me.BtnBoom.UseVisualStyleBackColor = False
        '
        'BtnFor
        '
        Me.BtnFor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnFor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnFor.Location = New System.Drawing.Point(102, 145)
        Me.BtnFor.Name = "BtnFor"
        Me.BtnFor.Size = New System.Drawing.Size(198, 44)
        Me.BtnFor.TabIndex = 2
        Me.BtnFor.Text = "For - Next"
        Me.BtnFor.UseVisualStyleBackColor = False
        '
        'BtnWhile
        '
        Me.BtnWhile.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnWhile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnWhile.Location = New System.Drawing.Point(306, 145)
        Me.BtnWhile.Name = "BtnWhile"
        Me.BtnWhile.Size = New System.Drawing.Size(198, 44)
        Me.BtnWhile.TabIndex = 2
        Me.BtnWhile.Text = "While - End While"
        Me.BtnWhile.UseVisualStyleBackColor = False
        '
        'BtnDoWhile
        '
        Me.BtnDoWhile.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnDoWhile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDoWhile.Location = New System.Drawing.Point(102, 195)
        Me.BtnDoWhile.Name = "BtnDoWhile"
        Me.BtnDoWhile.Size = New System.Drawing.Size(198, 44)
        Me.BtnDoWhile.TabIndex = 2
        Me.BtnDoWhile.Text = "Do While - Loop"
        Me.BtnDoWhile.UseVisualStyleBackColor = False
        '
        'BtnDo
        '
        Me.BtnDo.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnDo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDo.Location = New System.Drawing.Point(306, 195)
        Me.BtnDo.Name = "BtnDo"
        Me.BtnDo.Size = New System.Drawing.Size(198, 44)
        Me.BtnDo.TabIndex = 2
        Me.BtnDo.Text = "Do - Loop While"
        Me.BtnDo.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(634, 510)
        Me.Controls.Add(Me.BtnDo)
        Me.Controls.Add(Me.BtnDoWhile)
        Me.Controls.Add(Me.BtnWhile)
        Me.Controls.Add(Me.BtnFor)
        Me.Controls.Add(Me.BtnBoom)
        Me.Controls.Add(Me.TxtOutput)
        Me.Controls.Add(Me.TxtInput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Perulangan :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents TxtOutput As TextBox
    Friend WithEvents BtnBoom As Button
    Friend WithEvents BtnFor As Button
    Friend WithEvents BtnWhile As Button
    Friend WithEvents BtnDoWhile As Button
    Friend WithEvents BtnDo As Button
End Class
