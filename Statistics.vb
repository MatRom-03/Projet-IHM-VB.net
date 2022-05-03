Public Class Statistics

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each gamer As DataGamer In AppSettings.GamersList
            ListBoxStats.Items.Add(gamer.name & ", " & gamer.CellDiscoveredMax & " cases révélées, " & gamer.TimeGame & " sec.")
        Next
    End Sub
End Class