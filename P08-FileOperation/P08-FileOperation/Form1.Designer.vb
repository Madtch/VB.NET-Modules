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
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.TxtEditor = New System.Windows.Forms.TextBox()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnRead = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(97, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(97, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Editor:"
        '
        'TxtPath
        '
        Me.TxtPath.Location = New System.Drawing.Point(101, 46)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(461, 26)
        Me.TxtPath.TabIndex = 1
        '
        'TxtEditor
        '
        Me.TxtEditor.Location = New System.Drawing.Point(101, 182)
        Me.TxtEditor.Multiline = True
        Me.TxtEditor.Name = "TxtEditor"
        Me.TxtEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtEditor.Size = New System.Drawing.Size(461, 376)
        Me.TxtEditor.TabIndex = 1
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(101, 78)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(225, 45)
        Me.BtnCreate.TabIndex = 2
        Me.BtnCreate.Text = "Create / write file"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnRead
        '
        Me.BtnRead.Location = New System.Drawing.Point(332, 78)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(230, 45)
        Me.BtnRead.TabIndex = 2
        Me.BtnRead.Text = "Read file"
        Me.BtnRead.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(656, 586)
        Me.Controls.Add(Me.BtnRead)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.TxtEditor)
        Me.Controls.Add(Me.TxtPath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: File Operation :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents TxtEditor As TextBox
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
End Class
