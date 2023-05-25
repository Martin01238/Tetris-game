<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tetristitle
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.Leaderboard = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.Names = New System.Windows.Forms.Label()
        Me.Close = New System.Windows.Forms.Button()
        Me.Sort = New System.Windows.Forms.Button()
        Me.Sort2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Tetris_Game.My.Resources.Resources.Tetris_Logo_980x553
        Me.PictureBox1.Location = New System.Drawing.Point(-88, -79)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(916, 484)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(367, 259)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Leaderboard
        '
        Me.Leaderboard.Location = New System.Drawing.Point(367, 288)
        Me.Leaderboard.Name = "Leaderboard"
        Me.Leaderboard.Size = New System.Drawing.Size(75, 23)
        Me.Leaderboard.TabIndex = 1
        Me.Leaderboard.Text = "Leaderboard"
        Me.Leaderboard.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(367, 317)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(75, 23)
        Me.Quit.TabIndex = 1
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'Names
        '
        Me.Names.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Names.Location = New System.Drawing.Point(13, 13)
        Me.Names.Name = "Names"
        Me.Names.Size = New System.Drawing.Size(588, 377)
        Me.Names.TabIndex = 2
        '
        'Close
        '
        Me.Close.Location = New System.Drawing.Point(608, 13)
        Me.Close.Name = "Close"
        Me.Close.Size = New System.Drawing.Size(195, 74)
        Me.Close.TabIndex = 3
        Me.Close.Text = "Close leaderboard"
        Me.Close.UseVisualStyleBackColor = True
        '
        'Sort
        '
        Me.Sort.Location = New System.Drawing.Point(608, 93)
        Me.Sort.Name = "Sort"
        Me.Sort.Size = New System.Drawing.Size(195, 74)
        Me.Sort.TabIndex = 3
        Me.Sort.Text = "Sort by highest score"
        Me.Sort.UseVisualStyleBackColor = True
        '
        'Sort2
        '
        Me.Sort2.Location = New System.Drawing.Point(608, 173)
        Me.Sort2.Name = "Sort2"
        Me.Sort2.Size = New System.Drawing.Size(195, 74)
        Me.Sort2.TabIndex = 3
        Me.Sort2.Text = "Sort by time"
        Me.Sort2.UseVisualStyleBackColor = True
        '
        'Tetristitle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 399)
        Me.Controls.Add(Me.Sort2)
        Me.Controls.Add(Me.Sort)
        Me.Controls.Add(Me.Close)
        Me.Controls.Add(Me.Names)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.Leaderboard)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Tetristitle"
        Me.Text = "Tetris Title Screen"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Start As Button
    Friend WithEvents Leaderboard As Button
    Friend WithEvents Quit As Button
    Friend WithEvents Names As Label
    Friend WithEvents Close As Button
    Friend WithEvents Sort As Button
    Friend WithEvents Sort2 As Button
End Class
