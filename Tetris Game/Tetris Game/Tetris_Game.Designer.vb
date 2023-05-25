<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tetris_Game
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tetris_Game))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Scorecount = New System.Windows.Forms.Label()
        Me.Z = New System.Windows.Forms.PictureBox()
        Me.minusZ = New System.Windows.Forms.PictureBox()
        Me.L = New System.Windows.Forms.PictureBox()
        Me.minusL = New System.Windows.Forms.PictureBox()
        Me.Line = New System.Windows.Forms.PictureBox()
        Me.T = New System.Windows.Forms.PictureBox()
        Me.Square = New System.Windows.Forms.PictureBox()
        Me.Fall = New System.Windows.Forms.Timer(Me.components)
        Me.Gameoverlabel = New System.Windows.Forms.PictureBox()
        Me.q2 = New System.Windows.Forms.PictureBox()
        Me.q1 = New System.Windows.Forms.PictureBox()
        Me.holdbox = New System.Windows.Forms.PictureBox()
        Me.q3 = New System.Windows.Forms.PictureBox()
        Me.Pause = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.Label()
        Me.Second = New System.Windows.Forms.Timer(Me.components)
        Me.Pixelatetimer = New System.Windows.Forms.Label()
        Me.Restart = New System.Windows.Forms.Button()
        Me.backtomain = New System.Windows.Forms.Button()
        Me.savescore = New System.Windows.Forms.Button()
        Me.entername = New System.Windows.Forms.TextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.speed = New System.Windows.Forms.Label()
        CType(Me.Z, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minusZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.L, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minusL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Line, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Square, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Gameoverlabel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.holdbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Lime
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(377, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hold"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(352, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Next"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(352, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Score:"
        '
        'Scorecount
        '
        Me.Scorecount.AutoSize = True
        Me.Scorecount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Scorecount.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scorecount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Scorecount.Location = New System.Drawing.Point(352, 167)
        Me.Scorecount.Name = "Scorecount"
        Me.Scorecount.Size = New System.Drawing.Size(24, 26)
        Me.Scorecount.TabIndex = 1
        Me.Scorecount.Text = "0"
        '
        'Z
        '
        Me.Z.BackColor = System.Drawing.Color.Transparent
        Me.Z.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Z.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Z.Image = CType(resources.GetObject("Z.Image"), System.Drawing.Image)
        Me.Z.Location = New System.Drawing.Point(12, 9)
        Me.Z.Name = "Z"
        Me.Z.Size = New System.Drawing.Size(100, 100)
        Me.Z.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Z.TabIndex = 0
        Me.Z.TabStop = False
        Me.Z.UseWaitCursor = True
        '
        'minusZ
        '
        Me.minusZ.BackColor = System.Drawing.Color.Transparent
        Me.minusZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minusZ.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.minusZ.Image = CType(resources.GetObject("minusZ.Image"), System.Drawing.Image)
        Me.minusZ.Location = New System.Drawing.Point(12, 9)
        Me.minusZ.Name = "minusZ"
        Me.minusZ.Size = New System.Drawing.Size(100, 100)
        Me.minusZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minusZ.TabIndex = 2
        Me.minusZ.TabStop = False
        Me.minusZ.UseWaitCursor = True
        '
        'L
        '
        Me.L.BackColor = System.Drawing.Color.Transparent
        Me.L.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.L.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.L.Image = CType(resources.GetObject("L.Image"), System.Drawing.Image)
        Me.L.Location = New System.Drawing.Point(12, 9)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(100, 100)
        Me.L.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.L.TabIndex = 3
        Me.L.TabStop = False
        Me.L.UseWaitCursor = True
        '
        'minusL
        '
        Me.minusL.BackColor = System.Drawing.Color.Transparent
        Me.minusL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.minusL.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.minusL.Image = CType(resources.GetObject("minusL.Image"), System.Drawing.Image)
        Me.minusL.Location = New System.Drawing.Point(12, 9)
        Me.minusL.Name = "minusL"
        Me.minusL.Size = New System.Drawing.Size(100, 100)
        Me.minusL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minusL.TabIndex = 4
        Me.minusL.TabStop = False
        Me.minusL.UseWaitCursor = True
        '
        'Line
        '
        Me.Line.BackColor = System.Drawing.Color.Transparent
        Me.Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Line.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Line.Image = CType(resources.GetObject("Line.Image"), System.Drawing.Image)
        Me.Line.Location = New System.Drawing.Point(12, 9)
        Me.Line.Name = "Line"
        Me.Line.Size = New System.Drawing.Size(100, 100)
        Me.Line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Line.TabIndex = 5
        Me.Line.TabStop = False
        Me.Line.UseWaitCursor = True
        '
        'T
        '
        Me.T.BackColor = System.Drawing.Color.Transparent
        Me.T.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.T.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.T.Image = CType(resources.GetObject("T.Image"), System.Drawing.Image)
        Me.T.Location = New System.Drawing.Point(12, 9)
        Me.T.Name = "T"
        Me.T.Size = New System.Drawing.Size(100, 100)
        Me.T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.T.TabIndex = 5
        Me.T.TabStop = False
        Me.T.UseWaitCursor = True
        '
        'Square
        '
        Me.Square.BackColor = System.Drawing.Color.Transparent
        Me.Square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Square.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Square.Image = CType(resources.GetObject("Square.Image"), System.Drawing.Image)
        Me.Square.Location = New System.Drawing.Point(12, 9)
        Me.Square.Name = "Square"
        Me.Square.Size = New System.Drawing.Size(100, 100)
        Me.Square.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Square.TabIndex = 5
        Me.Square.TabStop = False
        Me.Square.UseWaitCursor = True
        '
        'Fall
        '
        Me.Fall.Interval = 500
        '
        'Gameoverlabel
        '
        Me.Gameoverlabel.BackColor = System.Drawing.Color.White
        Me.Gameoverlabel.BackgroundImage = CType(resources.GetObject("Gameoverlabel.BackgroundImage"), System.Drawing.Image)
        Me.Gameoverlabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Gameoverlabel.InitialImage = CType(resources.GetObject("Gameoverlabel.InitialImage"), System.Drawing.Image)
        Me.Gameoverlabel.Location = New System.Drawing.Point(22, 31)
        Me.Gameoverlabel.Name = "Gameoverlabel"
        Me.Gameoverlabel.Size = New System.Drawing.Size(324, 504)
        Me.Gameoverlabel.TabIndex = 6
        Me.Gameoverlabel.TabStop = False
        '
        'q2
        '
        Me.q2.BackColor = System.Drawing.Color.Transparent
        Me.q2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.q2.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.q2.Image = CType(resources.GetObject("q2.Image"), System.Drawing.Image)
        Me.q2.Location = New System.Drawing.Point(352, 338)
        Me.q2.Name = "q2"
        Me.q2.Size = New System.Drawing.Size(100, 100)
        Me.q2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.q2.TabIndex = 5
        Me.q2.TabStop = False
        Me.q2.UseWaitCursor = True
        '
        'q1
        '
        Me.q1.BackColor = System.Drawing.Color.Transparent
        Me.q1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.q1.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.q1.Image = CType(resources.GetObject("q1.Image"), System.Drawing.Image)
        Me.q1.Location = New System.Drawing.Point(352, 232)
        Me.q1.Name = "q1"
        Me.q1.Size = New System.Drawing.Size(100, 100)
        Me.q1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.q1.TabIndex = 5
        Me.q1.TabStop = False
        Me.q1.UseWaitCursor = True
        '
        'holdbox
        '
        Me.holdbox.BackColor = System.Drawing.Color.Transparent
        Me.holdbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.holdbox.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.holdbox.Image = CType(resources.GetObject("holdbox.Image"), System.Drawing.Image)
        Me.holdbox.Location = New System.Drawing.Point(352, 38)
        Me.holdbox.Name = "holdbox"
        Me.holdbox.Size = New System.Drawing.Size(100, 100)
        Me.holdbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.holdbox.TabIndex = 5
        Me.holdbox.TabStop = False
        Me.holdbox.UseWaitCursor = True
        '
        'q3
        '
        Me.q3.BackColor = System.Drawing.Color.Transparent
        Me.q3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.q3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.q3.Image = CType(resources.GetObject("q3.Image"), System.Drawing.Image)
        Me.q3.Location = New System.Drawing.Point(352, 444)
        Me.q3.Name = "q3"
        Me.q3.Size = New System.Drawing.Size(100, 100)
        Me.q3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.q3.TabIndex = 5
        Me.q3.TabStop = False
        Me.q3.UseWaitCursor = True
        '
        'Pause
        '
        Me.Pause.AutoSize = True
        Me.Pause.BackColor = System.Drawing.Color.White
        Me.Pause.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pause.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pause.Location = New System.Drawing.Point(17, 2)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(109, 26)
        Me.Pause.TabIndex = 1
        Me.Pause.Text = "(P) Pause"
        '
        'time
        '
        Me.time.AutoSize = True
        Me.time.BackColor = System.Drawing.Color.White
        Me.time.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.time.Location = New System.Drawing.Point(132, 2)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(157, 26)
        Me.time.TabIndex = 1
        Me.time.Text = "Time Survived:"
        '
        'Second
        '
        Me.Second.Enabled = True
        Me.Second.Interval = 1000
        '
        'Pixelatetimer
        '
        Me.Pixelatetimer.AutoSize = True
        Me.Pixelatetimer.BackColor = System.Drawing.Color.White
        Me.Pixelatetimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pixelatetimer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pixelatetimer.Location = New System.Drawing.Point(12, 543)
        Me.Pixelatetimer.Name = "Pixelatetimer"
        Me.Pixelatetimer.Size = New System.Drawing.Size(194, 26)
        Me.Pixelatetimer.TabIndex = 1
        Me.Pixelatetimer.Text = "Pixelate cooldown:"
        '
        'Restart
        '
        Me.Restart.Location = New System.Drawing.Point(109, 444)
        Me.Restart.Name = "Restart"
        Me.Restart.Size = New System.Drawing.Size(157, 43)
        Me.Restart.TabIndex = 8
        Me.Restart.Text = "Restart"
        Me.Restart.UseVisualStyleBackColor = True
        '
        'backtomain
        '
        Me.backtomain.Location = New System.Drawing.Point(109, 492)
        Me.backtomain.Name = "backtomain"
        Me.backtomain.Size = New System.Drawing.Size(157, 43)
        Me.backtomain.TabIndex = 8
        Me.backtomain.Text = "Back to main menu"
        Me.backtomain.UseVisualStyleBackColor = True
        '
        'savescore
        '
        Me.savescore.Location = New System.Drawing.Point(270, 492)
        Me.savescore.Name = "savescore"
        Me.savescore.Size = New System.Drawing.Size(76, 43)
        Me.savescore.TabIndex = 8
        Me.savescore.Text = "Save score"
        Me.savescore.UseVisualStyleBackColor = True
        '
        'entername
        '
        Me.entername.Location = New System.Drawing.Point(105, 312)
        Me.entername.Name = "entername"
        Me.entername.Size = New System.Drawing.Size(161, 20)
        Me.entername.TabIndex = 9
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(109, 346)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(157, 43)
        Me.save.TabIndex = 8
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'speed
        '
        Me.speed.AutoSize = True
        Me.speed.BackColor = System.Drawing.Color.White
        Me.speed.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.speed.Location = New System.Drawing.Point(322, 543)
        Me.speed.Name = "speed"
        Me.speed.Size = New System.Drawing.Size(110, 26)
        Me.speed.TabIndex = 1
        Me.speed.Text = "Speed: x1"
        '
        'Tetris_Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(464, 578)
        Me.Controls.Add(Me.Pause)
        Me.Controls.Add(Me.entername)
        Me.Controls.Add(Me.backtomain)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.savescore)
        Me.Controls.Add(Me.Restart)
        Me.Controls.Add(Me.Gameoverlabel)
        Me.Controls.Add(Me.holdbox)
        Me.Controls.Add(Me.q1)
        Me.Controls.Add(Me.q3)
        Me.Controls.Add(Me.q2)
        Me.Controls.Add(Me.Square)
        Me.Controls.Add(Me.T)
        Me.Controls.Add(Me.Line)
        Me.Controls.Add(Me.minusL)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.minusZ)
        Me.Controls.Add(Me.Z)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Scorecount)
        Me.Controls.Add(Me.speed)
        Me.Controls.Add(Me.Pixelatetimer)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Tetris_Game"
        Me.Text = "Form2"
        CType(Me.Z, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minusZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.L, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minusL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Line, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Square, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Gameoverlabel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.holdbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Scorecount As Label
    Friend WithEvents Z As PictureBox
    Friend WithEvents minusZ As PictureBox
    Friend WithEvents L As PictureBox
    Friend WithEvents minusL As PictureBox
    Friend WithEvents Line As PictureBox
    Friend WithEvents T As PictureBox
    Friend WithEvents Square As PictureBox
    Friend WithEvents Fall As Timer
    Friend WithEvents Gameoverlabel As PictureBox
    Friend WithEvents q2 As PictureBox
    Friend WithEvents q1 As PictureBox
    Friend WithEvents holdbox As PictureBox
    Friend WithEvents q3 As PictureBox
    Friend WithEvents Pause As Label
    Friend WithEvents time As Label
    Friend WithEvents Second As Timer
    Friend WithEvents Pixelatetimer As Label
    Friend WithEvents Restart As Button
    Friend WithEvents backtomain As Button
    Friend WithEvents savescore As Button
    Friend WithEvents entername As TextBox
    Friend WithEvents save As Button
    Friend WithEvents speed As Label
End Class
