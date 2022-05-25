Module GameFunction

    Public TabMineCells As New Hashtable
    Public Countdown As Integer
    Dim FlagCount As Integer = AppSettings.MinesCount
    Dim CellDiscovered As Integer = 0
    Dim LastReveal As Integer = 0
    Public GameEnded As Boolean = False
    Private hasAlreadyBeenUsed As Boolean = False

    Private Sub clearPreviousData()
        If Not hasAlreadyBeenUsed Then
            hasAlreadyBeenUsed = True
            Return
        End If
        TabMineCells.Clear()
        FlagCount = AppSettings.MinesCount
        CellDiscovered = 0
        LastReveal = 0
        GameEnded = False
    End Sub
    Public Sub GenerateGrid()

        clearPreviousData()

        Dim GridWidth = AppSettings.ColumnsCount * MineCell.MineCellWidth
        Dim GridHeight = AppSettings.LinesCount * MineCell.MineCellHeight

        Game.Grid.Width = GridWidth
        Game.Grid.Height = GridHeight

        Dim index As Integer = 0


        For LineIndex As Integer = 0 To AppSettings.LinesCount - 1
            For ColumnIndex As Integer = 0 To AppSettings.ColumnsCount - 1
                TabMineCells.Add(New Point(ColumnIndex, LineIndex), New MineCell(Game.ImageListPictures, 9, ColumnIndex, LineIndex))
                index += 1
            Next
        Next

        For i As Integer = 0 To AppSettings.MinesCount - 1

            While (True)
                Randomize()
                Dim valueX As Integer = CInt(Int((AppSettings.ColumnsCount * Rnd()) + 1))
                Dim valueY As Integer = CInt(Int((AppSettings.ColumnsCount * Rnd()) + 1))
                Dim point As New Point(valueX Mod AppSettings.ColumnsCount, valueY Mod AppSettings.LinesCount)
                Dim cellMine As MineCell = TabMineCells.Item(point)
                If cellMine.getCellValue <> MineCell.MineStates.BombCell Then
                    cellMine.isMine()
                    setVoisins(cellMine)
                    Exit While
                End If
            End While
        Next

        For Each cell As MineCell In TabMineCells.Values
            Game.Grid.Controls.Add(cell)
        Next

    End Sub

    Public Sub setVoisins(cell As MineCell)
        Dim point As Point = cell.getPoint
        Dim x As Integer = point.X
        Dim y As Integer = point.Y
        Dim MineTmp As MineCell
        If x <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x - 1, y))
            MineTmp.addVoisin()
        End If
        If x <> AppSettings.ColumnsCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x + 1, y))
            MineTmp.addVoisin()
        End If
        If y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x, y - 1))
            MineTmp.addVoisin()
        End If
        If y <> AppSettings.LinesCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x, y + 1))
            MineTmp.addVoisin()
        End If
        If x <> 0 And y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x - 1, y - 1))
            MineTmp.addVoisin()
        End If
        If x <> 0 And y <> AppSettings.LinesCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x - 1, y + 1))
            MineTmp.addVoisin()
        End If
        If x <> AppSettings.ColumnsCount - 1 And y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x + 1, y - 1))
            MineTmp.addVoisin()
        End If
        If x <> AppSettings.ColumnsCount - 1 And y <> AppSettings.LinesCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x + 1, y + 1))
            MineTmp.addVoisin()
        End If
    End Sub

    Public Sub Discover(cell As MineCell)
        Dim point As Point = cell.getPoint
        Dim x As Integer = point.X
        Dim y As Integer = point.Y
        Dim MineTmp As MineCell
        If x <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x - 1, y))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
        If x <> AppSettings.ColumnsCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x + 1, y))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
        If y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x, y - 1))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
        If y <> AppSettings.LinesCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x, y + 1))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
        If x <> 0 And y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x - 1, y - 1))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
        If x <> 0 And y <> AppSettings.LinesCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x - 1, y + 1))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
        If x <> AppSettings.ColumnsCount - 1 And y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x + 1, y - 1))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
        If x <> AppSettings.ColumnsCount - 1 And y <> AppSettings.LinesCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x + 1, y + 1))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
    End Sub

    Public Sub GeneratePanelNumber(ColumnsCount As Integer, panel As Panel)

        Dim CountdownWidth = ColumnsCount * StickNumberCell.CountdownCellWidth
        Dim CountdownHeight = StickNumberCell.CountdownCellHeight

        panel.Width = CountdownWidth
        panel.Height = CountdownHeight

        For ColumnIndex As Integer = 0 To ColumnsCount - 1

            panel.Controls.Add(New StickNumberCell(Game.ImageListCountdown, 0, ColumnIndex))

        Next

    End Sub


    Public Sub PanelNumberSetImage(Number As Integer, panel As Panel)

        Dim power As Integer = Math.Pow(10, Game.PanelCountdown.Controls.Count - 1)
        Dim calcul As Integer = Number

        For Each panelindex As StickNumberCell In panel.Controls

            Dim result As Integer = Math.Truncate(calcul / power)
            panelindex.setNumber(result)
            calcul -= result * power

            power /= 10

        Next
    End Sub

    Public Sub GameOver()
        Game.Trace("Game Over")
        For Each cell As MineCell In TabMineCells.Values
            If cell.getCellValue = MineCell.MineStates.BombCell Then
                cell.decovery()
            End If
        Next
        BlockGame()
        EndGame("Game Over !")
    End Sub

    Public Sub GameWon()
        If FlagCount = 0 And CellDiscovered = (AppSettings.ColumnsCount * AppSettings.LinesCount - AppSettings.MinesCount) Then
            Game.Trace("The game is won")
            BlockGame()
            EndGame("Vous avez gagné !!")
        End If
    End Sub

    Public Sub BlockGame()
        If AppSettings.CountdownEnabled Then
            Game.TimerGame.Stop()
        Else
            Game.TimerHide.Stop()
        End If
        Game.Grid.Enabled = False
    End Sub

    Public Sub EndGame(result As String)
        Game.ButtonPlayPause.Visible = False
        If AppSettings.CurrentPlayer.CellDiscoveredMax < CellDiscovered Then
            AppSettings.CurrentPlayer.CellDiscoveredMax = CellDiscovered
            AppSettings.CurrentPlayer.TimeGame = LastReveal
        End If
        If AppSettings.CurrentPlayer.CellDiscoveredMax = CellDiscovered And AppSettings.CurrentPlayer.TimeGame > LastReveal Then
            AppSettings.CurrentPlayer.CellDiscoveredMax = CellDiscovered
            AppSettings.CurrentPlayer.TimeGame = LastReveal
        End If
        AppSettings.CurrentPlayer.GameCount += 1
        If AppSettings.CountdownEnabled Then
            AppSettings.CurrentPlayer.TimeCount += (AppSettings.GameTime - Countdown)
        Else
            AppSettings.CurrentPlayer.TimeCount += Countdown
        End If
        Dim Results As String = ""
        Results += result & vbNewLine & "Nombre de cellules révélées : " & CellDiscovered & " cellules." & vbNewLine
        Results += "Temps jusqu'à la dernière révélation : " & LastReveal & " sec. " & vbNewLine
        Results += "Temps de la partie : "
        If AppSettings.CountdownEnabled Then
            Results += (AppSettings.GameTime - Countdown).ToString
        Else
            Results += Countdown.ToString
        End If
        Results += "sec."
        MsgBox(Results, MsgBoxStyle.OkOnly, "Résultats")
        GameEnded = True
    End Sub

    Public Sub LastRevealUpdate()
        If AppSettings.CountdownEnabled Then
            LastReveal = AppSettings.GameTime - Countdown
        Else
            LastReveal = Countdown
        End If
    End Sub

    Public Function FlagUsed()
        Dim Remaining As Boolean = False
        If FlagCount > 0 Then
            FlagCount -= 1
        Else
            Remaining = True
        End If
        PanelNumberSetImage(FlagCount, Game.PanelFlagCount)
        Return Remaining
    End Function

    Public Sub FlagNotUsed()
        FlagCount += 1
        PanelNumberSetImage(FlagCount, Game.PanelFlagCount)
    End Sub

    Public Sub CellDiscoveredCount()
        CellDiscovered += 1
        If CellDiscovered = (AppSettings.ColumnsCount * AppSettings.LinesCount - AppSettings.MinesCount) Then
            Game.Trace("All normal cell have been uncovered")
            GameWon()
        End If
    End Sub
End Module
