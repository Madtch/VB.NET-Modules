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
        Me.BtnClick = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnClick
        '
        Me.BtnClick.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClick.ForeColor = System.Drawing.SystemColors.Highlight
        Me.BtnClick.Location = New System.Drawing.Point(283, 150)
        Me.BtnClick.Name = "BtnClick"
        Me.BtnClick.Size = New System.Drawing.Size(191, 87)
        Me.BtnClick.TabIndex = 0
        Me.BtnClick.Text = "Click Me!!"
        Me.BtnClick.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnClick)
        Me.Name = "Form1"
        Me.Text = "  "
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnClick As Button
End Class
