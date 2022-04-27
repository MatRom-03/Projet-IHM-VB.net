Public Class MineCell
    Inherits Panel

    Public Const MineCellWidth As Integer = 16
    Public Const MineCellHeight As Integer = 16

    Dim ImageListPictures As ImageList
    Dim Index As Integer
    Dim PosX As Integer
    Dim PosY As Integer
    Sub New(ImageListPictures As ImageList, Index As Integer, PosX As Integer, PosY As Integer)
        Me.ImageListPictures = ImageListPictures
        Me.Index = Index
        Me.PosX = PosX
        Me.PosY = PosY
        Me.Width = MineCellWidth
        Me.Height = MineCellHeight
        Me.Location = New Point(PosX * MineCellWidth, PosY * MineCellHeight)
        Me.BackgroundImage = Me.ImageListPictures.Images(Index)
    End Sub

    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        MyBase.OnMouseClick(e)

        If e.Button = MouseButtons.Right Then
            Form1.Trace("Right (" & PosX & "," & PosY & ")")
        ElseIf e.Button = MouseButtons.Left Then
            Form1.Trace("Left (" & PosX & "," & PosY & ")")
        End If


    End Sub

End Class
