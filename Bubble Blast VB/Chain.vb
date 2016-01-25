Imports Microsoft.VisualBasic.PowerPacks
Imports System.ComponentModel

Public Class ChainElement
    Inherits OvalShape

    Const RADIUS As Integer = 5

    Public Sub New(Direction As Integer, env As Environment)        'Direction : -1 is Left, 1 is Right, -2 is Up, 2 is Down
        Width = RADIUS
        Height = RADIUS

        Surroundings = env
        env.Add(Me)
        env.Enabled = False

        T.Interval = 10
        T.Enabled = True
        ChainQueue.Add(Me)

        Vx = (Direction Mod 2) * 2
        Vy = ((Direction + 1) Mod 2) * 2

        BackStyle = PowerPacks.BackStyle.Opaque
        BorderColor = Color.OrangeRed
        FillStyle = PowerPacks.FillStyle.Solid
        FillColor = Color.Red

    End Sub

    Public Sub Hit()
        RemoveList.Enqueue(Me)
        Surroundings.Remove(Me)
    End Sub

    Shared Sub Timer_Tick(sender As Timer, e As EventArgs) Handles T.Tick
        RemoveCycle()
        If ChainQueue.Count = 0 Then
            Surroundings.Enabled = True
            T.Enabled = False
            Return
        End If
        For i = 0 To ChainQueue.Count - 1
            If i >= ChainQueue.Count Then Exit For
            With ChainQueue(i)
                Dim p As Point = .Location
                p.X += .Vx
                p.Y += .Vy
                .Location = p
                If p.X < 0 Or p.Y < 0 Or p.X > Surroundings.Width Or p.Y > Surroundings.Height Then
                    .Hit()
                    Continue For
                End If
                Dim b As Bubble = Surroundings.GetBubble(.Location.X + .Width / 2, .Location.Y + .Height / 2)
                If Not IsNothing(b) Then
                    b.Hit()
                    .Hit()
                End If
            End With
        Next
    End Sub

    Public Shared Sub StopAll()
        T.Enabled = False
        RemoveList.Clear()
        ChainQueue.Clear()
    End Sub

    Shared Sub RemoveCycle()
        While RemoveList.Count > 0
            Dim c As ChainElement = RemoveList.Dequeue()
            ChainQueue.Remove(c)
            c.Dispose()
        End While
    End Sub

    Shared WithEvents T As New Timer
    Shared ChainQueue As New List(Of ChainElement)
    Shared RemoveList As New Queue(Of ChainElement)
    Private Vx, Vy As Integer
    Shared Surroundings As Environment
End Class
