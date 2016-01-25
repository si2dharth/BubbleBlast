Imports Microsoft.VisualBasic.PowerPacks
Public Class Bubble
    Inherits OvalShape
    Const MAXLEVEL As Integer = 5

    Public Sub New(level As Integer, env As Environment)
        Surroundings = env
        FillStyle = PowerPacks.FillStyle.Solid
        BackStyle = PowerPacks.BackStyle.Opaque
        Me.Level = level
        Surroundings.Add(Me)
    End Sub

    Private Sub Blast()
        Dim p As New Point(Location.X + Width / 2 - 2, Location.Y + Height / 2 - 2)
        Dim c1 As New ChainElement(1, Surroundings)
        Dim c2 As New ChainElement(2, Surroundings)
        Dim c3 As New ChainElement(-1, Surroundings)
        Dim c4 As New ChainElement(-2, Surroundings)
        c1.Location = p
        c2.Location = p
        c3.Location = p
        c4.Location = p
        Surroundings.Remove(Me)
        Me.Dispose()
    End Sub

    Private Sub CalculateColor()
        Select Case Level
            Case 0
                Blast()
            Case 1
                FillColor = Color.Red
                BorderColor = Color.OrangeRed
            Case 2
                FillColor = Color.Green
                BorderColor = Color.LightGreen
            Case 3
                FillColor = Color.Yellow
                BorderColor = Color.LightYellow
            Case 4
                FillColor = Color.Blue
                BorderColor = Color.LightBlue
        End Select
    End Sub

    Public Sub Hit()
        Level -= 1
    End Sub

    Private Sub Clicked(sender As Bubble, e As MouseEventArgs) Handles Me.MouseClick
        Me.Hit()
        Surroundings.numberOfClicks += 1
    End Sub

    Private Surroundings As Environment
    Private _Level As Integer
    Public Property Level() As Integer
        Get
            Return _Level
        End Get
        Set(ByVal value As Integer)
            Dim Cx, Cy As Integer
            Cx = Location.X + Me.Width / 2
            Cy = Location.Y + Me.Height / 2
            _Level = value
            Width = (MAXLEVEL - _Level) * 5
            Height = Width
            Location = New Point(Cx - Width / 2, Cy - Height / 2)
            CalculateColor()
        End Set
    End Property

End Class
