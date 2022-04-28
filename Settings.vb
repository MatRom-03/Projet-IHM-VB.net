Imports System.Xml
Public Class Settings
    Public XmlSettings As XmlDocument = New XmlDocument()
    Public ActiveTrace As Boolean
    Public LastGamer As String
    Public ColumnsCount As Integer = 8
    Public LinesCount As Integer = 8
    Public MinesCount = 10
    Public GamersList As List(Of String) = New List(Of String)

    Public Sub Load()
        Try

            XmlSettings.Load(Application.StartupPath & "\Demineur.xml")

            Dim NodesList As XmlNodeList = XmlSettings.GetElementsByTagName("EnableTraces")
            For Each Node As XmlNode In NodesList

                If (Not Boolean.TryParse(Node.InnerText, ActiveTrace)) Then
                    ActiveTrace = False
                End If
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("LastGamer")
            For Each Node As XmlNode In NodesList

                LastGamer = Node.InnerText
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("ColumnsCount")
            For Each Node As XmlNode In NodesList

                ColumnsCount = Node.InnerText
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("LinesCount")
            For Each Node As XmlNode In NodesList

                LinesCount = Node.InnerText
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("MinesCount")
            For Each Node As XmlNode In NodesList

                MinesCount = Node.InnerText
                Exit For

            Next

            NodesList = XmlSettings.GetElementsByTagName("Gamer")
            For Each Node As XmlNode In NodesList

                GamersList.Add(Node.InnerText)

            Next


        Catch ex As Exception
            TraceFile("No xml file found, assume default settings values")

            ActiveTrace = False

        End Try
        TraceFile("Settings loading complete")
    End Sub

    Public Sub save()
        Try

            XmlSettings.RemoveAll()

            Dim declarationElement As XmlDeclaration = XmlSettings.CreateXmlDeclaration("1.0", "UTF-8", Nothing)
            XmlSettings.AppendChild(declarationElement)

            Dim rootElement As XmlElement = XmlSettings.CreateElement("Settings")
            XmlSettings.AppendChild(rootElement)

            Dim enableTracesElement As XmlElement = XmlSettings.CreateElement("EnableTraces")
            enableTracesElement.InnerText = ActiveTrace
            rootElement.AppendChild(enableTracesElement)

            Dim LastGamerElement As XmlElement = XmlSettings.CreateElement("LastGamer")
            LastGamerElement.InnerText = LastGamer
            rootElement.AppendChild(LastGamerElement)

            Dim ColumnsCountElement As XmlElement = XmlSettings.CreateElement("ColumnsCount")
            ColumnsCountElement.InnerText = ColumnsCount
            rootElement.AppendChild(ColumnsCountElement)

            Dim LinesCountElement As XmlElement = XmlSettings.CreateElement("LinesCount")
            LinesCountElement.InnerText = LinesCount
            rootElement.AppendChild(LinesCountElement)

            Dim MinesCountElement As XmlElement = XmlSettings.CreateElement("MinesCount")
            MinesCountElement.InnerText = MinesCount
            rootElement.AppendChild(MinesCountElement)


            Dim gamersElement As XmlElement = XmlSettings.CreateElement("Gamers")
            rootElement.AppendChild(gamersElement)

            For Each gamer As String In GamersList

                Dim gamerElement As XmlElement = XmlSettings.CreateElement("Gamer")
                gamerElement.InnerText = gamer
                gamersElement.AppendChild(gamerElement)

            Next


            XmlSettings.Save(Application.StartupPath & "\Demineur.xml")


        Catch ex As Exception

            TraceFile("Impossible to write xml file")

        End Try
        TraceFile("Settings backup done")
    End Sub

End Class
