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
        Me.TxtData = New System.Windows.Forms.TextBox()
        Me.TxtKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnProcess = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtData
        '
        Me.TxtData.Location = New System.Drawing.Point(105, 24)
        Me.TxtData.Multiline = True
        Me.TxtData.Name = "TxtData"
        Me.TxtData.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtData.Size = New System.Drawing.Size(562, 285)
        Me.TxtData.TabIndex = 0
        '
        'TxtKey
        '
        Me.TxtKey.Location = New System.Drawing.Point(105, 382)
        Me.TxtKey.Name = "TxtKey"
        Me.TxtKey.Size = New System.Drawing.Size(388, 26)
        Me.TxtKey.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 340)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter the key to be searched:"
        '
        'BtnProcess
        '
        Me.BtnProcess.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnProcess.ForeColor = System.Drawing.Color.White
        Me.BtnProcess.Location = New System.Drawing.Point(506, 374)
        Me.BtnProcess.Name = "BtnProcess"
        Me.BtnProcess.Size = New System.Drawing.Size(161, 42)
        Me.BtnProcess.TabIndex = 2
        Me.BtnProcess.Text = "Searching Process"
        Me.BtnProcess.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnProcess)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtKey)
        Me.Controls.Add(Me.TxtData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Searching :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtData As TextBox
    Friend WithEvents TxtKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnProcess As Button
End Class
