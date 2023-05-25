Public Class Tetristitle
    Dim ApplicationDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
    Dim entries As New Dictionary(Of String, Integer)
    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        Tetris_Game.Show()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        End
    End Sub

    Private Sub Tetristitle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplicationDir = ApplicationDir & "\Scores.txt"
        addentries()
        Names.Hide()
        Close.Hide()
        Sort.Hide()
        Sort2.Hide()
    End Sub

    Private Sub addentries()
        Dim name, score As String
        name = ""
        score = ""
        Dim line As String
        Dim text As New System.IO.StreamReader(CStr(ApplicationDir))
        Dim namefound, scorefound As Boolean
        Dim character As Integer
        Do Until text.Peek = -1
            line = text.ReadLine()
            name = ""
            score = ""
            character = 0
            Do Until namefound = True
                If line(character) = "#" And line(character + 1) = "#" Then
                    namefound = True
                    character = character + 2
                Else
                    name = name & line(character)
                    character = character + 1
                End If
            Loop
            Do Until scorefound = True
                If line(character) = "@" And line(character + 1) = "@" Then
                    scorefound = True
                Else
                    score = score & line(character)
                    character = character + 1
                End If
            Loop
            namefound = False
            scorefound = False
            entries.Add(name, CInt(score))
        Loop
        For Each pair As KeyValuePair(Of String, Integer) In entries
            Names.Text = Names.Text & pair.Key & ": " & pair.Value & ", "
        Next
    End Sub
    Private Sub Leaderboard_Click(sender As Object, e As EventArgs) Handles Leaderboard.Click
        Sort.Show()
        Sort2.Show()
        Close.Show()
        Names.Show()
    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles Close.Click
        Names.Hide()
        Close.Hide()
        Sort.Hide()
        Sort2.Hide()
    End Sub

    Private Sub Sort_Click(sender As Object, e As EventArgs) Handles Sort.Click
        Names.Text = ""
        Dim count As Integer
        Dim scores(entries.Count - 1) As Integer
        For Each pair As KeyValuePair(Of String, Integer) In entries
            scores(count) = pair.Value
            count = count + 1
        Next
        Dim counter As Integer = scores.Length
        Dim temp As Integer
        For loop1 = 0 To scores.Length - 1
            For loop2 = 0 To scores.Length - 2
                If scores(loop2) < scores(loop2 + 1) Then
                    temp = scores(loop2)
                    scores(loop2) = scores(loop2 + 1)
                    scores(loop2 + 1) = temp
                End If
            Next
        Next
        count = 0
        Dim sortedentries As New Dictionary(Of String, Integer)
        Do Until sortedentries.Count = entries.Count
            For Each pair As KeyValuePair(Of String, Integer) In entries
                If scores(count) = pair.Value And sortedentries.ContainsKey(pair.Key) = False Then
                    sortedentries.Add(pair.Key, pair.Value)
                End If
            Next
            count = count + 1
        Loop
        For Each pair As KeyValuePair(Of String, Integer) In sortedentries
            Names.Text = Names.Text & pair.Key & ": " & pair.Value & ", "
        Next
    End Sub

    Private Sub Sort2_Click(sender As Object, e As EventArgs) Handles Sort2.Click
        Names.Text = ""
        For Each pair As KeyValuePair(Of String, Integer) In entries
            Names.Text = Names.Text & pair.Key & ": " & pair.Value & ", "
        Next
    End Sub
End Class
