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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblReplace = New System.Windows.Forms.Label()
        Me.txtRegExPattern = New System.Windows.Forms.TextBox()
        Me.cmdParse = New System.Windows.Forms.Button()
        Me.chkShowAffected = New System.Windows.Forms.CheckBox()
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblReplaceWith = New System.Windows.Forms.Label()
        Me.txtReplaceWith = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(13, 34)
        Me.txtInput.MaxLength = 65534
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtInput.Size = New System.Drawing.Size(775, 200)
        Me.txtInput.TabIndex = 1
        Me.txtInput.WordWrap = False
        '
        'lblReplace
        '
        Me.lblReplace.AutoSize = True
        Me.lblReplace.Location = New System.Drawing.Point(14, 259)
        Me.lblReplace.Name = "lblReplace"
        Me.lblReplace.Size = New System.Drawing.Size(79, 13)
        Me.lblReplace.TabIndex = 2
        Me.lblReplace.Text = "RegEx Pattern:"
        '
        'txtRegExPattern
        '
        Me.txtRegExPattern.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRegExPattern.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegExPattern.Location = New System.Drawing.Point(91, 252)
        Me.txtRegExPattern.Name = "txtRegExPattern"
        Me.txtRegExPattern.Size = New System.Drawing.Size(200, 26)
        Me.txtRegExPattern.TabIndex = 3
        '
        'cmdParse
        '
        Me.cmdParse.Location = New System.Drawing.Point(529, 252)
        Me.cmdParse.Name = "cmdParse"
        Me.cmdParse.Size = New System.Drawing.Size(100, 26)
        Me.cmdParse.TabIndex = 6
        Me.cmdParse.Text = "&Parse"
        Me.cmdParse.UseVisualStyleBackColor = True
        '
        'chkShowAffected
        '
        Me.chkShowAffected.AutoSize = True
        Me.chkShowAffected.Location = New System.Drawing.Point(639, 256)
        Me.chkShowAffected.Name = "chkShowAffected"
        Me.chkShowAffected.Size = New System.Drawing.Size(148, 17)
        Me.chkShowAffected.TabIndex = 7
        Me.chkShowAffected.Text = "Show Affected Lines Only"
        Me.chkShowAffected.UseVisualStyleBackColor = True
        '
        'lblInput
        '
        Me.lblInput.AutoSize = True
        Me.lblInput.Location = New System.Drawing.Point(12, 18)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(31, 13)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Input"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 300)
        Me.txtOutput.MaxLength = 65534
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOutput.Size = New System.Drawing.Size(775, 200)
        Me.txtOutput.TabIndex = 9
        Me.txtOutput.WordWrap = False
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(14, 284)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(39, 13)
        Me.lblOutput.TabIndex = 8
        Me.lblOutput.Text = "Output"
        '
        'lblReplaceWith
        '
        Me.lblReplaceWith.AutoSize = True
        Me.lblReplaceWith.Location = New System.Drawing.Point(297, 260)
        Me.lblReplaceWith.Name = "lblReplaceWith"
        Me.lblReplaceWith.Size = New System.Drawing.Size(75, 13)
        Me.lblReplaceWith.TabIndex = 4
        Me.lblReplaceWith.Text = "Replace With:"
        '
        'txtReplaceWith
        '
        Me.txtReplaceWith.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtReplaceWith.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReplaceWith.Location = New System.Drawing.Point(370, 252)
        Me.txtReplaceWith.Name = "txtReplaceWith"
        Me.txtReplaceWith.Size = New System.Drawing.Size(150, 26)
        Me.txtReplaceWith.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 512)
        Me.Controls.Add(Me.txtReplaceWith)
        Me.Controls.Add(Me.lblReplaceWith)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.lblInput)
        Me.Controls.Add(Me.chkShowAffected)
        Me.Controls.Add(Me.cmdParse)
        Me.Controls.Add(Me.txtRegExPattern)
        Me.Controls.Add(Me.lblReplace)
        Me.Controls.Add(Me.txtInput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "RegEx Tester"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblReplace As Label
    Friend WithEvents txtRegExPattern As TextBox
    Friend WithEvents cmdParse As Button
    Friend WithEvents chkShowAffected As CheckBox
    Friend WithEvents lblInput As Label
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblReplaceWith As Label
    Friend WithEvents txtReplaceWith As TextBox
End Class
