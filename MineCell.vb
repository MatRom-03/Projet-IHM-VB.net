Public Class MineCell
    Inherits Panel

    Public Const MineCellWidth As Integer = 16
    Public Const MineCellHeight As Integer = 16

    Public Enum MineStates

        DefaultCellDiscovered = 0
        BeginCell = 9
        FlagImageCell = 10
        BombCell = 11

    End Enum



    Dim ImageListPictures As ImageList
    Dim decouvert As Boolean = False
    Dim isFlag As Boolean = False
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
            Game.Trace("Clic droit (" & PosX & "," & PosY & ")")
            If isFlag Then
                Me.BackgroundImage = Me.ImageListPictures.Images(MineStates.BeginCell)
                Game.FlagNotUsed()
                isFlag = False
            Else
                If Not Game.FlagUsed() Then
                    Me.BackgroundImage = Me.ImageListPictures.Images(MineStates.FlagImageCell)
                    isFlag = True
                End If
            End If
        ElseIf e.Button = MouseButtons.Left And Not decouvert Then
            Game.Trace("Clic gauche (" & PosX & "," & PosY & ")")
            decovery()
            If value = MineStates.DefaultCellDiscovered Then
                If isFlag Then
                    Game.FlagNotUsed()
                    isFlag = False
                End If
                Game.Discover(Me)
                End If
                If value = MineStates.BombCell Then
                If isFlag Then
                    Game.FlagNotUsed()
                    isFlag = False
                End If
                Game.GameOver()
            End If
        End If

    End Sub

    Public Sub decovery()
        Me.BackgroundImage = Me.ImageListPictures.Images(Me.value)
        decouvert = True
        If isFlag Then
            Game.FlagNotUsed()
            isFlag = False
        End If
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
