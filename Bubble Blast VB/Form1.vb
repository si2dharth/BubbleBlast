Public Class BubbleBlast

    Private Sub BubbleBlast_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        TheEnvironment.Game = Me
        PrepareLevel(1)
    End Sub

    Private Sub PrepareLevel(levelnumber As Integer)
        R = New Random(levelnumber)
        Dim b As Bubble
        Dim p As New Point
        For i = 1 To 9
            For j = 1 To 9
                b = New Bubble(R.Next() Mod 4 + 1, TheEnvironment)
                p.X = i * TheEnvironment.Width / 10 - b.Width / 2
                p.Y = j * TheEnvironment.Height / 10 - b.Height / 2
                b.Location = p
            Next
        Next
    End Sub

    Public Sub NextLevel()
        CurLevel += 1
        PrepareLevel(CurLevel)
    End Sub

    Dim R As Random
    Dim CurLevel As Integer = 1
End Class

