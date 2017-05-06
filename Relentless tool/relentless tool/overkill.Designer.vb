<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class overkill
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MephTheme1 = New Relentless_tool.MephTheme()
        Me.MephButton2 = New Relentless_tool.MephButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MephTextBox2 = New Relentless_tool.MephTextBox()
        Me.MephTextBox1 = New Relentless_tool.MephTextBox()
        Me.MephButton1 = New Relentless_tool.MephButton()
        Me.MephTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5
        '
        'Timer2
        '
        Me.Timer2.Interval = 5
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.DarkRed
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.MephButton2)
        Me.MephTheme1.Controls.Add(Me.Label2)
        Me.MephTheme1.Controls.Add(Me.Label1)
        Me.MephTheme1.Controls.Add(Me.MephTextBox2)
        Me.MephTheme1.Controls.Add(Me.MephTextBox1)
        Me.MephTheme1.Controls.Add(Me.MephButton1)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(194, 173)
        Me.MephTheme1.SubHeader = "Warning: Decent PC needed"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "Over-Killer"
        '
        'MephButton2
        '
        Me.MephButton2.BackColor = System.Drawing.Color.Transparent
        Me.MephButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton2.Location = New System.Drawing.Point(109, 125)
        Me.MephButton2.Name = "MephButton2"
        Me.MephButton2.Size = New System.Drawing.Size(55, 23)
        Me.MephButton2.TabIndex = 5
        Me.MephButton2.Text = "Stop"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(135, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sent"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(88, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "0"
        '
        'MephTextBox2
        '
        Me.MephTextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox2.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox2.Location = New System.Drawing.Point(29, 95)
        Me.MephTextBox2.MaxLength = 32767
        Me.MephTextBox2.MultiLine = False
        Me.MephTextBox2.Name = "MephTextBox2"
        Me.MephTextBox2.Size = New System.Drawing.Size(135, 24)
        Me.MephTextBox2.TabIndex = 2
        Me.MephTextBox2.Text = "Message"
        Me.MephTextBox2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.MephTextBox2.UseSystemPasswordChar = False
        Me.MephTextBox2.WordWrap = False
        '
        'MephTextBox1
        '
        Me.MephTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MephTextBox1.ForeColor = System.Drawing.Color.Silver
        Me.MephTextBox1.Location = New System.Drawing.Point(29, 65)
        Me.MephTextBox1.MaxLength = 32767
        Me.MephTextBox1.MultiLine = False
        Me.MephTextBox1.Name = "MephTextBox1"
        Me.MephTextBox1.Size = New System.Drawing.Size(135, 24)
        Me.MephTextBox1.TabIndex = 1
        Me.MephTextBox1.Text = "Username"
        Me.MephTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.MephTextBox1.UseSystemPasswordChar = False
        Me.MephTextBox1.WordWrap = False
        '
        'MephButton1
        '
        Me.MephButton1.BackColor = System.Drawing.Color.Transparent
        Me.MephButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MephButton1.Location = New System.Drawing.Point(29, 125)
        Me.MephButton1.Name = "MephButton1"
        Me.MephButton1.Size = New System.Drawing.Size(57, 23)
        Me.MephButton1.TabIndex = 0
        Me.MephButton1.Text = "Kill"
        '
        'overkill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(194, 173)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "overkill"
        Me.Text = "overkill"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        Me.MephTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MephTheme1 As Relentless_tool.MephTheme
    Friend WithEvents MephButton1 As Relentless_tool.MephButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MephTextBox2 As Relentless_tool.MephTextBox
    Friend WithEvents MephTextBox1 As Relentless_tool.MephTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents MephButton2 As Relentless_tool.MephButton
End Class
