<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.Play = New System.Windows.Forms.Button()
        Me.Rules = New System.Windows.Forms.Button()
        Me.Leaderboard = New System.Windows.Forms.Button()
        Me.PlayerName = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Play
        '
        Me.Play.BackColor = System.Drawing.Color.Transparent
        Me.Play.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Play.FlatAppearance.BorderSize = 0
        Me.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Play.Font = New System.Drawing.Font("Lucida Handwriting", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Play.Location = New System.Drawing.Point(165, 86)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(142, 54)
        Me.Play.TabIndex = 1
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = False
        '
        'Rules
        '
        Me.Rules.BackColor = System.Drawing.Color.Transparent
        Me.Rules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Rules.FlatAppearance.BorderSize = 0
        Me.Rules.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Rules.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Rules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Rules.Font = New System.Drawing.Font("Lucida Handwriting", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rules.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Rules.Location = New System.Drawing.Point(165, 234)
        Me.Rules.Name = "Rules"
        Me.Rules.Size = New System.Drawing.Size(142, 54)
        Me.Rules.TabIndex = 2
        Me.Rules.Text = "Rules"
        Me.Rules.UseVisualStyleBackColor = False
        '
        'Leaderboard
        '
        Me.Leaderboard.BackColor = System.Drawing.Color.Transparent
        Me.Leaderboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Leaderboard.FlatAppearance.BorderSize = 0
        Me.Leaderboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Leaderboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Leaderboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Leaderboard.Font = New System.Drawing.Font("Lucida Handwriting", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Leaderboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Leaderboard.Location = New System.Drawing.Point(88, 372)
        Me.Leaderboard.Name = "Leaderboard"
        Me.Leaderboard.Size = New System.Drawing.Size(308, 70)
        Me.Leaderboard.TabIndex = 3
        Me.Leaderboard.Text = "Leaderboard"
        Me.Leaderboard.UseVisualStyleBackColor = False
        '
        'PlayerName
        '
        Me.PlayerName.BackColor = System.Drawing.Color.Transparent
        Me.PlayerName.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.PlayerName.Location = New System.Drawing.Point(39, 9)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(115, 32)
        Me.PlayerName.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Quizophile.My.Resources.Resources.icons8_customer_48
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(4, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 32)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Chocolate
        Me.Button1.Location = New System.Drawing.Point(165, 518)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 31)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(171, 464)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 32)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Or"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PlayerName)
        Me.Controls.Add(Me.Leaderboard)
        Me.Controls.Add(Me.Rules)
        Me.Controls.Add(Me.Play)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizophile"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Play As System.Windows.Forms.Button
    Friend WithEvents Rules As System.Windows.Forms.Button
    Friend WithEvents Leaderboard As System.Windows.Forms.Button
    Friend WithEvents PlayerName As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
