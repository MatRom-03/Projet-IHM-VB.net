Public Class DataGamer
    Public name As String
    Public CellDiscoveredMax As Integer
    Public TimeGame As Integer
    Public GameCount As Integer
    Public TimeCount As Integer

    Sub New(name As String)
        Me.New(name, 0, 0, 0, 0)
    End Sub

    Sub New(name As String, CellDiscoveredCount As Integer, TimeGame As Integer, GameCount As Integer, TimeCount As Integer)
        Me.name = name
        Me.CellDiscoveredMax = CellDiscoveredCount
        Me.TimeGame = TimeGame
        Me.GameCount = GameCount
        Me.TimeCount = TimeCount
    End Sub

    Public Shared Function CompareByCellDiscoveredMaxAscending(Max1 As DataGamer, Max2 As DataGamer)
        If Max2.CellDiscoveredMax.CompareTo(Max1.CellDiscoveredMax) <> 0 Then
            Return Max2.CellDiscoveredMax.CompareTo(Max1.CellDiscoveredMax)
        End If
        Return Max1.TimeGame.CompareTo(Max2.TimeGame)
    End Function

    Public Shared Function CompareByCellDiscoveredMaxDescending(Max1 As DataGamer, Max2 As DataGamer)
        If Max1.CellDiscoveredMax.CompareTo(Max2.CellDiscoveredMax) <> 0 Then
            Return Max1.CellDiscoveredMax.CompareTo(Max2.CellDiscoveredMax)
        End If
        Return Max2.TimeGame.CompareTo(Max1.TimeGame)
    End Function


End Class
