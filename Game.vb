Public Class Game


    Dim FlagCount As Integer = AppSettings.MinesCount
    Dim PlayPause As Boolean = True 'True = play et False = Pause
    Private Const Play As Char = "4"
    Private Const Pause As Char = ";"
    Private Const XbtnPlayPause As Integer = 130
    Private Const XbtnStart As Integer = 120

    Public Sub Trace(TheTrace As String)
        Dim trace As String = GameLauncher.TraceFile(TheTrace)
        If (Not ToolStripMenuItemTrace.Checked) Then
            Return
        End If

        TextBoxTrace.Text += trace & vbNewLine
        TextBoxTrace.SelectionStart = TextBoxTrace.TextLength - 1
        TextBoxTrace.ScrollToCaret()

    End Sub

    Sub PlayLoopingBackgroundSoundResource()
        My.Computer.Audio.Play(My.Resources.music1, AudioPlayMode.BackgroundLoop)
    End Sub

    Sub StopBackgroundSound()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Trace("Width : " & Me.Size.Width & " Height : " & Me.Size.Height)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Trace("load Game")
        ResizeAll()

        If AppSettings.Darkmode Then
            GameLauncher.SetThemeDark(Me)
        Else
            GameLauncher.SetThemeWhite(Me)
        End If
        ButtonGiveUp.Visible = False
        ButtonPlayPause.Visible = False
        LabelGamerName.Text = AppSettings.CurrentPlayer.name
        Me.ToolStripMenuItemTrace.Checked = AppSettings.ActiveTrace
        Grid.Enabled = False
        ButtonPlayPause.Enabled = False
        ButtonPlayPause.Text = Pause
        If AppSettings.CountdownEnabled Then
            GameFunction.Countdown = AppSettings.GameTime
        End If
        GeneratePanelNumber(3, PanelCountdown)
        GeneratePanelNumber(3, PanelFlagCount)
        PanelNumberSetImage(GameFunction.Countdown, PanelCountdown)
        PanelNumberSetImage(FlagCount, PanelFlagCount)
        GameFunction.GenerateGrid()
        TextBoxTrace.Visible = ToolStripMenuItemTrace.Checked
        If Not TextBoxTrace.Visible Then
            Me.Height -= TextBoxTrace.Height
        End If
        ButtonStart.Enabled = True
        PlayLoopingBackgroundSoundResource()
        Trace("load Game finish")

    End Sub

    Private Sub ResizeAll()

        Dim x = 425, y = 425
        If AppSettings.ColumnsCount > 10 Then
            x += (AppSettings.ColumnsCount - 10) * MineCell.MineCellWidth
        End If
        If AppSettings.LinesCount > 10 Then
            y += (AppSettings.LinesCount - 10) * MineCell.MineCellWidth
        End If
        Me.Size = New Size(x, y)
        Dim point As Point = New Point((AppSettings.ColumnsCount * MineCell.MineCellWidth) + XbtnStart, ButtonStart.Location.Y)
        ButtonStart.Location = point
        point.Y = ButtonGiveUp.Location.Y
        ButtonGiveUp.Location = point
        point.X = (AppSettings.ColumnsCount * MineCell.MineCellWidth) + XbtnPlayPause
        point.Y = ButtonPlayPause.Location.Y
        ButtonPlayPause.Location = point

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
        If AppSettings.CountdownEnabled Then
            Trace("Start timer")
            TimerGame.Start()
        Else
            TimerHide.Start()
        End If
        Grid.Enabled = True
        ButtonPlayPause.Enabled = True
        ButtonStart.Enabled = False
        ButtonStart.Visible = False
        ButtonGiveUp.Visible = True
        ButtonPlayPause.Visible = True
    End Sub

    Private Sub TimerGame_Tick(sender As Object, e As EventArgs) Handles TimerGame.Tick

        If (GameFunction.Countdown > 0) Then
            GameFunction.Countdown -= 1
        Else
            Trace("End Timer")
            GameOver()
        End If

        GameFunction.PanelNumberSetImage(GameFunction.Countdown, PanelCountdown)

    End Sub

    Private Sub TimerHide_Tick(sender As Object, e As EventArgs) Handles TimerHide.Tick
        GameFunction.Countdown += 1
    End Sub

    Private Sub Game_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Trace("Game closed")
        Launcher.Show()
    End Sub



    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TraceFile("Game Shown")
    End Sub

    Private Sub ButtonPlayPause_Click(sender As Object, e As EventArgs) Handles ButtonPlayPause.Click
        If GameFunction.GameEnded Then
            Return
        End If
        If AppSettings.CountdownEnabled Then
            If PlayPause Then
                Trace("The game is paused")
                GameFunction.BlockGame()
                ButtonPlayPause.Text = Play
                PlayPause = Not PlayPause
            Else
                Trace("The game resumes")
                TimerGame.Start()
                Grid.Enabled = True
                ButtonPlayPause.Text = Pause
                PlayPause = Not PlayPause
            End If
        Else
            If PlayPause Then
                Trace("The game is paused")
                GameFunction.BlockGame()
                ButtonPlayPause.Text = Play
                PlayPause = Not PlayPause
            Else
                Trace("The game resumes")
                TimerHide.Start()
                Grid.Enabled = True
                ButtonPlayPause.Text = Pause
                PlayPause = Not PlayPause
            End If
        End If
    End Sub


    Private Sub ButtonGiveUp_Click(sender As Object, e As EventArgs) Handles ButtonGiveUp.Click
        Me.Close()
    End Sub

    Private Sub Launcher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        StopBackgroundSound()
        If GameFunction.GameEnded Then
            Return
        End If
        If MsgBox("Etes-vous sûr d'abandonner la partie ?", MsgBoxStyle.YesNo, "Exit Game") = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class