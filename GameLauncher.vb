Imports System.IO
Imports System.Security.Cryptography

Module GameLauncher
    Public AppSettings As Settings = New Settings
    Public Sub Main()
        AppSettings.Load()
        Application.Run(Launcher)
        AppSettings.save()
    End Sub

    Public Sub SetThemeDark(Form As Form)
        Form.BackColor = Color.Black
        For Each comp As Control In Form.Controls
            comp.ForeColor = Color.FromArgb(61, 170, 255)
            comp.BackColor = Color.Black
        Next
    End Sub

    Public Sub SetThemeWhite(Form As Form)
        Form.BackColor = System.Drawing.SystemColors.AppWorkspace
        For Each comp As Control In Form.Controls
            comp.ForeColor = Color.Black
            comp.BackColor = System.Drawing.SystemColors.AppWorkspace
        Next
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
