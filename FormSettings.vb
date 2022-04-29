Public Class FormSettings

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim LinesCount As Integer
        If Not Integer.TryParse(TextBoxLinesCount.Text, LinesCount) Then
            Me.ErrorProviderSettings.SetError(TextBoxLinesCount, "Valeur incorrecte.")
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
        AppSettings.CountdownEnabled = CheckBoxCountdown.Checked
        TraceFile("CountdownEnabled setting set to : " & CheckBoxCountdown.Checked)

        Launcher.Trace("Settings have been updated")
        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

    Private Sub CheckBoxCountdown_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxCountdown.CheckedChanged
        TextBoxCountdown.Enabled = CheckBoxCountdown.Checked
    End Sub
End Class