<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class picturequiz
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.wordsearch.My.Resources.Resources.bg2
        Me.Button3.Location = New System.Drawing.Point(354, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 66)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "instructions"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.wordsearch.My.Resources.Resources.bg2
        Me.Button2.Location = New System.Drawing.Point(354, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 66)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Leaderboard"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.wordsearch.My.Resources.Resources.bg2
        Me.Button1.Location = New System.Drawing.Point(354, 97)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 67)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 43)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Picture Quiz"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picturequiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.wordsearch.My.Resources.Resources.brownbg
        Me.ClientSize = New System.Drawing.Size(953, 453)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "picturequiz"
        Me.Text = "picturequiz"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
