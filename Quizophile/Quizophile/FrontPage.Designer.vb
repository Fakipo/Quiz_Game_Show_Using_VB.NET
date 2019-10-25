<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrontPage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrontPage))
        Me.Namebox = New System.Windows.Forms.TextBox()
        Me.NewToGame = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Namebox
        '
        Me.Namebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Namebox.Location = New System.Drawing.Point(96, 257)
        Me.Namebox.Name = "Namebox"
        Me.Namebox.Size = New System.Drawing.Size(301, 38)
        Me.Namebox.TabIndex = 1
        '
        'NewToGame
        '
        Me.NewToGame.BackColor = System.Drawing.Color.Transparent
        Me.NewToGame.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewToGame.FlatAppearance.BorderSize = 0
        Me.NewToGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.NewToGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.NewToGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewToGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewToGame.ForeColor = System.Drawing.Color.Olive
        Me.NewToGame.Location = New System.Drawing.Point(143, 495)
        Me.NewToGame.Name = "NewToGame"
        Me.NewToGame.Size = New System.Drawing.Size(215, 34)
        Me.NewToGame.TabIndex = 2
        Me.NewToGame.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Olive
        Me.Button1.Location = New System.Drawing.Point(80, 355)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(340, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrontPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.NewToGame)
        Me.Controls.Add(Me.Namebox)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrontPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizophile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Namebox As System.Windows.Forms.TextBox
    Friend WithEvents NewToGame As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
