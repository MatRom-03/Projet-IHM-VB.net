Module GameLauncher
    Public AppSettings As Settings = New Settings
    Public Sub Main()
        AppSettings.Load()
        Application.Run(Launcher)
        AppSettings.save()
    End Sub
    Public Function TraceFile(TheTrace As String)

        Dim TraceDate As Date = Date.Now
        Dim trace As String
        Dim file As IO.StreamWriter = FileIO.FileSystem.OpenTextFileWriter(Application.StartupPath & "\Demineur.txt", True)

        trace = TraceDate.ToShortDateString & " - " & TraceDate.ToLongTimeString & " : "
        trace += TheTrace

        file.WriteLine(trace)
        file.Close()
        Return trace
    End Function
End Module
