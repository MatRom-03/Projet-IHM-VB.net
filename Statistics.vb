Public Class Statistics

    Private Sub Statistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each name As String In AppSettings.GamersList
            ListBoxStats.Items.Add(name)
        Next
    End Sub
End Class