Imports System.Xml
Public Class Launcher

    Private Sub BtnNewGame_Click(sender As Object, e As EventArgs) Handles BtnNewGame.Click
        If ComboBoxNameGamer.Text.Length < 3 Then
            Me.ErrorProviderLauncher.SetError(ComboBoxNameGamer, "Nom trop court.")
            Return
        End If
        Dim newgamer As String = ComboBoxNameGamer.Text
        newgamer.Trim()
        Dim bFound As Boolean = False
        For Each gamer As String In AppSettings.GamersList

            If (String.Compare(gamer, newgamer, True) = 0) Then
                bFound = True
                Exit For
            End If
        Next

        If (Not bFound) Then
            AppSettings.GamersList.Add(newgamer)
            ComboBoxNameGamer.Items.Add(newgamer)
        End If
        Trace("The gamer is : " & newgamer)
        AppSettings.LastGamer = newgamer

        Me.Hide()
        Game.Show()
    End Sub

    Private Sub ToolStripMenuItemTrace_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemTrace.Click
        ToolStripMenuItemTrace.Checked = Not ToolStripMenuItemTrace.Checked

        TextBoxTrace.Visible = ToolStripMenuItemTrace.Checked
        AppSettings.ActiveTrace = ToolStripMenuItemTrace.Checked

        If (TextBoxTrace.Visible) Then
            Me.Height += TextBoxTrace.Height
        Else
            Me.Height -= TextBoxTrace.Height
        End If

    End Sub
    Public Sub Trace(TheTrace As String)
        Dim trace As String = GameLuncher.TraceFile(TheTrace)
        If (Not ToolStripMenuItemTrace.Checked) Then
            Return
        End If

        TextBoxTrace.Text += trace & vbNewLine
        TextBoxTrace.SelectionStart = TextBoxTrace.TextLength - 1
        TextBoxTrace.ScrollToCaret()

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Trace("Form1 closed")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Trace("load form1")
        ComboBoxNameGamer.Text = AppSettings.LastGamer
        Me.ToolStripMenuItemTrace.Checked = AppSettings.ActiveTrace

        For Each gamer As String In AppSettings.GamersList
            ComboBoxNameGamer.Items.Add(gamer)
        Next

        Trace("load form1 finish")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        If MsgBox("Etes-vous sûr de quitter le jeu ?", MsgBoxStyle.YesNo, "Exit Game") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        TraceFile("Form1 Shown")

        TextBoxTrace.Visible = ToolStripMenuItemTrace.Checked

        If Not TextBoxTrace.Visible Then
            Me.Height -= TextBoxTrace.Height
        End If
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSettings.Click
        FormSettings.Show()
    End Sub

End Class