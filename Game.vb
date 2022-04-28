Public Class Game

    Dim GameTime As Integer = 60
    Dim Countdown As Integer = GameTime
    Dim nbMines = 10
    Dim ColumnsCount As Integer = 8
    Dim LinesCount As Integer = 8
    Dim TabMineCells As New Hashtable

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

        Dim GridWidth = ColumnsCount * MineCell.MineCellWidth
        Dim GridHeight = LinesCount * MineCell.MineCellHeight

        Grid.Width = GridWidth
        Grid.Height = GridHeight

        Dim index As Integer = 0


        For LineIndex As Integer = 0 To LinesCount - 1
            For ColumnIndex As Integer = 0 To ColumnsCount - 1
                TabMineCells.Add(New Point(ColumnIndex, LineIndex), New MineCell(ImageListPictures, 9, ColumnIndex, LineIndex))
                index += 1
            Next
        Next

        For i As Integer = 0 To nbMines - 1

            While (True)
                Randomize()
                Dim valueX As Integer = CInt(Int((ColumnsCount * Rnd()) + 1))
                Dim valueY As Integer = CInt(Int((ColumnsCount * Rnd()) + 1))
                Dim point As New Point(valueX Mod ColumnsCount, valueY Mod LinesCount)
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
        If x <> ColumnsCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x + 1, y))
            MineTmp.addVoisin()
        End If
        If y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x, y - 1))
            MineTmp.addVoisin()
        End If
        If y <> LinesCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x, y + 1))
            MineTmp.addVoisin()
        End If
        If x <> 0 And y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x - 1, y - 1))
            MineTmp.addVoisin()
        End If
        If x <> 0 And y <> LinesCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x - 1, y + 1))
            MineTmp.addVoisin()
        End If
        If x <> ColumnsCount - 1 And y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x + 1, y - 1))
            MineTmp.addVoisin()
        End If
        If x <> ColumnsCount - 1 And y <> LinesCount - 1 Then
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
        If x <> ColumnsCount - 1 Then
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
        If y <> LinesCount - 1 Then
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
        If x <> 0 And y <> LinesCount - 1 Then
            MineTmp = TabMineCells.Item(New Point(x - 1, y + 1))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
        If x <> ColumnsCount - 1 And y <> 0 Then
            MineTmp = TabMineCells.Item(New Point(x + 1, y - 1))
            If MineTmp.getCellValue < MineCell.MineStates.BeginCell And Not MineTmp.isDiscovered Then
                MineTmp.decovery()
                If MineTmp.getCellValue = MineCell.MineStates.DefaultCellDiscovered Then
                    Discover(MineTmp)
                End If
            End If
        End If
        If x <> ColumnsCount - 1 And y <> LinesCount - 1 Then
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
        GenerateCountdown(3)
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
        If Countdown = GameTime Then
            Trace("Start timer")
            TimerGame.Start()
            Grid.Enabled = True
        Else
            Trace("The counter is deactivated, the game has already been started")
        End If
    End Sub

    Private Sub TimerGame_Tick(sender As Object, e As EventArgs) Handles TimerGame.Tick

        If (Countdown > 0) Then
            If Countdown = 1 Then
                Trace("End Timer")
            End If
            Countdown -= 1
        Else
            TimerGame.Enabled = False
        End If

        CountdownSetImage(Countdown)

    End Sub


    Private Sub GenerateCountdown(ColumnsCount As Integer)

        Dim CountdownWidth = ColumnsCount * CountdownCell.CountdownCellWidth
        Dim CountdownHeight = CountdownCell.CountdownCellHeight

        PanelCountdown.Width = CountdownWidth
        PanelCountdown.Height = CountdownHeight

        For ColumnIndex As Integer = 0 To ColumnsCount - 1

            PanelCountdown.Controls.Add(New CountdownCell(ImageListCountdown, 0, ColumnIndex))

        Next

    End Sub

    Private Sub CountdownSetImage(Number As Integer)

        Dim power As Integer = Math.Pow(10, PanelCountdown.Controls.Count - 1)
        Dim calcul As Integer = Number

        For Each panelindex As CountdownCell In PanelCountdown.Controls

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
        MsgBox("Game Over !")
        For Each cell As MineCell In TabMineCells.Values
            If cell.getCellValue = MineCell.MineStates.BombCell Then
                cell.decovery()
            End If
        Next
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TraceFile("Game Shown")
    End Sub
End Class
