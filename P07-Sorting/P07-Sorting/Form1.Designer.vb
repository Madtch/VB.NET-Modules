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
        Me.TxtSorting = New System.Windows.Forms.TextBox()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtSorting
        '
        Me.TxtSorting.Location = New System.Drawing.Point(65, 55)
        Me.TxtSorting.Multiline = True
        Me.TxtSorting.Name = "TxtSorting"
        Me.TxtSorting.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtSorting.Size = New System.Drawing.Size(682, 337)
        Me.TxtSorting.TabIndex = 0
        '
        'BtnProses
        '
        Me.BtnProses.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnProses.ForeColor = System.Drawing.Color.White
        Me.BtnProses.Location = New System.Drawing.Point(65, 398)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(682, 40)
        Me.BtnProses.TabIndex = 1
        Me.BtnProses.Text = "Sorting Process"
        Me.BtnProses.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnProses)
        Me.Controls.Add(Me.TxtSorting)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Sorting :."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSorting As TextBox
    Friend WithEvents BtnProses As Button
End Class
