<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class question
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(question))
        Me.Qno = New System.Windows.Forms.Label()
        Me.Questions = New System.Windows.Forms.Label()
        Me.Option3 = New System.Windows.Forms.Button()
        Me.Option2 = New System.Windows.Forms.Button()
        Me.Option1 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PlayerName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Score = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Qno
        '
        Me.Qno.BackColor = System.Drawing.Color.Transparent
        Me.Qno.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qno.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Qno.Location = New System.Drawing.Point(12, 177)
        Me.Qno.Name = "Qno"
        Me.Qno.Size = New System.Drawing.Size(67, 44)
        Me.Qno.TabIndex = 6
        Me.Qno.Text = "Q1"
        '
        'Questions
        '
        Me.Questions.BackColor = System.Drawing.Color.Transparent
        Me.Questions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Questions.ForeColor = System.Drawing.SystemColors.Control
        Me.Questions.Location = New System.Drawing.Point(66, 177)
        Me.Questions.Name = "Questions"
        Me.Questions.Size = New System.Drawing.Size(384, 65)
        Me.Questions.TabIndex = 7
        '
        'Option3
        '
        Me.Option3.BackColor = System.Drawing.Color.White
        Me.Option3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Option3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option3.Location = New System.Drawing.Point(124, 479)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(250, 51)
        Me.Option3.TabIndex = 10
        Me.Option3.UseVisualStyleBackColor = False
        '
        'Option2
        '
        Me.Option2.BackColor = System.Drawing.Color.White
        Me.Option2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Option2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option2.Location = New System.Drawing.Point(124, 406)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(250, 51)
        Me.Option2.TabIndex = 9
        Me.Option2.UseVisualStyleBackColor = False
        '
        'Option1
        '
        Me.Option1.BackColor = System.Drawing.Color.White
        Me.Option1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Option1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Option1.Location = New System.Drawing.Point(121, 319)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(250, 51)
        Me.Option1.TabIndex = 8
        Me.Option1.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 12000
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 14000
        '
        'PlayerName
        '
        Me.PlayerName.BackColor = System.Drawing.Color.Transparent
        Me.PlayerName.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayerName.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.PlayerName.Location = New System.Drawing.Point(37, 9)
        Me.PlayerName.Name = "PlayerName"
        Me.PlayerName.Size = New System.Drawing.Size(135, 33)
        Me.PlayerName.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(192, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 39)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "10"
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1000
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label5.Location = New System.Drawing.Point(116, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(258, 38)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Next question will be in.."
        '
        'Score
        '
        Me.Score.BackColor = System.Drawing.Color.Transparent
        Me.Score.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Score.Location = New System.Drawing.Point(374, 9)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(76, 38)
        Me.Score.TabIndex = 14
        Me.Score.Text = "0"
        Me.Score.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Quizophile.My.Resources.Resources.icons8_coins_48
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(446, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 38)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Quizophile.My.Resources.Resources.icons8_customer_48
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(2, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 32)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Lime
        Me.Label7.Location = New System.Drawing.Point(240, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 39)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Sec."
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Quizophile.My.Resources.Resources.icons8_alarm_clock_48
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(191, 100)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'question
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 561)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PlayerName)
        Me.Controls.Add(Me.Option3)
        Me.Controls.Add(Me.Option2)
        Me.Controls.Add(Me.Option1)
        Me.Controls.Add(Me.Questions)
        Me.Controls.Add(Me.Qno)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "question"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizophile"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Qno As System.Windows.Forms.Label
    Friend WithEvents Questions As System.Windows.Forms.Label
    Friend WithEvents Option3 As System.Windows.Forms.Button
    Friend WithEvents Option2 As System.Windows.Forms.Button
    Friend WithEvents Option1 As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PlayerName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Score As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
