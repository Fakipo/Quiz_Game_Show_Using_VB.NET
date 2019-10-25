<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.Submit = New System.Windows.Forms.Button()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.MobBox = New System.Windows.Forms.TextBox()
        Me.AgeBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Submit
        '
        Me.Submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Submit.Location = New System.Drawing.Point(185, 489)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(95, 30)
        Me.Submit.TabIndex = 0
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'NameBox
        '
        Me.NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.Location = New System.Drawing.Point(238, 198)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(195, 26)
        Me.NameBox.TabIndex = 1
        '
        'MobBox
        '
        Me.MobBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobBox.Location = New System.Drawing.Point(238, 268)
        Me.MobBox.Name = "MobBox"
        Me.MobBox.Size = New System.Drawing.Size(195, 26)
        Me.MobBox.TabIndex = 2
        '
        'AgeBox
        '
        Me.AgeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeBox.Location = New System.Drawing.Point(238, 335)
        Me.AgeBox.Name = "AgeBox"
        Me.AgeBox.Size = New System.Drawing.Size(195, 26)
        Me.AgeBox.TabIndex = 3
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.CheckBox1.Location = New System.Drawing.Point(55, 426)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(292, 24)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "I agree with Terms and Condition"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackgroundImage = CType(resources.GetObject("Back.BackgroundImage"), System.Drawing.Image)
        Me.Back.Location = New System.Drawing.Point(2, 0)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(104, 51)
        Me.Back.TabIndex = 5
        Me.Back.UseVisualStyleBackColor = True
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(484, 531)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.AgeBox)
        Me.Controls.Add(Me.MobBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Submit)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quizophile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents MobBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeBox As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Back As System.Windows.Forms.Button
End Class
