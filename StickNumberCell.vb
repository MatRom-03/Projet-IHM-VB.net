Public Class StickNumberCell
    Inherits Panel

    Public Const CountdownCellWidth As Integer = 21
    Public Const CountdownCellHeight As Integer = 41

    Dim ImageListCountdown As ImageList
    Dim Index As Integer
    Dim PosX As Integer
    Dim PosY As Integer
    Sub New(ImageListCountdown As ImageList, Index As Integer, PosX As Integer)
        Me.ImageListCountdown = ImageListCountdown
        Me.Index = Index
        Me.PosX = PosX
        Me.PosY = 0
        Me.Width = CountdownCellWidth
        Me.Height = CountdownCellHeight
        Me.Location = New Point(Me.PosX * CountdownCellWidth, 0)
        Me.BackgroundImage = Me.ImageListCountdown.Images(Index)
    End Sub


    Public Sub setNumber(Index As Integer)
        Me.Index = Index
        Me.BackgroundImage = Me.ImageListCountdown.Images(Index)
    End Sub

End Class
