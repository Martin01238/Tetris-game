Public Class Tetris_Game
    Dim score As Integer
    Dim gameend As Boolean
    Dim ApplicationDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
    Dim grid(15, 25) As PictureBox
    Dim newxy(1, 3) As Integer
    Dim currentcolor As String
    Dim newsquare As New PictureBox
    Dim currentshape As String
    Dim queue(2) As String
    Dim columnheight(15) As Integer
    Dim coloredsquare(15, 25) As Boolean
    Dim hold As String
    Dim canhold, canpixel As Boolean
    Dim paused As Boolean
    Dim minutes, seconds, pixelcooldown As Integer
    Public Class fallingshape
        Protected squarespos(1, 4) As Integer
        Protected shape As String
        Protected colour As String
        Public Sub New(newshape As String)
            shape = newshape
            If newshape = "-Z" Then
                colour = "red"
                squarespos(0, 1) = 7
                squarespos(0, 2) = 8
                squarespos(0, 3) = 8
                squarespos(0, 4) = 9
                squarespos(1, 1) = 1
                squarespos(1, 2) = 1
                squarespos(1, 3) = 2
                squarespos(1, 4) = 2
            ElseIf newshape = "Z" Then
                colour = "green"
                squarespos(0, 1) = 9
                squarespos(0, 2) = 8
                squarespos(0, 3) = 8
                squarespos(0, 4) = 7
                squarespos(1, 1) = 1
                squarespos(1, 2) = 1
                squarespos(1, 3) = 2
                squarespos(1, 4) = 2
            ElseIf newshape = "L" Then
                colour = "orange"
                squarespos(0, 1) = 7
                squarespos(0, 2) = 7
                squarespos(0, 3) = 7
                squarespos(0, 4) = 8
                squarespos(1, 1) = 1
                squarespos(1, 2) = 2
                squarespos(1, 3) = 3
                squarespos(1, 4) = 3
            ElseIf newshape = "-L" Then
                colour = "blue"
                squarespos(0, 1) = 8
                squarespos(0, 2) = 8
                squarespos(0, 3) = 8
                squarespos(0, 4) = 7
                squarespos(1, 1) = 1
                squarespos(1, 2) = 2
                squarespos(1, 3) = 3
                squarespos(1, 4) = 3
            ElseIf newshape = "line" Then
                colour = "cyan"
                squarespos(0, 1) = 7
                squarespos(0, 2) = 7
                squarespos(0, 3) = 7
                squarespos(0, 4) = 7
                squarespos(1, 1) = 1
                squarespos(1, 2) = 2
                squarespos(1, 3) = 3
                squarespos(1, 4) = 4
            ElseIf newshape = "T" Then
                colour = "purple"
                squarespos(0, 1) = 7
                squarespos(0, 2) = 8
                squarespos(0, 3) = 9
                squarespos(0, 4) = 8
                squarespos(1, 1) = 1
                squarespos(1, 2) = 1
                squarespos(1, 3) = 1
                squarespos(1, 4) = 2
            ElseIf newshape = "square" Then
                colour = "yellow"
                squarespos(0, 1) = 7
                squarespos(0, 2) = 8
                squarespos(0, 3) = 7
                squarespos(0, 4) = 8
                squarespos(1, 1) = 1
                squarespos(1, 2) = 1
                squarespos(1, 3) = 2
                squarespos(1, 4) = 2
            End If
        End Sub
        Public Function getpos(axis, square)
            Return squarespos(axis, square)
        End Function

        Public Function Getcolour()
            Return (colour)
        End Function
        Public Function Getshape()
            Return (shape)
        End Function
    End Class
    Public Class pixel
        Inherits fallingshape
        Private position(1) As Integer
        Public Sub New(newshape, x, y, colourinput)
            MyBase.New(newshape)
            colour = colourinput
            position(0) = x
            position(1) = y
            For a = 0 To 1
                For b = 1 To 4
                    If a = 0 Then
                        squarespos(a, b) = x
                    Else
                        squarespos(a, b) = y
                    End If
                Next
            Next
        End Sub
    End Class
    Private Sub rotate()
        Dim checknewxy(1, 3)
        setcolor("white", newxy(0, 0), newxy(0, 1), newxy(0, 2), newxy(0, 3), newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
        Dim rotationcords(1) As Integer
        rotationcords(0) = newxy(0, 1)
        rotationcords(1) = newxy(1, 1)
        Dim relativexy(1, 3), newrelativexy(1, 3) As Integer
        For a = 0 To 1
            For b = 0 To 3
                checknewxy(a, b) = newxy(a, b)
                relativexy(a, b) = newxy(a, b) - newxy(a, 1)
            Next
        Next
        For newx = 0 To 3
            newrelativexy(0, newx) = dotproduct(0, 1, relativexy(0, newx), relativexy(1, newx))
        Next
        For newy = 0 To 3
            newrelativexy(1, newy) = dotproduct(-1, 0, relativexy(0, newy), relativexy(1, newy))
        Next
        For a = 0 To 1
            For b = 0 To 3
                newxy(a, b) = newrelativexy(a, b) + rotationcords(a)
            Next
        Next
        Dim rotationpossible As Boolean
        rotationpossible = True
        For a = 0 To 1
            For b = 0 To 3
                If a = 0 And (newxy(0, b) < 1 Or newxy(0, b) > 15) Then
                    rotationpossible = False
                End If
                If a = 1 And (newxy(1, b) < 1 Or newxy(1, b) > 25) Then
                    rotationpossible = False
                End If
                If newxy(0, b) < 15 And newxy(0, b) > 0 Then
                    If coloredsquare(newxy(0, b), newxy(1, b)) = True Then
                        rotationpossible = False
                    End If
                End If
            Next
        Next
        If rotationpossible = False Then
            For a = 0 To 1
                For b = 0 To 3
                    newxy(a, b) = checknewxy(a, b)
                Next
            Next
        End If
        setcolor(currentcolor, newxy(0, 0), newxy(0, 1), newxy(0, 2), newxy(0, 3), newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
    End Sub
    Private Function dotproduct(a, b, c, d)
        Dim value As Integer
        value = (a * c) + (b * d)
        Return value
    End Function
    Private Sub Tetris_Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For a = 1 To 3
            enqueueshape()
        Next
        save.Hide()
        savescore.Hide()
        entername.Hide()
        Restart.Hide()
        backtomain.Hide()
        q2.Image = Square.Image
        canhold = True
        holdbox.Hide()
        Gameoverlabel.Hide()
        Tetristitle.Hide()
        Z.Hide()
        minusZ.Hide()
        L.Hide()
        minusL.Hide()
        Line.Hide()
        T.Hide()
        Square.Hide()
        For a = 1 To 15
            For b = 1 To 25
                coloredsquare(a, 25) = False
            Next
        Next
        For x = 1 To 15
            For y = 1 To 25
                newsquare = New PictureBox
                Me.Controls.Add(newsquare)
                grid(x, y) = newsquare
                newsquare.Size = New Size(15, 15)
                newsquare.Location = New Point(x * 20 + 10, y * 20 + 20)
                newsquare.BackColor = Color.White
                newsquare.Visible = True
            Next
        Next
        enqueueshape()
        createnewfallingshape()
        Fall.Enabled = True
    End Sub
    Private Sub createnewfallingshape()
        Dim shape As New fallingshape(queue(0))
        currentshape = queue(0)
        enqueueshape()
        currentcolor = shape.Getcolour
        setcolor(shape.Getcolour, shape.getpos(0, 1), shape.getpos(0, 2), shape.getpos(0, 3), shape.getpos(0, 4), shape.getpos(1, 1), shape.getpos(1, 2), shape.getpos(1, 3), shape.getpos(1, 4))
        For x = 0 To 1
            For y = 0 To 3
                newxy(x, y) = shape.getpos(x, y + 1)
            Next
        Next
        Fall.Enabled = True
    End Sub

    Private Sub createpixel()
        setcolor("white", newxy(0, 0), newxy(0, 1), newxy(0, 2), newxy(0, 3), newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
        Dim pixel As New pixel("pixel", newxy(0, 1), newxy(1, 1), currentcolor)
        setcolor(pixel.Getcolour, pixel.getpos(0, 1), pixel.getpos(0, 2), pixel.getpos(0, 3), pixel.getpos(0, 4), pixel.getpos(1, 1), pixel.getpos(1, 2), pixel.getpos(1, 3), pixel.getpos(1, 4))
        For x = 0 To 1
            For y = 0 To 3
                newxy(x, y) = pixel.getpos(x, y + 1)
            Next
        Next
        Fall.Enabled = True
    End Sub
    Private Sub enqueueshape()
        queue(0) = queue(1)
        q1.Image = q2.Image
        queue(1) = queue(2)
        q2.Image = q3.Image
        Dim picker As Integer
        Randomize()
        picker = Int((7 * Rnd()) + 1)
        If picker = 1 Then
            queue(2) = "Z"
            q3.Image = Z.Image
        ElseIf picker = 2 Then
            queue(2) = "-Z"
            q3.Image = minusZ.Image
        ElseIf picker = 3 Then
            queue(2) = "L"
            q3.Image = L.Image
        ElseIf picker = 4 Then
            queue(2) = "-L"
            q3.Image = minusL.Image
        ElseIf picker = 5 Then
            queue(2) = "line"
            q3.Image = Line.Image
        ElseIf picker = 6 Then
            queue(2) = "T"
            q3.Image = T.Image
        ElseIf picker = 7 Then
            queue(2) = "square"
            q3.Image = Square.Image
        End If
    End Sub


    Private Sub setcolor(colour, x1, x2, x3, x4, y1, y2, y3, y4)
        Dim x(4) As Integer
        x(1) = x1
        x(2) = x2
        x(3) = x3
        x(4) = x4
        Dim y(4) As Integer
        y(1) = y1
        y(2) = y2
        y(3) = y3
        y(4) = y4
        If colour = "green" Then
            For squares = 1 To 4
                grid(x(squares), y(squares)).BackColor = Color.Green
            Next
        ElseIf colour = "red" Then
            For squares = 1 To 4
                grid(x(squares), y(squares)).BackColor = Color.Red
            Next
        ElseIf colour = "orange" Then
            For squares = 1 To 4
                grid(x(squares), y(squares)).BackColor = Color.Orange
            Next
        ElseIf colour = "blue" Then
            For squares = 1 To 4
                grid(x(squares), y(squares)).BackColor = Color.Blue
            Next
        ElseIf colour = "cyan" Then
            For squares = 1 To 4
                grid(x(squares), y(squares)).BackColor = Color.Cyan
            Next
        ElseIf colour = "purple" Then
            For squares = 1 To 4
                grid(x(squares), y(squares)).BackColor = Color.Purple
            Next
        ElseIf colour = "yellow" Then
            For squares = 1 To 4
                grid(x(squares), y(squares)).BackColor = Color.Yellow
            Next
        ElseIf colour = "white" Then
            For squares = 1 To 4
                grid(x(squares), y(squares)).BackColor = Color.White
            Next
        End If
    End Sub

    Private Sub falldown()
        setcolor("white", newxy(0, 0), newxy(0, 1), newxy(0, 2), newxy(0, 3), newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
        For i = 0 To 3
            newxy(1, i) = newxy(1, i) + 1
        Next
        setcolor(currentcolor, newxy(0, 0), newxy(0, 1), newxy(0, 2), newxy(0, 3), newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
        For i = 0 To 3
            If newxy(1, i) = 25 Then
                Fall.Enabled = False
                For squares = 0 To 3
                    coloredsquare(newxy(0, squares), newxy(1, squares)) = True
                Next
                canhold = True
                For a = 0 To 3
                    checkrow(newxy(1, a))
                Next
                score = score + 10
                createnewfallingshape()
            ElseIf coloredsquare(newxy(0, i), newxy(1, i) + 1) = True Then
                Dim top As Boolean
                For a = 1 To 3
                    If coloredsquare(newxy(0, a), newxy(1, a)) = True Then
                        top = True
                    End If
                Next
                If top = True Then
                    gameend = True
                    gameover()
                ElseIf top = False Then
                    Fall.Enabled = False
                    For squares = 0 To 3
                        coloredsquare(newxy(0, squares), newxy(1, squares)) = True
                    Next
                    canhold = True
                    For a = 0 To 3
                        checkrow(newxy(1, a))
                    Next
                    score = score + 10
                    createnewfallingshape()
                End If
            End If
        Next
    End Sub
    Private Sub Tetris_Game_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If gameend = False Then
            If paused = False Then
                If e.KeyChar = Convert.ToChar(97) Then 'a key
                    If newxy(0, 0) <> 1 And newxy(0, 1) <> 1 And newxy(0, 2) <> 1 And newxy(0, 3) <> 1 Then
                        If coloredsquare((newxy(0, 0) - 1), newxy(1, 0)) = False And coloredsquare((newxy(0, 1) - 1), newxy(1, 1)) = False And coloredsquare((newxy(0, 2) - 1), newxy(1, 2)) = False And coloredsquare((newxy(0, 3) - 1), newxy(1, 3)) = False Then
                            setcolor("white", newxy(0, 0), newxy(0, 1), newxy(0, 2), newxy(0, 3), newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
                            setcolor(currentcolor, newxy(0, 0) - 1, newxy(0, 1) - 1, newxy(0, 2) - 1, newxy(0, 3) - 1, newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
                            For x = 0 To 3
                                newxy(0, x) = newxy(0, x) - 1
                            Next
                        End If
                    End If
                End If
                If e.KeyChar = Convert.ToChar(100) Then 'd key
                    If newxy(0, 0) <> 15 And newxy(0, 1) <> 15 And newxy(0, 2) <> 15 And newxy(0, 3) <> 15 Then
                        If coloredsquare((newxy(0, 0) + 1), newxy(1, 0)) = False And coloredsquare((newxy(0, 1) + 1), newxy(1, 1)) = False And coloredsquare((newxy(0, 2) + 1), newxy(1, 2)) = False And coloredsquare((newxy(0, 3) + 1), newxy(1, 3)) = False Then
                            setcolor("white", newxy(0, 0), newxy(0, 1), newxy(0, 2), newxy(0, 3), newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
                            setcolor(currentcolor, newxy(0, 0) + 1, newxy(0, 1) + 1, newxy(0, 2) + 1, newxy(0, 3) + 1, newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
                            For x = 0 To 3
                                newxy(0, x) = newxy(0, x) + 1
                            Next
                        End If
                    End If
                End If
                If e.KeyChar = Convert.ToChar(115) Then
                    falldown()
                End If
                If e.KeyChar = Convert.ToChar(32) And canhold = True Then 'space bar
                    holdbox.Show()
                    Dim temp As String
                    temp = hold
                    hold = currentshape
                    If currentshape = "Z" Then
                        holdbox.Image = Z.Image
                    ElseIf currentshape = "-Z" Then
                        holdbox.Image = minusZ.Image
                    ElseIf currentshape = "L" Then
                        holdbox.Image = L.Image
                    ElseIf currentshape = "-L" Then
                        holdbox.Image = minusL.Image
                    ElseIf currentshape = "line" Then
                        holdbox.Image = Line.Image
                    ElseIf currentshape = "T" Then
                        holdbox.Image = T.Image
                    ElseIf currentshape = "square" Then
                        holdbox.Image = Square.Image
                    End If
                    setcolor("white", newxy(0, 0), newxy(0, 1), newxy(0, 2), newxy(0, 3), newxy(1, 0), newxy(1, 1), newxy(1, 2), newxy(1, 3))
                    Fall.Enabled = False
                    If temp = "" Then
                        temp = queue(0)
                        enqueueshape()
                    End If
                    Dim shape As New fallingshape(temp)
                    currentshape = temp
                    currentcolor = shape.Getcolour
                    setcolor(shape.Getcolour, shape.getpos(0, 1), shape.getpos(0, 2), shape.getpos(0, 3), shape.getpos(0, 4), shape.getpos(1, 1), shape.getpos(1, 2), shape.getpos(1, 3), shape.getpos(1, 4))
                    For x = 0 To 1
                        For y = 0 To 3
                            newxy(x, y) = shape.getpos(x, y + 1)
                        Next
                    Next

                    Fall.Enabled = True
                    canhold = False
                End If
                If e.KeyChar = Convert.ToChar(114) Then 'r key
                    If currentshape <> "square" Then
                        rotate()
                    End If
                End If
                If e.KeyChar = Convert.ToChar(116) And canpixel = True Then 't key
                    createpixel()
                    canpixel = False
                    pixelcooldown = 60
                End If
            End If
            If e.KeyChar = Convert.ToChar(112) Then 'p key
                pausegame()
            End If
        End If
    End Sub
    Private Sub gameover()
        Fall.Enabled = False
        Gameoverlabel.Show()
        Restart.Show()
        backtomain.Show()
        savescore.Show()
    End Sub

    Private Sub checkrow(rowheight)
        Dim rowfull As Boolean
        rowfull = True
        Dim count As Integer
        count = 1
        Do
            If grid(count, rowheight).BackColor = Color.White Then
                rowfull = False
                count = count + 1
            Else
                count = count + 1
            End If
        Loop Until rowfull = False Or count = 16
        If rowfull = True Then
            For y = rowheight To 2 Step -1
                For x = 1 To 15
                    coloredsquare(x, rowheight) = False
                    grid(x, y).BackColor = grid(x, (y - 1)).BackColor
                    If grid(x, y).BackColor = Color.White Then
                        coloredsquare(x, y) = False
                    End If
                    If grid(x, y).BackColor <> Color.White Then
                        coloredsquare(x, y) = True
                    End If
                    If coloredsquare(x, y) = False Then
                        grid(x, y).BackColor = Color.White
                    End If
                Next
            Next
            For b = 0 To 3
                If newxy(1, b) < 25 Then
                    newxy(1, b) = newxy(1, b) + 1
                End If
            Next
            score = score + 50
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Fall.Tick
        falldown()
    End Sub

    Private Sub backtomain_Click(sender As Object, e As EventArgs) Handles backtomain.Click
        Tetristitle.Show()
        Me.Close()
    End Sub

    Private Sub Restart_Click(sender As Object, e As EventArgs) Handles Restart.Click
        Me.Refresh()
    End Sub

    Private Sub savescore_Click(sender As Object, e As EventArgs) Handles savescore.Click
        save.Show()
        entername.Show()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim file As System.IO.StreamWriter
        ApplicationDir = ApplicationDir & "\Scores.txt"
        file = My.Computer.FileSystem.OpenTextFileWriter(ApplicationDir, True)
        file.WriteLine(entername.Text + "##" & Scorecount.Text + "@@")
        file.Close()
        save.Hide()
        entername.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Pause.Click, time.Click, Pixelatetimer.Click, speed.Click
        pausegame()
    End Sub
    Private Sub pausegame()
        If paused = False Then
            Second.Enabled = False
            Fall.Enabled = False
            paused = True
        Else
            Second.Enabled = True
            Fall.Enabled = True
            paused = False
        End If
    End Sub

    Private Sub Second_Tick(sender As Object, e As EventArgs) Handles Second.Tick
        score = score + 1
        Scorecount.Text = score
        seconds = seconds + 1
        If seconds = 60 Then
            seconds = 0
            minutes = minutes + 1
        End If
        time.Text = "Time Survived: " & minutes & ":" & seconds
        If pixelcooldown > 0 Then
            pixelcooldown = pixelcooldown - 1
            Pixelatetimer.Text = "Pixelate cooldown: " & pixelcooldown
        Else
            Pixelatetimer.Text = "Pixelate cooldown: Ready"
            canpixel = True
        End If
        If minutes = 1 Then
            Fall.Interval = 333
            speed.Text = "Speed: x1.5"
        ElseIf minutes = 2 Then
            Fall.Interval = 250
            speed.Text = "Speed: x2"
        End If
    End Sub
End Class