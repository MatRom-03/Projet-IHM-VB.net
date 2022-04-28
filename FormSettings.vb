Public Class FormSettings

    Private Sub FormSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxColumnsCount.Text = AppSettings.ColumnsCount
        TextBoxLinesCount.Text = AppSettings.LinesCount
        TextBoxMinesCount.Text = AppSettings.MinesCount
    End Sub

    Private Sub ButtonValidate_Click(sender As Object, e As EventArgs) Handles ButtonValidate.Click

        Dim ColumnsCount As Integer
        If Not Integer.TryParse(TextBoxColumnsCount.Text, ColumnsCount) Then
            Me.ErrorProviderSettings.SetError(TextBoxColumnsCount, "Valeur incorrecte")
            Return
        End If
        Dim LinesCount As Integer
        If Not Integer.TryParse(TextBoxLinesCount.Text, LinesCount) Then
            Me.ErrorProviderSettings.SetError(TextBoxLinesCount, "Valeur incorrecte")
            Return
        End If
        Dim MinesCount As Integer
        If Not Integer.TryParse(TextBoxMinesCount.Text, MinesCount) Then
            Me.ErrorProviderSettings.SetError(TextBoxMinesCount, "Valeur incorrecte")
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

        Me.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Close()
    End Sub

End Class