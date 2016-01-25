Imports Microsoft.VisualBasic.PowerPacks
Public Class Environment
    Inherits Panel

    Public Sub New()
        Shp = New ShapeContainer
        Controls.Add(Shp)
        MovShp = New ShapeContainer
        Controls.Add(MovShp)
        DoubleBuffered = True
    End Sub

    Public Sub Add(bubble As Bubble)
        Shp.Shapes.Add(bubble)
    End Sub

    Public Sub Remove(bubble As Bubble)
        Shp.Shapes.Remove(bubble)
        If Shp.Shapes.Count = 0 Then LevelComplete()
    End Sub

    Public Sub Add(chainElement As ChainElement)
        MovShp.Shapes.Add(chainElement)
    End Sub

    Public Sub Remove(chainElement As ChainElement)
        MovShp.Shapes.Remove(chainElement)
    End Sub

    Public Function GetBubble(x As Integer, y As Integer) As Bubble
        Return Shp.GetChildAtPoint(New Point(x, y))
    End Function

    Private Sub LevelComplete()
        MsgBox("Level Complete!" + vbNewLine + "Number of Clicks : " + Convert.ToString(numberOfClicks))
        Game.NextLevel()
        numberOfClicks = 0
        ChainElement.StopAll()
        MovShp.Shapes.Clear()
        Me.Enabled = True
    End Sub

    Private Shp As ShapeContainer
    Private MovShp As ShapeContainer
    Public Game As BubbleBlast

    Private _numberOfClicks As Integer
    Public Property numberOfClicks() As Integer
        Get
            Return _numberOfClicks
        End Get
        Set(ByVal value As Integer)
            _numberOfClicks = value
            Game.numberOfClicksLabel.Text = _numberOfClicks.ToString
        End Set
    End Property

End Class
