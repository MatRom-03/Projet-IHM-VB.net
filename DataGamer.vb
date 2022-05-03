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
End Class
