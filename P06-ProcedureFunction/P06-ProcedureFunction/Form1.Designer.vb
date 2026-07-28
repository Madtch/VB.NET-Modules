<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnProcedure = New System.Windows.Forms.Button()
        Me.TxtProcInput = New System.Windows.Forms.TextBox()
        Me.TxtProcOutput = New System.Windows.Forms.TextBox()
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.BtnFunction = New System.Windows.Forms.Button()
        Me.TxtFuncOutput = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.TxtProcOutput)
        Me.Panel1.Controls.Add(Me.TxtProcInput)
        Me.Panel1.Controls.Add(Me.BtnProcedure)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 532)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel2.Controls.Add(Me.TxtFuncOutput)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BtnFunction)
        Me.Panel2.Controls.Add(Me.TxtNum2)
        Me.Panel2.Controls.Add(Me.TxtNum1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(463, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(444, 532)
        Me.Panel2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(171, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Procedure"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Function"
        '
        'BtnProcedure
        '
        Me.BtnProcedure.Location = New System.Drawing.Point(320, 100)
        Me.BtnProcedure.Name = "BtnProcedure"
        Me.BtnProcedure.Size = New System.Drawing.Size(103, 31)
        Me.BtnProcedure.TabIndex = 1
        Me.BtnProcedure.Text = "Proses"
        Me.BtnProcedure.UseVisualStyleBackColor = True
        '
        'TxtProcInput
        '
        Me.TxtProcInput.Location = New System.Drawing.Point(37, 102)
        Me.TxtProcInput.Name = "TxtProcInput"
        Me.TxtProcInput.Size = New System.Drawing.Size(277, 26)
        Me.TxtProcInput.TabIndex = 2
        '
        'TxtProcOutput
        '
        Me.TxtProcOutput.Location = New System.Drawing.Point(37, 137)
        Me.TxtProcOutput.Multiline = True
        Me.TxtProcOutput.Name = "TxtProcOutput"
        Me.TxtProcOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtProcOutput.Size = New System.Drawing.Size(386, 361)
        Me.TxtProcOutput.TabIndex = 2
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(26, 105)
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(136, 26)
        Me.TxtNum1.TabIndex = 2
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(168, 105)
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(145, 26)
        Me.TxtNum2.TabIndex = 2
        '
        'BtnFunction
        '
        Me.BtnFunction.Location = New System.Drawing.Point(317, 100)
        Me.BtnFunction.Name = "BtnFunction"
        Me.BtnFunction.Size = New System.Drawing.Size(95, 28)
        Me.BtnFunction.TabIndex = 1
        Me.BtnFunction.Text = "Proses"
        Me.BtnFunction.UseVisualStyleBackColor = True
        '
        'TxtFuncOutput
        '
        Me.TxtFuncOutput.Location = New System.Drawing.Point(26, 137)
        Me.TxtFuncOutput.Multiline = True
        Me.TxtFuncOutput.Name = "TxtFuncOutput"
        Me.TxtFuncOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtFuncOutput.Size = New System.Drawing.Size(386, 361)
        Me.TxtFuncOutput.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(907, 532)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Procedure and Function :."
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtProcOutput As TextBox
    Friend WithEvents TxtProcInput As TextBox
    Friend WithEvents BtnProcedure As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents BtnFunction As Button
    Friend WithEvents TxtFuncOutput As TextBox
End Class
