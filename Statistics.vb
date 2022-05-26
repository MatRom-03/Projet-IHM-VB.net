Public Class Statistics

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppSettings.GamersList.Sort(AddressOf DataGamer.CompareByCellDiscoveredMaxAscending)
        DisplayList()
        If AppSettings.Darkmode Then
            GameLauncher.SetThemeDark(Me)
        Else
            GameLauncher.SetThemeWhite(Me)
        End If
        FoundGamer(AppSettings.LastGamer)
        ComboBoxNameGamer.Text = AppSettings.LastGamer
        For Each gamer As DataGamer In AppSettings.GamersList
            ComboBoxNameGamer.Items.Add(gamer.name)
        Next
    End Sub

    Private Sub ButtonSort_Click(sender As Object, e As EventArgs) Handles ButtonSort.Click
        If ButtonSort.Text = "↑" Then
            ButtonSort.Text = "↓"
            AppSettings.GamersList.Sort(AddressOf DataGamer.CompareByCellDiscoveredMaxDescending)
        Else
            ButtonSort.Text = "↑"
            AppSettings.GamersList.Sort(AddressOf DataGamer.CompareByCellDiscoveredMaxAscending)
        End If
        DisplayList()
    End Sub

    Private Sub DisplayList()
        ListBoxStats.Items.Clear()

        For Each gamer As DataGamer In AppSettings.GamersList
            ListBoxStats.Items.Add(gamer.name & ", " & gamer.CellDiscoveredMax & " cases révélées en " & gamer.TimeGame & " sec.")
        Next
    End Sub

    Private Sub ComboBoxNameGamer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNameGamer.SelectedIndexChanged
        FoundGamer(ComboBoxNameGamer.Text)
    End Sub

    Private Sub UpdateDataGamer(Gamer As DataGamer)
        Dim Stats As String = ""
        Stats += "Nom : " & Gamer.name & vbNewLine
        Stats += "Meilleur nombre de cases révélées : " & Gamer.CellDiscoveredMax & " cases en " & Gamer.TimeGame & " sec." & vbNewLine
        Stats += "Temps de parties cumulés : " & Gamer.TimeCount & " sec." & vbNewLine
        Stats += "Nombre de parties : " & Gamer.GameCount & " parties." & vbNewLine
        Label1.Text = Stats
    End Sub

    Private Sub ListBoxStats_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxStats.SelectedIndexChanged
        FoundGamer(ListBoxStats.Text.Split(",")(0))
    End Sub

    Private Sub FoundGamer(GamerName As String)
        Dim ChosenGamer As DataGamer
        Dim bFound As Boolean = False
        For Each gamer As DataGamer In AppSettings.GamersList

            If (String.Compare(gamer.name, GamerName, True) = 0) Then
                bFound = True
                ChosenGamer = gamer
                Exit For
            End If
        Next

        If (Not bFound) Then
            Return
        End If
        UpdateDataGamer(ChosenGamer)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Statistics_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Launcher.Show()
    End Sub
End Class