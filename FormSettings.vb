Public Class FormSettings

    Dim ValidatedChange As Boolean = False
    Private Const MAX_VALUE_COLUMN_LINE As Integer = 20
    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AppSettings.Darkmode Then
            GameLauncher.SetThemeDark(Me)
        Else
            GameLauncher.SetThemeWhite(Me)
        End If
        If AppSettings.Darkmode Then
            ComboBoxTheme.Text = "Sombre"
        Else
            ComboBoxTheme.Text = "Clair"
        End If
        ComboBoxTheme.Items.Add("Sombre")
        ComboBoxTheme.Items.Add("Clair")
        TextBoxPathXml.Text = AppSettings.StoragePathXMLFile
        TextBoxColumnsCount.Text = AppSettings.ColumnsCount
        TextBoxLinesCount.Text = AppSettings.LinesCount
        TextBoxMinesCount.Text = AppSettings.MinesCount
        TextBoxCountdown.Text = AppSettings.GameTime
        CheckBoxCountdown.Checked = AppSettings.CountdownEnabled
        TextBoxCountdown.Enabled = CheckBoxCountdown.Checked
    End Sub

    Private Sub ButtonValidate_Click(sender As Object, e As EventArgs) Handles ButtonValidate.Click
        Me.ErrorProviderSettings.Clear()
        Dim ColumnsCount As Integer
        If Not Integer.TryParse(TextBoxColumnsCount.Text, ColumnsCount) Then
            Me.ErrorProviderSettings.SetError(TextBoxColumnsCount, "Valeur incorrecte.")
            Return
        End If
        If ColumnsCount > MAX_VALUE_COLUMN_LINE Then
            Me.ErrorProviderSettings.SetError(TextBoxColumnsCount, "Valeur trop grande, la valeur max est 20")
            Return
        End If
        Dim LinesCount As Integer
        If Not Integer.TryParse(TextBoxLinesCount.Text, LinesCount) Then
            Me.ErrorProviderSettings.SetError(TextBoxLinesCount, "Valeur incorrecte.")
            Return
        End If
        If LinesCount > MAX_VALUE_COLUMN_LINE Then
            Me.ErrorProviderSettings.SetError(TextBoxLinesCount, "Valeur trop grande, la valeur max est 20")
            Return
        End If
        Dim MinesCount As Integer
        If Not Integer.TryParse(TextBoxMinesCount.Text, MinesCount) Then
            Me.ErrorProviderSettings.SetError(TextBoxMinesCount, "Valeur incorrecte.")
            Return
        End If
        Dim Countdown As Integer
        If Not Integer.TryParse(TextBoxCountdown.Text, Countdown) Then
            Me.ErrorProviderSettings.SetError(TextBoxCountdown, "Valeur incorrecte.")
            Return
        ElseIf TextBoxCountdown.Text > 999 Then
            Me.ErrorProviderSettings.SetError(TextBoxCountdown, "Valeur trop élevée, le maximum est de 999 secondes.")
            Return
        End If

        If MinesCount > ColumnsCount * LinesCount Then
            Me.ErrorProviderSettings.SetError(TextBoxMinesCount, "Nombre de mines trop élevé.")
            Return
        End If

        AppSettings.ColumnsCount = ColumnsCount
        TraceFile("ColumnsCount setting set to : " & ColumnsCount)
        AppSettings.LinesCount = LinesCount
        TraceFile("LinesCount setting set to : " & LinesCount)
        AppSettings.MinesCount = MinesCount
        TraceFile("MinesCount setting set to : " & MinesCount)
        AppSettings.GameTime = Countdown
        TraceFile("GameTime setting set to : " & Countdown)
        If ComboBoxTheme.Text = "Sombre" Then
            AppSettings.Darkmode = True
            GameLauncher.SetThemeDark(Launcher)
        Else
            AppSettings.Darkmode = False
            GameLauncher.SetThemeWhite(Launcher)
        End If
        AppSettings.CountdownEnabled = CheckBoxCountdown.Checked
        TraceFile("CountdownEnabled setting set to : " & CheckBoxCountdown.Checked)
        AppSettings.StoragePathXMLFile = TextBoxPathXml.Text
        TraceFile("The new storage path for the XML file is: " & FolderBrowserDialogPathXml.SelectedPath)

        Launcher.Trace("Settings have been updated")
        ValidatedChange = True
        Launcher.Show()
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Launcher.Show()
        Me.Close()
    End Sub

    Private Sub CheckBoxCountdown_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCountdown.CheckedChanged
        TextBoxCountdown.Enabled = CheckBoxCountdown.Checked
    End Sub

    Private Sub ButtonModifyPath_Click(sender As Object, e As EventArgs) Handles ButtonModifyPath.Click
        FolderBrowserDialogPathXml.SelectedPath = Application.StartupPath
        FolderBrowserDialogPathXml.ShowDialog()
        TextBoxPathXml.Text = FolderBrowserDialogPathXml.SelectedPath
    End Sub

    Private Sub FormSettings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ValidatedChange Then
            Launcher.Show()
            Return
        End If
        If MsgBox("Etes-vous sûr de ne pas enregistrer les modifications ?", MsgBoxStyle.YesNo, "Exit Settings") = MsgBoxResult.No Then
            e.Cancel = True
        Else
            Launcher.Show()
        End If
    End Sub

End Class