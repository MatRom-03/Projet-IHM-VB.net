Public Class Game

    Dim TabMineCells As New Hashtable
    Dim GameStart As Boolean = False
    Dim Countdown As Integer = AppSettings.GameTime
    Dim FlagCount As Integer = AppSettings.MinesCount
    Dim CellDiscovered As Integer = 0

    Public Sub Trace(TheTrace As String)
        Dim trace As String = GameLuncher.TraceFile(TheTrace)
        If (Not ToolStripMenuItemTrace.Checked) Then
            Return
        End If

        TextBoxTrace.Text += trace & vbNewLine
        TextBoxTrace.SelectionStart = TextBoxTrace.TextLength - 1
        TextBoxTrace.ScrollToCaret()

    End Sub



    Private Sub Grid_MouseClick(sender As Object, e As MouseEventArgs) Handles Grid.MouseClick
        If e.Button = MouseButtons.Right Then
            MsgBox("Right", MsgBoxStyle.OkOnly)
        Else
            MsgBox("Ohter", MsgBoxStyle.OkOnly)
        End If
    End Sub


    Private Sub GenerateGrid()

        Dim GridWidth = AppSettings.ColumnsCount * MineCell.MineCellWidth
        Dim GridHeight = AppSettings.LinesCount * MineCell.MineCellHeight

        Grid.Width = GridWidth
        Grid.Height = GridHeight

        Dim index As Integer = 0


        For LineIndex As Integer = 0 To AppSettings.LinesCount - 1
            For ColumnIndex As Integer = 0 To AppSettings.ColumnsCount - 1
                TabMineCells.Add(New Point(ColumnIndex, LineIndex), New MineCell(ImageListPictures, 9, ColumnIndex, LineIndex))
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
            Grid.Controls.Add(cell)
        Next

    End Sub

    Private Sub setVoisins(cell As MineCell)
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Trace("load Game")
        LabelGamerName.Text = AppSettings.LastGamer
        Me.ToolStripMenuItemTrace.Checked = AppSettings.ActiveTrace
        Grid.Enabled = False
        GeneratePanelNumber(3, PanelCountdown)
        GeneratePanelNumber(3, PanelFlagCount)
        PanelNumberSetImage(Countdown, PanelCountdown)
        PanelNumberSetImage(FlagCount, PanelFlagCount)
        GenerateGrid()
        TextBoxTrace.Visible = ToolStripMenuItemTrace.Checked
        If Not TextBoxTrace.Visible Then
            Me.Height -= TextBoxTrace.Height
        End If

        Trace("load Game finish")

    End Sub

    Private Sub ToolStripMenuItemTrace_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemTrace.Click
        ToolStripMenuItemTrace.Checked = Not ToolStripMenuItemTrace.Checked
        Launcher.ToolStripMenuItemTrace.Checked = ToolStripMenuItemTrace.Checked

        TextBoxTrace.Visible = ToolStripMenuItemTrace.Checked
        AppSettings.ActiveTrace = ToolStripMenuItemTrace.Checked

        If (TextBoxTrace.Visible) Then
            Me.Height += TextBoxTrace.Height
        Else
            Me.Height -= TextBoxTrace.Height
        End If

    End Sub


    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        If Not GameStart Then
            If AppSettings.CountdownEnabled Then
                Trace("Start timer")
                TimerGame.Start()
            End If
            Grid.Enabled = True
            GameStart = True
        Else
            Trace("The counter is deactivated, the game has already been started")
        End If
    End Sub

    Private Sub TimerGame_Tick(sender As Object, e As EventArgs) Handles TimerGame.Tick

        If (Countdown > 0) Then
            Countdown -= 1
        Else
            Trace("End Timer")
            GameOver()
        End If

        PanelNumberSetImage(Countdown, PanelCountdown)

    End Sub


    Private Sub GeneratePanelNumber(ColumnsCount As Integer, panel As Panel)

        Dim CountdownWidth = ColumnsCount * CountdownCell.CountdownCellWidth
        Dim CountdownHeight = CountdownCell.CountdownCellHeight

        panel.Width = CountdownWidth
        panel.Height = CountdownHeight

        For ColumnIndex As Integer = 0 To ColumnsCount - 1

            panel.Controls.Add(New CountdownCell(ImageListCountdown, 0, ColumnIndex))

        Next

    End Sub


    Private Sub PanelNumberSetImage(Number As Integer, panel As Panel)

        Dim power As Integer = Math.Pow(10, PanelCountdown.Controls.Count - 1)
        Dim calcul As Integer = Number

        For Each panelindex As CountdownCell In panel.Controls

            Dim result As Integer = Math.Truncate(calcul / power)
            panelindex.setNumber(result)
            calcul -= result * power

            power /= 10

        Next
    End Sub


    Private Sub Game_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Trace("Game closed")
        Launcher.Show()
    End Sub

    Public Sub GameOver()
        Trace("End game")
        TimerGame.Enabled = False
        Grid.Enabled = False
        For Each cell As MineCell In TabMineCells.Values
            If cell.getCellValue = MineCell.MineStates.BombCell Then
                cell.decovery()
            End If
        Next
        MsgBox("Game Over !")
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TraceFile("Game Shown")
    End Sub

    Public Function FlagUsed()
        Dim Remaining As Boolean = False
        If FlagCount > 0 Then
            FlagCount -= 1
        Else
            Remaining = True
        End If
        PanelNumberSetImage(FlagCount, PanelFlagCount)
        Return Remaining
    End Function

    Public Sub FlagNotUsed()
        FlagCount += 1
        PanelNumberSetImage(FlagCount, PanelFlagCount)
    End Sub

End Class
