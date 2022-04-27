Public Class MineCell
    Inherits Panel

    Public Const MineCellWidth As Integer = 16
    Public Const MineCellHeight As Integer = 16
    'Public Const DefaultCellDiscovered As Integer = 0
    'Public Const FlagImageCell As Integer = 10
    'Public Const BombCell As Integer = 11


    Public Enum MineStates

        DefaultCellDiscovered = 0
        BeginCell = 9
        FlagImageCell = 10
        BombCell = 11

    End Enum



    Dim ImageListPictures As ImageList
    Dim decouvert As Boolean = False
    Dim value As Integer = MineStates.DefaultCellDiscovered
    Dim PosX As Integer
    Dim PosY As Integer
    Sub New(ImageListPictures As ImageList, Index As Integer, PosX As Integer, PosY As Integer)
        Me.ImageListPictures = ImageListPictures
        Me.PosX = PosX
        Me.PosY = PosY
        Me.Width = MineCellWidth
        Me.Height = MineCellHeight
        Me.Location = New Point(PosX * MineCellWidth, PosY * MineCellHeight)
        Me.BackgroundImage = Me.ImageListPictures.Images(Index)
    End Sub

    Protected Overrides Sub OnMouseClick(e As MouseEventArgs)
        MyBase.OnMouseClick(e)

        If e.Button = MouseButtons.Right And Not decouvert Then
            Form1.Trace("Clic droit (" & PosX & "," & PosY & ")")
            Me.BackgroundImage = Me.ImageListPictures.Images(MineStates.FlagImageCell)
        ElseIf e.Button = MouseButtons.Left And Not decouvert Then
            Form1.Trace("Clic gauche (" & PosX & "," & PosY & ")")
            decovery()
            Form1.decouvrir(Me)
        End If

    End Sub

    Public Sub decovery()
        Me.BackgroundImage = Me.ImageListPictures.Images(Me.value)
        decouvert = True
    End Sub

    Public Sub isMine()
        Me.value = MineStates.BombCell
    End Sub

    Public Function getCellValue()
        Return Me.value
    End Function

    Public Function getPoint()
        Return New Point(PosX, PosY)
    End Function

    Public Sub addVoisin()
        If Me.value <> MineStates.BombCell Then
            value += 1
        End If
    End Sub

    Public Function isDiscovered()
        Return decouvert
    End Function

End Class
